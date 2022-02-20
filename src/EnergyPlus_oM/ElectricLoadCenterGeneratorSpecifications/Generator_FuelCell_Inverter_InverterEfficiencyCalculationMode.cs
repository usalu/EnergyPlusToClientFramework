using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_Inverter_InverterEfficiencyCalculationMode
    {
        
        [JsonProperty("Constant")]
        Constant = 0,
        
        [JsonProperty("Quadratic")]
        Quadratic = 1,
    }
}