namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum GasEquipment_DesignLevelCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="EquipmentLevel")]
        EquipmentLevel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Power/Area")]
        PowerArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Power/Person")]
        PowerPerson = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Area")]
        WattsArea = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Person")]
        WattsPerson = 5,
    }
}