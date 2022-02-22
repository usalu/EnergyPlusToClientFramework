using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("This object defines a list of surrounding surfaces for an exterior surface.")]
    public class SurfaceProperty_SurroundingSurfaces : BHoMObject, IEnergyPlusClass
    {
        

        [Description("optional")]
        [JsonProperty("sky_view_factor")]
        public System.Nullable<float> SkyViewFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("Schedule values are real numbers, -100.0 to 100.0, units C optional")]
        [JsonProperty("sky_temperature_schedule_name")]
        public string SkyTemperatureScheduleName { get; set; } = "";
        

        [Description("optional")]
        [JsonProperty("ground_view_factor")]
        public System.Nullable<float> GroundViewFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("Schedule values are real numbers, -100.0 to 100.0, units C optional")]
        [JsonProperty("ground_temperature_schedule_name")]
        public string GroundTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("surfaces")]
        public string Surfaces { get; set; } = "";
    }
}