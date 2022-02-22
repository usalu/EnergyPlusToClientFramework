using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Gas heating coil, multi-stage. If the coil is located directly in an air loop branch or outdoor air equipment list, then it is controlled on leaving air temperature and the Temperature Setpoint Node Name must be specified. If the coil is contained within another component such as an air terminal unit, zone HVAC equipment, or unitary system, then the coil is controlled by the parent component and the setpoint node name is not entered.")]
    [JsonObject("Coil:Heating:Gas:MultiStage")]
    public class Coil_Heating_Gas_MultiStage : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("optional, used if coil is temperature control and not load-base controlled.")]
        [JsonProperty("temperature_setpoint_node_name")]
        public string TemperatureSetpointNodeName { get; set; } = "";
        

        [Description(@"quadratic curve, PLF = a + b*PLR + c*PLR**2 cubic curve, PLF = a + b*PLR + c*PLR**2 + d*PLR**3 PLF = part load fraction PLR = part load ratio (sensible heating load/steady state heating capacity) Coil runtime fraction = Part Load Ratio / PLF This part load degradation is for coil performance & will increase the gas consumption of the coil due to transient coil operation.")]
        [JsonProperty("part_load_fraction_correlation_curve_name")]
        public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description("parasitic gas load associated with the gas coil operation (i.e., standing pilot)")]
        [JsonProperty("parasitic_gas_load")]
        public System.Nullable<float> ParasiticGasLoad { get; set; } = null;
        

        [Description("Enter the number of the following sets of data for coil capacity and Gas Burner E" +
                     "fficiency.")]
        [JsonProperty("number_of_stages")]
        public System.Nullable<float> NumberOfStages { get; set; } = null;
        

        [JsonProperty("stage_1_gas_burner_efficiency")]
        public System.Nullable<float> Stage1GasBurnerEfficiency { get; set; } = null;
        

        [JsonProperty("stage_1_nominal_capacity")]
        public string Stage1NominalCapacity { get; set; } = "";
        

        [Description("Stage 1 parasitic electric load associated with the gas coil operation such as an" +
                     " inducer fan, etc. This will be modified by the part load ratio to reflect the t" +
                     "ime of operation in a timestep.")]
        [JsonProperty("stage_1_parasitic_electric_load")]
        public System.Nullable<float> Stage1ParasiticElectricLoad { get; set; } = null;
        

        [JsonProperty("stage_2_gas_burner_efficiency")]
        public System.Nullable<float> Stage2GasBurnerEfficiency { get; set; } = null;
        

        [JsonProperty("stage_2_nominal_capacity")]
        public string Stage2NominalCapacity { get; set; } = "";
        

        [Description("Stage 2 parasitic electric load associated with the gas coil operation such as an" +
                     " inducer fan, etc. This will be modified by the part load ratio to reflect the t" +
                     "ime of operation in a timestep.")]
        [JsonProperty("stage_2_parasitic_electric_load")]
        public System.Nullable<float> Stage2ParasiticElectricLoad { get; set; } = null;
        

        [JsonProperty("stage_3_gas_burner_efficiency")]
        public System.Nullable<float> Stage3GasBurnerEfficiency { get; set; } = null;
        

        [JsonProperty("stage_3_nominal_capacity")]
        public string Stage3NominalCapacity { get; set; } = "";
        

        [Description("Stage 3 parasitic electric load associated with the gas coil operation such as an" +
                     " inducer fan, etc. This will be modified by the part load ratio to reflect the t" +
                     "ime of operation in a timestep.")]
        [JsonProperty("stage_3_parasitic_electric_load")]
        public System.Nullable<float> Stage3ParasiticElectricLoad { get; set; } = null;
        

        [JsonProperty("stage_4_gas_burner_efficiency")]
        public System.Nullable<float> Stage4GasBurnerEfficiency { get; set; } = null;
        

        [JsonProperty("stage_4_nominal_capacity")]
        public string Stage4NominalCapacity { get; set; } = "";
        

        [Description("Stage 4 parasitic electric load associated with the gas coil operation such as an" +
                     " inducer fan, etc. This will be modified by the part load ratio to reflect the t" +
                     "ime of operation in a timestep.")]
        [JsonProperty("stage_4_parasitic_electric_load")]
        public System.Nullable<float> Stage4ParasiticElectricLoad { get; set; } = null;
    }
}