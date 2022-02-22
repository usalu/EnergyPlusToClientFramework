using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("A model of a shallow pond with immersed pipe loops. Typically used in hybrid geot" +
                 "hermal systems and included in the condenser loop. This component may also be us" +
                 "ed as a simple solar collector.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatExchanger_Pond : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("fluid_inlet_node_name")]
        public string FluidInletNodeName { get; set; } = "";
        

        [JsonProperty("fluid_outlet_node_name")]
        public string FluidOutletNodeName { get; set; } = "";
        

        [JsonProperty("pond_depth")]
        public System.Nullable<float> PondDepth { get; set; } = null;
        

        [JsonProperty("pond_area")]
        public System.Nullable<float> PondArea { get; set; } = null;
        

        [JsonProperty("hydronic_tubing_inside_diameter")]
        public System.Nullable<float> HydronicTubingInsideDiameter { get; set; } = null;
        

        [JsonProperty("hydronic_tubing_outside_diameter")]
        public System.Nullable<float> HydronicTubingOutsideDiameter { get; set; } = null;
        

        [JsonProperty("hydronic_tubing_thermal_conductivity")]
        public System.Nullable<float> HydronicTubingThermalConductivity { get; set; } = null;
        

        [JsonProperty("ground_thermal_conductivity")]
        public System.Nullable<float> GroundThermalConductivity { get; set; } = null;
        

        [JsonProperty("number_of_tubing_circuits")]
        public System.Nullable<float> NumberOfTubingCircuits { get; set; } = null;
        

        [JsonProperty("length_of_each_tubing_circuit")]
        public System.Nullable<float> LengthOfEachTubingCircuit { get; set; } = null;
    }
}