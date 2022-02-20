using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Used to define details of the air supply subsystem for a fuel cell power generato" +
                 "r.")]
    [JsonObject("Generator:FuelCell:AirSupply")]
    public class Generator_FuelCell_AirSupply : BHoMObject
    {
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("blower_power_curve_name")]
        public string BlowerPowerCurveName { get; set; } = "";
        

        [JsonProperty("blower_heat_loss_factor")]
        public System.Nullable<float> BlowerHeatLossFactor { get; set; } = null;
        

        [JsonProperty("air_supply_rate_calculation_mode")]
        public EmptyNoYes AirSupplyRateCalculationMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("This is the excess air \"stoics\" the value entered is incremented by 1 in the mode" +
                     "l.")]
        [JsonProperty("stoichiometric_ratio")]
        public System.Nullable<float> StoichiometricRatio { get; set; } = null;
        

        [JsonProperty("air_rate_function_of_electric_power_curve_name")]
        public string AirRateFunctionOfElectricPowerCurveName { get; set; } = "";
        

        [JsonProperty("air_rate_air_temperature_coefficient")]
        public System.Nullable<float> AirRateAirTemperatureCoefficient { get; set; } = null;
        

        [JsonProperty("air_rate_function_of_fuel_rate_curve_name")]
        public string AirRateFunctionOfFuelRateCurveName { get; set; } = "";
        

        [JsonProperty("air_intake_heat_recovery_mode")]
        public EmptyNoYes AirIntakeHeatRecoveryMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("air_supply_constituent_mode")]
        public EmptyNoYes AirSupplyConstituentMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("number_of_userdefined_constituents")]
        public System.Nullable<float> NumberOfUserdefinedConstituents { get; set; } = null;
        

        [JsonProperty("constituent_fractions")]
        public string ConstituentFractions { get; set; } = "";
    }
}