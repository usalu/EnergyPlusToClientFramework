using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Hot water heating coil, NTU-effectiveness model, assumes a cross-flow heat exchan" +
                 "ger. Two options for capacity inputs: UA and water flow rate or capacity and des" +
                 "ign temperatures.")]
    [JsonObject("Coil:Heating:Water")]
    public class Coil_Heating_Water : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("UA value under rating conditions")]
        [JsonProperty("u_factor_times_area_value")]
        public string UFactorTimesAreaValue { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("maximum_water_flow_rate")]
        public string MaximumWaterFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("water_inlet_node_name")]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty("water_outlet_node_name")]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("performance_input_method")]
        public EmptyNoYes PerformanceInputMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "UFactorTimesAreaAndDesignWaterFlowRate");
        

        [JsonProperty("rated_capacity")]
        public string RatedCapacity { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("rated_inlet_water_temperature")]
        public System.Nullable<float> RatedInletWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("82.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("rated_inlet_air_temperature")]
        public System.Nullable<float> RatedInletAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16.6", CultureInfo.InvariantCulture);
        

        [JsonProperty("rated_outlet_water_temperature")]
        public System.Nullable<float> RatedOutletWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("71.1", CultureInfo.InvariantCulture);
        

        [JsonProperty("rated_outlet_air_temperature")]
        public System.Nullable<float> RatedOutletAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("32.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("rated_ratio_for_air_and_water_convection")]
        public System.Nullable<float> RatedRatioForAirAndWaterConvection { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("This input field is optional. If specified, it is used for sizing the Design Wate" +
                     "r Flow Rate. If blank or omitted, the Loop Design Temperature Difference value s" +
                     "pecified in Sizing:Plant object is used for sizing the Design Water Flow Rate.")]
        [JsonProperty("design_water_temperature_difference")]
        public System.Nullable<float> DesignWaterTemperatureDifference { get; set; } = null;
    }
}