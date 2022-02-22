using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Specifies outside temperature-controlled electric baseboard heating.")]
    public class ZoneBaseboard_OutdoorTemperatureControlled : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("units in Schedule should be fraction applied to capacity of the baseboard heat eq" +
                     "uipment, generally (0.0 - 1.0)")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [JsonProperty("capacity_at_low_temperature")]
        public System.Nullable<float> CapacityAtLowTemperature { get; set; } = null;
        

        [JsonProperty("low_temperature")]
        public System.Nullable<float> LowTemperature { get; set; } = null;
        

        [JsonProperty("capacity_at_high_temperature")]
        public System.Nullable<float> CapacityAtHighTemperature { get; set; } = null;
        

        [JsonProperty("high_temperature")]
        public System.Nullable<float> HighTemperature { get; set; } = null;
        

        [JsonProperty("fraction_radiant")]
        public System.Nullable<float> FractionRadiant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}