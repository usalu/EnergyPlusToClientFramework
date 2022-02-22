namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_Surfaces_List_ReportType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="CostInfo")]
        CostInfo = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DecayCurvesFromComponentLoadsSummary")]
        DecayCurvesFromComponentLoadsSummary = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Details")]
        Details = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DetailsWithVertices")]
        DetailsWithVertices = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Lines")]
        Lines = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Vertices")]
        Vertices = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="ViewFactorInfo")]
        ViewFactorInfo = 6,
    }
}