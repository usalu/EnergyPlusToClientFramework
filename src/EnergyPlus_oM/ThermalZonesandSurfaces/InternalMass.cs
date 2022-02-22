using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description(@"Used to describe internal zone surface area that does not need to be part of geometric representation. This should be the total surface area exposed to the zone air. If you use a ZoneList in the Zone or ZoneList name field then this definition applies to all the zones in the ZoneList.")]
    [JsonObject("InternalMass")]
    public class InternalMass : BHoMObject, IEnergyPlusClass
    {
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [Description("Zone the surface is a part of used to be Interior Environment")]
        [JsonProperty("zone_or_zonelist_name")]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [JsonProperty("surface_area")]
        public System.Nullable<float> SurfaceArea { get; set; } = null;
    }
}