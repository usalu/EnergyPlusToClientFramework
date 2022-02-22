namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_ZoneControl_PressureController_ControlObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AirflowNetwork:Distribution:Component:ReliefAirFlow")]
        AirflowNetworkDistributionComponentReliefAirFlow = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirflowNetwork:MultiZone:Component:ZoneExhaustFan")]
        AirflowNetworkMultiZoneComponentZoneExhaustFan = 1,
    }
}