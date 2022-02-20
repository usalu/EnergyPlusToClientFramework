using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fault of humidistat offset")]
    [JsonObject("FaultModel:HumidistatOffset")]
    public class FaultModel_HumidistatOffset : BHoMObject
    {
        

        [Description("Enter the name of a ZoneControl:Humidistat object.")]
        [JsonProperty("humidistat_name")]
        public string HumidistatName { get; set; } = "";
        

        [Description("Two types are available: Type ThermostatOffsetIndependent Type ThermostatOffsetDe" +
                     "pendent")]
        [JsonProperty("humidistat_offset_type")]
        public EmptyNoYes HumidistatOffsetType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ThermostatOffsetIndependent");
        

        [Description("This field is applicable for Type ThermostatOffsetIndependent")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("This field is applicable for Type ThermostatOffsetIndependent")]
        [JsonProperty("severity_schedule_name")]
        public string SeverityScheduleName { get; set; } = "";
        

        [Description("Required field for Type ThermostatOffsetIndependent")]
        [JsonProperty("reference_humidistat_offset")]
        public System.Nullable<float> ReferenceHumidistatOffset { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of a FaultModel:ThermostatOffset object Required field for Type Th" +
                     "ermostatOffsetDependent")]
        [JsonProperty("related_thermostat_offset_fault_name")]
        public string RelatedThermostatOffsetFaultName { get; set; } = "";
    }
}