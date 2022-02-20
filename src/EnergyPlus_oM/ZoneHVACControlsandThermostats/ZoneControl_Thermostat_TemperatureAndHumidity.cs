using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("This object modifies a ZoneControl:Thermostat object to effect temperature contro" +
                 "l based on zone air humidity conditions.")]
    [JsonObject("ZoneControl:Thermostat:TemperatureAndHumidity")]
    public class ZoneControl_Thermostat_TemperatureAndHumidity : BHoMObject
    {
        

        [Description(@"Enter the name of a ZoneControl:Thermostat object whose operation is to be modified to effect temperature control based on zone air humidity conditions. If the ZoneControl: Thermostat object references a ZoneList, simply enter the name of the ZoneControl:Thermostat object and this temperature and humidity thermostat control will be applied to all zones in the ZoneList. If the ZoneControl:Thermostat object references a ZoneList but it is desired that only a single zone within the ZoneList be controlled based on temperature and humidity control, then the name to be put here is <Zone Name> <Thermostat Name> where the Thermostat Name is the the name of the ZoneControl:Thermostat object.")]
        [JsonProperty("thermostat_name")]
        public string ThermostatName { get; set; } = "";
        

        [Description("Schedule values should be in Relative Humidity (percent)")]
        [JsonProperty("dehumidifying_relative_humidity_setpoint_schedule_name")]
        public string DehumidifyingRelativeHumiditySetpointScheduleName { get; set; } = "";
        

        [JsonProperty("dehumidification_control_type")]
        public EmptyNoYes DehumidificationControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Overcool");
        

        [JsonProperty("overcool_range_input_method")]
        public EmptyNoYes OvercoolRangeInputMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Constant");
        

        [Description("Maximum Overcool temperature range for cooling setpoint reduction. Used with Dehu" +
                     "midification Control Type = Overcool. A value of 0.0 indicates no zone temperatu" +
                     "re overcooling will be provided to gain additional dehumidification.")]
        [JsonProperty("overcool_constant_range")]
        public System.Nullable<float> OvercoolConstantRange { get; set; } = (System.Nullable<float>)Single.Parse("1.7", CultureInfo.InvariantCulture);
        

        [Description("Schedule values of 0.0 indicates no zone temperature overcooling will be provided" +
                     " to gain additional dehumidification. Schedule values should be >= 0 and <= 3 (d" +
                     "eltaC).")]
        [JsonProperty("overcool_range_schedule_name")]
        public string OvercoolRangeScheduleName { get; set; } = "";
        

        [Description(@"The value of this input field is used to adjust the cooling setpoint temperature (established by the associated ZoneControl:Thermostat object) downward based on the difference between the zone air relative humidity level and the dehumidifying relative humidity setpoint.")]
        [JsonProperty("overcool_control_ratio")]
        public System.Nullable<float> OvercoolControlRatio { get; set; } = (System.Nullable<float>)Single.Parse("3.6", CultureInfo.InvariantCulture);
    }
}