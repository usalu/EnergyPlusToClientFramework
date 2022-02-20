using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    public enum AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:Water")]
        CoilCoolingWater = 0,
        
        [JsonProperty("Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 1,
    }
}