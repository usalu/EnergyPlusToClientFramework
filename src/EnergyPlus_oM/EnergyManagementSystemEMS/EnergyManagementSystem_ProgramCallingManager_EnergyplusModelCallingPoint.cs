namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    public enum EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AfterComponentInputReadIn")]
        AfterComponentInputReadIn = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AfterNewEnvironmentWarmUpIsComplete")]
        AfterNewEnvironmentWarmUpIsComplete = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AfterPredictorAfterHVACManagers")]
        AfterPredictorAfterHVACManagers = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="AfterPredictorBeforeHVACManagers")]
        AfterPredictorBeforeHVACManagers = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="BeginNewEnvironment")]
        BeginNewEnvironment = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="BeginTimestepBeforePredictor")]
        BeginTimestepBeforePredictor = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="BeginZoneTimestepAfterInitHeatBalance")]
        BeginZoneTimestepAfterInitHeatBalance = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="BeginZoneTimestepBeforeInitHeatBalance")]
        BeginZoneTimestepBeforeInitHeatBalance = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="BeginZoneTimestepBeforeSetCurrentWeather")]
        BeginZoneTimestepBeforeSetCurrentWeather = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="EndOfSystemSizing")]
        EndOfSystemSizing = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="EndOfSystemTimestepAfterHVACReporting")]
        EndOfSystemTimestepAfterHVACReporting = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="EndOfSystemTimestepBeforeHVACReporting")]
        EndOfSystemTimestepBeforeHVACReporting = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="EndOfZoneSizing")]
        EndOfZoneSizing = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="EndOfZoneTimestepAfterZoneReporting")]
        EndOfZoneTimestepAfterZoneReporting = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="EndOfZoneTimestepBeforeZoneReporting")]
        EndOfZoneTimestepBeforeZoneReporting = 14,
        
        [System.Runtime.Serialization.EnumMember(Value="InsideHVACSystemIterationLoop")]
        InsideHVACSystemIterationLoop = 15,
        
        [System.Runtime.Serialization.EnumMember(Value="UnitarySystemSizing")]
        UnitarySystemSizing = 16,
        
        [System.Runtime.Serialization.EnumMember(Value="UserDefinedComponentModel")]
        UserDefinedComponentModel = 17,
    }
}