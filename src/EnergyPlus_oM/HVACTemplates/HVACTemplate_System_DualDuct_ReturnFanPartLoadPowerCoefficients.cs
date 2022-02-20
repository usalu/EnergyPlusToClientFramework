using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DualDuct_ReturnFanPartLoadPowerCoefficients
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAE90.1-2004AppendixG")]
        ASHRAE9012004AppendixG = 1,
        
        [JsonProperty("InletVaneDampers")]
        InletVaneDampers = 2,
        
        [JsonProperty("OutletDampers")]
        OutletDampers = 3,
        
        [JsonProperty("VariableSpeedMotor")]
        VariableSpeedMotor = 4,
        
        [JsonProperty("VariableSpeedMotorPressureReset")]
        VariableSpeedMotorPressureReset = 5,
    }
}