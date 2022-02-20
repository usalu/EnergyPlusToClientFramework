using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"Provides a list of all the refrigerated cases, walk in coolers, or air chillers cooled by a single refrigeration system. Note that the names of all cases, walk-ins ,air chillers, and CaseAndWalkInLists must be unique. That is, you cannot give a list the same name as one of list items. This list may contain a combination of case and walk-in names OR a list of air chiller names. Air chillers may not be included in any list that also includes cases or walk-ins.")]
    [JsonObject("Refrigeration:CaseAndWalkInList")]
    public class Refrigeration_CaseAndWalkInList : BHoMObject
    {
        

        [JsonProperty("cases_and_walkins")]
        public string CasesAndWalkins { get; set; } = "";
    }
}