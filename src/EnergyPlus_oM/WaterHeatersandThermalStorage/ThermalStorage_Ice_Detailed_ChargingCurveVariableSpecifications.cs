using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum ThermalStorage_Ice_Detailed_ChargingCurveVariableSpecifications
    {
        
        [JsonProperty("FractionChargedLMTD")]
        FractionChargedLMTD = 0,
        
        [JsonProperty("FractionDischargedLMTD")]
        FractionDischargedLMTD = 1,
        
        [JsonProperty("LMTDFractionCharged")]
        LMTDFractionCharged = 2,
        
        [JsonProperty("LMTDMassFlow")]
        LMTDMassFlow = 3,
    }
}