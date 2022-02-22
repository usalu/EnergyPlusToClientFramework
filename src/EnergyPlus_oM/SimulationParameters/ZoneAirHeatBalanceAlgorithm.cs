using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Determines which algorithm will be used to solve the zone air heat balance.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneAirHeatBalanceAlgorithm : BHoMObject
    {
        

        [JsonProperty("algorithm")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneAirHeatBalanceAlgorithm_Algorithm Algorithm { get; set; } = (ZoneAirHeatBalanceAlgorithm_Algorithm)Enum.Parse(typeof(ZoneAirHeatBalanceAlgorithm_Algorithm), "ThirdOrderBackwardDifference");
    }
}