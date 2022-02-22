namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_Case_DefrostEnergyCorrectionCurveType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CaseTemperatureMethod")]
        CaseTemperatureMethod = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DewpointMethod")]
        DewpointMethod = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="RelativeHumidityMethod")]
        RelativeHumidityMethod = 4,
    }
}