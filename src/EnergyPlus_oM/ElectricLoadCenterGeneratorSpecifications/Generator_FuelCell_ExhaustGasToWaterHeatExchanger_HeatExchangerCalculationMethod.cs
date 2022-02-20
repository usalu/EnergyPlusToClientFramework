using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_ExhaustGasToWaterHeatExchanger_HeatExchangerCalculationMethod
    {
        
        [JsonProperty("Condensing")]
        Condensing = 0,
        
        [JsonProperty("EmpiricalUAeff")]
        EmpiricalUAeff = 1,
        
        [JsonProperty("FixedEffectiveness")]
        FixedEffectiveness = 2,
        
        [JsonProperty("FundementalUAeff")]
        FundementalUAeff = 3,
    }
}