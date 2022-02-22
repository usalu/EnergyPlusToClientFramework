using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("Declares EMS variable as an internal data variable")]
    public class EnergyManagementSystem_InternalVariable : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("internal_data_index_key_name")]
        public string InternalDataIndexKeyName { get; set; } = "";
        

        [JsonProperty("internal_data_type")]
        public string InternalDataType { get; set; } = "";
    }
}