namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ShadowCalculation_SkyDiffuseModelingAlgorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DetailedSkyDiffuseModeling")]
        DetailedSkyDiffuseModeling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SimpleSkyDiffuseModeling")]
        SimpleSkyDiffuseModeling = 2,
    }
}