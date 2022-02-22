using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("used to define pillar geometry for support pillars")]
    public class WindowGap_SupportPillar : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("spacing")]
        public System.Nullable<float> Spacing { get; set; } = (System.Nullable<float>)Single.Parse("0.04", CultureInfo.InvariantCulture);
        

        [JsonProperty("radius")]
        public System.Nullable<float> Radius { get; set; } = (System.Nullable<float>)Single.Parse("0.0004", CultureInfo.InvariantCulture);
    }
}