using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("simple water-water hp curve-fit model")]
    [JsonObject("HeatPump:WaterToWater:EquationFit:Heating")]
    public class HeatPump_WaterToWater_EquationFit_Heating : BHoMObject
    {
        

        [JsonProperty("source_side_inlet_node_name")]
        public string SourceSideInletNodeName { get; set; } = "";
        

        [JsonProperty("source_side_outlet_node_name")]
        public string SourceSideOutletNodeName { get; set; } = "";
        

        [JsonProperty("load_side_inlet_node_name")]
        public string LoadSideInletNodeName { get; set; } = "";
        

        [JsonProperty("load_side_outlet_node_name")]
        public string LoadSideOutletNodeName { get; set; } = "";
        

        [JsonProperty("reference_load_side_flow_rate")]
        public string ReferenceLoadSideFlowRate { get; set; } = "";
        

        [JsonProperty("reference_source_side_flow_rate")]
        public string ReferenceSourceSideFlowRate { get; set; } = "";
        

        [JsonProperty("reference_heating_capacity")]
        public string ReferenceHeatingCapacity { get; set; } = "";
        

        [JsonProperty("reference_heating_power_consumption")]
        public string ReferenceHeatingPowerConsumption { get; set; } = "";
        

        [JsonProperty("heating_capacity_curve_name")]
        public string HeatingCapacityCurveName { get; set; } = "";
        

        [JsonProperty("heating_compressor_power_curve_name")]
        public string HeatingCompressorPowerCurveName { get; set; } = "";
        

        [Description("This optional field is used to autosize Reference Heating Power Consumption COP =" +
                     " Reference Heating Capacity / Reference Heating Power Consumption")]
        [JsonProperty("reference_coefficient_of_performance")]
        public System.Nullable<float> ReferenceCoefficientOfPerformance { get; set; } = (System.Nullable<float>)Single.Parse("7.5", CultureInfo.InvariantCulture);
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("companion_cooling_heat_pump_name")]
        public string CompanionCoolingHeatPumpName { get; set; } = "";
    }
}