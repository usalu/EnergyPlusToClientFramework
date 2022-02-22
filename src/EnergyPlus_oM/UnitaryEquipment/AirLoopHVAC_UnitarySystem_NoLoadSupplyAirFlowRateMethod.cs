namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_NoLoadSupplyAirFlowRateMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerCoolingCapacity")]
        FlowPerCoolingCapacity = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerFloorArea")]
        FlowPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerHeatingCapacity")]
        FlowPerHeatingCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedCoolingValue")]
        FractionOfAutosizedCoolingValue = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingValue")]
        FractionOfAutosizedHeatingValue = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="SupplyAirFlowRate")]
        SupplyAirFlowRate = 6,
    }
}