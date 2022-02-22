using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Electric heating coil, multi-stage. If the coil is located directly in an air loop branch or outdoor air equipment list, then it is controlled on leaving air temperature and the Temperature Setpoint Node Name must be specified. If the coil is contained within another component such as an air terminal unit, zone HVAC equipment, or unitary system, then the coil is controlled by the parent component and the setpoint node name is not entered.")]
    public class Coil_Heating_Electric_MultiStage : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Required if coil is temperature controlled. controlled")]
        [JsonProperty("temperature_setpoint_node_name")]
        public string TemperatureSetpointNodeName { get; set; } = "";
        

        [Description("Enter the number of the following sets of data for coil capacity and Efficiency.")]
        [JsonProperty("number_of_stages")]
        public System.Nullable<float> NumberOfStages { get; set; } = null;
        

        [JsonProperty("stage_1_efficiency")]
        public System.Nullable<float> Stage1Efficiency { get; set; } = null;
        

        [JsonProperty("stage_1_nominal_capacity")]
        public string Stage1NominalCapacity { get; set; } = "";
        

        [JsonProperty("stage_2_efficiency")]
        public System.Nullable<float> Stage2Efficiency { get; set; } = null;
        

        [JsonProperty("stage_2_nominal_capacity")]
        public string Stage2NominalCapacity { get; set; } = "";
        

        [JsonProperty("stage_3_efficiency")]
        public System.Nullable<float> Stage3Efficiency { get; set; } = null;
        

        [JsonProperty("stage_3_nominal_capacity")]
        public string Stage3NominalCapacity { get; set; } = "";
        

        [JsonProperty("stage_4_efficiency")]
        public System.Nullable<float> Stage4Efficiency { get; set; } = null;
        

        [JsonProperty("stage_4_nominal_capacity")]
        public string Stage4NominalCapacity { get; set; } = "";
    }
}