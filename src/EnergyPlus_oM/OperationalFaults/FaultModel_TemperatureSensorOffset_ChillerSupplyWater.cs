using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fault of chiller supply water temperature sensor offset")]
    [JsonObject("FaultModel:TemperatureSensorOffset:ChillerSupplyWater")]
    public class FaultModel_TemperatureSensorOffset_ChillerSupplyWater : BHoMObject
    {
        

        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("severity_schedule_name")]
        public string SeverityScheduleName { get; set; } = "";
        

        [Description("Enter the type of a chiller object")]
        [JsonProperty("chiller_object_type")]
        public EmptyNoYes ChillerObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Enter the name of a chiller object")]
        [JsonProperty("chiller_object_name")]
        public string ChillerObjectName { get; set; } = "";
        

        [JsonProperty("reference_sensor_offset")]
        public System.Nullable<float> ReferenceSensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}