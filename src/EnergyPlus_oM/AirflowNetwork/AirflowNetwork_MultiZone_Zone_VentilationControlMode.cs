namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_MultiZone_Zone_VentilationControlMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAE55Adaptive")]
        ASHRAE55Adaptive = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CEN15251Adaptive")]
        CEN15251Adaptive = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Enthalpy")]
        Enthalpy = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="NoVent")]
        NoVent = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 6,
    }
}