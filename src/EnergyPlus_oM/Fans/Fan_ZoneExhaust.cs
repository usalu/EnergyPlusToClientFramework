using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    [Description("Models a fan that exhausts air from a zone.")]
    [JsonObject("Fan:ZoneExhaust")]
    public class Fan_ZoneExhaust : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("fan_total_efficiency")]
        public System.Nullable<float> FanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.6", CultureInfo.InvariantCulture);
        

        [JsonProperty("pressure_rise")]
        public System.Nullable<float> PressureRise { get; set; } = null;
        

        [JsonProperty("maximum_flow_rate")]
        public System.Nullable<float> MaximumFlowRate { get; set; } = null;
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
        

        [Description("If field is used, then when fan runs the exhausted air flow rate is controlled to" +
                     " be the scheduled fraction times the Maximum Flow Rate")]
        [JsonProperty("flow_fraction_schedule_name")]
        public string FlowFractionScheduleName { get; set; } = "";
        

        [Description("Control if fan is to be interlocked with HVAC system Availability Managers or not" +
                     ".")]
        [JsonProperty("system_availability_manager_coupling_mode")]
        public Fan_ZoneExhaust_SystemAvailabilityManagerCouplingMode SystemAvailabilityManagerCouplingMode { get; set; } = (Fan_ZoneExhaust_SystemAvailabilityManagerCouplingMode)Enum.Parse(typeof(Fan_ZoneExhaust_SystemAvailabilityManagerCouplingMode), "Coupled");
        

        [Description("If field is used, the exhaust fan will not run if the zone temperature is lower t" +
                     "han this limit")]
        [JsonProperty("minimum_zone_temperature_limit_schedule_name")]
        public string MinimumZoneTemperatureLimitScheduleName { get; set; } = "";
        

        [Description("Used to control fan\'s impact on flow at the return air node. Enter the portion of" +
                     " the exhaust that is balanced by simple airflows.")]
        [JsonProperty("balanced_exhaust_fraction_schedule_name")]
        public string BalancedExhaustFractionScheduleName { get; set; } = "";
    }
}