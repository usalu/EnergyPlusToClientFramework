namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum DesignSpecification_ZoneHVAC_Sizing_NoLoadSupplyAirFlowRateMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerFloorArea")]
        FlowPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedCoolingAirflow")]
        FractionOfAutosizedCoolingAirflow = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingAirflow")]
        FractionOfAutosizedHeatingAirflow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="SupplyAirFlowRate")]
        SupplyAirFlowRate = 5,
    }
}