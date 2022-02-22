using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Determines which algorithm will be used to solve the zone air heat balance.")]
    [JsonObject("ZoneAirHeatBalanceAlgorithm")]
    public class ZoneAirHeatBalanceAlgorithm : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("algorithm")]
        public ZoneAirHeatBalanceAlgorithm_Algorithm Algorithm { get; set; } = (ZoneAirHeatBalanceAlgorithm_Algorithm)Enum.Parse(typeof(ZoneAirHeatBalanceAlgorithm_Algorithm), "ThirdOrderBackwardDifference");
    }
}