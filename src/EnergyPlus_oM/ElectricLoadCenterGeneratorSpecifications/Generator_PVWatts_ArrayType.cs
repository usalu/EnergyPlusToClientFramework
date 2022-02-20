using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_PVWatts_ArrayType
    {
        
        [JsonProperty("FixedOpenRack")]
        FixedOpenRack = 0,
        
        [JsonProperty("FixedRoofMounted")]
        FixedRoofMounted = 1,
        
        [JsonProperty("OneAxis")]
        OneAxis = 2,
        
        [JsonProperty("OneAxisBacktracking")]
        OneAxisBacktracking = 3,
        
        [JsonProperty("TwoAxis")]
        TwoAxis = 4,
    }
}