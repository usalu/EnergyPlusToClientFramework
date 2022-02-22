using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description(@"This chiller model is an empirical model, a reformulated version of Chiller:Electric:EIR where the performance is a function of condenser leaving fluid Temperature instead of condenser entering fluid Temperature. Chiller performance at off-reference conditions is modeled using three polynomial equations. Three curve objects are required.")]
    public class Chiller_Electric_ReformulatedEIR : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("reference_capacity")]
        public string ReferenceCapacity { get; set; } = "";
        

        [Description("Efficiency of the chiller compressor (cooling output/compressor energy input). Co" +
                     "ndenser fan power should not be included here.")]
        [JsonProperty("reference_cop")]
        public System.Nullable<float> ReferenceCop { get; set; } = null;
        

        [JsonProperty("reference_leaving_chilled_water_temperature")]
        public System.Nullable<float> ReferenceLeavingChilledWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("6.67", CultureInfo.InvariantCulture);
        

        [JsonProperty("reference_leaving_condenser_water_temperature")]
        public System.Nullable<float> ReferenceLeavingCondenserWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("35", CultureInfo.InvariantCulture);
        

        [JsonProperty("reference_chilled_water_flow_rate")]
        public string ReferenceChilledWaterFlowRate { get; set; } = "";
        

        [JsonProperty("reference_condenser_water_flow_rate")]
        public string ReferenceCondenserWaterFlowRate { get; set; } = "";
        

        [Description(@"Cooling capacity as a function of supply (leaving) chilled water temperature and leaving condenser fluid temperature curve = a + b*CWS + c*CWS**2 + d*LCT + e*LCT**2 + f*CWS*LCT CWS = supply (leaving) chilled water temperature(C) LCT = leaving condenser fluid temperature(C)")]
        [JsonProperty("cooling_capacity_function_of_temperature_curve_name")]
        public string CoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Electric Input Ratio (EIR) as a function of supply (leaving) chilled water temperature and leaving condenser fluid temperature. EIR = 1/COP. curve = a + b*CWS + c*CWS**2 + d*LCT + e*LCT**2 + f*CWS*LCT CWS = supply (leaving) chilled water temperature(C) LCT = leaving condenser fluid temperature(C)")]
        [JsonProperty("electric_input_to_cooling_output_ratio_function_of_temperature_curve_name")]
        public string ElectricInputToCoolingOutputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Two curve types are available: Type LeavingCondenserWaterTemperature: based on the leaving condenser water temperature. Type Lift: based on the normalized lift, which is the temperature difference between the leaving condenser water temperature and the leaving evaporator water temperature.")]
        [JsonProperty("electric_input_to_cooling_output_ratio_function_of_part_load_ratio_curve_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Chiller_Electric_ReformulatedEIR_ElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveType ElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveType { get; set; } = (Chiller_Electric_ReformulatedEIR_ElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveType)Enum.Parse(typeof(Chiller_Electric_ReformulatedEIR_ElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveType), "LeavingCondenserWaterTemperature");
        

        [Description(@"Electric Input Ratio (EIR) as a function of Part Load Ratio (PLR) EIR = 1/COP The form of this curve is based on the input for Electric Input to Cooling Output RatioFunction of Part Load Ratio Curve Type Type=LeavingCondenserWaterTemperature: Calculated based on LCT and PLR Curve object type should be Curve:Bicubic or Table:Lookup Bicubic curve = a + b*LCT + c*LCT**2 + d*PLR + e*PLR**2 + f*LCT*PLR + g*0 + h*PLR**3 + i*0 + j*0 PLR = part load ratio (cooling load/steady state capacity) LCT = leaving condenser fluid temperature(C) Type=Lift: Calculated based on dT*, Tdev* and PLR Curve object type should be Curve:ChillerPartLoadWithLiftCurves or Table:Lookup ChillerPartLoadWithLiftCurves curve = a + b*(dT*) + c*(dT*)**2 + d*PLR + e*PLR**2 + f*(dT*)*PLR + g*(dT*)**3 + h*PLR**3 + i*(dT*)**2*PLR + j*(dT*)*PLR**2 + k*(dT*)**2*PLR**2 + l*(Tdev*)*PLR**3 x = dT* = normalized fractional Lift = dT / dTref y = PLR = part load ratio (cooling load/steady state capacity) z = Tdev* = normalized Tdev = Tdev / dTref Where: dT = Lift = Leaving Condenser Water Temperature - Leaving Chilled Water Temperature dTref = dT at the reference condition Tdev = Leaving Chilled Water Temperature - Reference Chilled Water Temperature")]
        [JsonProperty("electric_input_to_cooling_output_ratio_function_of_part_load_ratio_curve_name")]
        public string ElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [Description("Part load ratio below which the chiller starts cycling on/off to meet the load. M" +
                     "ust be less than or equal to Maximum Part Load Ratio.")]
        [JsonProperty("minimum_part_load_ratio")]
        public System.Nullable<float> MinimumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description("Maximum allowable part load ratio. Must be greater than or equal to Minimum Part " +
                     "Load Ratio.")]
        [JsonProperty("maximum_part_load_ratio")]
        public System.Nullable<float> MaximumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Optimum part load ratio where the chiller is most efficient. Must be greater than" +
                     " or equal to the Minimum Part Load Ratio and less than or equal to the Maximum P" +
                     "art Load Ratio.")]
        [JsonProperty("optimum_part_load_ratio")]
        public System.Nullable<float> OptimumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Part load ratio where the chiller can no longer unload and false loading begins. " +
                     "Minimum unloading ratio must be greater than or equal to the Minimum Part Load R" +
                     "atio and less than or equal to the Maximum Part Load Ratio.")]
        [JsonProperty("minimum_unloading_ratio")]
        public System.Nullable<float> MinimumUnloadingRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("chilled_water_inlet_node_name")]
        public string ChilledWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("chilled_water_outlet_node_name")]
        public string ChilledWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_inlet_node_name")]
        public string CondenserInletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_outlet_node_name")]
        public string CondenserOutletNodeName { get; set; } = "";
        

        [Description(@"Fraction of compressor electrical energy that must be rejected by the condenser. Enter a value of 1.0 when modeling hermetic chillers. For open chillers, enter the compressor motor efficiency. This value should be greater than 0.6 for practical applications.")]
        [JsonProperty("fraction_of_compressor_electric_consumption_rejected_by_condenser")]
        public System.Nullable<float> FractionOfCompressorElectricConsumptionRejectedByCondenser { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("leaving_chilled_water_lower_temperature_limit")]
        public System.Nullable<float> LeavingChilledWaterLowerTemperatureLimit { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"Select operating mode for fluid flow through the chiller. ""NotModulated"" is for either variable or constant pumping with flow controlled by the external plant system. ""ConstantFlow"" is for constant pumping with flow controlled by chiller to operate at full design flow rate. ""LeavingSetpointModulated"" is for variable pumping with flow controlled by chiller to vary flow to target a leaving temperature setpoint.")]
        [JsonProperty("chiller_flow_mode_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Chiller_Electric_ReformulatedEIR_ChillerFlowModeType ChillerFlowModeType { get; set; } = (Chiller_Electric_ReformulatedEIR_ChillerFlowModeType)Enum.Parse(typeof(Chiller_Electric_ReformulatedEIR_ChillerFlowModeType), "NotModulated");
        

        [Description("If non-zero, then the heat recovery inlet and outlet node names must be entered.")]
        [JsonProperty("design_heat_recovery_water_flow_rate")]
        public string DesignHeatRecoveryWaterFlowRate { get; set; } = (System.String)"0";
        

        [JsonProperty("heat_recovery_inlet_node_name")]
        public string HeatRecoveryInletNodeName { get; set; } = "";
        

        [JsonProperty("heat_recovery_outlet_node_name")]
        public string HeatRecoveryOutletNodeName { get; set; } = "";
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This optional field is the fraction of total rejected heat that can be recovered " +
                     "at full load")]
        [JsonProperty("condenser_heat_recovery_relative_capacity_fraction")]
        public System.Nullable<float> CondenserHeatRecoveryRelativeCapacityFraction { get; set; } = null;
        

        [Description("This optional schedule of temperatures will turn off heat recovery if inlet excee" +
                     "ds the value")]
        [JsonProperty("heat_recovery_inlet_high_temperature_limit_schedule_name")]
        public string HeatRecoveryInletHighTemperatureLimitScheduleName { get; set; } = "";
        

        [Description("This optional field provides control over the heat recovery Using this triggers a" +
                     " model more suited to series bundle and chillers with higher temperature heat re" +
                     "covery If this field is not used, the bundles are modeled as being in parallel")]
        [JsonProperty("heat_recovery_leaving_temperature_setpoint_node_name")]
        public string HeatRecoveryLeavingTemperatureSetpointNodeName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}