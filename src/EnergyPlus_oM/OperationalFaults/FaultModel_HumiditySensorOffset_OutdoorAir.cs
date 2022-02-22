using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes outdoor air humidity sensor offset")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FaultModel_HumiditySensorOffset_OutdoorAir : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("severity_schedule_name")]
        public string SeverityScheduleName { get; set; } = "";
        

        [JsonProperty("controller_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FaultModel_HumiditySensorOffset_OutdoorAir_ControllerObjectType ControllerObjectType { get; set; } = (FaultModel_HumiditySensorOffset_OutdoorAir_ControllerObjectType)Enum.Parse(typeof(FaultModel_HumiditySensorOffset_OutdoorAir_ControllerObjectType), "ControllerOutdoorAir");
        

        [JsonProperty("controller_object_name")]
        public string ControllerObjectName { get; set; } = "";
        

        [JsonProperty("humidity_sensor_offset")]
        public System.Nullable<float> HumiditySensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}