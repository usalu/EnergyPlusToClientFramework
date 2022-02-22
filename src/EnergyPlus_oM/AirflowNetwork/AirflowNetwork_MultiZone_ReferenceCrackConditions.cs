using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object specifies the conditions under which the air mass flow coefficient wa" +
                 "s measured.")]
    public class AirflowNetwork_MultiZone_ReferenceCrackConditions : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the reference temperature under which the surface crack data were obtained." +
                     "")]
        [JsonProperty("reference_temperature")]
        public System.Nullable<float> ReferenceTemperature { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

        [Description("Enter the reference barometric pressure under which the surface crack data were o" +
                     "btained.")]
        [JsonProperty("reference_barometric_pressure")]
        public System.Nullable<float> ReferenceBarometricPressure { get; set; } = (System.Nullable<float>)Single.Parse("101325", CultureInfo.InvariantCulture);
        

        [Description("Enter the reference humidity ratio under which the surface crack data were obtain" +
                     "ed.")]
        [JsonProperty("reference_humidity_ratio")]
        public System.Nullable<float> ReferenceHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}