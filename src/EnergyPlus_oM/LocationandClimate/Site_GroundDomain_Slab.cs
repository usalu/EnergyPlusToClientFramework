using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Ground-coupled slab model for on-grade and in-grade cases with or without insulat" +
                 "ion.")]
    [JsonObject("Site:GroundDomain:Slab")]
    public class Site_GroundDomain_Slab : BHoMObject
    {
        

        [JsonProperty("ground_domain_depth")]
        public System.Nullable<float> GroundDomainDepth { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [JsonProperty("aspect_ratio")]
        public System.Nullable<float> AspectRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

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
        public EmptyNoYes UndisturbedGroundTemperatureModelType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("undisturbed_ground_temperature_model_name")]
        public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

        [Description(@"This specifies the ground cover effects during evapotranspiration calculations. The value roughly represents the following cases: = 0   : concrete or other solid, non-permeable ground surface material = 0.5 : short grass, much like a manicured lawn = 1   : standard reference state (12 cm grass) = 1.5 : wild growth")]
        [JsonProperty("evapotranspiration_ground_cover_parameter")]
        public System.Nullable<float> EvapotranspirationGroundCoverParameter { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty("slab_boundary_condition_model_name")]
        public string SlabBoundaryConditionModelName { get; set; } = "";
        

        [Description("This field specifies whether the slab is located \"in-grade\" or \"on-grade\"")]
        [JsonProperty("slab_location")]
        public EmptyNoYes SlabLocation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Only applicable for the in-grade case")]
        [JsonProperty("slab_material_name")]
        public string SlabMaterialName { get; set; } = "";
        

        [Description("This field specifies the presence of insulation beneath the slab. Only required f" +
                     "or in-grade case.")]
        [JsonProperty("horizontal_insulation")]
        public EmptyNoYes HorizontalInsulation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("This field specifies the horizontal insulation material.")]
        [JsonProperty("horizontal_insulation_material_name")]
        public string HorizontalInsulationMaterialName { get; set; } = "";
        

        [Description("This field specifies whether the horizontal insulation fully insulates the surfac" +
                     "e or is perimeter only insulation")]
        [JsonProperty("horizontal_insulation_extents")]
        public EmptyNoYes HorizontalInsulationExtents { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Full");
        

        [Description("This field specifies the width of the underfloor perimeter insulation")]
        [JsonProperty("perimeter_insulation_width")]
        public System.Nullable<float> PerimeterInsulationWidth { get; set; } = null;
        

        [Description("This field specifies the presence of vertical insulation at the slab edge.")]
        [JsonProperty("vertical_insulation")]
        public EmptyNoYes VerticalInsulation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("This field specifies the vertical insulation material.")]
        [JsonProperty("vertical_insulation_material_name")]
        public string VerticalInsulationMaterialName { get; set; } = "";
        

        [Description("Only used when including vertical insulation This field specifies the depth of th" +
                     "e vertical insulation")]
        [JsonProperty("vertical_insulation_depth")]
        public System.Nullable<float> VerticalInsulationDepth { get; set; } = null;
        

        [Description("This field specifies the ground domain simulation timestep.")]
        [JsonProperty("simulation_timestep")]
        public EmptyNoYes SimulationTimestep { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Hourly");
        

        [JsonProperty("geometric_mesh_coefficient")]
        public System.Nullable<float> GeometricMeshCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1.6", CultureInfo.InvariantCulture);
        

        [JsonProperty("mesh_density_parameter")]
        public System.Nullable<float> MeshDensityParameter { get; set; } = (System.Nullable<float>)Single.Parse("6", CultureInfo.InvariantCulture);
    }
}