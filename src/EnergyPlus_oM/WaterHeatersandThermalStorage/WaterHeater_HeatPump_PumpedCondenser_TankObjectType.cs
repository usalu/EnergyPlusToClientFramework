namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_HeatPump_PumpedCondenser_TankObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="WaterHeater:Mixed")]
        WaterHeaterMixed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="WaterHeater:Stratified")]
        WaterHeaterStratified = 2,
    }
}