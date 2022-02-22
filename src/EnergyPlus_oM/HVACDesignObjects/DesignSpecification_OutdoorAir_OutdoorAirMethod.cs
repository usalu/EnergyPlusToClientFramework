namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum DesignSpecification_OutdoorAir_OutdoorAirMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirChanges/Hour")]
        AirChangesHour = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Area")]
        FlowArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Person")]
        FlowPerson = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Zone")]
        FlowZone = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="IndoorAirQualityProcedure")]
        IndoorAirQualityProcedure = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Maximum")]
        Maximum = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="ProportionalControlBasedOnDesignOccupancy")]
        ProportionalControlBasedOnDesignOccupancy = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ProportionalControlBasedOnOccupancySchedule")]
        ProportionalControlBasedOnOccupancySchedule = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Sum")]
        Sum = 9,
    }
}