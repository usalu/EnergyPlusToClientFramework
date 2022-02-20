using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("ComBldg contains the monthly average temperatures (C) and possibility of daily va" +
                 "riation amplitude")]
    [JsonObject("GroundHeatTransfer:Basement:ComBldg")]
    public class GroundHeatTransfer_Basement_ComBldg : BHoMObject
    {
        

        [JsonProperty("january_average_temperature")]
        public System.Nullable<float> JanuaryAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty("february_average_temperature")]
        public System.Nullable<float> FebruaryAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty("march_average_temperature")]
        public System.Nullable<float> MarchAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty("april_average_temperature")]
        public System.Nullable<float> AprilAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty("may_average_temperature")]
        public System.Nullable<float> MayAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty("june_average_temperature")]
        public System.Nullable<float> JuneAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty("july_average_temperature")]
        public System.Nullable<float> JulyAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty("august_average_temperature")]
        public System.Nullable<float> AugustAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty("september_average_temperature")]
        public System.Nullable<float> SeptemberAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty("october_average_temperature")]
        public System.Nullable<float> OctoberAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty("november_average_temperature")]
        public System.Nullable<float> NovemberAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty("december_average_temperature")]
        public System.Nullable<float> DecemberAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("(Normally zero, just for checking)")]
        [JsonProperty("daily_variation_sine_wave_amplitude")]
        public System.Nullable<float> DailyVariationSineWaveAmplitude { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}