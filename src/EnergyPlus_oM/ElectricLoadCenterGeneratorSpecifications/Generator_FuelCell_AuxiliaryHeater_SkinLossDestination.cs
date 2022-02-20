using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_AuxiliaryHeater_SkinLossDestination
    {
        
        [JsonProperty("AirInletForFuelCell")]
        AirInletForFuelCell = 0,
        
        [JsonProperty("SurroundingZone")]
        SurroundingZone = 1,
    }
}