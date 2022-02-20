using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Gas mixtures that are used in Windows or Glass Doors")]
    [JsonObject("WindowMaterial:GasMixture")]
    public class WindowMaterial_GasMixture : BHoMObject
    {
        

        [JsonProperty("thickness")]
        public System.Nullable<float> Thickness { get; set; } = null;
        

        [JsonProperty("number_of_gases_in_mixture")]
        public System.Nullable<float> NumberOfGasesInMixture { get; set; } = null;
        

        [JsonProperty("gas_1_type")]
        public EmptyNoYes Gas1Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("gas_1_fraction")]
        public System.Nullable<float> Gas1Fraction { get; set; } = null;
        

        [JsonProperty("gas_2_type")]
        public EmptyNoYes Gas2Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("gas_2_fraction")]
        public System.Nullable<float> Gas2Fraction { get; set; } = null;
        

        [JsonProperty("gas_3_type")]
        public EmptyNoYes Gas3Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("gas_3_fraction")]
        public System.Nullable<float> Gas3Fraction { get; set; } = null;
        

        [JsonProperty("gas_4_type")]
        public EmptyNoYes Gas4Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("gas_4_fraction")]
        public System.Nullable<float> Gas4Fraction { get; set; } = null;
    }
}