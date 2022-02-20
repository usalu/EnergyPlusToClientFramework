using EnergyPlusJsonSchemas.Fields;
using Newtonsoft.Json;

namespace EnergyPlusJsonSchemas.Objects
{
    public class EPName
    {
        [JsonProperty("type")]
        public EPFieldType Type { get; set; }

        [JsonProperty("retaincase", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Retaincase { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public string Default { get; set; }

        [JsonProperty("is_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRequired { get; set; }

        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Reference { get; set; }

        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
        public EPList? EPList { get; set; }

        [JsonProperty("object_list", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ObjectList { get; set; }

        [JsonProperty("reference-class-name", NullValueHandling = NullValueHandling.Ignore)]
        public EPReferenceClassName[] EPReferenceClassName { get; set; }
    }
}