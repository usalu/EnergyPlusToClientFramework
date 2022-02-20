using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    public enum CondenserEquipmentOperationSchemes_ControlScheme2ObjectType
    {
        
        [JsonProperty("PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 0,
        
        [JsonProperty("PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 1,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 2,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 3,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 4,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 5,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 6,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 7,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 8,
        
        [JsonProperty("PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 9,
        
        [JsonProperty("PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 10,
    }
}