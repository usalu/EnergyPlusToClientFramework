using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Unitary furnace with air conditioner")]
    [JsonObject("HVACTemplate:System:Unitary")]
    public class HVACTemplate_System_Unitary : BHoMObject, IEnergyPlusClass
    {
        

        [Description("If blank, always on; Unitary System always on. Schedule is used in availability m" +
                     "anager and fan scheduling. Also see \"Night Cycle Control\" field.")]
        [JsonProperty("system_availability_schedule_name")]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("control_zone_or_thermostat_location_name")]
        public string ControlZoneOrThermostatLocationName { get; set; } = "";
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
                     "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
                     "value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty("supply_fan_maximum_flow_rate")]
        public string SupplyFanMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
                     "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
                     "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
                     "e used.")]
        [JsonProperty("supply_fan_operating_mode_schedule_name")]
        public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

        [JsonProperty("supply_fan_total_efficiency")]
        public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_delta_pressure")]
        public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("600", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_efficiency")]
        public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_in_air_stream_fraction")]
        public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_coil_type")]
        public HVACTemplate_System_Unitary_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_Unitary_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_Unitary_CoolingCoilType), "SingleSpeedDX");
        

        [Description("If blank, always on")]
        [JsonProperty("cooling_coil_availability_schedule_name")]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Used for sizing.")]
        [JsonProperty("cooling_design_supply_air_temperature")]
        public System.Nullable<float> CoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("cooling_coil_gross_rated_total_capacity")]
        public string CoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Gross SHR")]
        [JsonProperty("cooling_coil_gross_rated_sensible_heat_ratio")]
        public string CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply air fan heat or supply air fan electric power")]
        [JsonProperty("cooling_coil_gross_rated_cop")]
        public System.Nullable<float> CoolingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_coil_type")]
        public HVACTemplate_System_Unitary_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_Unitary_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_Unitary_HeatingCoilType), "Electric");
        

        [Description("If blank, always on")]
        [JsonProperty("heating_coil_availability_schedule_name")]
        public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Used for sizing.")]
        [JsonProperty("heating_design_supply_air_temperature")]
        public System.Nullable<float> HeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_coil_capacity")]
        public string HeatingCoilCapacity { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("gas_heating_coil_efficiency")]
        public System.Nullable<float> GasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty("gas_heating_coil_parasitic_electric_load")]
        public System.Nullable<float> GasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_outdoor_air_flow_rate")]
        public string MaximumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("minimum_outdoor_air_flow_rate")]
        public string MinimumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("Schedule values multiply the minimum outdoor air flow rate If blank, always one")]
        [JsonProperty("minimum_outdoor_air_schedule_name")]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [JsonProperty("economizer_type")]
        public HVACTemplate_System_Unitary_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_Unitary_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_Unitary_EconomizerType), "NoEconomizer");
        

        [JsonProperty("economizer_lockout")]
        public HVACTemplate_System_Unitary_EconomizerLockout EconomizerLockout { get; set; } = (HVACTemplate_System_Unitary_EconomizerLockout)Enum.Parse(typeof(HVACTemplate_System_Unitary_EconomizerLockout), "NoLockout");
        

        [Description("Outdoor temperature above which economizer is disabled and heat recovery is enabl" +
                     "ed (if available). Blank means no limit.")]
        [JsonProperty("economizer_upper_temperature_limit")]
        public System.Nullable<float> EconomizerUpperTemperatureLimit { get; set; } = null;
        

        [Description("Outdoor temperature below which economizer is disabled and heat recovery is enabl" +
                     "ed (if available). Blank means no limit.")]
        [JsonProperty("economizer_lower_temperature_limit")]
        public System.Nullable<float> EconomizerLowerTemperatureLimit { get; set; } = null;
        

        [Description("Outdoor enthalpy above which economizer is disabled and heat recovery is enabled " +
                     "(if available). Blank means no limit.")]
        [JsonProperty("economizer_upper_enthalpy_limit")]
        public System.Nullable<float> EconomizerUpperEnthalpyLimit { get; set; } = null;
        

        [Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
                     "economizer control type. No input or blank input means this limit is not operati" +
                     "ve. Limit is applied regardless of economizer control type.")]
        [JsonProperty("economizer_maximum_limit_dewpoint_temperature")]
        public System.Nullable<float> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

        [Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
        [JsonProperty("supply_plenum_name")]
        public string SupplyPlenumName { get; set; } = "";
        

        [Description("Plenum zone name. Return plenum serves all zones on this system. Blank if none.")]
        [JsonProperty("return_plenum_name")]
        public string ReturnPlenumName { get; set; } = "";
        

        [JsonProperty("supply_fan_placement")]
        public HVACTemplate_System_Unitary_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_Unitary_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_Unitary_SupplyFanPlacement), "BlowThrough");
        

        [JsonProperty("night_cycle_control")]
        public HVACTemplate_System_Unitary_NightCycleControl NightCycleControl { get; set; } = (HVACTemplate_System_Unitary_NightCycleControl)Enum.Parse(typeof(HVACTemplate_System_Unitary_NightCycleControl), "StayOff");
        

        [Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
        [JsonProperty("night_cycle_control_zone_name")]
        public string NightCycleControlZoneName { get; set; } = "";
        

        [JsonProperty("heat_recovery_type")]
        public HVACTemplate_System_Unitary_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_Unitary_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_Unitary_HeatRecoveryType), "None");
        

        [JsonProperty("sensible_heat_recovery_effectiveness")]
        public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Heat Recovery Type is Enthalpy.")]
        [JsonProperty("latent_heat_recovery_effectiveness")]
        public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

        [Description(@"None = meet sensible cooling load only CoolReheatHeatingCoil = cool beyond the dry-bulb setpoint as required to meet the humidity setpoint, reheat with main heating coil. CoolReheatDesuperheater = cool beyond the dry-bulb setpoint as required to meet the humidity setpoint, reheat with desuperheater coil.")]
        [JsonProperty("dehumidification_control_type")]
        public HVACTemplate_System_Unitary_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_Unitary_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_Unitary_DehumidificationControlType), "None");
        

        [Description("Zone relative humidity setpoint in percent (0 to 100)")]
        [JsonProperty("dehumidification_setpoint")]
        public System.Nullable<float> DehumidificationSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

        [JsonProperty("humidifier_type")]
        public HVACTemplate_System_Unitary_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_Unitary_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_Unitary_HumidifierType), "None");
        

        [Description("If blank, always available")]
        [JsonProperty("humidifier_availability_schedule_name")]
        public string HumidifierAvailabilityScheduleName { get; set; } = "";
        

        [Description("Moisture output rate at full rated power input. The humidifier does not currently" +
                     " autosize, so the default is very large to allow for adequate capacity.")]
        [JsonProperty("humidifier_rated_capacity")]
        public System.Nullable<float> HumidifierRatedCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1E-06", CultureInfo.InvariantCulture);
        

        [Description("Electric power input at rated capacity moisture output. Power consumption is prop" +
                     "ortional to moisture output with no part-load penalty.")]
        [JsonProperty("humidifier_rated_electric_power")]
        public string HumidifierRatedElectricPower { get; set; } = (System.String)"Autosize";
        

        [Description("Zone name where humidistat is located")]
        [JsonProperty("humidifier_control_zone_name")]
        public string HumidifierControlZoneName { get; set; } = "";
        

        [Description("Zone relative humidity setpoint in percent (0 to 100)")]
        [JsonProperty("humidifier_setpoint")]
        public System.Nullable<float> HumidifierSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [Description("Specifies if the system has a return fan.")]
        [JsonProperty("return_fan")]
        public EmptyNoYes ReturnFan { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("return_fan_total_efficiency")]
        public System.Nullable<float> ReturnFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("return_fan_delta_pressure")]
        public System.Nullable<float> ReturnFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("500", CultureInfo.InvariantCulture);
        

        [JsonProperty("return_fan_motor_efficiency")]
        public System.Nullable<float> ReturnFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("return_fan_motor_in_air_stream_fraction")]
        public System.Nullable<float> ReturnFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}