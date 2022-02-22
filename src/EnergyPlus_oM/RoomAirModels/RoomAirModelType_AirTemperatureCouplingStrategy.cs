namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    public enum RoomAirModelType_AirTemperatureCouplingStrategy
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Direct")]
        Direct = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Indirect")]
        Indirect = 2,
    }
}