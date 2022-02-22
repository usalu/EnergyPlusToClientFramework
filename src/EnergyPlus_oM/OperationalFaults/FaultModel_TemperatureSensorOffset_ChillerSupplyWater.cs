using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fault of chiller supply water temperature sensor offset")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FaultModel_TemperatureSensorOffset_ChillerSupplyWater : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("severity_schedule_name")]
        public string SeverityScheduleName { get; set; } = "";
        

        [Description("Enter the type of a chiller object")]
        [JsonProperty("chiller_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FaultModel_TemperatureSensorOffset_ChillerSupplyWater_ChillerObjectType ChillerObjectType { get; set; } = (FaultModel_TemperatureSensorOffset_ChillerSupplyWater_ChillerObjectType)Enum.Parse(typeof(FaultModel_TemperatureSensorOffset_ChillerSupplyWater_ChillerObjectType), "ChillerAbsorption");
        

        [Description("Enter the name of a chiller object")]
        [JsonProperty("chiller_object_name")]
        public string ChillerObjectName { get; set; } = "";
        

        [JsonProperty("reference_sensor_offset")]
        public System.Nullable<float> ReferenceSensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}