using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("This object is used to define coefficients for the approach temperature correlati" +
                 "on for a variable speed cooling tower when tower Model Type is specified as Cool" +
                 "ToolsUserDefined in the object CoolingTower:VariableSpeed.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class CoolingTowerPerformance_CoolTools : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Minimum valid inlet air wet-bulb temperature for this approach temperature correl" +
                     "ation.")]
        [JsonProperty("minimum_inlet_air_wet_bulb_temperature")]
        public System.Nullable<float> MinimumInletAirWetBulbTemperature { get; set; } = null;
        

        [Description("Maximum valid inlet air wet-bulb temperature for this approach temperature correl" +
                     "ation.")]
        [JsonProperty("maximum_inlet_air_wet_bulb_temperature")]
        public System.Nullable<float> MaximumInletAirWetBulbTemperature { get; set; } = null;
        

        [Description("Minimum valid range temperature for this approach temperature correlation.")]
        [JsonProperty("minimum_range_temperature")]
        public System.Nullable<float> MinimumRangeTemperature { get; set; } = null;
        

        [Description("Maximum valid range temperature for this approach temperature correlation.")]
        [JsonProperty("maximum_range_temperature")]
        public System.Nullable<float> MaximumRangeTemperature { get; set; } = null;
        

        [Description("Minimum valid approach temperature for this correlation.")]
        [JsonProperty("minimum_approach_temperature")]
        public System.Nullable<float> MinimumApproachTemperature { get; set; } = null;
        

        [Description("Maximum valid approach temperature for this correlation.")]
        [JsonProperty("maximum_approach_temperature")]
        public System.Nullable<float> MaximumApproachTemperature { get; set; } = null;
        

        [Description("Minimum valid water flow rate ratio for this approach temperature correlation.")]
        [JsonProperty("minimum_water_flow_rate_ratio")]
        public System.Nullable<float> MinimumWaterFlowRateRatio { get; set; } = null;
        

        [Description("Maximum valid water flow rate ratio for this approach temperature correlation.")]
        [JsonProperty("maximum_water_flow_rate_ratio")]
        public System.Nullable<float> MaximumWaterFlowRateRatio { get; set; } = null;
        

        [JsonProperty("coefficient_1")]
        public System.Nullable<float> Coefficient1 { get; set; } = null;
        

        [JsonProperty("coefficient_2")]
        public System.Nullable<float> Coefficient2 { get; set; } = null;
        

        [JsonProperty("coefficient_3")]
        public System.Nullable<float> Coefficient3 { get; set; } = null;
        

        [JsonProperty("coefficient_4")]
        public System.Nullable<float> Coefficient4 { get; set; } = null;
        

        [JsonProperty("coefficient_5")]
        public System.Nullable<float> Coefficient5 { get; set; } = null;
        

        [JsonProperty("coefficient_6")]
        public System.Nullable<float> Coefficient6 { get; set; } = null;
        

        [JsonProperty("coefficient_7")]
        public System.Nullable<float> Coefficient7 { get; set; } = null;
        

        [JsonProperty("coefficient_8")]
        public System.Nullable<float> Coefficient8 { get; set; } = null;
        

        [JsonProperty("coefficient_9")]
        public System.Nullable<float> Coefficient9 { get; set; } = null;
        

        [JsonProperty("coefficient_10")]
        public System.Nullable<float> Coefficient10 { get; set; } = null;
        

        [JsonProperty("coefficient_11")]
        public System.Nullable<float> Coefficient11 { get; set; } = null;
        

        [JsonProperty("coefficient_12")]
        public System.Nullable<float> Coefficient12 { get; set; } = null;
        

        [JsonProperty("coefficient_13")]
        public System.Nullable<float> Coefficient13 { get; set; } = null;
        

        [JsonProperty("coefficient_14")]
        public System.Nullable<float> Coefficient14 { get; set; } = null;
        

        [JsonProperty("coefficient_15")]
        public System.Nullable<float> Coefficient15 { get; set; } = null;
        

        [JsonProperty("coefficient_16")]
        public System.Nullable<float> Coefficient16 { get; set; } = null;
        

        [JsonProperty("coefficient_17")]
        public System.Nullable<float> Coefficient17 { get; set; } = null;
        

        [JsonProperty("coefficient_18")]
        public System.Nullable<float> Coefficient18 { get; set; } = null;
        

        [JsonProperty("coefficient_19")]
        public System.Nullable<float> Coefficient19 { get; set; } = null;
        

        [JsonProperty("coefficient_20")]
        public System.Nullable<float> Coefficient20 { get; set; } = null;
        

        [JsonProperty("coefficient_21")]
        public System.Nullable<float> Coefficient21 { get; set; } = null;
        

        [JsonProperty("coefficient_22")]
        public System.Nullable<float> Coefficient22 { get; set; } = null;
        

        [JsonProperty("coefficient_23")]
        public System.Nullable<float> Coefficient23 { get; set; } = null;
        

        [JsonProperty("coefficient_24")]
        public System.Nullable<float> Coefficient24 { get; set; } = null;
        

        [JsonProperty("coefficient_25")]
        public System.Nullable<float> Coefficient25 { get; set; } = null;
        

        [JsonProperty("coefficient_26")]
        public System.Nullable<float> Coefficient26 { get; set; } = null;
        

        [JsonProperty("coefficient_27")]
        public System.Nullable<float> Coefficient27 { get; set; } = null;
        

        [JsonProperty("coefficient_28")]
        public System.Nullable<float> Coefficient28 { get; set; } = null;
        

        [JsonProperty("coefficient_29")]
        public System.Nullable<float> Coefficient29 { get; set; } = null;
        

        [JsonProperty("coefficient_30")]
        public System.Nullable<float> Coefficient30 { get; set; } = null;
        

        [JsonProperty("coefficient_31")]
        public System.Nullable<float> Coefficient31 { get; set; } = null;
        

        [JsonProperty("coefficient_32")]
        public System.Nullable<float> Coefficient32 { get; set; } = null;
        

        [JsonProperty("coefficient_33")]
        public System.Nullable<float> Coefficient33 { get; set; } = null;
        

        [JsonProperty("coefficient_34")]
        public System.Nullable<float> Coefficient34 { get; set; } = null;
        

        [JsonProperty("coefficient_35")]
        public System.Nullable<float> Coefficient35 { get; set; } = null;
    }
}