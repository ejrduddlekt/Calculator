using AYellowpaper.SerializedCollections;
using System.Collections.Generic;

public class DataContainer
{
    public SerializedDictionary<string, List<NaverOrderResource>> NaverOrderDataContainer = new SerializedDictionary<string, List<NaverOrderResource>>();
    public SerializedDictionary<string, List<ZigzagOrderResource>> ZigZagOrderDataContainer = new SerializedDictionary<string, List<ZigzagOrderResource>>();
    public SerializedDictionary<string, ProductCostData> productCostData = new SerializedDictionary<string, ProductCostData>();
}
