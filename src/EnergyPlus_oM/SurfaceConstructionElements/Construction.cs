using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Start with outside layer and work your way to the inside layer Up to 10 layers to" +
                 "tal, 8 for windows Enter the material name for each layer")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

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
    }
}