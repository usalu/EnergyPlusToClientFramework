namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    public enum RoomAirModelType_RoomAirModelingType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirflowNetwork")]
        AirflowNetwork = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CrossVentilation")]
        CrossVentilation = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Mixing")]
        Mixing = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OneNodeDisplacementVentilation")]
        OneNodeDisplacementVentilation = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ThreeNodeDisplacementVentilation")]
        ThreeNodeDisplacementVentilation = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="UnderFloorAirDistributionExterior")]
        UnderFloorAirDistributionExterior = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="UnderFloorAirDistributionInterior")]
        UnderFloorAirDistributionInterior = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="UserDefined")]
        UserDefined = 8,
    }
}