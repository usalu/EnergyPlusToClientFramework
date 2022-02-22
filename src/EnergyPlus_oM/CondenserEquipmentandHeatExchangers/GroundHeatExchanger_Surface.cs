using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description(@"A hydronic surface/panel consisting of a multi-layer construction with embedded rows of tubes. Typically used in hybrid geothermal systems and included in the condenser loop. This component may also be used as a simple solar collector. The bottom surface may be defined as ground-coupled or exposed to wind (eg. bridge deck).")]
    [JsonObject("GroundHeatExchanger:Surface")]
    public class GroundHeatExchanger_Surface : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [JsonProperty("fluid_inlet_node_name")]
        public string FluidInletNodeName { get; set; } = "";
        

        [JsonProperty("fluid_outlet_node_name")]
        public string FluidOutletNodeName { get; set; } = "";
        

        [JsonProperty("hydronic_tubing_inside_diameter")]
        public System.Nullable<float> HydronicTubingInsideDiameter { get; set; } = null;
        

        [JsonProperty("number_of_tubing_circuits")]
        public System.Nullable<float> NumberOfTubingCircuits { get; set; } = null;
        

        [JsonProperty("hydronic_tube_spacing")]
        public System.Nullable<float> HydronicTubeSpacing { get; set; } = null;
        

        [JsonProperty("surface_length")]
        public System.Nullable<float> SurfaceLength { get; set; } = null;
        

        [JsonProperty("surface_width")]
        public System.Nullable<float> SurfaceWidth { get; set; } = null;
        

        [JsonProperty("lower_surface_environment")]
        public GroundHeatExchanger_Surface_LowerSurfaceEnvironment LowerSurfaceEnvironment { get; set; } = (GroundHeatExchanger_Surface_LowerSurfaceEnvironment)Enum.Parse(typeof(GroundHeatExchanger_Surface_LowerSurfaceEnvironment), "Ground");
    }
}