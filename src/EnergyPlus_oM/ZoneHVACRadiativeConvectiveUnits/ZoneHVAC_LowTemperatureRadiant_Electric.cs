using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("Electric resistance low temperature radiant system")]
    public class ZoneHVAC_LowTemperatureRadiant_Electric : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Name of zone system is serving")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Identifies surfaces that radiant system is embedded in. For a system with multipl" +
                     "e surfaces, enter the name of a ZoneHVAC:LowTemperatureRadiant:SurfaceGroup obje" +
                     "ct.")]
        [JsonProperty("surface_name_or_radiant_surface_group_name")]
        public string SurfaceNameOrRadiantSurfaceGroupName { get; set; } = "";
        

        [Description(@"Enter the method used to determine the maximum electrical heating design capacity. HeatingDesignCapacity = > selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea = > selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity = > is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
        [JsonProperty("heating_design_capacity_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_LowTemperatureRadiant_Electric_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_LowTemperatureRadiant_Electric_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_Electric_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

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
        

        [Description("Temperature used to control unit")]
        [JsonProperty("temperature_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_LowTemperatureRadiant_Electric_TemperatureControlType TemperatureControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_Electric_TemperatureControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_Electric_TemperatureControlType), "MeanAirTemperature");
        

        [Description("How setpoint temperature is defined")]
        [JsonProperty("setpoint_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_LowTemperatureRadiant_Electric_SetpointControlType SetpointControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_Electric_SetpointControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_Electric_SetpointControlType), "HalfFlowPower");
        

        [JsonProperty("heating_throttling_range")]
        public System.Nullable<float> HeatingThrottlingRange { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_setpoint_temperature_schedule_name")]
        public string HeatingSetpointTemperatureScheduleName { get; set; } = "";
    }
}