using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("This object creates a dedicated outdoor air system that must be used with HVACTem" +
                 "plate:Zone:* objects for BaseboardHeat FanCoil PTAC PTHP WaterToAirHeatPump and " +
                 "VRF. Does not support HVACTemplate:Zone:VAV or other central multizone systems")]
    [JsonObject("HVACTemplate:System:DedicatedOutdoorAir")]
    public class HVACTemplate_System_DedicatedOutdoorAir : BHoMObject, IEnergyPlusClass
    {
        

        [Description("If blank, always on; DOAS System always on. Schedule is used in availability mana" +
                     "ger and fan scheduling.")]
        [JsonProperty("system_availability_schedule_name")]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("air_outlet_type")]
        public HVACTemplate_System_DedicatedOutdoorAir_AirOutletType AirOutletType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_AirOutletType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_AirOutletType), "DirectIntoZone");
        

        [JsonProperty("supply_fan_flow_rate")]
        public string SupplyFanFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("supply_fan_total_efficiency")]
        public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_delta_pressure")]
        public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_efficiency")]
        public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_in_air_stream_fraction")]
        public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_placement")]
        public HVACTemplate_System_DedicatedOutdoorAir_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_SupplyFanPlacement), "DrawThrough");
        

        [JsonProperty("cooling_coil_type")]
        public HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilType), "ChilledWater");
        

        [Description("If blank, always on")]
        [JsonProperty("cooling_coil_availability_schedule_name")]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("cooling_coil_setpoint_control_type")]
        public HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilSetpointControlType CoolingCoilSetpointControlType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilSetpointControlType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilSetpointControlType), "FixedSetpoint");
        

        [Description("Used for sizing and as constant setpoint if no Cooling Coil Setpoint Schedule Nam" +
                     "e is specified.")]
        [JsonProperty("cooling_coil_design_setpoint")]
        public System.Nullable<float> CoolingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty("cooling_coil_setpoint_schedule_name")]
        public string CoolingCoilSetpointScheduleName { get; set; } = "";
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("cooling_coil_setpoint_at_outdoor_dry_bulb_low")]
        public System.Nullable<float> CoolingCoilSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15.6", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control. Defaults are 15.6C (60F) " +
                     "at 15.6C (60F) to 12.8C (55F) at 23.3C (74F)")]
        [JsonProperty("cooling_coil_reset_outdoor_dry_bulb_low")]
        public System.Nullable<float> CoolingCoilResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15.6", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("cooling_coil_setpoint_at_outdoor_dry_bulb_high")]
        public System.Nullable<float> CoolingCoilSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("cooling_coil_reset_outdoor_dry_bulb_high")]
        public System.Nullable<float> CoolingCoilResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("23.3", CultureInfo.InvariantCulture);
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("dx_cooling_coil_gross_rated_total_capacity")]
        public string DxCoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Gross SHR")]
        [JsonProperty("dx_cooling_coil_gross_rated_sensible_heat_ratio")]
        public string DxCoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electrical energy input")]
        [JsonProperty("dx_cooling_coil_gross_rated_cop")]
        public System.Nullable<float> DxCoolingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_coil_type")]
        public HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilType), "HotWater");
        

        [Description("If blank, always on")]
        [JsonProperty("heating_coil_availability_schedule_name")]
        public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("When selecting OutdoorAirTemperatureReset, the Heating Coil Design Setpoint may n" +
                     "eed to be changed")]
        [JsonProperty("heating_coil_setpoint_control_type")]
        public HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilSetpointControlType HeatingCoilSetpointControlType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilSetpointControlType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilSetpointControlType), "FixedSetpoint");
        

        [Description("Used for sizing and as constant setpoint if no Heating Coil Setpoint Schedule Nam" +
                     "e is specified.")]
        [JsonProperty("heating_coil_design_setpoint")]
        public System.Nullable<float> HeatingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("12.2", CultureInfo.InvariantCulture);
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty("heating_coil_setpoint_schedule_name")]
        public string HeatingCoilSetpointScheduleName { get; set; } = "";
        

        [Description("Applicable only for OutdoorAirTemperatureReset control. Defaults 15.0C (59F) at 7" +
                     ".8C (46F) to 12.2C (54F) at 12.2C (54F)")]
        [JsonProperty("heating_coil_setpoint_at_outdoor_dry_bulb_low")]
        public System.Nullable<float> HeatingCoilSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("heating_coil_reset_outdoor_dry_bulb_low")]
        public System.Nullable<float> HeatingCoilResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("7.8", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("heating_coil_setpoint_at_outdoor_dry_bulb_high")]
        public System.Nullable<float> HeatingCoilSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.2", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("heating_coil_reset_outdoor_dry_bulb_high")]
        public System.Nullable<float> HeatingCoilResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("gas_heating_coil_efficiency")]
        public System.Nullable<float> GasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty("gas_heating_coil_parasitic_electric_load")]
        public System.Nullable<float> GasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_recovery_type")]
        public HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryType), "None");
        

        [JsonProperty("heat_recovery_sensible_effectiveness")]
        public System.Nullable<float> HeatRecoverySensibleEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_recovery_latent_effectiveness")]
        public System.Nullable<float> HeatRecoveryLatentEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_recovery_heat_exchanger_type")]
        public HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryHeatExchangerType HeatRecoveryHeatExchangerType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryHeatExchangerType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryHeatExchangerType), "Plate");
        

        [JsonProperty("heat_recovery_frost_control_type")]
        public HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryFrostControlType HeatRecoveryFrostControlType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryFrostControlType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryFrostControlType), "None");
        

        [Description(@"None = meet sensible load only CoolReheatHeatingCoil = cool beyond the dry-bulb setpoint, reheat with heating coil Valid for all cooling coil types. If no heating coil specified, cold supply temps may occur. CoolReheatDesuperheater = cool beyond the dry-bulb setpoint as required to meet the humidity setpoint, reheat with desuperheater coil. Valid only for Cooling Coil Type = TwoSpeedDX, TwoStageDX, TwoStageHumidityControlDX, or HeatExchangerAssistedDX. Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only for Cooling Coil Type = TwoStageHumidityControlDX or HeatExchangerAssistedDX")]
        [JsonProperty("dehumidification_control_type")]
        public HVACTemplate_System_DedicatedOutdoorAir_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_DehumidificationControlType), "None");
        

        [Description("The supply air humidity ratio for dehumidification control. Default of 0.00924 kg" +
                     "Water/kgDryAir is equivalent to 12.8C (55F) dewpoint. Ignored if Dehumidificatio" +
                     "n Setpoint Schedule specified below")]
        [JsonProperty("dehumidification_setpoint")]
        public System.Nullable<float> DehumidificationSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("0.00924", CultureInfo.InvariantCulture);
        

        [JsonProperty("humidifier_type")]
        public HVACTemplate_System_DedicatedOutdoorAir_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HumidifierType), "None");
        

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
        

        [Description("The supply air humidity ratio for humidification control. Ignored if Humidifier S" +
                     "etpoint Schedule specified below")]
        [JsonProperty("humidifier_constant_setpoint")]
        public System.Nullable<float> HumidifierConstantSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("0.003", CultureInfo.InvariantCulture);
        

        [Description("Leave blank to use constant setpoint specified in Dehumidification Setpoint above" +
                     ". Schedule values must be in units of humidity ratio (kgWater/kgDryAir or lbWate" +
                     "r/lbDryAir)")]
        [JsonProperty("dehumidification_setpoint_schedule_name")]
        public string DehumidificationSetpointScheduleName { get; set; } = "";
        

        [Description("Leave blank to use constant setpoint specified in Humidifier Constant Setpoint ab" +
                     "ove. Schedule values must be in units of humidity ratio (kgWater/kgDryAir or lbW" +
                     "ater/lbDryAir)")]
        [JsonProperty("humidifier_setpoint_schedule_name")]
        public string HumidifierSetpointScheduleName { get; set; } = "";
    }
}