using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceProperty_ConvectionCoefficients_MultipleSurface_ConvectionCoefficient2Type
    {
        
        [JsonProperty("ASHRAEVerticalWall")]
        ASHRAEVerticalWall = 0,
        
        [JsonProperty("ASTMC1340")]
        ASTMC1340 = 1,
        
        [JsonProperty("AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 2,
        
        [JsonProperty("AlamdariHammondStableHorizontal")]
        AlamdariHammondStableHorizontal = 3,
        
        [JsonProperty("AlamdariHammondUnstableHorizontal")]
        AlamdariHammondUnstableHorizontal = 4,
        
        [JsonProperty("AlamdariHammondVerticalWall")]
        AlamdariHammondVerticalWall = 5,
        
        [JsonProperty("AwbiHattonHeatedFloor")]
        AwbiHattonHeatedFloor = 6,
        
        [JsonProperty("AwbiHattonHeatedWall")]
        AwbiHattonHeatedWall = 7,
        
        [JsonProperty("BeausoleilMorrisonMixedAssistedWall")]
        BeausoleilMorrisonMixedAssistedWall = 8,
        
        [JsonProperty("BeausoleilMorrisonMixedOpposingWall")]
        BeausoleilMorrisonMixedOpposingWall = 9,
        
        [JsonProperty("BeausoleilMorrisonMixedStableCeiling")]
        BeausoleilMorrisonMixedStableCeiling = 10,
        
        [JsonProperty("BeausoleilMorrisonMixedStableFloor")]
        BeausoleilMorrisonMixedStableFloor = 11,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableCeiling")]
        BeausoleilMorrisonMixedUnstableCeiling = 12,
        
        [JsonProperty("BeausoleilMorrisonMixedUnstableFloor")]
        BeausoleilMorrisonMixedUnstableFloor = 13,
        
        [JsonProperty("BlockenWindard")]
        BlockenWindard = 14,
        
        [JsonProperty("ClearRoof")]
        ClearRoof = 15,
        
        [JsonProperty("DOE-2")]
        DOE2 = 16,
        
        [JsonProperty("EmmelRoof")]
        EmmelRoof = 17,
        
        [JsonProperty("EmmelVertical")]
        EmmelVertical = 18,
        
        [JsonProperty("FisherPedersenCeilingDiffuserCeiling")]
        FisherPedersenCeilingDiffuserCeiling = 19,
        
        [JsonProperty("FisherPedersenCeilingDiffuserFloor")]
        FisherPedersenCeilingDiffuserFloor = 20,
        
        [JsonProperty("FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 21,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 22,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserFloor")]
        GoldsteinNovoselacCeilingDiffuserFloor = 23,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 24,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWindow")]
        GoldsteinNovoselacCeilingDiffuserWindow = 25,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 26,
        
        [JsonProperty("KaradagChilledCeiling")]
        KaradagChilledCeiling = 27,
        
        [JsonProperty("KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 28,
        
        [JsonProperty("KhalifaEq4CeilingAwayFromHeat")]
        KhalifaEq4CeilingAwayFromHeat = 29,
        
        [JsonProperty("KhalifaEq5WallNearHeat")]
        KhalifaEq5WallNearHeat = 30,
        
        [JsonProperty("KhalifaEq6NonHeatedWalls")]
        KhalifaEq6NonHeatedWalls = 31,
        
        [JsonProperty("KhalifaEq7Ceiling")]
        KhalifaEq7Ceiling = 32,
        
        [JsonProperty("McAdams")]
        McAdams = 33,
        
        [JsonProperty("Mitchell")]
        Mitchell = 34,
        
        [JsonProperty("MoWitt")]
        MoWitt = 35,
        
        [JsonProperty("NusseltJurges")]
        NusseltJurges = 36,
        
        [JsonProperty("Schedule")]
        Schedule = 37,
        
        [JsonProperty("Simple")]
        Simple = 38,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 39,
        
        [JsonProperty("TARP")]
        TARP = 40,
        
        [JsonProperty("UserCurve")]
        UserCurve = 41,
        
        [JsonProperty("Value")]
        Value = 42,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 43,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 44,
    }
}