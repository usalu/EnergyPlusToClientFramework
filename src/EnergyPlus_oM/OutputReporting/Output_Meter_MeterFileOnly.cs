using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"Each Output:Meter:MeterFileOnly command picks meters to be put only onto meter file (.mtr). Not all meters are reported in every simulation. A list of meters that can be reported a list of meters that can be reported are available after a run on the meter dictionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Meter_MeterFileOnly : BHoMObject
    {
        

        [Description("Form is EnergyUseType:..., e.g. Electricity:* for all Electricity meters or EndUs" +
                     "e:..., e.g. GeneralLights:* for all General Lights Output:Meter:MeterFileOnly pu" +
                     "ts results on the eplusout.mtr file only")]
        [JsonProperty("key_name")]
        public string KeyName { get; set; } = "";
        

        [Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
                     "and Environment are the same")]
        [JsonProperty("reporting_frequency")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_Meter_MeterFileOnly_ReportingFrequency ReportingFrequency { get; set; } = (Output_Meter_MeterFileOnly_ReportingFrequency)Enum.Parse(typeof(Output_Meter_MeterFileOnly_ReportingFrequency), "Hourly");
    }
}