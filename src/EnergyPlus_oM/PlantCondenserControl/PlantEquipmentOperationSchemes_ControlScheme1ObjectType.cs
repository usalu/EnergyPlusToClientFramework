using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    public enum PlantEquipmentOperationSchemes_ControlScheme1ObjectType
    {
        
        [JsonProperty("PlantEquipmentOperation:ComponentSetpoint")]
        PlantEquipmentOperationComponentSetpoint = 0,
        
        [JsonProperty("PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 1,
        
        [JsonProperty("PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 2,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 3,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 4,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 5,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 6,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 7,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 8,
        
        [JsonProperty("PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 9,
        
        [JsonProperty("PlantEquipmentOperation:ThermalEnergyStorage")]
        PlantEquipmentOperationThermalEnergyStorage = 10,
        
        [JsonProperty("PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 11,
        
        [JsonProperty("PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 12,
    }
}