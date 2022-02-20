using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description("Earth Tube is specified as a design level which is modified by a Schedule fractio" +
                 "n, temperature difference and wind speed: Earthtube=Edesign * Fschedule * (A + B" +
                 "*|(Tzone-Todb)| + C*WindSpd + D * WindSpd**2)")]
    [JsonObject("ZoneEarthtube")]
    public class ZoneEarthtube : BHoMObject
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [Description("\"Edesign\" in Equation")]
        [JsonProperty("design_flow_rate")]
        public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

        [Description("this is the indoor temperature below which the earth tube is shut off")]
        [JsonProperty("minimum_zone_temperature_when_cooling")]
        public System.Nullable<float> MinimumZoneTemperatureWhenCooling { get; set; } = null;
        

        [Description("this is the indoor temperature above which the earth tube is shut off")]
        [JsonProperty("maximum_zone_temperature_when_heating")]
        public System.Nullable<float> MaximumZoneTemperatureWhenHeating { get; set; } = null;
        

        [Description("This is the temperature difference between indoor and outdoor below which the ear" +
                     "th tube is shut off")]
        [JsonProperty("delta_temperature")]
        public System.Nullable<float> DeltaTemperature { get; set; } = null;
        

        [JsonProperty("earthtube_type")]
        public EmptyNoYes EarthtubeType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Natural");
        

        [Description("pressure rise across the fan")]
        [JsonProperty("fan_pressure_rise")]
        public System.Nullable<float> FanPressureRise { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("fan_total_efficiency")]
        public System.Nullable<float> FanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_radius")]
        public System.Nullable<float> PipeRadius { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_thickness")]
        public System.Nullable<float> PipeThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_length")]
        public System.Nullable<float> PipeLength { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_thermal_conductivity")]
        public System.Nullable<float> PipeThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("200", CultureInfo.InvariantCulture);
        

        [JsonProperty("pipe_depth_under_ground_surface")]
        public System.Nullable<float> PipeDepthUnderGroundSurface { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_condition")]
        public EmptyNoYes SoilCondition { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "HeavyAndDamp");
        

        [JsonProperty("average_soil_surface_temperature")]
        public System.Nullable<float> AverageSoilSurfaceTemperature { get; set; } = null;
        

        [JsonProperty("amplitude_of_soil_surface_temperature")]
        public System.Nullable<float> AmplitudeOfSoilSurfaceTemperature { get; set; } = null;
        

        [JsonProperty("phase_constant_of_soil_surface_temperature")]
        public System.Nullable<float> PhaseConstantOfSoilSurfaceTemperature { get; set; } = null;
        

        [Description("\"A\" in Equation")]
        [JsonProperty("constant_term_flow_coefficient")]
        public System.Nullable<float> ConstantTermFlowCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("\"B\" in Equation")]
        [JsonProperty("temperature_term_flow_coefficient")]
        public System.Nullable<float> TemperatureTermFlowCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("\"C\" in Equation")]
        [JsonProperty("velocity_term_flow_coefficient")]
        public System.Nullable<float> VelocityTermFlowCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("\"D\" in Equation")]
        [JsonProperty("velocity_squared_term_flow_coefficient")]
        public System.Nullable<float> VelocitySquaredTermFlowCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}