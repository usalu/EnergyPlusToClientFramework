using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Gas mixtures that are used in Windows or Glass Doors")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_GasMixture : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("thickness")]
        public System.Nullable<float> Thickness { get; set; } = null;
        

        [JsonProperty("number_of_gases_in_mixture")]
        public System.Nullable<float> NumberOfGasesInMixture { get; set; } = null;
        

        [JsonProperty("gas_1_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_GasMixture_Gas1Type Gas1Type { get; set; } = (WindowMaterial_GasMixture_Gas1Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas1Type), "Air");
        

        [JsonProperty("gas_1_fraction")]
        public System.Nullable<float> Gas1Fraction { get; set; } = null;
        

        [JsonProperty("gas_2_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_GasMixture_Gas2Type Gas2Type { get; set; } = (WindowMaterial_GasMixture_Gas2Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas2Type), "Air");
        

        [JsonProperty("gas_2_fraction")]
        public System.Nullable<float> Gas2Fraction { get; set; } = null;
        

        [JsonProperty("gas_3_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_GasMixture_Gas3Type Gas3Type { get; set; } = (WindowMaterial_GasMixture_Gas3Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas3Type), "Air");
        

        [JsonProperty("gas_3_fraction")]
        public System.Nullable<float> Gas3Fraction { get; set; } = null;
        

        [JsonProperty("gas_4_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_GasMixture_Gas4Type Gas4Type { get; set; } = (WindowMaterial_GasMixture_Gas4Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas4Type), "Air");
        

        [JsonProperty("gas_4_fraction")]
        public System.Nullable<float> Gas4Fraction { get; set; } = null;
    }
}