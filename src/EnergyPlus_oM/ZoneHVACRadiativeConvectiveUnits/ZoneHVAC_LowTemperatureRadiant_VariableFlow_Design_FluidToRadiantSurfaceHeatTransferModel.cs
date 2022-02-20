using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_FluidToRadiantSurfaceHeatTransferModel
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConvectionOnly")]
        ConvectionOnly = 1,
        
        [JsonProperty("ISOStandard")]
        ISOStandard = 2,
    }
}