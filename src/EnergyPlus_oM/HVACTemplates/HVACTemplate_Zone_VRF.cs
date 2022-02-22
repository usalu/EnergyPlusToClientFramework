using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Zone terminal unit with variable refrigerant flow (VRF) DX cooling and heating co" +
                 "ils (air-to-air or water-to-air heat pump). The VRF terminal units are served by" +
                 " an HVACTemplate:System:VRF system.")]
    public class HVACTemplate_Zone_VRF : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Zone name must match a building zone name")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Name of a HVACTemplate:System:VRF object serving this zone")]
        [JsonProperty("template_vrf_system_name")]
        public string TemplateVrfSystemName { get; set; } = "";
        

        [Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
                     "that standard thermostat objects have been defined for this zone.")]
        [JsonProperty("template_thermostat_name")]
        public string TemplateThermostatName { get; set; } = "";
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty("zone_heating_sizing_factor")]
        public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty("zone_cooling_sizing_factor")]
        public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

        [Description(@"If this terminal unit's heating coil is autosized, the heating capacity is sized to be equal to the cooling capacity multiplied by this sizing ratio. This input applies to the terminal unit heating coil and overrides the sizing ratio entered in the HVACTemplate:System:VRF object.")]
        [JsonProperty("rated_total_heating_capacity_sizing_ratio")]
        public System.Nullable<float> RatedTotalHeatingCapacitySizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
                     " by the Supply Air Sizing Factor and by zone multipliers.")]
        [JsonProperty("cooling_supply_air_flow_rate")]
        public string CoolingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("This flow rate is used when the terminal is not cooling and the previous mode was" +
                     " cooling. This field may be set to \"autosize\". If a value is entered, it will be" +
                     " multiplied by the Supply Air Sizing Factor and by zone multipliers.")]
        [JsonProperty("no_cooling_supply_air_flow_rate")]
        public string NoCoolingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
                     " by the Supply Air Sizing Factor and by zone multipliers.")]
        [JsonProperty("heating_supply_air_flow_rate")]
        public string HeatingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("This flow rate is used when the terminal is not heating and the previous mode was" +
                     " heating. This field may be set to \"autosize\". If a value is entered, it will be" +
                     " multiplied by the Supply Air Sizing Factor and by zone multipliers.")]
        [JsonProperty("no_heating_supply_air_flow_rate")]
        public string NoHeatingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("If this field is set to autosize it will be sized based on the outdoor air inputs" +
                     " below, unless a dedicated outdoor air system is specified for this zone and the" +
                     "n it will be set to zero.")]
        [JsonProperty("cooling_outdoor_air_flow_rate")]
        public string CoolingOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("If this field is set to autosize it will be sized based on the outdoor air inputs" +
                     " below, unless a dedicated outdoor air system is specified for this zone and the" +
                     "n it will be set to zero.")]
        [JsonProperty("heating_outdoor_air_flow_rate")]
        public string HeatingOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("If this field is set to autosize it will be sized based on the outdoor air inputs" +
                     " below, unless a dedicated outdoor air system is specified for this zone and the" +
                     "n it will be set to zero.")]
        [JsonProperty("no_load_outdoor_air_flow_rate")]
        public string NoLoadOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
        [JsonProperty("outdoor_air_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VRF_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_VRF_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_VRF_OutdoorAirMethod), "Empty");
        

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
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty("design_specification_outdoor_air_object_name")]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty("design_specification_zone_air_distribution_object_name")]
        public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

        [Description("If blank, always on")]
        [JsonProperty("system_availability_schedule_name")]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
                     "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
                     "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
                     "e used.")]
        [JsonProperty("supply_fan_operating_mode_schedule_name")]
        public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

        [Description("Select fan placement as either blow through or draw through.")]
        [JsonProperty("supply_air_fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VRF_SupplyAirFanPlacement SupplyAirFanPlacement { get; set; } = (HVACTemplate_Zone_VRF_SupplyAirFanPlacement)Enum.Parse(typeof(HVACTemplate_Zone_VRF_SupplyAirFanPlacement), "BlowThrough");
        

        [JsonProperty("supply_fan_total_efficiency")]
        public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_delta_pressure")]
        public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("75", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_efficiency")]
        public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VRF_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_Zone_VRF_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_VRF_CoolingCoilType), "VariableRefrigerantFlowDX");
        

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
        

        [JsonProperty("heat_pump_heating_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VRF_HeatPumpHeatingCoilType HeatPumpHeatingCoilType { get; set; } = (HVACTemplate_Zone_VRF_HeatPumpHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_VRF_HeatPumpHeatingCoilType), "VariableRefrigerantFlowDX");
        

        [Description("If blank, always on")]
        [JsonProperty("heat_pump_heating_coil_availability_schedule_name")]
        public string HeatPumpHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Capacity excluding supply air fan heat Rating point outdoor dry-bulb temp 8.33 C," +
                     " outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21" +
                     ".11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty("heat_pump_heating_coil_gross_rated_capacity")]
        public string HeatPumpHeatingCoilGrossRatedCapacity { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("zone_terminal_unit_on_parasitic_electric_energy_use")]
        public System.Nullable<float> ZoneTerminalUnitOnParasiticElectricEnergyUse { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("zone_terminal_unit_off_parasitic_electric_energy_use")]
        public System.Nullable<float> ZoneTerminalUnitOffParasiticElectricEnergyUse { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

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
        public HVACTemplate_Zone_VRF_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VRF_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VRF_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

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
        public HVACTemplate_Zone_VRF_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VRF_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VRF_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

        [Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty("zone_heating_design_supply_air_temperature")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
        [JsonProperty("zone_heating_design_supply_air_temperature_difference")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [JsonProperty("baseboard_heating_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VRF_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_VRF_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_VRF_BaseboardHeatingType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty("baseboard_heating_availability_schedule_name")]
        public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("baseboard_heating_capacity")]
        public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
    }
}