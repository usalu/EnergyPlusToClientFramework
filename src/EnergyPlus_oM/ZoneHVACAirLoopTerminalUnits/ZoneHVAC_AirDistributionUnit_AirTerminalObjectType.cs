using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    public enum ZoneHVAC_AirDistributionUnit_AirTerminalObjectType
    {
        
        [JsonProperty("AirTerminal:DualDuct:ConstantVolume")]
        AirTerminalDualDuctConstantVolume = 0,
        
        [JsonProperty("AirTerminal:DualDuct:VAV")]
        AirTerminalDualDuctVAV = 1,
        
        [JsonProperty("AirTerminal:DualDuct:VAV:OutdoorAir")]
        AirTerminalDualDuctVAVOutdoorAir = 2,
        
        [JsonProperty("AirTerminal:SingleDuct:ConstantVolume:CooledBeam")]
        AirTerminalSingleDuctConstantVolumeCooledBeam = 3,
        
        [JsonProperty("AirTerminal:SingleDuct:ConstantVolume:FourPipeBeam")]
        AirTerminalSingleDuctConstantVolumeFourPipeBeam = 4,
        
        [JsonProperty("AirTerminal:SingleDuct:ConstantVolume:FourPipeInduction")]
        AirTerminalSingleDuctConstantVolumeFourPipeInduction = 5,
        
        [JsonProperty("AirTerminal:SingleDuct:ConstantVolume:NoReheat")]
        AirTerminalSingleDuctConstantVolumeNoReheat = 6,
        
        [JsonProperty("AirTerminal:SingleDuct:ConstantVolume:Reheat")]
        AirTerminalSingleDuctConstantVolumeReheat = 7,
        
        [JsonProperty("AirTerminal:SingleDuct:Mixer")]
        AirTerminalSingleDuctMixer = 8,
        
        [JsonProperty("AirTerminal:SingleDuct:ParallelPIU:Reheat")]
        AirTerminalSingleDuctParallelPIUReheat = 9,
        
        [JsonProperty("AirTerminal:SingleDuct:SeriesPIU:Reheat")]
        AirTerminalSingleDuctSeriesPIUReheat = 10,
        
        [JsonProperty("AirTerminal:SingleDuct:UserDefined")]
        AirTerminalSingleDuctUserDefined = 11,
        
        [JsonProperty("AirTerminal:SingleDuct:VAV:HeatAndCool:NoReheat")]
        AirTerminalSingleDuctVAVHeatAndCoolNoReheat = 12,
        
        [JsonProperty("AirTerminal:SingleDuct:VAV:HeatAndCool:Reheat")]
        AirTerminalSingleDuctVAVHeatAndCoolReheat = 13,
        
        [JsonProperty("AirTerminal:SingleDuct:VAV:NoReheat")]
        AirTerminalSingleDuctVAVNoReheat = 14,
        
        [JsonProperty("AirTerminal:SingleDuct:VAV:Reheat")]
        AirTerminalSingleDuctVAVReheat = 15,
        
        [JsonProperty("AirTerminal:SingleDuct:VAV:Reheat:VariableSpeedFan")]
        AirTerminalSingleDuctVAVReheatVariableSpeedFan = 16,
    }
}