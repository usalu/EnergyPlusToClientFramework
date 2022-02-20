using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.FluidProperties
{
    [Description("glycol and what concentration it is")]
    [JsonObject("FluidProperties:GlycolConcentration")]
    public class FluidProperties_GlycolConcentration : BHoMObject
    {
        

        [Description("or UserDefined Fluid (must show up as a glycol in FluidProperties:Name object)")]
        [JsonProperty("glycol_type")]
        public EmptyNoYes GlycolType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("user_defined_glycol_name")]
        public string UserDefinedGlycolName { get; set; } = "";
        

        [JsonProperty("glycol_concentration")]
        public System.Nullable<float> GlycolConcentration { get; set; } = null;
    }
}