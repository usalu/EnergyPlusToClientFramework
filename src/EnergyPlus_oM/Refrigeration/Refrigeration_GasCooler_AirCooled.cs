using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description("The transcritical refrigeration system requires a single gas cooler to reject the" +
                 " system heat.")]
    [JsonObject("Refrigeration:GasCooler:AirCooled")]
    public class Refrigeration_GasCooler_AirCooled : BHoMObject
    {
        

        [Description("Be sure the rating corresponds to the correct refrigerant (R744) HeatRejection(W)" +
                     "=C1 +C2(Gas Cooler Outlet Temp - Entering Air Temp, deg C) Will be adjusted for " +
                     "elevation automatically")]
        [JsonProperty("rated_total_heat_rejection_rate_curve_name")]
        public string RatedTotalHeatRejectionRateCurveName { get; set; } = "";
        

        [JsonProperty("gas_cooler_fan_speed_control_type")]
        public EmptyNoYes GasCoolerFanSpeedControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Fixed");
        

        [Description("Power for gas cooler fan(s) corresponding to rated total heat rejection effect.")]
        [JsonProperty("rated_fan_power")]
        public System.Nullable<float> RatedFanPower { get; set; } = (System.Nullable<float>)Single.Parse("5000", CultureInfo.InvariantCulture);
        

        [Description("Minimum air flow fraction through gas cooler fan")]
        [JsonProperty("minimum_fan_air_flow_ratio")]
        public System.Nullable<float> MinimumFanAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("Temperature at which system transitions between subcritical and transcritical ope" +
                     "ration.")]
        [JsonProperty("transition_temperature")]
        public System.Nullable<float> TransitionTemperature { get; set; } = (System.Nullable<float>)Single.Parse("27", CultureInfo.InvariantCulture);
        

        [Description("Temperature difference between the CO2 exiting the gas cooler and the air enterin" +
                     "g the gas cooler during transcritical operation.")]
        [JsonProperty("transcritical_approach_temperature")]
        public System.Nullable<float> TranscriticalApproachTemperature { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Temperature difference between the saturated condensing temperature and the air t" +
                     "emperature during subcritical operation.")]
        [JsonProperty("subcritical_temperature_difference")]
        public System.Nullable<float> SubcriticalTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Minimum saturated condensing temperature during subcritical operation.")]
        [JsonProperty("minimum_condensing_temperature")]
        public System.Nullable<float> MinimumCondensingTemperature { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("If field is left blank, then the model assumes that the inlet air conditions are " +
                     "the outdoor air conditions for the current timestep (e.g., no adjustment for hei" +
                     "ght above ground).")]
        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
        

        [Description("optional input")]
        [JsonProperty("gas_cooler_refrigerant_operating_charge_inventory")]
        public System.Nullable<float> GasCoolerRefrigerantOperatingChargeInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("optional input")]
        [JsonProperty("gas_cooler_receiver_refrigerant_inventory")]
        public System.Nullable<float> GasCoolerReceiverRefrigerantInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("optional input")]
        [JsonProperty("gas_cooler_outlet_piping_refrigerant_inventory")]
        public System.Nullable<float> GasCoolerOutletPipingRefrigerantInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}