using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("simple water-water heat pump curve-fit model")]
    [JsonObject("HeatPump:WaterToWater:EquationFit:Cooling")]
    public class HeatPump_WaterToWater_EquationFit_Cooling : BHoMObject
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
        

        [JsonProperty("reference_cooling_capacity")]
        public string ReferenceCoolingCapacity { get; set; } = "";
        

        [JsonProperty("reference_cooling_power_consumption")]
        public string ReferenceCoolingPowerConsumption { get; set; } = "";
        

        [JsonProperty("cooling_capacity_curve_name")]
        public string CoolingCapacityCurveName { get; set; } = "";
        

        [JsonProperty("cooling_compressor_power_curve_name")]
        public string CoolingCompressorPowerCurveName { get; set; } = "";
        

        [Description("This optional field is used to autosize Reference Cooling Power Consumption COP =" +
                     " Rated Cooling Capacity / Rated Cooling Power Consumption")]
        [JsonProperty("reference_coefficient_of_performance")]
        public System.Nullable<float> ReferenceCoefficientOfPerformance { get; set; } = (System.Nullable<float>)Single.Parse("8", CultureInfo.InvariantCulture);
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This optional field is used to coordinate sizing calculations between heating and" +
                     " cooling modes.")]
        [JsonProperty("companion_heating_heat_pump_name")]
        public string CompanionHeatingHeatPumpName { get; set; } = "";
    }
}