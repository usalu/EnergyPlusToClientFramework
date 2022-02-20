using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_Photovoltaic_PhotovoltaicPerformanceObjectType
    {
        
        [JsonProperty("PhotovoltaicPerformance:EquivalentOne-Diode")]
        PhotovoltaicPerformanceEquivalentOneDiode = 0,
        
        [JsonProperty("PhotovoltaicPerformance:Sandia")]
        PhotovoltaicPerformanceSandia = 1,
        
        [JsonProperty("PhotovoltaicPerformance:Simple")]
        PhotovoltaicPerformanceSimple = 2,
    }
}