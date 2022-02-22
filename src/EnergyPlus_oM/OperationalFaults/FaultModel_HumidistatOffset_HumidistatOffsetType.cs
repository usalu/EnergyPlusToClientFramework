namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_HumidistatOffset_HumidistatOffsetType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatOffsetDependent")]
        ThermostatOffsetDependent = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatOffsetIndependent")]
        ThermostatOffsetIndependent = 2,
    }
}