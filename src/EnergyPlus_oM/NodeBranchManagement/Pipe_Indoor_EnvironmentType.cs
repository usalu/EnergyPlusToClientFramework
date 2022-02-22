namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    public enum Pipe_Indoor_EnvironmentType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 2,
    }
}