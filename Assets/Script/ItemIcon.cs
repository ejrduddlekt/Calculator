using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemIcon : MonoBehaviour
{
    public TextMeshProUGUI text_PurchaseConfirmationDate;
    public TextMeshProUGUI text_ProductNumber;
    public TextMeshProUGUI text_TotalOrderAmountPerProduct;
    public TextMeshProUGUI text_TotalDeliveryFee;
    public TextMeshProUGUI text_ProductCost;
    public TextMeshProUGUI text_Platform;

    public TextMeshProUGUI text_TotalProfit;
    public ProfitData profitData;

    public int UpdateTotalProfit
    {
        get { return int.Parse(profitData.TotalProfit); }
        set 
        {
            profitData.TotalProfit = value.ToString();
            text_TotalProfit.text = value.ToString(); 
        }
    }

    public ProfitData TotalProfitValue
    {
        get { return profitData; }
        set
        {
            profitData = value;
            text_Platform.text = value.orderPlatform.ToString();
            text_PurchaseConfirmationDate.text = DateTime.Parse(value.PurchaseConfirmationDate).ToString("yy.MM.dd");
            text_ProductNumber.text = value.ProductNumber;
            text_TotalOrderAmountPerProduct.text = value.TotalOrderAmountPerProduct;
            text_TotalDeliveryFee.text = value.TotalDeliveryFee;
            text_ProductCost.text = value.productCostData;
            text_TotalProfit.text = value.TotalProfit?? "No data";

            switch (value.orderPlatform)
            {
                case Platform.Naver: text_Platform.color = Color.green; break;
                case Platform.ZigZag: text_Platform.color = Color.grey; break;
            }
        }
    }
}
