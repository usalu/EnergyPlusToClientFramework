using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description(@"Defines the perimeter of a foundation floor that is exposed to the exterior environment through the floor. User may either define the total exposed perimeter, fraction of perimeter exposed or individually define which segments of the floor surface perimeter are exposed.")]
    [JsonObject("SurfaceProperty:ExposedFoundationPerimeter")]
    public class SurfaceProperty_ExposedFoundationPerimeter : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("surface_name")]
        public string SurfaceName { get; set; } = "";
        

        [Description(@"Choices: TotalExposedPerimeter => total exposed perimeter in meters ExposedPerimeterFraction => fraction of total perimeter that is exposed. Value * Fraction = Total exposed perimeter BySegment => define whether the segment between each set of consecutive vertices of the floor surface is exposed. SUM(exposed segement lengths) = Total exposed perimeter")]
        [JsonProperty("exposed_perimeter_calculation_method")]
        public SurfaceProperty_ExposedFoundationPerimeter_ExposedPerimeterCalculationMethod ExposedPerimeterCalculationMethod { get; set; } = (SurfaceProperty_ExposedFoundationPerimeter_ExposedPerimeterCalculationMethod)Enum.Parse(typeof(SurfaceProperty_ExposedFoundationPerimeter_ExposedPerimeterCalculationMethod), "BySegment");
        

        [JsonProperty("total_exposed_perimeter")]
        public System.Nullable<float> TotalExposedPerimeter { get; set; } = null;
        

        [JsonProperty("exposed_perimeter_fraction")]
        public System.Nullable<float> ExposedPerimeterFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("surfaces")]
        public string Surfaces { get; set; } = "";
    }
}