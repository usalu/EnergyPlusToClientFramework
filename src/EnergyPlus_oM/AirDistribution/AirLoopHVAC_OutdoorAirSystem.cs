using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description(@"Outdoor air subsystem for an AirLoopHVAC. Includes an outdoor air mixing box and optional outdoor air conditioning equipment such as heat recovery, preheat, and precool coils. From the perspective of the primary air loop the outdoor air system is treated as a single component.")]
    [JsonObject("AirLoopHVAC:OutdoorAirSystem")]
    public class AirLoopHVAC_OutdoorAirSystem : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the name of an AirLoopHVAC:ControllerList object or blank if this object is" +
                     " used in AirLoopHVAC:DedicatedOutdoorAirSystem.")]
        [JsonProperty("controller_list_name")]
        public string ControllerListName { get; set; } = "";
        

        [Description("Enter the name of an AirLoopHVAC:OutdoorAirSystem:EquipmentList object.")]
        [JsonProperty("outdoor_air_equipment_list_name")]
        public string OutdoorAirEquipmentListName { get; set; } = "";
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty("availability_manager_list_name")]
        public string AvailabilityManagerListName { get; set; } = "";
    }
}