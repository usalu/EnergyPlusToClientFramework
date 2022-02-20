using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum CoilSystem_Cooling_DX_HeatExchangerAssisted_HeatExchangerObjectType
    {
        
        [JsonProperty("HeatExchanger:AirToAir:FlatPlate")]
        HeatExchangerAirToAirFlatPlate = 0,
        
        [JsonProperty("HeatExchanger:AirToAir:SensibleAndLatent")]
        HeatExchangerAirToAirSensibleAndLatent = 1,
        
        [JsonProperty("HeatExchanger:Desiccant:BalancedFlow")]
        HeatExchangerDesiccantBalancedFlow = 2,
    }
}