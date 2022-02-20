using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_Fouling_Chiller_ChillerObjectType
    {
        
        [JsonProperty("Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 0,
        
        [JsonProperty("Chiller:ConstantCOP")]
        ChillerConstantCOP = 1,
        
        [JsonProperty("Chiller:Electric")]
        ChillerElectric = 2,
        
        [JsonProperty("Chiller:Electric:EIR")]
        ChillerElectricEIR = 3,
        
        [JsonProperty("Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 4,
        
        [JsonProperty("Chiller:EngineDriven")]
        ChillerEngineDriven = 5,
    }
}