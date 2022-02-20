using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Used to describe the amount of irrigation on the ecoroof surface over the course " +
                 "of the simulation runperiod.")]
    [JsonObject("RoofIrrigation")]
    public class RoofIrrigation : BHoMObject
    {
        

        [Description("SmartSchedule will not allow irrigation when soil is already moist. Current thres" +
                     "hold set at 30% of saturation.")]
        [JsonProperty("irrigation_model_type")]
        public EmptyNoYes IrrigationModelType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Schedule values in meters of water per hour values should be non-negative")]
        [JsonProperty("irrigation_rate_schedule_name")]
        public string IrrigationRateScheduleName { get; set; } = "";
        

        [Description("Used with SmartSchedule to set the saturation level at which no irrigation is all" +
                     "owed.")]
        [JsonProperty("irrigation_maximum_saturation_threshold")]
        public System.Nullable<float> IrrigationMaximumSaturationThreshold { get; set; } = (System.Nullable<float>)Single.Parse("40", CultureInfo.InvariantCulture);
    }
}