using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Water to Air Heat Pump to be used with HVACTemplate:Plant:MixedWaterLoop")]
    public class HVACTemplate_Zone_WaterToAirHeatPump : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Zone name must match a building zone name")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
                     "that standard thermostat objects have been defined for this zone.")]
        [JsonProperty("template_thermostat_name")]
        public string TemplateThermostatName { get; set; } = "";
        

        [Description("Supply air flow rate during cooling operation This field may be set to \"autosize\"" +
                     ". If a value is entered, it will be multiplied by the Supply Air Sizing Factor a" +
                     "nd by zone multipliers.")]
        [JsonProperty("cooling_supply_air_flow_rate")]
        public string CoolingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("Supply air flow rate during heating operation This field may be set to \"autosize\"" +
                     ". If a value is entered, it will be multiplied by the Supply Air Sizing Factor a" +
                     "nd by zone multipliers.")]
        [JsonProperty("heating_supply_air_flow_rate")]
        public string HeatingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description(@"Supply air flow rate when no cooling or heating is needed Only used when heat pump fan operating mode is continuous. This air flow rate is used when no heating or cooling is required. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used. A value entered in this field will *not* be multiplied by the sizing factor or by zone multipliers. It is best to autosize or leave blank when using zone multipliers.")]
        [JsonProperty("no_load_supply_air_flow_rate")]
        public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty("zone_heating_sizing_factor")]
        public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty("zone_cooling_sizing_factor")]
        public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

        [Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
        [JsonProperty("outdoor_air_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_OutdoorAirMethod), "Empty");
        

        [Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
                     "Method is Flow/Person, Sum, or Maximum")]
        [JsonProperty("outdoor_air_flow_rate_per_person")]
        public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

        [Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
        [JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
        public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
        [JsonProperty("outdoor_air_flow_rate_per_zone")]
        public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("If blank, always on")]
        [JsonProperty("system_availability_schedule_name")]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
                     "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
                     "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
                     "e used.")]
        [JsonProperty("supply_fan_operating_mode_schedule_name")]
        public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

        [JsonProperty("supply_fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_SupplyFanPlacement), "DrawThrough");
        

        [JsonProperty("supply_fan_total_efficiency")]
        public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_delta_pressure")]
        public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("75", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_efficiency")]
        public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_CoolingCoilType), "Empty");
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("cooling_coil_gross_rated_total_capacity")]
        public string CoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
                     " and total capacities do not include effect of supply fan heat")]
        [JsonProperty("cooling_coil_gross_rated_sensible_heat_ratio")]
        public string CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electric power input")]
        [JsonProperty("cooling_coil_gross_rated_cop")]
        public System.Nullable<float> CoolingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_pump_heating_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpHeatingCoilType HeatPumpHeatingCoilType { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpHeatingCoilType), "Empty");
        

        [Description("Capacity excluding supply air fan heat")]
        [JsonProperty("heat_pump_heating_coil_gross_rated_capacity")]
        public string HeatPumpHeatingCoilGrossRatedCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Heat Pump Heating Coil Rated Capacity divided by power input to the compressor an" +
                     "d outdoor fan, does not include supply air fan heat or supply air fan electric p" +
                     "ower input")]
        [JsonProperty("heat_pump_heating_coil_gross_rated_cop")]
        public System.Nullable<float> HeatPumpHeatingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("4.2", CultureInfo.InvariantCulture);
        

        [Description("If blank, always on")]
        [JsonProperty("supplemental_heating_coil_availability_schedule_name")]
        public string SupplementalHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("supplemental_heating_coil_capacity")]
        public string SupplementalHeatingCoilCapacity { get; set; } = (System.String)"Autosize";
        

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
        

        [Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this zone " +
                     "is served by a separate dedicated outdoor air system (DOAS). Leave field blank i" +
                     "f no DOAS serves this zone.")]
        [JsonProperty("dedicated_outdoor_air_system_name")]
        public string DedicatedOutdoorAirSystemName { get; set; } = "";
        

        [JsonProperty("supplemental_heating_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_SupplementalHeatingCoilType SupplementalHeatingCoilType { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_SupplementalHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_SupplementalHeatingCoilType), "Electric");
        

        [Description("SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperat" +
                     "ure TemperatureDifference = use the value from Zone Cooling Design Supply Air Te" +
                     "mperature Difference")]
        [JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

        [Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty("zone_cooling_design_supply_air_temperature")]
        public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("14", CultureInfo.InvariantCulture);
        

        [Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
        [JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
        public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

        [Description("SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperat" +
                     "ure TemperatureDifference = use the value from Zone Heating Design Supply Air Te" +
                     "mperature Difference")]
        [JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

        [Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty("zone_heating_design_supply_air_temperature")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
        [JsonProperty("zone_heating_design_supply_air_temperature_difference")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [Description(@"used only when the heat pump coils are of the type WaterToAirHeatPump:EquationFit Constant results in 100% water flow regardless of compressor PLR Cycling results in water flow that matches compressor PLR ConstantOnDemand results in 100% water flow whenever the coil is on, but is 0% whenever the coil has no load")]
        [JsonProperty("heat_pump_coil_water_flow_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode HeatPumpCoilWaterFlowMode { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode), "Cycling");
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty("design_specification_outdoor_air_object_name")]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty("design_specification_zone_air_distribution_object_name")]
        public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

        [JsonProperty("baseboard_heating_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_BaseboardHeatingType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty("baseboard_heating_availability_schedule_name")]
        public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("baseboard_heating_capacity")]
        public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
    }
}