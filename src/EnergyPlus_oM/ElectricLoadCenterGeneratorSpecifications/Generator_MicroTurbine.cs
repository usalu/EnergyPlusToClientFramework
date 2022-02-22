using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("MicroTurbine generators are small combustion turbines (e.g., 25kW to 500kW). The " +
                 "model calculates electrical power output, fuel use, standby and ancillary power." +
                 " Energy recovery from exhaust air can be used to heat water.")]
    [JsonObject("Generator:MicroTurbine")]
    public class Generator_MicroTurbine : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("reference_electrical_power_output")]
        public System.Nullable<float> ReferenceElectricalPowerOutput { get; set; } = null;
        

        [JsonProperty("minimum_full_load_electrical_power_output")]
        public System.Nullable<float> MinimumFullLoadElectricalPowerOutput { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("If left blank, Maximum Full Load Electrical Power Output will be set equal to the" +
                     " Reference Electrical Power Output.")]
        [JsonProperty("maximum_full_load_electrical_power_output")]
        public System.Nullable<float> MaximumFullLoadElectricalPowerOutput { get; set; } = null;
        

        [Description("Electric power output divided by fuel energy input (LHV basis) at reference condi" +
                     "tions.")]
        [JsonProperty("reference_electrical_efficiency_using_lower_heating_value")]
        public System.Nullable<float> ReferenceElectricalEfficiencyUsingLowerHeatingValue { get; set; } = null;
        

        [JsonProperty("reference_combustion_air_inlet_temperature")]
        public System.Nullable<float> ReferenceCombustionAirInletTemperature { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

        [JsonProperty("reference_combustion_air_inlet_humidity_ratio")]
        public System.Nullable<float> ReferenceCombustionAirInletHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.00638", CultureInfo.InvariantCulture);
        

        [JsonProperty("reference_elevation")]
        public System.Nullable<float> ReferenceElevation { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*T + c*T**2 + d*Elev + e*Elev**2 + f*T*Elev T = combustion air inlet" +
                     " temperature (C) Elev = elevation (m)")]
        [JsonProperty("electrical_power_function_of_temperature_and_elevation_curve_name")]
        public string ElectricalPowerFunctionOfTemperatureAndElevationCurveName { get; set; } = "";
        

        [Description("Quadratic curve = a + b*T + c*T**2 Cubic curve = a + b*T + c*T**2 + d*T**3 T = co" +
                     "mbustion air inlet temperature (C)")]
        [JsonProperty("electrical_efficiency_function_of_temperature_curve_name")]
        public string ElectricalEfficiencyFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Quadratic curve = a + b*PLR + c*PLR**2 Cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = ratio of Generator Load to steady state Electrical Power Output at cur" +
                     "rent operating conditions")]
        [JsonProperty("electrical_efficiency_function_of_part_load_ratio_curve_name")]
        public string ElectricalEfficiencyFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [JsonProperty("fuel_type")]
        public Generator_MicroTurbine_FuelType FuelType { get; set; } = (Generator_MicroTurbine_FuelType)Enum.Parse(typeof(Generator_MicroTurbine_FuelType), "NaturalGas");
        

        [JsonProperty("fuel_higher_heating_value")]
        public System.Nullable<float> FuelHigherHeatingValue { get; set; } = (System.Nullable<float>)Single.Parse("50000", CultureInfo.InvariantCulture);
        

        [JsonProperty("fuel_lower_heating_value")]
        public System.Nullable<float> FuelLowerHeatingValue { get; set; } = (System.Nullable<float>)Single.Parse("45450", CultureInfo.InvariantCulture);
        

        [Description("Electric power consumed when the generator is available but not being called by t" +
                     "he Electric Load Center.")]
        [JsonProperty("standby_power")]
        public System.Nullable<float> StandbyPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Electric power consumed by ancillary equipment (e.g., external fuel pressurization pump). Set to zero if Reference Electrical Power Output is the 'net' value (ancillary power already deducted). Input value is positive, but indicates negative electric generation.")]
        [JsonProperty("ancillary_power")]
        public System.Nullable<float> AncillaryPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Quadratic curve = a + b*mdot + c*mdot**2 mdot = fuel mass flow rate (kg/s) If lef" +
                     "t blank, model assumes ancillary power defined in previous field is constant whe" +
                     "never the generator is operating.")]
        [JsonProperty("ancillary_power_function_of_fuel_input_curve_name")]
        public string AncillaryPowerFunctionOfFuelInputCurveName { get; set; } = "";
        

        [JsonProperty("heat_recovery_water_inlet_node_name")]
        public string HeatRecoveryWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("heat_recovery_water_outlet_node_name")]
        public string HeatRecoveryWaterOutletNodeName { get; set; } = "";
        

        [Description("Reference thermal efficiency (heat recovery to water) based on the Lower Heating " +
                     "Value (LHV) of the fuel.")]
        [JsonProperty("reference_thermal_efficiency_using_lower_heat_value")]
        public System.Nullable<float> ReferenceThermalEfficiencyUsingLowerHeatValue { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("reference_inlet_water_temperature")]
        public System.Nullable<float> ReferenceInletWaterTemperature { get; set; } = null;
        

        [Description(@"PlantControl means the heat recovery water flow rate is determined by the plant, but the user needs to supply a heat recovery water flow rate. InternalControl means the heat recovery water flow rate is controlled by this generator. If 'InternalControl' is selected, then the user needs to supply a reference heat recovery water flow rate and optionally the name of a heat recovery flow rate modifier curve.")]
        [JsonProperty("heat_recovery_water_flow_operating_mode")]
        public Generator_MicroTurbine_HeatRecoveryWaterFlowOperatingMode HeatRecoveryWaterFlowOperatingMode { get; set; } = (Generator_MicroTurbine_HeatRecoveryWaterFlowOperatingMode)Enum.Parse(typeof(Generator_MicroTurbine_HeatRecoveryWaterFlowOperatingMode), "PlantControl");
        

        [JsonProperty("reference_heat_recovery_water_flow_rate")]
        public System.Nullable<float> ReferenceHeatRecoveryWaterFlowRate { get; set; } = null;
        

        [Description(@"curve = a + b*T + c*T**2 + d*Pnet + e*Pnet + f*T*Pnet T = heat recovery inlet water temperature Pnet = net power output = electric power output - ancillary power If left blank, model assumes the heat recovery water flow rate is constant whenever the generator is operating, at the Reference HR Water Flow Rate defined in the previous field.")]
        [JsonProperty("heat_recovery_water_flow_rate_function_of_temperature_and_power_curve_name")]
        public string HeatRecoveryWaterFlowRateFunctionOfTemperatureAndPowerCurveName { get; set; } = "";
        

        [Description(@"Bicubic curve = a + b*T + c*T**2 + d*Elev + e*Elev**2 + f*T*Elev + g*T**3 + h*Elev**3 + i*T**2*Elev + j*T*Elev**2 Biquadratic curve = a + b*T + c*T**2 + d*Elev + e*Elev**2 + f*T*Elev T = combustion air inlet temperature (C) Elev = elevation (m) If field is left blank, model assumes this modifier equals 1 for entire simulation.")]
        [JsonProperty("thermal_efficiency_function_of_temperature_and_elevation_curve_name")]
        public string ThermalEfficiencyFunctionOfTemperatureAndElevationCurveName { get; set; } = "";
        

        [Description(@"Quadratic curve = a + b*PLR + c*PLR**2 Cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 PLR = ratio of Generator Load to steady state Electrical Power Output at current operating conditions If field is left blank, model assumes this modifier equals 1 for entire simulation.")]
        [JsonProperty("heat_recovery_rate_function_of_part_load_ratio_curve_name")]
        public string HeatRecoveryRateFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [Description("Quadratic curve = a + b*T + c*T**2 T = inlet water temperature (C) If field is le" +
                     "ft blank, model assumes this modifier equals 1 for entire simulation.")]
        [JsonProperty("heat_recovery_rate_function_of_inlet_water_temperature_curve_name")]
        public string HeatRecoveryRateFunctionOfInletWaterTemperatureCurveName { get; set; } = "";
        

        [Description("Quadratic curve = a + b*Flow + c*Flow**2 Flow = flow rate of water through the he" +
                     "at exchanger (m3/s) If field is left blank, model assumes this modifier equals 1" +
                     " for entire simulation.")]
        [JsonProperty("heat_recovery_rate_function_of_water_flow_rate_curve_name")]
        public string HeatRecoveryRateFunctionOfWaterFlowRateCurveName { get; set; } = "";
        

        [JsonProperty("minimum_heat_recovery_water_flow_rate")]
        public System.Nullable<float> MinimumHeatRecoveryWaterFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_heat_recovery_water_flow_rate")]
        public System.Nullable<float> MaximumHeatRecoveryWaterFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_heat_recovery_water_temperature")]
        public System.Nullable<float> MaximumHeatRecoveryWaterTemperature { get; set; } = null;
        

        [Description("Must be an outdoor air node.")]
        [JsonProperty("combustion_air_inlet_node_name")]
        public string CombustionAirInletNodeName { get; set; } = "";
        

        [JsonProperty("combustion_air_outlet_node_name")]
        public string CombustionAirOutletNodeName { get; set; } = "";
        

        [JsonProperty("reference_exhaust_air_mass_flow_rate")]
        public System.Nullable<float> ReferenceExhaustAirMassFlowRate { get; set; } = null;
        

        [Description("Quadratic curve = a + b*T + c*T**2 Cubic curve = a + b*T + c*T**2 + d*T**3 T = co" +
                     "mbustion air inlet temperature (C) If field is left blank, model assumes this mo" +
                     "difier equals 1 for entire simulation.")]
        [JsonProperty("exhaust_air_flow_rate_function_of_temperature_curve_name")]
        public string ExhaustAirFlowRateFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Quadratic curve = a + b*PLR + c*PLR**2 Cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 PLR = ratio of Generator Load to steady state Electrical Power Output at current operating conditions. If field is left blank, model assumes this modifier equals 1 for entire simulation.")]
        [JsonProperty("exhaust_air_flow_rate_function_of_part_load_ratio_curve_name")]
        public string ExhaustAirFlowRateFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [Description("Exhaust air outlet temperature at reference conditions.")]
        [JsonProperty("nominal_exhaust_air_outlet_temperature")]
        public System.Nullable<float> NominalExhaustAirOutletTemperature { get; set; } = null;
        

        [Description("Quadratic curve = a + b*T + c*T**2 Cubic curve = a + b*T + c*T**2 + d*T**3 T = co" +
                     "mbustion air inlet temperature (C) If field is left blank, model assumes this mo" +
                     "difier equals 1 for entire simulation.")]
        [JsonProperty("exhaust_air_temperature_function_of_temperature_curve_name")]
        public string ExhaustAirTemperatureFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Quadratic curve = a + b*PLR + c*PLR**2 Cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 PLR = ratio of Generator Load to steady state Electrical Power Output at current operating conditions. If field is left blank, model assumes this modifier equals 1 for entire simulation.")]
        [JsonProperty("exhaust_air_temperature_function_of_part_load_ratio_curve_name")]
        public string ExhaustAirTemperatureFunctionOfPartLoadRatioCurveName { get; set; } = "";
    }
}