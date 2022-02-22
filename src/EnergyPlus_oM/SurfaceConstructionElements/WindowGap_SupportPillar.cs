using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("used to define pillar geometry for support pillars")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowGap_SupportPillar : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("spacing")]
        public System.Nullable<float> Spacing { get; set; } = (System.Nullable<float>)Single.Parse("0.04", CultureInfo.InvariantCulture);
        

        [JsonProperty("radius")]
        public System.Nullable<float> Radius { get; set; } = (System.Nullable<float>)Single.Parse("0.0004", CultureInfo.InvariantCulture);
    }
}