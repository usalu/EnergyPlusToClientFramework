using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("Centralized source of chilled water, such as a district cooling system.")]
    [JsonObject("DistrictCooling")]
    public class DistrictCooling : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("chilled_water_inlet_node_name")]
        public string ChilledWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("chilled_water_outlet_node_name")]
        public string ChilledWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("nominal_capacity")]
        public string NominalCapacity { get; set; } = "";
        

        [Description("Schedule values are multiplied by Nominal Capacity for current capacity")]
        [JsonProperty("capacity_fraction_schedule_name")]
        public string CapacityFractionScheduleName { get; set; } = "";
    }
}