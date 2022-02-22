using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("The number of surfaces can be expanded beyond 100, if necessary, by adding more g" +
                 "roups to the end of the list")]
    public class ZoneHVAC_HighTemperatureRadiant : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Name of zone system is serving")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description(@"Enter the method used to determine the maximum heating power input capacity. HeatingDesignCapacity = > selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea = > selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity = > is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
        [JsonProperty("heating_design_capacity_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_HighTemperatureRadiant_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_HighTemperatureRadiant_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_HighTemperatureRadiant_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

        [Description("Enter the design heating capacity. Required field when the heating design capacit" +
                     "y method HeatingDesignCapacity.")]
        [JsonProperty("heating_design_capacity")]
        public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Enter the heating design capacity per zone floor area. Required field when the he" +
                     "ating design capacity method field is CapacityPerFloorArea.")]
        [JsonProperty("heating_design_capacity_per_floor_area")]
        public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of autosized heating design capacity. Required field when capa" +
                     "city the heating design capacity method field is FractionOfAutosizedHeatingCapac" +
                     "ity.")]
        [JsonProperty("fraction_of_autosized_heating_design_capacity")]
        public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Natural gas or electricity")]
        [JsonProperty("fuel_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_HighTemperatureRadiant_FuelType FuelType { get; set; } = (ZoneHVAC_HighTemperatureRadiant_FuelType)Enum.Parse(typeof(ZoneHVAC_HighTemperatureRadiant_FuelType), "Electricity");
        

        [Description("Not used for non-gas radiant heaters")]
        [JsonProperty("combustion_efficiency")]
        public System.Nullable<float> CombustionEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Radiant+latent+lost fractions must sum to 1 or less, remainder is considered conv" +
                     "ective heat")]
        [JsonProperty("fraction_of_input_converted_to_radiant_energy")]
        public System.Nullable<float> FractionOfInputConvertedToRadiantEnergy { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("fraction_of_input_converted_to_latent_energy")]
        public System.Nullable<float> FractionOfInputConvertedToLatentEnergy { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Fraction of input vented to outdoor environment")]
        [JsonProperty("fraction_of_input_that_is_lost")]
        public System.Nullable<float> FractionOfInputThatIsLost { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Temperature type used to control unit")]
        [JsonProperty("temperature_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_HighTemperatureRadiant_TemperatureControlType TemperatureControlType { get; set; } = (ZoneHVAC_HighTemperatureRadiant_TemperatureControlType)Enum.Parse(typeof(ZoneHVAC_HighTemperatureRadiant_TemperatureControlType), "OperativeTemperature");
        

        [JsonProperty("heating_throttling_range")]
        public System.Nullable<float> HeatingThrottlingRange { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("This setpoint is an \"operative temperature\" setpoint")]
        [JsonProperty("heating_setpoint_temperature_schedule_name")]
        public string HeatingSetpointTemperatureScheduleName { get; set; } = "";
        

        [Description("This will affect thermal comfort but from an energy balance standpoint this value" +
                     " gets added to the convective gains from the radiant heater")]
        [JsonProperty("fraction_of_radiant_energy_incident_on_people")]
        public System.Nullable<float> FractionOfRadiantEnergyIncidentOnPeople { get; set; } = null;
        

        [JsonProperty("surface_fractions")]
        public string SurfaceFractions { get; set; } = "";
    }
}