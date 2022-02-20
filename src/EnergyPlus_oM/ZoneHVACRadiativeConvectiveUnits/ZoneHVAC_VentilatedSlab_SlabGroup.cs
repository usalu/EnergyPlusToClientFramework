using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("This is used to allow the coordinate control of several ventilated slab system su" +
                 "rfaces. Note that the flow fractions must sum up to 1.0. The number of surfaces " +
                 "can be expanded beyond 10, if necessary, by adding more groups to the end of the" +
                 " list")]
    [JsonObject("ZoneHVAC:VentilatedSlab:SlabGroup")]
    public class ZoneHVAC_VentilatedSlab_SlabGroup : BHoMObject
    {
        

        [JsonProperty("data")]
        public string Data { get; set; } = "";
    }
}