using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_Distribution_Component_Coil_CoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX")]
        CoilCoolingDX = 0,
        
        [JsonProperty("Coil:Cooling:DX:MultiSpeed")]
        CoilCoolingDXMultiSpeed = 1,
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 2,
        
        [JsonProperty("Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 3,
        
        [JsonProperty("Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 4,
        
        [JsonProperty("Coil:Cooling:Water")]
        CoilCoolingWater = 5,
        
        [JsonProperty("Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 6,
        
        [JsonProperty("Coil:Heating:DX:MultiSpeed")]
        CoilHeatingDXMultiSpeed = 7,
        
        [JsonProperty("Coil:Heating:DX:SingleSpeed")]
        CoilHeatingDXSingleSpeed = 8,
        
        [JsonProperty("Coil:Heating:Desuperheater")]
        CoilHeatingDesuperheater = 9,
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 10,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 11,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 12,
    }
}