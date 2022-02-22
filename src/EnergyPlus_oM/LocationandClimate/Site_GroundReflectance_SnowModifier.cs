using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Specifies ground reflectance multipliers when snow resident on the ground. These " +
                 "multipliers are applied to the \"normal\" ground reflectances specified in Site:Gr" +
                 "oundReflectance.")]
    [JsonObject("Site:GroundReflectance:SnowModifier")]
    public class Site_GroundReflectance_SnowModifier : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"Value for modifying the ""normal"" ground reflectance when Snow is on ground when calculating the ""Ground Reflected Solar Radiation Value"" a value of 1.0 here uses the ""normal"" ground reflectance Ground Reflected Solar = (BeamSolar*CosSunZenith + DiffuseSolar)*GroundReflectance This would be further modified by the Snow Ground Reflectance Modifier when Snow was on the ground When Snow on ground, effective GroundReflectance is normal GroundReflectance*""Ground Reflectance Snow Modifier"" Ground Reflectance achieved in this manner will be restricted to [0.0,1.0]")]
        [JsonProperty("ground_reflected_solar_modifier")]
        public System.Nullable<float> GroundReflectedSolarModifier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"Value for modifying the ""normal"" daylighting ground reflectance when Snow is on ground when calculating the ""Ground Reflected Solar Radiation Value"" a value of 1.0 here uses the ""normal"" ground reflectance Ground Reflected Solar = (BeamSolar*CosSunZenith + DiffuseSolar)*GroundReflectance This would be further modified by the Snow Ground Reflectance Modifier when Snow was on the ground When Snow on ground, effective GroundReflectance is normal GroundReflectance*""Daylighting Ground Reflectance Snow Modifier"" Ground Reflectance achieved in this manner will be restricted to [0.0,1.0]")]
        [JsonProperty("daylighting_ground_reflected_solar_modifier")]
        public System.Nullable<float> DaylightingGroundReflectedSolarModifier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}