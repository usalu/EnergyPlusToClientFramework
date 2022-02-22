using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("Declares EMS variable as an internal data variable")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_InternalVariable : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("internal_data_index_key_name")]
        public string InternalDataIndexKeyName { get; set; } = "";
        

        [JsonProperty("internal_data_type")]
        public string InternalDataType { get; set; } = "";
    }
}