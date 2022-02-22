using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Direct expansion (DX) cooling coil for water-to-air heat pump (includes electric compressor), single-speed, equation-fit model. Optional inputs for moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Equation-fit model uses normalized curves to describe the heat pump performance.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Cooling_WaterToAirHeatPump_EquationFit : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("water_inlet_node_name")]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty("water_outlet_node_name")]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("rated_air_flow_rate")]
        public string RatedAirFlowRate { get; set; } = "";
        

        [JsonProperty("rated_water_flow_rate")]
        public string RatedWaterFlowRate { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("gross_rated_total_cooling_capacity")]
        public string GrossRatedTotalCoolingCapacity { get; set; } = "";
        

        [JsonProperty("gross_rated_sensible_cooling_capacity")]
        public string GrossRatedSensibleCoolingCapacity { get; set; } = "";
        

        [JsonProperty("gross_rated_cooling_cop")]
        public System.Nullable<float> GrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty("total_cooling_capacity_curve_name")]
        public string TotalCoolingCapacityCurveName { get; set; } = "";
        

        [JsonProperty("sensible_cooling_capacity_curve_name")]
        public string SensibleCoolingCapacityCurveName { get; set; } = "";
        

        [JsonProperty("cooling_power_consumption_curve_name")]
        public string CoolingPowerConsumptionCurveName { get; set; } = "";
        

        [Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
        [JsonProperty("nominal_time_for_condensate_removal_to_begin")]
        public System.Nullable<float> NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
        [JsonProperty("ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capacity")]
        public System.Nullable<float> RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}