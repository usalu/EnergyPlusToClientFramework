using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Zone baseboard heating system.")]
    public class HVACTemplate_Zone_BaseboardHeat : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Zone name must match a building zone name")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
                     "that standard thermostat objects have been defined for this zone.")]
        [JsonProperty("template_thermostat_name")]
        public string TemplateThermostatName { get; set; } = "";
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty("zone_heating_sizing_factor")]
        public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

        [JsonProperty("baseboard_heating_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_BaseboardHeat_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_BaseboardHeat_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_BaseboardHeat_BaseboardHeatingType), "HotWater");
        

        [Description("If blank, always on")]
        [JsonProperty("baseboard_heating_availability_schedule_name")]
        public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("baseboard_heating_capacity")]
        public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this zone " +
                     "is served by a separate dedicated outdoor air system (DOAS). Leave field blank i" +
                     "f no DOAS serves this zone.")]
        [JsonProperty("dedicated_outdoor_air_system_name")]
        public string DedicatedOutdoorAirSystemName { get; set; } = "";
        

        [Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
        [JsonProperty("outdoor_air_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_BaseboardHeat_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_BaseboardHeat_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_BaseboardHeat_OutdoorAirMethod), "Empty");
        

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
    }
}