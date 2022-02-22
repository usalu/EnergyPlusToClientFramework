using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description(@"This UCSD Cross Ventilation Room Air Model provides a simple model for heat transfer and vertical temperature profile prediction in cross ventilated rooms. The model distinguishes two regions in the room, the main jet region and the recirculations, and predicts characteristic airflow velocities and average air temperatures. Used with RoomAirModelType = CrossVentilation.")]
    public class RoomAirSettings_CrossVentilation : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Name of Zone being described. Any existing zone name")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Distribution of the convective heat gains between the jet and recirculation zones" +
                     ". 0<= Accepted Value <= 1. In the CV model 1 means all convective gains in the j" +
                     "et region.")]
        [JsonProperty("gain_distribution_schedule_name")]
        public string GainDistributionScheduleName { get; set; } = "";
        

        [Description("Required field whenever thermal comfort is predicted defines Air temperature and " +
                     "Airflow velocity that will be used in the Fanger model conditions must refer to " +
                     "one of the two regions: jet or recirculation")]
        [JsonProperty("airflow_region_used_for_thermal_comfort_evaluation")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoomAirSettings_CrossVentilation_AirflowRegionUsedForThermalComfortEvaluation AirflowRegionUsedForThermalComfortEvaluation { get; set; } = (RoomAirSettings_CrossVentilation_AirflowRegionUsedForThermalComfortEvaluation)Enum.Parse(typeof(RoomAirSettings_CrossVentilation_AirflowRegionUsedForThermalComfortEvaluation), "Jet");
    }
}