using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_MultiZone_Component_DetailedOpening_TypeOfRectangularLargeVerticalOpeningLvo
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("HorizontallyPivoted")]
        HorizontallyPivoted = 1,
        
        [JsonProperty("NonPivoted")]
        NonPivoted = 2,
    }
}