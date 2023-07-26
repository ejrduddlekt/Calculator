using System;

[Serializable]
public struct NaverOrderResource
{
    public string PurchaseOrderNumber;             // (1) (A) ��ǰ�ֹ���ȣ
    public string OrderNumber;                     // (2) (B) �ֹ���ȣ
    public string PurchaseConfirmationDate;        // (3) (C) ����Ȯ����
    public string SalesChannel;                    // (4) (D) �Ǹ�ä��
    public string OrderStatus;                     // (5) (E) �ֹ�����
    public string ShippingAttribute;               // (6) (F) ��ۼӼ�
    public string FulfillmentCompany;              // (7) (G) Ǯ�ʸ�Ʈ��
    public string BuyerName;                       // (8) (H) �����ڸ�
    public string BuyerID;                         // (9) (I) ������ ID
    public string RecipientName;                   // (10) (J) �����θ�
    public string DispatchProcessingDate;          // (11) (K) �߼�ó����
    public string DeliveryMethod;                  // (12) (L) ��۹��
    public string CourierCompany;                  // (13) (M) �ù��
    public string TrackingNumber;                  // (14) (N) �����ȣ
    public string DeliveryCompletionDate;          // (15) (O) ��ۿϷ���
    public string ProductNumber;                   // (16) (P) ��ǰ��ȣ
    public string ProductName;                     // (17) (Q) ��ǰ��
    public string ProductType;                     // (18) (R) ��ǰ����
    public string ReturnCare;                      // (19) (S) ��ǰ�Ƚ��ɾ�
    public string OptionInfo;                      // (20) (T) �ɼ�����
    public string OptionManagementCode;            // (21) (U) �ɼǰ����ڵ�
    public string Quantity;                        // (22) (V) ����
    public string ProductPrice;                    // (23) (W) ��ǰ����
    public string OptionPrice;                     // (24) (X) �ɼǰ���
    public string ProductDiscount;                 // (25) (Y) ��ǰ�� ���ξ�
    public string SellerBearsDiscount;             // (26) (Z) �Ǹ��� �δ� ���ξ�
    public string TotalOrderAmountPerProduct;      // (27) (AA) ��ǰ�� �� �ֹ��ݾ�
    public string SellerProductCode;               // (28) (AB) �Ǹ��� ��ǰ�ڵ�
    public string SellerInternalCode1;             // (29) (AC) �Ǹ��� �����ڵ�1
    public string SellerInternalCode2;             // (30) (AD) �Ǹ��� �����ڵ�2
    public string DeliveryBundleNumber;            // (31) (AE) ��ۺ� ������ȣ
    public string DeliveryFeeType;                 // (32) (AF) ��ۺ� ����
    public string DeliveryFeeCategory;             // (33) (AG) ��ۺ� ����
    public string TotalDeliveryFee;                // (34) (AH) ��ۺ� �հ�
    public string JejuIslandAndRemoteAreaSurcharge; // (35) (AI) ����/���� �߰���ۺ�
    public string DeliveryFeeDiscount;             // (36) (AJ) ��ۺ� ���ξ�
    public string PaymentDate;                     // (37) (AK) ������
    public string PaymentMethod;                   // (38) (AL) ��������
    public string PaymentLocation;                 // (39) (AM) ������ġ
    public string CommissionChargeType;            // (40) (AN) ������ ���ݱ���
    public string CommissionPaymentMethod;         // (41) (AO) ������������
    public string NaverPayOrderManagementCommission; // (42) (AP) ���̹����� �ֹ����� ������
    public string SalesIntegrationCommission;      // (43) (AQ) ���⿬�� ������
    public string EstimatedSettlementAmount;       // (44) (AR) ���꿹���ݾ�
    public string SalesIntegrationCommissionInflowPath; // (45) (AS) ���⿬�������� ���԰��

    public NaverOrderResource(string purchaseOrderNumber, string orderNumber, string purchaseConfirmationDate, string salesChannel,
                     string orderStatus, string shippingAttribute, string fulfillmentCompany, string buyerName, string buyerID,
                     string recipientName, string dispatchProcessingDate, string deliveryMethod, string courierCompany,
                     string trackingNumber, string deliveryCompletionDate, string productNumber, string productName,
                     string productType, string returnCare, string optionInfo, string optionManagementCode, string quantity,
                     string productPrice, string optionPrice, string productDiscount, string sellerBearsDiscount,
                     string totalOrderAmountPerProduct, string sellerProductCode, string sellerInternalCode1,
                     string sellerInternalCode2, string deliveryBundleNumber, string deliveryFeeType, string deliveryFeeCategory,
                     string totalDeliveryFee, string jejuIslandAndRemoteAreaSurcharge, string deliveryFeeDiscount,
                     string paymentDate, string paymentMethod, string paymentLocation, string commissionChargeType,
                     string commissionPaymentMethod, string naverPayOrderManagementCommission, string salesIntegrationCommission,
                     string estimatedSettlementAmount, string salesIntegrationCommissionInflowPath)
    {
        PurchaseOrderNumber = purchaseOrderNumber;
        OrderNumber = orderNumber;
        PurchaseConfirmationDate = purchaseConfirmationDate;
        SalesChannel = salesChannel;
        OrderStatus = orderStatus;
        ShippingAttribute = shippingAttribute;
        FulfillmentCompany = fulfillmentCompany;
        BuyerName = buyerName;
        BuyerID = buyerID;
        RecipientName = recipientName;
        DispatchProcessingDate = dispatchProcessingDate;
        DeliveryMethod = deliveryMethod;
        CourierCompany = courierCompany;
        TrackingNumber = trackingNumber;
        DeliveryCompletionDate = deliveryCompletionDate;
        ProductNumber = productNumber;
        ProductName = productName;
        ProductType = productType;
        ReturnCare = returnCare;
        OptionInfo = optionInfo;
        OptionManagementCode = optionManagementCode;
        Quantity = quantity;
        ProductPrice = productPrice;
        OptionPrice = optionPrice;
        ProductDiscount = productDiscount;
        SellerBearsDiscount = sellerBearsDiscount;
        TotalOrderAmountPerProduct = totalOrderAmountPerProduct;
        SellerProductCode = sellerProductCode;
        SellerInternalCode1 = sellerInternalCode1;
        SellerInternalCode2 = sellerInternalCode2;
        DeliveryBundleNumber = deliveryBundleNumber;
        DeliveryFeeType = deliveryFeeType;
        DeliveryFeeCategory = deliveryFeeCategory;
        TotalDeliveryFee = totalDeliveryFee;
        JejuIslandAndRemoteAreaSurcharge = jejuIslandAndRemoteAreaSurcharge;
        DeliveryFeeDiscount = deliveryFeeDiscount;
        PaymentDate = paymentDate;
        PaymentMethod = paymentMethod;
        PaymentLocation = paymentLocation;
        CommissionChargeType = commissionChargeType;
        CommissionPaymentMethod = commissionPaymentMethod;
        NaverPayOrderManagementCommission = naverPayOrderManagementCommission;
        SalesIntegrationCommission = salesIntegrationCommission;
        EstimatedSettlementAmount = estimatedSettlementAmount;
        SalesIntegrationCommissionInflowPath = salesIntegrationCommissionInflowPath;
    }
}

[Serializable]
public struct ZigzagOrderResource
{
    public string StoreName;                // (1) (A) ������
    public string PurchaseOrderNumber;      // (2) (B) ��ǰ�ֹ���ȣ
    public string OrderNumber;              // (3) (C) �ֹ���ȣ
    public string PurchaseConfirmationDate; // (4) (D) ����Ȯ����
    public string BuyerName;                // (5) (E) �����ڸ�
    public string BuyerID;                  // (6) (F) ������ ID
    public string BuyerContact;             // (7) (G) ������ ����ó
    public string OrderStatus;              // (8) (H) �ֹ�����
    public string OrderDateTime;            // (9) (I) �ֹ��Ͻ�
    public string ProductCode;              // (10) (J) ��ǰ�ڵ�
    public string CustomProductCode;        // (11) (K) ��ü��ǰ�ڵ�
    public string ProductName;              // (12) (L) ��ǰ��
    public string ItemCode;                 // (13) (M) ǰ���ڵ�
    public string CustomItemCode;           // (14) (N) ��üǰ���ڵ�
    public string OptionInfo;               // (15) (O) �ɼ�����
    public string SalePrice;                // (16) (P) �ǸŰ�
    public string ProductDiscount;          // (17) (Q) ��ǰ ���ξ�
    public string ProductPrice;             // (18) (R) ��ǰ����
    public string Quantity;                 // (19) (S) ����
    public string ProductOrderAmount;       // (20) (T) ��ǰ�ֹ���
    public string CouponDiscountAmount;     // (21) (U) ���� ���� �ݾ�
    public string StoreBearsAmount;         // (22) (V) ����� �δ� �ݾ�
    public string DeliveryFeeType;          // (23) (W) ��ۺ�����
    public string TotalDeliveryFee;         // (24) (X) �� ��ۺ�
    public string DeliveryFee;              // (25) (Y) ��ۺ�
    public string ReturnDeliveryFee;        // (26) (Z) ��ǰ��ۺ�
    public string JejuIslandRemoteAreaFee;  // (27) (AA) ���ֵ����߰���ۺ�
    public string RecipientName;            // (28) (AB) �����θ�
    public string RecipientContact;         // (29) (AC) ������ ����ó
    public string DeliveryAddress;          // (30) (AD) ����� �ּ�
    public string PostalCode;               // (31) (AE) �����ȣ
    public string DeliveryMessage;          // (32) (AF) ��� �޼���
    public string DeliveryCompletionDate;   // (33) (AG) ��� �Ϸ���
    public string PaymentMethod;            // (34) (AH) ���� ����
    public string ProductNumber;            // (35) (AI) ��ǰ��ȣ
    public string ChannelClassification;    // (36) (AJ) ä�κз�

    public ZigzagOrderResource(string storeName, string purchaseOrderNumber, string orderNumber,
        string purchaseConfirmationDate, string buyerName, string buyerID, string buyerContact,
        string orderStatus, string orderDateTime, string productCode, string customProductCode,
        string productName, string itemCode, string customItemCode, string optionInfo,
        string salePrice, string productDiscount, string productPrice, string quantity,
        string productOrderAmount, string couponDiscountAmount, string storeBearsAmount,
        string deliveryFeeType, string totalDeliveryFee, string deliveryFee, string returnDeliveryFee,
        string jejuIslandRemoteAreaFee, string recipientName, string recipientContact,
        string deliveryAddress, string postalCode, string deliveryMessage,
        string deliveryCompletionDate, string paymentMethod, string productNumber, string channelClassification)
    {
        StoreName = storeName;                              // (1) (A) ������
        PurchaseOrderNumber = purchaseOrderNumber;          // (2) (B) ��ǰ�ֹ���ȣ
        OrderNumber = orderNumber;                          // (3) (C) �ֹ���ȣ
        PurchaseConfirmationDate = purchaseConfirmationDate; // (4) (D) ����Ȯ����
        BuyerName = buyerName;                              // (5) (E) �����ڸ�
        BuyerID = buyerID;                                  // (6) (F) ������ ID
        BuyerContact = buyerContact;                        // (7) (G) ������ ����ó
        OrderStatus = orderStatus;                          // (8) (H) �ֹ�����
        OrderDateTime = orderDateTime;                      // (9) (I) �ֹ��Ͻ�
        ProductCode = productCode;                          // (10) (J) ��ǰ�ڵ�
        CustomProductCode = customProductCode;              // (11) (K) ��ü��ǰ�ڵ�
        ProductName = productName;                          // (12) (L) ��ǰ��
        ItemCode = itemCode;                                // (13) (M) ǰ���ڵ�
        CustomItemCode = customItemCode;                    // (14) (N) ��üǰ���ڵ�
        OptionInfo = optionInfo;                            // (15) (O) �ɼ�����
        SalePrice = salePrice;                              // (16) (P) �ǸŰ�
        ProductDiscount = productDiscount;                  // (17) (Q) ��ǰ ���ξ�
        ProductPrice = productPrice;                        // (18) (R) ��ǰ����
        Quantity = quantity;                                // (19) (S) ����
        ProductOrderAmount = productOrderAmount;            // (20) (T) ��ǰ�ֹ���
        CouponDiscountAmount = couponDiscountAmount;        // (21) (U) ���� ���� �ݾ�
        StoreBearsAmount = storeBearsAmount;                // (22) (V) ����� �δ� �ݾ�
        DeliveryFeeType = deliveryFeeType;                  // (23) (W) ��ۺ�����
        TotalDeliveryFee = totalDeliveryFee;                // (24) (X) �� ��ۺ�
        DeliveryFee = deliveryFee;                          // (25) (Y) ��ۺ�
        ReturnDeliveryFee = returnDeliveryFee;              // (26) (Z) ��ǰ��ۺ�
        JejuIslandRemoteAreaFee = jejuIslandRemoteAreaFee;  // (27) (AA) ���ֵ����߰���ۺ�
        RecipientName = recipientName;                      // (28) (AB) �����θ�
        RecipientContact = recipientContact;                // (29) (AC) ������ ����ó
        DeliveryAddress = deliveryAddress;                  // (30) (AD) ����� �ּ�
        PostalCode = postalCode;                            // (31) (AE) �����ȣ
        DeliveryMessage = deliveryMessage;                  // (32) (AF) ��� �޼���
        DeliveryCompletionDate = deliveryCompletionDate;    // (33) (AG) ��� �Ϸ���
        PaymentMethod = paymentMethod;                      // (34) (AH) ���� ����
        ProductNumber = productNumber;                      // (35) (AI) ��ǰ��ȣ
        ChannelClassification = channelClassification;      // (36) (AJ) ä�κз�
    }
}


public struct ProfitData
{
    public Platform orderPlatform;              //�÷���
    public string PurchaseConfirmationDate;     //����Ȯ����
    public string ProductNumber;                //��ǰ��ȣ
    public string TotalOrderAmountPerProduct;   //�ǸŰ�
    public string TotalDeliveryFee;             //��ۺ�
    public string etc;                          //�Ǹ��ںδ��
    public string productCostData;              //��ǰ����
    public string TotalProfit;                  //���ͱ�


    public ProfitData(Platform _Platform, 
        string _PurchaseConfirmationDate, 
        string _ProductNumber, 
        string _TotalOrderAmountPerProduct, 
        string _TotalDeliveryFee, 
        string _etc,
        string _productCostData, 
        string _TotalProfit = null)
    {
        orderPlatform = _Platform;                              //�÷���
        PurchaseConfirmationDate = _PurchaseConfirmationDate;   //����Ȯ����
        ProductNumber = _ProductNumber;                         //��ǰ��ȣ
        TotalOrderAmountPerProduct = _TotalOrderAmountPerProduct; //�ǸŰ�
        TotalDeliveryFee = _TotalDeliveryFee;                   //��ۺ�
        etc = _etc;                                             //�Ǹ��ںδ��
        productCostData = _productCostData;                     //��ǰ����
        TotalProfit = _TotalProfit ?? "";                       //���ͱ�
    }
}

public struct ProductCostData
{
    public Platform orderPlatform;
    public string productCode;
    public string productName;
    public string productCost;

    public ProductCostData(string _orderPlatform, string _productCode, string _productName, string _productCost)
    {
        // Convert the string orderPlatform to the Platform enum using Enum.TryParse
        if (Enum.TryParse(_orderPlatform, out Platform platform))
        {
            this.orderPlatform = platform;
        }
        else
        {
            // If the provided platform string is not valid, set a default value (e.g., Naver)
            this.orderPlatform = Platform.Naver;
        }

        this.productCode = _productCode;
        this.productName = _productName;
        this.productCost = _productCost;
    }
}

public enum Platform
{
    Naver,
    ZigZag,
}
