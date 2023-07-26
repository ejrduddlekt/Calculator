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
            totalProfit_Text.text = totalProfit.ToString("C0"); // �ѱ� ��ȭ �������� ǥ��
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
        // ����Ʈ�� ����Ʈ�� �ڽ� ���� ������Ʈ���� �����մϴ�.
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

            // �� Ű�� �ش��ϴ� ������ ����Ʈ�� �����ϴ��� Ȯ��
            if (dataContainer != null && dataContainer.Count > 0)
            {
                // ������ ����Ʈ�� ������ŭ �������� �����Ͽ� content�� �ڽ����� �߰�
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
                        (int.Parse(naverData.TotalDeliveryFee) == 0 ? 3000 : int.Parse(naverData.TotalDeliveryFee)).ToString(),  //��ۺ�
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

            // �� Ű�� �ش��ϴ� ������ ����Ʈ�� �����ϴ��� Ȯ��
            if (dataContainer != null && dataContainer.Count > 0)
            {
                // ������ ����Ʈ�� ������ŭ �������� �����Ͽ� content�� �ڽ����� �߰�
                foreach (var zigzagData in dataContainer)
                {
                    GameObject newItem = Instantiate(itemPrefab, content);
                    itemList.Add(newItem);

                    // ���� ����
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
        // ���ڿ����� '��'�� '\' �ؽ�Ʈ�� �����Ͽ� ��ȯ
        string removedWon = amountText.Replace("��", "").Trim();
        return removedWon.Replace("\\", "").Trim();
    }
}
