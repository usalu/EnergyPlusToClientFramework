using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    public enum RoomAirSettings_CrossVentilation_AirflowRegionUsedForThermalComfortEvaluation
    {
        
        [JsonProperty("Jet")]
        Jet = 0,
        
        [JsonProperty("Recirculation")]
        Recirculation = 1,
    }
}