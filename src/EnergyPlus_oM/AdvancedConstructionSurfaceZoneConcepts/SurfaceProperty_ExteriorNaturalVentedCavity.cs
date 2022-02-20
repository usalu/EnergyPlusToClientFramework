using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Used to describe the decoupled layer, or baffle, and the characteristics of the c" +
                 "avity and openings for naturally ventilated exterior surfaces. This object is al" +
                 "so used in conjunction with the OtherSideConditionsModel.")]
    [JsonObject("SurfaceProperty:ExteriorNaturalVentedCavity")]
    public class SurfaceProperty_ExteriorNaturalVentedCavity : BHoMObject
    {
        

        [Description("Enter the name of a SurfaceProperty:OtherSideConditionsModel object")]
        [JsonProperty("boundary_conditions_model_name")]
        public string BoundaryConditionsModelName { get; set; } = "";
        

        [JsonProperty("area_fraction_of_openings")]
        public System.Nullable<float> AreaFractionOfOpenings { get; set; } = null;
        

        [JsonProperty("thermal_emissivity_of_exterior_baffle_material")]
        public System.Nullable<float> ThermalEmissivityOfExteriorBaffleMaterial { get; set; } = null;
        

        [JsonProperty("solar_absorbtivity_of_exterior_baffle")]
        public System.Nullable<float> SolarAbsorbtivityOfExteriorBaffle { get; set; } = null;
        

        [JsonProperty("height_scale_for_buoyancy_driven_ventilation")]
        public System.Nullable<float> HeightScaleForBuoyancyDrivenVentilation { get; set; } = null;
        

        [Description("if corrugated, use average depth")]
        [JsonProperty("effective_thickness_of_cavity_behind_exterior_baffle")]
        public System.Nullable<float> EffectiveThicknessOfCavityBehindExteriorBaffle { get; set; } = null;
        

        [Description("this parameter is used to help account for corrugations in the collector")]
        [JsonProperty("ratio_of_actual_surface_area_to_projected_surface_area")]
        public System.Nullable<float> RatioOfActualSurfaceAreaToProjectedSurfaceArea { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("roughness_of_exterior_surface")]
        public EmptyNoYes RoughnessOfExteriorSurface { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("effectiveness_for_perforations_with_respect_to_wind")]
        public System.Nullable<float> EffectivenessForPerforationsWithRespectToWind { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

        [JsonProperty("discharge_coefficient_for_openings_with_respect_to_buoyancy_driven_flow")]
        public System.Nullable<float> DischargeCoefficientForOpeningsWithRespectToBuoyancyDrivenFlow { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

        [JsonProperty("surface")]
        public string Surface { get; set; } = "";
    }
}