using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    public enum AirConditioner_VariableRefrigerantFlow_MasterThermostatPriorityControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LoadPriority")]
        LoadPriority = 1,
        
        [JsonProperty("MasterThermostatPriority")]
        MasterThermostatPriority = 2,
        
        [JsonProperty("Scheduled")]
        Scheduled = 3,
        
        [JsonProperty("ThermostatOffsetPriority")]
        ThermostatOffsetPriority = 4,
        
        [JsonProperty("ZonePriority")]
        ZonePriority = 5,
    }
}