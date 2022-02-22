using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Describe the core power module subsystem of a fuel cell power generator. This includes the fuel cell stack, fuel reformer, and whatever ancillary devices are included inside. If the model has multiple FC generators that are of the exact same type, then only one of these objects is needed and all the Generator:FuelCell objects can reference it.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelCell_PowerModule : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("efficiency_curve_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_PowerModule_EfficiencyCurveMode EfficiencyCurveMode { get; set; } = (Generator_FuelCell_PowerModule_EfficiencyCurveMode)Enum.Parse(typeof(Generator_FuelCell_PowerModule_EfficiencyCurveMode), "Annex42");
        

        [JsonProperty("efficiency_curve_name")]
        public string EfficiencyCurveName { get; set; } = "";
        

        [Description("This field is not used.")]
        [JsonProperty("nominal_efficiency")]
        public System.Nullable<float> NominalEfficiency { get; set; } = null;
        

        [Description("This field is not used")]
        [JsonProperty("nominal_electrical_power")]
        public System.Nullable<float> NominalElectricalPower { get; set; } = null;
        

        [Description("this is Nstops in SOFC model specification")]
        [JsonProperty("number_of_stops_at_start_of_simulation")]
        public System.Nullable<float> NumberOfStopsAtStartOfSimulation { get; set; } = null;
        

        [Description("this is D in SOFC model specification")]
        [JsonProperty("cycling_performance_degradation_coefficient")]
        public System.Nullable<float> CyclingPerformanceDegradationCoefficient { get; set; } = null;
        

        [JsonProperty("number_of_run_hours_at_beginning_of_simulation")]
        public System.Nullable<float> NumberOfRunHoursAtBeginningOfSimulation { get; set; } = null;
        

        [Description("this is L in SOFC model specification")]
        [JsonProperty("accumulated_run_time_degradation_coefficient")]
        public System.Nullable<float> AccumulatedRunTimeDegradationCoefficient { get; set; } = null;
        

        [JsonProperty("run_time_degradation_initiation_time_threshold")]
        public System.Nullable<float> RunTimeDegradationInitiationTimeThreshold { get; set; } = null;
        

        [Description("Maximum rate of change in electrical output [power increasing]")]
        [JsonProperty("power_up_transient_limit")]
        public System.Nullable<float> PowerUpTransientLimit { get; set; } = null;
        

        [Description("Maximum rate of change in electrical output [power decreasing] Enter positive val" +
                     "ue for rate of change")]
        [JsonProperty("power_down_transient_limit")]
        public System.Nullable<float> PowerDownTransientLimit { get; set; } = null;
        

        [Description("Time from start up to normal operation")]
        [JsonProperty("start_up_time")]
        public System.Nullable<float> StartUpTime { get; set; } = null;
        

        [JsonProperty("start_up_fuel")]
        public System.Nullable<float> StartUpFuel { get; set; } = null;
        

        [JsonProperty("start_up_electricity_consumption")]
        public System.Nullable<float> StartUpElectricityConsumption { get; set; } = null;
        

        [JsonProperty("start_up_electricity_produced")]
        public System.Nullable<float> StartUpElectricityProduced { get; set; } = null;
        

        [JsonProperty("shut_down_time")]
        public System.Nullable<float> ShutDownTime { get; set; } = null;
        

        [JsonProperty("shut_down_fuel")]
        public System.Nullable<float> ShutDownFuel { get; set; } = null;
        

        [JsonProperty("shut_down_electricity_consumption")]
        public System.Nullable<float> ShutDownElectricityConsumption { get; set; } = null;
        

        [JsonProperty("ancillary_electricity_constant_term")]
        public System.Nullable<float> AncillaryElectricityConstantTerm { get; set; } = null;
        

        [JsonProperty("ancillary_electricity_linear_term")]
        public System.Nullable<float> AncillaryElectricityLinearTerm { get; set; } = null;
        

        [JsonProperty("skin_loss_calculation_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_PowerModule_SkinLossCalculationMode SkinLossCalculationMode { get; set; } = (Generator_FuelCell_PowerModule_SkinLossCalculationMode)Enum.Parse(typeof(Generator_FuelCell_PowerModule_SkinLossCalculationMode), "ConstantRate");
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("skin_loss_radiative_fraction")]
        public System.Nullable<float> SkinLossRadiativeFraction { get; set; } = null;
        

        [JsonProperty("constant_skin_loss_rate")]
        public System.Nullable<float> ConstantSkinLossRate { get; set; } = null;
        

        [JsonProperty("skin_loss_u_factor_times_area_term")]
        public System.Nullable<float> SkinLossUFactorTimesAreaTerm { get; set; } = null;
        

        [Description("curve is function of fuel use rate")]
        [JsonProperty("skin_loss_quadratic_curve_name")]
        public string SkinLossQuadraticCurveName { get; set; } = "";
        

        [JsonProperty("dilution_air_flow_rate")]
        public System.Nullable<float> DilutionAirFlowRate { get; set; } = null;
        

        [JsonProperty("stack_heat_loss_to_dilution_air")]
        public System.Nullable<float> StackHeatLossToDilutionAir { get; set; } = null;
        

        [JsonProperty("dilution_inlet_air_node_name")]
        public string DilutionInletAirNodeName { get; set; } = "";
        

        [JsonProperty("dilution_outlet_air_node_name")]
        public string DilutionOutletAirNodeName { get; set; } = "";
        

        [JsonProperty("minimum_operating_point")]
        public System.Nullable<float> MinimumOperatingPoint { get; set; } = null;
        

        [JsonProperty("maximum_operating_point")]
        public System.Nullable<float> MaximumOperatingPoint { get; set; } = null;
    }
}