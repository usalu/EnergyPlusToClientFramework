using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("The Mixed Air Setpoint Manager is meant to be used in conjunction with a Controll" +
                 "er:OutdoorAir object. This setpoint manager is used to establish a temperature s" +
                 "etpoint at the mixed air node.")]
    public class SetpointManager_MixedAir : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("control_variable")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_MixedAir_ControlVariable ControlVariable { get; set; } = (SetpointManager_MixedAir_ControlVariable)Enum.Parse(typeof(SetpointManager_MixedAir_ControlVariable), "Temperature");
        

        [JsonProperty("reference_setpoint_node_name")]
        public string ReferenceSetpointNodeName { get; set; } = "";
        

        [JsonProperty("fan_inlet_node_name")]
        public string FanInletNodeName { get; set; } = "";
        

        [JsonProperty("fan_outlet_node_name")]
        public string FanOutletNodeName { get; set; } = "";
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
        

        [Description("Optional field used to limit economizer operation to prevent freezing of DX cooli" +
                     "ng coil.")]
        [JsonProperty("cooling_coil_inlet_node_name")]
        public string CoolingCoilInletNodeName { get; set; } = "";
        

        [Description("Optional field used to limit economizer operation to prevent freezing of DX cooli" +
                     "ng coil.")]
        [JsonProperty("cooling_coil_outlet_node_name")]
        public string CoolingCoilOutletNodeName { get; set; } = "";
        

        [Description("Optional field used to limit economizer operation to prevent freezing of DX cooli" +
                     "ng coil.")]
        [JsonProperty("minimum_temperature_at_cooling_coil_outlet_node")]
        public System.Nullable<float> MinimumTemperatureAtCoolingCoilOutletNode { get; set; } = (System.Nullable<float>)Single.Parse("7.2", CultureInfo.InvariantCulture);
    }
}