namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_System_CoolingSupplyAirFlowRateMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DesignDay")]
        DesignDay = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/System")]
        FlowSystem = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerCoolingCapacity")]
        FlowPerCoolingCapacity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerFloorArea")]
        FlowPerFloorArea = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedCoolingAirflow")]
        FractionOfAutosizedCoolingAirflow = 5,
    }
}