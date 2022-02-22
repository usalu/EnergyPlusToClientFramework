using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fault of coil supply air temperature sensor offset")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FaultModel_TemperatureSensorOffset_CoilSupplyAir : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("severity_schedule_name")]
        public string SeverityScheduleName { get; set; } = "";
        

        [Description("Enter the type of the coil affected")]
        [JsonProperty("coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FaultModel_TemperatureSensorOffset_CoilSupplyAir_CoilObjectType CoilObjectType { get; set; } = (FaultModel_TemperatureSensorOffset_CoilSupplyAir_CoilObjectType)Enum.Parse(typeof(FaultModel_TemperatureSensorOffset_CoilSupplyAir_CoilObjectType), "AirLoopHVACUnitarySystem");
        

        [Description("Enter the name of the coil affected")]
        [JsonProperty("coil_object_name")]
        public string CoilObjectName { get; set; } = "";
        

        [Description("Enter the name of controller for the water coil affected Required for water coils" +
                     "")]
        [JsonProperty("water_coil_controller_name")]
        public string WaterCoilControllerName { get; set; } = "";
        

        [JsonProperty("reference_sensor_offset")]
        public System.Nullable<float> ReferenceSensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}