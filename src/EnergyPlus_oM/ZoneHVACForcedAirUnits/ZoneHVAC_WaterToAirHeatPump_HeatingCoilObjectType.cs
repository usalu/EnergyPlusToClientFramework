namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_WaterToAirHeatPump_HeatingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:WaterToAirHeatPump:EquationFit")]
        CoilHeatingWaterToAirHeatPumpEquationFit = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:WaterToAirHeatPump:VariableSpeedEquationFit")]
        CoilHeatingWaterToAirHeatPumpVariableSpeedEquationFit = 1,
    }
}