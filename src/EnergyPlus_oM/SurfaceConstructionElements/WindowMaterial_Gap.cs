using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Used to define the gap between two layers in a complex fenestration system, where the Construction:ComplexFenestrationState object is used. It is referenced as a layer in the Construction:ComplexFenestrationState object. It cannot be referenced as a layer from the Construction object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Gap : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("thickness")]
        public System.Nullable<float> Thickness { get; set; } = null;
        

        [Description("This field should reference only WindowMaterial:Gas or WindowMaterial:GasMixture " +
                     "objects")]
        [JsonProperty("gas_or_gas_mixture_")]
        public string GasOrGasMixture { get; set; } = "";
        

        [JsonProperty("pressure")]
        public System.Nullable<float> Pressure { get; set; } = (System.Nullable<float>)Single.Parse("101325", CultureInfo.InvariantCulture);
        

        [Description("If left blank, it will be considered that gap is not deflected")]
        [JsonProperty("deflection_state")]
        public string DeflectionState { get; set; } = "";
        

        [Description("If left blank, it will be considered that gap does not have support pillars")]
        [JsonProperty("support_pillar")]
        public string SupportPillar { get; set; } = "";
    }
}