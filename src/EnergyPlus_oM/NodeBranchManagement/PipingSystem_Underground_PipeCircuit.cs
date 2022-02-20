using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("The pipe circuit object in an underground piping system. This object is simulated" +
                 " within an underground piping domain object and connected on a branch on a plant" +
                 " loop.")]
    [JsonObject("PipingSystem:Underground:PipeCircuit")]
    public class PipingSystem_Underground_PipeCircuit : BHoMObject
    {
        

        [JsonProperty("pipe_thermal_conductivity")]
        public System.Nullable<float> PipeThermalConductivity { get; set; } = null;
        

        [JsonProperty("pipe_density")]
        public System.Nullable<float> PipeDensity { get; set; } = null;
        

        [JsonProperty("pipe_specific_heat")]
        public System.Nullable<float> PipeSpecificHeat { get; set; } = null;
        

        [JsonProperty("pipe_inner_diameter")]
        public System.Nullable<float> PipeInnerDiameter { get; set; } = null;
        

        [JsonProperty("pipe_outer_diameter")]
        public System.Nullable<float> PipeOuterDiameter { get; set; } = null;
        

        [JsonProperty("design_flow_rate")]
        public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

        [JsonProperty("circuit_inlet_node")]
        public string CircuitInletNode { get; set; } = "";
        

        [JsonProperty("circuit_outlet_node")]
        public string CircuitOutletNode { get; set; } = "";
        

        [JsonProperty("convergence_criterion_for_the_inner_radial_iteration_loop")]
        public System.Nullable<float> ConvergenceCriterionForTheInnerRadialIterationLoop { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_iterations_in_the_inner_radial_iteration_loop")]
        public System.Nullable<float> MaximumIterationsInTheInnerRadialIterationLoop { get; set; } = (System.Nullable<float>)Single.Parse("500", CultureInfo.InvariantCulture);
        

        [JsonProperty("number_of_soil_nodes_in_the_inner_radial_near_pipe_mesh_region")]
        public System.Nullable<float> NumberOfSoilNodesInTheInnerRadialNearPipeMeshRegion { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Required because it must be selected by user instead of being inferred from circu" +
                     "it/domain object inputs.")]
        [JsonProperty("radial_thickness_of_inner_radial_near_pipe_mesh_region")]
        public System.Nullable<float> RadialThicknessOfInnerRadialNearPipeMeshRegion { get; set; } = null;
        

        [JsonProperty("number_of_pipe_segments_entered_for_this_pipe_circuit")]
        public System.Nullable<float> NumberOfPipeSegmentsEnteredForThisPipeCircuit { get; set; } = null;
        

        [JsonProperty("pipe_segments")]
        public string PipeSegments { get; set; } = "";
    }
}