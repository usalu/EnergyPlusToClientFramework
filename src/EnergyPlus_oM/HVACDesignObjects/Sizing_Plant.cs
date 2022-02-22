using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description(@"Specifies the input needed to autosize plant loop flow rates and equipment capacities. This information is initially used by components that use water for heating or cooling such as hot or chilled water coils to calculate their maximum water flow rates. These flow rates are then summed for use in calculating the Plant Loop flow rates.")]
    [JsonObject("Sizing:Plant")]
    public class Sizing_Plant : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the name of a PlantLoop or a CondenserLoop object")]
        [JsonProperty("plant_or_condenser_loop_name")]
        public string PlantOrCondenserLoopName { get; set; } = "";
        

        [JsonProperty("loop_type")]
        public Sizing_Plant_LoopType LoopType { get; set; } = (Sizing_Plant_LoopType)Enum.Parse(typeof(Sizing_Plant_LoopType), "Condenser");
        

        [JsonProperty("design_loop_exit_temperature")]
        public System.Nullable<float> DesignLoopExitTemperature { get; set; } = null;
        

        [JsonProperty("loop_design_temperature_difference")]
        public System.Nullable<float> LoopDesignTemperatureDifference { get; set; } = null;
        

        [Description("if Coincident is chosen, then sizing is based on HVAC Sizing Simulations and the " +
                     "input field called Do HVAC Sizing Simulation for Sizing Periods in SimulationCon" +
                     "trol must be set to Yes")]
        [JsonProperty("sizing_option")]
        public Sizing_Plant_SizingOption SizingOption { get; set; } = (Sizing_Plant_SizingOption)Enum.Parse(typeof(Sizing_Plant_SizingOption), "NonCoincident");
        

        [Description("this is used in the coincident sizing algorithm to apply a running average to pea" +
                     "k flow rates that occur during HVAC Sizing Simulations")]
        [JsonProperty("zone_timesteps_in_averaging_window")]
        public System.Nullable<float> ZoneTimestepsInAveragingWindow { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("this is used to adjust the result for coincident sizing by applying a sizing fact" +
                     "or")]
        [JsonProperty("coincident_sizing_factor_mode")]
        public Sizing_Plant_CoincidentSizingFactorMode CoincidentSizingFactorMode { get; set; } = (Sizing_Plant_CoincidentSizingFactorMode)Enum.Parse(typeof(Sizing_Plant_CoincidentSizingFactorMode), "GlobalCoolingSizingFactor");
    }
}