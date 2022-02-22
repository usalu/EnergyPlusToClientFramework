namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_IdealLoadsAirSystem_DehumidificationControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConstantSensibleHeatRatio")]
        ConstantSensibleHeatRatio = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ConstantSupplyHumidityRatio")]
        ConstantSupplyHumidityRatio = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Humidistat")]
        Humidistat = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
    }
}