using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Water-to-air heat pump. Forced-convection heating-cooling unit with supply fan, w" +
                 "ater-to-air cooling and heating coils, supplemental heating coil (gas, electric," +
                 " hot water, or steam), and fixed-position outdoor air mixer.")]
    public class ZoneHVAC_WaterToAirHeatPump : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Currently only one OutdoorAir:Mixer object type is available. This field should b" +
                     "e left blank if the WSHP is connected to central dedicated outdoor air through a" +
                     "n AirTerminal:SingleDuct:Mixer object.")]
        [JsonProperty("outdoor_air_mixer_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WaterToAirHeatPump_OutdoorAirMixerObjectType OutdoorAirMixerObjectType { get; set; } = (ZoneHVAC_WaterToAirHeatPump_OutdoorAirMixerObjectType)Enum.Parse(typeof(ZoneHVAC_WaterToAirHeatPump_OutdoorAirMixerObjectType), "OutdoorAirMixer");
        

        [Description(@"If this field is blank, the OutdoorAir:Mixer is not used. This optional field specifies the name of the OutdoorAir:Mixer object. When used, this name needs to match name of the OutdoorAir:Mixer object. This field should be left blank if the WSHP is connected to central dedicated outdoor air through an AirTerminal:SingleDuct:Mixer object.")]
        [JsonProperty("outdoor_air_mixer_name")]
        public string OutdoorAirMixerName { get; set; } = "";
        

        [Description("Must be less than or equal to fan size.")]
        [JsonProperty("cooling_supply_air_flow_rate")]
        public string CoolingSupplyAirFlowRate { get; set; } = "";
        

        [Description("Must be less than or equal to fan size.")]
        [JsonProperty("heating_supply_air_flow_rate")]
        public string HeatingSupplyAirFlowRate { get; set; } = "";
        

        [Description(@"Must be less than or equal to fan size. Only used when heat pump fan operating mode is continuous. This air flow rate is used when no heating or cooling is required and the DX coil compressor is off. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used.")]
        [JsonProperty("no_load_supply_air_flow_rate")]
        public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

        [Description("Must be less than or equal to supply air flow rate during cooling operation. This" +
                     " field is set to zero flow when the WSHP is connected to central dedicated outdo" +
                     "or air through air terminal single duct mixer object.")]
        [JsonProperty("cooling_outdoor_air_flow_rate")]
        public string CoolingOutdoorAirFlowRate { get; set; } = "";
        

        [Description("Must be less than or equal to supply air flow rate during heating operation. This" +
                     " field is set to zero flow when the WSHP is connected to central dedicated outdo" +
                     "or air through air terminal single duct mixer object.")]
        [JsonProperty("heating_outdoor_air_flow_rate")]
        public string HeatingOutdoorAirFlowRate { get; set; } = "";
        

        [Description(@"Only used when heat pump Fan operating mode is continuous. This air flow rate is used when no heating or cooling is required and the DX coil compressor is off. If this field is left blank or zero, the outdoor air flow rate from the previous on cycle (either cooling or heating) is used. This field is set to zero flow when the PTHP is connected to central dedicated outdoor air through air terminal single duct mixer object.")]
        [JsonProperty("no_load_outdoor_air_flow_rate")]
        public string NoLoadOutdoorAirFlowRate { get; set; } = "";
        

        [JsonProperty("supply_air_fan_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WaterToAirHeatPump_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (ZoneHVAC_WaterToAirHeatPump_SupplyAirFanObjectType)Enum.Parse(typeof(ZoneHVAC_WaterToAirHeatPump_SupplyAirFanObjectType), "FanOnOff");
        

        [Description("Needs to match Fan:SystemModel or Fan:OnOff object")]
        [JsonProperty("supply_air_fan_name")]
        public string SupplyAirFanName { get; set; } = "";
        

        [JsonProperty("heating_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WaterToAirHeatPump_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (ZoneHVAC_WaterToAirHeatPump_HeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_WaterToAirHeatPump_HeatingCoilObjectType), "CoilHeatingWaterToAirHeatPumpEquationFit");
        

        [Description("Needs to match in the water-to-air heat pump heating coil object")]
        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
        

        [JsonProperty("cooling_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WaterToAirHeatPump_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (ZoneHVAC_WaterToAirHeatPump_CoolingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_WaterToAirHeatPump_CoolingCoilObjectType), "CoilCoolingWaterToAirHeatPumpEquationFit");
        

        [Description("Needs to match in the water-to-air heat pump cooling coil object")]
        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
        

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
        public ZoneHVAC_WaterToAirHeatPump_SupplementalHeatingCoilObjectType SupplementalHeatingCoilObjectType { get; set; } = (ZoneHVAC_WaterToAirHeatPump_SupplementalHeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_WaterToAirHeatPump_SupplementalHeatingCoilObjectType), "CoilHeatingElectric");
        

        [Description("Needs to match in the supplemental heating coil object")]
        [JsonProperty("supplemental_heating_coil_name")]
        public string SupplementalHeatingCoilName { get; set; } = "";
        

        [Description("Supply air temperature from the supplemental heater will not exceed this value.")]
        [JsonProperty("maximum_supply_air_temperature_from_supplemental_heater")]
        public string MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_supplemental_heater_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForSupplementalHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

        [JsonProperty("outdoor_dry_bulb_temperature_sensor_node_name")]
        public string OutdoorDryBulbTemperatureSensorNodeName { get; set; } = "";
        

        [JsonProperty("fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WaterToAirHeatPump_FanPlacement FanPlacement { get; set; } = (ZoneHVAC_WaterToAirHeatPump_FanPlacement)Enum.Parse(typeof(ZoneHVAC_WaterToAirHeatPump_FanPlacement), "BlowThrough");
        

        [Description(@"Enter the name of a schedule that controls fan operation. Schedule values of 0 denote cycling fan operation (fan cycles with cooling or heating coil). Schedule values greater than 0 denote constant fan operation (fan runs continually regardless of coil operation). The fan operating mode defaults to cycling fan operation if this field is left blank.")]
        [JsonProperty("supply_air_fan_operating_mode_schedule_name")]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty("availability_manager_list_name")]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description(@"used only when the heat pump coils are of the type WaterToAirHeatPump:EquationFit Constant results in 100% water flow regardless of compressor PLR Cycling results in water flow that matches compressor PLR ConstantOnDemand results in 100% water flow whenever the coil is on, but is 0% whenever the coil has no load")]
        [JsonProperty("heat_pump_coil_water_flow_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode HeatPumpCoilWaterFlowMode { get; set; } = (ZoneHVAC_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode)Enum.Parse(typeof(ZoneHVAC_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode), "Cycling");
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty("design_specification_zonehvac_sizing_object_name")]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
}