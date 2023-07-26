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

            // ����Ȯ������ DateTime���� ��ȯ
            DateTime purchaseConfirmationDate = DateTime.Parse(split[2]);
            // Ű������ ����� �������� ����Ȯ������ ��ȯ
            string key = purchaseConfirmationDate.ToString("yyyyMM");

            NaverOrderResource Data = new NaverOrderResource(
                split[0],  // ��ǰ�ֹ���ȣ
                split[1],  // �ֹ���ȣ
                split[2],  // ����Ȯ����
                split[3],  // �Ǹ�ä��
                split[4],  // �ֹ�����
                split[5],  // ��ۼӼ�
                split[6],  // Ǯ�ʸ�Ʈ��(�ֹ� ����)
                split[7],  // �����ڸ�
                split[8],  // ������ID
                split[9],  // �����θ�
                split[10], // �߼�ó����
                split[11], // ��۹��
                split[12], // �ù��
                split[13], // �����ȣ
                split[14], // ��ۿϷ���
                split[15], // ��ǰ��ȣ
                split[16], // ��ǰ��
                split[17], // ��ǰ����
                split[18], // ��ǰ�Ƚ��ɾ�
                split[19], // �ɼ�����
                split[20], // �ɼǰ����ڵ�
                split[21], // ����
                ItemManager.RemoveWonAndBackslash(split[22]), // ��ǰ����
                ItemManager.RemoveWonAndBackslash(split[23]), // �ɼǰ���
                ItemManager.RemoveWonAndBackslash(split[24]), // ��ǰ�� ���ξ�
                ItemManager.RemoveWonAndBackslash(split[25]), // �Ǹ��� �δ� ���ξ�
                ItemManager.RemoveWonAndBackslash(split[26]), // ��ǰ�� �� �ֹ��ݾ�
                split[27], // �Ǹ��� ��ǰ�ڵ�
                split[28], // �Ǹ��� �����ڵ�1
                split[29], // �Ǹ��� �����ڵ�2
                split[30], // ��ۺ� ������ȣ
                split[31], // ��ۺ� ����
                split[32], // ��ۺ� ����
                ItemManager.RemoveWonAndBackslash(split[33]), // ��ۺ� �հ�
                ItemManager.RemoveWonAndBackslash(split[34]), // ����/���� �߰���ۺ�
                ItemManager.RemoveWonAndBackslash(split[35]), // ��ۺ� ���ξ�
                split[36], // ������
                split[37], // ��������
                split[38], // ������ġ
                split[39], // ������ ���ݱ���
                split[40], // ������������
                ItemManager.RemoveWonAndBackslash(split[41]), // ���̹����� �ֹ����� ������
                ItemManager.RemoveWonAndBackslash(split[42]), // ���⿬�� ������
                ItemManager.RemoveWonAndBackslash(split[43]), // ���꿹���ݾ�
                split[44]  // ���⿬�������� ���԰��
            );


            // Ű���� �̹� �����ϴ��� Ȯ��
            if (orderDataContainer.ContainsKey(key))
            {
                // �̹� �����ϴ� ��� �ش� ����Ʈ�� ������ �߰�
                orderDataContainer[key].Add(Data);
            }
            else
            {
                // �������� �ʴ� ��� ���ο� ����Ʈ ���� �� ������ �߰�
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
                split[0],  // (1) (A) ������
                split[1],  // (2) (B) ��ǰ�ֹ���ȣ
                split[2],  // (3) (C) �ֹ���ȣ
                split[3],  // (4) (D) ����Ȯ����
                split[4],  // (5) (E) �����ڸ�
                split[5],  // (6) (F) ������ ID
                split[6],  // (7) (G) ������ ����ó
                split[7],  // (8) (H) �ֹ�����
                split[8],  // (9) (I) �ֹ��Ͻ�
                split[9],  // (10) (J) ��ǰ�ڵ�
                split[10], // (11) (K) ��ü��ǰ�ڵ�
                split[11], // (12) (L) ��ǰ��
                split[12], // (13) (M) ǰ���ڵ�
                split[13], // (14) (N) ��üǰ���ڵ�
                split[14], // (15) (O) �ɼ�����
                ItemManager.RemoveWonAndBackslash(split[15]), // (16) (P) �ǸŰ�
                ItemManager.RemoveWonAndBackslash(split[16]), // (17) (Q) ��ǰ ���ξ�
                ItemManager.RemoveWonAndBackslash(split[17]), // (18) (R) ��ǰ����
                split[18], // (19) (S) ����
                ItemManager.RemoveWonAndBackslash(split[19]), // (20) (T) ��ǰ�ֹ���
                ItemManager.RemoveWonAndBackslash(split[20]), // (21) (U) ���� ���� �ݾ�
                ItemManager.RemoveWonAndBackslash(split[21]), // (22) (V) ����� �δ� �ݾ�
                split[22], // (23) (W) ��ۺ�����
                ItemManager.RemoveWonAndBackslash(split[23]), // (24) (X) �� ��ۺ�
                ItemManager.RemoveWonAndBackslash(split[24]), // (25) (Y) ��ۺ�
                ItemManager.RemoveWonAndBackslash(split[25]), // (26) (Z) ��ǰ��ۺ�
                ItemManager.RemoveWonAndBackslash(split[26]), // (27) (AA) ���ֵ����߰���ۺ�
                split[27], // (28) (AB) �����θ�
                split[28], // (29) (AC) ������ ����ó
                split[29], // (30) (AD) ����� �ּ�
                split[30], // (31) (AE) �����ȣ
                split[31], // (32) (AF) ��� �޼���
                split[32], // (33) (AG) ��� �Ϸ���
                split[33], // (34) (AH) ���� ����
                split[34], // (35) (AI) ��ǰ��ȣ
                split[35]  // (36) (AJ) ä�κз�
            );

            // Ű������ ����� �������� ����Ȯ������ ��ȯ
            DateTime purchaseConfirmationDate = DateTime.Parse(split[3]);
            string key = purchaseConfirmationDate.ToString("yyyyMM");

            // Ű���� �̹� �����ϴ��� Ȯ��
            if (orderDataContainer.ContainsKey(key))
            {
                // �̹� �����ϴ� ��� �ش� ����Ʈ�� ������ �߰�
                orderDataContainer[key].Add(data);
            }
            else
            {
                // �������� �ʴ� ��� ���ο� ����Ʈ ���� �� ������ �߰�
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

    public void CreateCSVFile(List<ProfitData> dataList, List<string> productCostList, string fileName = "profit_data")
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(path, fileName + ".csv");

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            // Write header if the file is empty (i.e., newly created)
            if (new FileInfo(filePath).Length == 0)
            {
                writer.WriteLine("OrderPlatform,PurchaseConfirmationDate,ProductNumber," +
                    "TotalOrderAmountPerProduct,TotalDeliveryFee,ProductCost,TotalProfit");
            }

            // Write data to CSV file
            for (int i = 0; i < dataList.Count; i++)
            {
                string productCost = productCostList[i]; // Get the productCost for the current ProfitData
                ProfitData data = dataList[i]; // Get the ProfitData for the current productCost

                writer.WriteLine($"{data.orderPlatform},{data.PurchaseConfirmationDate},{data.ProductNumber}," +
                    $"{data.TotalOrderAmountPerProduct},{data.TotalDeliveryFee},{productCost},{data.TotalProfit}");
            }
        }
    }
}








//// orderDataContainer�� JSON���� ��ȯ
//string json = JsonUtility.ToJson(orderDataContainer, true);

//// JSON ���Ϸ� ����
//string filePath = Path.Combine(Application.dataPath, "Data", "orderDataContainer.json");
//File.WriteAllText(filePath, json);
