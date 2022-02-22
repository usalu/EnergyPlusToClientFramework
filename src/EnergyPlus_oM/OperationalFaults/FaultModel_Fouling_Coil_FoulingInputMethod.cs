namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_Fouling_Coil_FoulingInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FouledUARated")]
        FouledUARated = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FoulingFactor")]
        FoulingFactor = 2,
    }
}