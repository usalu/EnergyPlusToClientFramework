using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("This model is based on Merkel\'s theory, which is also the basis for the cooling t" +
                 "ower model in EnergyPlus. The Evaporative fluid cooler is modeled as a counter f" +
                 "low heat exchanger.")]
    [JsonObject("EvaporativeFluidCooler:SingleSpeed")]
    public class EvaporativeFluidCooler_SingleSpeed : BHoMObject
    {
        

        [Description("Name of Fluid Cooler water inlet node")]
        [JsonProperty("water_inlet_node_name")]
        public string WaterInletNodeName { get; set; } = "";
        

        [Description("Name of Fluid Cooler water outlet node")]
        [JsonProperty("water_outlet_node_name")]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("design_air_flow_rate")]
        public string DesignAirFlowRate { get; set; } = "";
        

        [Description("This is the fan motor electric input power")]
        [JsonProperty("design_air_flow_rate_fan_power")]
        public string DesignAirFlowRateFanPower { get; set; } = "";
        

        [JsonProperty("design_spray_water_flow_rate")]
        public System.Nullable<float> DesignSprayWaterFlowRate { get; set; } = null;
        

        [Description("User can define fluid cooler thermal performance by specifying the fluid cooler U" +
                     "A and the Design Water Flow Rate, or by specifying the fluid cooler Standard Des" +
                     "ign Capacity or by specifying Design Capacity for Non standard conditions.")]
        [JsonProperty("performance_input_method")]
        public EmptyNoYes PerformanceInputMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Enter the name of an outdoor air node")]
        [JsonProperty("outdoor_air_inlet_node_name")]
        public string OutdoorAirInletNodeName { get; set; } = "";
        

        [JsonProperty("heat_rejection_capacity_and_nominal_capacity_sizing_ratio")]
        public System.Nullable<float> HeatRejectionCapacityAndNominalCapacitySizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description(@"Standard design capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt (3 gpm/ton). Standard design capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25) gives the actual fluid cooler heat rejection at these operating conditions. Only used for Performance Input Method = StandardDesignCapacity; for other input methods, this field is ignored. The standard conditions mentioned above for Standard design capacity are already specified in the EnergyPlus. So the input fields such as design entering water temp., design entering air wet-bulb and dry-bulb temp. and design water flow rate, if provided in the input, will be ignored for the StandardDesignCapacity performance input method. Also, the standard conditions are for water as a fluid type so this performance input method can only be used with water as a fluid type (as specified in CondenserLoop object).")]
        [JsonProperty("standard_design_capacity")]
        public System.Nullable<float> StandardDesignCapacity { get; set; } = null;
        

        [Description("Only used for Performance Input Method = UFactorTimesAreaAndDesignWaterFlowRate; " +
                     "for other Performance Input Methods, this field is ignored.")]
        [JsonProperty("design_air_flow_rate_u_factor_times_area_value")]
        public string DesignAirFlowRateUFactorTimesAreaValue { get; set; } = "";
        

        [Description("Input value is ignored if fluid cooler Performance Input Method= StandardDesignCa" +
                     "pacity.")]
        [JsonProperty("design_water_flow_rate")]
        public string DesignWaterFlowRate { get; set; } = "";
        

        [Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
                     "erformance Input Methods, this field is ignored.")]
        [JsonProperty("user_specified_design_capacity")]
        public System.Nullable<float> UserSpecifiedDesignCapacity { get; set; } = null;
        

        [Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
                     "erformance Input Methods, this field is ignored. Design Entering Water Temperatu" +
                     "re must be greater than Design Entering Air Temperature.")]
        [JsonProperty("design_entering_water_temperature")]
        public System.Nullable<float> DesignEnteringWaterTemperature { get; set; } = null;
        

        [Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
                     "erformance Input Methods, this field is ignored. Design Entering Air Temperature" +
                     " must be greater than Design Entering Air Wet-bulb Temperature.")]
        [JsonProperty("design_entering_air_temperature")]
        public System.Nullable<float> DesignEnteringAirTemperature { get; set; } = null;
        

        [Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
                     "erformance Input Methods, this field is ignored. Design Entering Air Wet-bulb Te" +
                     "mperature must be less than Design Entering Air Temperature.")]
        [JsonProperty("design_entering_air_wet_bulb_temperature")]
        public System.Nullable<float> DesignEnteringAirWetBulbTemperature { get; set; } = null;
        

        [JsonProperty("capacity_control")]
        public EmptyNoYes CapacityControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "FanCycling");
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("evaporation_loss_mode")]
        public EmptyNoYes EvaporationLossMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "SaturatedExit");
        

        [Description("Rate of water evaporation from the Fluid Cooler and lost to the outdoor air [%/K]" +
                     " Empirical correlation is used to calculate default loss factor if it not explic" +
                     "itly provided.")]
        [JsonProperty("evaporation_loss_factor")]
        public System.Nullable<float> EvaporationLossFactor { get; set; } = null;
        

        [Description("Rate of drift loss as a percentage of circulating spray water flow rate Default v" +
                     "alue for this field is under investigation. For now Cooling tower\'s drift loss p" +
                     "ercent default value is taken here.")]
        [JsonProperty("drift_loss_percent")]
        public System.Nullable<float> DriftLossPercent { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

        [JsonProperty("blowdown_calculation_mode")]
        public EmptyNoYes BlowdownCalculationMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ConcentrationRatio");
        

        [Description(@"Characterizes the rate of blowdown in the Evaporative Fluid Cooler. Blowdown is water intentionally drained from the basin in order to offset the build up of solids in the water that would otherwise occur because of evaporation. Ratio of solids in the blowdown water to solids in the make up water. Default value for this field is under investigation. For now Cooling tower's Blowdown Concentration Ratio percent default value is taken here.")]
        [JsonProperty("blowdown_concentration_ratio")]
        public System.Nullable<float> BlowdownConcentrationRatio { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"Makeup water usage due to blowdown results from occasionally draining a small amount of water in the Fluid Cooler basin to purge scale or other contaminants to reduce their concentration in order to maintain an acceptable level of water quality. Schedule values should reflect water usage in m3/s.")]
        [JsonProperty("blowdown_makeup_water_usage_schedule_name")]
        public string BlowdownMakeupWaterUsageScheduleName { get; set; } = "";
        

        [JsonProperty("supply_water_storage_tank_name")]
        public string SupplyWaterStorageTankName { get; set; } = "";
    }
}