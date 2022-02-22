using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, single duct, variable volume, induction unit wi" +
                 "th hot water reheat coil and chilled water recool coil.")]
    [JsonObject("AirTerminal:SingleDuct:ConstantVolume:FourPipeInduction")]
    public class AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("maximum_total_air_flow_rate")]
        public string MaximumTotalAirFlowRate { get; set; } = "";
        

        [Description("ratio of induced air flow rate to primary air flow rate")]
        [JsonProperty("induction_ratio")]
        public System.Nullable<float> InductionRatio { get; set; } = (System.Nullable<float>)Single.Parse("2.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_air_inlet_node_name")]
        public string SupplyAirInletNodeName { get; set; } = "";
        

        [Description("should be a zone exhaust node, also the heating coil inlet node")]
        [JsonProperty("induced_air_inlet_node_name")]
        public string InducedAirInletNodeName { get; set; } = "";
        

        [Description("should be a zone inlet node")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("heating_coil_object_type")]
        public AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_HeatingCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_HeatingCoilObjectType), "CoilHeatingWater");
        

        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
        

        [Description("Not used when heating coil type is gas or electric")]
        [JsonProperty("maximum_hot_water_flow_rate")]
        public string MaximumHotWaterFlowRate { get; set; } = "";
        

        [Description("Not used when heating coil type is gas or electric")]
        [JsonProperty("minimum_hot_water_flow_rate")]
        public System.Nullable<float> MinimumHotWaterFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_convergence_tolerance")]
        public System.Nullable<float> HeatingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_coil_object_type")]
        public AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_CoolingCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_CoolingCoilObjectType), "CoilCoolingWater");
        

        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
        

        [JsonProperty("maximum_cold_water_flow_rate")]
        public string MaximumColdWaterFlowRate { get; set; } = "";
        

        [JsonProperty("minimum_cold_water_flow_rate")]
        public System.Nullable<float> MinimumColdWaterFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_convergence_tolerance")]
        public System.Nullable<float> CoolingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [JsonProperty("zone_mixer_name")]
        public string ZoneMixerName { get; set; } = "";
    }
}