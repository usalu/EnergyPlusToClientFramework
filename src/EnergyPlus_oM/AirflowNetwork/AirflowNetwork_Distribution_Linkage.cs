using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the connection between two nodes and a component.")]
    [JsonObject("AirflowNetwork:Distribution:Linkage")]
    public class AirflowNetwork_Distribution_Linkage : BHoMObject
    {
        

        [Description("Enter the name of zone or AirflowNetwork Node.")]
        [JsonProperty("node_1_name")]
        public string Node1Name { get; set; } = "";
        

        [Description("Enter the name of zone or AirflowNetwork Node.")]
        [JsonProperty("node_2_name")]
        public string Node2Name { get; set; } = "";
        

        [Description("Enter the name of an AirflowNetwork component. A component is one of the followin" +
                     "g AirflowNetwork:Distribution:Component objects: Leak, LeakageRatio, Duct, Const" +
                     "antVolumeFan, Coil, TerminalUnit, ConstantPressureDrop, or HeatExchanger.")]
        [JsonProperty("component_name")]
        public string ComponentName { get; set; } = "";
        

        [Description("Only used if component = AirflowNetwork:Distribution:Component:Duct The zone name" +
                     " is where AirflowNetwork:Distribution:Component:Duct is exposed. Leave this fiel" +
                     "d blank if the duct conduction loss is ignored.")]
        [JsonProperty("thermal_zone_name")]
        public string ThermalZoneName { get; set; } = "";
    }
}