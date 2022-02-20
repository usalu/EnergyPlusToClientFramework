using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_TemperatureSensorOffset_ChillerSupplyWater_ChillerObjectType
    {
        
        [JsonProperty("Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [JsonProperty("Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [JsonProperty("Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [JsonProperty("Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [JsonProperty("Chiller:Electric")]
        ChillerElectric = 4,
        
        [JsonProperty("Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [JsonProperty("Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [JsonProperty("Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
    }
}