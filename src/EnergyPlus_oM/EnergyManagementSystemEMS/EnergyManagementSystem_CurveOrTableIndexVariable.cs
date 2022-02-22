using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("Declares EMS variable that identifies a curve or table")]
    public class EnergyManagementSystem_CurveOrTableIndexVariable : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("curve_or_table_object_name")]
        public string CurveOrTableObjectName { get; set; } = "";
    }
}