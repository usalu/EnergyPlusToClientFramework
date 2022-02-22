namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_SimulationControl_WindPressureCoefficientType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Input")]
        Input = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceAverageCalculation")]
        SurfaceAverageCalculation = 2,
    }
}