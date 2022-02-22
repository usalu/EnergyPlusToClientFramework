using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HeatRecovery
{
    [Description(@"RTO = B1 + B2*RWI + B3*RTI + B4*(RWI/RTI) + B5*PWI + B6*PTI + B7*(PWI/PTI) + B8*RFV RWO = C1 + C2*RWI + C3*RTI + C4*(RWI/RTI) + C5*PWI + C6*PTI + C7*(PWI/PTI) + C8*RFV where, RTO = Dry-bulb temperature of the regeneration outlet air (C) RWO = Humidity ratio of the regeneration outlet air (kgWater/kgDryAir) RWI = Humidity ratio of the regeneration inlet air (kgWater/kgDryAir) RTI = Dry-bulb temperature of the regeneration inlet air (C) PWI = Humidity ratio of the process inlet air (kgWater/kgDryAir) PTI = Dry-bulb temperature of the process inlet air (C) RFV = Regeneration Face Velocity (m/s)")]
    public class HeatExchanger_Desiccant_BalancedFlow_PerformanceDataType1 : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Air flow rate at nominal conditions (assumed to be the same for both sides of the" +
                     " heat exchanger).")]
        [JsonProperty("nominal_air_flow_rate")]
        public string NominalAirFlowRate { get; set; } = "";
        

        [JsonProperty("nominal_air_face_velocity")]
        public string NominalAirFaceVelocity { get; set; } = "";
        

        [Description("Parasitic electric power (e.g., desiccant wheel motor)")]
        [JsonProperty("nominal_electric_power")]
        public System.Nullable<float> NominalElectricPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("temperature_equation_coefficient_1")]
        public System.Nullable<float> TemperatureEquationCoefficient1 { get; set; } = null;
        

        [JsonProperty("temperature_equation_coefficient_2")]
        public System.Nullable<float> TemperatureEquationCoefficient2 { get; set; } = null;
        

        [JsonProperty("temperature_equation_coefficient_3")]
        public System.Nullable<float> TemperatureEquationCoefficient3 { get; set; } = null;
        

        [JsonProperty("temperature_equation_coefficient_4")]
        public System.Nullable<float> TemperatureEquationCoefficient4 { get; set; } = null;
        

        [JsonProperty("temperature_equation_coefficient_5")]
        public System.Nullable<float> TemperatureEquationCoefficient5 { get; set; } = null;
        

        [JsonProperty("temperature_equation_coefficient_6")]
        public System.Nullable<float> TemperatureEquationCoefficient6 { get; set; } = null;
        

        [JsonProperty("temperature_equation_coefficient_7")]
        public System.Nullable<float> TemperatureEquationCoefficient7 { get; set; } = null;
        

        [JsonProperty("temperature_equation_coefficient_8")]
        public System.Nullable<float> TemperatureEquationCoefficient8 { get; set; } = null;
        

        [JsonProperty("minimum_regeneration_inlet_air_humidity_ratio_for_temperature_equation")]
        public System.Nullable<float> MinimumRegenerationInletAirHumidityRatioForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("maximum_regeneration_inlet_air_humidity_ratio_for_temperature_equation")]
        public System.Nullable<float> MaximumRegenerationInletAirHumidityRatioForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("minimum_regeneration_inlet_air_temperature_for_temperature_equation")]
        public System.Nullable<float> MinimumRegenerationInletAirTemperatureForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("maximum_regeneration_inlet_air_temperature_for_temperature_equation")]
        public System.Nullable<float> MaximumRegenerationInletAirTemperatureForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("minimum_process_inlet_air_humidity_ratio_for_temperature_equation")]
        public System.Nullable<float> MinimumProcessInletAirHumidityRatioForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("maximum_process_inlet_air_humidity_ratio_for_temperature_equation")]
        public System.Nullable<float> MaximumProcessInletAirHumidityRatioForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("minimum_process_inlet_air_temperature_for_temperature_equation")]
        public System.Nullable<float> MinimumProcessInletAirTemperatureForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("maximum_process_inlet_air_temperature_for_temperature_equation")]
        public System.Nullable<float> MaximumProcessInletAirTemperatureForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("minimum_regeneration_air_velocity_for_temperature_equation")]
        public System.Nullable<float> MinimumRegenerationAirVelocityForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("maximum_regeneration_air_velocity_for_temperature_equation")]
        public System.Nullable<float> MaximumRegenerationAirVelocityForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("minimum_regeneration_outlet_air_temperature_for_temperature_equation")]
        public System.Nullable<float> MinimumRegenerationOutletAirTemperatureForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("maximum_regeneration_outlet_air_temperature_for_temperature_equation")]
        public System.Nullable<float> MaximumRegenerationOutletAirTemperatureForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("minimum_regeneration_inlet_air_relative_humidity_for_temperature_equation")]
        public System.Nullable<float> MinimumRegenerationInletAirRelativeHumidityForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("maximum_regeneration_inlet_air_relative_humidity_for_temperature_equation")]
        public System.Nullable<float> MaximumRegenerationInletAirRelativeHumidityForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("minimum_process_inlet_air_relative_humidity_for_temperature_equation")]
        public System.Nullable<float> MinimumProcessInletAirRelativeHumidityForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("maximum_process_inlet_air_relative_humidity_for_temperature_equation")]
        public System.Nullable<float> MaximumProcessInletAirRelativeHumidityForTemperatureEquation { get; set; } = null;
        

        [JsonProperty("humidity_ratio_equation_coefficient_1")]
        public System.Nullable<float> HumidityRatioEquationCoefficient1 { get; set; } = null;
        

        [JsonProperty("humidity_ratio_equation_coefficient_2")]
        public System.Nullable<float> HumidityRatioEquationCoefficient2 { get; set; } = null;
        

        [JsonProperty("humidity_ratio_equation_coefficient_3")]
        public System.Nullable<float> HumidityRatioEquationCoefficient3 { get; set; } = null;
        

        [JsonProperty("humidity_ratio_equation_coefficient_4")]
        public System.Nullable<float> HumidityRatioEquationCoefficient4 { get; set; } = null;
        

        [JsonProperty("humidity_ratio_equation_coefficient_5")]
        public System.Nullable<float> HumidityRatioEquationCoefficient5 { get; set; } = null;
        

        [JsonProperty("humidity_ratio_equation_coefficient_6")]
        public System.Nullable<float> HumidityRatioEquationCoefficient6 { get; set; } = null;
        

        [JsonProperty("humidity_ratio_equation_coefficient_7")]
        public System.Nullable<float> HumidityRatioEquationCoefficient7 { get; set; } = null;
        

        [JsonProperty("humidity_ratio_equation_coefficient_8")]
        public System.Nullable<float> HumidityRatioEquationCoefficient8 { get; set; } = null;
        

        [JsonProperty("minimum_regeneration_inlet_air_humidity_ratio_for_humidity_ratio_equation")]
        public System.Nullable<float> MinimumRegenerationInletAirHumidityRatioForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("maximum_regeneration_inlet_air_humidity_ratio_for_humidity_ratio_equation")]
        public System.Nullable<float> MaximumRegenerationInletAirHumidityRatioForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("minimum_regeneration_inlet_air_temperature_for_humidity_ratio_equation")]
        public System.Nullable<float> MinimumRegenerationInletAirTemperatureForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("maximum_regeneration_inlet_air_temperature_for_humidity_ratio_equation")]
        public System.Nullable<float> MaximumRegenerationInletAirTemperatureForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("minimum_process_inlet_air_humidity_ratio_for_humidity_ratio_equation")]
        public System.Nullable<float> MinimumProcessInletAirHumidityRatioForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("maximum_process_inlet_air_humidity_ratio_for_humidity_ratio_equation")]
        public System.Nullable<float> MaximumProcessInletAirHumidityRatioForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("minimum_process_inlet_air_temperature_for_humidity_ratio_equation")]
        public System.Nullable<float> MinimumProcessInletAirTemperatureForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("maximum_process_inlet_air_temperature_for_humidity_ratio_equation")]
        public System.Nullable<float> MaximumProcessInletAirTemperatureForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("minimum_regeneration_air_velocity_for_humidity_ratio_equation")]
        public System.Nullable<float> MinimumRegenerationAirVelocityForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("maximum_regeneration_air_velocity_for_humidity_ratio_equation")]
        public System.Nullable<float> MaximumRegenerationAirVelocityForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("minimum_regeneration_outlet_air_humidity_ratio_for_humidity_ratio_equation")]
        public System.Nullable<float> MinimumRegenerationOutletAirHumidityRatioForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("maximum_regeneration_outlet_air_humidity_ratio_for_humidity_ratio_equation")]
        public System.Nullable<float> MaximumRegenerationOutletAirHumidityRatioForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("minimum_regeneration_inlet_air_relative_humidity_for_humidity_ratio_equation")]
        public System.Nullable<float> MinimumRegenerationInletAirRelativeHumidityForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("maximum_regeneration_inlet_air_relative_humidity_for_humidity_ratio_equation")]
        public System.Nullable<float> MaximumRegenerationInletAirRelativeHumidityForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("minimum_process_inlet_air_relative_humidity_for_humidity_ratio_equation")]
        public System.Nullable<float> MinimumProcessInletAirRelativeHumidityForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty("maximum_process_inlet_air_relative_humidity_for_humidity_ratio_equation")]
        public System.Nullable<float> MaximumProcessInletAirRelativeHumidityForHumidityRatioEquation { get; set; } = null;
    }
}