using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description(@"Determines which Heat Balance Algorithm will be used for a list of surfaces Allows selectively overriding the global setting in HeatBalanceAlgorithm CTF (Conduction Transfer Functions), EMPD (Effective Moisture Penetration Depth with Conduction Transfer Functions). Advanced/Research Usage: CondFD (Conduction Finite Difference) Advanced/Research Usage: HAMT (Combined Heat And Moisture Finite Element)")]
    [JsonObject("SurfaceProperty:HeatTransferAlgorithm:SurfaceList")]
    public class SurfaceProperty_HeatTransferAlgorithm_SurfaceList : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("algorithm")]
        public SurfaceProperty_HeatTransferAlgorithm_SurfaceList_Algorithm Algorithm { get; set; } = (SurfaceProperty_HeatTransferAlgorithm_SurfaceList_Algorithm)Enum.Parse(typeof(SurfaceProperty_HeatTransferAlgorithm_SurfaceList_Algorithm), "ConductionTransferFunction");
        

        [JsonProperty("surface")]
        public string Surface { get; set; } = "";
    }
}