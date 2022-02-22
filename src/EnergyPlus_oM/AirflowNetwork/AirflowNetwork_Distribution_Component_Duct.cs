using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the relationship between pressure and air flow through the du" +
                 "ct.")]
    public class AirflowNetwork_Distribution_Component_Duct : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the length of the duct.")]
        [JsonProperty("duct_length")]
        public System.Nullable<float> DuctLength { get; set; } = null;
        

        [Description("Enter the hydraulic diameter of the duct. Hydraulic diameter is defined as 4 mult" +
                     "iplied by cross section area divided by perimeter")]
        [JsonProperty("hydraulic_diameter")]
        public System.Nullable<float> HydraulicDiameter { get; set; } = null;
        

        [Description("Enter the cross section area of the duct.")]
        [JsonProperty("cross_section_area")]
        public System.Nullable<float> CrossSectionArea { get; set; } = null;
        

        [Description("Enter the inside surface roughness of the duct.")]
        [JsonProperty("surface_roughness")]
        public System.Nullable<float> SurfaceRoughness { get; set; } = (System.Nullable<float>)Single.Parse("0.0009", CultureInfo.InvariantCulture);
        

        [Description("Enter the coefficient used to calculate dynamic losses of fittings (e.g. elbows)." +
                     "")]
        [JsonProperty("coefficient_for_local_dynamic_loss_due_to_fitting")]
        public System.Nullable<float> CoefficientForLocalDynamicLossDueToFitting { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("conduction only Default value of 0.943 is equivalent to 1.06 m2-K/W (R6) duct ins" +
                     "ulation.")]
        [JsonProperty("heat_transmittance_coefficient_u_factor_for_duct_wall_construction")]
        public System.Nullable<float> HeatTransmittanceCoefficientUFactorForDuctWallConstruction { get; set; } = (System.Nullable<float>)Single.Parse("0.943", CultureInfo.InvariantCulture);
        

        [Description("Enter the overall moisture transmittance coefficient including moisture film coef" +
                     "ficients at both surfaces.")]
        [JsonProperty("overall_moisture_transmittance_coefficient_from_air_to_air")]
        public System.Nullable<float> OverallMoistureTransmittanceCoefficientFromAirToAir { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("optional. convection coefficient calculated automatically, unless specified")]
        [JsonProperty("outside_convection_coefficient")]
        public System.Nullable<float> OutsideConvectionCoefficient { get; set; } = null;
        

        [Description("optional. convection coefficient calculated automatically, unless specified")]
        [JsonProperty("inside_convection_coefficient")]
        public System.Nullable<float> InsideConvectionCoefficient { get; set; } = null;
    }
}