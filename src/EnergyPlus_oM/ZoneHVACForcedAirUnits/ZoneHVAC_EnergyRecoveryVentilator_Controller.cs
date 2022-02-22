using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("This controller is used exclusively by the ZoneHVAC:EnergyRecoveryVentilator obje" +
                 "ct to allow economizer (free cooling) operation when possible.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_EnergyRecoveryVentilator_Controller : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the maximum outdoor dry-bulb temperature limit for economizer operation. No" +
                     " input or blank input means this limit is not operative")]
        [JsonProperty("temperature_high_limit")]
        public System.Nullable<float> TemperatureHighLimit { get; set; } = null;
        

        [Description("Enter the minimum outdoor dry-bulb temperature limit for economizer operation. No" +
                     " input or blank input means this limit is not operative")]
        [JsonProperty("temperature_low_limit")]
        public System.Nullable<float> TemperatureLowLimit { get; set; } = null;
        

        [Description("Enter the maximum outdoor enthalpy limit for economizer operation. No input or bl" +
                     "ank input means this limit is not operative")]
        [JsonProperty("enthalpy_high_limit")]
        public System.Nullable<float> EnthalpyHighLimit { get; set; } = null;
        

        [Description("Enter the maximum outdoor dew point temperature limit for economizer operation. N" +
                     "o input or blank input means this limit is not operative")]
        [JsonProperty("dewpoint_temperature_limit")]
        public System.Nullable<float> DewpointTemperatureLimit { get; set; } = null;
        

        [Description("Enter the name of a quadratic or cubic curve which defines the maximum outdoor hu" +
                     "midity ratio (function of outdoor dry-bulb temperature) for economizer operation" +
                     ". No input or blank input means this limit is not operative")]
        [JsonProperty("electronic_enthalpy_limit_curve_name")]
        public string ElectronicEnthalpyLimitCurveName { get; set; } = "";
        

        [JsonProperty("exhaust_air_temperature_limit")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirTemperatureLimit ExhaustAirTemperatureLimit { get; set; } = (ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirTemperatureLimit)Enum.Parse(typeof(ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirTemperatureLimit), "NoExhaustAirTemperatureLimit");
        

        [JsonProperty("exhaust_air_enthalpy_limit")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirEnthalpyLimit ExhaustAirEnthalpyLimit { get; set; } = (ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirEnthalpyLimit)Enum.Parse(typeof(ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirEnthalpyLimit), "NoExhaustAirEnthalpyLimit");
        

        [Description("Schedule values greater than 0 indicate economizer operation is active. This sche" +
                     "dule may be used with or without the High Humidity Control option. When used tog" +
                     "ether, high humidity control has priority over economizer control.")]
        [JsonProperty("time_of_day_economizer_flow_control_schedule_name")]
        public string TimeOfDayEconomizerFlowControlScheduleName { get; set; } = "";
        

        [Description("Select Yes to modify air flow rates based on a zone humidistat. Select No to disa" +
                     "ble this feature.")]
        [JsonProperty("high_humidity_control_flag")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes HighHumidityControlFlag { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Enter the name of the zone where the humidistat is located.")]
        [JsonProperty("humidistat_control_zone_name")]
        public string HumidistatControlZoneName { get; set; } = "";
        

        [Description("Enter the ratio of supply (outdoor) air to the maximum supply air flow rate when " +
                     "modified air flow rates are active based on high indoor humidity.")]
        [JsonProperty("high_humidity_outdoor_air_flow_ratio")]
        public System.Nullable<float> HighHumidityOutdoorAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"If NO is selected, the air flow rate is modified any time indoor relative humidity is above humidistat setpoint. If YES is selected, outdoor air flow rate is modified any time indoor relative humidity is above the humidistat setpoint AND the outdoor humidity ratio is less than the indoor humidity ratio.")]
        [JsonProperty("control_high_indoor_humidity_based_on_outdoor_humidity_ratio")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ControlHighIndoorHumidityBasedOnOutdoorHumidityRatio { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
}