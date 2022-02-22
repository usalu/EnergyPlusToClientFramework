using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"Works in conjunction with a refrigeration chiller set, compressor rack, a refrigeration system, or a refrigeration secondary system to simulate the performance of an air chiller, similar to one found in a refrigerated warehouse. Energy use for fans and heaters is modeled based on inputs for nominal power, schedules, and control type. The air chiller model accounts for the sensible and latent heat exchange with the surrounding environment.")]
    public class Refrigeration_AirChiller : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description(@"In each case, select the rating option that corresponds to the expected service conditions. For example, U.S. manufacturers quote a separate Unit Load Factor for wet or frosted coils. If the evaporating temperature is less than 0C, input the frosted coil value. Within the European convention, select SC1, 2, 3, 4, or 5 depending upon the expected evaporating temperature.")]
        [JsonProperty("capacity_rating_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_AirChiller_CapacityRatingType CapacityRatingType { get; set; } = (Refrigeration_AirChiller_CapacityRatingType)Enum.Parse(typeof(Refrigeration_AirChiller_CapacityRatingType), "CapacityTotalSpecificConditions");
        

        [Description(@"The sensible cooling capacity in watts (W/C) at rated conditions. The value entered for this field must be greater than zero, with no default value. This value is only used if the Capacity Rating Type is UnitLoadFactorSensibleOnly. The value given must be based upon the difference between the chiller inlet and outlet air temperatures, not on the difference between the zone mean temperature and the outlet air temperature")]
        [JsonProperty("rated_unit_load_factor")]
        public System.Nullable<float> RatedUnitLoadFactor { get; set; } = null;
        

        [Description(@"This value is only used if the Capacity Rating Type is NOT UnitLoadFactorSensibleOnly. For CapacityTotalSpecificConditions, this capacity includes both sensible and latent at the conditions given in the next two fields. Note that the European Standard ratings are sensible only and the European Nominal ratings include latent capacity as well. The value given here must correspond to the capacity rating type given previously")]
        [JsonProperty("rated_capacity")]
        public System.Nullable<float> RatedCapacity { get; set; } = null;
        

        [Description("This field is ONLY used if the Capacity Rating Type is CapacityTotalSpecificCondi" +
                     "tions and represents the relative humidity at rated conditions. The default is 8" +
                     "5.")]
        [JsonProperty("rated_relative_humidity")]
        public System.Nullable<float> RatedRelativeHumidity { get; set; } = (System.Nullable<float>)Single.Parse("85", CultureInfo.InvariantCulture);
        

        [Description("If DXEvaporator, use evaporating temperature (saturated suction temperature) If B" +
                     "rineCoil, use Brine entering temperature used to set minimum suction pressure fo" +
                     "r DX systems and minimum brine temp for secondary systems")]
        [JsonProperty("rated_cooling_source_temperature")]
        public System.Nullable<float> RatedCoolingSourceTemperature { get; set; } = null;
        

        [Description("The rated difference between the air entering the refrigeration chiller and the c" +
                     "ooling source temperature in degC.")]
        [JsonProperty("rated_temperature_difference_dt1")]
        public System.Nullable<float> RatedTemperatureDifferenceDt1 { get; set; } = null;
        

        [Description("The maximum difference between the air entering the refrigeration chiller and the" +
                     " cooling source temperature in degC used to limit capacity during pull-down. def" +
                     "aults to 1.3 times the Rated Temperature Difference DT1")]
        [JsonProperty("maximum_temperature_difference_between_inlet_air_and_evaporating_temperature")]
        public System.Nullable<float> MaximumTemperatureDifferenceBetweenInletAirAndEvaporatingTemperature { get; set; } = null;
        

        [Description("This is the manufacturer\'s correction factor for coil material corresponding to r" +
                     "ating")]
        [JsonProperty("coil_material_correction_factor")]
        public System.Nullable<float> CoilMaterialCorrectionFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This is the manufacturer\'s correction factor for refrigerant corresponding to rat" +
                     "ing")]
        [JsonProperty("refrigerant_correction_factor")]
        public System.Nullable<float> RefrigerantCorrectionFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("In each case, select the correction curve type that corresponds to the rating typ" +
                     "e. default LinearSHR60 unless Capacity Rating Type = CapacityTotalSpecificCondit" +
                     "ions")]
        [JsonProperty("capacity_correction_curve_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_AirChiller_CapacityCorrectionCurveType CapacityCorrectionCurveType { get; set; } = (Refrigeration_AirChiller_CapacityCorrectionCurveType)Enum.Parse(typeof(Refrigeration_AirChiller_CapacityCorrectionCurveType), "European");
        

        [Description("Should be blank for LinearSHR60 correction curve type")]
        [JsonProperty("capacity_correction_curve_name")]
        public string CapacityCorrectionCurveName { get; set; } = "";
        

        [Description("only used when the capacity correction curve type is LinearSHR60")]
        [JsonProperty("shr60_correction_factor")]
        public System.Nullable<float> Shr60CorrectionFactor { get; set; } = (System.Nullable<float>)Single.Parse("1.48", CultureInfo.InvariantCulture);
        

        [Description("Include total for all heater power Do not include defrost heater power")]
        [JsonProperty("rated_total_heating_power")]
        public System.Nullable<float> RatedTotalHeatingPower { get; set; } = null;
        

        [Description("Values will be used to multiply the total heating power Values in the schedule sh" +
                     "ould be between 0.0 and 1.0 Defaults to always on if schedule name left blank.")]
        [JsonProperty("heating_power_schedule_name")]
        public string HeatingPowerScheduleName { get; set; } = "";
        

        [JsonProperty("fan_speed_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_AirChiller_FanSpeedControlType FanSpeedControlType { get; set; } = (Refrigeration_AirChiller_FanSpeedControlType)Enum.Parse(typeof(Refrigeration_AirChiller_FanSpeedControlType), "Fixed");
        

        [JsonProperty("rated_fan_power")]
        public System.Nullable<float> RatedFanPower { get; set; } = (System.Nullable<float>)Single.Parse("375", CultureInfo.InvariantCulture);
        

        [JsonProperty("rated_air_flow")]
        public System.Nullable<float> RatedAirFlow { get; set; } = null;
        

        [Description("Minimum air flow fraction through fan")]
        [JsonProperty("minimum_fan_air_flow_ratio")]
        public System.Nullable<float> MinimumFanAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("HotFluid includes either hot gas defrost for a DX system or Hot Brine defrost if " +
                     "this walk in is cooled by brine from a secondary chiller")]
        [JsonProperty("defrost_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_AirChiller_DefrostType DefrostType { get; set; } = (Refrigeration_AirChiller_DefrostType)Enum.Parse(typeof(Refrigeration_AirChiller_DefrostType), "Electric");
        

        [JsonProperty("defrost_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_AirChiller_DefrostControlType DefrostControlType { get; set; } = (Refrigeration_AirChiller_DefrostControlType)Enum.Parse(typeof(Refrigeration_AirChiller_DefrostControlType), "TimeSchedule");
        

        [Description("The schedule values should be 0 (off) or 1 (on)")]
        [JsonProperty("defrost_schedule_name")]
        public string DefrostScheduleName { get; set; } = "";
        

        [Description(@"The schedule values should be 0 (off) or 1 (on) The start time for each defrost period in this drip-down schedule should coincide with the start time for each defrost period in the defrost schedule (previous input field). The length of each defrost drip-down period must be greater than or equal to the corresponding defrost period specified in the defrost schedule. This extra time allows the melted frost to drip from the coil before refrigeration is restarted.")]
        [JsonProperty("defrost_drip_down_schedule_name")]
        public string DefrostDripDownScheduleName { get; set; } = "";
        

        [Description("needed for all defrost types except none and offcycle")]
        [JsonProperty("defrost_power")]
        public System.Nullable<float> DefrostPower { get; set; } = null;
        

        [Description("This is the portion of the defrost energy that is available to melt frost Needed " +
                     "only for defrost control type TemperatureTermination defaults to 0.7 for electri" +
                     "c defrost and to 0.3 for hot fluid defrost")]
        [JsonProperty("temperature_termination_defrost_fraction_to_ice")]
        public System.Nullable<float> TemperatureTerminationDefrostFractionToIce { get; set; } = null;
        

        [JsonProperty("vertical_location")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_AirChiller_VerticalLocation VerticalLocation { get; set; } = (Refrigeration_AirChiller_VerticalLocation)Enum.Parse(typeof(Refrigeration_AirChiller_VerticalLocation), "Middle");
        

        [Description("This value is only used if the Cooling Source Type is DXEvaporator")]
        [JsonProperty("average_refrigerant_charge_inventory")]
        public System.Nullable<float> AverageRefrigerantChargeInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}