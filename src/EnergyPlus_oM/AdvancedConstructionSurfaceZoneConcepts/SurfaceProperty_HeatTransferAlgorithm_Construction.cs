using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description(@"Determines which Heat Balance Algorithm will be used for surfaces that have a specific type of construction Allows selectively overriding the global setting in HeatBalanceAlgorithm CTF (Conduction Transfer Functions), EMPD (Effective Moisture Penetration Depth with Conduction Transfer Functions). Advanced/Research Usage: CondFD (Conduction Finite Difference) Advanced/Research Usage: HAMT (Combined Heat And Moisture Finite Element)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceProperty_HeatTransferAlgorithm_Construction : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("algorithm")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceProperty_HeatTransferAlgorithm_Construction_Algorithm Algorithm { get; set; } = (SurfaceProperty_HeatTransferAlgorithm_Construction_Algorithm)Enum.Parse(typeof(SurfaceProperty_HeatTransferAlgorithm_Construction_Algorithm), "ConductionTransferFunction");
        

        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
    }
}