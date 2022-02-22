using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Zone terminal unit, variable volume, reheat optional. For heating, this unit acti" +
                 "vates reheat coil first, then increases airflow (if reverse action specified).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_Zone_VAV : BHoMObject
    {
        

        [Description("Zone name must match a building zone name")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Name of a HVACTemplate:System:VAV or HVACTemplate:System:PackagedVAV object servi" +
                     "ng this zone")]
        [JsonProperty("template_vav_system_name")]
        public string TemplateVavSystemName { get; set; } = "";
        

        [Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
                     "that standard thermostat objects have been defined for this zone.")]
        [JsonProperty("template_thermostat_name")]
        public string TemplateThermostatName { get; set; } = "";
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
                     " by the Supply Air Sizing Factor and by zone multipliers.")]
        [JsonProperty("supply_air_maximum_flow_rate")]
        public string SupplyAirMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty("zone_heating_sizing_factor")]
        public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty("zone_cooling_sizing_factor")]
        public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

        [Description("Constant = Constant Minimum Air Flow Fraction (a fraction of Maximum Air Flow Rat" +
                     "e) FixedFlowRate = Fixed Minimum Air Flow Rate (a fixed minimum air volume flow " +
                     "rate) Scheduled = Scheduled Minimum Air Flow Fraction (a fraction of Maximum Air" +
                     " Flow")]
        [JsonProperty("zone_minimum_air_flow_input_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VAV_ZoneMinimumAirFlowInputMethod ZoneMinimumAirFlowInputMethod { get; set; } = (HVACTemplate_Zone_VAV_ZoneMinimumAirFlowInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_ZoneMinimumAirFlowInputMethod), "Constant");
        

        [Description(@"This field is used if the field Zone Minimum Air Flow Input Method is Constant If the field Zone Minimum Air Flow Input Method is Scheduled, then this field is optional. If a value is entered, then it is used for sizing normal-action reheat coils. If both this field and the following field are entered, the larger result is used.")]
        [JsonProperty("constant_minimum_air_flow_fraction")]
        public System.Nullable<float> ConstantMinimumAirFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description(@"This field is used if the field Zone Minimum Air Flow Input Method is FixedFlowRate. If the field Zone Minimum Air Flow Input Method is Scheduled, then this field is optional. If a value is entered, then it is used for sizing normal-action reheat coils. If both this field and the previous field are entered, the larger result is used.")]
        [JsonProperty("fixed_minimum_air_flow_rate")]
        public System.Nullable<float> FixedMinimumAirFlowRate { get; set; } = null;
        

        [Description(@"This field is used if the field Zone Minimum Air Flow Input Method is Scheduled Schedule values are fractions, 0.0 to 1.0. If the field Constant Minimum Air Flow Fraction is blank, then the average of the minimum and maximum schedule values is used for sizing normal-action reheat coils.")]
        [JsonProperty("minimum_air_flow_fraction_schedule_name")]
        public string MinimumAirFlowFractionScheduleName { get; set; } = "";
        

        [Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
        [JsonProperty("outdoor_air_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VAV_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_VAV_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_OutdoorAirMethod), "Empty");
        

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
        

        [JsonProperty("reheat_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VAV_ReheatCoilType ReheatCoilType { get; set; } = (HVACTemplate_Zone_VAV_ReheatCoilType)Enum.Parse(typeof(HVACTemplate_Zone_VAV_ReheatCoilType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty("reheat_coil_availability_schedule_name")]
        public string ReheatCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("damper_heating_action")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VAV_DamperHeatingAction DamperHeatingAction { get; set; } = (HVACTemplate_Zone_VAV_DamperHeatingAction)Enum.Parse(typeof(HVACTemplate_Zone_VAV_DamperHeatingAction), "Reverse");
        

        [Description(@"Used only when Reheat Coil Object Type = Coil:Heating:Water and Damper Heating Action = Reverse When autocalculating, the maximum flow per zone is set to 0.002032 m3/s-m2 (0.4 cfm/sqft) This optional field limits the maximum flow allowed in reheat mode. If this field and the following field are left blank, the maximum flow will not be limited. At no time will the maximum flow rate calculated here exceed the value of Maximum Air Flow Rate.")]
        [JsonProperty("maximum_flow_per_zone_floor_area_during_reheat")]
        public string MaximumFlowPerZoneFloorAreaDuringReheat { get; set; } = "";
        

        [Description(@"Used only when Reheat Coil Object Type = Coil:Heating:Water and Damper Heating Action = Reverse When autocalculating, the maximum flow fraction is set to the ratio of 0.002032 m3/s-m2 (0.4 cfm/sqft) multiplied by the zone floor area and the Maximum Air Flow Rate. This optional field limits the maximum flow allowed in reheat mode. If this field and the previous field are left blank, the maximum flow will not be limited. At no time will the maximum flow rate calculated here exceed the value of Maximum Air Flow Rate.")]
        [JsonProperty("maximum_flow_fraction_during_reheat")]
        public string MaximumFlowFractionDuringReheat { get; set; } = "";
        

        [Description("Specifies the maximum allowable supply air temperature leaving the reheat coil. I" +
                     "f left blank, there is no limit and no default. If unknown, 35C (95F) is recomme" +
                     "nded.")]
        [JsonProperty("maximum_reheat_air_temperature")]
        public System.Nullable<float> MaximumReheatAirTemperature { get; set; } = null;
        

        [Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will increase flow as needed to meet this outdoor air requirement. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based on the current number of occupants in the zone. At no time will the supply air flow rate exceed the value for Maximum Air Flow Rate. If this field is blank, then the terminal unit will not be controlled for outdoor air flow. Note that this field is used only for specifying the design outdoor air flow rate used for control. The field Design Specification Outdoor Air Object Name for Sizing (see below) is used to specify the design outdoor air flow rate.")]
        [JsonProperty("design_specification_outdoor_air_object_name_for_control")]
        public string DesignSpecificationOutdoorAirObjectNameForControl { get; set; } = "";
        

        [Description("Plenum zone name. Supply plenum runs through only this zone. Blank if none.")]
        [JsonProperty("supply_plenum_name")]
        public string SupplyPlenumName { get; set; } = "";
        

        [Description("Plenum zone name. Return plenum runs through only this zone. Blank if none.")]
        [JsonProperty("return_plenum_name")]
        public string ReturnPlenumName { get; set; } = "";
        

        [JsonProperty("baseboard_heating_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VAV_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_VAV_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_VAV_BaseboardHeatingType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty("baseboard_heating_availability_schedule_name")]
        public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("baseboard_heating_capacity")]
        public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
        

        [Description(@"SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperature TemperatureDifference = use the value from Zone Cooling Design Supply Air Temperature Difference SystemSupplyAirTemperature = use the value from HVACTemplate:System:VAV Cooling Coil Design Setpoint")]
        [JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VAV_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VAV_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SystemSupplyAirTemperature");
        

        [Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty("zone_cooling_design_supply_air_temperature")]
        public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

        [Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
        [JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
        public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

        [Description("SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperat" +
                     "ure TemperatureDifference = use the value from Zone Heating Design Supply Air Te" +
                     "mperature Difference")]
        [JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VAV_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VAV_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

        [Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty("zone_heating_design_supply_air_temperature")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
        [JsonProperty("zone_heating_design_supply_air_temperature_difference")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [Description(@"This field is used only when Outdoor Air Method=DetailedSpecification. Note that this field is used only for specifying the design outdoor air flow rate used for sizing. The field Design Specification Outdoor Air Object Name for Control (see above) is used to actively control the VAV terminal air flow rate.")]
        [JsonProperty("design_specification_outdoor_air_object_name_for_sizing")]
        public string DesignSpecificationOutdoorAirObjectNameForSizing { get; set; } = "";
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty("design_specification_zone_air_distribution_object_name")]
        public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
    }
}