namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    public enum RoomAir_Node_NodeType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Ceiling")]
        Ceiling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Control")]
        Control = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Floor")]
        Floor = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Inlet")]
        Inlet = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MundtRoom")]
        MundtRoom = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Return")]
        Return = 5,
    }
}