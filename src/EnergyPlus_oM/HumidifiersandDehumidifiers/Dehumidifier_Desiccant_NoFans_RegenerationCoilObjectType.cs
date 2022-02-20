using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers
{
    public enum Dehumidifier_Desiccant_NoFans_RegenerationCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 0,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 1,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 2,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 3,
    }
}