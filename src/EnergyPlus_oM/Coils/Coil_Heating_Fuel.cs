using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Gas or other fuel heating coil. If the coil is located directly in an air loop branch or outdoor air equipment list, then it is controlled on leaving air temperature and the Temperature Setpoint Node Name must be specified. If the coil is contained within another component such as an air terminal unit, zone HVAC equipment, or unitary system, then the coil is controlled by the parent component and the setpoint node name is not entered.")]
    public class Coil_Heating_Fuel : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("fuel_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Heating_Fuel_FuelType FuelType { get; set; } = (Coil_Heating_Fuel_FuelType)Enum.Parse(typeof(Coil_Heating_Fuel_FuelType), "NaturalGas");
        

        [JsonProperty("burner_efficiency")]
        public System.Nullable<float> BurnerEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty("nominal_capacity")]
        public string NominalCapacity { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("optional, used if coil is temperature control and not load-base controlled")]
        [JsonProperty("temperature_setpoint_node_name")]
        public string TemperatureSetpointNodeName { get; set; } = "";
        

        [Description("parasitic electric load associated with the coil operation such as an inducer fan" +
                     ", etc... This will be modified by the part load ratio to reflect the time of ope" +
                     "ration in a timestep.")]
        [JsonProperty("parasitic_electric_load")]
        public System.Nullable<float> ParasiticElectricLoad { get; set; } = null;
        

        [Description(@"quadratic curve, PLF = a + b*PLR + c*PLR**2 cubic curve, PLF = a + b*PLR + c*PLR**2 + d*PLR**3 PLF = part load fraction PLR = part load ratio (sensible heating load/steady state heating capacity) Coil runtime fraction = Part Load Ratio / PLF This part load degradation is for coil performance & will increase the fuel consumption of the coil due to transient coil operation.")]
        [JsonProperty("part_load_fraction_correlation_curve_name")]
        public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description("parasitic fuel load associated with the coil operation (i.e., standing pilot)")]
        [JsonProperty("parasitic_fuel_load")]
        public System.Nullable<float> ParasiticFuelLoad { get; set; } = null;
    }
}