using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Zone terminal unit, fan powered variable volume, reheat optional. Referenced sche" +
                 "dules must be defined elsewhere in the idf.")]
    [JsonObject("HVACTemplate:Zone:VAV:FanPowered")]
    public class HVACTemplate_Zone_VAV_FanPowered : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Zone Name must match a building zone name")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Enter the name of a HVACTemplate:System:VAV or HVACTemplate:System:PackagedVAV ob" +
                     "ject serving this zone.")]
        [JsonProperty("template_vav_system_name")]
        public string TemplateVavSystemName { get; set; } = "";
        

        [Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
                     "that standard thermostat objects have been defined for this zone.")]
        [JsonProperty("template_thermostat_name")]
        public string TemplateThermostatName { get; set; } = "";
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
                     " by the Supply Air Sizing Factor and by zone multipliers.")]
        [JsonProperty("primary_supply_air_maximum_flow_rate")]
        public string PrimarySupplyAirMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty("zone_heating_sizing_factor")]
        public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty("zone_cooling_sizing_factor")]
        public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

        [JsonProperty("primary_supply_air_minimum_flow_fraction")]
        public string PrimarySupplyAirMinimumFlowFraction { get; set; } = (System.String)"Autosize";
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
                     " by the Supply Air Sizing Factor and by zone multipliers.")]
        [JsonProperty("secondary_supply_air_maximum_flow_rate")]
        public string SecondarySupplyAirMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("flow_type")]
        public HVACTemplate_Zone_VAV_FanPowered_FlowType FlowType { get; set; } = (HVACTemplate_Zone_VAV_FanPowered_FlowType)Enum.Parse(typeof(HVACTemplate_Zone_VAV_FanPowered_FlowType), "Parallel");
        

        [Description("The fraction of the primary air flow at which fan turns on Applicable only to Par" +
                     "allel Flow Type")]
        [JsonProperty("parallel_fan_on_flow_fraction")]
        public string ParallelFanOnFlowFraction { get; set; } = (System.String)"Autosize";
        

        [Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
        [JsonProperty("outdoor_air_method")]
        public HVACTemplate_Zone_VAV_FanPowered_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_VAV_FanPowered_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_FanPowered_OutdoorAirMethod), "Empty");
        

        [Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
                     "Method is Flow/Person, Sum, or Maximum")]
        [JsonProperty("outdoor_air_flow_rate_per_person")]
        public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

        [Description("This input is used if the field Outdoor Air Method is Flow/area, Sum, or Maximum")]
        [JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
        public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
        [JsonProperty("outdoor_air_flow_rate_per_zone")]
        public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("reheat_coil_type")]
        public HVACTemplate_Zone_VAV_FanPowered_ReheatCoilType ReheatCoilType { get; set; } = (HVACTemplate_Zone_VAV_FanPowered_ReheatCoilType)Enum.Parse(typeof(HVACTemplate_Zone_VAV_FanPowered_ReheatCoilType), "Electric");
        

        [Description("If blank, always on")]
        [JsonProperty("reheat_coil_availability_schedule_name")]
        public string ReheatCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("fan_total_efficiency")]
        public System.Nullable<float> FanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("fan_delta_pressure")]
        public System.Nullable<float> FanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

        [JsonProperty("fan_motor_efficiency")]
        public System.Nullable<float> FanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Plenum zone name. Supply plenum runs through only this zone. Blank if none.")]
        [JsonProperty("supply_plenum_name")]
        public string SupplyPlenumName { get; set; } = "";
        

        [Description("Plenum zone name. Return plenum runs through only this zone. Blank if none.")]
        [JsonProperty("return_plenum_name")]
        public string ReturnPlenumName { get; set; } = "";
        

        [JsonProperty("baseboard_heating_type")]
        public HVACTemplate_Zone_VAV_FanPowered_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_VAV_FanPowered_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_VAV_FanPowered_BaseboardHeatingType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty("baseboard_heating_availability_schedule_name")]
        public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("baseboard_heating_capacity")]
        public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
        

        [Description(@"SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperature TemperatureDifference = use the value from Zone Cooling Design Supply Air Temperature Difference SystemSupplyAirTemperature = use the value from HVACTemplate:System:VAV Cooling Coil Design Setpoint")]
        [JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
        public HVACTemplate_Zone_VAV_FanPowered_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VAV_FanPowered_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_FanPowered_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SystemSupplyAirTemperature");
        

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
        public HVACTemplate_Zone_VAV_FanPowered_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VAV_FanPowered_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_FanPowered_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

        [Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty("zone_heating_design_supply_air_temperature")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
        [JsonProperty("zone_heating_design_supply_air_temperature_difference")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [Description(@"This is the operating schedule for the zone PIU fan. For a parallel PIU, the fan operates only when the primary air flow is below the Parallel Fan On Flow Fraction and the Zone PIU Fan Schedule is on, or it is activated by an availability manager. For a series PIU, the zone fan operates whenever the Zone PIU Fan Schedule is on, or it is activated by an availability manager. If this field is left blank, the System Availability Schedule for the HVACTemplate:System serving this zone will be used.")]
        [JsonProperty("zone_piu_fan_schedule_name")]
        public string ZonePiuFanScheduleName { get; set; } = "";
        

        [JsonProperty("design_specification_outdoor_air_object_name")]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [JsonProperty("design_specification_zone_air_distribution_object_name")]
        public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
    }
}