namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_WaterCoil_ControlVariable
    {
        
        [System.Runtime.Serialization.EnumMember(Value="HumidityRatio")]
        HumidityRatio = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureAndHumidityRatio")]
        TemperatureAndHumidityRatio = 2,
    }
}