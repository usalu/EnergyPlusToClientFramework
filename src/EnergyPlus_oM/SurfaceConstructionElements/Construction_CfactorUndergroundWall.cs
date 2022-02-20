using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Alternate method of describing underground wall constructions")]
    [JsonObject("Construction:CfactorUndergroundWall")]
    public class Construction_CfactorUndergroundWall : BHoMObject
    {
        

        [Description("Enter C-Factor without film coefficients or soil")]
        [JsonProperty("c_factor")]
        public System.Nullable<float> CFactor { get; set; } = null;
        

        [Description("Enter height of the underground wall")]
        [JsonProperty("height")]
        public System.Nullable<float> Height { get; set; } = null;
    }
}