using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Variable refrigerant flow (VRF) direct expansion (DX) heating coil (air-to-air he" +
                 "at pump). Used with ZoneHVAC:TerminalUnit:VariableRefrigerantFlow. Condensing un" +
                 "it is modeled separately, see AirConditioner:VariableRefrigerantFlow.")]
    [JsonObject("Coil:Heating:DX:VariableRefrigerantFlow")]
    public class Coil_Heating_DX_VariableRefrigerantFlow : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule")]
        public string AvailabilitySchedule { get; set; } = "";
        

        [Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outside dry-bulb temp 8.33 C, outside wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wetbulb 15.55 C")]
        [JsonProperty("gross_rated_heating_capacity")]
        public string GrossRatedHeatingCapacity { get; set; } = "";
        

        [Description("volume flow rate corresponding to rated total capacity should be between 0.000040" +
                     "27 m3/s and .00006041 m3/s per watt of rated heating capacity")]
        [JsonProperty("rated_air_flow_rate")]
        public string RatedAirFlowRate { get; set; } = "";
        

        [JsonProperty("coil_air_inlet_node")]
        public string CoilAirInletNode { get; set; } = "";
        

        [JsonProperty("coil_air_outlet_node")]
        public string CoilAirOutletNode { get; set; } = "";
        

        [JsonProperty("heating_capacity_ratio_modifier_function_of_temperature_curve_name")]
        public string HeatingCapacityRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("heating_capacity_modifier_function_of_flow_fraction_curve_name")]
        public string HeatingCapacityModifierFunctionOfFlowFractionCurveName { get; set; } = "";
    }
}