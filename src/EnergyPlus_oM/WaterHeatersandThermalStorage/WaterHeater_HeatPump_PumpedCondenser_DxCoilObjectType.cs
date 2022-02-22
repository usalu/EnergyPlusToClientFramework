namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_HeatPump_PumpedCondenser_DxCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:WaterHeating:AirToWaterHeatPump:Pumped")]
        CoilWaterHeatingAirToWaterHeatPumpPumped = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:WaterHeating:AirToWaterHeatPump:VariableSpeed")]
        CoilWaterHeatingAirToWaterHeatPumpVariableSpeed = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CoilSystem:IntegratedHeatPump:AirSource")]
        CoilSystemIntegratedHeatPumpAirSource = 3,
    }
}