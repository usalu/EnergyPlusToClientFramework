using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("California Energy Commission tests and publishes data on inverters This inverter " +
                 "model interpolates using CEC test data Input data are at http://www.gosolarcalif" +
                 "ornia.org/equipment/inverter_tests/summaries")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricLoadCenter_Inverter_LookUpTable : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter name of zone to receive inverter losses as heat if blank then inverter is a" +
                     "ssumed to be outdoors")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("radiative_fraction")]
        public System.Nullable<float> RadiativeFraction { get; set; } = null;
        

        [JsonProperty("rated_maximum_continuous_output_power")]
        public System.Nullable<float> RatedMaximumContinuousOutputPower { get; set; } = null;
        

        [JsonProperty("night_tare_loss_power")]
        public System.Nullable<float> NightTareLossPower { get; set; } = null;
        

        [JsonProperty("nominal_voltage_input")]
        public System.Nullable<float> NominalVoltageInput { get; set; } = null;
        

        [JsonProperty("efficiency_at_10_power_and_nominal_voltage")]
        public System.Nullable<float> EfficiencyAt10PowerAndNominalVoltage { get; set; } = null;
        

        [JsonProperty("efficiency_at_20_power_and_nominal_voltage")]
        public System.Nullable<float> EfficiencyAt20PowerAndNominalVoltage { get; set; } = null;
        

        [JsonProperty("efficiency_at_30_power_and_nominal_voltage")]
        public System.Nullable<float> EfficiencyAt30PowerAndNominalVoltage { get; set; } = null;
        

        [JsonProperty("efficiency_at_50_power_and_nominal_voltage")]
        public System.Nullable<float> EfficiencyAt50PowerAndNominalVoltage { get; set; } = null;
        

        [JsonProperty("efficiency_at_75_power_and_nominal_voltage")]
        public System.Nullable<float> EfficiencyAt75PowerAndNominalVoltage { get; set; } = null;
        

        [JsonProperty("efficiency_at_100_power_and_nominal_voltage")]
        public System.Nullable<float> EfficiencyAt100PowerAndNominalVoltage { get; set; } = null;
    }
}