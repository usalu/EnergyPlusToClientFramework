using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_TemperatureSensorOffset_CoilSupplyAir_CoilObjectType
    {
        
        [JsonProperty("AirLoopHVAC:UnitarySystem")]
        AirLoopHVACUnitarySystem = 0,
        
        [JsonProperty("Coil:Cooling:Water")]
        CoilCoolingWater = 1,
        
        [JsonProperty("Coil:Cooling:Water:Detailedgeometry")]
        CoilCoolingWaterDetailedgeometry = 2,
        
        [JsonProperty("Coil:Heating:Desuperheater")]
        CoilHeatingDesuperheater = 3,
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 4,
        
        [JsonProperty("Coil:Heating:Gas")]
        CoilHeatingGas = 5,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 6,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 7,
        
        [JsonProperty("CoilSystem:Cooling:DX")]
        CoilSystemCoolingDX = 8,
        
        [JsonProperty("CoilSystem:Heating:DX")]
        CoilSystemHeatingDX = 9,
    }
}