using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description(@"Specifies global heating and cooling sizing factors/ratios. These ratios are applied at the zone level to all of the zone heating and cooling loads and air flow rates. Then these new loads and air flow rates are used to calculate the system level flow rates and capacities and are used in all component sizing calculations. Specifies the width (in load timesteps) of a moving average window which is used to smooth the peak load across more than one timestep.")]
    [JsonObject("Sizing:Parameters")]
    public class Sizing_Parameters : BHoMObject
    {
        

        [JsonProperty("heating_sizing_factor")]
        public System.Nullable<float> HeatingSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_sizing_factor")]
        public System.Nullable<float> CoolingSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("blank => set the timesteps in averaging window to Number of Timesteps per Hour re" +
                     "sulting in a 1 hour averaging window default is number of timesteps for 1 hour a" +
                     "veraging window")]
        [JsonProperty("timesteps_in_averaging_window")]
        public System.Nullable<float> TimestepsInAveragingWindow { get; set; } = null;
    }
}