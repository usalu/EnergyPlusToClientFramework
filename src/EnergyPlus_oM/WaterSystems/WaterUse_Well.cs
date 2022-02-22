using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    [Description(@"Simulates on-site water supply from a well. Well water is pumped out of the ground into a WaterUse:Storage. The operation of the ground water well is controlled by the associated WaterUse:Storage which is assumed to be operated as a vented cistern with no pressure tank.")]
    [JsonObject("WaterUse:Well")]
    public class WaterUse_Well : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("storage_tank_name")]
        public string StorageTankName { get; set; } = "";
        

        [JsonProperty("pump_depth")]
        public System.Nullable<float> PumpDepth { get; set; } = null;
        

        [JsonProperty("pump_rated_flow_rate")]
        public System.Nullable<float> PumpRatedFlowRate { get; set; } = null;
        

        [JsonProperty("pump_rated_head")]
        public System.Nullable<float> PumpRatedHead { get; set; } = null;
        

        [JsonProperty("pump_rated_power_consumption")]
        public System.Nullable<float> PumpRatedPowerConsumption { get; set; } = null;
        

        [JsonProperty("pump_efficiency")]
        public System.Nullable<float> PumpEfficiency { get; set; } = null;
        

        [JsonProperty("well_recovery_rate")]
        public System.Nullable<float> WellRecoveryRate { get; set; } = null;
        

        [JsonProperty("nominal_well_storage_volume")]
        public System.Nullable<float> NominalWellStorageVolume { get; set; } = null;
        

        [JsonProperty("water_table_depth_mode")]
        public WaterUse_Well_WaterTableDepthMode WaterTableDepthMode { get; set; } = (WaterUse_Well_WaterTableDepthMode)Enum.Parse(typeof(WaterUse_Well_WaterTableDepthMode), "Constant");
        

        [JsonProperty("water_table_depth")]
        public System.Nullable<float> WaterTableDepth { get; set; } = null;
        

        [JsonProperty("water_table_depth_schedule_name")]
        public string WaterTableDepthScheduleName { get; set; } = "";
    }
}