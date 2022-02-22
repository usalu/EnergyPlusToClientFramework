using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("This object should only be used for non-standard weather data. Standard weather d" +
                 "ata such as TMY2, IWEC, and ASHRAE design day data are all measured at the defau" +
                 "lt conditions and do not require this object.")]
    [JsonObject("Site:WeatherStation")]
    public class Site_WeatherStation : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("wind_sensor_height_above_ground")]
        public System.Nullable<float> WindSensorHeightAboveGround { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [JsonProperty("wind_speed_profile_exponent")]
        public System.Nullable<float> WindSpeedProfileExponent { get; set; } = (System.Nullable<float>)Single.Parse("0.14", CultureInfo.InvariantCulture);
        

        [JsonProperty("wind_speed_profile_boundary_layer_thickness")]
        public System.Nullable<float> WindSpeedProfileBoundaryLayerThickness { get; set; } = (System.Nullable<float>)Single.Parse("270", CultureInfo.InvariantCulture);
        

        [JsonProperty("air_temperature_sensor_height_above_ground")]
        public System.Nullable<float> AirTemperatureSensorHeightAboveGround { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
    }
}