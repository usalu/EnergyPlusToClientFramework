using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EvaporativeCoolers
{
    [Description("Indirect evaporative cooler with wetted coil, recirculating water pump, and secon" +
                 "dary air fan. This model has no controls other than its availability schedule.")]
    [JsonObject("EvaporativeCooler:Indirect:WetCoil")]
    public class EvaporativeCooler_Indirect_WetCoil : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("coil_maximum_efficiency")]
        public System.Nullable<float> CoilMaximumEfficiency { get; set; } = null;
        

        [JsonProperty("coil_flow_ratio")]
        public System.Nullable<float> CoilFlowRatio { get; set; } = null;
        

        [JsonProperty("recirculating_water_pump_power_consumption")]
        public System.Nullable<float> RecirculatingWaterPumpPowerConsumption { get; set; } = null;
        

        [JsonProperty("secondary_air_fan_flow_rate")]
        public System.Nullable<float> SecondaryAirFanFlowRate { get; set; } = null;
        

        [JsonProperty("secondary_air_fan_total_efficiency")]
        public System.Nullable<float> SecondaryAirFanTotalEfficiency { get; set; } = null;
        

        [JsonProperty("secondary_air_fan_delta_pressure")]
        public System.Nullable<float> SecondaryAirFanDeltaPressure { get; set; } = null;
        

        [JsonProperty("primary_air_inlet_node_name")]
        public string PrimaryAirInletNodeName { get; set; } = "";
        

        [JsonProperty("primary_air_outlet_node_name")]
        public string PrimaryAirOutletNodeName { get; set; } = "";
        

        [Description("This field is not currently used and can be left blank")]
        [JsonProperty("control_type")]
        public string ControlType { get; set; } = "";
        

        [JsonProperty("water_supply_storage_tank_name")]
        public string WaterSupplyStorageTankName { get; set; } = "";
        

        [Description("Enter the name of an outdoor air node")]
        [JsonProperty("secondary_air_inlet_node_name")]
        public string SecondaryAirInletNodeName { get; set; } = "";
    }
}