namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_SimulationControl_Solver
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConjugateGradient")]
        ConjugateGradient = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SkylineLU")]
        SkylineLU = 2,
    }
}