using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"EcoRoof model, plant layer plus soil layer Implemented by Portland State University (Sailor et al., January, 2007) only one material must be referenced per simulation though the same EcoRoof material could be used in multiple constructions. New moisture redistribution scheme (2010) requires higher number of timesteps per hour (minimum 12 recommended).")]
    [JsonObject("Material:RoofVegetation")]
    public class Material_RoofVegetation : BHoMObject, IEnergyPlusClass
    {
        

        [Description("The ecoroof module is designed for short plants and shrubs.")]
        [JsonProperty("height_of_plants")]
        public System.Nullable<float> HeightOfPlants { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("Entire surface is assumed covered, so decrease LAI accordingly.")]
        [JsonProperty("leaf_area_index")]
        public System.Nullable<float> LeafAreaIndex { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Leaf reflectivity (albedo) is typically 0.18-0.25")]
        [JsonProperty("leaf_reflectivity")]
        public System.Nullable<float> LeafReflectivity { get; set; } = (System.Nullable<float>)Single.Parse("0.22", CultureInfo.InvariantCulture);
        

        [JsonProperty("leaf_emissivity")]
        public System.Nullable<float> LeafEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.95", CultureInfo.InvariantCulture);
        

        [Description("This depends upon plant type")]
        [JsonProperty("minimum_stomatal_resistance")]
        public System.Nullable<float> MinimumStomatalResistance { get; set; } = (System.Nullable<float>)Single.Parse("180", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_layer_name")]
        public string SoilLayerName { get; set; } = (System.String)"Green Roof Soil";
        

        [JsonProperty("roughness")]
        public Material_RoofVegetation_Roughness Roughness { get; set; } = (Material_RoofVegetation_Roughness)Enum.Parse(typeof(Material_RoofVegetation_Roughness), "MediumRough");
        

        [Description("thickness of the soil layer of the EcoRoof Soil depths of 0.15m (6in) and 0.30m (" +
                     "12in) are common.")]
        [JsonProperty("thickness")]
        public System.Nullable<float> Thickness { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description("Thermal conductivity of dry soil. Typical ecoroof soils range from 0.3 to 0.5")]
        [JsonProperty("conductivity_of_dry_soil")]
        public System.Nullable<float> ConductivityOfDrySoil { get; set; } = (System.Nullable<float>)Single.Parse("0.35", CultureInfo.InvariantCulture);
        

        [Description("Density of dry soil (the code modifies this as the soil becomes moist) Typical ec" +
                     "oroof soils range from 400 to 1000 (dry to wet)")]
        [JsonProperty("density_of_dry_soil")]
        public System.Nullable<float> DensityOfDrySoil { get; set; } = (System.Nullable<float>)Single.Parse("1100", CultureInfo.InvariantCulture);
        

        [Description("Specific heat of dry soil")]
        [JsonProperty("specific_heat_of_dry_soil")]
        public System.Nullable<float> SpecificHeatOfDrySoil { get; set; } = (System.Nullable<float>)Single.Parse("1200", CultureInfo.InvariantCulture);
        

        [Description("Soil emissivity is typically in range of 0.90 to 0.98")]
        [JsonProperty("thermal_absorptance")]
        public System.Nullable<float> ThermalAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Solar absorptance of dry soil (1-albedo) is typically 0.60 to 0.85 corresponding " +
                     "to a dry albedo of 0.15 to 0.40")]
        [JsonProperty("solar_absorptance")]
        public System.Nullable<float> SolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("visible_absorptance")]
        public System.Nullable<float> VisibleAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.75", CultureInfo.InvariantCulture);
        

        [Description("Maximum moisture content is typically less than 0.5")]
        [JsonProperty("saturation_volumetric_moisture_content_of_the_soil_layer")]
        public System.Nullable<float> SaturationVolumetricMoistureContentOfTheSoilLayer { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

        [JsonProperty("residual_volumetric_moisture_content_of_the_soil_layer")]
        public System.Nullable<float> ResidualVolumetricMoistureContentOfTheSoilLayer { get; set; } = (System.Nullable<float>)Single.Parse("0.01", CultureInfo.InvariantCulture);
        

        [JsonProperty("initial_volumetric_moisture_content_of_the_soil_layer")]
        public System.Nullable<float> InitialVolumetricMoistureContentOfTheSoilLayer { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description("Advanced calculation requires increased number of timesteps (recommended >20).")]
        [JsonProperty("moisture_diffusion_calculation_method")]
        public Material_RoofVegetation_MoistureDiffusionCalculationMethod MoistureDiffusionCalculationMethod { get; set; } = (Material_RoofVegetation_MoistureDiffusionCalculationMethod)Enum.Parse(typeof(Material_RoofVegetation_MoistureDiffusionCalculationMethod), "Advanced");
    }
}