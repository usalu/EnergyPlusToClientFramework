namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    public enum CondenserEquipmentOperationSchemes_ControlScheme8ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 10,
    }
}