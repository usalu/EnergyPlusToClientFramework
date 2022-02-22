using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Used to describe the amount of water precipitation at the building site. Precipit" +
                 "ation includes both rain and the equivalent water content of snow.")]
    [JsonObject("Site:Precipitation")]
    public class Site_Precipitation : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("precipitation_model_type")]
        public Site_Precipitation_PrecipitationModelType PrecipitationModelType { get; set; } = (Site_Precipitation_PrecipitationModelType)Enum.Parse(typeof(Site_Precipitation_PrecipitationModelType), "ScheduleAndDesignLevel");
        

        [Description("meters of water per year used for design level")]
        [JsonProperty("design_level_for_total_annual_precipitation")]
        public System.Nullable<float> DesignLevelForTotalAnnualPrecipitation { get; set; } = null;
        

        [Description("Schedule values in meters of water per hour values should be non-negative")]
        [JsonProperty("precipitation_rates_schedule_name")]
        public string PrecipitationRatesScheduleName { get; set; } = "";
        

        [Description("meters of water per year from average weather statistics")]
        [JsonProperty("average_total_annual_precipitation")]
        public System.Nullable<float> AverageTotalAnnualPrecipitation { get; set; } = null;
    }
}