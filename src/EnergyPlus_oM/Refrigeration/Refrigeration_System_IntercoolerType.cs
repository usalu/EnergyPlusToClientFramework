namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_System_IntercoolerType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Flash Intercooler")]
        FlashIntercooler = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Shell-and-Coil Intercooler")]
        ShellandCoilIntercooler = 3,
    }
}