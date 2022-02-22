namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_CoolingSupplyAirFlowRateMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerCoolingCapacity")]
        FlowPerCoolingCapacity = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerFloorArea")]
        FlowPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedCoolingValue")]
        FractionOfAutosizedCoolingValue = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="SupplyAirFlowRate")]
        SupplyAirFlowRate = 4,
    }
}