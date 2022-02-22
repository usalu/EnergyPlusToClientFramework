using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description(@"These temperatures are specifically for those surfaces that have the outside environment of ""Ground"". Documentation about what values these should be is located in the Auxiliary programs document (Ground Heat Transfer) as well as the InputOutput Reference. CAUTION - Do not use the ""undisturbed"" ground temperatures from the weather data. These values are too extreme for the soil under a conditioned building. For best results, use the Slab or Basement program to calculate custom monthly average ground temperatures (see Auxiliary Programs). For typical commercial buildings in the USA, a reasonable default value is 2C less than the average indoor space temperature.")]
    [JsonObject("Site:GroundTemperature:BuildingSurface")]
    public class Site_GroundTemperature_BuildingSurface : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("january_ground_temperature")]
        public System.Nullable<float> JanuaryGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty("february_ground_temperature")]
        public System.Nullable<float> FebruaryGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty("march_ground_temperature")]
        public System.Nullable<float> MarchGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty("april_ground_temperature")]
        public System.Nullable<float> AprilGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty("may_ground_temperature")]
        public System.Nullable<float> MayGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty("june_ground_temperature")]
        public System.Nullable<float> JuneGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty("july_ground_temperature")]
        public System.Nullable<float> JulyGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty("august_ground_temperature")]
        public System.Nullable<float> AugustGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty("september_ground_temperature")]
        public System.Nullable<float> SeptemberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty("october_ground_temperature")]
        public System.Nullable<float> OctoberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty("november_ground_temperature")]
        public System.Nullable<float> NovemberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty("december_ground_temperature")]
        public System.Nullable<float> DecemberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
    }
}