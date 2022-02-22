using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    [Description(@"Unitary heat pump system, heating and cooling, single-speed with constant volume supply fan (continuous or cycling), direct expansion (DX) cooling coil, DX heating coil (water-to-air heat pump), and supplemental heating coil (gas, electric, hot water, or steam).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_UnitaryHeatPump_WaterToAir : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("This value should be > 0 and <= than the fan air flow rate.")]
        [JsonProperty("supply_air_flow_rate")]
        public string SupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("controlling_zone_or_thermostat_location")]
        public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

        [Description("Only works with On/Off Fan")]
        [JsonProperty("supply_air_fan_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplyAirFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplyAirFanObjectType), "FanOnOff");
        

        [Description("Needs to match Fan:OnOff object")]
        [JsonProperty("supply_air_fan_name")]
        public string SupplyAirFanName { get; set; } = "";
        

        [JsonProperty("heating_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatingCoilObjectType), "CoilHeatingWaterToAirHeatPumpEquationFit");
        

        [Description("Needs to match in the water-to-air heat pump heating coil object")]
        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
        

        [JsonProperty("heating_convergence")]
        public System.Nullable<float> HeatingConvergence { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_WaterToAir_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_CoolingCoilObjectType), "CoilCoolingWaterToAirHeatPumpEquationFit");
        

        [Description("Needs to match in the water-to-air heat pump cooling coil object")]
        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
        

        [JsonProperty("cooling_convergence")]
        public System.Nullable<float> CoolingConvergence { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("The maximum on-off cycling rate for the compressor Suggested value is 2.5 for a t" +
                     "ypical heat pump")]
        [JsonProperty("maximum_cycling_rate")]
        public System.Nullable<float> MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("2.5", CultureInfo.InvariantCulture);
        

        [Description("Time constant for the cooling coil\'s capacity to reach steady state after startup" +
                     " Suggested value is 60 for a typical heat pump")]
        [JsonProperty("heat_pump_time_constant")]
        public System.Nullable<float> HeatPumpTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

        [Description("The fraction of on-cycle power use to adjust the part load fraction based on the " +
                     "off-cycle power consumption due to crankcase heaters, controls, fans, and etc. S" +
                     "uggested value is 0.01 for a typical heat pump")]
        [JsonProperty("fraction_of_on_cycle_power_use")]
        public System.Nullable<float> FractionOfOnCyclePowerUse { get; set; } = (System.Nullable<float>)Single.Parse("0.01", CultureInfo.InvariantCulture);
        

        [Description("Programmed time delay for heat pump fan to shut off after compressor cycle off. O" +
                     "nly required when fan operating mode is cycling Enter 0 when fan operating mode " +
                     "is continuous")]
        [JsonProperty("heat_pump_fan_delay_time")]
        public System.Nullable<float> HeatPumpFanDelayTime { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

        [Description("works with gas, electric, hot water and steam heating coils")]
        [JsonProperty("supplemental_heating_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplementalHeatingCoilObjectType SupplementalHeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplementalHeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_SupplementalHeatingCoilObjectType), "CoilHeatingElectric");
        

        [Description("Needs to match in the supplemental heating coil object")]
        [JsonProperty("supplemental_heating_coil_name")]
        public string SupplementalHeatingCoilName { get; set; } = "";
        

        [JsonProperty("maximum_supply_air_temperature_from_supplemental_heater")]
        public string MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = "";
        

        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_supplemental_heater_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForSupplementalHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

        [JsonProperty("outdoor_dry_bulb_temperature_sensor_node_name")]
        public string OutdoorDryBulbTemperatureSensorNodeName { get; set; } = "";
        

        [JsonProperty("fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_WaterToAir_FanPlacement FanPlacement { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_FanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_FanPlacement), "BlowThrough");
        

        [Description(@"Enter the name of a schedule that controls fan operation. Schedule values of 0 denote cycling fan operation (fan cycles with cooling or heating coil). Schedule values greater than 0 denote constant fan operation (fan runs continually regardless of coil operation). The fan operating mode defaults to cycling fan operation if this field is left blank.")]
        [JsonProperty("supply_air_fan_operating_mode_schedule_name")]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [Description("None = meet sensible load only CoolReheat = cool beyond the dry-bulb setpoint. as" +
                     " required to meet the humidity setpoint. Valid only with Coil:Cooling:WaterToAir" +
                     "HeatPump:EquationFit or Coil:Cooling:WaterToAirHeatPump:VariableSpeedEquationFit" +
                     "")]
        [JsonProperty("dehumidification_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_WaterToAir_DehumidificationControlType DehumidificationControlType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_DehumidificationControlType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_DehumidificationControlType), "None");
        

        [Description(@"used only when the heat pump coils are of the type WaterToAirHeatPump:EquationFit Constant results in 100% water flow regardless of compressor PLR Cycling results in water flow that matches compressor PLR ConstantOnDemand results in 100% water flow whenever the coil is on, but is 0% whenever the coil has no load")]
        [JsonProperty("heat_pump_coil_water_flow_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatPumpCoilWaterFlowMode HeatPumpCoilWaterFlowMode { get; set; } = (AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatPumpCoilWaterFlowMode)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_WaterToAir_HeatPumpCoilWaterFlowMode), "Cycling");
    }
}