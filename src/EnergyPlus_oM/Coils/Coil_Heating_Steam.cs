using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Steam heating coil. Condenses and sub-cools steam at loop pressure and discharges" +
                 " condensate through steam traps to low pressure condensate line.")]
    [JsonObject("Coil:Heating:Steam")]
    public class Coil_Heating_Steam : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("maximum_steam_flow_rate")]
        public string MaximumSteamFlowRate { get; set; } = "";
        

        [JsonProperty("degree_of_subcooling")]
        public System.Nullable<float> DegreeOfSubcooling { get; set; } = null;
        

        [JsonProperty("degree_of_loop_subcooling")]
        public System.Nullable<float> DegreeOfLoopSubcooling { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

        [JsonProperty("water_inlet_node_name")]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty("water_outlet_node_name")]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Use ZoneLoadControl if the coil is contained within another component such as an " +
                     "air terminal unit, zone HVAC equipment, or unitary system. Use TemperatureSetpoi" +
                     "ntControl if the coil is located directly in an air loop branch or outdoor air e" +
                     "quipment list.")]
        [JsonProperty("coil_control_type")]
        public EmptyNoYes CoilControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Required if Coil Control Type is TemperatureSetpointControl")]
        [JsonProperty("temperature_setpoint_node_name")]
        public string TemperatureSetpointNodeName { get; set; } = "";
    }
}