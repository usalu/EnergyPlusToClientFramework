using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("This is a movable exterior glass layer that is usually applied in the winter and " +
                 "removed in the summer.")]
    public class WindowProperty_StormWindow : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Must be the name of a FenestrationSurface:Detailed object with Surface Type = WIN" +
                     "DOW. The WindowProperty:StormWindow object can only be used with exterior window" +
                     "s.")]
        [JsonProperty("window_name")]
        public string WindowName { get; set; } = "";
        

        [Description("Must be a WindowMaterial:Glazing or WindowMaterial:Glazing:RefractionExtinctionMe" +
                     "thod Gap between storm glass layer and adjacent glass layer is assumed to be fil" +
                     "led with Air")]
        [JsonProperty("storm_glass_layer_name")]
        public string StormGlassLayerName { get; set; } = "";
        

        [JsonProperty("distance_between_storm_glass_layer_and_adjacent_glass")]
        public System.Nullable<float> DistanceBetweenStormGlassLayerAndAdjacentGlass { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

        [JsonProperty("month_that_storm_glass_layer_is_put_on")]
        public System.Nullable<float> MonthThatStormGlassLayerIsPutOn { get; set; } = null;
        

        [JsonProperty("day_of_month_that_storm_glass_layer_is_put_on")]
        public System.Nullable<float> DayOfMonthThatStormGlassLayerIsPutOn { get; set; } = null;
        

        [JsonProperty("month_that_storm_glass_layer_is_taken_off")]
        public System.Nullable<float> MonthThatStormGlassLayerIsTakenOff { get; set; } = null;
        

        [JsonProperty("day_of_month_that_storm_glass_layer_is_taken_off")]
        public System.Nullable<float> DayOfMonthThatStormGlassLayerIsTakenOff { get; set; } = null;
    }
}