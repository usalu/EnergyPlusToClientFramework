namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_WaterSupply_WaterTemperatureModelingMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="MainsWaterTemperature")]
        MainsWaterTemperature = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureFromAirNode")]
        TemperatureFromAirNode = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureFromSchedule")]
        TemperatureFromSchedule = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureFromWaterNode")]
        TemperatureFromWaterNode = 3,
    }
}