using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fault of thermostat offset")]
    [JsonObject("FaultModel:ThermostatOffset")]
    public class FaultModel_ThermostatOffset : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the name of a ZoneControl:Thermostat object.")]
        [JsonProperty("thermostat_name")]
        public string ThermostatName { get; set; } = "";
        

        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("severity_schedule_name")]
        public string SeverityScheduleName { get; set; } = "";
        

        [JsonProperty("reference_thermostat_offset")]
        public System.Nullable<float> ReferenceThermostatOffset { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
}