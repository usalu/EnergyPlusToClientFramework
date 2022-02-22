namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum ElectricEquipment_ITE_AirCooled_AirFlowCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowControlWithApproachTemperatures")]
        FlowControlWithApproachTemperatures = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowFromSystem")]
        FlowFromSystem = 2,
    }
}