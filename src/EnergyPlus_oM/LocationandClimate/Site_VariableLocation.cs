using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Captures the scheduling of a moving/reorienting building, or more likely a vessel" +
                 "")]
    public class Site_VariableLocation : BHoMObject, IEnergyPlusClass
    {
        

        [Description("The name of a schedule that defines the latitude of the building at any time. If " +
                     "not entered, the latitude defined in the Site:Location, or the default latitude," +
                     " will be used for the entirety of the simulation")]
        [JsonProperty("building_location_latitude_schedule")]
        public string BuildingLocationLatitudeSchedule { get; set; } = "";
        

        [Description("The name of a schedule that defines the longitude of the building at any time. If" +
                     " not entered, the longitude defined in the Site:Location, or the default longitu" +
                     "de, will be used for the entirety of the simulation")]
        [JsonProperty("building_location_longitude_schedule")]
        public string BuildingLocationLongitudeSchedule { get; set; } = "";
        

        [Description(@"The name of a schedule that defines the orientation of the building at any time. This orientation is based on a change from the original orientation. -- NEED TO REFINE THIS If not entered, the original orientation will be used for the entirety of the simulation")]
        [JsonProperty("building_location_orientation_schedule")]
        public string BuildingLocationOrientationSchedule { get; set; } = "";
    }
}