using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Used to provide details of the water supply subsystem for a fuel cell power gener" +
                 "ator. This water is used for steam reforming of the fuel and is not the same as " +
                 "the water used for thermal heat recovery.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelCell_WaterSupply : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("reformer_water_flow_rate_function_of_fuel_rate_curve_name")]
        public string ReformerWaterFlowRateFunctionOfFuelRateCurveName { get; set; } = "";
        

        [JsonProperty("reformer_water_pump_power_function_of_fuel_rate_curve_name")]
        public string ReformerWaterPumpPowerFunctionOfFuelRateCurveName { get; set; } = "";
        

        [JsonProperty("pump_heat_loss_factor")]
        public System.Nullable<float> PumpHeatLossFactor { get; set; } = null;
        

        [JsonProperty("water_temperature_modeling_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_WaterSupply_WaterTemperatureModelingMode WaterTemperatureModelingMode { get; set; } = (Generator_FuelCell_WaterSupply_WaterTemperatureModelingMode)Enum.Parse(typeof(Generator_FuelCell_WaterSupply_WaterTemperatureModelingMode), "MainsWaterTemperature");
        

        [JsonProperty("water_temperature_reference_node_name")]
        public string WaterTemperatureReferenceNodeName { get; set; } = "";
        

        [JsonProperty("water_temperature_schedule_name")]
        public string WaterTemperatureScheduleName { get; set; } = "";
    }
}