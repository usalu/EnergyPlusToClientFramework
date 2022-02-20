using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    public enum EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint
    {
        
        [JsonProperty("AfterComponentInputReadIn")]
        AfterComponentInputReadIn = 0,
        
        [JsonProperty("AfterNewEnvironmentWarmUpIsComplete")]
        AfterNewEnvironmentWarmUpIsComplete = 1,
        
        [JsonProperty("AfterPredictorAfterHVACManagers")]
        AfterPredictorAfterHVACManagers = 2,
        
        [JsonProperty("AfterPredictorBeforeHVACManagers")]
        AfterPredictorBeforeHVACManagers = 3,
        
        [JsonProperty("BeginNewEnvironment")]
        BeginNewEnvironment = 4,
        
        [JsonProperty("BeginTimestepBeforePredictor")]
        BeginTimestepBeforePredictor = 5,
        
        [JsonProperty("BeginZoneTimestepAfterInitHeatBalance")]
        BeginZoneTimestepAfterInitHeatBalance = 6,
        
        [JsonProperty("BeginZoneTimestepBeforeInitHeatBalance")]
        BeginZoneTimestepBeforeInitHeatBalance = 7,
        
        [JsonProperty("BeginZoneTimestepBeforeSetCurrentWeather")]
        BeginZoneTimestepBeforeSetCurrentWeather = 8,
        
        [JsonProperty("EndOfSystemSizing")]
        EndOfSystemSizing = 9,
        
        [JsonProperty("EndOfSystemTimestepAfterHVACReporting")]
        EndOfSystemTimestepAfterHVACReporting = 10,
        
        [JsonProperty("EndOfSystemTimestepBeforeHVACReporting")]
        EndOfSystemTimestepBeforeHVACReporting = 11,
        
        [JsonProperty("EndOfZoneSizing")]
        EndOfZoneSizing = 12,
        
        [JsonProperty("EndOfZoneTimestepAfterZoneReporting")]
        EndOfZoneTimestepAfterZoneReporting = 13,
        
        [JsonProperty("EndOfZoneTimestepBeforeZoneReporting")]
        EndOfZoneTimestepBeforeZoneReporting = 14,
        
        [JsonProperty("InsideHVACSystemIterationLoop")]
        InsideHVACSystemIterationLoop = 15,
        
        [JsonProperty("UnitarySystemSizing")]
        UnitarySystemSizing = 16,
        
        [JsonProperty("UserDefinedComponentModel")]
        UserDefinedComponentModel = 17,
    }
}