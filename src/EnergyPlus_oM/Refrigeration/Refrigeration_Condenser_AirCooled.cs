using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description("Air cooled condenser for a refrigeration system (Refrigeration:System).")]
    [JsonObject("Refrigeration:Condenser:AirCooled")]
    public class Refrigeration_Condenser_AirCooled : BHoMObject
    {
        

        [Description("Rating as per ARI 460 Be sure the rating corresponds to the correct refrigerant H" +
                     "eatRejection(W)=C1 +C2(Condensing Temp - Entering Air Temp, deg C) Will be adjus" +
                     "ted for elevation automatically")]
        [JsonProperty("rated_effective_total_heat_rejection_rate_curve_name")]
        public string RatedEffectiveTotalHeatRejectionRateCurveName { get; set; } = "";
        

        [Description("must correspond to rating given for total heat rejection effect")]
        [JsonProperty("rated_subcooling_temperature_difference")]
        public System.Nullable<float> RatedSubcoolingTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("condenser_fan_speed_control_type")]
        public EmptyNoYes CondenserFanSpeedControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Fixed");
        

        [Description("Power for condenser fan(s) corresponding to rated total heat rejection effect.")]
        [JsonProperty("rated_fan_power")]
        public System.Nullable<float> RatedFanPower { get; set; } = (System.Nullable<float>)Single.Parse("250", CultureInfo.InvariantCulture);
        

        [Description("Minimum air flow fraction through condenser fan")]
        [JsonProperty("minimum_fan_air_flow_ratio")]
        public System.Nullable<float> MinimumFanAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description(@"If field is left blank, then the model assumes that the inlet air conditions are the outdoor air conditions for the current timestep (e.g., no adjustment for height above ground). If the condenser rejects heat to a conditioned zone, enter the zone name here.")]
        [JsonProperty("air_inlet_node_name_or_zone_name")]
        public string AirInletNodeNameOrZoneName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
        

        [Description("optional input")]
        [JsonProperty("condenser_refrigerant_operating_charge_inventory")]
        public System.Nullable<float> CondenserRefrigerantOperatingChargeInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("optional input")]
        [JsonProperty("condensate_receiver_refrigerant_inventory")]
        public System.Nullable<float> CondensateReceiverRefrigerantInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("optional input")]
        [JsonProperty("condensate_piping_refrigerant_inventory")]
        public System.Nullable<float> CondensatePipingRefrigerantInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}