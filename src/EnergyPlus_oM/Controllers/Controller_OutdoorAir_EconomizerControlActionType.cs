namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_OutdoorAir_EconomizerControlActionType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MinimumFlowWithBypass")]
        MinimumFlowWithBypass = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ModulateFlow")]
        ModulateFlow = 2,
    }
}