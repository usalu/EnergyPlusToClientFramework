using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Heating_Desuperheater_HeatingSourceObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 1,
        
        [JsonProperty("Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 2,
        
        [JsonProperty("Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 3,
        
        [JsonProperty("Refrigeration:CompressorRack")]
        RefrigerationCompressorRack = 4,
        
        [JsonProperty("Refrigeration:Condenser:AirCooled")]
        RefrigerationCondenserAirCooled = 5,
        
        [JsonProperty("Refrigeration:Condenser:EvaporativeCooled")]
        RefrigerationCondenserEvaporativeCooled = 6,
        
        [JsonProperty("Refrigeration:Condenser:WaterCooled")]
        RefrigerationCondenserWaterCooled = 7,
    }
}