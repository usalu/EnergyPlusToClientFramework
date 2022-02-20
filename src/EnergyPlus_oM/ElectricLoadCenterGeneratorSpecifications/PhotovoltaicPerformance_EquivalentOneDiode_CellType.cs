using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum PhotovoltaicPerformance_EquivalentOneDiode_CellType
    {
        
        [JsonProperty("AmorphousSilicon")]
        AmorphousSilicon = 0,
        
        [JsonProperty("CrystallineSilicon")]
        CrystallineSilicon = 1,
    }
}