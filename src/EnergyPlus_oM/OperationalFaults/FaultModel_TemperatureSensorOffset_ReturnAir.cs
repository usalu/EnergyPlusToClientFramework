using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes return air temperature sensor offset")]
    [JsonObject("FaultModel:TemperatureSensorOffset:ReturnAir")]
    public class FaultModel_TemperatureSensorOffset_ReturnAir : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("severity_schedule_name")]
        public string SeverityScheduleName { get; set; } = "";
        

        [JsonProperty("controller_object_type")]
        public FaultModel_TemperatureSensorOffset_ReturnAir_ControllerObjectType ControllerObjectType { get; set; } = (FaultModel_TemperatureSensorOffset_ReturnAir_ControllerObjectType)Enum.Parse(typeof(FaultModel_TemperatureSensorOffset_ReturnAir_ControllerObjectType), "ControllerOutdoorAir");
        

        [JsonProperty("controller_object_name")]
        public string ControllerObjectName { get; set; } = "";
        

        [JsonProperty("temperature_sensor_offset")]
        public System.Nullable<float> TemperatureSensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}