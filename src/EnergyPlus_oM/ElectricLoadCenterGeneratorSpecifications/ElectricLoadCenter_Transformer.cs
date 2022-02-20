using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("a list of meters that can be reported are available after a run on the meter dict" +
                 "ionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject("ElectricLoadCenter:Transformer")]
    public class ElectricLoadCenter_Transformer : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description(@"A transformer can be used to transfer electric energy from utility grid to building (PowerInFromGrid)or from building on-site generation to the grid (PowerOutToGrid) or within a load center to match generation to the facility service main panel (LoadCenterPowerConditioning)")]
        [JsonProperty("transformer_usage")]
        public EmptyNoYes TransformerUsage { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "PowerInFromGrid");
        

        [Description("Enter name of zone to receive transformer losses as heat if blank then transforme" +
                     "r losses are dissipated to outdoors")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("radiative_fraction")]
        public System.Nullable<float> RadiativeFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("the unit is VA, instead of kVA as usually shown on transformer nameplates.")]
        [JsonProperty("rated_capacity")]
        public System.Nullable<float> RatedCapacity { get; set; } = null;
        

        [Description("Must be single or three phase transformer. NOT used in the current model.")]
        [JsonProperty("phase")]
        public string Phase { get; set; } = (System.String)"3";
        

        [Description("Winding material used by the transformer.")]
        [JsonProperty("conductor_material")]
        public EmptyNoYes ConductorMaterial { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Aluminum");
        

        [JsonProperty("full_load_temperature_rise")]
        public System.Nullable<float> FullLoadTemperatureRise { get; set; } = (System.Nullable<float>)Single.Parse("150", CultureInfo.InvariantCulture);
        

        [JsonProperty("fraction_of_eddy_current_losses")]
        public System.Nullable<float> FractionOfEddyCurrentLosses { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description("User can define transformer performance by specifying load and no load losses at " +
                     "rated conditions or nameplate efficiency and maximum efficiency")]
        [JsonProperty("performance_input_method")]
        public EmptyNoYes PerformanceInputMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "RatedLosses");
        

        [Description("Only required when RatedLosses is the performance input method")]
        [JsonProperty("rated_no_load_loss")]
        public System.Nullable<float> RatedNoLoadLoss { get; set; } = null;
        

        [Description("Only required when RatedLosses is the performance input method")]
        [JsonProperty("rated_load_loss")]
        public System.Nullable<float> RatedLoadLoss { get; set; } = null;
        

        [Description("Only required when NominalEfficiency is the performance input method")]
        [JsonProperty("nameplate_efficiency")]
        public System.Nullable<float> NameplateEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.98", CultureInfo.InvariantCulture);
        

        [Description("Percentage of the rated capacity at which the nameplate efficiency is defined Onl" +
                     "y required when NominalEfficiency is the performance input method")]
        [JsonProperty("per_unit_load_for_nameplate_efficiency")]
        public System.Nullable<float> PerUnitLoadForNameplateEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.35", CultureInfo.InvariantCulture);
        

        [Description("Conductor operating temperature at which the nameplate efficiency is defined Only" +
                     " required when NominalEfficiency is the performance input method")]
        [JsonProperty("reference_temperature_for_nameplate_efficiency")]
        public System.Nullable<float> ReferenceTemperatureForNameplateEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("75", CultureInfo.InvariantCulture);
        

        [Description("Percentage of the rate capacity at which the maximum efficiency is obtained Only " +
                     "required when NominalEfficiency is the performance input method")]
        [JsonProperty("per_unit_load_for_maximum_efficiency")]
        public System.Nullable<float> PerUnitLoadForMaximumEfficiency { get; set; } = null;
        

        [Description("Only required when the transformer is used for power in from the utility grid")]
        [JsonProperty("consider_transformer_loss_for_utility_cost")]
        public EmptyNoYes ConsiderTransformerLossForUtilityCost { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("meters")]
        public string Meters { get; set; } = "";
    }
}