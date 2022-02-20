using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description(@"The object lists a series of computations that are used to perform the utility bill calculation. The object is only used for complex tariffs that cannot be modeled any other way. For most utility tariffs, UtilityCost:Computation is unnecessary and should be avoided. If UtilityCost:Computation is used, it must contain references to all objects involved in the rate in the order that they should be computed.")]
    [JsonObject("UtilityCost:Computation")]
    public class UtilityCost_Computation : BHoMObject
    {
        

        [Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Varia" +
                     "ble.")]
        [JsonProperty("tariff_name")]
        public string TariffName { get; set; } = "";
        

        [Description("Contain a simple language that describes the steps used in the computation proces" +
                     "s similar to a programming language.")]
        [JsonProperty("compute_step_1")]
        public string ComputeStep1 { get; set; } = "";
        

        [JsonProperty("compute_step_2")]
        public string ComputeStep2 { get; set; } = "";
        

        [JsonProperty("compute_step_3")]
        public string ComputeStep3 { get; set; } = "";
        

        [JsonProperty("compute_step_4")]
        public string ComputeStep4 { get; set; } = "";
        

        [JsonProperty("compute_step_5")]
        public string ComputeStep5 { get; set; } = "";
        

        [JsonProperty("compute_step_6")]
        public string ComputeStep6 { get; set; } = "";
        

        [JsonProperty("compute_step_7")]
        public string ComputeStep7 { get; set; } = "";
        

        [JsonProperty("compute_step_8")]
        public string ComputeStep8 { get; set; } = "";
        

        [JsonProperty("compute_step_9")]
        public string ComputeStep9 { get; set; } = "";
        

        [JsonProperty("compute_step_10")]
        public string ComputeStep10 { get; set; } = "";
        

        [JsonProperty("compute_step_11")]
        public string ComputeStep11 { get; set; } = "";
        

        [JsonProperty("compute_step_12")]
        public string ComputeStep12 { get; set; } = "";
        

        [JsonProperty("compute_step_13")]
        public string ComputeStep13 { get; set; } = "";
        

        [JsonProperty("compute_step_14")]
        public string ComputeStep14 { get; set; } = "";
        

        [JsonProperty("compute_step_15")]
        public string ComputeStep15 { get; set; } = "";
        

        [JsonProperty("compute_step_16")]
        public string ComputeStep16 { get; set; } = "";
        

        [JsonProperty("compute_step_17")]
        public string ComputeStep17 { get; set; } = "";
        

        [JsonProperty("compute_step_18")]
        public string ComputeStep18 { get; set; } = "";
        

        [JsonProperty("compute_step_19")]
        public string ComputeStep19 { get; set; } = "";
        

        [JsonProperty("compute_step_20")]
        public string ComputeStep20 { get; set; } = "";
        

        [JsonProperty("compute_step_21")]
        public string ComputeStep21 { get; set; } = "";
        

        [JsonProperty("compute_step_22")]
        public string ComputeStep22 { get; set; } = "";
        

        [JsonProperty("compute_step_23")]
        public string ComputeStep23 { get; set; } = "";
        

        [JsonProperty("compute_step_24")]
        public string ComputeStep24 { get; set; } = "";
        

        [JsonProperty("compute_step_25")]
        public string ComputeStep25 { get; set; } = "";
        

        [JsonProperty("compute_step_26")]
        public string ComputeStep26 { get; set; } = "";
        

        [JsonProperty("compute_step_27")]
        public string ComputeStep27 { get; set; } = "";
        

        [JsonProperty("compute_step_28")]
        public string ComputeStep28 { get; set; } = "";
        

        [JsonProperty("compute_step_29")]
        public string ComputeStep29 { get; set; } = "";
        

        [JsonProperty("compute_step_30")]
        public string ComputeStep30 { get; set; } = "";
    }
}