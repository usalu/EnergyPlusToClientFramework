using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fault of thermostat offset")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FaultModel_ThermostatOffset : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

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