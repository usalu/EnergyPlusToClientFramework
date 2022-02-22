using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("These temperatures are specifically for the Surface Ground Heat Exchanger and sho" +
                 "uld probably be close to the average outdoor air temperature for the location. T" +
                 "hey are not used in other models.")]
    public class Site_GroundTemperature_Shallow : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("january_surface_ground_temperature")]
        public System.Nullable<float> JanuarySurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("february_surface_ground_temperature")]
        public System.Nullable<float> FebruarySurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("march_surface_ground_temperature")]
        public System.Nullable<float> MarchSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("april_surface_ground_temperature")]
        public System.Nullable<float> AprilSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("may_surface_ground_temperature")]
        public System.Nullable<float> MaySurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("june_surface_ground_temperature")]
        public System.Nullable<float> JuneSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("july_surface_ground_temperature")]
        public System.Nullable<float> JulySurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("august_surface_ground_temperature")]
        public System.Nullable<float> AugustSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("september_surface_ground_temperature")]
        public System.Nullable<float> SeptemberSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("october_surface_ground_temperature")]
        public System.Nullable<float> OctoberSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("november_surface_ground_temperature")]
        public System.Nullable<float> NovemberSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("december_surface_ground_temperature")]
        public System.Nullable<float> DecemberSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
    }
}