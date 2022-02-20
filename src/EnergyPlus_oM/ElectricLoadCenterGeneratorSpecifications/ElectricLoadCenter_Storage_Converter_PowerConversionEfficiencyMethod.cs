using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum ElectricLoadCenter_Storage_Converter_PowerConversionEfficiencyMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FunctionOfPower")]
        FunctionOfPower = 1,
        
        [JsonProperty("SimpleFixed")]
        SimpleFixed = 2,
    }
}