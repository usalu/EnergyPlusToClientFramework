namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_HeatingSupplyAirFlowRateMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerFloorArea")]
        FlowPerFloorArea = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerHeatingCapacity")]
        FlowPerHeatingCapacity = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingValue")]
        FractionOfAutosizedHeatingValue = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="SupplyAirFlowRate")]
        SupplyAirFlowRate = 4,
    }
}