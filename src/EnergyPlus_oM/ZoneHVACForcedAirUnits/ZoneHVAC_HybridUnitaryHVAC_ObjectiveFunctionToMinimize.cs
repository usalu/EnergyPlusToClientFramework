namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_HybridUnitaryHVAC_ObjectiveFunctionToMinimize
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Electricity Use")]
        ElectricityUse = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Second Fuel Use")]
        SecondFuelUse = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Third Fuel Use")]
        ThirdFuelUse = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Water Use")]
        WaterUse = 4,
    }
}