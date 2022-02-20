using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("Pipe model with transport delay and heat transfer to the environment.")]
    [JsonObject("Pipe:Outdoor")]
    public class Pipe_Outdoor : BHoMObject
    {
        

        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [JsonProperty("fluid_inlet_node_name")]
        public string FluidInletNodeName { get; set; } = "";
        

        [JsonProperty("fluid_outlet_node_name")]
        public string FluidOutletNodeName { get; set; } = "";
        

        [JsonProperty("ambient_temperature_outdoor_air_node_name")]
        public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

        [JsonProperty("pipe_inside_diameter")]
        public System.Nullable<float> PipeInsideDiameter { get; set; } = null;
        

        [JsonProperty("pipe_length")]
        public System.Nullable<float> PipeLength { get; set; } = null;
    }
}