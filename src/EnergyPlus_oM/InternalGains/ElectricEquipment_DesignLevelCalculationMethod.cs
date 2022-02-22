namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum ElectricEquipment_DesignLevelCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="EquipmentLevel")]
        EquipmentLevel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Area")]
        WattsArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Person")]
        WattsPerson = 3,
    }
}