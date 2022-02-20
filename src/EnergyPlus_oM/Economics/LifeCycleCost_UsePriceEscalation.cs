using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description("Life cycle cost escalation factors. The values for this object may be found in th" +
                 "e annual supplement to NIST Handbook 135 in Tables Ca-1 to Ca-5 and are included" +
                 " in an EnergyPlus dataset file.")]
    [JsonObject("LifeCycleCost:UsePriceEscalation")]
    public class LifeCycleCost_UsePriceEscalation : BHoMObject
    {
        

        [Description(@"The identifier used for the object. The name usually identifies the location (such as the state or region or country or census area) that the escalations apply to. In addition the name should identify the building class such as residential or commercial or industrial and the use type such as electricity or natural gas or water.")]
        [JsonProperty("lcc_price_escalation_name")]
        public string LccPriceEscalationName { get; set; } = "";
        

        [JsonProperty("resource")]
        public EmptyNoYes Resource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("This field and the Escalation Start Month define the time that corresponds to Yea" +
                     "r 1 Escalation such as 2010 when the escalation rates are applied. This field an" +
                     "d the Escalation Start Month define the time that escalation begins.")]
        [JsonProperty("escalation_start_year")]
        public System.Nullable<float> EscalationStartYear { get; set; } = null;
        

        [Description("This field and the Escalation Start Year define the time that corresponds to Year" +
                     " 1 Escalation such as 2010 when the escalation rates are applied. This field and" +
                     " the Escalation Start Year define the time that escalation begins.")]
        [JsonProperty("escalation_start_month")]
        public EmptyNoYes EscalationStartMonth { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "January");
        

        [JsonProperty("escalations")]
        public string Escalations { get; set; } = "";
    }
}