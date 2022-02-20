using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum Site_GroundDomain_Slab_SlabLocation
    {
        
        [JsonProperty("InGrade")]
        InGrade = 0,
        
        [JsonProperty("OnGrade")]
        OnGrade = 1,
    }
}