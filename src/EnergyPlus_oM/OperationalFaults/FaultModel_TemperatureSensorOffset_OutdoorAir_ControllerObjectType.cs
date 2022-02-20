using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_TemperatureSensorOffset_OutdoorAir_ControllerObjectType
    {
        
        [JsonProperty("Controller:OutdoorAir")]
        ControllerOutdoorAir = 0,
    }
}