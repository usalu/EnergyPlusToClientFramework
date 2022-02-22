using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Used to describe the electrical storage subsystem for a fuel cell power generator" +
                 ". The electrical storage model is a very simple \"constrained bucket\" model. Note" +
                 " that this electrical storage is embedded within the FC device.")]
    [JsonObject("Generator:FuelCell:ElectricalStorage")]
    public class Generator_FuelCell_ElectricalStorage : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("choice_of_model")]
        public Generator_FuelCell_ElectricalStorage_ChoiceOfModel ChoiceOfModel { get; set; } = (Generator_FuelCell_ElectricalStorage_ChoiceOfModel)Enum.Parse(typeof(Generator_FuelCell_ElectricalStorage_ChoiceOfModel), "SimpleEfficiencyWithConstraints");
        

        [JsonProperty("nominal_charging_energetic_efficiency")]
        public System.Nullable<float> NominalChargingEnergeticEfficiency { get; set; } = null;
        

        [JsonProperty("nominal_discharging_energetic_efficiency")]
        public System.Nullable<float> NominalDischargingEnergeticEfficiency { get; set; } = null;
        

        [JsonProperty("simple_maximum_capacity")]
        public System.Nullable<float> SimpleMaximumCapacity { get; set; } = null;
        

        [JsonProperty("simple_maximum_power_draw")]
        public System.Nullable<float> SimpleMaximumPowerDraw { get; set; } = null;
        

        [JsonProperty("simple_maximum_power_store")]
        public System.Nullable<float> SimpleMaximumPowerStore { get; set; } = null;
        

        [JsonProperty("initial_charge_state")]
        public System.Nullable<float> InitialChargeState { get; set; } = null;
    }
}