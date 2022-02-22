namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_Baseboard_RadiantConvective_Electric_HeatingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingCapacity")]
        FractionOfAutosizedHeatingCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingDesignCapacity")]
        HeatingDesignCapacity = 3,
    }
}