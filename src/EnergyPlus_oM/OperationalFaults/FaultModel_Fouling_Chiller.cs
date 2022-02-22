using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes the fouling fault of chillers with water-cooled condensers")]
    public class FaultModel_Fouling_Chiller : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("severity_schedule_name")]
        public string SeverityScheduleName { get; set; } = "";
        

        [Description("Enter the type of a chiller object The fault applies to the chillers with water-c" +
                     "ooled condensers")]
        [JsonProperty("chiller_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FaultModel_Fouling_Chiller_ChillerObjectType ChillerObjectType { get; set; } = (FaultModel_Fouling_Chiller_ChillerObjectType)Enum.Parse(typeof(FaultModel_Fouling_Chiller_ChillerObjectType), "ChillerCombustionTurbine");
        

        [Description("Enter the name of a chiller object")]
        [JsonProperty("chiller_object_name")]
        public string ChillerObjectName { get; set; } = "";
        

        [Description("The factor indicates the decrease of the nominal capacity of the chiller It is th" +
                     "e ratio between the nominal capacity at fouling case and that at fault free case" +
                     "")]
        [JsonProperty("fouling_factor")]
        public System.Nullable<float> FoulingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}