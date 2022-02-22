using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HeatRecovery
{
    [Description("This object models an air-to-air heat exchanger using effectiveness relationships" +
                 ". The heat exchanger can transfer sensible energy, latent energy, or both betwee" +
                 "n the supply (primary) and exhaust (secondary) air streams.")]
    public class HeatExchanger_AirToAir_SensibleAndLatent : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("nominal_supply_air_flow_rate")]
        public string NominalSupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("sensible_effectiveness_at_100_heating_air_flow")]
        public System.Nullable<float> SensibleEffectivenessAt100HeatingAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("latent_effectiveness_at_100_heating_air_flow")]
        public System.Nullable<float> LatentEffectivenessAt100HeatingAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("sensible_effectiveness_at_75_heating_air_flow")]
        public System.Nullable<float> SensibleEffectivenessAt75HeatingAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("latent_effectiveness_at_75_heating_air_flow")]
        public System.Nullable<float> LatentEffectivenessAt75HeatingAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("sensible_effectiveness_at_100_cooling_air_flow")]
        public System.Nullable<float> SensibleEffectivenessAt100CoolingAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("latent_effectiveness_at_100_cooling_air_flow")]
        public System.Nullable<float> LatentEffectivenessAt100CoolingAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("sensible_effectiveness_at_75_cooling_air_flow")]
        public System.Nullable<float> SensibleEffectivenessAt75CoolingAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("latent_effectiveness_at_75_cooling_air_flow")]
        public System.Nullable<float> LatentEffectivenessAt75CoolingAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_air_inlet_node_name")]
        public string SupplyAirInletNodeName { get; set; } = "";
        

        [JsonProperty("supply_air_outlet_node_name")]
        public string SupplyAirOutletNodeName { get; set; } = "";
        

        [JsonProperty("exhaust_air_inlet_node_name")]
        public string ExhaustAirInletNodeName { get; set; } = "";
        

        [JsonProperty("exhaust_air_outlet_node_name")]
        public string ExhaustAirOutletNodeName { get; set; } = "";
        

        [JsonProperty("nominal_electric_power")]
        public System.Nullable<float> NominalElectricPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_air_outlet_temperature_control")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes SupplyAirOutletTemperatureControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("heat_exchanger_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatExchanger_AirToAir_SensibleAndLatent_HeatExchangerType HeatExchangerType { get; set; } = (HeatExchanger_AirToAir_SensibleAndLatent_HeatExchangerType)Enum.Parse(typeof(HeatExchanger_AirToAir_SensibleAndLatent_HeatExchangerType), "Plate");
        

        [JsonProperty("frost_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatExchanger_AirToAir_SensibleAndLatent_FrostControlType FrostControlType { get; set; } = (HeatExchanger_AirToAir_SensibleAndLatent_FrostControlType)Enum.Parse(typeof(HeatExchanger_AirToAir_SensibleAndLatent_FrostControlType), "None");
        

        [Description("Supply (outdoor) air inlet temp threshold for exhaust air recirculation and exhau" +
                     "st only frost control types. Exhaust air outlet threshold Temperature for minimu" +
                     "m exhaust temperature frost control type.")]
        [JsonProperty("threshold_temperature")]
        public System.Nullable<float> ThresholdTemperature { get; set; } = (System.Nullable<float>)Single.Parse("1.7", CultureInfo.InvariantCulture);
        

        [Description("Fraction of the time when frost control will be invoked at the threshold temperat" +
                     "ure. This field only used for exhaust air recirc and exhaust-only frost control " +
                     "types.")]
        [JsonProperty("initial_defrost_time_fraction")]
        public System.Nullable<float> InitialDefrostTimeFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.083", CultureInfo.InvariantCulture);
        

        [Description("Rate of increase in defrost time fraction as actual temp falls below threshold te" +
                     "mperature. This field only used for exhaust air recirc and exhaust-only frost co" +
                     "ntrol types.")]
        [JsonProperty("rate_of_defrost_time_fraction_increase")]
        public System.Nullable<float> RateOfDefrostTimeFractionIncrease { get; set; } = (System.Nullable<float>)Single.Parse("0.012", CultureInfo.InvariantCulture);
        

        [Description("Yes means that the heat exchanger will be locked out (off) when the economizer is" +
                     " operating or high humidity control is active")]
        [JsonProperty("economizer_lockout")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes EconomizerLockout { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
}