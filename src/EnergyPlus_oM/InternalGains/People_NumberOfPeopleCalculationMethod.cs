using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum People_NumberOfPeopleCalculationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Area/Person")]
        AreaPerson = 1,
        
        [JsonProperty("People")]
        People = 2,
        
        [JsonProperty("People/Area")]
        PeopleArea = 3,
    }
}