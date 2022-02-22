using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("DX cooling coil performance for a single operating mode which may have one or mor" +
                 "e speeds.")]
    public class Coil_Cooling_DX_CurveFit_OperatingMode : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"Total (sensible+latent) cooling capacity not accounting for the effect of supply air fan heat. Rating point: air entering the evaporator coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the condenser coil at 35 C dry-bulb/23.9 C wet-bulb. gross capacity excluding supply air fan heat")]
        [JsonProperty("rated_gross_total_cooling_capacity")]
        public string RatedGrossTotalCoolingCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Flow rate corresponding to rated total cooling capacity, Rated SHR and Rated COP." +
                     " Should be between 0.00004027 m3/s and 0.00006041 m3/s per watt of rated total c" +
                     "ooling capacity.")]
        [JsonProperty("rated_evaporator_air_flow_rate")]
        public string RatedEvaporatorAirFlowRate { get; set; } = "";
        

        [Description("Used to calculate evaporative condenser water use.")]
        [JsonProperty("rated_condenser_air_flow_rate")]
        public string RatedCondenserAirFlowRate { get; set; } = "";
        

        [Description("The maximum on-off cycling Rate for the compressor, which occurs at 50% run time " +
                     "fraction. Suggested value is 3; zero value means latent degradation model is dis" +
                     "abled.")]
        [JsonProperty("maximum_cycling_rate")]
        public System.Nullable<float> MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
        [JsonProperty("ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capacity")]
        public System.Nullable<float> RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Time constant for the cooling coil\'s latent capacity to reach steady state after " +
                     "startup. Suggested value is 45; zero value means latent degradation model is dis" +
                     "abled.")]
        [JsonProperty("latent_capacity_time_constant")]
        public System.Nullable<float> LatentCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
        [JsonProperty("nominal_time_for_condensate_removal_to_begin")]
        public System.Nullable<float> NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("apply_latent_degradation_to_speeds_greater_than_1")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ApplyLatentDegradationToSpeedsGreaterThan1 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("condenser_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_CurveFit_OperatingMode_CondenserType CondenserType { get; set; } = (Coil_Cooling_DX_CurveFit_OperatingMode_CondenserType)Enum.Parse(typeof(Coil_Cooling_DX_CurveFit_OperatingMode_CondenserType), "AirCooled");
        

        [Description("Rated power consumed by the evaporative condenser\'s water pump")]
        [JsonProperty("nominal_evaporative_condenser_pump_power")]
        public string NominalEvaporativeCondenserPumpPower { get; set; } = (System.String)"0";
        

        [Description("Must be lower than or equal to the highest speed number. If blank, defaults to th" +
                     "e highest speed number used.")]
        [JsonProperty("nominal_speed_number")]
        public System.Nullable<float> NominalSpeedNumber { get; set; } = null;
        

        [JsonProperty("speed_1_name")]
        public string Speed1Name { get; set; } = "";
        

        [JsonProperty("speed_2_name")]
        public string Speed2Name { get; set; } = "";
        

        [JsonProperty("speed_3_name")]
        public string Speed3Name { get; set; } = "";
        

        [JsonProperty("speed_4_name")]
        public string Speed4Name { get; set; } = "";
        

        [JsonProperty("speed_5_name")]
        public string Speed5Name { get; set; } = "";
        

        [JsonProperty("speed_6_name")]
        public string Speed6Name { get; set; } = "";
        

        [JsonProperty("speed_7_name")]
        public string Speed7Name { get; set; } = "";
        

        [JsonProperty("speed_8_name")]
        public string Speed8Name { get; set; } = "";
        

        [JsonProperty("speed_9_name")]
        public string Speed9Name { get; set; } = "";
        

        [JsonProperty("speed_10_name")]
        public string Speed10Name { get; set; } = "";
    }
}