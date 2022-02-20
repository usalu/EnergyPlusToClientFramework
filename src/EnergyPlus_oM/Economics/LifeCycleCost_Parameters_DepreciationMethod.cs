using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum LifeCycleCost_Parameters_DepreciationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ModifiedAcceleratedCostRecoverySystem-10year")]
        ModifiedAcceleratedCostRecoverySystem10year = 1,
        
        [JsonProperty("ModifiedAcceleratedCostRecoverySystem-15year")]
        ModifiedAcceleratedCostRecoverySystem15year = 2,
        
        [JsonProperty("ModifiedAcceleratedCostRecoverySystem-20year")]
        ModifiedAcceleratedCostRecoverySystem20year = 3,
        
        [JsonProperty("ModifiedAcceleratedCostRecoverySystem-3year")]
        ModifiedAcceleratedCostRecoverySystem3year = 4,
        
        [JsonProperty("ModifiedAcceleratedCostRecoverySystem-5year")]
        ModifiedAcceleratedCostRecoverySystem5year = 5,
        
        [JsonProperty("ModifiedAcceleratedCostRecoverySystem-7year")]
        ModifiedAcceleratedCostRecoverySystem7year = 6,
        
        [JsonProperty("None")]
        None = 7,
        
        [JsonProperty("StraightLine-27year")]
        StraightLine27year = 8,
        
        [JsonProperty("StraightLine-31year")]
        StraightLine31year = 9,
        
        [JsonProperty("StraightLine-39year")]
        StraightLine39year = 10,
        
        [JsonProperty("StraightLine-40year")]
        StraightLine40year = 11,
    }
}