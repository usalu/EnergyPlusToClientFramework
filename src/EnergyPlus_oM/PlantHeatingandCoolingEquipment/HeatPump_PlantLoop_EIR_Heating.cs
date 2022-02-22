using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("An EIR formulated water to water heat pump model, heating operation")]
    public class HeatPump_PlantLoop_EIR_Heating : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("load_side_inlet_node_name")]
        public string LoadSideInletNodeName { get; set; } = "";
        

        [JsonProperty("load_side_outlet_node_name")]
        public string LoadSideOutletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatPump_PlantLoop_EIR_Heating_CondenserType CondenserType { get; set; } = (HeatPump_PlantLoop_EIR_Heating_CondenserType)Enum.Parse(typeof(HeatPump_PlantLoop_EIR_Heating_CondenserType), "WaterSource");
        

        [JsonProperty("source_side_inlet_node_name")]
        public string SourceSideInletNodeName { get; set; } = "";
        

        [JsonProperty("source_side_outlet_node_name")]
        public string SourceSideOutletNodeName { get; set; } = "";
        

        [Description("This field allows the user to specify a companion cooling object for this heating" +
                     " object. The companion is used in sizing the heat pump as well as to allow check" +
                     "s for unexpected simultaneous operation of the two objects.")]
        [JsonProperty("companion_heat_pump_name")]
        public string CompanionHeatPumpName { get; set; } = "";
        

        [Description("This component is currently a constant-flow device, meaning it will always try to" +
                     " request the full design flow from the central plant manager.")]
        [JsonProperty("load_side_reference_flow_rate")]
        public string LoadSideReferenceFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("source_side_reference_flow_rate")]
        public string SourceSideReferenceFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("reference_capacity")]
        public string ReferenceCapacity { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("reference_coefficient_of_performance")]
        public System.Nullable<float> ReferenceCoefficientOfPerformance { get; set; } = (System.Nullable<float>)Single.Parse("7.5", CultureInfo.InvariantCulture);
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Heating capacity modifier as a function of CW supply temp and entering condenser " +
                     "temp curve = a + b*CWS + c*CWS**2 + d*ECT + e*ECT**2 + f*CWS*ECT CWS = supply (l" +
                     "eaving) hot water temperature(C) ECT = entering condenser fluid temperature(C)")]
        [JsonProperty("capacity_modifier_function_of_temperature_curve_name")]
        public string CapacityModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Electric Input Ratio (EIR) modifier as a function of temperature EIR = 1/COP curv" +
                     "e = a + b*CWS + c*CWS**2 + d*ECT + e*ECT**2 + f*CWS*ECT CWS = supply (leaving) h" +
                     "ot water temperature(C) ECT = entering condenser fluid temperature(C)")]
        [JsonProperty("electric_input_to_output_ratio_modifier_function_of_temperature_curve_name")]
        public string ElectricInputToOutputRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Electric Input Ratio (EIR) modifier as a function of Part Load Ratio (PLR) EIR = " +
                     "1/COP quadratic curve = a + b*PLR + c*PLR**2 is typical, other univariate curves" +
                     " may be used PLR = part load ratio (hot load/steady state capacity)")]
        [JsonProperty("electric_input_to_output_ratio_modifier_function_of_part_load_ratio_curve_name")]
        public string ElectricInputToOutputRatioModifierFunctionOfPartLoadRatioCurveName { get; set; } = "";
    }
}