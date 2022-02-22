using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.FluidProperties
{
    [Description("glycol and what concentration it is")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FluidProperties_GlycolConcentration : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("or UserDefined Fluid (must show up as a glycol in FluidProperties:Name object)")]
        [JsonProperty("glycol_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FluidProperties_GlycolConcentration_GlycolType GlycolType { get; set; } = (FluidProperties_GlycolConcentration_GlycolType)Enum.Parse(typeof(FluidProperties_GlycolConcentration_GlycolType), "EthyleneGlycol");
        

        [JsonProperty("user_defined_glycol_name")]
        public string UserDefinedGlycolName { get; set; } = "";
        

        [JsonProperty("glycol_concentration")]
        public System.Nullable<float> GlycolConcentration { get; set; } = null;
    }
}