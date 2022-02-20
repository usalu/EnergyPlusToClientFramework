using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_SimulationControl_Solver
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConjugateGradient")]
        ConjugateGradient = 1,
        
        [JsonProperty("SkylineLU")]
        SkylineLU = 2,
    }
}