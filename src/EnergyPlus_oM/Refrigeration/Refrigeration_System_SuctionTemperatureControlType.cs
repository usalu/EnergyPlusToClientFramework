namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_System_SuctionTemperatureControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConstantSuctionTemperature")]
        ConstantSuctionTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FloatSuctionTemperature")]
        FloatSuctionTemperature = 2,
    }
}