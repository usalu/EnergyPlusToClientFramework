using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HeatRecovery
{
    [Description(@"This object models a balanced desiccant heat exchanger. The heat exchanger transfers both sensible and latent energy between the process and regeneration air streams. The air flow rate and face velocity are assumed to be the same on both the process and regeneration sides of the heat exchanger.")]
    public class HeatExchanger_Desiccant_BalancedFlow : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("regeneration_air_inlet_node_name")]
        public string RegenerationAirInletNodeName { get; set; } = "";
        

        [JsonProperty("regeneration_air_outlet_node_name")]
        public string RegenerationAirOutletNodeName { get; set; } = "";
        

        [JsonProperty("process_air_inlet_node_name")]
        public string ProcessAirInletNodeName { get; set; } = "";
        

        [JsonProperty("process_air_outlet_node_name")]
        public string ProcessAirOutletNodeName { get; set; } = "";
        

        [JsonProperty("heat_exchanger_performance_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatExchanger_Desiccant_BalancedFlow_HeatExchangerPerformanceObjectType HeatExchangerPerformanceObjectType { get; set; } = (HeatExchanger_Desiccant_BalancedFlow_HeatExchangerPerformanceObjectType)Enum.Parse(typeof(HeatExchanger_Desiccant_BalancedFlow_HeatExchangerPerformanceObjectType), "Empty");
        

        [JsonProperty("heat_exchanger_performance_name")]
        public string HeatExchangerPerformanceName { get; set; } = "";
        

        [Description("Yes means that the heat exchanger will be locked out (off) when the economizer is" +
                     " operating or high humidity control is active")]
        [JsonProperty("economizer_lockout")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes EconomizerLockout { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
}