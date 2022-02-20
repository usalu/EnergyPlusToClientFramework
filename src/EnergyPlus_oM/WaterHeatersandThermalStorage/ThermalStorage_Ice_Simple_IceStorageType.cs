using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum ThermalStorage_Ice_Simple_IceStorageType
    {
        
        [JsonProperty("IceOnCoilExternal")]
        IceOnCoilExternal = 0,
        
        [JsonProperty("IceOnCoilInternal")]
        IceOnCoilInternal = 1,
    }
}