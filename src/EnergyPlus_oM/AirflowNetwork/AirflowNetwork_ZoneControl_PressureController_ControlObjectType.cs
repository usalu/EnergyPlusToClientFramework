using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_ZoneControl_PressureController_ControlObjectType
    {
        
        [JsonProperty("AirflowNetwork:Distribution:Component:ReliefAirFlow")]
        AirflowNetworkDistributionComponentReliefAirFlow = 0,
        
        [JsonProperty("AirflowNetwork:MultiZone:Component:ZoneExhaustFan")]
        AirflowNetworkMultiZoneComponentZoneExhaustFan = 1,
    }
}