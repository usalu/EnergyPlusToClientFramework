using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager determines the required conditions at the outdoor air strea" +
                 "m node which will produce the reference setpoint condition at the mixed air node" +
                 " when mixed with the return air stream")]
    [JsonObject("SetpointManager:OutdoorAirPretreat")]
    public class SetpointManager_OutdoorAirPretreat : BHoMObject
    {
        

        [JsonProperty("control_variable")]
        public EmptyNoYes ControlVariable { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Applicable only if Control variable is Temperature")]
        [JsonProperty("minimum_setpoint_temperature")]
        public System.Nullable<float> MinimumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-99", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Control variable is Temperature")]
        [JsonProperty("maximum_setpoint_temperature")]
        public System.Nullable<float> MaximumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("99", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Control variable is MaximumHumidityRatio, MinimumHumidityRatio" +
                     ", or HumidityRatio - then minimum is 0.00001")]
        [JsonProperty("minimum_setpoint_humidity_ratio")]
        public System.Nullable<float> MinimumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("1E-05", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Control variable is MaximumHumidityRatio, MinimumHumidityRatio" +
                     ", or HumidityRatio - then minimum is 0.00001")]
        [JsonProperty("maximum_setpoint_humidity_ratio")]
        public System.Nullable<float> MaximumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The current setpoint at this node is the desired condition for the Mixed Air Node" +
                     " This node must have a valid setpoint which has been set by another setpoint man" +
                     "ager")]
        [JsonProperty("reference_setpoint_node_name")]
        public string ReferenceSetpointNodeName { get; set; } = "";
        

        [Description("Name of Mixed Air Node")]
        [JsonProperty("mixed_air_stream_node_name")]
        public string MixedAirStreamNodeName { get; set; } = "";
        

        [Description("Name of Outdoor Air Stream Node")]
        [JsonProperty("outdoor_air_stream_node_name")]
        public string OutdoorAirStreamNodeName { get; set; } = "";
        

        [Description("Name of Return Air Stream Node")]
        [JsonProperty("return_air_stream_node_name")]
        public string ReturnAirStreamNodeName { get; set; } = "";
        

        [Description("Node(s) at which the temperature or humidity ratio will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}