using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_PowerModule_EfficiencyCurveMode
    {
        
        [JsonProperty("Annex42")]
        Annex42 = 0,
        
        [JsonProperty("Normalized")]
        Normalized = 1,
    }
}