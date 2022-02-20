using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"List of all the compressors included within a single refrigeration system (Refrigeration:System). Each list must contain at least one compressor. The order in which the individual compressors are listed here will be the order in which the compressors are dispatched to meet the system load. IMPORTANT: List compressor names in the order in which the compressors will be loaded Data is available for many compressors in the RefrigerationCompressor.idf dataset")]
    [JsonObject("Refrigeration:CompressorList")]
    public class Refrigeration_CompressorList : BHoMObject
    {
        

        [JsonProperty("compressors")]
        public string Compressors { get; set; } = "";
    }
}