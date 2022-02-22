using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [Description(@"Glazed solar collector with integral storage unit. Thermal and optical properties are taken from the referenced SolarCollectorPerformance:IntegralCollectorStorage object. Collector tilt, azimuth, and gross area are taken from the referenced building surface or shading surface. The collector surface participates normally in all shading calculations.")]
    public class SolarCollector_IntegralCollectorStorage : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("integralcollectorstorageparameters_name")]
        public string IntegralcollectorstorageparametersName { get; set; } = "";
        

        [JsonProperty("surface_name")]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty("bottom_surface_boundary_conditions_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SolarCollector_IntegralCollectorStorage_BottomSurfaceBoundaryConditionsType BottomSurfaceBoundaryConditionsType { get; set; } = (SolarCollector_IntegralCollectorStorage_BottomSurfaceBoundaryConditionsType)Enum.Parse(typeof(SolarCollector_IntegralCollectorStorage_BottomSurfaceBoundaryConditionsType), "AmbientAir");
        

        [Description("Enter the name of a SurfaceProperty:OtherSideConditionsModel object. Specified on" +
                     "ly if the boundary condition type is OtherSideConditionsModel, otherwise leave i" +
                     "t blank")]
        [JsonProperty("boundary_condition_model_name")]
        public string BoundaryConditionModelName { get; set; } = "";
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty("maximum_flow_rate")]
        public System.Nullable<float> MaximumFlowRate { get; set; } = null;
    }
}