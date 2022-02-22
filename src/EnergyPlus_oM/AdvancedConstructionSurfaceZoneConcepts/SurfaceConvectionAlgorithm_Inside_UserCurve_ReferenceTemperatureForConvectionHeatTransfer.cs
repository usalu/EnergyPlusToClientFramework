namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Inside_UserCurve_ReferenceTemperatureForConvectionHeatTransfer
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AdjacentAirTemperature")]
        AdjacentAirTemperature = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SupplyAirTemperature")]
        SupplyAirTemperature = 2,
    }
}