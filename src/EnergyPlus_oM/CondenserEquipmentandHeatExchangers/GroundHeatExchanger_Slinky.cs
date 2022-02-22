using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description(@"This models a slinky horizontal heat exchanger placed in a series of trenches The model uses the model developed by: Xiong, Z., D.E. Fisher, and J.D. Spitler. 2015. Development and Validation of a Slinky Ground Heat Exchanger Model. Applied Energy 141: 57-69.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatExchanger_Slinky : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty("design_flow_rate")]
        public System.Nullable<float> DesignFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0.002", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_thermal_conductivity")]
        public System.Nullable<float> SoilThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("1.08", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_density")]
        public System.Nullable<float> SoilDensity { get; set; } = (System.Nullable<float>)Single.Parse("962", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_specific_heat")]
        public System.Nullable<float> SoilSpecificHeat { get; set; } = (System.Nullable<float>)Single.Parse("2576", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_thermal_conductivity")]
        public System.Nullable<float> PipeThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_density")]
        public System.Nullable<float> PipeDensity { get; set; } = (System.Nullable<float>)Single.Parse("641", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_specific_heat")]
        public System.Nullable<float> PipeSpecificHeat { get; set; } = (System.Nullable<float>)Single.Parse("2405", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_outer_diameter")]
        public System.Nullable<float> PipeOuterDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.02667", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_thickness")]
        public System.Nullable<float> PipeThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.002413", CultureInfo.InvariantCulture);
        

        [Description("This is the orientation of the heat exchanger")]
        [JsonProperty("heat_exchanger_configuration")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatExchanger_Slinky_HeatExchangerConfiguration HeatExchangerConfiguration { get; set; } = (GroundHeatExchanger_Slinky_HeatExchangerConfiguration)Enum.Parse(typeof(GroundHeatExchanger_Slinky_HeatExchangerConfiguration), "Horizontal");
        

        [Description("This is the diameter of the heat exchanger coil")]
        [JsonProperty("coil_diameter")]
        public System.Nullable<float> CoilDiameter { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This is the center-to-center distance between coils")]
        [JsonProperty("coil_pitch")]
        public System.Nullable<float> CoilPitch { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("This is the distance from the ground surface to the trench bottom")]
        [JsonProperty("trench_depth")]
        public System.Nullable<float> TrenchDepth { get; set; } = (System.Nullable<float>)Single.Parse("1.8", CultureInfo.InvariantCulture);
        

        [Description("This is the total length of a single trench This assumes the heat exchanger runs " +
                     "the full length of the trench")]
        [JsonProperty("trench_length")]
        public System.Nullable<float> TrenchLength { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("This is the number of parallel trenches that has a heat exchanger, one per trench" +
                     "")]
        [JsonProperty("number_of_trenches")]
        public System.Nullable<float> NumberOfTrenches { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This represents the average horizontal spacing between any two trenches for heat " +
                     "exchangers that have multiple trenches")]
        [JsonProperty("horizontal_spacing_between_pipes")]
        public System.Nullable<float> HorizontalSpacingBetweenPipes { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [JsonProperty("undisturbed_ground_temperature_model_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatExchanger_Slinky_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (GroundHeatExchanger_Slinky_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(GroundHeatExchanger_Slinky_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

        [JsonProperty("undisturbed_ground_temperature_model_name")]
        public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

        [JsonProperty("maximum_length_of_simulation")]
        public System.Nullable<float> MaximumLengthOfSimulation { get; set; } = null;
    }
}