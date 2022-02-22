using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Variable refrigerant flow (VRF) direct expansion (DX) cooling coil. Used with Zon" +
                 "eHVAC:TerminalUnit:VariableRefrigerantFlow. Condensing unit is modeled separatel" +
                 "y, see AirConditioner:VariableRefrigerantFlow.")]
    [JsonObject("Coil:Cooling:DX:VariableRefrigerantFlow")]
    public class Coil_Cooling_DX_VariableRefrigerantFlow : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat Cooli" +
                     "ng capacity excluding supply air fan heat")]
        [JsonProperty("gross_rated_total_cooling_capacity")]
        public string GrossRatedTotalCoolingCapacity { get; set; } = "";
        

        [Description("Sensible heat ratio excluding supply air fan heat")]
        [JsonProperty("gross_rated_sensible_heat_ratio")]
        public string GrossRatedSensibleHeatRatio { get; set; } = "";
        

        [Description("Volume flow rate corresponding to rated total cooling capacity should be between " +
                     "0.00004027 m3/s and .00006041 m3/s per watt of rated total cooling capacity")]
        [JsonProperty("rated_air_flow_rate")]
        public string RatedAirFlowRate { get; set; } = "";
        

        [JsonProperty("cooling_capacity_ratio_modifier_function_of_temperature_curve_name")]
        public string CoolingCapacityRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("cooling_capacity_modifier_curve_function_of_flow_fraction_name")]
        public string CoolingCapacityModifierCurveFunctionOfFlowFractionName { get; set; } = "";
        

        [JsonProperty("coil_air_inlet_node")]
        public string CoilAirInletNode { get; set; } = "";
        

        [JsonProperty("coil_air_outlet_node")]
        public string CoilAirOutletNode { get; set; } = "";
        

        [JsonProperty("name_of_water_storage_tank_for_condensate_collection")]
        public string NameOfWaterStorageTankForCondensateCollection { get; set; } = "";
    }
}