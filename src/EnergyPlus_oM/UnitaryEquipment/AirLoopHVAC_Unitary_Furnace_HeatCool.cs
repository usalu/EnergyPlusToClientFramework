using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    [Description(@"Unitary system, heating and cooling with constant volume supply fan (continuous or cycling), direct expansion (DX) cooling coil, heating coil (gas, electric, hot water, or steam), and optional reheat coil for dehumidification control. Identical to AirLoopHVAC:UnitaryHeatCool.")]
    [JsonObject("AirLoopHVAC:Unitary:Furnace:HeatCool")]
    public class AirLoopHVAC_Unitary_Furnace_HeatCool : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. A schedule value greater than zero (usually 1 is used) indicates that the unit is available to operate as needed. A value less than or equal to zero (usually zero is used) denotes that the unit must be off.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("furnace_air_inlet_node_name")]
        public string FurnaceAirInletNodeName { get; set; } = "";
        

        [JsonProperty("furnace_air_outlet_node_name")]
        public string FurnaceAirOutletNodeName { get; set; } = "";
        

        [Description(@"A fan operating mode schedule value of 0 indicates cycling fan mode (supply air fan cycles on and off in tandem with the cooling or heating coil). Any other schedule value indicates continuous fan mode (supply air fan operates continuously regardless of cooling or heating coil operation). Provide a schedule with non-zero values when high humidity control is specified. Leaving this schedule name blank will default to cycling fan mode for the entire simulation period.")]
        [JsonProperty("supply_air_fan_operating_mode_schedule_name")]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [JsonProperty("maximum_supply_air_temperature")]
        public string MaximumSupplyAirTemperature { get; set; } = (System.String)"80";
        

        [Description("Must be less than or equal to the fan\'s maximum flow rate.")]
        [JsonProperty("cooling_supply_air_flow_rate")]
        public string CoolingSupplyAirFlowRate { get; set; } = "";
        

        [Description("Must be less than or equal to the fan\'s maximum flow fate.")]
        [JsonProperty("heating_supply_air_flow_rate")]
        public string HeatingSupplyAirFlowRate { get; set; } = "";
        

        [Description(@"Must be less than or equal to the fan's maximum flow rate. Only used when fan operating mode is continuous (disregarded for cycling fan mode). This air flow rate is used when no heating or cooling is required (i.e., the DX coil compressor and heating coil are off). If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used.")]
        [JsonProperty("no_load_supply_air_flow_rate")]
        public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("controlling_zone_or_thermostat_location")]
        public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

        [Description("Fan:ConstantVolume only works with continuous fan operating mode (i.e. supply air" +
                     " fan operating mode schedule values not equal to 0).")]
        [JsonProperty("supply_fan_object_type")]
        public AirLoopHVAC_Unitary_Furnace_HeatCool_SupplyFanObjectType SupplyFanObjectType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatCool_SupplyFanObjectType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatCool_SupplyFanObjectType), "FanConstantVolume");
        

        [JsonProperty("supply_fan_name")]
        public string SupplyFanName { get; set; } = "";
        

        [JsonProperty("fan_placement")]
        public AirLoopHVAC_Unitary_Furnace_HeatCool_FanPlacement FanPlacement { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatCool_FanPlacement)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatCool_FanPlacement), "BlowThrough");
        

        [Description("works with gas, electric, hot water and steam heating coils")]
        [JsonProperty("heating_coil_object_type")]
        public AirLoopHVAC_Unitary_Furnace_HeatCool_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatCool_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatCool_HeatingCoilObjectType), "CoilHeatingElectric");
        

        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
        

        [Description("Only works with DX cooling coil types")]
        [JsonProperty("cooling_coil_object_type")]
        public AirLoopHVAC_Unitary_Furnace_HeatCool_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatCool_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatCool_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
        

        [Description(@"None = meet sensible load only Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only with cooling coil type CoilSystem:Cooling:DX:HeatExchangerAssisted. This control mode allows the heat exchanger to be turned on and off based on the zone dehumidification requirements. A ZoneControl:Humidistat object is also required. CoolReheat = cool beyond the dry-bulb setpoint. as required to meet the humidity setpoint. Valid with all cooling coil types. When a heat exchanger assisted cooling coil is used, the heat exchanger is locked on at all times. A ZoneControl:Humidistat object is also required.")]
        [JsonProperty("dehumidification_control_type")]
        public AirLoopHVAC_Unitary_Furnace_HeatCool_DehumidificationControlType DehumidificationControlType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatCool_DehumidificationControlType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatCool_DehumidificationControlType), "None");
        

        [Description("Only required if dehumidification control type is \"CoolReheat\" works with gas, el" +
                     "ectric, hot water and steam heating coils")]
        [JsonProperty("reheat_coil_object_type")]
        public AirLoopHVAC_Unitary_Furnace_HeatCool_ReheatCoilObjectType ReheatCoilObjectType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatCool_ReheatCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatCool_ReheatCoilObjectType), "CoilHeatingDesuperheater");
        

        [Description("Only required if dehumidification control type is \"CoolReheat\"")]
        [JsonProperty("reheat_coil_name")]
        public string ReheatCoilName { get; set; } = "";
    }
}