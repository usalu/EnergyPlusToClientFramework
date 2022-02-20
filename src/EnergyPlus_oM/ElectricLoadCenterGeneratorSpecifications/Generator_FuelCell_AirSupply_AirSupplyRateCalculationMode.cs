using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_AirSupply_AirSupplyRateCalculationMode
    {
        
        [JsonProperty("AirRatiobyStoics")]
        AirRatiobyStoics = 0,
        
        [JsonProperty("QuadraticFunctionofElectricPower")]
        QuadraticFunctionofElectricPower = 1,
        
        [JsonProperty("QuadraticFunctionofFuelRate")]
        QuadraticFunctionofFuelRate = 2,
    }
}