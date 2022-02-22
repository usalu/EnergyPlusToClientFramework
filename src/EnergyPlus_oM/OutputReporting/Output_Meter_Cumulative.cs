using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"Each Output:Meter:Cumulative command picks meters to be reported cumulatively onto the standard output file (.eso) and meter file (.mtr). Not all meters are reported in every simulation. a list of meters that can be reported are available after a run on the meter dictionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    public class Output_Meter_Cumulative : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Form is EnergyUseType:..., e.g. Electricity:* for all Electricity meters or EndUs" +
                     "e:..., e.g. GeneralLights:* for all General Lights Output:Meter:Cumulative puts " +
                     "results on both the eplusout.mtr and eplusout.eso files")]
        [JsonProperty("key_name")]
        public string KeyName { get; set; } = "";
        

        [Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
                     "and Environment are the same")]
        [JsonProperty("reporting_frequency")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_Meter_Cumulative_ReportingFrequency ReportingFrequency { get; set; } = (Output_Meter_Cumulative_ReportingFrequency)Enum.Parse(typeof(Output_Meter_Cumulative_ReportingFrequency), "Hourly");
    }
}