using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, single duct, variable volume, parallel powered " +
                 "induction unit (PIU), with reheat coil (hot water, electric, gas, or steam).")]
    [JsonObject("AirTerminal:SingleDuct:ParallelPIU:Reheat")]
    public class AirTerminal_SingleDuct_ParallelPIU_Reheat : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("maximum_primary_air_flow_rate")]
        public string MaximumPrimaryAirFlowRate { get; set; } = "";
        

        [JsonProperty("maximum_secondary_air_flow_rate")]
        public string MaximumSecondaryAirFlowRate { get; set; } = "";
        

        [JsonProperty("minimum_primary_air_flow_fraction")]
        public string MinimumPrimaryAirFlowFraction { get; set; } = "";
        

        [Description("the fraction of the primary air flow at which fan turns on")]
        [JsonProperty("fan_on_flow_fraction")]
        public string FanOnFlowFraction { get; set; } = "";
        

        [JsonProperty("supply_air_inlet_node_name")]
        public string SupplyAirInletNodeName { get; set; } = "";
        

        [JsonProperty("secondary_air_inlet_node_name")]
        public string SecondaryAirInletNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [Description("mixer outlet node")]
        [JsonProperty("reheat_coil_air_inlet_node_name")]
        public string ReheatCoilAirInletNodeName { get; set; } = "";
        

        [JsonProperty("zone_mixer_name")]
        public string ZoneMixerName { get; set; } = "";
        

        [Description("Fan type must be Fan:SystemModel or Fan:ConstantVolume")]
        [JsonProperty("fan_name")]
        public string FanName { get; set; } = "";
        

        [JsonProperty("reheat_coil_object_type")]
        public EmptyNoYes ReheatCoilObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("reheat_coil_name")]
        public string ReheatCoilName { get; set; } = "";
        

        [Description("Not used when reheat coil type is gas or electric")]
        [JsonProperty("maximum_hot_water_or_steam_flow_rate")]
        public string MaximumHotWaterOrSteamFlowRate { get; set; } = "";
        

        [Description("Not used when reheat coil type is gas or electric")]
        [JsonProperty("minimum_hot_water_or_steam_flow_rate")]
        public System.Nullable<float> MinimumHotWaterOrSteamFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("convergence_tolerance")]
        public System.Nullable<float> ConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
    }
}