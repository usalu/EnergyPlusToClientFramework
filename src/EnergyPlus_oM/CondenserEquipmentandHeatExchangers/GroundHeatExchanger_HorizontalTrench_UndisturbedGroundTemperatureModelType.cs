namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum GroundHeatExchanger_HorizontalTrench_UndisturbedGroundTemperatureModelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:FiniteDifference")]
        SiteGroundTemperatureUndisturbedFiniteDifference = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:KusudaAchenbach")]
        SiteGroundTemperatureUndisturbedKusudaAchenbach = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:Xing")]
        SiteGroundTemperatureUndisturbedXing = 2,
    }
}