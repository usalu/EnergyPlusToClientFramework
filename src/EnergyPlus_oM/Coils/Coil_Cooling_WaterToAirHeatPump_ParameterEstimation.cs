using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Direct expansion (DX) cooling coil for water-to-air heat pump (includes electric compressor), single-speed, parameter estimation model. Optional inputs for moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Parameter estimation model is a deterministic model that requires a consistent set of parameters to describe the operating conditions of the heat pump components.")]
    [JsonObject("Coil:Cooling:WaterToAirHeatPump:ParameterEstimation")]
    public class Coil_Cooling_WaterToAirHeatPump_ParameterEstimation : BHoMObject
    {
        

        [Description("Parameters 1-5 are as named below. Parameters 6-10 depend on the type of compress" +
                     "or and fluid. Refer to the InputOutputReference on the parameters required")]
        [JsonProperty("compressor_type")]
        public EmptyNoYes CompressorType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("refrigerant_type")]
        public string RefrigerantType { get; set; } = (System.String)"R22";
        

        [JsonProperty("design_source_side_flow_rate")]
        public System.Nullable<float> DesignSourceSideFlowRate { get; set; } = null;
        

        [JsonProperty("nominal_cooling_coil_capacity")]
        public System.Nullable<float> NominalCoolingCoilCapacity { get; set; } = null;
        

        [Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
        [JsonProperty("nominal_time_for_condensate_removal_to_begin")]
        public System.Nullable<float> NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
        [JsonProperty("ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capacity")]
        public System.Nullable<float> RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("high_pressure_cutoff")]
        public System.Nullable<float> HighPressureCutoff { get; set; } = null;
        

        [JsonProperty("low_pressure_cutoff")]
        public System.Nullable<float> LowPressureCutoff { get; set; } = null;
        

        [JsonProperty("water_inlet_node_name")]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty("water_outlet_node_name")]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Previously called Parameter 1")]
        [JsonProperty("load_side_total_heat_transfer_coefficient")]
        public System.Nullable<float> LoadSideTotalHeatTransferCoefficient { get; set; } = null;
        

        [Description("Previously called Parameter 2")]
        [JsonProperty("load_side_outside_surface_heat_transfer_coefficient")]
        public System.Nullable<float> LoadSideOutsideSurfaceHeatTransferCoefficient { get; set; } = null;
        

        [Description("Previously called Parameter 3")]
        [JsonProperty("superheat_temperature_at_the_evaporator_outlet")]
        public System.Nullable<float> SuperheatTemperatureAtTheEvaporatorOutlet { get; set; } = null;
        

        [Description("Accounts for the loss of work due to mechanical and electrical losses in the comp" +
                     "ressor. Previously called Parameter 4")]
        [JsonProperty("compressor_power_losses")]
        public System.Nullable<float> CompressorPowerLosses { get; set; } = null;
        

        [Description("Previously called Parameter 5")]
        [JsonProperty("compressor_efficiency")]
        public System.Nullable<float> CompressorEfficiency { get; set; } = null;
        

        [Description("Use when Compressor Type is Reciprocating or Rotary Leave this field blank for Co" +
                     "mpressor Type is Scroll. Previously part of Parameter 6")]
        [JsonProperty("compressor_piston_displacement")]
        public System.Nullable<float> CompressorPistonDisplacement { get; set; } = null;
        

        [Description("Used when Compressor Type is Rotary or Reciprocating Leave this field blank for C" +
                     "ompressor Type is Scroll. Previously part of Parameter 7")]
        [JsonProperty("compressor_suction_discharge_pressure_drop")]
        public System.Nullable<float> CompressorSuctionDischargePressureDrop { get; set; } = null;
        

        [Description("Used when Compressor Type is Reciprocating. Leave this field blank for Compressor" +
                     " Type is Rotary or Scroll. Previously part of Parameter 8")]
        [JsonProperty("compressor_clearance_factor")]
        public System.Nullable<float> CompressorClearanceFactor { get; set; } = null;
        

        [Description("Use when Compressor Type is Scroll Leave this field blank for Compressor Type is " +
                     "Rotary or Reciprocating. Previously part of Parameter 6")]
        [JsonProperty("refrigerant_volume_flow_rate")]
        public System.Nullable<float> RefrigerantVolumeFlowRate { get; set; } = null;
        

        [Description("Use when Compressor Type is Scroll. Leave this field blank for Compressor Type is" +
                     " Rotary or Reciprocating. Previously part of Parameter 7")]
        [JsonProperty("volume_ratio")]
        public System.Nullable<float> VolumeRatio { get; set; } = null;
        

        [Description("Use when Compressor Type is Scroll. Leave this field blank for Compressor Type is" +
                     " Rotary or Reciprocating. Previously part of Parameter 8")]
        [JsonProperty("leak_rate_coefficient")]
        public System.Nullable<float> LeakRateCoefficient { get; set; } = null;
        

        [Description("Use when Source Side Fluid Name is Water Leave this field blank when Source Side " +
                     "Fluid Name is an antifreeze Previously part of Parameter 9")]
        [JsonProperty("source_side_heat_transfer_coefficient")]
        public System.Nullable<float> SourceSideHeatTransferCoefficient { get; set; } = null;
        

        [Description("Use when Source Side Fluid Name is an antifreeze Leave this field blank for Sourc" +
                     "e Side Fluid is Water Previously part of Parameter 9")]
        [JsonProperty("source_side_heat_transfer_resistance1")]
        public System.Nullable<float> SourceSideHeatTransferResistance1 { get; set; } = null;
        

        [Description("Use when Source Side Fluid Name is an antifreeze Leave this field blank for Sourc" +
                     "e Side Fluid is Water Previously part of Parameter 10")]
        [JsonProperty("source_side_heat_transfer_resistance2")]
        public System.Nullable<float> SourceSideHeatTransferResistance2 { get; set; } = null;
    }
}