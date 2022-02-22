using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes the fouling fault of boilers with water-based heat exchange" +
                 "rs")]
    [JsonObject("FaultModel:Fouling:Boiler")]
    public class FaultModel_Fouling_Boiler : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("severity_schedule_name")]
        public string SeverityScheduleName { get; set; } = "";
        

        [Description("Enter the type of a boiler object The fault applies to the hot-water boilers")]
        [JsonProperty("boiler_object_type")]
        public FaultModel_Fouling_Boiler_BoilerObjectType BoilerObjectType { get; set; } = (FaultModel_Fouling_Boiler_BoilerObjectType)Enum.Parse(typeof(FaultModel_Fouling_Boiler_BoilerObjectType), "BoilerHotWater");
        

        [Description("Enter the name of a Boiler object")]
        [JsonProperty("boiler_object_name")]
        public string BoilerObjectName { get; set; } = "";
        

        [Description("The factor indicates the decrease of the nominal capacity of the boiler It is the" +
                     " ratio between the nominal capacity at fouling case and that at fault free case")]
        [JsonProperty("fouling_factor")]
        public System.Nullable<float> FoulingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}