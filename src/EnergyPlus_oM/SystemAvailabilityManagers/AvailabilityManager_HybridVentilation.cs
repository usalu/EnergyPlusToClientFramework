using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description(@"Depending on zone and outdoor conditions overrides window/door opening controls to maximize natural ventilation and turn off an HVAC system when ventilation control conditions are met. This object (zone ventilation object name) has not been instrumented to work with global Zone or Zone List names option for Ventilation:DesignFlowRate. In order to use, you must enter the single <Ventilation:DesignFlowRate> name in that field. If it is a part of a global ventilation assignment the name will be <Zone Name> <global Ventilation:DesignFlowRate> name. Currently, hybrid ventilation manager is restricted to one per zone. It can either be applied through the air loop or directly to the zone. If hybrid ventilation manager is applied to an air loop and one of the zones served by that air loop also has hybrid ventilation manager, then zone hybrid ventilation manager is disabled.")]
    [JsonObject("AvailabilityManager:HybridVentilation")]
    public class AvailabilityManager_HybridVentilation : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the name of an AirLoopHVAC or HVACTemplate:System:* object. If this field i" +
                     "s left blank, hybrid ventilation managers will be simulated for zone equipment c" +
                     "ontrol")]
        [JsonProperty("hvac_air_loop_name")]
        public string HvacAirLoopName { get; set; } = "";
        

        [Description("the zone name should be a zone where a thermostat or humidistat is located served" +
                     " by an air primary loop.")]
        [JsonProperty("control_zone_name")]
        public string ControlZoneName { get; set; } = "";
        

        [Description(@"The Ventilation control mode contains appropriate integer control types. 0 - uncontrolled (Natural ventilation and HVAC system are controlled by themselves) 1 = Temperature control 2 = Enthalpy control 3 = Dewpoint control 4 = Outdoor ventilation air control 5 = Operative temperature control with 80% adaptive comfort acceptability limits 6 = Operative temperature control with 90% adaptive comfort acceptability limits 7 = Carbon dioxide control")]
        [JsonProperty("ventilation_control_mode_schedule_name")]
        public string VentilationControlModeScheduleName { get; set; } = "";
        

        [Description("If Yes, ventilation is shutoff when there is rain If No, there is no rain control" +
                     "")]
        [JsonProperty("use_weather_file_rain_indicators")]
        public EmptyNoYes UseWeatherFileRainIndicators { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("this is the wind speed above which ventilation is shutoff")]
        [JsonProperty("maximum_wind_speed")]
        public System.Nullable<float> MaximumWindSpeed { get; set; } = (System.Nullable<float>)Single.Parse("40", CultureInfo.InvariantCulture);
        

        [Description("this is the outdoor temperature below which ventilation is shutoff")]
        [JsonProperty("minimum_outdoor_temperature")]
        public System.Nullable<float> MinimumOutdoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("this is the outdoor temperature above which ventilation is shutoff")]
        [JsonProperty("maximum_outdoor_temperature")]
        public System.Nullable<float> MaximumOutdoorTemperature { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

        [Description("this is the outdoor Enthalpy below which ventilation is shutoff")]
        [JsonProperty("minimum_outdoor_enthalpy")]
        public System.Nullable<float> MinimumOutdoorEnthalpy { get; set; } = null;
        

        [Description("this is the outdoor Enthalpy above which ventilation is shutoff")]
        [JsonProperty("maximum_outdoor_enthalpy")]
        public System.Nullable<float> MaximumOutdoorEnthalpy { get; set; } = null;
        

        [Description("this is the outdoor temperature below which ventilation is shutoff Applicable onl" +
                     "y if Ventilation Control Mode = 3")]
        [JsonProperty("minimum_outdoor_dewpoint")]
        public System.Nullable<float> MinimumOutdoorDewpoint { get; set; } = (System.Nullable<float>)Single.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("this is the outdoor dewpoint above which ventilation is shutoff Applicable only i" +
                     "f Ventilation Control Mode = 3")]
        [JsonProperty("maximum_outdoor_dewpoint")]
        public System.Nullable<float> MaximumOutdoorDewpoint { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

        [Description("Used only if Ventilation Control Mode = 4")]
        [JsonProperty("minimum_outdoor_ventilation_air_schedule_name")]
        public string MinimumOutdoorVentilationAirScheduleName { get; set; } = "";
        

        [Description("linear curve = a + b*WS quadratic curve = a + b*WS + c*WS**2 WS = wind speed (m/s" +
                     ")")]
        [JsonProperty("opening_factor_function_of_wind_speed_curve_name")]
        public string OpeningFactorFunctionOfWindSpeedCurveName { get; set; } = "";
        

        [Description("The schedule is used to incorporate operation of AirflowNetwork large opening obj" +
                     "ects and HVAC system operation.")]
        [JsonProperty("airflownetwork_control_type_schedule_name")]
        public string AirflownetworkControlTypeScheduleName { get; set; } = "";
        

        [Description("The schedule is used to incorporate operation of simple airflow objects and HVAC " +
                     "system operation. The simple airflow objects are Ventilation and Mixing only")]
        [JsonProperty("simple_airflow_control_type_schedule_name")]
        public string SimpleAirflowControlTypeScheduleName { get; set; } = "";
        

        [Description(@"This field has not been instrumented to work with global Zone or Zone List names option for Ventilation:DesignFlowRate. In order to use, you must enter the single <Ventilation:DesignFlowRate> name in this field. If it is a part of a global ventilation assignment the name will be <Zone Name> <global Ventilation:DesignFlowRate> name. The other ZoneVentilation:* and ZoneMixing objects controlled in the same AirLoopHVAC will work in the same way as this ventilation object.")]
        [JsonProperty("zoneventilation_object_name")]
        public string ZoneventilationObjectName { get; set; } = "";
        

        [Description("Minimum operation time when HVAC system is forced on.")]
        [JsonProperty("minimum_hvac_operation_time")]
        public System.Nullable<float> MinimumHvacOperationTime { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Minimum ventilation time when natural ventilation is forced on.")]
        [JsonProperty("minimum_ventilation_time")]
        public System.Nullable<float> MinimumVentilationTime { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}