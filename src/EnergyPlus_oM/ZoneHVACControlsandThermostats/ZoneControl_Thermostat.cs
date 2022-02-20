using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Define the Thermostat settings for a zone or list of zones. If you use a ZoneList" +
                 " in the Zone or ZoneList name field then this definition applies to all the zone" +
                 "s in the ZoneList.")]
    [JsonObject("ZoneControl:Thermostat")]
    public class ZoneControl_Thermostat : BHoMObject
    {
        

        [JsonProperty("zone_or_zonelist_name")]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [Description(@"This schedule contains appropriate control types for thermostat. Control types are integers: 0 - Uncontrolled (floating, no thermostat), 1 = ThermostatSetpoint:SingleHeating, 2 = ThermostatSetpoint:SingleCooling, 3 = ThermostatSetpoint:SingleHeatingOrCooling, 4 = ThermostatSetpoint:DualSetpoint")]
        [JsonProperty("control_type_schedule_name")]
        public string ControlTypeScheduleName { get; set; } = "";
        

        [JsonProperty("control_1_object_type")]
        public EmptyNoYes Control1ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Control names are names of individual control objects (e.g. ThermostatSetpoint:Si" +
                     "ngleHeating) Schedule values in these objects list actual setpoint temperatures " +
                     "for the control types")]
        [JsonProperty("control_1_name")]
        public string Control1Name { get; set; } = "";
        

        [JsonProperty("control_2_object_type")]
        public EmptyNoYes Control2ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Control names are names of individual control objects (e.g. ThermostatSetpoint:Si" +
                     "ngleHeating) Schedule values in these objects list actual setpoint temperatures " +
                     "for the control types")]
        [JsonProperty("control_2_name")]
        public string Control2Name { get; set; } = "";
        

        [JsonProperty("control_3_object_type")]
        public EmptyNoYes Control3ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Control names are names of individual control objects (e.g. ThermostatSetpoint:Si" +
                     "ngleHeating) Schedule values in these objects list actual setpoint temperatures " +
                     "for the control types")]
        [JsonProperty("control_3_name")]
        public string Control3Name { get; set; } = "";
        

        [JsonProperty("control_4_object_type")]
        public EmptyNoYes Control4ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Control names are names of individual control objects (e.g. ThermostatSetpoint:Si" +
                     "ngleHeating) Schedule values in these objects list actual setpoint temperatures " +
                     "for the control types")]
        [JsonProperty("control_4_name")]
        public string Control4Name { get; set; } = "";
        

        [Description("This optional choice field provides a temperature difference between cut-out temp" +
                     "erature and setpoint. The difference is used to adjust to heating or cooling set" +
                     "point based on control types.")]
        [JsonProperty("temperature_difference_between_cutout_and_setpoint")]
        public System.Nullable<float> TemperatureDifferenceBetweenCutoutAndSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}