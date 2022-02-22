using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Specifies the ground reflectance values used to calculate ground reflected solar." +
                 " The ground reflectance can be further modified when snow is on the ground by Si" +
                 "te:GroundReflectance:SnowModifier.")]
    public class Site_GroundReflectance : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("january_ground_reflectance")]
        public System.Nullable<float> JanuaryGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("february_ground_reflectance")]
        public System.Nullable<float> FebruaryGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("march_ground_reflectance")]
        public System.Nullable<float> MarchGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("april_ground_reflectance")]
        public System.Nullable<float> AprilGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("may_ground_reflectance")]
        public System.Nullable<float> MayGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("june_ground_reflectance")]
        public System.Nullable<float> JuneGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("july_ground_reflectance")]
        public System.Nullable<float> JulyGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("august_ground_reflectance")]
        public System.Nullable<float> AugustGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("september_ground_reflectance")]
        public System.Nullable<float> SeptemberGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("october_ground_reflectance")]
        public System.Nullable<float> OctoberGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("november_ground_reflectance")]
        public System.Nullable<float> NovemberGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("december_ground_reflectance")]
        public System.Nullable<float> DecemberGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
    }
}