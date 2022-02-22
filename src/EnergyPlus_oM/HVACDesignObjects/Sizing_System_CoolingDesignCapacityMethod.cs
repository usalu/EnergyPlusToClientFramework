namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_System_CoolingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingDesignCapacity")]
        CoolingDesignCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedCoolingCapacity")]
        FractionOfAutosizedCoolingCapacity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
    }
}