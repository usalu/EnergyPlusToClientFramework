namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    public enum ZoneInfiltration_DesignFlowRate_DesignFlowRateCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirChanges/Hour")]
        AirChangesHour = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Area")]
        FlowArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/ExteriorArea")]
        FlowExteriorArea = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/ExteriorWallArea")]
        FlowExteriorWallArea = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Zone")]
        FlowZone = 5,
    }
}