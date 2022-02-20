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
    [JsonObject("CoilSystem:Heating:DX")]
    public class CoilSystem_Heating_DX : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("heating_coil_object_type")]
        public EmptyNoYes HeatingCoilObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
    }
}