using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description(@"This tower model is based on Merkel's theory, which is also the basis for the tower model in ASHRAE's HVAC1 Toolkit. The open wet cooling tower is modeled as a counter flow heat exchanger with a variable-speed fan drawing air through the tower (induced-draft configuration). For a multi-cell tower, the capacity and air/water flow rate inputs are for the entire tower.")]
    [JsonObject("CoolingTower:VariableSpeed:Merkel")]
    public class CoolingTower_VariableSpeed_Merkel : BHoMObject
    {
        

        [Description("Name of tower water inlet node")]
        [JsonProperty("water_inlet_node_name")]
        public string WaterInletNodeName { get; set; } = "";
        

        [Description("Name of tower water outlet node")]
        [JsonProperty("water_outlet_node_name")]
        public string WaterOutletNodeName { get; set; } = "";
        

        [Description("User can define tower thermal performance by specifying the tower UA, the Design " +
                     "Air Flow Rate and the Design Water Flow Rate, or by specifying the tower nominal" +
                     " capacity")]
        [JsonProperty("performance_input_method")]
        public EmptyNoYes PerformanceInputMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "NominalCapacity");
        

        [JsonProperty("heat_rejection_capacity_and_nominal_capacity_sizing_ratio")]
        public System.Nullable<float> HeatRejectionCapacityAndNominalCapacitySizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description(@"Nominal tower capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature, with the tower fan operating at Design Air Flow Rate (full speed). Design water flow rate is as set in Design Water Flow Rate per Unit of Nominal Capacity. Nominal tower capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25) gives the actual tower heat rejection at these operating conditions.")]
        [JsonProperty("nominal_capacity")]
        public string NominalCapacity { get; set; } = "";
        

        [Description(@"required field when performance method is NominalCapacity Tower capacity in free convection regime with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate is as set in Design Water Flow Rate per Unit of Nominal Capacity. Tower free convection capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25)  gives the actual tower heat rejection at these operating conditions")]
        [JsonProperty("free_convection_nominal_capacity")]
        public string FreeConvectionNominalCapacity { get; set; } = "";
        

        [Description("This field is only used if the previous field is set to autocalculate")]
        [JsonProperty("free_convection_nominal_capacity_sizing_factor")]
        public System.Nullable<float> FreeConvectionNominalCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [JsonProperty("design_water_flow_rate")]
        public string DesignWaterFlowRate { get; set; } = "";
        

        [Description("This field is only used if the previous is set to autocalculate and performance i" +
                     "nput method is NominalCapacity")]
        [JsonProperty("design_water_flow_rate_per_unit_of_nominal_capacity")]
        public System.Nullable<float> DesignWaterFlowRatePerUnitOfNominalCapacity { get; set; } = (System.Nullable<float>)Single.Parse("5.382E-08", CultureInfo.InvariantCulture);
        

        [Description("This is the air flow rate at full fan speed")]
        [JsonProperty("design_air_flow_rate")]
        public string DesignAirFlowRate { get; set; } = "";
        

        [Description(@"This field is only used if the previous is set to autocalculate When field is left blank the default scaling factor is adjusted for elevation to increase volume flow at altitude When field has a value the scaling factor is used without adjusting for elevation")]
        [JsonProperty("design_air_flow_rate_per_unit_of_nominal_capacity")]
        public System.Nullable<float> DesignAirFlowRatePerUnitOfNominalCapacity { get; set; } = (System.Nullable<float>)Single.Parse("2.76316E-05", CultureInfo.InvariantCulture);
        

        [Description("Enter the minimum air flow rate ratio. This is typically determined by the variab" +
                     "le speed drive that controls the fan motor speed. Valid entries are from 0.1 to " +
                     "0.5.")]
        [JsonProperty("minimum_air_flow_rate_ratio")]
        public System.Nullable<float> MinimumAirFlowRateRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("This is the fan motor electric input power at high speed")]
        [JsonProperty("design_fan_power")]
        public string DesignFanPower { get; set; } = "";
        

        [Description("This field is only used if the previous is set to autocalculate [W/W] Watts of fa" +
                     "n power per Watt of tower nominal capacity")]
        [JsonProperty("design_fan_power_per_unit_of_nominal_capacity")]
        public System.Nullable<float> DesignFanPowerPerUnitOfNominalCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0.0105", CultureInfo.InvariantCulture);
        

        [Description("Any curve or table with one independent variable can be used cubic curve = a + b*" +
                     "AFR + c*AFR**2 + d*AFR**3 quartic curve = a + b*AFR + c*AFR**2 + d*AFR**3 + e*AF" +
                     "R**4 x = AFR = Ratio of current operating air flow rate to Design Air Flow Rate")]
        [JsonProperty("fan_power_modifier_function_of_air_flow_rate_ratio_curve_name")]
        public string FanPowerModifierFunctionOfAirFlowRateRatioCurveName { get; set; } = "";
        

        [JsonProperty("free_convection_regime_air_flow_rate")]
        public string FreeConvectionRegimeAirFlowRate { get; set; } = (System.String)"0";
        

        [Description("This field is only used if the previous field is set to autocalculate.")]
        [JsonProperty("free_convection_regime_air_flow_rate_sizing_factor")]
        public System.Nullable<float> FreeConvectionRegimeAirFlowRateSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description("required field when performance method is UFactorTimesAreaAndDesignWaterFlowRate " +
                     "when performance method is NominalCapacity the program will solve for this UA")]
        [JsonProperty("design_air_flow_rate_u_factor_times_area_value")]
        public string DesignAirFlowRateUFactorTimesAreaValue { get; set; } = "";
        

        [Description("required field when performance input method is UFactorTimesAreaAndDesignWaterFlo" +
                     "wRate Leave field blank if performance input method is NominalCapacity")]
        [JsonProperty("free_convection_regime_u_factor_times_area_value")]
        public string FreeConvectionRegimeUFactorTimesAreaValue { get; set; } = (System.String)"0";
        

        [Description("required field when performance input method is UFactorTimesAreaAndDesignWaterFlo" +
                     "wRate This field is only used if the previous field is set to autocalculate and " +
                     "the performance input method is UFactorTimesAreaAndDesignWaterFlowRate")]
        [JsonProperty("free_convection_u_factor_times_area_value_sizing_factor")]
        public System.Nullable<float> FreeConvectionUFactorTimesAreaValueSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description(@"This curve describes how tower's design UA changes with variable air flow rate Any curve or table with one independent variable can be used cubic curve = a + b*AFR + c*AFR**2 + d*AFR**3 quartic curve = a + b*AFR + c*AFR**2 + d*AFR**3 + e*AFR**4 x = AFR = Ratio of current operating air flow rate to Design Air Flow Rate")]
        [JsonProperty("u_factor_times_area_modifier_function_of_air_flow_ratio_curve_name")]
        public string UFactorTimesAreaModifierFunctionOfAirFlowRatioCurveName { get; set; } = "";
        

        [Description(@"curve describes how tower UA changes with outdoor air wet-bulb temperature difference from design wet-bulb Any curve or table with one independent variable can be used cubic curve = a + b*DeltaWB + c*DeltaWB**2 + d*DeltaWB**3 quartic curve = a + b*DeltaWB + c*DeltaWB**2 + d*DeltaWB**3 + e*DeltaWB**4 x = DeltaWB = (design wet-bulb temperature in C - current wet-bulb temperature in C) where design wet-bulb temperature of entering air is 25.56C (78F)")]
        [JsonProperty("u_factor_times_area_modifier_function_of_wetbulb_temperature_difference_curve_nam" +
                      "e")]
        public string UFactorTimesAreaModifierFunctionOfWetbulbTemperatureDifferenceCurveName { get; set; } = "";
        

        [Description(@"curve describes how tower UA changes with the flow rate of condenser water through the tower Any curve or table with one independent variable can be used cubic curve = a + b*WFR + c*WFR**2 + d*WFR**3 quartic curve = a + b*WFR + c*WFR**2 + d*WFR**3 + e*WFR**4 x = WFR = Ratio of current operating water flow rate to Design Water Flow Rate")]
        [JsonProperty("u_factor_times_area_modifier_function_of_water_flow_ratio_curve_name")]
        public string UFactorTimesAreaModifierFunctionOfWaterFlowRatioCurveName { get; set; } = "";
        

        [Description("Enter the tower\'s design inlet air dry-bulb temperature")]
        [JsonProperty("design_inlet_air_dry_bulb_temperature")]
        public System.Nullable<float> DesignInletAirDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("35", CultureInfo.InvariantCulture);
        

        [Description("Enter the tower\'s design inlet air wet-bulb temperature")]
        [JsonProperty("design_inlet_air_wet_bulb_temperature")]
        public System.Nullable<float> DesignInletAirWetBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25.6", CultureInfo.InvariantCulture);
        

        [Description("Enter the approach temperature corresponding to the design inlet air wet-bulb tem" +
                     "perature and design range temperature. Design approach temp = outlet water tempe" +
                     "rature minus inlet air wet-bulb temperature at design conditions. Autosized to 3" +
                     ".9 deltaC.")]
        [JsonProperty("design_approach_temperature")]
        public string DesignApproachTemperature { get; set; } = (System.String)"Autosize";
        

        [Description("Enter the range temperature corresponding to the design inlet air wet-bulb temper" +
                     "ature and design approach temperature. Design range = inlet water temperature mi" +
                     "nus outlet water temperature at design conditions. Autosized to 5.5 deltaC.")]
        [JsonProperty("design_range_temperature")]
        public string DesignRangeTemperature { get; set; } = (System.String)"Autosize";
        

        [Description("This heater maintains the basin water temperature at the basin heater setpoint te" +
                     "mperature when the outdoor air temperature falls below the setpoint temperature." +
                     " The basin heater only operates when water is not flowing through the tower.")]
        [JsonProperty("basin_heater_capacity")]
        public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the outdoor dry-bulb temperature when the basin heater turns on")]
        [JsonProperty("basin_heater_setpoint_temperature")]
        public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty("basin_heater_operating_schedule_name")]
        public string BasinHeaterOperatingScheduleName { get; set; } = "";
        

        [JsonProperty("evaporation_loss_mode")]
        public EmptyNoYes EvaporationLossMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description(@"Rate of water evaporated from the cooling tower and lost to the outdoor air [%/K] Evaporation loss is calculated as percentage of the circulating condenser water rate Value entered here is percent-per-degree K of temperature drop in the condenser water Typical values are from 0.15 to 0.27 [%/K].")]
        [JsonProperty("evaporation_loss_factor")]
        public System.Nullable<float> EvaporationLossFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("Rate of drift loss as a percentage of circulating condenser water flow rate Typic" +
                     "al values are between 0.002 and 0.2% The default value is 0.008%")]
        [JsonProperty("drift_loss_percent")]
        public System.Nullable<float> DriftLossPercent { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

        [JsonProperty("blowdown_calculation_mode")]
        public EmptyNoYes BlowdownCalculationMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description(@"Characterizes the rate of blowdown in the cooling tower. Blowdown is water intentionally drained from the tower in order to offset the build up of solids in the water that would otherwise occur because of evaporation. Ratio of solids in the blowdown water to solids in the make up water. Typical values for tower operation are 3 to 5. The default value is 3.")]
        [JsonProperty("blowdown_concentration_ratio")]
        public System.Nullable<float> BlowdownConcentrationRatio { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"Makeup water usage due to blowdown results from occasionally draining some amount of water in the tower basin to purge scale or other contaminants to reduce their concentration in order to maintain an acceptable level of water quality. Schedule values should reflect water usage in m3/s.")]
        [JsonProperty("blowdown_makeup_water_usage_schedule_name")]
        public string BlowdownMakeupWaterUsageScheduleName { get; set; } = "";
        

        [JsonProperty("supply_water_storage_tank_name")]
        public string SupplyWaterStorageTankName { get; set; } = "";
        

        [Description("Enter the name of an outdoor air node")]
        [JsonProperty("outdoor_air_inlet_node_name")]
        public string OutdoorAirInletNodeName { get; set; } = "";
        

        [JsonProperty("number_of_cells")]
        public System.Nullable<float> NumberOfCells { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("cell_control")]
        public EmptyNoYes CellControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "MinimalCell");
        

        [Description("The allowable minimal fraction of the nominal flow rate per cell")]
        [JsonProperty("cell_minimum_water_flow_rate_fraction")]
        public System.Nullable<float> CellMinimumWaterFlowRateFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.33", CultureInfo.InvariantCulture);
        

        [Description("The allowable maximal fraction of the nominal flow rate per cell")]
        [JsonProperty("cell_maximum_water_flow_rate_fraction")]
        public System.Nullable<float> CellMaximumWaterFlowRateFraction { get; set; } = (System.Nullable<float>)Single.Parse("2.5", CultureInfo.InvariantCulture);
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}