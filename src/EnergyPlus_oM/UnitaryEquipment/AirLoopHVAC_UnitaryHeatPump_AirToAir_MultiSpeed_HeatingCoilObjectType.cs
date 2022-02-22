namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_HeatingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:DX:MultiSpeed")]
        CoilHeatingDXMultiSpeed = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Electric:MultiStage")]
        CoilHeatingElectricMultiStage = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Gas:MultiStage")]
        CoilHeatingGasMultiStage = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Steam")]
        CoilHeatingSteam = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Water")]
        CoilHeatingWater = 4,
    }
}