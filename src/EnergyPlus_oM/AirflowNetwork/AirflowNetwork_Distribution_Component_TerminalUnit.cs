using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the name of a terminal unit in an air loop.")]
    [JsonObject("AirflowNetwork:Distribution:Component:TerminalUnit")]
    public class AirflowNetwork_Distribution_Component_TerminalUnit : BHoMObject
    {
        

        [Description("Enter the name of a terminal unit in the AirLoopHVAC.")]
        [JsonProperty("terminal_unit_name")]
        public string TerminalUnitName { get; set; } = "";
        

        [Description("Select the type of terminal unit corresponding to the name entered in the field a" +
                     "bove.")]
        [JsonProperty("terminal_unit_object_type")]
        public EmptyNoYes TerminalUnitObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Enter the air path length (depth) for the terminal unit.")]
        [JsonProperty("air_path_length")]
        public System.Nullable<float> AirPathLength { get; set; } = null;
        

        [Description("Enter the hydraulic diameter of this terminal unit. The hydraulic diameter is def" +
                     "ined as 4 multiplied by the cross section area divided by perimeter.")]
        [JsonProperty("air_path_hydraulic_diameter")]
        public System.Nullable<float> AirPathHydraulicDiameter { get; set; } = null;
    }
}