namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    public enum WaterUse_Connections_DrainWaterHeatExchangerDestination
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Equipment")]
        Equipment = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Plant")]
        Plant = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantAndEquipment")]
        PlantAndEquipment = 3,
    }
}