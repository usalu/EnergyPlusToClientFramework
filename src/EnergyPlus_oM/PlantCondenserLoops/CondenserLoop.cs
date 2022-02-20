using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserLoops
{
    [Description("Defines a central plant condenser loop. CondenserLoop and PlantLoop are nearly id" +
                 "entical except some components and operation schemes are applicable to only one " +
                 "loop type or the other.")]
    [JsonObject("CondenserLoop")]
    public class CondenserLoop : BHoMObject
    {
        

        [JsonProperty("fluid_type")]
        public EmptyNoYes FluidType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Water");
        

        [Description("This field is only required when Fluid Type is UserDefinedFluidType")]
        [JsonProperty("user_defined_fluid_type")]
        public string UserDefinedFluidType { get; set; } = "";
        

        [JsonProperty("condenser_equipment_operation_scheme_name")]
        public string CondenserEquipmentOperationSchemeName { get; set; } = "";
        

        [JsonProperty("condenser_loop_temperature_setpoint_node_name")]
        public string CondenserLoopTemperatureSetpointNodeName { get; set; } = "";
        

        [JsonProperty("maximum_loop_temperature")]
        public System.Nullable<float> MaximumLoopTemperature { get; set; } = null;
        

        [JsonProperty("minimum_loop_temperature")]
        public System.Nullable<float> MinimumLoopTemperature { get; set; } = null;
        

        [JsonProperty("maximum_loop_flow_rate")]
        public string MaximumLoopFlowRate { get; set; } = "";
        

        [JsonProperty("minimum_loop_flow_rate")]
        public System.Nullable<float> MinimumLoopFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("condenser_loop_volume")]
        public string CondenserLoopVolume { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("condenser_side_inlet_node_name")]
        public string CondenserSideInletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_side_outlet_node_name")]
        public string CondenserSideOutletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_side_branch_list_name")]
        public string CondenserSideBranchListName { get; set; } = "";
        

        [JsonProperty("condenser_side_connector_list_name")]
        public string CondenserSideConnectorListName { get; set; } = "";
        

        [JsonProperty("demand_side_inlet_node_name")]
        public string DemandSideInletNodeName { get; set; } = "";
        

        [JsonProperty("demand_side_outlet_node_name")]
        public string DemandSideOutletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_demand_side_branch_list_name")]
        public string CondenserDemandSideBranchListName { get; set; } = "";
        

        [JsonProperty("condenser_demand_side_connector_list_name")]
        public string CondenserDemandSideConnectorListName { get; set; } = "";
        

        [JsonProperty("load_distribution_scheme")]
        public EmptyNoYes LoadDistributionScheme { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "SequentialLoad");
        

        [JsonProperty("pressure_simulation_type")]
        public EmptyNoYes PressureSimulationType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
        

        [Description("This field is only used to autocalulate the Condenser Loop Volume. Loop Volume = " +
                     "Loop Circulation Time * Maximum Loop Flow Rate")]
        [JsonProperty("loop_circulation_time")]
        public System.Nullable<float> LoopCirculationTime { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
}