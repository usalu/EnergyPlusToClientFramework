using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Multiplier altering the relative capacitance of the air compared to an empty zone" +
                 "")]
    [JsonObject("ZoneCapacitanceMultiplier:ResearchSpecial")]
    public class ZoneCapacitanceMultiplier_ResearchSpecial : BHoMObject
    {
        

        [Description("If this field is left blank, the multipliers are applied to all the zones not spe" +
                     "cified")]
        [JsonProperty("zone_or_zonelist_name")]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [Description("Used to alter the capacitance of zone air with respect to heat or temperature")]
        [JsonProperty("temperature_capacity_multiplier")]
        public System.Nullable<float> TemperatureCapacityMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Used to alter the capacitance of zone air with respect to moisture or humidity ra" +
                     "tio")]
        [JsonProperty("humidity_capacity_multiplier")]
        public System.Nullable<float> HumidityCapacityMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Used to alter the capacitance of zone air with respect to zone air carbon dioxide" +
                     " concentration")]
        [JsonProperty("carbon_dioxide_capacity_multiplier")]
        public System.Nullable<float> CarbonDioxideCapacityMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Used to alter the capacitance of zone air with respect to zone air generic contam" +
                     "inant concentration")]
        [JsonProperty("generic_contaminant_capacity_multiplier")]
        public System.Nullable<float> GenericContaminantCapacityMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}