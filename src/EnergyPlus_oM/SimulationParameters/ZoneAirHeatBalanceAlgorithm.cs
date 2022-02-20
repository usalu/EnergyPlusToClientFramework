using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Determines which algorithm will be used to solve the zone air heat balance.")]
    [JsonObject("ZoneAirHeatBalanceAlgorithm")]
    public class ZoneAirHeatBalanceAlgorithm : BHoMObject
    {
        

        [JsonProperty("algorithm")]
        public EmptyNoYes Algorithm { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ThirdOrderBackwardDifference");
    }
}