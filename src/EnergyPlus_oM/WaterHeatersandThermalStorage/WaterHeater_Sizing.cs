using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    [Description("This input object is used with WaterHeater:Mixed or with WaterHeater:Stratified t" +
                 "o autosize tank volume and heater capacity This object is not needed if water he" +
                 "aters are not autosized.")]
    [JsonObject("WaterHeater:Sizing")]
    public class WaterHeater_Sizing : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("waterheater_name")]
        public string WaterheaterName { get; set; } = "";
        

        [JsonProperty("design_mode")]
        public WaterHeater_Sizing_DesignMode DesignMode { get; set; } = (WaterHeater_Sizing_DesignMode)Enum.Parse(typeof(WaterHeater_Sizing_DesignMode), "PeakDraw");
        

        [Description("Only used for Design Mode = PeakDraw")]
        [JsonProperty("time_storage_can_meet_peak_draw")]
        public System.Nullable<float> TimeStorageCanMeetPeakDraw { get; set; } = null;
        

        [Description("Only used for Design Mode = PeakDraw")]
        [JsonProperty("time_for_tank_recovery")]
        public System.Nullable<float> TimeForTankRecovery { get; set; } = null;
        

        [Description("Only used if Design Mode = PeakDraw and the water heater also has autosized flow " +
                     "rates for connections on the demand side of a plant loop")]
        [JsonProperty("nominal_tank_volume_for_autosizing_plant_connections")]
        public System.Nullable<float> NominalTankVolumeForAutosizingPlantConnections { get; set; } = null;
        

        [Description("Only used for Design Mode = ResidentialHUD-FHAMinimum")]
        [JsonProperty("number_of_bedrooms")]
        public System.Nullable<float> NumberOfBedrooms { get; set; } = null;
        

        [Description("Only used for Design Mode = ResidentialHUD-FHAMinimum")]
        [JsonProperty("number_of_bathrooms")]
        public System.Nullable<float> NumberOfBathrooms { get; set; } = null;
        

        [Description("Only used for Design Mode = PerPerson")]
        [JsonProperty("storage_capacity_per_person")]
        public System.Nullable<float> StorageCapacityPerPerson { get; set; } = null;
        

        [Description("Only used for Design Mode = PerPerson")]
        [JsonProperty("recovery_capacity_per_person")]
        public System.Nullable<float> RecoveryCapacityPerPerson { get; set; } = null;
        

        [Description("Only used for Design Mode = PerFloorArea")]
        [JsonProperty("storage_capacity_per_floor_area")]
        public System.Nullable<float> StorageCapacityPerFloorArea { get; set; } = null;
        

        [Description("Only used for Design Mode = PerFloorArea")]
        [JsonProperty("recovery_capacity_per_floor_area")]
        public System.Nullable<float> RecoveryCapacityPerFloorArea { get; set; } = null;
        

        [Description("Only used for Design Mode = PerUnit")]
        [JsonProperty("number_of_units")]
        public System.Nullable<float> NumberOfUnits { get; set; } = null;
        

        [Description("Only used for Design Mode = PerUnit")]
        [JsonProperty("storage_capacity_per_unit")]
        public System.Nullable<float> StorageCapacityPerUnit { get; set; } = null;
        

        [Description("Only used for Design Mode = PerUnit")]
        [JsonProperty("recovery_capacity_perunit")]
        public System.Nullable<float> RecoveryCapacityPerunit { get; set; } = null;
        

        [Description("Only used for Design Mode = PerSolarCollectorArea")]
        [JsonProperty("storage_capacity_per_collector_area")]
        public System.Nullable<float> StorageCapacityPerCollectorArea { get; set; } = null;
        

        [Description("only used if for WaterHeater:Stratified")]
        [JsonProperty("height_aspect_ratio")]
        public System.Nullable<float> HeightAspectRatio { get; set; } = null;
    }
}