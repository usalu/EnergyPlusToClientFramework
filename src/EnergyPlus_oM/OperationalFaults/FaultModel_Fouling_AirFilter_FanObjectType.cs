using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_Fouling_AirFilter_FanObjectType
    {
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 0,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 1,
        
        [JsonProperty("Fan:VariableVolume")]
        FanVariableVolume = 2,
    }
}