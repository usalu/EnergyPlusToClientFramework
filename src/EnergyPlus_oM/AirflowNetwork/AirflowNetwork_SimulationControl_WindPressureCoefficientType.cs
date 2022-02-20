using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_SimulationControl_WindPressureCoefficientType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Input")]
        Input = 1,
        
        [JsonProperty("SurfaceAverageCalculation")]
        SurfaceAverageCalculation = 2,
    }
}