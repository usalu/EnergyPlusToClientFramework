using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("Centralized source of hot water, such as a district heating system.")]
    [JsonObject("DistrictHeating")]
    public class DistrictHeating : BHoMObject
    {
        

        [JsonProperty("hot_water_inlet_node_name")]
        public string HotWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("hot_water_outlet_node_name")]
        public string HotWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("nominal_capacity")]
        public string NominalCapacity { get; set; } = "";
        

        [Description("Schedule values are multiplied by Nominal Capacity for current capacity")]
        [JsonProperty("capacity_fraction_schedule_name")]
        public string CapacityFractionScheduleName { get; set; } = "";
    }
}