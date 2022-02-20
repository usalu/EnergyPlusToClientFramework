using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_WaterHeating_Desuperheater_HeatingSourceObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:MultiSpeed")]
        CoilCoolingDXMultiSpeed = 0,
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 1,
        
        [JsonProperty("Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 2,
        
        [JsonProperty("Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 3,
        
        [JsonProperty("Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 4,
        
        [JsonProperty("Coil:Cooling:WaterToAirHeatPump:EquationFit")]
        CoilCoolingWaterToAirHeatPumpEquationFit = 5,
        
        [JsonProperty("Refrigeration:CompressorRack")]
        RefrigerationCompressorRack = 6,
        
        [JsonProperty("Refrigeration:Condenser:AirCooled")]
        RefrigerationCondenserAirCooled = 7,
        
        [JsonProperty("Refrigeration:Condenser:EvaporativeCooled")]
        RefrigerationCondenserEvaporativeCooled = 8,
        
        [JsonProperty("Refrigeration:Condenser:WaterCooled")]
        RefrigerationCondenserWaterCooled = 9,
    }
}