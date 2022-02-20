using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum ComponentCost_LineItem_LineItemType
    {
        
        [JsonProperty("Chiller:Electric")]
        ChillerElectric = 0,
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 1,
        
        [JsonProperty("Coil:DX")]
        CoilDX = 2,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 3,
        
        [JsonProperty("Construction")]
        Construction = 4,
        
        [JsonProperty("Daylighting:Controls")]
        DaylightingControls = 5,
        
        [JsonProperty("General")]
        General = 6,
        
        [JsonProperty("Generator:Photovoltaic")]
        GeneratorPhotovoltaic = 7,
        
        [JsonProperty("Lights")]
        Lights = 8,
        
        [JsonProperty("Shading:Zone:Detailed")]
        ShadingZoneDetailed = 9,
    }
}