using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Specifies the soil surface properties for the Basement preprocessor ground heat t" +
                 "ransfer simulation.")]
    [JsonObject("GroundHeatTransfer:Basement:SurfaceProps")]
    public class GroundHeatTransfer_Basement_SurfaceProps : BHoMObject
    {
        

        [JsonProperty("albedo_surface_albedo_for_no_snow_conditions")]
        public System.Nullable<float> AlbedoSurfaceAlbedoForNoSnowConditions { get; set; } = (System.Nullable<float>)Single.Parse("0.16", CultureInfo.InvariantCulture);
        

        [JsonProperty("albedo_surface_albedo_for_snow_conditions")]
        public System.Nullable<float> AlbedoSurfaceAlbedoForSnowConditions { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty("epsln_surface_emissivity_no_snow")]
        public System.Nullable<float> EpslnSurfaceEmissivityNoSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.94", CultureInfo.InvariantCulture);
        

        [JsonProperty("epsln_surface_emissivity_with_snow")]
        public System.Nullable<float> EpslnSurfaceEmissivityWithSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.86", CultureInfo.InvariantCulture);
        

        [JsonProperty("veght_surface_roughness_no_snow_conditions")]
        public System.Nullable<float> VeghtSurfaceRoughnessNoSnowConditions { get; set; } = (System.Nullable<float>)Single.Parse("6", CultureInfo.InvariantCulture);
        

        [JsonProperty("veght_surface_roughness_snow_conditions")]
        public System.Nullable<float> VeghtSurfaceRoughnessSnowConditions { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

        [Description("Typically, PET is False")]
        [JsonProperty("pet_flag_potential_evapotranspiration_on_")]
        public EmptyNoYes PetFlagPotentialEvapotranspirationOn { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "FALSE");
    }
}