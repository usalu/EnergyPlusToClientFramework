namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_MechanicalVentilation_SystemOutdoorAirMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="IndoorAirQualityProcedure")]
        IndoorAirQualityProcedure = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="IndoorAirQualityProcedureCombined")]
        IndoorAirQualityProcedureCombined = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="IndoorAirQualityProcedureGenericContaminant")]
        IndoorAirQualityProcedureGenericContaminant = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ProportionalControlBasedOnDesignOARate")]
        ProportionalControlBasedOnDesignOARate = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ProportionalControlBasedOnDesignOccupancy")]
        ProportionalControlBasedOnDesignOccupancy = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="ProportionalControlBasedOnOccupancySchedule")]
        ProportionalControlBasedOnOccupancySchedule = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="VentilationRateProcedure")]
        VentilationRateProcedure = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneSum")]
        ZoneSum = 8,
    }
}