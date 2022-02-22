using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Electric power inverter to convert from direct current (DC) to alternating curren" +
                 "t (AC) in an electric load center that contains photovoltaic modules. This input" +
                 " object is for the simplest inverter model and uses a fixed efficiency.")]
    public class ElectricLoadCenter_Inverter_Simple : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("enter name of zone to receive inverter losses as heat if blank then inverter is a" +
                     "ssumed to be outdoors")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("radiative_fraction")]
        public System.Nullable<float> RadiativeFraction { get; set; } = null;
        

        [JsonProperty("inverter_efficiency")]
        public System.Nullable<float> InverterEfficiency { get; set; } = null;
    }
}