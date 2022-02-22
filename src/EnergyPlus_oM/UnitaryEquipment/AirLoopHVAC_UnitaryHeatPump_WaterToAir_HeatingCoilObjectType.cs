namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:WaterToAirHeatPump:EquationFit")]
        CoilHeatingWaterToAirHeatPumpEquationFit = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:WaterToAirHeatPump:ParameterEstimation")]
        CoilHeatingWaterToAirHeatPumpParameterEstimation = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:WaterToAirHeatPump:VariableSpeedEquationFit")]
        CoilHeatingWaterToAirHeatPumpVariableSpeedEquationFit = 2,
    }
}