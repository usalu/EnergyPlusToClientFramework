namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_Zone_CoolingDesignAirFlowMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DesignDay")]
        DesignDay = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DesignDayWithLimit")]
        DesignDayWithLimit = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Zone")]
        FlowZone = 3,
    }
}