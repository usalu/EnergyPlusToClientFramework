using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description("Evaporative-cooled condenser for a refrigeration system (Refrigeration:System).")]
    [JsonObject("Refrigeration:Condenser:EvaporativeCooled")]
    public class Refrigeration_Condenser_EvaporativeCooled : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Rating as per ARI 490 Be sure the rating corresponds to the correct refrigerant")]
        [JsonProperty("rated_effective_total_heat_rejection_rate")]
        public System.Nullable<float> RatedEffectiveTotalHeatRejectionRate { get; set; } = null;
        

        [Description("must correspond to rating given for total heat rejection effect")]
        [JsonProperty("rated_subcooling_temperature_difference")]
        public System.Nullable<float> RatedSubcoolingTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("fan_speed_control_type")]
        public Refrigeration_Condenser_EvaporativeCooled_FanSpeedControlType FanSpeedControlType { get; set; } = (Refrigeration_Condenser_EvaporativeCooled_FanSpeedControlType)Enum.Parse(typeof(Refrigeration_Condenser_EvaporativeCooled_FanSpeedControlType), "Fixed");
        

        [Description("Power for condenser fan(s) corresponding to rated total heat rejection effect.")]
        [JsonProperty("rated_fan_power")]
        public System.Nullable<float> RatedFanPower { get; set; } = null;
        

        [Description("Minimum air flow fraction through condenser fan")]
        [JsonProperty("minimum_fan_air_flow_ratio")]
        public System.Nullable<float> MinimumFanAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("A1 in delta T = A1 + A2(hrcf) + A3/(hrcf) + A4(Twb)")]
        [JsonProperty("approach_temperature_constant_term")]
        public System.Nullable<float> ApproachTemperatureConstantTerm { get; set; } = (System.Nullable<float>)Single.Parse("6.63", CultureInfo.InvariantCulture);
        

        [Description("A2 in delta T = A1 + A2(hrcf) +A3/(hrcf) +A4(Twb)")]
        [JsonProperty("approach_temperature_coefficient_2")]
        public System.Nullable<float> ApproachTemperatureCoefficient2 { get; set; } = (System.Nullable<float>)Single.Parse("0.468", CultureInfo.InvariantCulture);
        

        [Description("A3 in delta T = A1 + A2(hrcf) +A3/(hrcf) +A4(Twb)")]
        [JsonProperty("approach_temperature_coefficient_3")]
        public System.Nullable<float> ApproachTemperatureCoefficient3 { get; set; } = (System.Nullable<float>)Single.Parse("17.93", CultureInfo.InvariantCulture);
        

        [Description("A4 in deltaT=A1 + A2(hrcf) +A3/(hrcf) +A4(Twb)")]
        [JsonProperty("approach_temperature_coefficient_4")]
        public System.Nullable<float> ApproachTemperatureCoefficient4 { get; set; } = (System.Nullable<float>)Single.Parse("-0.322", CultureInfo.InvariantCulture);
        

        [Description("taken from manufacturer\'s Heat Rejection Capacity Factor Table")]
        [JsonProperty("minimum_capacity_factor")]
        public System.Nullable<float> MinimumCapacityFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("taken from manufacturer\'s Heat Rejection Capacity Factor Table")]
        [JsonProperty("maximum_capacity_factor")]
        public System.Nullable<float> MaximumCapacityFactor { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("If field is left blank, then the model assumes that the inlet air conditions are " +
                     "the outdoor air conditions for the current timestep (e.g., no adjustment for hei" +
                     "ght above ground).")]
        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Used to calculate evaporative condenser water use and fan energy use.")]
        [JsonProperty("rated_air_flow_rate")]
        public string RatedAirFlowRate { get; set; } = (System.String)"Autocalculate";
        

        [Description(@"This field is only used for periods when the evap condenser is available (field Evaporative Condenser Availability Schedule). For this situation, the heater heats the basin water when the outdoor air dry-bulb temperature falls below the set point temperature, but only when the condenser fans are off (i.e., no refrigerated case load).")]
        [JsonProperty("basin_heater_capacity")]
        public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("200", CultureInfo.InvariantCulture);
        

        [Description("Enter the outdoor dry-bulb temperature at which the basin heater turns on.")]
        [JsonProperty("basin_heater_setpoint_temperature")]
        public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Design recirculating water pump power.")]
        [JsonProperty("rated_water_pump_power")]
        public string RatedWaterPumpPower { get; set; } = (System.String)"1000";
        

        [Description("If blank, water supply is from Mains.")]
        [JsonProperty("evaporative_water_supply_tank_name")]
        public string EvaporativeWaterSupplyTankName { get; set; } = "";
        

        [Description(@"Schedule values greater than 0 indicate that evaporative cooling of the condenser is available. This schedule allows the user to define seasonal shutdown/draining of the water cooling system in cold climate applications. For periods with schedule values of 0, the condenser operates as Air Cooled.")]
        [JsonProperty("evaporative_condenser_availability_schedule_name")]
        public string EvaporativeCondenserAvailabilityScheduleName { get; set; } = "";
        

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