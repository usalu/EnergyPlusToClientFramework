using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:DX:MultiSpeed")]
        CoilHeatingDXMultiSpeed = 0,
        
        [JsonProperty("Coil:Heating:DX:SingleSpeed")]
        CoilHeatingDXSingleSpeed = 1,
        
        [JsonProperty("Coil:Heating:DX:VariableSpeed")]
        CoilHeatingDXVariableSpeed = 2,
        
        [JsonProperty("Coil:Heating:Desuperheater")]
        CoilHeatingDesuperheater = 3,
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 4,
        
        [JsonProperty("Coil:Heating:Electric:MultiStage")]
        CoilHeatingElectricMultiStage = 5,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 6,
        
        [JsonProperty("Coil:Heating:Gas:MultiStage")]
        CoilHeatingGasMultiStage = 7,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 8,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 9,
        
        [JsonProperty("Coil:Heating:WaterToAirHeatPump:EquationFit")]
        CoilHeatingWaterToAirHeatPumpEquationFit = 10,
        
        [JsonProperty("Coil:Heating:WaterToAirHeatPump:ParameterEstimation")]
        CoilHeatingWaterToAirHeatPumpParameterEstimation = 11,
        
        [JsonProperty("Coil:Heating:WaterToAirHeatPump:VariableSpeedEquationFit")]
        CoilHeatingWaterToAirHeatPumpVariableSpeedEquationFit = 12,
        
        [JsonProperty("Coil:UserDefined")]
        CoilUserDefined = 13,
    }
}