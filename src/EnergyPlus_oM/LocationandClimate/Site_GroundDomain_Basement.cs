using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Ground-coupled basement model for simulating basements or other underground zones" +
                 ".")]
    public class Site_GroundDomain_Basement : BHoMObject, IEnergyPlusClass
    {
        

        [Description("The depth from ground surface to the deep ground boundary of the domain.")]
        [JsonProperty("ground_domain_depth")]
        public System.Nullable<float> GroundDomainDepth { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("This defines the height to width ratio of the basement zone.")]
        [JsonProperty("aspect_ratio")]
        public System.Nullable<float> AspectRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The distance from the basement wall edge to the edge of the ground domain")]
        [JsonProperty("perimeter_offset")]
        public System.Nullable<float> PerimeterOffset { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_thermal_conductivity")]
        public System.Nullable<float> SoilThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_density")]
        public System.Nullable<float> SoilDensity { get; set; } = (System.Nullable<float>)Single.Parse("2800", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_specific_heat")]
        public System.Nullable<float> SoilSpecificHeat { get; set; } = (System.Nullable<float>)Single.Parse("850", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_moisture_content_volume_fraction")]
        public System.Nullable<float> SoilMoistureContentVolumeFraction { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_moisture_content_volume_fraction_at_saturation")]
        public System.Nullable<float> SoilMoistureContentVolumeFractionAtSaturation { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [JsonProperty("undisturbed_ground_temperature_model_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Site_GroundDomain_Basement_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (Site_GroundDomain_Basement_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(Site_GroundDomain_Basement_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

        [JsonProperty("undisturbed_ground_temperature_model_name")]
        public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

        [Description(@"This specifies the ground cover effects during evapotranspiration calculations. The value roughly represents the following cases: = 0   : concrete or other solid, non-permeable ground surface material = 0.5 : short grass, much like a manicured lawn = 1   : standard reference state (12 cm grass) = 1.5 : wild growth")]
        [JsonProperty("evapotranspiration_ground_cover_parameter")]
        public System.Nullable<float> EvapotranspirationGroundCoverParameter { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty("basement_floor_boundary_condition_model_name")]
        public string BasementFloorBoundaryConditionModelName { get; set; } = "";
        

        [Description("This field specifies the presence of insulation beneath the basement floor.")]
        [JsonProperty("horizontal_insulation")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes HorizontalInsulation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("horizontal_insulation_material_name")]
        public string HorizontalInsulationMaterialName { get; set; } = "";
        

        [Description("This field specifies whether the horizontal insulation fully insulates the surfac" +
                     "e or is perimeter only insulation")]
        [JsonProperty("horizontal_insulation_extents")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Site_GroundDomain_Basement_HorizontalInsulationExtents HorizontalInsulationExtents { get; set; } = (Site_GroundDomain_Basement_HorizontalInsulationExtents)Enum.Parse(typeof(Site_GroundDomain_Basement_HorizontalInsulationExtents), "Full");
        

        [Description("Width of horizontal perimeter insulation measured from foundation wall inside sur" +
                     "face.")]
        [JsonProperty("perimeter_horizontal_insulation_width")]
        public System.Nullable<float> PerimeterHorizontalInsulationWidth { get; set; } = null;
        

        [Description("Depth measured from ground surface.")]
        [JsonProperty("basement_wall_depth")]
        public System.Nullable<float> BasementWallDepth { get; set; } = null;
        

        [JsonProperty("basement_wall_boundary_condition_model_name")]
        public string BasementWallBoundaryConditionModelName { get; set; } = "";
        

        [JsonProperty("vertical_insulation")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes VerticalInsulation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("basement_wall_vertical_insulation_material_name")]
        public string BasementWallVerticalInsulationMaterialName { get; set; } = "";
        

        [Description("Depth measured from the ground surface.")]
        [JsonProperty("vertical_insulation_depth")]
        public System.Nullable<float> VerticalInsulationDepth { get; set; } = null;
        

        [Description("This field specifies the basement domain simulation interval.")]
        [JsonProperty("simulation_timestep")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Site_GroundDomain_Basement_SimulationTimestep SimulationTimestep { get; set; } = (Site_GroundDomain_Basement_SimulationTimestep)Enum.Parse(typeof(Site_GroundDomain_Basement_SimulationTimestep), "Hourly");
        

        [JsonProperty("mesh_density_parameter")]
        public System.Nullable<float> MeshDensityParameter { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
    }
}