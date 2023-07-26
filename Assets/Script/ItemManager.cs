using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject itemPrefab;
    public DataContainer itemContainer = new DataContainer();

    public List<GameObject> itemList = new List<GameObject>();
    public List<ProfitData> TotalProfit = new List<ProfitData>();

    public Transform content;

    int totalProfit = 0;
    public TextMeshProUGUI totalProfit_Text;

    public int TotalProfitValue
    {
        get { return totalProfit; }
        set
        {
            totalProfit = value;
            totalProfit_Text.text = totalProfit.ToString("C0"); // 한국 원화 형식으로 표시
        }
    }

    public void UpdateData()
    {
        itemContainer.NaverOrderDataContainer.Clear();
        itemContainer.ZigZagOrderDataContainer.Clear();
        itemContainer.productCostData.Clear();
        itemContainer.NaverOrderDataContainer = GetComponent<CSVParser>().CreateNaverResource();
        itemContainer.ZigZagOrderDataContainer = GetComponent<CSVParser>().CreateZigZagNaverResource();
        itemContainer.productCostData = GetComponent<CSVParser>().CreateProductCostData();
    }

    public void ClearContent()
    {
        // 리스트와 콘텐트의 자식 게임 오브젝트들을 삭제합니다.
        itemList.Clear();
        foreach (Transform child in content)
        {
            Destroy(child.gameObject);
        }
        TotalProfitValue = 0;
    }

    public void NaverDataViewUpdate()
    {
        foreach (var key in itemContainer.NaverOrderDataContainer.Keys)
        {
            List<NaverOrderResource> dataContainer = itemContainer.NaverOrderDataContainer[key];

            // 각 키에 해당하는 아이템 리스트가 존재하는지 확인
            if (dataContainer != null && dataContainer.Count > 0)
            {
                // 아이템 리스트의 갯수만큼 아이템을 생성하여 content의 자식으로 추가
                foreach (var naverData in dataContainer)
                {
                    GameObject newItem = Instantiate(itemPrefab, content);
                    itemList.Add(newItem);

                    string productCost;

                    if (itemContainer.productCostData.TryGetValue(naverData.ProductNumber, out ProductCostData productCostData))
                        productCost = productCostData.productCost;
                    else
                        productCost = "No Data";
                    
                    var _profitData = new ProfitData(
                        Platform.Naver, 
                        naverData.PurchaseConfirmationDate, 
                        naverData.ProductNumber, 
                        naverData.TotalOrderAmountPerProduct, 
                        (int.Parse(naverData.TotalDeliveryFee) == 0 ? 3000 : int.Parse(naverData.TotalDeliveryFee)).ToString(),  //배송비
                        "0",
                        productCost
                        );

                    TotalProfit.Add(_profitData);
                    newItem.GetComponent<ItemIcon>().TotalProfitValue = _profitData;
                }
            }
        }
        Calculator();
    }



    public void ZigZagViewUpdate()
    {
        foreach (var key in itemContainer.ZigZagOrderDataContainer.Keys)
        {
            List<ZigzagOrderResource> dataContainer = itemContainer.ZigZagOrderDataContainer[key];

            // 각 키에 해당하는 아이템 리스트가 존재하는지 확인
            if (dataContainer != null && dataContainer.Count > 0)
            {
                // 아이템 리스트의 갯수만큼 아이템을 생성하여 content의 자식으로 추가
                foreach (var zigzagData in dataContainer)
                {
                    GameObject newItem = Instantiate(itemPrefab, content);
                    itemList.Add(newItem);

                    // 원가 빼기
                    string productCost;
                    if (itemContainer.productCostData.TryGetValue(zigzagData.ProductNumber, out ProductCostData productCostData))
                        productCost = productCostData.productCost;
                    else
                        productCost = "No Data";


                    //TotalProfitValue += _profit;
                    var _profitData = new ProfitData(
                        Platform.ZigZag, 
                        zigzagData.PurchaseConfirmationDate, 
                        zigzagData.ProductNumber, 
                        zigzagData.ProductOrderAmount,
                        (int.Parse(zigzagData.TotalDeliveryFee) == 0 ? 3000 : int.Parse(zigzagData.TotalDeliveryFee)) + " / " + zigzagData.StoreBearsAmount,
                        zigzagData.StoreBearsAmount,
                        productCost
                        );

                    TotalProfit.Add(_profitData);
                    newItem.GetComponent<ItemIcon>().TotalProfitValue = _profitData;
                }
            }
        }
        Calculator();
    }

    public void Calculator()
    {
        totalProfit = 0;
        foreach (var item in itemList)
        {
            var data = item.GetComponent<ItemIcon>().TotalProfitValue;

            int.TryParse(data.TotalOrderAmountPerProduct, out int orderAmountPerProduct);
            int.TryParse(data.TotalDeliveryFee, out int deliveryFee);
            int.TryParse(data.etc, out int etc);
            int productCostData = int.TryParse(data.productCostData, out int parsedCost) ? parsedCost : 0;

            item.GetComponent<ItemIcon>().UpdateTotalProfit = orderAmountPerProduct - deliveryFee - etc - productCostData;

            TotalProfitValue += item.GetComponent<ItemIcon>().UpdateTotalProfit;
        }
    }

    public void CreateCSV()
    {
        List<string> costList = new List<string>();
        for (int i = 0; i < TotalProfit.Count; i++)
        {
            if (itemContainer.productCostData.TryGetValue(TotalProfit[i].ProductNumber, out ProductCostData productCostData))
            {
                costList.Add(productCostData.productCost);

            }
            else
            {
                costList.Add("No Data");
            }

        }

        GetComponent<CSVParser>().CreateCSVFile(TotalProfit, costList);
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    public static string RemoveWonAndBackslash(string amountText)
    {
        // 문자열에서 '원'과 '\' 텍스트를 제거하여 반환
        string removedWon = amountText.Replace("원", "").Trim();
        return removedWon.Replace("\\", "").Trim();
    }
}
