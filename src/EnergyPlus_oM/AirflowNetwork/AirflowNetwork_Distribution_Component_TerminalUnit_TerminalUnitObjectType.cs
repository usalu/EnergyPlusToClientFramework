namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_Distribution_Component_TerminalUnit_TerminalUnitObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ConstantVolume:Reheat")]
        AirTerminalSingleDuctConstantVolumeReheat = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:VAV:Reheat")]
        AirTerminalSingleDuctVAVReheat = 1,
    }
}