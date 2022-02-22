using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("This object is referenced by a Generator:MicroCHP object and provides the non-nor" +
                 "malized parameters for the MicroCHP generator model.")]
    [JsonObject("Generator:MicroCHP:NonNormalizedParameters")]
    public class Generator_MicroCHP_NonNormalizedParameters : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("maximum_electric_power")]
        public System.Nullable<float> MaximumElectricPower { get; set; } = null;
        

        [JsonProperty("minimum_electric_power")]
        public System.Nullable<float> MinimumElectricPower { get; set; } = null;
        

        [JsonProperty("minimum_cooling_water_flow_rate")]
        public System.Nullable<float> MinimumCoolingWaterFlowRate { get; set; } = null;
        

        [JsonProperty("maximum_cooling_water_temperature")]
        public System.Nullable<float> MaximumCoolingWaterTemperature { get; set; } = null;
        

        [Description("TriQuadratic")]
        [JsonProperty("electrical_efficiency_curve_name")]
        public string ElectricalEfficiencyCurveName { get; set; } = "";
        

        [Description("TriQuadratic")]
        [JsonProperty("thermal_efficiency_curve_name")]
        public string ThermalEfficiencyCurveName { get; set; } = "";
        

        [JsonProperty("cooling_water_flow_rate_mode")]
        public Generator_MicroCHP_NonNormalizedParameters_CoolingWaterFlowRateMode CoolingWaterFlowRateMode { get; set; } = (Generator_MicroCHP_NonNormalizedParameters_CoolingWaterFlowRateMode)Enum.Parse(typeof(Generator_MicroCHP_NonNormalizedParameters_CoolingWaterFlowRateMode), "InternalControl");
        

        [JsonProperty("cooling_water_flow_rate_curve_name")]
        public string CoolingWaterFlowRateCurveName { get; set; } = "";
        

        [JsonProperty("air_flow_rate_curve_name")]
        public string AirFlowRateCurveName { get; set; } = "";
        

        [JsonProperty("maximum_net_electrical_power_rate_of_change")]
        public System.Nullable<float> MaximumNetElectricalPowerRateOfChange { get; set; } = null;
        

        [JsonProperty("maximum_fuel_flow_rate_of_change")]
        public System.Nullable<float> MaximumFuelFlowRateOfChange { get; set; } = null;
        

        [JsonProperty("heat_exchanger_u_factor_times_area_value")]
        public System.Nullable<float> HeatExchangerUFactorTimesAreaValue { get; set; } = null;
        

        [JsonProperty("skin_loss_u_factor_times_area_value")]
        public System.Nullable<float> SkinLossUFactorTimesAreaValue { get; set; } = null;
        

        [JsonProperty("skin_loss_radiative_fraction")]
        public System.Nullable<float> SkinLossRadiativeFraction { get; set; } = null;
        

        [JsonProperty("aggregated_thermal_mass_of_energy_conversion_portion_of_generator")]
        public System.Nullable<float> AggregatedThermalMassOfEnergyConversionPortionOfGenerator { get; set; } = null;
        

        [JsonProperty("aggregated_thermal_mass_of_heat_recovery_portion_of_generator")]
        public System.Nullable<float> AggregatedThermalMassOfHeatRecoveryPortionOfGenerator { get; set; } = null;
        

        [JsonProperty("standby_power")]
        public System.Nullable<float> StandbyPower { get; set; } = null;
        

        [Description("Stirling engines use Nominal Engine Temperature Internal combustion engines use T" +
                     "ime Delay")]
        [JsonProperty("warm_up_mode")]
        public Generator_MicroCHP_NonNormalizedParameters_WarmUpMode WarmUpMode { get; set; } = (Generator_MicroCHP_NonNormalizedParameters_WarmUpMode)Enum.Parse(typeof(Generator_MicroCHP_NonNormalizedParameters_WarmUpMode), "NominalEngineTemperature");
        

        [JsonProperty("warm_up_fuel_flow_rate_coefficient")]
        public System.Nullable<float> WarmUpFuelFlowRateCoefficient { get; set; } = null;
        

        [JsonProperty("nominal_engine_operating_temperature")]
        public System.Nullable<float> NominalEngineOperatingTemperature { get; set; } = null;
        

        [JsonProperty("warm_up_power_coefficient")]
        public System.Nullable<float> WarmUpPowerCoefficient { get; set; } = null;
        

        [JsonProperty("warm_up_fuel_flow_rate_limit_ratio")]
        public System.Nullable<float> WarmUpFuelFlowRateLimitRatio { get; set; } = null;
        

        [JsonProperty("warm_up_delay_time")]
        public System.Nullable<float> WarmUpDelayTime { get; set; } = null;
        

        [JsonProperty("cool_down_power")]
        public System.Nullable<float> CoolDownPower { get; set; } = null;
        

        [JsonProperty("cool_down_delay_time")]
        public System.Nullable<float> CoolDownDelayTime { get; set; } = null;
        

        [JsonProperty("restart_mode")]
        public Generator_MicroCHP_NonNormalizedParameters_RestartMode RestartMode { get; set; } = (Generator_MicroCHP_NonNormalizedParameters_RestartMode)Enum.Parse(typeof(Generator_MicroCHP_NonNormalizedParameters_RestartMode), "MandatoryCoolDown");
    }
}