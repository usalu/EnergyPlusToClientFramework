using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    public enum Curve_QuintLinear_InputUnitTypeForZ
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Dimensionless")]
        Dimensionless = 1,
        
        [JsonProperty("Distance")]
        Distance = 2,
        
        [JsonProperty("MassFlow")]
        MassFlow = 3,
        
        [JsonProperty("Power")]
        Power = 4,
        
        [JsonProperty("Temperature")]
        Temperature = 5,
        
        [JsonProperty("VolumetricFlow")]
        VolumetricFlow = 6,
        
        [JsonProperty("VolumetricFlowPerPower")]
        VolumetricFlowPerPower = 7,
    }
}