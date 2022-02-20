using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_OutdoorAirUnit_EquipmentList_Component1ObjectType
    {
        
        [JsonProperty("AirLoopHVAC:UnitarySystem")]
        AirLoopHVACUnitarySystem = 0,
        
        [JsonProperty("Coil:Cooling:Water")]
        CoilCoolingWater = 1,
        
        [JsonProperty("Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 2,
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 3,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 4,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 5,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 6,
        
        [JsonProperty("CoilSystem:Cooling:DX")]
        CoilSystemCoolingDX = 7,
        
        [JsonProperty("CoilSystem:Cooling:Water:HeatexchangerAssisted")]
        CoilSystemCoolingWaterHeatexchangerAssisted = 8,
        
        [JsonProperty("CoilSystem:Heating:DX")]
        CoilSystemHeatingDX = 9,
        
        [JsonProperty("Dehumidifier:Desiccant:NoFans")]
        DehumidifierDesiccantNoFans = 10,
        
        [JsonProperty("HeatExchanger:AirToAir:FlatPlate")]
        HeatExchangerAirToAirFlatPlate = 11,
        
        [JsonProperty("HeatExchanger:AirToAir:SensibleAndLatent")]
        HeatExchangerAirToAirSensibleAndLatent = 12,
    }
}