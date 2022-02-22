using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Exterior or Interior Insulation on opaque surfaces")]
    public class SurfaceControl_MovableInsulation : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("insulation_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceControl_MovableInsulation_InsulationType InsulationType { get; set; } = (SurfaceControl_MovableInsulation_InsulationType)Enum.Parse(typeof(SurfaceControl_MovableInsulation_InsulationType), "Inside");
        

        [JsonProperty("surface_name")]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty("material_name")]
        public string MaterialName { get; set; } = "";
        

        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
    }
}