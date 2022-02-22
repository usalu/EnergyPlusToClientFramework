namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    public enum AirConditioner_VariableRefrigerantFlow_CondenserType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirCooled")]
        AirCooled = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="EvaporativelyCooled")]
        EvaporativelyCooled = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="WaterCooled")]
        WaterCooled = 3,
    }
}