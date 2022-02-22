using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("OSU parameter estimation model")]
    [JsonObject("HeatPump:WaterToWater:ParameterEstimation:Heating")]
    public class HeatPump_WaterToWater_ParameterEstimation_Heating : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("source_side_inlet_node_name")]
        public string SourceSideInletNodeName { get; set; } = "";
        

        [JsonProperty("source_side_outlet_node_name")]
        public string SourceSideOutletNodeName { get; set; } = "";
        

        [JsonProperty("load_side_inlet_node_name")]
        public string LoadSideInletNodeName { get; set; } = "";
        

        [JsonProperty("load_side_outlet_node_name")]
        public string LoadSideOutletNodeName { get; set; } = "";
        

        [JsonProperty("nominal_cop")]
        public System.Nullable<float> NominalCop { get; set; } = null;
        

        [JsonProperty("nominal_capacity")]
        public System.Nullable<float> NominalCapacity { get; set; } = null;
        

        [JsonProperty("minimum_part_load_ratio")]
        public System.Nullable<float> MinimumPartLoadRatio { get; set; } = null;
        

        [JsonProperty("maximum_part_load_ratio")]
        public System.Nullable<float> MaximumPartLoadRatio { get; set; } = null;
        

        [JsonProperty("optimum_part_load_ratio")]
        public System.Nullable<float> OptimumPartLoadRatio { get; set; } = null;
        

        [JsonProperty("load_side_flow_rate")]
        public System.Nullable<float> LoadSideFlowRate { get; set; } = null;
        

        [JsonProperty("source_side_flow_rate")]
        public System.Nullable<float> SourceSideFlowRate { get; set; } = null;
        

        [JsonProperty("load_side_heat_transfer_coefficient")]
        public System.Nullable<float> LoadSideHeatTransferCoefficient { get; set; } = null;
        

        [JsonProperty("source_side_heat_transfer_coefficient")]
        public System.Nullable<float> SourceSideHeatTransferCoefficient { get; set; } = null;
        

        [JsonProperty("piston_displacement")]
        public System.Nullable<float> PistonDisplacement { get; set; } = null;
        

        [JsonProperty("compressor_clearance_factor")]
        public System.Nullable<float> CompressorClearanceFactor { get; set; } = null;
        

        [JsonProperty("compressor_suction_and_discharge_pressure_drop")]
        public System.Nullable<float> CompressorSuctionAndDischargePressureDrop { get; set; } = null;
        

        [JsonProperty("superheating")]
        public System.Nullable<float> Superheating { get; set; } = null;
        

        [JsonProperty("constant_part_of_electromechanical_power_losses")]
        public System.Nullable<float> ConstantPartOfElectromechanicalPowerLosses { get; set; } = null;
        

        [Description("Used to define electromechanical loss that is proportional to the theoretical pow" +
                     "er %")]
        [JsonProperty("loss_factor")]
        public System.Nullable<float> LossFactor { get; set; } = null;
        

        [JsonProperty("high_pressure_cut_off")]
        public System.Nullable<float> HighPressureCutOff { get; set; } = (System.Nullable<float>)Single.Parse("500000000", CultureInfo.InvariantCulture);
        

        [JsonProperty("low_pressure_cut_off")]
        public System.Nullable<float> LowPressureCutOff { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}