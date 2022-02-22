using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description(@"List condenser equipment in order of operating priority, 1st in list will be used 1st, etc Use only condenser equipment in this list. If no equipment object types and equipment names are specified, then the corresponding PlantEquipmentOperation:* object will assume all available condenser equipment for the loop should be OFF (not operate) within the specified lower/upper limit.")]
    [JsonObject("CondenserEquipmentList")]
    public class CondenserEquipmentList : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("equipment")]
        public string Equipment { get; set; } = "";
    }
}