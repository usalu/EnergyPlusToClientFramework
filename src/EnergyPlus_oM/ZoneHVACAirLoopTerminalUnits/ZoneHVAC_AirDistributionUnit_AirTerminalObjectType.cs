namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    public enum ZoneHVAC_AirDistributionUnit_AirTerminalObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:DualDuct:ConstantVolume")]
        AirTerminalDualDuctConstantVolume = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:DualDuct:VAV")]
        AirTerminalDualDuctVAV = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:DualDuct:VAV:OutdoorAir")]
        AirTerminalDualDuctVAVOutdoorAir = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ConstantVolume:CooledBeam")]
        AirTerminalSingleDuctConstantVolumeCooledBeam = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ConstantVolume:FourPipeBeam")]
        AirTerminalSingleDuctConstantVolumeFourPipeBeam = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ConstantVolume:FourPipeInduction")]
        AirTerminalSingleDuctConstantVolumeFourPipeInduction = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ConstantVolume:NoReheat")]
        AirTerminalSingleDuctConstantVolumeNoReheat = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ConstantVolume:Reheat")]
        AirTerminalSingleDuctConstantVolumeReheat = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:Mixer")]
        AirTerminalSingleDuctMixer = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:ParallelPIU:Reheat")]
        AirTerminalSingleDuctParallelPIUReheat = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:SeriesPIU:Reheat")]
        AirTerminalSingleDuctSeriesPIUReheat = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:UserDefined")]
        AirTerminalSingleDuctUserDefined = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:VAV:HeatAndCool:NoReheat")]
        AirTerminalSingleDuctVAVHeatAndCoolNoReheat = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:VAV:HeatAndCool:Reheat")]
        AirTerminalSingleDuctVAVHeatAndCoolReheat = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:VAV:NoReheat")]
        AirTerminalSingleDuctVAVNoReheat = 14,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:VAV:Reheat")]
        AirTerminalSingleDuctVAVReheat = 15,
        
        [System.Runtime.Serialization.EnumMember(Value="AirTerminal:SingleDuct:VAV:Reheat:VariableSpeedFan")]
        AirTerminalSingleDuctVAVReheatVariableSpeedFan = 16,
    }
}