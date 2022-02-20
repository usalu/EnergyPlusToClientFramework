using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_PowerModule_SkinLossCalculationMode
    {
        
        [JsonProperty("ConstantRate")]
        ConstantRate = 0,
        
        [JsonProperty("QuadraticFunctionOfFuelRate")]
        QuadraticFunctionOfFuelRate = 1,
        
        [JsonProperty("UAForProcessGasTemperature")]
        UAForProcessGasTemperature = 2,
    }
}