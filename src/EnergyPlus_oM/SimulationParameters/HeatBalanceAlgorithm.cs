using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description(@"Determines which Heat Balance Algorithm will be used ie. CTF (Conduction Transfer Functions), EMPD (Effective Moisture Penetration Depth with Conduction Transfer Functions). Advanced/Research Usage: CondFD (Conduction Finite Difference) Advanced/Research Usage: ConductionFiniteDifferenceSimplified Advanced/Research Usage: HAMT (Combined Heat And Moisture Finite Element)")]
    [JsonObject("HeatBalanceAlgorithm")]
    public class HeatBalanceAlgorithm : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("algorithm")]
        public HeatBalanceAlgorithm_Algorithm Algorithm { get; set; } = (HeatBalanceAlgorithm_Algorithm)Enum.Parse(typeof(HeatBalanceAlgorithm_Algorithm), "ConductionTransferFunction");
        

        [JsonProperty("surface_temperature_upper_limit")]
        public System.Nullable<float> SurfaceTemperatureUpperLimit { get; set; } = (System.Nullable<float>)Single.Parse("200", CultureInfo.InvariantCulture);
        

        [JsonProperty("minimum_surface_convection_heat_transfer_coefficient_value")]
        public System.Nullable<float> MinimumSurfaceConvectionHeatTransferCoefficientValue { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_surface_convection_heat_transfer_coefficient_value")]
        public System.Nullable<float> MaximumSurfaceConvectionHeatTransferCoefficientValue { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
    }
}