using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_Unitary_Furnace_HeatCool_ReheatCoilObjectType
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
    }
}