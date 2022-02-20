using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description(@"A cooltower (sometimes referred to as a wind tower or a shower cooling tower) models passive downdraught evaporative cooling (PDEC) that is designed to capture the wind at the top of a tower and cool the outdoor air using water evaporation before delivering it to a space.")]
    [JsonObject("ZoneCoolTower:Shower")]
    public class ZoneCoolTower_Shower : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("In case of stand alone tank or underground water, leave this input blank")]
        [JsonProperty("water_supply_storage_tank_name")]
        public string WaterSupplyStorageTankName { get; set; } = "";
        

        [Description("Water flow schedule should be selected when the water flow rate is known. Wind-dr" +
                     "iven flow should be selected when the water flow rate is unknown.")]
        [JsonProperty("flow_control_type")]
        public EmptyNoYes FlowControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "WindDrivenFlow");
        

        [JsonProperty("pump_flow_rate_schedule_name")]
        public string PumpFlowRateScheduleName { get; set; } = "";
        

        [JsonProperty("maximum_water_flow_rate")]
        public System.Nullable<float> MaximumWaterFlowRate { get; set; } = null;
        

        [Description("This field is from either the spray or the wet pad to the top of the outlet.")]
        [JsonProperty("effective_tower_height")]
        public System.Nullable<float> EffectiveTowerHeight { get; set; } = null;
        

        [Description("User have to specify effective area when outlet area is relatively bigger than th" +
                     "e cross sectional area of cooltower. If the number of outlet is more than one, a" +
                     "ssume the air passes through only one.")]
        [JsonProperty("airflow_outlet_area")]
        public System.Nullable<float> AirflowOutletArea { get; set; } = null;
        

        [JsonProperty("maximum_air_flow_rate")]
        public System.Nullable<float> MaximumAirFlowRate { get; set; } = null;
        

        [Description("This field is to specify the indoor temperature below which cooltower is shutoff." +
                     "")]
        [JsonProperty("minimum_indoor_temperature")]
        public System.Nullable<float> MinimumIndoorTemperature { get; set; } = null;
        

        [JsonProperty("fraction_of_water_loss")]
        public System.Nullable<float> FractionOfWaterLoss { get; set; } = null;
        

        [JsonProperty("fraction_of_flow_schedule")]
        public System.Nullable<float> FractionOfFlowSchedule { get; set; } = null;
        

        [JsonProperty("rated_power_consumption")]
        public System.Nullable<float> RatedPowerConsumption { get; set; } = null;
    }
}