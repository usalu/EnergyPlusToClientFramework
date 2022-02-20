using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum ElectricLoadCenter_Distribution_GeneratorOperationSchemeType
    {
        
        [JsonProperty("Baseload")]
        Baseload = 0,
        
        [JsonProperty("DemandLimit")]
        DemandLimit = 1,
        
        [JsonProperty("FollowThermal")]
        FollowThermal = 2,
        
        [JsonProperty("FollowThermalLimitElectrical")]
        FollowThermalLimitElectrical = 3,
        
        [JsonProperty("TrackElectrical")]
        TrackElectrical = 4,
        
        [JsonProperty("TrackMeter")]
        TrackMeter = 5,
        
        [JsonProperty("TrackSchedule")]
        TrackSchedule = 6,
    }
}