using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description(@"This object is used if the user requires advanced control over height-dependent variations in wind speed and temperature. When this object is not present, the default model for temperature dependence on height is used, and the wind speed is modeled according to the Terrain field of the BUILDING object.")]
    [JsonObject("Site:HeightVariation")]
    public class Site_HeightVariation : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Set to zero for no wind speed dependence on height.")]
        [JsonProperty("wind_speed_profile_exponent")]
        public System.Nullable<float> WindSpeedProfileExponent { get; set; } = (System.Nullable<float>)Single.Parse("0.22", CultureInfo.InvariantCulture);
        

        [JsonProperty("wind_speed_profile_boundary_layer_thickness")]
        public System.Nullable<float> WindSpeedProfileBoundaryLayerThickness { get; set; } = (System.Nullable<float>)Single.Parse("370", CultureInfo.InvariantCulture);
        

        [Description("Set to zero for no air temperature dependence on height.")]
        [JsonProperty("air_temperature_gradient_coefficient")]
        public System.Nullable<float> AirTemperatureGradientCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0.0065", CultureInfo.InvariantCulture);
    }
}