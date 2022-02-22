using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description("This object declares an FMU")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ExternalInterface_FunctionalMockupUnitImport : BHoMObject
    {
        

        [JsonProperty("fmu_file_name")]
        public string FmuFileName { get; set; } = "";
        

        [Description("in milli-seconds")]
        [JsonProperty("fmu_timeout")]
        public System.Nullable<float> FmuTimeout { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("fmu_loggingon")]
        public System.Nullable<float> FmuLoggingon { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}