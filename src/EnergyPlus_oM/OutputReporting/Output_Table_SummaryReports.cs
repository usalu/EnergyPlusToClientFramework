using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"This object allows the user to call report types that are predefined and will appear with the other tabular reports. These predefined reports are sensitive to the OutputControl:Table:Style object and appear in the same files as the tabular reports. The entries for this object is a list of the predefined reports that should appear in the tabular report output file.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Table_SummaryReports : BHoMObject
    {
        

        [JsonProperty("reports")]
        public string Reports { get; set; } = "";
    }
}