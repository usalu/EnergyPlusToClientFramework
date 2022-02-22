namespace BH.oM.Adapters.EnergyPlus.PlantCondenserLoops
{
    public enum CondenserLoop_FluidType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="UserDefinedFluidType")]
        UserDefinedFluidType = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Water")]
        Water = 2,
    }
}