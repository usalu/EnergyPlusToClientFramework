using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("This models a horizontal heat exchanger placed in a series of trenches The model " +
                 "uses the PipingSystem:Underground underlying algorithms, but provides a more usa" +
                 "ble input interface.")]
    public class GroundHeatExchanger_HorizontalTrench : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty("design_flow_rate")]
        public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

        [Description("This is the total pipe axial length of the heat exchanger If all pipe trenches ar" +
                     "e parallel, this is the length of a single trench. If a single, long run of pipe" +
                     " is used with one trench, this is the full length of the pipe run.")]
        [JsonProperty("trench_length_in_pipe_axial_direction")]
        public System.Nullable<float> TrenchLengthInPipeAxialDirection { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description("This is the number of horizontal legs that will be used in the entire heat exchan" +
                     "ger, one pipe per trench")]
        [JsonProperty("number_of_trenches")]
        public System.Nullable<float> NumberOfTrenches { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This represents the average horizontal spacing between any two trenches for heat " +
                     "exchangers that have multiple trenches")]
        [JsonProperty("horizontal_spacing_between_pipes")]
        public System.Nullable<float> HorizontalSpacingBetweenPipes { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_inner_diameter")]
        public System.Nullable<float> PipeInnerDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.016", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_outer_diameter")]
        public System.Nullable<float> PipeOuterDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.026", CultureInfo.InvariantCulture);
        

        [Description("This is the burial depth of the pipes, or the trenches containing the pipes")]
        [JsonProperty("burial_depth")]
        public System.Nullable<float> BurialDepth { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_thermal_conductivity")]
        public System.Nullable<float> SoilThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("1.08", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_density")]
        public System.Nullable<float> SoilDensity { get; set; } = (System.Nullable<float>)Single.Parse("962", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_specific_heat")]
        public System.Nullable<float> SoilSpecificHeat { get; set; } = (System.Nullable<float>)Single.Parse("2576", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_thermal_conductivity")]
        public System.Nullable<float> PipeThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.3895", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_density")]
        public System.Nullable<float> PipeDensity { get; set; } = (System.Nullable<float>)Single.Parse("641", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_specific_heat")]
        public System.Nullable<float> PipeSpecificHeat { get; set; } = (System.Nullable<float>)Single.Parse("2405", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_moisture_content_percent")]
        public System.Nullable<float> SoilMoistureContentPercent { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_moisture_content_percent_at_saturation")]
        public System.Nullable<float> SoilMoistureContentPercentAtSaturation { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [JsonProperty("undisturbed_ground_temperature_model_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatExchanger_HorizontalTrench_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (GroundHeatExchanger_HorizontalTrench_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(GroundHeatExchanger_HorizontalTrench_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

        [JsonProperty("undisturbed_ground_temperature_model_name")]
        public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

        [Description(@"This specifies the ground cover effects during evapotranspiration calculations. The value roughly represents the following cases: = 0   : concrete or other solid, non-permeable ground surface material = 0.5 : short grass, much like a manicured lawn = 1   : standard reference state (12 cm grass) = 1.5 : wild growth")]
        [JsonProperty("evapotranspiration_ground_cover_parameter")]
        public System.Nullable<float> EvapotranspirationGroundCoverParameter { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
    }
}