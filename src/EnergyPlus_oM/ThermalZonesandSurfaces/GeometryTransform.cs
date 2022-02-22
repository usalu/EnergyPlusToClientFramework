using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Provides a simple method of altering the footprint geometry of a model. The inten" +
                 "t is to provide a single parameter that can be used to reshape the building desc" +
                 "ription contained in the rest of the input file.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GeometryTransform : BHoMObject
    {
        

        [Description("only current allowed value is \"XY\"")]
        [JsonProperty("plane_of_transform")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GeometryTransform_PlaneOfTransform PlaneOfTransform { get; set; } = (GeometryTransform_PlaneOfTransform)Enum.Parse(typeof(GeometryTransform_PlaneOfTransform), "XY");
        

        [Description("Aspect ratio of building as described in idf")]
        [JsonProperty("current_aspect_ratio")]
        public System.Nullable<float> CurrentAspectRatio { get; set; } = null;
        

        [Description("Aspect ratio to transform to during run")]
        [JsonProperty("new_aspect_ratio")]
        public System.Nullable<float> NewAspectRatio { get; set; } = null;
    }
}