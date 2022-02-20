using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum HeatExchanger_FluidToFluid_ControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolingDifferentialOnOff")]
        CoolingDifferentialOnOff = 1,
        
        [JsonProperty("CoolingSetpointModulated")]
        CoolingSetpointModulated = 2,
        
        [JsonProperty("CoolingSetpointOnOff")]
        CoolingSetpointOnOff = 3,
        
        [JsonProperty("CoolingSetpointOnOffWithComponentOverride")]
        CoolingSetpointOnOffWithComponentOverride = 4,
        
        [JsonProperty("DualDeadbandSetpointModulated")]
        DualDeadbandSetpointModulated = 5,
        
        [JsonProperty("DualDeadbandSetpointOnOff")]
        DualDeadbandSetpointOnOff = 6,
        
        [JsonProperty("HeatingSetpointModulated")]
        HeatingSetpointModulated = 7,
        
        [JsonProperty("HeatingSetpointOnOff")]
        HeatingSetpointOnOff = 8,
        
        [JsonProperty("OperationSchemeModulated")]
        OperationSchemeModulated = 9,
        
        [JsonProperty("OperationSchemeOnOff")]
        OperationSchemeOnOff = 10,
        
        [JsonProperty("UncontrolledOn")]
        UncontrolledOn = 11,
    }
}