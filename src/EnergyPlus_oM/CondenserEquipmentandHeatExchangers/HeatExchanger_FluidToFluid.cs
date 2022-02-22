using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("A fluid/fluid heat exchanger designed to couple the supply side of one loop to th" +
                 "e demand side of another loop Loops can be either plant or condenser loops but n" +
                 "o air side connections are allowed")]
    [JsonObject("HeatExchanger:FluidToFluid")]
    public class HeatExchanger_FluidToFluid : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available. default is " +
                     "that heat exchanger is on")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("This connection is to the demand side of a loop and is the inlet to the heat exch" +
                     "anger")]
        [JsonProperty("loop_demand_side_inlet_node_name")]
        public string LoopDemandSideInletNodeName { get; set; } = "";
        

        [Description("This connection is to the demand side of a loop")]
        [JsonProperty("loop_demand_side_outlet_node_name")]
        public string LoopDemandSideOutletNodeName { get; set; } = "";
        

        [JsonProperty("loop_demand_side_design_flow_rate")]
        public string LoopDemandSideDesignFlowRate { get; set; } = "";
        

        [JsonProperty("loop_supply_side_inlet_node_name")]
        public string LoopSupplySideInletNodeName { get; set; } = "";
        

        [JsonProperty("loop_supply_side_outlet_node_name")]
        public string LoopSupplySideOutletNodeName { get; set; } = "";
        

        [JsonProperty("loop_supply_side_design_flow_rate")]
        public string LoopSupplySideDesignFlowRate { get; set; } = "";
        

        [JsonProperty("heat_exchange_model_type")]
        public HeatExchanger_FluidToFluid_HeatExchangeModelType HeatExchangeModelType { get; set; } = (HeatExchanger_FluidToFluid_HeatExchangeModelType)Enum.Parse(typeof(HeatExchanger_FluidToFluid_HeatExchangeModelType), "Ideal");
        

        [JsonProperty("heat_exchanger_u_factor_times_area_value")]
        public string HeatExchangerUFactorTimesAreaValue { get; set; } = "";
        

        [JsonProperty("control_type")]
        public HeatExchanger_FluidToFluid_ControlType ControlType { get; set; } = (HeatExchanger_FluidToFluid_ControlType)Enum.Parse(typeof(HeatExchanger_FluidToFluid_ControlType), "UncontrolledOn");
        

        [Description("Setpoint node is needed with any Control Type that is \"*Setpoint*\"")]
        [JsonProperty("heat_exchanger_setpoint_node_name")]
        public string HeatExchangerSetpointNodeName { get; set; } = "";
        

        [Description("Tolerance between control temperatures used to determine if heat exchanger should" +
                     " run.")]
        [JsonProperty("minimum_temperature_difference_to_activate_heat_exchanger")]
        public System.Nullable<float> MinimumTemperatureDifferenceToActivateHeatExchanger { get; set; } = (System.Nullable<float>)Single.Parse("0.01", CultureInfo.InvariantCulture);
        

        [Description("This field controls end use reporting for heat transfer meters")]
        [JsonProperty("heat_transfer_metering_end_use_type")]
        public HeatExchanger_FluidToFluid_HeatTransferMeteringEndUseType HeatTransferMeteringEndUseType { get; set; } = (HeatExchanger_FluidToFluid_HeatTransferMeteringEndUseType)Enum.Parse(typeof(HeatExchanger_FluidToFluid_HeatTransferMeteringEndUseType), "LoopToLoop");
        

        [Description("This field is only used if Control Type is set to CoolingSetpointOnOffWithCompone" +
                     "ntOverride")]
        [JsonProperty("component_override_loop_supply_side_inlet_node_name")]
        public string ComponentOverrideLoopSupplySideInletNodeName { get; set; } = "";
        

        [Description("This field is only used if Control Type is set to CoolingSetpointOnOffWithCompone" +
                     "ntOverride")]
        [JsonProperty("component_override_loop_demand_side_inlet_node_name")]
        public string ComponentOverrideLoopDemandSideInletNodeName { get; set; } = "";
        

        [Description("This field is only used if Control Type is set to CoolingSetpointOnOffWithCompone" +
                     "ntOverride")]
        [JsonProperty("component_override_cooling_control_temperature_mode")]
        public HeatExchanger_FluidToFluid_ComponentOverrideCoolingControlTemperatureMode ComponentOverrideCoolingControlTemperatureMode { get; set; } = (HeatExchanger_FluidToFluid_ComponentOverrideCoolingControlTemperatureMode)Enum.Parse(typeof(HeatExchanger_FluidToFluid_ComponentOverrideCoolingControlTemperatureMode), "Loop");
        

        [Description("Multiplies the autosized flow rates for this device")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Lower limit on inlet temperatures, heat exchanger will not operate if either inle" +
                     "t is below this limit")]
        [JsonProperty("operation_minimum_temperature_limit")]
        public System.Nullable<float> OperationMinimumTemperatureLimit { get; set; } = null;
        

        [Description("Upper limit on inlet temperatures, heat exchanger will not operate if either inle" +
                     "t is above this limit")]
        [JsonProperty("operation_maximum_temperature_limit")]
        public System.Nullable<float> OperationMaximumTemperatureLimit { get; set; } = null;
    }
}