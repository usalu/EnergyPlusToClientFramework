using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_WindTurbine_RotorType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("HorizontalAxisWindTurbine")]
        HorizontalAxisWindTurbine = 1,
        
        [JsonProperty("VerticalAxisWindTurbine")]
        VerticalAxisWindTurbine = 2,
    }
}