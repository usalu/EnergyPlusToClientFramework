using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_Photovoltaic_HeatTransferIntegrationMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Decoupled")]
        Decoupled = 1,
        
        [JsonProperty("DecoupledUllebergDynamic")]
        DecoupledUllebergDynamic = 2,
        
        [JsonProperty("IntegratedExteriorVentedCavity")]
        IntegratedExteriorVentedCavity = 3,
        
        [JsonProperty("IntegratedSurfaceOutsideFace")]
        IntegratedSurfaceOutsideFace = 4,
        
        [JsonProperty("IntegratedTranspiredCollector")]
        IntegratedTranspiredCollector = 5,
        
        [JsonProperty("PhotovoltaicThermalSolarCollector")]
        PhotovoltaicThermalSolarCollector = 6,
    }
}