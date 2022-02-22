using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("These temperatures are specifically for underground walls and ground floors defin" +
                 "ed with the C-factor and F-factor methods, and should be close to the monthly av" +
                 "erage outdoor air temperature delayed by 3 months for the location.")]
    public class Site_GroundTemperature_FCfactorMethod : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("january_ground_temperature")]
        public System.Nullable<float> JanuaryGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("february_ground_temperature")]
        public System.Nullable<float> FebruaryGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("march_ground_temperature")]
        public System.Nullable<float> MarchGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("april_ground_temperature")]
        public System.Nullable<float> AprilGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("may_ground_temperature")]
        public System.Nullable<float> MayGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("june_ground_temperature")]
        public System.Nullable<float> JuneGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("july_ground_temperature")]
        public System.Nullable<float> JulyGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("august_ground_temperature")]
        public System.Nullable<float> AugustGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("september_ground_temperature")]
        public System.Nullable<float> SeptemberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("october_ground_temperature")]
        public System.Nullable<float> OctoberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("november_ground_temperature")]
        public System.Nullable<float> NovemberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("december_ground_temperature")]
        public System.Nullable<float> DecemberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
    }
}