using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    [Description(@"Unitary system, heating and cooling, multi-speed with constant volume supply fan (continuous or cycling), direct expansion (DX) cooling coil, heating coil (DX air-to-air heat pump, gas, electric, hot water, or steam), and supplemental heating coil (gas, electric, hot water, or steam).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed : BHoMObject, IEnergyPlusNode
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
        

        [JsonProperty("controlling_zone_or_thermostat_location")]
        public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

        [Description("Select the type of supply air fan used in this unitary system.")]
        [JsonProperty("supply_air_fan_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanObjectType), "FanConstantVolume");
        

        [Description("Enter the name of the supply air fan used in this unitary system.")]
        [JsonProperty("supply_air_fan_name")]
        public string SupplyAirFanName { get; set; } = "";
        

        [Description(@"Select supply air fan placement as either BlowThrough or DrawThrough. BlowThrough means the supply air fan is located before the cooling coil. DrawThrough means the supply air fan is located after the heating coil but before the optional supplemental heating coil.")]
        [JsonProperty("supply_air_fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanPlacement SupplyAirFanPlacement { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanPlacement), "BlowThrough");
        

        [Description(@"Enter the name of a schedule to control the supply air fan. Schedule values of zero mean that the supply air fan will cycle off if there is no cooling or heating load in the control zone. Non-zero schedule values mean that the supply air fan will operate continuously even if there is no cooling or heating load in the control zone. If this field is left blank, the supply air fan will operate continuously for the entire simulation period.")]
        [JsonProperty("supply_air_fan_operating_mode_schedule_name")]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [Description("Multi Speed DX, Electric, Gas, and Single speed Water and Steam coils")]
        [JsonProperty("heating_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_HeatingCoilObjectType), "CoilHeatingDXMultiSpeed");
        

        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
        

        [Description("Needs to match the corresponding minimum outdoor temperature defined in the DX he" +
                     "ating coil object.")]
        [JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
        public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-8", CultureInfo.InvariantCulture);
        

        [Description("Only works with Coil:Cooling:DX:MultiSpeed")]
        [JsonProperty("cooling_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_CoolingCoilObjectType), "CoilCoolingDXMultiSpeed");
        

        [Description("Needs to match in the DX Cooling Coil object")]
        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
        

        [Description("works with gas, electric, hot water and steam heating coils")]
        [JsonProperty("supplemental_heating_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplementalHeatingCoilObjectType SupplementalHeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplementalHeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplementalHeatingCoilObjectType), "CoilHeatingElectric");
        

        [Description("Needs to match in the supplemental heating coil object")]
        [JsonProperty("supplemental_heating_coil_name")]
        public string SupplementalHeatingCoilName { get; set; } = "";
        

        [JsonProperty("maximum_supply_air_temperature_from_supplemental_heater")]
        public string MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = "";
        

        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_supplemental_heater_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForSupplementalHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

        [JsonProperty("auxiliary_on_cycle_electric_power")]
        public System.Nullable<float> AuxiliaryOnCycleElectricPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("auxiliary_off_cycle_electric_power")]
        public System.Nullable<float> AuxiliaryOffCycleElectricPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("If non-zero, then the heat recovery inlet and outlet node names must be entered. " +
                     "Used for heat recovery to an EnergyPlus plant loop.")]
        [JsonProperty("design_heat_recovery_water_flow_rate")]
        public System.Nullable<float> DesignHeatRecoveryWaterFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_temperature_for_heat_recovery")]
        public System.Nullable<float> MaximumTemperatureForHeatRecovery { get; set; } = (System.Nullable<float>)Single.Parse("80", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_recovery_water_inlet_node_name")]
        public string HeatRecoveryWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("heat_recovery_water_outlet_node_name")]
        public string HeatRecoveryWaterOutletNodeName { get; set; } = "";
        

        [Description(@"Only used when the supply air fan operating mode is continuous (see field Supply Air Fan Operating Mode Schedule Name). This air flow rate is used when no heating or cooling is required and the coils are off. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used.")]
        [JsonProperty("no_load_supply_air_flow_rate")]
        public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

        [Description("Enter the number of the following sets of data for air flow rates. If Heating Coi" +
                     "l Object Type is Coil:Heating:Water or Coil:Heating:Steam, this field should be " +
                     "1.")]
        [JsonProperty("number_of_speeds_for_heating")]
        public System.Nullable<float> NumberOfSpeedsForHeating { get; set; } = null;
        

        [Description("Enter the number of the following sets of data for air flow rates.")]
        [JsonProperty("number_of_speeds_for_cooling")]
        public System.Nullable<float> NumberOfSpeedsForCooling { get; set; } = null;
        

        [Description("Enter the operating supply air flow rate during heating operation or specify auto" +
                     "size.")]
        [JsonProperty("heating_speed_1_supply_air_flow_rate")]
        public string HeatingSpeed1SupplyAirFlowRate { get; set; } = "";
        

        [Description("Enter the operating supply air flow rate during heating operation or specify auto" +
                     "size.")]
        [JsonProperty("heating_speed_2_supply_air_flow_rate")]
        public string HeatingSpeed2SupplyAirFlowRate { get; set; } = "";
        

        [Description("Enter the operating supply air flow rate during heating operation or specify auto" +
                     "size.")]
        [JsonProperty("heating_speed_3_supply_air_flow_rate")]
        public string HeatingSpeed3SupplyAirFlowRate { get; set; } = "";
        

        [Description("Enter the operating supply air flow rate during heating operation or specify auto" +
                     "size.")]
        [JsonProperty("heating_speed_4_supply_air_flow_rate")]
        public string HeatingSpeed4SupplyAirFlowRate { get; set; } = "";
        

        [Description("Enter the operating supply air flow rate during cooling operation or specify auto" +
                     "size.")]
        [JsonProperty("cooling_speed_1_supply_air_flow_rate")]
        public string CoolingSpeed1SupplyAirFlowRate { get; set; } = "";
        

        [Description("Enter the operating supply air flow rate during cooling operation or specify auto" +
                     "size.")]
        [JsonProperty("cooling_speed_2_supply_air_flow_rate")]
        public string CoolingSpeed2SupplyAirFlowRate { get; set; } = "";
        

        [Description("Enter the operating supply air flow rate during cooling operation or specify auto" +
                     "size.")]
        [JsonProperty("cooling_speed_3_supply_air_flow_rate")]
        public string CoolingSpeed3SupplyAirFlowRate { get; set; } = "";
        

        [Description("Enter the operating supply air flow rate during cooling operation or specify auto" +
                     "size.")]
        [JsonProperty("cooling_speed_4_supply_air_flow_rate")]
        public string CoolingSpeed4SupplyAirFlowRate { get; set; } = "";
    }
}