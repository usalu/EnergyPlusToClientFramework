using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EvaporativeCoolers
{
    [Description("Indirect evaporative cooler with rigid media evaporative pad, recirculating water" +
                 " pump, and secondary air fan. This model has no controls other than its availabi" +
                 "lity schedule.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EvaporativeCooler_Indirect_CelDekPad : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("direct_pad_area")]
        public string DirectPadArea { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("direct_pad_depth")]
        public string DirectPadDepth { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("recirculating_water_pump_power_consumption")]
        public System.Nullable<float> RecirculatingWaterPumpPowerConsumption { get; set; } = null;
        

        [JsonProperty("secondary_air_fan_flow_rate")]
        public System.Nullable<float> SecondaryAirFanFlowRate { get; set; } = null;
        

        [JsonProperty("secondary_air_fan_total_efficiency")]
        public System.Nullable<float> SecondaryAirFanTotalEfficiency { get; set; } = null;
        

        [JsonProperty("secondary_air_fan_delta_pressure")]
        public System.Nullable<float> SecondaryAirFanDeltaPressure { get; set; } = null;
        

        [JsonProperty("indirect_heat_exchanger_effectiveness")]
        public System.Nullable<float> IndirectHeatExchangerEffectiveness { get; set; } = null;
        

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