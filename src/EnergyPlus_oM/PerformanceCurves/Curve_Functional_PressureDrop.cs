using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description("Sets up curve information for minor loss and/or friction calculations in plant pr" +
                 "essure simulations Expression: DeltaP = {K + f*(L/D)} * (rho * V^2) / 2")]
    [JsonObject("Curve:Functional:PressureDrop")]
    public class Curve_Functional_PressureDrop : BHoMObject, IEnergyPlusClass
    {
        

        [Description("\"D\" in above expression, used to also calculate local velocity")]
        [JsonProperty("diameter")]
        public System.Nullable<float> Diameter { get; set; } = null;
        

        [Description("\"K\" in above expression")]
        [JsonProperty("minor_loss_coefficient")]
        public System.Nullable<float> MinorLossCoefficient { get; set; } = null;
        

        [Description("\"L\" in above expression")]
        [JsonProperty("length")]
        public System.Nullable<float> Length { get; set; } = null;
        

        [Description("This will be used to calculate \"f\" from Moody-chart approximations")]
        [JsonProperty("roughness")]
        public System.Nullable<float> Roughness { get; set; } = null;
        

        [Description("Optional way to set a constant value for \"f\", instead of using internal Moody-cha" +
                     "rt approximations")]
        [JsonProperty("fixed_friction_factor")]
        public System.Nullable<float> FixedFrictionFactor { get; set; } = null;
    }
}