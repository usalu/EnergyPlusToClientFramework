using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Additional properties for temperature dependent thermal conductivity and enthalpy for Phase Change Materials (PCM) with separate melting and freezing curves. HeatBalanceAlgorithm = CondFD (ConductionFiniteDifference) solution algorithm only. Constructions with this should use the detailed CondFD process. Has no effect with other HeatBalanceAlgorithm solution algorithms.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_PhaseChangeHysteresis : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("The total latent heat absorbed or rejected during the transition from solid to li" +
                     "quid, or back")]
        [JsonProperty("latent_heat_during_the_entire_phase_change_process")]
        public System.Nullable<float> LatentHeatDuringTheEntirePhaseChangeProcess { get; set; } = null;
        

        [Description("The thermal conductivity used by this material when the material is fully liquid")]
        [JsonProperty("liquid_state_thermal_conductivity")]
        public System.Nullable<float> LiquidStateThermalConductivity { get; set; } = null;
        

        [Description("The density used by this material when the material is fully liquid")]
        [JsonProperty("liquid_state_density")]
        public System.Nullable<float> LiquidStateDensity { get; set; } = null;
        

        [Description("The constant specific heat used for the fully melted (liquid) state")]
        [JsonProperty("liquid_state_specific_heat")]
        public System.Nullable<float> LiquidStateSpecificHeat { get; set; } = null;
        

        [Description("The total melting range of the material is the sum of low and high temperature di" +
                     "fference of melting curve.")]
        [JsonProperty("high_temperature_difference_of_melting_curve")]
        public System.Nullable<float> HighTemperatureDifferenceOfMeltingCurve { get; set; } = null;
        

        [Description("The temperature at which the melting curve peaks")]
        [JsonProperty("peak_melting_temperature")]
        public System.Nullable<float> PeakMeltingTemperature { get; set; } = null;
        

        [Description("The total melting range of the material is the sum of low and high temperature di" +
                     "fference of melting curve.")]
        [JsonProperty("low_temperature_difference_of_melting_curve")]
        public System.Nullable<float> LowTemperatureDifferenceOfMeltingCurve { get; set; } = null;
        

        [Description("The thermal conductivity used by this material when the material is fully solid")]
        [JsonProperty("solid_state_thermal_conductivity")]
        public System.Nullable<float> SolidStateThermalConductivity { get; set; } = null;
        

        [Description("The density used by this material when the material is fully solid")]
        [JsonProperty("solid_state_density")]
        public System.Nullable<float> SolidStateDensity { get; set; } = null;
        

        [Description("The constant specific heat used for the fully frozen (crystallized) state")]
        [JsonProperty("solid_state_specific_heat")]
        public System.Nullable<float> SolidStateSpecificHeat { get; set; } = null;
        

        [Description("The total freezing range of the material is the sum of low and high temperature d" +
                     "ifference of freezing curve.")]
        [JsonProperty("high_temperature_difference_of_freezing_curve")]
        public System.Nullable<float> HighTemperatureDifferenceOfFreezingCurve { get; set; } = null;
        

        [Description("The temperature at which the freezing curve peaks")]
        [JsonProperty("peak_freezing_temperature")]
        public System.Nullable<float> PeakFreezingTemperature { get; set; } = null;
        

        [Description("The total freezing range of the material is the sum of low and high temperature d" +
                     "ifference of freezing curve.")]
        [JsonProperty("low_temperature_difference_of_freezing_curve")]
        public System.Nullable<float> LowTemperatureDifferenceOfFreezingCurve { get; set; } = null;
    }
}