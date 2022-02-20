using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Determines which contaminant concentration will be simulates.")]
    [JsonObject("ZoneAirContaminantBalance")]
    public class ZoneAirContaminantBalance : BHoMObject
    {
        

        [Description("If Yes, CO2 simulation will be performed.")]
        [JsonProperty("carbon_dioxide_concentration")]
        public EmptyNoYes CarbonDioxideConcentration { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Schedule values should be in parts per million (ppm)")]
        [JsonProperty("outdoor_carbon_dioxide_schedule_name")]
        public string OutdoorCarbonDioxideScheduleName { get; set; } = "";
        

        [Description("If Yes, generic contaminant simulation will be performed.")]
        [JsonProperty("generic_contaminant_concentration")]
        public EmptyNoYes GenericContaminantConcentration { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Schedule values should be generic contaminant concentration in parts per million " +
                     "(ppm)")]
        [JsonProperty("outdoor_generic_contaminant_schedule_name")]
        public string OutdoorGenericContaminantScheduleName { get; set; } = "";
    }
}