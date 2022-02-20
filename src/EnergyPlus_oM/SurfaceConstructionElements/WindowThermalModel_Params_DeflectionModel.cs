using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowThermalModel_Params_DeflectionModel
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MeasuredDeflection")]
        MeasuredDeflection = 1,
        
        [JsonProperty("NoDeflection")]
        NoDeflection = 2,
        
        [JsonProperty("TemperatureAndPressureInput")]
        TemperatureAndPressureInput = 3,
    }
}