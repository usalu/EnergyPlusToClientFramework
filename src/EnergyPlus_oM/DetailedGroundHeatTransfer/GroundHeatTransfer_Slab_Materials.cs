using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Object gives an overall description of the slab ground heat transfer model.")]
    public class GroundHeatTransfer_Slab_Materials : BHoMObject, IEnergyPlusClass
    {
        

        [Description("This field specifies the number of different materials that will be used in the m" +
                     "odel. Typically only a ground material and a slab material are used. (2 material" +
                     "s)")]
        [JsonProperty("nmat_number_of_materials")]
        public System.Nullable<float> NmatNumberOfMaterials { get; set; } = null;
        

        [Description(@"Two fields specify the albedo value of the surface: first for no snow coverage days; second for days with snow coverage. The albedo is the solar reflectivity of the surface, and can vary from 0.05 for blacktop to 0.95 for fresh snow. Typical values for North America reported by Bahnfleth range from 0.16 to 0.4.")]
        [JsonProperty("albedo_surface_albedo_no_snow")]
        public System.Nullable<float> AlbedoSurfaceAlbedoNoSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.16", CultureInfo.InvariantCulture);
        

        [JsonProperty("albedo_surface_albedo_snow")]
        public System.Nullable<float> AlbedoSurfaceAlbedoSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [Description("EPSLW (No Snow and Snow) specifies the long wavelength (thermal) emissivity of th" +
                     "e ground surface. primarily important for nighttime radiation to sky. typical va" +
                     "lue .95")]
        [JsonProperty("epslw_surface_emissivity_no_snow")]
        public System.Nullable<float> EpslwSurfaceEmissivityNoSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.94", CultureInfo.InvariantCulture);
        

        [JsonProperty("epslw_surface_emissivity_snow")]
        public System.Nullable<float> EpslwSurfaceEmissivitySnow { get; set; } = (System.Nullable<float>)Single.Parse("0.86", CultureInfo.InvariantCulture);
        

        [Description("fields Z0 (No Snow and Snow) describe the height at which an experimentally veloc" +
                     "ity profile goes to zero. typical value= .75 cm")]
        [JsonProperty("z0_surface_roughness_no_snow")]
        public System.Nullable<float> Z0SurfaceRoughnessNoSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.75", CultureInfo.InvariantCulture);
        

        [Description("typical value= .05 cm")]
        [JsonProperty("z0_surface_roughness_snow")]
        public System.Nullable<float> Z0SurfaceRoughnessSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

        [Description(@"These fields specify the combined convective and radiative heat transfer coefficient between the slab top inside surface and the room air for the cases where heat is flowing downward, and upward. The program toggles between the two if the direction of the heat flux changes. Typical values can be found in the ASHRAE Handbook of Fundamentals, but should be about 6 W/(m2-K) for downward heat flow and 9 W/(m2-K) for upward heat flow. typical value= 4-10")]
        [JsonProperty("hin_indoor_hconv_downward_flow")]
        public System.Nullable<float> HinIndoorHconvDownwardFlow { get; set; } = (System.Nullable<float>)Single.Parse("6.13", CultureInfo.InvariantCulture);
        

        [Description("typical value= 4-10")]
        [JsonProperty("hin_indoor_hconv_upward")]
        public System.Nullable<float> HinIndoorHconvUpward { get; set; } = (System.Nullable<float>)Single.Parse("9.26", CultureInfo.InvariantCulture);
    }
}