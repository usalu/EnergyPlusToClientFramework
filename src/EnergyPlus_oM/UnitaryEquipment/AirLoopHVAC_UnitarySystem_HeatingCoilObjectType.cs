namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_HeatingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:DX:MultiSpeed")]
        CoilHeatingDXMultiSpeed = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:DX:SingleSpeed")]
        CoilHeatingDXSingleSpeed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:DX:VariableSpeed")]
        CoilHeatingDXVariableSpeed = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Desuperheater")]
        CoilHeatingDesuperheater = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Electric")]
        CoilHeatingElectric = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Electric:MultiStage")]
        CoilHeatingElectricMultiStage = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Fuel")]
        CoilHeatingFuel = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Gas:MultiStage")]
        CoilHeatingGasMultiStage = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Steam")]
        CoilHeatingSteam = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Water")]
        CoilHeatingWater = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:WaterToAirHeatPump:EquationFit")]
        CoilHeatingWaterToAirHeatPumpEquationFit = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:WaterToAirHeatPump:ParameterEstimation")]
        CoilHeatingWaterToAirHeatPumpParameterEstimation = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:WaterToAirHeatPump:VariableSpeedEquationFit")]
        CoilHeatingWaterToAirHeatPumpVariableSpeedEquationFit = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:UserDefined")]
        CoilUserDefined = 13,
    }
}