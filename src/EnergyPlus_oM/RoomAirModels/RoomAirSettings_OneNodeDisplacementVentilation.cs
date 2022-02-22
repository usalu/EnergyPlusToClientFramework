using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("The Mundt model for displacement ventilation")]
    public class RoomAirSettings_OneNodeDisplacementVentilation : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("fraction_of_convective_internal_loads_added_to_floor_air")]
        public System.Nullable<float> FractionOfConvectiveInternalLoadsAddedToFloorAir { get; set; } = null;
        

        [JsonProperty("fraction_of_infiltration_internal_loads_added_to_floor_air")]
        public System.Nullable<float> FractionOfInfiltrationInternalLoadsAddedToFloorAir { get; set; } = null;
    }
}