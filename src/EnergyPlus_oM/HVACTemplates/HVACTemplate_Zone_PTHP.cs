using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Packaged Terminal Heat Pump")]
    public class HVACTemplate_Zone_PTHP : BHoMObject, IEnergyPlusClass
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
        

        [Description(@"Supply air flow rate when no cooling or heating is needed Only used when heat pump fan operating mode is continuous. This air flow rate is used when no heating or cooling is required and the DX coil compressor is off. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used. A value entered in this field will *not* be multiplied by the sizing factor or by zone multipliers. It is best to autosize or leave blank when using zone multipliers.")]
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
        public HVACTemplate_Zone_PTHP_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_PTHP_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_OutdoorAirMethod), "Empty");
        

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
        public HVACTemplate_Zone_PTHP_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_Zone_PTHP_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_SupplyFanPlacement), "DrawThrough");
        

        [JsonProperty("supply_fan_total_efficiency")]
        public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_delta_pressure")]
        public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("75", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_efficiency")]
        public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_Zone_PTHP_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_CoolingCoilType), "SingleSpeedDX");
        

        [Description("If blank, always on")]
        [JsonProperty("cooling_coil_availability_schedule_name")]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat Ratin" +
                     "g point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and a" +
                     "ir entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty("cooling_coil_gross_rated_total_capacity")]
        public string CoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
                     " and total capacities do not include effect of supply fan heat")]
        [JsonProperty("cooling_coil_gross_rated_sensible_heat_ratio")]
        public string CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electrical energy input")]
        [JsonProperty("cooling_coil_gross_rated_cop")]
        public System.Nullable<float> CoolingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_pump_heating_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_HeatPumpHeatingCoilType HeatPumpHeatingCoilType { get; set; } = (HVACTemplate_Zone_PTHP_HeatPumpHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_HeatPumpHeatingCoilType), "SingleSpeedDXHeatPump");
        

        [Description("If blank, always on")]
        [JsonProperty("heat_pump_heating_coil_availability_schedule_name")]
        public string HeatPumpHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Capacity excluding supply air fan heat Rating point outdoor dry-bulb temp 8.33 C," +
                     " outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21" +
                     ".11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty("heat_pump_heating_coil_gross_rated_capacity")]
        public string HeatPumpHeatingCoilGrossRatedCapacity { get; set; } = (System.String)"Autosize";
        

        [Description(@"Heat Pump Heating Coil Rated Capacity divided by power input to the compressor and outdoor fan, Does not include supply air fan heat or supply air fan electrical energy Rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty("heat_pump_heating_coil_gross_rated_cop")]
        public System.Nullable<float> HeatPumpHeatingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("2.75", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_pump_heating_minimum_outdoor_dry_bulb_temperature")]
        public System.Nullable<float> HeatPumpHeatingMinimumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-8", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_pump_defrost_maximum_outdoor_dry_bulb_temperature")]
        public System.Nullable<float> HeatPumpDefrostMaximumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_pump_defrost_strategy")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_HeatPumpDefrostStrategy HeatPumpDefrostStrategy { get; set; } = (HVACTemplate_Zone_PTHP_HeatPumpDefrostStrategy)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_HeatPumpDefrostStrategy), "ReverseCycle");
        

        [JsonProperty("heat_pump_defrost_control")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_HeatPumpDefrostControl HeatPumpDefrostControl { get; set; } = (HVACTemplate_Zone_PTHP_HeatPumpDefrostControl)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_HeatPumpDefrostControl), "Timed");
        

        [Description("Fraction of time in defrost mode only applicable if Timed defrost control is spec" +
                     "ified")]
        [JsonProperty("heat_pump_defrost_time_period_fraction")]
        public System.Nullable<float> HeatPumpDefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

        [JsonProperty("supplemental_heating_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_SupplementalHeatingCoilType SupplementalHeatingCoilType { get; set; } = (HVACTemplate_Zone_PTHP_SupplementalHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_SupplementalHeatingCoilType), "Electric");
        

        [Description("If blank, always on")]
        [JsonProperty("supplemental_heating_coil_availability_schedule_name")]
        public string SupplementalHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("supplemental_heating_coil_capacity")]
        public string SupplementalHeatingCoilCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Supplemental heater will not operate when outdoor temperature exceeds this value." +
                     "")]
        [JsonProperty("supplemental_heating_coil_maximum_outdoor_dry_bulb_temperature")]
        public System.Nullable<float> SupplementalHeatingCoilMaximumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

        [Description("Applies only if Supplemental Heating Coil Type is Gas")]
        [JsonProperty("supplemental_gas_heating_coil_efficiency")]
        public System.Nullable<float> SupplementalGasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [Description("Applies only if Supplemental Heating Coil Type is Gas")]
        [JsonProperty("supplemental_gas_heating_coil_parasitic_electric_load")]
        public System.Nullable<float> SupplementalGasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this zone " +
                     "is served by a separate dedicated outdoor air system (DOAS). Leave field blank i" +
                     "f no DOAS serves this zone.")]
        [JsonProperty("dedicated_outdoor_air_system_name")]
        public string DedicatedOutdoorAirSystemName { get; set; } = "";
        

        [Description("SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperat" +
                     "ure TemperatureDifference = use the value from Zone Cooling Design Supply Air Te" +
                     "mperature Difference")]
        [JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_PTHP_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

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
        public HVACTemplate_Zone_PTHP_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_PTHP_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

        [Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty("zone_heating_design_supply_air_temperature")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
        [JsonProperty("zone_heating_design_supply_air_temperature_difference")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty("design_specification_outdoor_air_object_name")]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty("design_specification_zone_air_distribution_object_name")]
        public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

        [JsonProperty("baseboard_heating_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_PTHP_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_BaseboardHeatingType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty("baseboard_heating_availability_schedule_name")]
        public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("baseboard_heating_capacity")]
        public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("capacity_control_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_CapacityControlMethod CapacityControlMethod { get; set; } = (HVACTemplate_Zone_PTHP_CapacityControlMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_CapacityControlMethod), "None");
    }
}