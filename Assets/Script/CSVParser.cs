using AYellowpaper.SerializedCollections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using TMPro;
using UnityEditor;
using UnityEngine;


public class CSVParser : MonoBehaviour
{
    public SerializedDictionary<string, List<NaverOrderResource>> CreateNaverResource()
    {

        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string pullPath = Path.Combine(path, "naver_data.csv");
        string[] allLines = File.ReadAllLines(pullPath);

        SerializedDictionary<string, List<NaverOrderResource>> orderDataContainer = new SerializedDictionary<string, List<NaverOrderResource>>();

        for (int i = 1; i < allLines.Length; i++)
        {
            string[] split = allLines[i].Split(',');

            // 구매확정일을 DateTime으로 변환
            DateTime purchaseConfirmationDate = DateTime.Parse(split[2]);
            // 키값으로 사용할 형식으로 구매확정일을 변환
            string key = purchaseConfirmationDate.ToString("yyyyMM");

            NaverOrderResource Data = new NaverOrderResource(
                split[0],  // 상품주문번호
                split[1],  // 주문번호
                split[2],  // 구매확정일
                split[3],  // 판매채널
                split[4],  // 주문상태
                split[5],  // 배송속성
                split[6],  // 풀필먼트사(주문 기준)
                split[7],  // 구매자명
                split[8],  // 구매자ID
                split[9],  // 수취인명
                split[10], // 발송처리일
                split[11], // 배송방법
                split[12], // 택배사
                split[13], // 송장번호
                split[14], // 배송완료일
                split[15], // 상품번호
                split[16], // 상품명
                split[17], // 상품종류
                split[18], // 반품안심케어
                split[19], // 옵션정보
                split[20], // 옵션관리코드
                split[21], // 수량
                ItemManager.RemoveWonAndBackslash(split[22]), // 상품가격
                ItemManager.RemoveWonAndBackslash(split[23]), // 옵션가격
                ItemManager.RemoveWonAndBackslash(split[24]), // 상품별 할인액
                ItemManager.RemoveWonAndBackslash(split[25]), // 판매자 부담 할인액
                ItemManager.RemoveWonAndBackslash(split[26]), // 상품별 총 주문금액
                split[27], // 판매자 상품코드
                split[28], // 판매자 내부코드1
                split[29], // 판매자 내부코드2
                split[30], // 배송비 묶음번호
                split[31], // 배송비 형태
                split[32], // 배송비 유형
                ItemManager.RemoveWonAndBackslash(split[33]), // 배송비 합계
                ItemManager.RemoveWonAndBackslash(split[34]), // 제주/도서 추가배송비
                ItemManager.RemoveWonAndBackslash(split[35]), // 배송비 할인액
                split[36], // 결제일
                split[37], // 결제수단
                split[38], // 결제위치
                split[39], // 수수료 과금구분
                split[40], // 수수료결제방식
                ItemManager.RemoveWonAndBackslash(split[41]), // 네이버페이 주문관리 수수료
                ItemManager.RemoveWonAndBackslash(split[42]), // 매출연동 수수료
                ItemManager.RemoveWonAndBackslash(split[43]), // 정산예정금액
                split[44]  // 매출연동수수료 유입경로
            );


            // 키값이 이미 존재하는지 확인
            if (orderDataContainer.ContainsKey(key))
            {
                // 이미 존재하는 경우 해당 리스트에 데이터 추가
                orderDataContainer[key].Add(Data);
            }
            else
            {
                // 존재하지 않는 경우 새로운 리스트 생성 후 데이터 추가
                List<NaverOrderResource> dataList = new List<NaverOrderResource>();
                dataList.Add(Data);
                orderDataContainer[key] = dataList;
            }
        }

        return orderDataContainer;
    }

    public SerializedDictionary<string, List<ZigzagOrderResource>> CreateZigZagNaverResource()
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string pullPath = Path.Combine(path, "zigzag_data.csv");
        string[] allLines = File.ReadAllLines(pullPath);

        SerializedDictionary<string, List<ZigzagOrderResource>> orderDataContainer = new SerializedDictionary<string, List<ZigzagOrderResource>>();

        for (int i = 1; i < allLines.Length; i++)
        {
            string[] split = allLines[i].Split(',');

            ZigzagOrderResource data = new ZigzagOrderResource(
                split[0],  // (1) (A) 스토어명
                split[1],  // (2) (B) 상품주문번호
                split[2],  // (3) (C) 주문번호
                split[3],  // (4) (D) 구매확정일
                split[4],  // (5) (E) 구매자명
                split[5],  // (6) (F) 구매자 ID
                split[6],  // (7) (G) 구매자 연락처
                split[7],  // (8) (H) 주문상태
                split[8],  // (9) (I) 주문일시
                split[9],  // (10) (J) 상품코드
                split[10], // (11) (K) 자체상품코드
                split[11], // (12) (L) 상품명
                split[12], // (13) (M) 품목코드
                split[13], // (14) (N) 자체품목코드
                split[14], // (15) (O) 옵션정보
                ItemManager.RemoveWonAndBackslash(split[15]), // (16) (P) 판매가
                ItemManager.RemoveWonAndBackslash(split[16]), // (17) (Q) 상품 할인액
                ItemManager.RemoveWonAndBackslash(split[17]), // (18) (R) 상품가격
                split[18], // (19) (S) 수량
                ItemManager.RemoveWonAndBackslash(split[19]), // (20) (T) 상품주문액
                ItemManager.RemoveWonAndBackslash(split[20]), // (21) (U) 쿠폰 할인 금액
                ItemManager.RemoveWonAndBackslash(split[21]), // (22) (V) 스토어 부담 금액
                split[22], // (23) (W) 배송비유형
                ItemManager.RemoveWonAndBackslash(split[23]), // (24) (X) 총 배송비
                ItemManager.RemoveWonAndBackslash(split[24]), // (25) (Y) 배송비
                ItemManager.RemoveWonAndBackslash(split[25]), // (26) (Z) 반품배송비
                ItemManager.RemoveWonAndBackslash(split[26]), // (27) (AA) 제주도서추가배송비
                split[27], // (28) (AB) 수령인명
                split[28], // (29) (AC) 수령인 연락처
                split[29], // (30) (AD) 배송지 주소
                split[30], // (31) (AE) 우편번호
                split[31], // (32) (AF) 배송 메세지
                split[32], // (33) (AG) 배송 완료일
                split[33], // (34) (AH) 결제 수단
                split[34], // (35) (AI) 상품번호
                split[35]  // (36) (AJ) 채널분류
            );

            // 키값으로 사용할 형식으로 구매확정일을 변환
            DateTime purchaseConfirmationDate = DateTime.Parse(split[3]);
            string key = purchaseConfirmationDate.ToString("yyyyMM");

            // 키값이 이미 존재하는지 확인
            if (orderDataContainer.ContainsKey(key))
            {
                // 이미 존재하는 경우 해당 리스트에 데이터 추가
                orderDataContainer[key].Add(data);
            }
            else
            {
                // 존재하지 않는 경우 새로운 리스트 생성 후 데이터 추가
                List<ZigzagOrderResource> dataList = new List<ZigzagOrderResource>();
                dataList.Add(data);
                orderDataContainer[key] = dataList;
            }
        }

        return orderDataContainer;
    }


    public SerializedDictionary<string, ProductCostData> CreateProductCostData()
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string pullPath = Path.Combine(path, "Product_Cost.csv");
        string[] allLines = File.ReadAllLines(pullPath);

        SerializedDictionary<string, ProductCostData> orderDataContainer = new SerializedDictionary<string, ProductCostData>();

        for (int i = 1; i < allLines.Length; i++)
        {
            string[] split = allLines[i].Split(',');

            ProductCostData data = new ProductCostData(split[0], split[1], split[2], split[3]);


            // Add the data to the appropriate key in the dictionary based on purchase confirmation date

            string key = split[1];
            orderDataContainer[key] = data;
        }

        return orderDataContainer;
    }

    public void CreateCSVFile(List<ProfitData> dataList, string fileName = "profit_data")
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(path, fileName + ".csv");

        // Check if the file exists, and delete it if it does
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        // Create a new file and write data
        using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
        {
            // Write header
            writer.WriteLine("플랫폼,구매일자,상품번호," +
                "판매가,배송비/스토어부담,상품원가,수익금");

            // Write data to CSV file
            for (int i = 0; i < dataList.Count; i++)
            {
                ProfitData data = dataList[i]; // Get the ProfitData for the current productCost

                writer.WriteLine($"{data.orderPlatform},{data.PurchaseConfirmationDate},{data.ProductNumber}," +
                    $"{data.TotalOrderAmountPerProduct},{data.TotalDeliveryFee},{data.productCostData},{data.TotalProfit}");
            }
        }
    }
}








//// orderDataContainer를 JSON으로 변환
//string json = JsonUtility.ToJson(orderDataContainer, true);

//// JSON 파일로 저장
//string filePath = Path.Combine(Application.dataPath, "Data", "orderDataContainer.json");
//File.WriteAllText(filePath, json);
