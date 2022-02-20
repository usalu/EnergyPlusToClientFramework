using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_AuxiliaryHeater_HeatingCapacityUnits
    {
        
        [JsonProperty("Watts")]
        Watts = 0,
        
        [JsonProperty("kmol/s")]
        Kmols = 1,
    }
}