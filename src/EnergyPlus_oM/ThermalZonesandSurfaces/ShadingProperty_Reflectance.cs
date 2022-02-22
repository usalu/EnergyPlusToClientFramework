using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("If this object is not defined for a shading surface the default values listed in " +
                 "following fields will be used in the solar reflection calculation.")]
    public class ShadingProperty_Reflectance : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("shading_surface_name")]
        public string ShadingSurfaceName { get; set; } = "";
        

        [JsonProperty("diffuse_solar_reflectance_of_unglazed_part_of_shading_surface")]
        public System.Nullable<float> DiffuseSolarReflectanceOfUnglazedPartOfShadingSurface { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("diffuse_visible_reflectance_of_unglazed_part_of_shading_surface")]
        public System.Nullable<float> DiffuseVisibleReflectanceOfUnglazedPartOfShadingSurface { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("fraction_of_shading_surface_that_is_glazed")]
        public System.Nullable<float> FractionOfShadingSurfaceThatIsGlazed { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Required if Fraction of Shading Surface That Is Glazed > 0.0")]
        [JsonProperty("glazing_construction_name")]
        public string GlazingConstructionName { get; set; } = "";
    }
}