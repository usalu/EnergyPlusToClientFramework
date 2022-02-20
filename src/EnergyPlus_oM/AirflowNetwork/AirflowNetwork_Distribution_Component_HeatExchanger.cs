using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the name of an air-to-air heat exchanger used in an air loop." +
                 "")]
    [JsonObject("AirflowNetwork:Distribution:Component:HeatExchanger")]
    public class AirflowNetwork_Distribution_Component_HeatExchanger : BHoMObject
    {
        

        [Description("Enter the name of an air-to-air heat exchanger in the primary Air loop.")]
        [JsonProperty("heatexchanger_name")]
        public string HeatexchangerName { get; set; } = "";
        

        [Description("Select the type of heat exchanger corresponding to the name entered in the field " +
                     "above.")]
        [JsonProperty("heatexchanger_object_type")]
        public EmptyNoYes HeatexchangerObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Enter the air path length (depth) for the heat exchanger.")]
        [JsonProperty("air_path_length")]
        public System.Nullable<float> AirPathLength { get; set; } = null;
        

        [Description("Enter the hydraulic diameter of this heat exchanger. The hydraulic diameter is de" +
                     "fined as 4 multiplied by the cross section area divided by perimeter.")]
        [JsonProperty("air_path_hydraulic_diameter")]
        public System.Nullable<float> AirPathHydraulicDiameter { get; set; } = null;
    }
}