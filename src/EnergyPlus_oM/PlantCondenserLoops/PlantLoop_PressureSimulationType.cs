namespace BH.oM.Adapters.EnergyPlus.PlantCondenserLoops
{
    public enum PlantLoop_PressureSimulationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LoopFlowCorrection")]
        LoopFlowCorrection = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PumpPowerCorrection")]
        PumpPowerCorrection = 3,
    }
}