using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Exterior or Interior Insulation on opaque surfaces")]
    [JsonObject("SurfaceControl:MovableInsulation")]
    public class SurfaceControl_MovableInsulation : BHoMObject
    {
        

        [JsonProperty("insulation_type")]
        public EmptyNoYes InsulationType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("surface_name")]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty("material_name")]
        public string MaterialName { get; set; } = "";
        

        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
    }
}