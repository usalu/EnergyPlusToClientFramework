using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Electric power inverter to convert from direct current (DC) to alternating curren" +
                 "t (AC) in an electric load center that contains photovoltaic modules. This input" +
                 " object is for an inverter model where efficiency is a function of normalized po" +
                 "wer.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricLoadCenter_Inverter_FunctionOfPower : BHoMObject, IEnergyPlusNode
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
        

        [Description("curve describes efficiency as a function of power curve is normalized relative to" +
                     " rated power in next field")]
        [JsonProperty("efficiency_function_of_power_curve_name")]
        public string EfficiencyFunctionOfPowerCurveName { get; set; } = "";
        

        [JsonProperty("rated_maximum_continuous_input_power")]
        public System.Nullable<float> RatedMaximumContinuousInputPower { get; set; } = null;
        

        [JsonProperty("minimum_efficiency")]
        public System.Nullable<float> MinimumEfficiency { get; set; } = null;
        

        [JsonProperty("maximum_efficiency")]
        public System.Nullable<float> MaximumEfficiency { get; set; } = null;
        

        [JsonProperty("minimum_power_output")]
        public System.Nullable<float> MinimumPowerOutput { get; set; } = null;
        

        [JsonProperty("maximum_power_output")]
        public System.Nullable<float> MaximumPowerOutput { get; set; } = null;
        

        [JsonProperty("ancillary_power_consumed_in_standby")]
        public System.Nullable<float> AncillaryPowerConsumedInStandby { get; set; } = null;
    }
}