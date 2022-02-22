using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Direct expansion (DX) heating coil for water-to-air heat pump (includes electric " +
                 "compressor), single-speed, equation-fit model. Equation-fit model uses normalize" +
                 "d curves to describe the heat pump performance.")]
    public class Coil_Heating_WaterToAirHeatPump_EquationFit : BHoMObject, IEnergyPlusClass
    {
        

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
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("gross_rated_heating_capacity")]
        public string GrossRatedHeatingCapacity { get; set; } = "";
        

        [JsonProperty("gross_rated_heating_cop")]
        public System.Nullable<float> GrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("heating_capacity_curve_name")]
        public string HeatingCapacityCurveName { get; set; } = "";
        

        [JsonProperty("heating_power_consumption_curve_name")]
        public string HeatingPowerConsumptionCurveName { get; set; } = "";
    }
}