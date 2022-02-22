using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("This is used to allow the coordinate control of several radiant system surfaces. " +
                 "Note that the following flow fractions must sum up to 1.0 The number of surfaces" +
                 " can be expanded beyond 100, if necessary, by adding more groups to the end of t" +
                 "he list")]
    [JsonObject("ZoneHVAC:LowTemperatureRadiant:SurfaceGroup")]
    public class ZoneHVAC_LowTemperatureRadiant_SurfaceGroup : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("surface_fractions")]
        public string SurfaceFractions { get; set; } = "";
    }
}