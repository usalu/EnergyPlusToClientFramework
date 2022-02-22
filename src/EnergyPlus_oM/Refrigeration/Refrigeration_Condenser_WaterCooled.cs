using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description("Water cooled condenser for a refrigeration system (Refrigeration:System).")]
    public class Refrigeration_Condenser_WaterCooled : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Rating as per ARI 450 Be sure the rating corresponds to the correct refrigerant n" +
                     "ot used in calculations, only for identification and output")]
        [JsonProperty("rated_effective_total_heat_rejection_rate")]
        public System.Nullable<float> RatedEffectiveTotalHeatRejectionRate { get; set; } = null;
        

        [Description("must correspond to rating given for total heat rejection effect")]
        [JsonProperty("rated_condensing_temperature")]
        public System.Nullable<float> RatedCondensingTemperature { get; set; } = null;
        

        [Description("must correspond to rating given for total heat rejection effect")]
        [JsonProperty("rated_subcooling_temperature_difference")]
        public System.Nullable<float> RatedSubcoolingTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("must correspond to rating given for total heat rejection effect")]
        [JsonProperty("rated_water_inlet_temperature")]
        public System.Nullable<float> RatedWaterInletTemperature { get; set; } = null;
        

        [JsonProperty("water_inlet_node_name")]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty("water_outlet_node_name")]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("water_cooled_loop_flow_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_Condenser_WaterCooled_WaterCooledLoopFlowType WaterCooledLoopFlowType { get; set; } = (Refrigeration_Condenser_WaterCooled_WaterCooledLoopFlowType)Enum.Parse(typeof(Refrigeration_Condenser_WaterCooled_WaterCooledLoopFlowType), "VariableFlow");
        

        [Description("Applicable only when loop flow type is Variable Flow.")]
        [JsonProperty("water_outlet_temperature_schedule_name")]
        public string WaterOutletTemperatureScheduleName { get; set; } = "";
        

        [Description("note required units must be converted from L/s as specified in ARI 450-2007 Appli" +
                     "cable only when loop flow type is Constant Flow.")]
        [JsonProperty("water_design_flow_rate")]
        public System.Nullable<float> WaterDesignFlowRate { get; set; } = null;
        

        [JsonProperty("water_maximum_flow_rate")]
        public System.Nullable<float> WaterMaximumFlowRate { get; set; } = null;
        

        [JsonProperty("water_maximum_water_outlet_temperature")]
        public System.Nullable<float> WaterMaximumWaterOutletTemperature { get; set; } = (System.Nullable<float>)Single.Parse("55", CultureInfo.InvariantCulture);
        

        [Description("related to the minimum allowed refrigeration system condensing temperature")]
        [JsonProperty("water_minimum_water_inlet_temperature")]
        public System.Nullable<float> WaterMinimumWaterInletTemperature { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
        

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