namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelSupply_FuelTemperatureModelingMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureFromAirNode")]
        TemperatureFromAirNode = 1,
    }
}