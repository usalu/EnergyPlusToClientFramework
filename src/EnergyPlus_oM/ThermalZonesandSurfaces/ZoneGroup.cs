using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Adds a multiplier to a ZoneList. This can be used to reduce the amount of input n" +
                 "ecessary for simulating repetitive structures, such as the identical floors of a" +
                 " multi-story building.")]
    [JsonObject("ZoneGroup")]
    public class ZoneGroup : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("zone_list_name")]
        public string ZoneListName { get; set; } = "";
        

        [JsonProperty("zone_list_multiplier")]
        public System.Nullable<float> ZoneListMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}