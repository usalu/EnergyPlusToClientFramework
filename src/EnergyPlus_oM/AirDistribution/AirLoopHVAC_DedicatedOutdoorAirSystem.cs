using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description("Defines a central forced air system to provide dedicated outdoor air to multiple " +
                 "AirLoopHVACs.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_DedicatedOutdoorAirSystem : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of an AirLoopHVAC:OutdoorAirSystem object.")]
        [JsonProperty("airloophvac_outdoorairsystem_name")]
        public string AirloophvacOutdoorairsystemName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Name of AirLoopHVAC:Mixer.")]
        [JsonProperty("airloophvac_mixer_name")]
        public string AirloophvacMixerName { get; set; } = "";
        

        [Description("Name of AirLoopHVAC:Splitter.")]
        [JsonProperty("airloophvac_splitter_name")]
        public string AirloophvacSplitterName { get; set; } = "";
        

        [JsonProperty("preheat_design_temperature")]
        public System.Nullable<float> PreheatDesignTemperature { get; set; } = null;
        

        [JsonProperty("preheat_design_humidity_ratio")]
        public System.Nullable<float> PreheatDesignHumidityRatio { get; set; } = null;
        

        [JsonProperty("precool_design_temperature")]
        public System.Nullable<float> PrecoolDesignTemperature { get; set; } = null;
        

        [JsonProperty("precool_design_humidity_ratio")]
        public System.Nullable<float> PrecoolDesignHumidityRatio { get; set; } = null;
        

        [Description("Enter the number of the AirLoopHAVC served by AirLoopHVAC:DedicatedOutdoorAirSyst" +
                     "em")]
        [JsonProperty("number_of_airloophvac")]
        public System.Nullable<float> NumberOfAirloophvac { get; set; } = null;
        

        [JsonProperty("airloophvacs")]
        public string Airloophvacs { get; set; } = "";
    }
}