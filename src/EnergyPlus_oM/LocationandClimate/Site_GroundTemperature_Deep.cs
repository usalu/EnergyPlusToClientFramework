using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("These temperatures are specifically for the ground heat exchangers that would use" +
                 " \"deep\" (3-4 m depth) ground temperatures for their heat source. They are not us" +
                 "ed in other models.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_Deep : BHoMObject
    {
        

        [JsonProperty("january_deep_ground_temperature")]
        public System.Nullable<float> JanuaryDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty("february_deep_ground_temperature")]
        public System.Nullable<float> FebruaryDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty("march_deep_ground_temperature")]
        public System.Nullable<float> MarchDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty("april_deep_ground_temperature")]
        public System.Nullable<float> AprilDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty("may_deep_ground_temperature")]
        public System.Nullable<float> MayDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty("june_deep_ground_temperature")]
        public System.Nullable<float> JuneDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty("july_deep_ground_temperature")]
        public System.Nullable<float> JulyDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty("august_deep_ground_temperature")]
        public System.Nullable<float> AugustDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty("september_deep_ground_temperature")]
        public System.Nullable<float> SeptemberDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty("october_deep_ground_temperature")]
        public System.Nullable<float> OctoberDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty("november_deep_ground_temperature")]
        public System.Nullable<float> NovemberDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty("december_deep_ground_temperature")]
        public System.Nullable<float> DecemberDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
    }
}