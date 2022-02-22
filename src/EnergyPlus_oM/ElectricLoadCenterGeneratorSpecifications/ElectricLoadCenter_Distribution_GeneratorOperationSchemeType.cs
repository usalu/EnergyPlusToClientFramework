namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum ElectricLoadCenter_Distribution_GeneratorOperationSchemeType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Baseload")]
        Baseload = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DemandLimit")]
        DemandLimit = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FollowThermal")]
        FollowThermal = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FollowThermalLimitElectrical")]
        FollowThermalLimitElectrical = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="TrackElectrical")]
        TrackElectrical = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="TrackMeter")]
        TrackMeter = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="TrackSchedule")]
        TrackSchedule = 6,
    }
}