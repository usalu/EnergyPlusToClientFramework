namespace BH.oM.Adapters.EnergyPlus.PlantCondenserLoops
{
    public enum PlantLoop_FluidType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="UserDefinedFluidType")]
        UserDefinedFluidType = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Water")]
        Water = 3,
    }
}