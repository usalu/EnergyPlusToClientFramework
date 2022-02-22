namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_WaterToAirHeatPump_CoolingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:WaterToAirHeatPump:EquationFit")]
        CoilCoolingWaterToAirHeatPumpEquationFit = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:WaterToAirHeatPump:VariableSpeedEquationFit")]
        CoilCoolingWaterToAirHeatPumpVariableSpeedEquationFit = 1,
    }
}