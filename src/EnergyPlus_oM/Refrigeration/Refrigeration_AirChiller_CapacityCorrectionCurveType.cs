namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_AirChiller_CapacityCorrectionCurveType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="European")]
        European = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LinearSHR60")]
        LinearSHR60 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="QuadraticSHR")]
        QuadraticSHR = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="TabularRHxDT1xTRoom")]
        TabularRHxDT1xTRoom = 3,
    }
}