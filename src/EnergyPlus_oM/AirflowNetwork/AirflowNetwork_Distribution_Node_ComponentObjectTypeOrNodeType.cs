namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_Distribution_Node_ComponentObjectTypeOrNodeType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirLoopHVAC:OutdoorAirSystem")]
        AirLoopHVACOutdoorAirSystem = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AirLoopHVAC:ZoneMixer")]
        AirLoopHVACZoneMixer = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="AirLoopHVAC:ZoneSplitter")]
        AirLoopHVACZoneSplitter = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OAMixerOutdoorAirStreamNode")]
        OAMixerOutdoorAirStreamNode = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Other")]
        Other = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAir:Node")]
        OutdoorAirNode = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAir:NodeList")]
        OutdoorAirNodeList = 7,
    }
}