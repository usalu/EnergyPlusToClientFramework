using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"Cascade condenser for a refrigeration system (Refrigeration:System). The cascade condenser is unlike the other condenser options because it rejects heat to another, higher-temperature, refrigeration system. That is, the cascade condenser acts as a heat rejection object for one system, but acts as a refrigeration load for another system.")]
    [JsonObject("Refrigeration:Condenser:Cascade")]
    public class Refrigeration_Condenser_Cascade : BHoMObject
    {
        

        [Description("This is the condensing temperature for the lower temperature secondary loop")]
        [JsonProperty("rated_condensing_temperature")]
        public System.Nullable<float> RatedCondensingTemperature { get; set; } = null;
        

        [Description("This is the difference between the condensing and evaporating temperatures")]
        [JsonProperty("rated_approach_temperature_difference")]
        public System.Nullable<float> RatedApproachTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("used for identification and rough system size error checking")]
        [JsonProperty("rated_effective_total_heat_rejection_rate")]
        public System.Nullable<float> RatedEffectiveTotalHeatRejectionRate { get; set; } = null;
        

        [Description("Fixed keeps condensing temperature constant Float sets the condensing temperature" +
                     " according to the other loads on the higher temperature system")]
        [JsonProperty("condensing_temperature_control_type")]
        public EmptyNoYes CondensingTemperatureControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Fixed");
        

        [Description("optional input")]
        [JsonProperty("condenser_refrigerant_operating_charge_inventory")]
        public System.Nullable<float> CondenserRefrigerantOperatingChargeInventory { get; set; } = null;
        

        [Description("optional input")]
        [JsonProperty("condensate_receiver_refrigerant_inventory")]
        public System.Nullable<float> CondensateReceiverRefrigerantInventory { get; set; } = null;
        

        [Description("optional input")]
        [JsonProperty("condensate_piping_refrigerant_inventory")]
        public System.Nullable<float> CondensatePipingRefrigerantInventory { get; set; } = null;
    }
}