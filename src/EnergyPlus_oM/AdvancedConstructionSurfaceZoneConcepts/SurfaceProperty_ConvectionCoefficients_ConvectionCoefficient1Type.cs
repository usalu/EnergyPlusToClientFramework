using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Type
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
        
        [JsonProperty("ClearRoof")]
        ClearRoof = 14,
        
        [JsonProperty("DOE-2")]
        DOE2 = 15,
        
        [JsonProperty("EmmelRoof")]
        EmmelRoof = 16,
        
        [JsonProperty("EmmelVertical")]
        EmmelVertical = 17,
        
        [JsonProperty("FisherPedersenCeilingDiffuserCeiling")]
        FisherPedersenCeilingDiffuserCeiling = 18,
        
        [JsonProperty("FisherPedersenCeilingDiffuserFloor")]
        FisherPedersenCeilingDiffuserFloor = 19,
        
        [JsonProperty("FisherPedersenCeilingDiffuserWalls")]
        FisherPedersenCeilingDiffuserWalls = 20,
        
        [JsonProperty("FohannoPolidoriVerticalWall")]
        FohannoPolidoriVerticalWall = 21,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserFloor")]
        GoldsteinNovoselacCeilingDiffuserFloor = 22,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWalls")]
        GoldsteinNovoselacCeilingDiffuserWalls = 23,
        
        [JsonProperty("GoldsteinNovoselacCeilingDiffuserWindow")]
        GoldsteinNovoselacCeilingDiffuserWindow = 24,
        
        [JsonProperty("ISO15099Windows")]
        ISO15099Windows = 25,
        
        [JsonProperty("KaradagChilledCeiling")]
        KaradagChilledCeiling = 26,
        
        [JsonProperty("KhalifaEq3WallAwayFromHeat")]
        KhalifaEq3WallAwayFromHeat = 27,
        
        [JsonProperty("KhalifaEq4CeilingAwayFromHeat")]
        KhalifaEq4CeilingAwayFromHeat = 28,
        
        [JsonProperty("KhalifaEq5WallNearHeat")]
        KhalifaEq5WallNearHeat = 29,
        
        [JsonProperty("KhalifaEq6NonHeatedWalls")]
        KhalifaEq6NonHeatedWalls = 30,
        
        [JsonProperty("KhalifaEq7Ceiling")]
        KhalifaEq7Ceiling = 31,
        
        [JsonProperty("McAdams")]
        McAdams = 32,
        
        [JsonProperty("Mitchell")]
        Mitchell = 33,
        
        [JsonProperty("MoWitt")]
        MoWitt = 34,
        
        [JsonProperty("NusseltJurges")]
        NusseltJurges = 35,
        
        [JsonProperty("Schedule")]
        Schedule = 36,
        
        [JsonProperty("Simple")]
        Simple = 37,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 38,
        
        [JsonProperty("TARP")]
        TARP = 39,
        
        [JsonProperty("UserCurve")]
        UserCurve = 40,
        
        [JsonProperty("Value")]
        Value = 41,
        
        [JsonProperty("WaltonStableHorizontalOrTilt")]
        WaltonStableHorizontalOrTilt = 42,
        
        [JsonProperty("WaltonUnstableHorizontalOrTilt")]
        WaltonUnstableHorizontalOrTilt = 43,
    }
}