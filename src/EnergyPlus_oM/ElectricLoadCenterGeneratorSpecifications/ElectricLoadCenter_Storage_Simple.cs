using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Used to model storage of electricity in an electric load center. This is a simple model that does not attempt to represent any of the characteristics of a real storage device such as a battery. The type of power, AC or DC, depends on the configuration chosen as the Electrical Buss Type in the ElectricLoadCenter:Distribution object.")]
    [JsonObject("ElectricLoadCenter:Storage:Simple")]
    public class ElectricLoadCenter_Storage_Simple : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter name of zone to receive storage losses as heat if blank then storage is ass" +
                     "umed to be outdoors")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("radiative_fraction_for_zone_heat_gains")]
        public System.Nullable<float> RadiativeFractionForZoneHeatGains { get; set; } = null;
        

        [JsonProperty("nominal_energetic_efficiency_for_charging")]
        public System.Nullable<float> NominalEnergeticEfficiencyForCharging { get; set; } = null;
        

        [JsonProperty("nominal_discharging_energetic_efficiency")]
        public System.Nullable<float> NominalDischargingEnergeticEfficiency { get; set; } = null;
        

        [JsonProperty("maximum_storage_capacity")]
        public System.Nullable<float> MaximumStorageCapacity { get; set; } = null;
        

        [JsonProperty("maximum_power_for_discharging")]
        public System.Nullable<float> MaximumPowerForDischarging { get; set; } = null;
        

        [JsonProperty("maximum_power_for_charging")]
        public System.Nullable<float> MaximumPowerForCharging { get; set; } = null;
        

        [JsonProperty("initial_state_of_charge")]
        public System.Nullable<float> InitialStateOfCharge { get; set; } = null;
    }
}