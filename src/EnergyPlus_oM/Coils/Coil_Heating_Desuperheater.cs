using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Desuperheater air heating coil. The heating energy provided by this coil is reclaimed from the superheated refrigerant gas leaving a compressor and does not impact the performance of the compressor. If the coil is located directly in an air loop branch or outdoor air equipment list, then it is controlled on leaving air temperature and the Temperature Setpoint Node Name must be specified. If the coil is contained within another component such as a unitary system, then the coil is controlled by the parent component and the setpoint node name is not entered.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Heating_Desuperheater : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("heat_reclaim_recovery_efficiency")]
        public System.Nullable<float> HeatReclaimRecoveryEfficiency { get; set; } = null;
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("heating_source_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Heating_Desuperheater_HeatingSourceObjectType HeatingSourceObjectType { get; set; } = (Coil_Heating_Desuperheater_HeatingSourceObjectType)Enum.Parse(typeof(Coil_Heating_Desuperheater_HeatingSourceObjectType), "CoilCoolingDXSingleSpeed");
        

        [JsonProperty("heating_source_name")]
        public string HeatingSourceName { get; set; } = "";
        

        [Description("Required if coil is temperature controlled. Temperature-based control requires th" +
                     "e use of a SetpointManager object")]
        [JsonProperty("temperature_setpoint_node_name")]
        public string TemperatureSetpointNodeName { get; set; } = "";
        

        [Description("parasitic electric load associated with the desuperheater coil operation such as " +
                     "solenoid valves, etc.")]
        [JsonProperty("parasitic_electric_load")]
        public System.Nullable<float> ParasiticElectricLoad { get; set; } = null;
    }
}