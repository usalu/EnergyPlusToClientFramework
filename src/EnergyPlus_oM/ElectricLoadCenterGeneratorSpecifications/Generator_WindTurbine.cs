using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Wind turbine generator.")]
    [JsonObject("Generator:WindTurbine")]
    public class Generator_WindTurbine : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("allowed values are: Horizontal Axis Wind Turbine or Vertical Axis Wind Turbine")]
        [JsonProperty("rotor_type")]
        public Generator_WindTurbine_RotorType RotorType { get; set; } = (Generator_WindTurbine_RotorType)Enum.Parse(typeof(Generator_WindTurbine_RotorType), "HorizontalAxisWindTurbine");
        

        [Description("Constant power output is obtained in the last three control types when the wind s" +
                     "peed exceeds the rated wind speed. allowed values are: Fixed Speed Fixed Pitch, " +
                     "Fixed Speed Variable Pitch, Variable Speed Fixed Pitch or Variable Speed Variabl" +
                     "e Pitch")]
        [JsonProperty("power_control")]
        public Generator_WindTurbine_PowerControl PowerControl { get; set; } = (Generator_WindTurbine_PowerControl)Enum.Parse(typeof(Generator_WindTurbine_PowerControl), "VariableSpeedVariablePitch");
        

        [JsonProperty("rated_rotor_speed")]
        public System.Nullable<float> RatedRotorSpeed { get; set; } = null;
        

        [Description("This field is the diameter of the perpendicular circle of the Vertical Axis Wind " +
                     "Turbine system from the upright pole on the ground.")]
        [JsonProperty("rotor_diameter")]
        public System.Nullable<float> RotorDiameter { get; set; } = null;
        

        [Description("This field is the height of the hub for the Horizontal Axis Wind Turbines and of " +
                     "the pole for the Vertical Axis Wind Turbines.")]
        [JsonProperty("overall_height")]
        public System.Nullable<float> OverallHeight { get; set; } = null;
        

        [JsonProperty("number_of_blades")]
        public System.Nullable<float> NumberOfBlades { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("This field is the nominal power at the rated wind speed. Users should input maxim" +
                     "um power in case of Fixed Speed Fixed Pitch control type.")]
        [JsonProperty("rated_power")]
        public System.Nullable<float> RatedPower { get; set; } = null;
        

        [JsonProperty("rated_wind_speed")]
        public System.Nullable<float> RatedWindSpeed { get; set; } = null;
        

        [JsonProperty("cut_in_wind_speed")]
        public System.Nullable<float> CutInWindSpeed { get; set; } = null;
        

        [JsonProperty("cut_out_wind_speed")]
        public System.Nullable<float> CutOutWindSpeed { get; set; } = null;
        

        [JsonProperty("fraction_system_efficiency")]
        public System.Nullable<float> FractionSystemEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.835", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_tip_speed_ratio")]
        public System.Nullable<float> MaximumTipSpeedRatio { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("This field should be input if the rotor type is Horizontal Axis Wind Turbine")]
        [JsonProperty("maximum_power_coefficient")]
        public System.Nullable<float> MaximumPowerCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

        [JsonProperty("annual_local_average_wind_speed")]
        public System.Nullable<float> AnnualLocalAverageWindSpeed { get; set; } = null;
        

        [JsonProperty("height_for_local_average_wind_speed")]
        public System.Nullable<float> HeightForLocalAverageWindSpeed { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [JsonProperty("blade_chord_area")]
        public System.Nullable<float> BladeChordArea { get; set; } = null;
        

        [Description("This field is only for Vertical Axis Wind Turbine.. The user must input this fiel" +
                     "d if the rotor type is Vertical Axis Wind Turbine.")]
        [JsonProperty("blade_drag_coefficient")]
        public System.Nullable<float> BladeDragCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("This field is only for Vertical Axis Wind Turbine.. The user must input this fiel" +
                     "d if the rotor type is Vertical Axis Wind Turbine.")]
        [JsonProperty("blade_lift_coefficient")]
        public System.Nullable<float> BladeLiftCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only available for Horizontal Axis Wind Turbine. The user should input all six parameters so that the analytic approximation is assumed. The simple approximation will be assumed, if any field C1 through C6 is not input. Leave this field blank, if the manufacturer's data is unavailable so that the simple approximation will be assumed.")]
        [JsonProperty("power_coefficient_c1")]
        public System.Nullable<float> PowerCoefficientC1 { get; set; } = (System.Nullable<float>)Single.Parse("0.5176", CultureInfo.InvariantCulture);
        

        [JsonProperty("power_coefficient_c2")]
        public System.Nullable<float> PowerCoefficientC2 { get; set; } = (System.Nullable<float>)Single.Parse("116", CultureInfo.InvariantCulture);
        

        [JsonProperty("power_coefficient_c3")]
        public System.Nullable<float> PowerCoefficientC3 { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty("power_coefficient_c4")]
        public System.Nullable<float> PowerCoefficientC4 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("power_coefficient_c5")]
        public System.Nullable<float> PowerCoefficientC5 { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty("power_coefficient_c6")]
        public System.Nullable<float> PowerCoefficientC6 { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
    }
}