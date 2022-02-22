namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    public enum PlantComponent_UserDefined_PlantConnection4LoopFlowRequestMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="NeedsFlowAndTurnsLoopOn")]
        NeedsFlowAndTurnsLoopOn = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NeedsFlowIfLoopOn")]
        NeedsFlowIfLoopOn = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ReceivesWhateverFlowAvailable")]
        ReceivesWhateverFlowAvailable = 2,
    }
}