using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Virtual container component that consists of a DX heating coil (heat pump) and it" +
                 "s associated controls. This control object supports two different types of DX he" +
                 "ating coils and may be placed directly in an air loop branch or outdoor air equi" +
                 "pment list.")]
    public class CoilSystem_Heating_DX : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("heating_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CoilSystem_Heating_DX_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (CoilSystem_Heating_DX_HeatingCoilObjectType)Enum.Parse(typeof(CoilSystem_Heating_DX_HeatingCoilObjectType), "CoilHeatingDXSingleSpeed");
        

        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
    }
}