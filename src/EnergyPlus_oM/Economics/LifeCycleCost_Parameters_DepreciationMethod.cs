namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum LifeCycleCost_Parameters_DepreciationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ModifiedAcceleratedCostRecoverySystem-10year")]
        ModifiedAcceleratedCostRecoverySystem10year = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ModifiedAcceleratedCostRecoverySystem-15year")]
        ModifiedAcceleratedCostRecoverySystem15year = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ModifiedAcceleratedCostRecoverySystem-20year")]
        ModifiedAcceleratedCostRecoverySystem20year = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ModifiedAcceleratedCostRecoverySystem-3year")]
        ModifiedAcceleratedCostRecoverySystem3year = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ModifiedAcceleratedCostRecoverySystem-5year")]
        ModifiedAcceleratedCostRecoverySystem5year = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="ModifiedAcceleratedCostRecoverySystem-7year")]
        ModifiedAcceleratedCostRecoverySystem7year = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="StraightLine-27year")]
        StraightLine27year = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="StraightLine-31year")]
        StraightLine31year = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="StraightLine-39year")]
        StraightLine39year = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="StraightLine-40year")]
        StraightLine40year = 11,
    }
}