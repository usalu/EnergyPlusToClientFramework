using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_WaterHeating_Desuperheater_TankObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("WaterHeater:Mixed")]
        WaterHeaterMixed = 1,
        
        [JsonProperty("WaterHeater:Stratified")]
        WaterHeaterStratified = 2,
    }
}