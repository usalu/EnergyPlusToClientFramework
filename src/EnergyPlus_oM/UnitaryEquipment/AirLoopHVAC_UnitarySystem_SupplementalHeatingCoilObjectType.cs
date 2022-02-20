using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_SupplementalHeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Desuperheater")]
        CoilHeatingDesuperheater = 0,
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 1,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 2,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 3,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 4,
        
        [JsonProperty("Coil:UserDefined")]
        CoilUserDefined = 5,
    }
}