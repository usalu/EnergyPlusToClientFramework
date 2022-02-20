using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_WindTurbine_PowerControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedSpeedFixedPitch")]
        FixedSpeedFixedPitch = 1,
        
        [JsonProperty("FixedSpeedVariablePitch")]
        FixedSpeedVariablePitch = 2,
        
        [JsonProperty("VariableSpeedFixedPitch")]
        VariableSpeedFixedPitch = 3,
        
        [JsonProperty("VariableSpeedVariablePitch")]
        VariableSpeedVariablePitch = 4,
    }
}