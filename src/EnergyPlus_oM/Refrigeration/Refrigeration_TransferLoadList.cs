using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"A refrigeration system may provide cooling to other, secondary, systems through either a secondary loop or a cascade condenser. If multiple transfer loads are served by a single primary system, use this list to group them together for reference by the primary system (see the field ""Refrigeration Transfer Load or TransferLoad List Name"" in the Refrigeration:System object).")]
    [JsonObject("Refrigeration:TransferLoadList")]
    public class Refrigeration_TransferLoadList : BHoMObject
    {
        

        [JsonProperty("transfer_loads")]
        public string TransferLoads { get; set; } = "";
    }
}