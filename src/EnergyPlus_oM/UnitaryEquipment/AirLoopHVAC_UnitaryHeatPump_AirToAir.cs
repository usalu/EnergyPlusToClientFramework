using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    [Description("Unitary heat pump system, heating and cooling, single-speed with supply fan, dire" +
                 "ct expansion (DX) cooling coil, DX heating coil (air-to-air heat pump), and supp" +
                 "lemental heating coil (gas, electric, hot water, or steam).")]
    public class AirLoopHVAC_UnitaryHeatPump_AirToAir : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. A schedule value greater than zero (usually 1 is used) indicates that the unit is available to operate as needed. A value less than or equal to zero (usually zero is used) denotes that the unit must be off.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Must be less than or equal to the fan\'s maximum flow rate.")]
        [JsonProperty("cooling_supply_air_flow_rate")]
        public string CoolingSupplyAirFlowRate { get; set; } = "";
        

        [Description("Must be less than or equal to the fan\'s maximum flow rate.")]
        [JsonProperty("heating_supply_air_flow_rate")]
        public string HeatingSupplyAirFlowRate { get; set; } = "";
        

        [Description(@"Must be less than or equal to the fan's maximum flow rate. Only used when fan operating mode is continuous (disregarded for cycling fan mode). This air flow rate is used when no heating or cooling is required (i.e., the DX coil compressor and supplemental heating coil are off). If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used.")]
        [JsonProperty("no_load_supply_air_flow_rate")]
        public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("controlling_zone_or_thermostat_location")]
        public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

        [Description("Fan:ConstantVolume only works with continuous fan operating mode (i.e. fan operat" +
                     "ing mode schedule values are greater than 0 or the fan operating mode schedule n" +
                     "ame field is left blank).")]
        [JsonProperty("supply_air_fan_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplyAirFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplyAirFanObjectType), "FanConstantVolume");
        

        [Description("Needs to match in the fan object")]
        [JsonProperty("supply_air_fan_name")]
        public string SupplyAirFanName { get; set; } = "";
        

        [Description("Only works with Coil:Heating:DX:SingleSpeed or Coil:Heating:DX:VariableSpeed or C" +
                     "oilSystem:IntegratedHeatPump:AirSource")]
        [JsonProperty("heating_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_AirToAir_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_HeatingCoilObjectType), "CoilHeatingDXSingleSpeed");
        

        [Description("Needs to match in the DX heating coil object")]
        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
        

        [Description("Only works with Coil:Cooling:DX:SingleSpeed or CoilSystem:Cooling:DX:HeatExchange" +
                     "rAssisted or Coil:Cooling:DX:VariableSpeed or CoilSystem:IntegratedHeatPump:AirS" +
                     "ource")]
        [JsonProperty("cooling_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_AirToAir_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

        [Description("Needs to match in the DX cooling coil object")]
        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
        

        [Description("works with gas, electric, hot water and steam heating coils")]
        [JsonProperty("supplemental_heating_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplementalHeatingCoilObjectType SupplementalHeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplementalHeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_SupplementalHeatingCoilObjectType), "CoilHeatingElectric");
        

        [Description("Needs to match in the supplemental heating coil object")]
        [JsonProperty("supplemental_heating_coil_name")]
        public string SupplementalHeatingCoilName { get; set; } = "";
        

        [JsonProperty("maximum_supply_air_temperature_from_supplemental_heater")]
        public string MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = "";
        

        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_supplemental_heater_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForSupplementalHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

        [JsonProperty("fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_AirToAir_FanPlacement FanPlacement { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_FanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_FanPlacement), "BlowThrough");
        

        [Description(@"A fan operating mode schedule value of 0 indicates cycling fan mode (supply air fan cycles on and off in tandem with the cooling or heating coil). Any other schedule value indicates continuous fan mode (supply air fan operates continuously regardless of cooling or heating coil operation). Leaving this schedule name blank will default to cycling fan mode for the entire simulation period.")]
        [JsonProperty("supply_air_fan_operating_mode_schedule_name")]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [Description(@"None = meet sensible load only Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only with cooling coil type CoilSystem:Cooling:DX:HeatExchangerAssisted. This control mode allows the heat exchanger to be turned on and off based on the zone dehumidification requirements. A ZoneControl:Humidistat object is also required. CoolReheat = cool beyond the dry-bulb setpoint. as required to meet the humidity setpoint. Valid with all cooling coil types. When a heat exchanger assisted Cooling coil is used, the heat exchanger is locked on at all times. A ZoneControl:Humidistat object is also required.")]
        [JsonProperty("dehumidification_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_AirToAir_DehumidificationControlType DehumidificationControlType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_DehumidificationControlType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_DehumidificationControlType), "None");
    }
}