namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum Chiller_ConstantCOP_ChillerFlowMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConstantFlow")]
        ConstantFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="LeavingSetpointModulated")]
        LeavingSetpointModulated = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="NotModulated")]
        NotModulated = 3,
    }
}