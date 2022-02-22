using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers
{
    [Description(@"This object models a solid desiccant dehumidifier. The process air stream is the air which is dehumidified. The regeneration air stream is the air which is heated to regenerate the desiccant. This object determines the process air outlet conditions, the load on the regeneration heating coil, the electric power consumption for the wheel rotor motor, and the regeneration air fan mass flow rate. All other heat exchangers are modeled as separate objects connected to the inlet and outlet nodes of the dehumidifier. The solid desiccant dehumidifier is typically used in an AirLoopHVAC:OutdoorAirSystem, but can also be specified in any AirLoopHVAC.")]
    public class Dehumidifier_Desiccant_NoFans : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("This is the node entering the process side of the desiccant wheel.")]
        [JsonProperty("process_air_inlet_node_name")]
        public string ProcessAirInletNodeName { get; set; } = "";
        

        [Description("This is the node leaving the process side of the desiccant wheel.")]
        [JsonProperty("process_air_outlet_node_name")]
        public string ProcessAirOutletNodeName { get; set; } = "";
        

        [Description("This is the node entering the regeneration side of the desiccant wheel after the " +
                     "regeneration coil.")]
        [JsonProperty("regeneration_air_inlet_node_name")]
        public string RegenerationAirInletNodeName { get; set; } = "";
        

        [Description("Node for air entering the regeneration fan, mass flow is set by the desiccant deh" +
                     "umidifier module.")]
        [JsonProperty("regeneration_fan_inlet_node_name")]
        public string RegenerationFanInletNodeName { get; set; } = "";
        

        [Description(@"Type of setpoint control: LeavingMaximumHumidityRatioSetpoint means that the unit is controlled to deliver air at the Leaving Max Humidity Ratio Setpoint (see below), SystemNodeMaximumHumidityRatioSetpoint means that the leaving humidity ratio setpoint is the System Node Humidity Ratio Max property of the Process Air Outlet Node. A Setpoint object must be used to control this setpoint. Both control types use bypass dampers to prevent over drying.")]
        [JsonProperty("control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_NoFans_ControlType ControlType { get; set; } = (Dehumidifier_Desiccant_NoFans_ControlType)Enum.Parse(typeof(Dehumidifier_Desiccant_NoFans_ControlType), "LeavingMaximumHumidityRatioSetpoint");
        

        [Description("Fixed setpoint for maximum process air leaving humidity ratio Applicable only whe" +
                     "n Control Type = LeavingMaximumHumidityRatioSetpoint.")]
        [JsonProperty("leaving_maximum_humidity_ratio_setpoint")]
        public System.Nullable<float> LeavingMaximumHumidityRatioSetpoint { get; set; } = null;
        

        [Description("Process air flow rate at nominal conditions")]
        [JsonProperty("nominal_process_air_flow_rate")]
        public System.Nullable<float> NominalProcessAirFlowRate { get; set; } = null;
        

        [Description("Process air velocity at nominal flow When using Performance Model Type of Default" +
                     ", must be 2.032 to 4.064 m/s (400 to 800 fpm)")]
        [JsonProperty("nominal_process_air_velocity")]
        public System.Nullable<float> NominalProcessAirVelocity { get; set; } = null;
        

        [Description("Power input to wheel rotor motor")]
        [JsonProperty("rotor_power")]
        public System.Nullable<float> RotorPower { get; set; } = null;
        

        [Description("heating coil type works with gas, electric, hot water and steam heating coils")]
        [JsonProperty("regeneration_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_NoFans_RegenerationCoilObjectType RegenerationCoilObjectType { get; set; } = (Dehumidifier_Desiccant_NoFans_RegenerationCoilObjectType)Enum.Parse(typeof(Dehumidifier_Desiccant_NoFans_RegenerationCoilObjectType), "CoilHeatingElectric");
        

        [Description("Name of heating coil object for regeneration air")]
        [JsonProperty("regeneration_coil_name")]
        public string RegenerationCoilName { get; set; } = "";
        

        [Description("Type of fan object for regeneration air. When using the Default Performance Model" +
                     " Type (see below), only Fan:VariableVolume or Fan:SystemModel are valid.")]
        [JsonProperty("regeneration_fan_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_NoFans_RegenerationFanObjectType RegenerationFanObjectType { get; set; } = (Dehumidifier_Desiccant_NoFans_RegenerationFanObjectType)Enum.Parse(typeof(Dehumidifier_Desiccant_NoFans_RegenerationFanObjectType), "FanConstantVolume");
        

        [Description("Name of fan object for regeneration air")]
        [JsonProperty("regeneration_fan_name")]
        public string RegenerationFanName { get; set; } = "";
        

        [Description(@"Specifies whether the default performance model or user-specified curves should be used to model the performance. The default model is a generic solid desiccant wheel using performance curves of the form: curve = C1 + C2*edb + C3*edb**2 + C4*ew + C5*ew**2 + C6*vel + C7*vel**2 + C8*edb*ew + C9*edb**2*ew**2 + C10*edb*vel + C11*edb**2*vel**2 + C12*ew*vel + C13*ew**2*vel**2 + C14*ALOG(edb) + C15*ALOG(ew) + C16*ALOG(vel) edb = process entering dry-bulb temperature [C] ew  = process entering humidity ratio [kgWater/kgDryAir] vel = process air velocity [m/s] If UserCurves are specified, then performance is calculated as follows: Leaving Dry-Bulb = (Leaving Dry-Bulb fTW Curve) * (Leaving Dry-Bulb fV Curve) Leaving Humidity Ratio = (Leaving Humidity Ratio fTW Curve) * (Leaving Humidity Ratio fV Curve) Regen Energy = (Regen Energy fTW Curve) * (Regen Energy fV Curve) Regen Velocity = (Regen Velocity fTW Curve) * (Regen Velocity fV Curve)")]
        [JsonProperty("performance_model_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_NoFans_PerformanceModelType PerformanceModelType { get; set; } = (Dehumidifier_Desiccant_NoFans_PerformanceModelType)Enum.Parse(typeof(Dehumidifier_Desiccant_NoFans_PerformanceModelType), "Default");
        

        [Description(@"Leaving dry-bulb of process air as a function of entering dry-bulb and entering humidity ratio, biquadratic curve curve = C1 + C2*edb + C3*edb**2 + C4*ew + C5*ew**2 + C6*edb*ew edb = process entering dry-bulb temperature [C] ew  = process entering humidity ratio [kgWater/kgDryAir]")]
        [JsonProperty("leaving_dry_bulb_function_of_entering_dry_bulb_and_humidity_ratio_curve_name")]
        public string LeavingDryBulbFunctionOfEnteringDryBulbAndHumidityRatioCurveName { get; set; } = "";
        

        [Description("Leaving dry-bulb of process air as a function of air velocity, quadratic curve. c" +
                     "urve = C1 + C2*v + C3*v**2 v = process air velocity [m/s]")]
        [JsonProperty("leaving_dry_bulb_function_of_air_velocity_curve_name")]
        public string LeavingDryBulbFunctionOfAirVelocityCurveName { get; set; } = "";
        

        [Description(@"Leaving humidity ratio of process air as a function of entering dry-bulb and entering humidity ratio, biquadratic curve curve = C1 + C2*edb + C3*edb**2 + C4*ew + C5*ew**2 + C6*edb*ew edb = process entering dry-bulb temperature [C] ew  = process entering humidity ratio [kgWater/kgDryAir]")]
        [JsonProperty("leaving_humidity_ratio_function_of_entering_dry_bulb_and_humidity_ratio_curve_nam" +
                      "e")]
        public string LeavingHumidityRatioFunctionOfEnteringDryBulbAndHumidityRatioCurveName { get; set; } = "";
        

        [Description("Leaving humidity ratio of process air as a function of process air velocity, quad" +
                     "ratic curve. curve = C1 + C2*v + C3*v**2 v = process air velocity [m/s]")]
        [JsonProperty("leaving_humidity_ratio_function_of_air_velocity_curve_name")]
        public string LeavingHumidityRatioFunctionOfAirVelocityCurveName { get; set; } = "";
        

        [Description(@"Regeneration energy [J/kg of water removed] as a function of entering dry-bulb and entering humidity ratio, biquadratic curve curve = C1 + C2*edb + C3*edb**2 + C4*ew + C5*ew**2 + C6*edb*ew edb = process entering dry-bulb temperature [C] ew  = process entering humidity ratio [kgWater/kgDryAir]")]
        [JsonProperty("regeneration_energy_function_of_entering_dry_bulb_and_humidity_ratio_curve_name")]
        public string RegenerationEnergyFunctionOfEnteringDryBulbAndHumidityRatioCurveName { get; set; } = "";
        

        [Description("Regeneration energy [J/kg of water removed] as a function of process air velocity" +
                     ", quadratic curve. curve = C1 + C2*v + C3*v**2 v = process air velocity [m/s]")]
        [JsonProperty("regeneration_energy_function_of_air_velocity_curve_name")]
        public string RegenerationEnergyFunctionOfAirVelocityCurveName { get; set; } = "";
        

        [Description(@"Regeneration velocity [m/s] as a function of entering dry-bulb and entering humidity ratio, biquadratic curve curve = C1 + C2*edb + C3*edb**2 + C4*ew + C5*ew**2 + C6*edb*ew edb = process entering dry-bulb temperature [C] ew  = process entering humidity ratio [kgWater/kgDryAir]")]
        [JsonProperty("regeneration_velocity_function_of_entering_dry_bulb_and_humidity_ratio_curve_name" +
                      "")]
        public string RegenerationVelocityFunctionOfEnteringDryBulbAndHumidityRatioCurveName { get; set; } = "";
        

        [Description("Regeneration velocity [m/s] as a function of process air velocity, quadratic curv" +
                     "e. curve = C1 + C2*v + C3*v**2 v = process air velocity [m/s]")]
        [JsonProperty("regeneration_velocity_function_of_air_velocity_curve_name")]
        public string RegenerationVelocityFunctionOfAirVelocityCurveName { get; set; } = "";
        

        [Description("Nominal regen temperature upon which the regen energy modifier curve is based. No" +
                     "t used if Default if chosen for the field Performance Mode Type. 121 C is a comm" +
                     "only used value.")]
        [JsonProperty("nominal_regeneration_temperature")]
        public System.Nullable<float> NominalRegenerationTemperature { get; set; } = null;
    }
}