namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum ElectricEquipment_ITE_AirCooled_AirInletConnectionType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjustedSupply")]
        AdjustedSupply = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="RoomAirModel")]
        RoomAirModel = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAirNode")]
        ZoneAirNode = 3,
    }
}