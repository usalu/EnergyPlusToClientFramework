using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"This is a key object in the new physics based VRF model applicable for Fluid Temperature Control. It describes the the indoor unit coil of the system at heating mode. Used with ZoneHVAC:TerminalUnit:VariableRefrigerantFlow. Outdoor unit is modeled separately, see AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl or AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:HR")]
    public class Coil_Heating_DX_VariableRefrigerantFlow_FluidTemperatureControl : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the name of a schedule that defines the availability of the coil Schedule v" +
                     "alues of 0 denote the unit is off. All other values denote the unit is available" +
                     " If this field is left blank, the unit is available the entire simulation")]
        [JsonProperty("availability_schedule")]
        public string AvailabilitySchedule { get; set; } = "";
        

        [Description("the inlet node to the coil")]
        [JsonProperty("coil_air_inlet_node")]
        public string CoilAirInletNode { get; set; } = "";
        

        [Description("the outlet node to the coil")]
        [JsonProperty("coil_air_outlet_node")]
        public string CoilAirOutletNode { get; set; } = "";
        

        [Description("Supply air fan heat is not included")]
        [JsonProperty("rated_total_heating_capacity")]
        public string RatedTotalHeatingCapacity { get; set; } = "";
        

        [JsonProperty("indoor_unit_reference_subcooling")]
        public System.Nullable<float> IndoorUnitReferenceSubcooling { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty("indoor_unit_condensing_temperature_function_of_subcooling_curve_name")]
        public string IndoorUnitCondensingTemperatureFunctionOfSubcoolingCurveName { get; set; } = "";
    }
}