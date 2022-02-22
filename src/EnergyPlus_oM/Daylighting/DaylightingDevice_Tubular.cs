using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description("Defines a tubular daylighting device (TDD) consisting of three components: a dome" +
                 ", a pipe, and a diffuser. The dome and diffuser are defined separately using the" +
                 " FenestrationSurface:Detailed object.")]
    [JsonObject("DaylightingDevice:Tubular")]
    public class DaylightingDevice_Tubular : BHoMObject, IEnergyPlusClass
    {
        

        [Description("This must refer to a subsurface object of type TubularDaylightDome")]
        [JsonProperty("dome_name")]
        public string DomeName { get; set; } = "";
        

        [Description("This must refer to a subsurface object of type TubularDaylightDiffuser Delivery z" +
                     "one is specified in the diffuser object")]
        [JsonProperty("diffuser_name")]
        public string DiffuserName { get; set; } = "";
        

        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [JsonProperty("diameter")]
        public System.Nullable<float> Diameter { get; set; } = null;
        

        [Description("The exterior exposed length is the difference between total and sum of zone lengt" +
                     "hs")]
        [JsonProperty("total_length")]
        public System.Nullable<float> TotalLength { get; set; } = null;
        

        [Description("R value between TubularDaylightDome and TubularDaylightDiffuser")]
        [JsonProperty("effective_thermal_resistance")]
        public System.Nullable<float> EffectiveThermalResistance { get; set; } = (System.Nullable<float>)Single.Parse("0.28", CultureInfo.InvariantCulture);
        

        [JsonProperty("transition_lengths")]
        public string TransitionLengths { get; set; } = "";
    }
}