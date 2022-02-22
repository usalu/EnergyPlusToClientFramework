using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("If you use a ZoneList in the Zone or ZoneList name field then this definition app" +
                 "lies to all the zones in the ZoneList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneControl_Thermostat_ThermalComfort : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("zone_or_zonelist_name")]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [Description("The method used to calculate thermal comfort dry-bulb temperature setpoint for mu" +
                     "ltiple people objects in a zone")]
        [JsonProperty("averaging_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneControl_Thermostat_ThermalComfort_AveragingMethod AveragingMethod { get; set; } = (ZoneControl_Thermostat_ThermalComfort_AveragingMethod)Enum.Parse(typeof(ZoneControl_Thermostat_ThermalComfort_AveragingMethod), "PeopleAverage");
        

        [Description("Used only when Averaging Method = SpecificObject in the previous field.")]
        [JsonProperty("specific_people_name")]
        public string SpecificPeopleName { get; set; } = "";
        

        [JsonProperty("minimum_dry_bulb_temperature_setpoint")]
        public System.Nullable<float> MinimumDryBulbTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_dry_bulb_temperature_setpoint")]
        public System.Nullable<float> MaximumDryBulbTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description(@"The Thermal Comfort Control Type Schedule contains values that are appropriate control types. Thermal Comfort Control types are integers: 0 - Uncontrolled (floating), 1 = ThermostatSetpoint:ThermalComfort:Fanger:SingleHeating 2 = ThermostatSetpoint:ThermalComfort:Fanger:SingleCooling 3 = ThermostatSetpoint:ThermalComfort:Fanger:SingleHeatingOrCooling 4 = ThermostatSetpoint:ThermalComfort:Fanger:DualSetpoint")]
        [JsonProperty("thermal_comfort_control_type_schedule_name")]
        public string ThermalComfortControlTypeScheduleName { get; set; } = "";
        

        [JsonProperty("thermal_comfort_control_1_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl1ObjectType ThermalComfortControl1ObjectType { get; set; } = (ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl1ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl1ObjectType), "ThermostatSetpointThermalComfortFangerDualSetpoint");
        

        [Description("Control type names are names for individual control type objects. Schedule values" +
                     " in these objects list actual setpoint temperatures for the control types")]
        [JsonProperty("thermal_comfort_control_1_name")]
        public string ThermalComfortControl1Name { get; set; } = "";
        

        [JsonProperty("thermal_comfort_control_2_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl2ObjectType ThermalComfortControl2ObjectType { get; set; } = (ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl2ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl2ObjectType), "ThermostatSetpointThermalComfortFangerDualSetpoint");
        

        [Description("Control Type names are names for individual control type objects. Schedule values" +
                     " in these objects list actual setpoint temperatures for the control types")]
        [JsonProperty("thermal_comfort_control_2_name")]
        public string ThermalComfortControl2Name { get; set; } = "";
        

        [JsonProperty("thermal_comfort_control_3_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl3ObjectType ThermalComfortControl3ObjectType { get; set; } = (ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl3ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl3ObjectType), "ThermostatSetpointThermalComfortFangerDualSetpoint");
        

        [Description("Control type names are names for individual control type objects. Schedule values" +
                     " in these objects list actual setpoint temperatures for the control types")]
        [JsonProperty("thermal_comfort_control_3_name")]
        public string ThermalComfortControl3Name { get; set; } = "";
        

        [JsonProperty("thermal_comfort_control_4_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl4ObjectType ThermalComfortControl4ObjectType { get; set; } = (ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl4ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl4ObjectType), "ThermostatSetpointThermalComfortFangerDualSetpoint");
        

        [Description("Control type names are names for individual control type objects. Schedule values" +
                     " in these objects list actual setpoint temperatures for the control types")]
        [JsonProperty("thermal_comfort_control_4_name")]
        public string ThermalComfortControl4Name { get; set; } = "";
    }
}