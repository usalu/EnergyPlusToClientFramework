using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    public enum AirTerminal_SingleDuct_Mixer_ZonehvacUnitObjectType
    {
        
        [JsonProperty("AirLoopHVAC:UnitarySystem")]
        AirLoopHVACUnitarySystem = 0,
        
        [JsonProperty("ZoneHVAC:FourPipeFanCoil")]
        ZoneHVACFourPipeFanCoil = 1,
        
        [JsonProperty("ZoneHVAC:PackagedTerminalAirConditioner")]
        ZoneHVACPackagedTerminalAirConditioner = 2,
        
        [JsonProperty("ZoneHVAC:PackagedTerminalHeatPump")]
        ZoneHVACPackagedTerminalHeatPump = 3,
        
        [JsonProperty("ZoneHVAC:TerminalUnit:VariableRefrigerantFlow")]
        ZoneHVACTerminalUnitVariableRefrigerantFlow = 4,
        
        [JsonProperty("ZoneHVAC:UnitVentilator")]
        ZoneHVACUnitVentilator = 5,
        
        [JsonProperty("ZoneHVAC:WaterToAirHeatPump")]
        ZoneHVACWaterToAirHeatPump = 6,
    }
}