using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Direct expansion (DX) heating coil for water-to-air heat pump (includes electric compressor), single-speed, parameter estimation model. Parameter estimation model is a deterministic model that requires a consistent set of parameters to describe the operating conditions of the heat pump components.")]
    [JsonObject("Coil:Heating:WaterToAirHeatPump:ParameterEstimation")]
    public class Coil_Heating_WaterToAirHeatPump_ParameterEstimation : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Parameters 1-4 are as named below. Parameters 5-9 depend on the type of compresso" +
                     "r. Refer to the InputOutputReference on the parameters required")]
        [JsonProperty("compressor_type")]
        public Coil_Heating_WaterToAirHeatPump_ParameterEstimation_CompressorType CompressorType { get; set; } = (Coil_Heating_WaterToAirHeatPump_ParameterEstimation_CompressorType)Enum.Parse(typeof(Coil_Heating_WaterToAirHeatPump_ParameterEstimation_CompressorType), "Reciprocating");
        

        [JsonProperty("refrigerant_type")]
        public string RefrigerantType { get; set; } = (System.String)"R22";
        

        [JsonProperty("design_source_side_flow_rate")]
        public System.Nullable<float> DesignSourceSideFlowRate { get; set; } = null;
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("gross_rated_heating_capacity")]
        public System.Nullable<float> GrossRatedHeatingCapacity { get; set; } = null;
        

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
        [JsonProperty("superheat_temperature_at_the_evaporator_outlet")]
        public System.Nullable<float> SuperheatTemperatureAtTheEvaporatorOutlet { get; set; } = null;
        

        [Description("Accounts for the loss of work due to mechanical and electrical losses in the comp" +
                     "ressor. Previously called Parameter 3")]
        [JsonProperty("compressor_power_losses")]
        public System.Nullable<float> CompressorPowerLosses { get; set; } = null;
        

        [Description("Previously called Parameter 4")]
        [JsonProperty("compressor_efficiency")]
        public System.Nullable<float> CompressorEfficiency { get; set; } = null;
        

        [Description("Use when Compressor Type is Reciprocating or Rotary Leave this field blank for Co" +
                     "mpressor Type is Scroll. Previously part of Parameter 5")]
        [JsonProperty("compressor_piston_displacement")]
        public System.Nullable<float> CompressorPistonDisplacement { get; set; } = null;
        

        [Description("Used when Compressor Type is Rotary or Reciprocating Leave this field blank for C" +
                     "ompressor Type is Scroll. Previously part of Parameter 6")]
        [JsonProperty("compressor_suction_discharge_pressure_drop")]
        public System.Nullable<float> CompressorSuctionDischargePressureDrop { get; set; } = null;
        

        [Description("Used when Compressor Type is Reciprocating. Leave this field blank for Compressor" +
                     " Type is Rotary or Scroll. Previously part of Parameter 7")]
        [JsonProperty("compressor_clearance_factor")]
        public System.Nullable<float> CompressorClearanceFactor { get; set; } = null;
        

        [Description("Use when Compressor Type is Scroll Leave this field blank for Compressor Type is " +
                     "Rotary or Reciprocating. Previously part of Parameter 5")]
        [JsonProperty("refrigerant_volume_flow_rate")]
        public System.Nullable<float> RefrigerantVolumeFlowRate { get; set; } = null;
        

        [Description("Use when Compressor Type is Scroll. Leave this field blank for Compressor Type is" +
                     " Rotary or Reciprocating. Previously part of Parameter 6")]
        [JsonProperty("volume_ratio")]
        public System.Nullable<float> VolumeRatio { get; set; } = null;
        

        [Description("Use when Compressor Type is Scroll. Leave this field blank for Compressor Type is" +
                     " Rotary or Reciprocating. Previously part of Parameter 7")]
        [JsonProperty("leak_rate_coefficient")]
        public System.Nullable<float> LeakRateCoefficient { get; set; } = null;
        

        [Description("Use when Source Side Fluid Name is Water Leave this field blank when Source Side " +
                     "Fluid is an antifreeze Previously part of Parameter 8")]
        [JsonProperty("source_side_heat_transfer_coefficient")]
        public System.Nullable<float> SourceSideHeatTransferCoefficient { get; set; } = null;
        

        [Description("Use when Source Side Fluid Name is an antifreeze Leave this field blank for Sourc" +
                     "e Side Fluid is Water Previously part of Parameter 8")]
        [JsonProperty("source_side_heat_transfer_resistance1")]
        public System.Nullable<float> SourceSideHeatTransferResistance1 { get; set; } = null;
        

        [Description("Use when Source Side Fluid Name is an antifreeze Leave this field blank for Sourc" +
                     "e Side Fluid is Water Previously part of Parameter 9")]
        [JsonProperty("source_side_heat_transfer_resistance2")]
        public System.Nullable<float> SourceSideHeatTransferResistance2 { get; set; } = null;
    }
}