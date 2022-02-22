namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_PVWatts_ArrayType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FixedOpenRack")]
        FixedOpenRack = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedRoofMounted")]
        FixedRoofMounted = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OneAxis")]
        OneAxis = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OneAxisBacktracking")]
        OneAxisBacktracking = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="TwoAxis")]
        TwoAxis = 4,
    }
}