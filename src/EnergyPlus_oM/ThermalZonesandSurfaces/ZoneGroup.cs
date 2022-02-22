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
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneGroup : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("zone_list_name")]
        public string ZoneListName { get; set; } = "";
        

        [JsonProperty("zone_list_multiplier")]
        public System.Nullable<float> ZoneListMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}