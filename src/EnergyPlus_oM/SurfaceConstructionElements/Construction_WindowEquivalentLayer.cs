using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Start with outside layer and work your way to the inside Layer Up to 11 layers to" +
                 "tal. Up to six solid layers and up to five gaps. Enter the material name for eac" +
                 "h layer")]
    [JsonObject("Construction:WindowEquivalentLayer")]
    public class Construction_WindowEquivalentLayer : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("outside_layer")]
        public string OutsideLayer { get; set; } = "";
        

        [JsonProperty("layer_2")]
        public string Layer2 { get; set; } = "";
        

        [JsonProperty("layer_3")]
        public string Layer3 { get; set; } = "";
        

        [JsonProperty("layer_4")]
        public string Layer4 { get; set; } = "";
        

        [JsonProperty("layer_5")]
        public string Layer5 { get; set; } = "";
        

        [JsonProperty("layer_6")]
        public string Layer6 { get; set; } = "";
        

        [JsonProperty("layer_7")]
        public string Layer7 { get; set; } = "";
        

        [JsonProperty("layer_8")]
        public string Layer8 { get; set; } = "";
        

        [JsonProperty("layer_9")]
        public string Layer9 { get; set; } = "";
        

        [JsonProperty("layer_10")]
        public string Layer10 { get; set; } = "";
        

        [JsonProperty("layer_11")]
        public string Layer11 { get; set; } = "";
    }
}