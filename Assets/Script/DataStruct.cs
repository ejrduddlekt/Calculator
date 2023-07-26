using System;

[Serializable]
public struct NaverOrderResource
{
    public string PurchaseOrderNumber;             // (1) (A) 상품주문번호
    public string OrderNumber;                     // (2) (B) 주문번호
    public string PurchaseConfirmationDate;        // (3) (C) 구매확정일
    public string SalesChannel;                    // (4) (D) 판매채널
    public string OrderStatus;                     // (5) (E) 주문상태
    public string ShippingAttribute;               // (6) (F) 배송속성
    public string FulfillmentCompany;              // (7) (G) 풀필먼트사
    public string BuyerName;                       // (8) (H) 구매자명
    public string BuyerID;                         // (9) (I) 구매자 ID
    public string RecipientName;                   // (10) (J) 수령인명
    public string DispatchProcessingDate;          // (11) (K) 발송처리일
    public string DeliveryMethod;                  // (12) (L) 배송방법
    public string CourierCompany;                  // (13) (M) 택배사
    public string TrackingNumber;                  // (14) (N) 송장번호
    public string DeliveryCompletionDate;          // (15) (O) 배송완료일
    public string ProductNumber;                   // (16) (P) 상품번호
    public string ProductName;                     // (17) (Q) 상품명
    public string ProductType;                     // (18) (R) 상품종류
    public string ReturnCare;                      // (19) (S) 반품안심케어
    public string OptionInfo;                      // (20) (T) 옵션정보
    public string OptionManagementCode;            // (21) (U) 옵션관리코드
    public string Quantity;                        // (22) (V) 수량
    public string ProductPrice;                    // (23) (W) 상품가격
    public string OptionPrice;                     // (24) (X) 옵션가격
    public string ProductDiscount;                 // (25) (Y) 상품별 할인액
    public string SellerBearsDiscount;             // (26) (Z) 판매자 부담 할인액
    public string TotalOrderAmountPerProduct;      // (27) (AA) 상품별 총 주문금액
    public string SellerProductCode;               // (28) (AB) 판매자 상품코드
    public string SellerInternalCode1;             // (29) (AC) 판매자 내부코드1
    public string SellerInternalCode2;             // (30) (AD) 판매자 내부코드2
    public string DeliveryBundleNumber;            // (31) (AE) 배송비 묶음번호
    public string DeliveryFeeType;                 // (32) (AF) 배송비 형태
    public string DeliveryFeeCategory;             // (33) (AG) 배송비 유형
    public string TotalDeliveryFee;                // (34) (AH) 배송비 합계
    public string JejuIslandAndRemoteAreaSurcharge; // (35) (AI) 제주/도서 추가배송비
    public string DeliveryFeeDiscount;             // (36) (AJ) 배송비 할인액
    public string PaymentDate;                     // (37) (AK) 결제일
    public string PaymentMethod;                   // (38) (AL) 결제수단
    public string PaymentLocation;                 // (39) (AM) 결제위치
    public string CommissionChargeType;            // (40) (AN) 수수료 과금구분
    public string CommissionPaymentMethod;         // (41) (AO) 수수료결제방식
    public string NaverPayOrderManagementCommission; // (42) (AP) 네이버페이 주문관리 수수료
    public string SalesIntegrationCommission;      // (43) (AQ) 매출연동 수수료
    public string EstimatedSettlementAmount;       // (44) (AR) 정산예정금액
    public string SalesIntegrationCommissionInflowPath; // (45) (AS) 매출연동수수료 유입경로

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
    public string StoreName;                // (1) (A) 스토어명
    public string PurchaseOrderNumber;      // (2) (B) 상품주문번호
    public string OrderNumber;              // (3) (C) 주문번호
    public string PurchaseConfirmationDate; // (4) (D) 구매확정일
    public string BuyerName;                // (5) (E) 구매자명
    public string BuyerID;                  // (6) (F) 구매자 ID
    public string BuyerContact;             // (7) (G) 구매자 연락처
    public string OrderStatus;              // (8) (H) 주문상태
    public string OrderDateTime;            // (9) (I) 주문일시
    public string ProductCode;              // (10) (J) 상품코드
    public string CustomProductCode;        // (11) (K) 자체상품코드
    public string ProductName;              // (12) (L) 상품명
    public string ItemCode;                 // (13) (M) 품목코드
    public string CustomItemCode;           // (14) (N) 자체품목코드
    public string OptionInfo;               // (15) (O) 옵션정보
    public string SalePrice;                // (16) (P) 판매가
    public string ProductDiscount;          // (17) (Q) 상품 할인액
    public string ProductPrice;             // (18) (R) 상품가격
    public string Quantity;                 // (19) (S) 수량
    public string ProductOrderAmount;       // (20) (T) 상품주문액
    public string CouponDiscountAmount;     // (21) (U) 쿠폰 할인 금액
    public string StoreBearsAmount;         // (22) (V) 스토어 부담 금액
    public string DeliveryFeeType;          // (23) (W) 배송비유형
    public string TotalDeliveryFee;         // (24) (X) 총 배송비
    public string DeliveryFee;              // (25) (Y) 배송비
    public string ReturnDeliveryFee;        // (26) (Z) 반품배송비
    public string JejuIslandRemoteAreaFee;  // (27) (AA) 제주도서추가배송비
    public string RecipientName;            // (28) (AB) 수령인명
    public string RecipientContact;         // (29) (AC) 수령인 연락처
    public string DeliveryAddress;          // (30) (AD) 배송지 주소
    public string PostalCode;               // (31) (AE) 우편번호
    public string DeliveryMessage;          // (32) (AF) 배송 메세지
    public string DeliveryCompletionDate;   // (33) (AG) 배송 완료일
    public string PaymentMethod;            // (34) (AH) 결제 수단
    public string ProductNumber;            // (35) (AI) 상품번호
    public string ChannelClassification;    // (36) (AJ) 채널분류

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
        StoreName = storeName;                              // (1) (A) 스토어명
        PurchaseOrderNumber = purchaseOrderNumber;          // (2) (B) 상품주문번호
        OrderNumber = orderNumber;                          // (3) (C) 주문번호
        PurchaseConfirmationDate = purchaseConfirmationDate; // (4) (D) 구매확정일
        BuyerName = buyerName;                              // (5) (E) 구매자명
        BuyerID = buyerID;                                  // (6) (F) 구매자 ID
        BuyerContact = buyerContact;                        // (7) (G) 구매자 연락처
        OrderStatus = orderStatus;                          // (8) (H) 주문상태
        OrderDateTime = orderDateTime;                      // (9) (I) 주문일시
        ProductCode = productCode;                          // (10) (J) 상품코드
        CustomProductCode = customProductCode;              // (11) (K) 자체상품코드
        ProductName = productName;                          // (12) (L) 상품명
        ItemCode = itemCode;                                // (13) (M) 품목코드
        CustomItemCode = customItemCode;                    // (14) (N) 자체품목코드
        OptionInfo = optionInfo;                            // (15) (O) 옵션정보
        SalePrice = salePrice;                              // (16) (P) 판매가
        ProductDiscount = productDiscount;                  // (17) (Q) 상품 할인액
        ProductPrice = productPrice;                        // (18) (R) 상품가격
        Quantity = quantity;                                // (19) (S) 수량
        ProductOrderAmount = productOrderAmount;            // (20) (T) 상품주문액
        CouponDiscountAmount = couponDiscountAmount;        // (21) (U) 쿠폰 할인 금액
        StoreBearsAmount = storeBearsAmount;                // (22) (V) 스토어 부담 금액
        DeliveryFeeType = deliveryFeeType;                  // (23) (W) 배송비유형
        TotalDeliveryFee = totalDeliveryFee;                // (24) (X) 총 배송비
        DeliveryFee = deliveryFee;                          // (25) (Y) 배송비
        ReturnDeliveryFee = returnDeliveryFee;              // (26) (Z) 반품배송비
        JejuIslandRemoteAreaFee = jejuIslandRemoteAreaFee;  // (27) (AA) 제주도서추가배송비
        RecipientName = recipientName;                      // (28) (AB) 수령인명
        RecipientContact = recipientContact;                // (29) (AC) 수령인 연락처
        DeliveryAddress = deliveryAddress;                  // (30) (AD) 배송지 주소
        PostalCode = postalCode;                            // (31) (AE) 우편번호
        DeliveryMessage = deliveryMessage;                  // (32) (AF) 배송 메세지
        DeliveryCompletionDate = deliveryCompletionDate;    // (33) (AG) 배송 완료일
        PaymentMethod = paymentMethod;                      // (34) (AH) 결제 수단
        ProductNumber = productNumber;                      // (35) (AI) 상품번호
        ChannelClassification = channelClassification;      // (36) (AJ) 채널분류
    }
}


public struct ProfitData
{
    public Platform orderPlatform;              //플랫폼
    public string PurchaseConfirmationDate;     //구매확정일
    public string ProductNumber;                //상품번호
    public string TotalOrderAmountPerProduct;   //판매가
    public string TotalDeliveryFee;             //배송비
    public string etc;                          //판매자부담금
    public string productCostData;              //상품원가
    public string TotalProfit;                  //수익금


    public ProfitData(Platform _Platform, 
        string _PurchaseConfirmationDate, 
        string _ProductNumber, 
        string _TotalOrderAmountPerProduct, 
        string _TotalDeliveryFee, 
        string _etc,
        string _productCostData, 
        string _TotalProfit = null)
    {
        orderPlatform = _Platform;                              //플랫폼
        PurchaseConfirmationDate = _PurchaseConfirmationDate;   //구매확정일
        ProductNumber = _ProductNumber;                         //상품번호
        TotalOrderAmountPerProduct = _TotalOrderAmountPerProduct; //판매가
        TotalDeliveryFee = _TotalDeliveryFee;                   //배송비
        etc = _etc;                                             //판매자부담금
        productCostData = _productCostData;                     //상품원가
        TotalProfit = _TotalProfit ?? "";                       //수익금
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
