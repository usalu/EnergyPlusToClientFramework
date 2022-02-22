using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [Description(@"Flat plate water solar collector (single glazed, unglazed, or evacuated tube). Thermal and optical properties are taken from the referenced SolarCollectorPerformance:FlatPlate object. Collector tilt, azimuth, and gross area are taken from the referenced building surface or shading surface. The collector surface participates normally in all shading calculations.")]
    public class SolarCollector_FlatPlate_Water : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("solarcollectorperformance_name")]
        public string SolarcollectorperformanceName { get; set; } = "";
        

        [JsonProperty("surface_name")]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty("maximum_flow_rate")]
        public System.Nullable<float> MaximumFlowRate { get; set; } = null;
    }
}