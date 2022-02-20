using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum OutputControl_SurfaceColorScheme_DrawingElement2Type
    {
        
        [JsonProperty("AttachedBuildingShades")]
        AttachedBuildingShades = 0,
        
        [JsonProperty("DaylightReferencePoint1")]
        DaylightReferencePoint1 = 1,
        
        [JsonProperty("DaylightReferencePoint2")]
        DaylightReferencePoint2 = 2,
        
        [JsonProperty("DetachedBuildingShades")]
        DetachedBuildingShades = 3,
        
        [JsonProperty("DetachedFixedShades")]
        DetachedFixedShades = 4,
        
        [JsonProperty("Doors")]
        Doors = 5,
        
        [JsonProperty("Floors")]
        Floors = 6,
        
        [JsonProperty("GlassDoors")]
        GlassDoors = 7,
        
        [JsonProperty("Photovoltaics")]
        Photovoltaics = 8,
        
        [JsonProperty("Roofs")]
        Roofs = 9,
        
        [JsonProperty("Text")]
        Text = 10,
        
        [JsonProperty("TubularDaylightDiffusers")]
        TubularDaylightDiffusers = 11,
        
        [JsonProperty("TubularDaylightDomes")]
        TubularDaylightDomes = 12,
        
        [JsonProperty("Walls")]
        Walls = 13,
        
        [JsonProperty("Windows")]
        Windows = 14,
    }
}