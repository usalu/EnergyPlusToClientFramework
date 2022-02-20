using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("4 pipe fan coil unit with optional outdoor air.")]
    [JsonObject("HVACTemplate:Zone:FanCoil")]
    public class HVACTemplate_Zone_FanCoil : BHoMObject
    {
        

        [Description("Zone name must match a building zone name")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

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
        

        [Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
        [JsonProperty("outdoor_air_method")]
        public EmptyNoYes OutdoorAirMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Flow/Person");
        

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
        

        [JsonProperty("supply_fan_total_efficiency")]
        public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_delta_pressure")]
        public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("75", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_efficiency")]
        public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_in_air_stream_fraction")]
        public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_coil_type")]
        public EmptyNoYes CoolingCoilType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ChilledWater");
        

        [Description("If blank, always on")]
        [JsonProperty("cooling_coil_availability_schedule_name")]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Used for sizing when Zone Cooling Design Supply Air Temperature Input Method = Su" +
                     "pplyAirTemperature")]
        [JsonProperty("cooling_coil_design_setpoint")]
        public System.Nullable<float> CoolingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("14", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_coil_type")]
        public EmptyNoYes HeatingCoilType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "HotWater");
        

        [Description("If blank, always on")]
        [JsonProperty("heating_coil_availability_schedule_name")]
        public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Used for sizing when Zone Heating Design Supply Air Temperature Input Method = Su" +
                     "pplyAirTemperature")]
        [JsonProperty("heating_coil_design_setpoint")]
        public System.Nullable<float> HeatingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this zone " +
                     "is served by a separate dedicated outdoor air system (DOAS). Leave field blank i" +
                     "f no DOAS serves this zone.")]
        [JsonProperty("dedicated_outdoor_air_system_name")]
        public string DedicatedOutdoorAirSystemName { get; set; } = "";
        

        [Description("SupplyAirTemperature = use the value from Cooling Coil Design Setpoint (above) Te" +
                     "mperatureDifference = use the value from Zone Cooling Design Supply Air Temperat" +
                     "ure Difference")]
        [JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
        public EmptyNoYes ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "SupplyAirTemperature");
        

        [Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
        [JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
        public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

        [Description("SupplyAirTemperature = use the value from Heating Coil Design Setpoint (above) Te" +
                     "mperatureDifference = use the value from Zone Heating Design Supply Air Temperat" +
                     "ure Difference")]
        [JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
        public EmptyNoYes ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "SupplyAirTemperature");
        

        [Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
        [JsonProperty("zone_heating_design_supply_air_temperature_difference")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty("design_specification_outdoor_air_object_name")]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty("design_specification_zone_air_distribution_object_name")]
        public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

        [Description("If this field is left blank, it will default to CyclingFan if a Dedicated Outdoor" +
                     " Air System is specified (see above), otherwise it will default to ConstantFanVa" +
                     "riableFlow.")]
        [JsonProperty("capacity_control_method")]
        public EmptyNoYes CapacityControlMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("low_speed_supply_air_flow_ratio")]
        public System.Nullable<float> LowSpeedSupplyAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.33", CultureInfo.InvariantCulture);
        

        [Description("Medium Speed Supply Air Flow Ratio should be greater than Low Speed Supply Air Fl" +
                     "ow Ratio")]
        [JsonProperty("medium_speed_supply_air_flow_ratio")]
        public System.Nullable<float> MediumSpeedSupplyAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.66", CultureInfo.InvariantCulture);
        

        [Description("Value of schedule multiplies maximum outdoor air flow rate This schedule is ignor" +
                     "ed if this zone is served by an HVACTemplate dedicated outdoor air system.")]
        [JsonProperty("outdoor_air_schedule_name")]
        public string OutdoorAirScheduleName { get; set; } = "";
        

        [JsonProperty("baseboard_heating_type")]
        public EmptyNoYes BaseboardHeatingType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
        

        [Description("If blank, always on")]
        [JsonProperty("baseboard_heating_availability_schedule_name")]
        public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("baseboard_heating_capacity")]
        public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
    }
}