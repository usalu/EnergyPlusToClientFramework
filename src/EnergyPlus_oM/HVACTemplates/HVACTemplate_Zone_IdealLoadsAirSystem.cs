using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Zone with ideal air system that meets heating or cooling loads")]
    [JsonObject("HVACTemplate:Zone:IdealLoadsAirSystem")]
    public class HVACTemplate_Zone_IdealLoadsAirSystem : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Zone name must match a building zone name")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
                     "that standard thermostat objects have been defined for this zone.")]
        [JsonProperty("template_thermostat_name")]
        public string TemplateThermostatName { get; set; } = "";
        

        [Description("If blank, always on")]
        [JsonProperty("system_availability_schedule_name")]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("maximum_heating_supply_air_temperature")]
        public System.Nullable<float> MaximumHeatingSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [JsonProperty("minimum_cooling_supply_air_temperature")]
        public System.Nullable<float> MinimumCoolingSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_heating_supply_air_humidity_ratio")]
        public System.Nullable<float> MaximumHeatingSupplyAirHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.0156", CultureInfo.InvariantCulture);
        

        [JsonProperty("minimum_cooling_supply_air_humidity_ratio")]
        public System.Nullable<float> MinimumCoolingSupplyAirHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.0077", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_limit")]
        public HVACTemplate_Zone_IdealLoadsAirSystem_HeatingLimit HeatingLimit { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_HeatingLimit)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_HeatingLimit), "NoLimit");
        

        [Description("This field is ignored if Heating Limit = NoLimit If this field is blank, there is" +
                     " no limit.")]
        [JsonProperty("maximum_heating_air_flow_rate")]
        public string MaximumHeatingAirFlowRate { get; set; } = "";
        

        [Description("This field is ignored if Heating Limit = NoLimit If this field is blank, there is" +
                     " no limit.")]
        [JsonProperty("maximum_sensible_heating_capacity")]
        public string MaximumSensibleHeatingCapacity { get; set; } = "";
        

        [JsonProperty("cooling_limit")]
        public HVACTemplate_Zone_IdealLoadsAirSystem_CoolingLimit CoolingLimit { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_CoolingLimit)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_CoolingLimit), "NoLimit");
        

        [Description("This field is ignored if Cooling Limit = NoLimit This field is required if Outdoo" +
                     "r Air Economizer Type is anything other than NoEconomizer.")]
        [JsonProperty("maximum_cooling_air_flow_rate")]
        public string MaximumCoolingAirFlowRate { get; set; } = "";
        

        [Description("This field is ignored if Cooling Limit = NoLimit")]
        [JsonProperty("maximum_total_cooling_capacity")]
        public string MaximumTotalCoolingCapacity { get; set; } = "";
        

        [Description("If blank, heating is always available.")]
        [JsonProperty("heating_availability_schedule_name")]
        public string HeatingAvailabilityScheduleName { get; set; } = "";
        

        [Description("If blank, cooling is always available.")]
        [JsonProperty("cooling_availability_schedule_name")]
        public string CoolingAvailabilityScheduleName { get; set; } = "";
        

        [Description(@"ConstantSensibleHeatRatio means that the ideal loads system will be controlled to meet the sensible cooling load, and the latent cooling rate will be computed using a constant sensible heat ratio (SHR) Humidistat means that there is a ZoneControl:Humidistat for this zone and the ideal loads system will attempt to satisfy the humidistat. None means that there is no dehumidification. ConstantSupplyHumidityRatio means that during cooling the supply air will always be at the Minimum Cooling Supply Humidity Ratio.")]
        [JsonProperty("dehumidification_control_type")]
        public HVACTemplate_Zone_IdealLoadsAirSystem_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_DehumidificationControlType), "ConstantSensibleHeatRatio");
        

        [Description("This field is applicable only when Dehumidification Control Type is ConstantSensi" +
                     "bleHeatRatio")]
        [JsonProperty("cooling_sensible_heat_ratio")]
        public System.Nullable<float> CoolingSensibleHeatRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Zone relative humidity setpoint in percent (0 to 100)")]
        [JsonProperty("dehumidification_setpoint")]
        public System.Nullable<float> DehumidificationSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

        [Description(@"None means that there is no humidification. Humidistat means that there is a ZoneControl:Humidistat for this zone and the ideal loads system will attempt to satisfy the humidistat. ConstantSupplyHumidityRatio means that during heating the supply air will always be at the Maximum Heating Supply Humidity Ratio.")]
        [JsonProperty("humidification_control_type")]
        public HVACTemplate_Zone_IdealLoadsAirSystem_HumidificationControlType HumidificationControlType { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_HumidificationControlType)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_HumidificationControlType), "None");
        

        [Description("Zone relative humidity setpoint in percent (0 to 100)")]
        [JsonProperty("humidification_setpoint")]
        public System.Nullable<float> HumidificationSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [Description(@"None means there is no outdoor air and all related fields will be ignored Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
        [JsonProperty("outdoor_air_method")]
        public HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirMethod), "None");
        

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
        

        [Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the minimum outdoor air flow rate will be computed using these specifications. The outdoor air flow rate will also be affected by the next two fields. If this field is blank, there will be no outdoor air and the remaining fields will be ignored.")]
        [JsonProperty("design_specification_outdoor_air_object_name")]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description(@"This field controls how the minimum outdoor air flow rate is calculated. None means that design occupancy will be used to compute the minimum outdoor air flow rate OccupancySchedule means that current occupancy level will be used. CO2Setpoint means that the design occupancy will be used to compute the minimum outdoor air flow rate and the outdoor air flow rate may be increased if necessary to maintain the indoor air carbon dioxide setpoint defined in a ZoneControl:ContaminantController object.")]
        [JsonProperty("demand_controlled_ventilation_type")]
        public HVACTemplate_Zone_IdealLoadsAirSystem_DemandControlledVentilationType DemandControlledVentilationType { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_DemandControlledVentilationType)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_DemandControlledVentilationType), "None");
        

        [Description("DifferentialDryBulb and DifferentialEnthalpy will increase the outdoor air flow r" +
                     "ate when there is a cooling load and the outdoor air temperature or enthalpy is " +
                     "below the zone exhaust air temperature or enthalpy.")]
        [JsonProperty("outdoor_air_economizer_type")]
        public HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirEconomizerType OutdoorAirEconomizerType { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirEconomizerType)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirEconomizerType), "NoEconomizer");
        

        [JsonProperty("heat_recovery_type")]
        public HVACTemplate_Zone_IdealLoadsAirSystem_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_HeatRecoveryType), "None");
        

        [JsonProperty("sensible_heat_recovery_effectiveness")]
        public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Heat Recovery Type is Enthalpy.")]
        [JsonProperty("latent_heat_recovery_effectiveness")]
        public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
    }
}