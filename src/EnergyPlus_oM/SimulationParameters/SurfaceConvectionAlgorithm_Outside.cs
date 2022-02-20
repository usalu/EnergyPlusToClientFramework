using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Default outside surface heat transfer convection algorithm to be used for all zon" +
                 "es")]
    [JsonObject("SurfaceConvectionAlgorithm:Outside")]
    public class SurfaceConvectionAlgorithm_Outside : BHoMObject
    {
        

        [Description(@"SimpleCombined = Combined radiation and convection coefficient using simple ASHRAE model TARP = correlation from models developed by ASHRAE, Walton, and Sparrow et. al. MoWiTT = correlation from measurements by Klems and Yazdanian for smooth surfaces DOE-2 = correlation from measurements by Klems and Yazdanian for rough surfaces AdaptiveConvectionAlgorithm = dynamic selection of correlations based on conditions")]
        [JsonProperty("algorithm")]
        public EmptyNoYes Algorithm { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "DOE-2");
    }
}