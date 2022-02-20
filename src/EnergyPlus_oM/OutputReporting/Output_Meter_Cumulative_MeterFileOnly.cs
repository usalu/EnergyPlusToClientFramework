using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"Each Output:Meter:Cumulative:MeterFileOnly command picks meters to be reported cumulatively onto the standard output file (.eso) and meter file (.mtr). Not all meters are reported in every simulation. a list of meters that can be reported are available after a run on the meter dictionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject("Output:Meter:Cumulative:MeterFileOnly")]
    public class Output_Meter_Cumulative_MeterFileOnly : BHoMObject
    {
        

        [Description("Form is EnergyUseType:..., e.g. Electricity:* for all Electricity meters or EndUs" +
                     "e:..., e.g. GeneralLights:* for all General Lights Output:Meter:Cumulative:Meter" +
                     "FileOnly puts results on the eplusout.mtr file only")]
        [JsonProperty("key_name")]
        public string KeyName { get; set; } = "";
        

        [Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
                     "and Environment are the same")]
        [JsonProperty("reporting_frequency")]
        public EmptyNoYes ReportingFrequency { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Hourly");
    }
}