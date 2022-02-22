namespace BH.oM.Adapters.EnergyPlus.PlantCondenserLoops
{
    public enum PlantLoop_PlantLoopDemandCalculationScheme
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DualSetpointDeadband")]
        DualSetpointDeadband = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SingleSetpoint")]
        SingleSetpoint = 2,
    }
}