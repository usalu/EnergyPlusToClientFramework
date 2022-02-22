namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using BH.oM.Base;
    using BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts;
    using BH.oM.Adapters.EnergyPlus.AirDistribution;
    using BH.oM.Adapters.EnergyPlus.AirflowNetwork;
    using BH.oM.Adapters.EnergyPlus.Coils;
    using BH.oM.Adapters.EnergyPlus.ComplianceObjects;
    using BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers;
    using BH.oM.Adapters.EnergyPlus.Controllers;
    using BH.oM.Adapters.EnergyPlus.Daylighting;
    using BH.oM.Adapters.EnergyPlus.DemandLimitingControls;
    using BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer;
    using BH.oM.Adapters.EnergyPlus.Economics;
    using BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications;
    using BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS;
    using BH.oM.Adapters.EnergyPlus.EvaporativeCoolers;
    using BH.oM.Adapters.EnergyPlus.ExteriorEquipment;
    using BH.oM.Adapters.EnergyPlus.ExternalInterface;
    using BH.oM.Adapters.EnergyPlus.Fans;
    using BH.oM.Adapters.EnergyPlus.FluidProperties;
    using BH.oM.Adapters.EnergyPlus.GeneralDataEntry;
    using BH.oM.Adapters.EnergyPlus.HeatRecovery;
    using BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers;
    using BH.oM.Adapters.EnergyPlus.HVACDesignObjects;
    using BH.oM.Adapters.EnergyPlus.HVACTemplates;
    using BH.oM.Adapters.EnergyPlus.HybridModel;
    using BH.oM.Adapters.EnergyPlus.InternalGains;
    using BH.oM.Adapters.EnergyPlus.NodeBranchManagement;
    using BH.oM.Adapters.EnergyPlus.NonZoneEquipment;
    using BH.oM.Adapters.EnergyPlus.OperationalFaults;
    using BH.oM.Adapters.EnergyPlus.OutputReporting;
    using BH.oM.Adapters.EnergyPlus.Parametrics;
    using BH.oM.Adapters.EnergyPlus.PerformanceCurves;
    using BH.oM.Adapters.EnergyPlus.PerformanceTables;
    using BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserFlowControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserLoops;
    using BH.oM.Adapters.EnergyPlus.Pumps;
    using BH.oM.Adapters.EnergyPlus.PythonPluginSystem;
    using BH.oM.Adapters.EnergyPlus.Refrigeration;
    using BH.oM.Adapters.EnergyPlus.RoomAirModels;
    using BH.oM.Adapters.EnergyPlus.Schedules;
    using BH.oM.Adapters.EnergyPlus.SetpointManagers;
    using BH.oM.Adapters.EnergyPlus.SimulationParameters;
    using BH.oM.Adapters.EnergyPlus.SolarCollectors;
    using BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements;
    using BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers;
    using BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces;
    using BH.oM.Adapters.EnergyPlus.UnitaryEquipment;
    using BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels;
    using BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment;
    using BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage;
    using BH.oM.Adapters.EnergyPlus.WaterSystems;
    using BH.oM.Adapters.EnergyPlus.ZoneAirflow;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("Specifies the building\'s location. Only one location is allowed. Weather data fil" +
        "e location, if it exists, will override this object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_Location : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("+ is North, - is South, degree minutes represented in decimal (i.e. 30 minutes is" +
    " .5)")]
[JsonProperty("latitude")]
public System.Nullable<float> Latitude { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("- is West, + is East, degree minutes represented in decimal (i.e. 30 minutes is ." +
    "5)")]
[JsonProperty("longitude")]
public System.Nullable<float> Longitude { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("basic these limits on the WorldTimeZone Map (2003) Time relative to GMT. Decimal " +
    "hours.")]
[JsonProperty("time_zone")]
public System.Nullable<float> TimeZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("elevation")]
public System.Nullable<float> Elevation { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description("Captures the scheduling of a moving/reorienting building, or more likely a vessel" +
        "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_VariableLocation : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("The name of a schedule that defines the latitude of the building at any time. If " +
    "not entered, the latitude defined in the Site:Location, or the default latitude," +
    " will be used for the entirety of the simulation")]
[JsonProperty("building_location_latitude_schedule")]
public string BuildingLocationLatitudeSchedule { get; set; } = "";
        

[Description("The name of a schedule that defines the longitude of the building at any time. If" +
    " not entered, the longitude defined in the Site:Location, or the default longitu" +
    "de, will be used for the entirety of the simulation")]
[JsonProperty("building_location_longitude_schedule")]
public string BuildingLocationLongitudeSchedule { get; set; } = "";
        

[Description(@"The name of a schedule that defines the orientation of the building at any time. This orientation is based on a change from the original orientation. -- NEED TO REFINE THIS If not entered, the original orientation will be used for the entirety of the simulation")]
[JsonProperty("building_location_orientation_schedule")]
public string BuildingLocationOrientationSchedule { get; set; } = "";
    }
    
    [Description(@"The design day object creates the parameters for the program to create the 24 hour weather profile that can be used for sizing as well as running to test the other simulation parameters. Parameters in this include a date (month and day), a day type (which uses the appropriate schedules for either sizing or simple tests), min/max temperatures, wind speeds, and solar radiation values.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SizingPeriod_DesignDay : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("month")]
public System.Nullable<float> Month { get; set; } = null;
        

[Description("must be valid for Month field")]
[JsonProperty("day_of_month")]
public System.Nullable<float> DayOfMonth { get; set; } = null;
        

[Description("Day Type selects the schedules appropriate for this design day")]
[JsonProperty("day_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public SizingPeriod_DesignDay_DayType DayType { get; set; } = (SizingPeriod_DesignDay_DayType)Enum.Parse(typeof(SizingPeriod_DesignDay_DayType), "CustomDay1");
        

[Description("This field is required when field \"Dry-Bulb Temperature Range Modifier Type\" is n" +
    "ot \"TemperatureProfileSchedule\".")]
[JsonProperty("maximum_dry_bulb_temperature")]
public System.Nullable<float> MaximumDryBulbTemperature { get; set; } = null;
        

[Description("Must still produce appropriate maximum dry-bulb (within range) This field is not " +
    "needed if Dry-Bulb Temperature Range Modifier Type is \"delta\".")]
[JsonProperty("daily_dry_bulb_temperature_range")]
public System.Nullable<float> DailyDryBulbTemperatureRange { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Type of modifier to the dry-bulb temperature calculated for the timestep")]
[JsonProperty("dry_bulb_temperature_range_modifier_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public SizingPeriod_DesignDay_DryBulbTemperatureRangeModifierType DryBulbTemperatureRangeModifierType { get; set; } = (SizingPeriod_DesignDay_DryBulbTemperatureRangeModifierType)Enum.Parse(typeof(SizingPeriod_DesignDay_DryBulbTemperatureRangeModifierType), "DefaultMultipliers");
        

[Description(@"Only used when previous field is ""MultiplierSchedule"", ""DifferenceSchedule"" or ""TemperatureProfileSchedule"". For type ""MultiplierSchedule""  the hour/time interval values should specify the fraction (0-1) of the dry-bulb temperature range to be subtracted from the maximum dry-bulb temperature for each timestep in the day For type ""DifferenceSchedule"" the values should specify a number to be subtracted from the maximum dry-bulb temperature for each timestep in the day. Note that numbers in the difference schedule cannot be negative as that would result in a higher maximum than the maximum previously specified. For type ""TemperatureProfileSchedule"" the values should specify the actual dry-bulb temperature for each timestep in the day.")]
[JsonProperty("dry_bulb_temperature_range_modifier_day_schedule_name")]
public string DryBulbTemperatureRangeModifierDayScheduleName { get; set; } = "";
        

[Description("values/schedules indicated here and in subsequent fields create the humidity valu" +
    "es in the 24 hour design day conditions profile.")]
[JsonProperty("humidity_condition_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public SizingPeriod_DesignDay_HumidityConditionType HumidityConditionType { get; set; } = (SizingPeriod_DesignDay_HumidityConditionType)Enum.Parse(typeof(SizingPeriod_DesignDay_HumidityConditionType), "WetBulb");
        

[Description("Wetbulb or dewpoint temperature coincident with the maximum temperature. Required" +
    " only if field Humidity Condition Type is \"Wetbulb\", \"Dewpoint\", \"WetBulbProfile" +
    "MultiplierSchedule\", \"WetBulbProfileDifferenceSchedule\", or \"WetBulbProfileDefau" +
    "ltMultipliers\"")]
[JsonProperty("wetbulb_or_dewpoint_at_maximum_dry_bulb")]
public System.Nullable<float> WetbulbOrDewpointAtMaximumDryBulb { get; set; } = null;
        

[Description(@"Only used when Humidity Condition Type is ""RelativeHumiditySchedule"", ""WetBulbProfileMultiplierSchedule"", or ""WetBulbProfileDifferenceSchedule"" For type ""RelativeHumiditySchedule"", the hour/time interval values should specify relative humidity (percent) from 0.0 to 100.0. For type ""WetBulbProfileMultiplierSchedule"" the hour/time interval values should specify the fraction (0-1) of the wet-bulb temperature range to be subtracted from the maximum wet-bulb temperature for each timestep in the day (units = Fraction) For type ""WetBulbProfileDifferenceSchedule"" the values should specify a number to be subtracted from the maximum wet-bulb temperature for each timestep in the day. (units = deltaC)")]
[JsonProperty("humidity_condition_day_schedule_name")]
public string HumidityConditionDayScheduleName { get; set; } = "";
        

[Description("Humidity ratio coincident with the maximum temperature (constant humidity ratio t" +
    "hroughout day). Required only if field Humidity Condition Type is \"HumidityRatio" +
    "\".")]
[JsonProperty("humidity_ratio_at_maximum_dry_bulb")]
public System.Nullable<float> HumidityRatioAtMaximumDryBulb { get; set; } = null;
        

[Description("Enthalpy coincident with the maximum temperature. Required only if field Humidity" +
    " Condition Type is \"Enthalpy\".")]
[JsonProperty("enthalpy_at_maximum_dry_bulb")]
public System.Nullable<float> EnthalpyAtMaximumDryBulb { get; set; } = null;
        

[Description("Required only if Humidity Condition Type = \"WetbulbProfileMultiplierSchedule\" or " +
    "\"WetBulbProfileDefaultMultipliers\"")]
[JsonProperty("daily_wet_bulb_temperature_range")]
public System.Nullable<float> DailyWetBulbTemperatureRange { get; set; } = null;
        

[Description("This field\'s value is also checked against the calculated \"standard barometric pr" +
    "essure\" for the location. If out of range (>10%) or blank, then is replaced by s" +
    "tandard value.")]
[JsonProperty("barometric_pressure")]
public System.Nullable<float> BarometricPressure { get; set; } = null;
        

[JsonProperty("wind_speed")]
public System.Nullable<float> WindSpeed { get; set; } = null;
        

[Description("North=0.0 East=90.0 0 and 360 are the same direction.")]
[JsonProperty("wind_direction")]
public System.Nullable<float> WindDirection { get; set; } = null;
        

[Description("Yes is raining (all day), No is not raining")]
[JsonProperty("rain_indicator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes RainIndicator { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Yes is Snow on Ground, No is no Snow on Ground")]
[JsonProperty("snow_indicator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes SnowIndicator { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Yes -- use schedules modified for Daylight Saving Time Schedules. No - do not use" +
    " schedules modified for Daylight Saving Time Schedules")]
[JsonProperty("daylight_saving_time_indicator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes DaylightSavingTimeIndicator { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("solar_model_indicator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public SizingPeriod_DesignDay_SolarModelIndicator SolarModelIndicator { get; set; } = (SizingPeriod_DesignDay_SolarModelIndicator)Enum.Parse(typeof(SizingPeriod_DesignDay_SolarModelIndicator), "ASHRAEClearSky");
        

[Description("if Solar Model Indicator = Schedule, then beam schedule name (for day)")]
[JsonProperty("beam_solar_day_schedule_name")]
public string BeamSolarDayScheduleName { get; set; } = "";
        

[Description("if Solar Model Indicator = Schedule, then diffuse schedule name (for day)")]
[JsonProperty("diffuse_solar_day_schedule_name")]
public string DiffuseSolarDayScheduleName { get; set; } = "";
        

[Description("Required if Solar Model Indicator = ASHRAETau or ASHRAETau2017 ASHRAETau2017 sola" +
    "r model can be used with 2013 and 2017 HOF matching taub")]
[JsonProperty("ashrae_clear_sky_optical_depth_for_beam_irradiance_taub_")]
public System.Nullable<float> AshraeClearSkyOpticalDepthForBeamIrradianceTaub { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Required if Solar Model Indicator = ASHRAETau or ASHRAETau2017 ASHRAETau2017 sola" +
    "r model can be used with 2013 and 2017 HOF matching taud")]
[JsonProperty("ashrae_clear_sky_optical_depth_for_diffuse_irradiance_taud_")]
public System.Nullable<float> AshraeClearSkyOpticalDepthForDiffuseIrradianceTaud { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used if Sky Model Indicator = ASHRAEClearSky or ZhangHuang 0.0 is totally unclear" +
    ", 1.0 is totally clear")]
[JsonProperty("sky_clearness")]
public System.Nullable<float> SkyClearness { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("If used this design day will be run with a custom limit on the maximum number of " +
    "days that are repeated for warmup. Limiting the number of warmup days can improv" +
    "e run time.")]
[JsonProperty("maximum_number_warmup_days")]
public System.Nullable<float> MaximumNumberWarmupDays { get; set; } = null;
        

[Description("If used this can control if you want the thermal history to be reset at the begin" +
    "ning of the design day. When using a series of similiar design days, this field " +
    "can be used to retain warmup state from the previous design day.")]
[JsonProperty("begin_environment_reset_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public SizingPeriod_DesignDay_BeginEnvironmentResetMode BeginEnvironmentResetMode { get; set; } = (SizingPeriod_DesignDay_BeginEnvironmentResetMode)Enum.Parse(typeof(SizingPeriod_DesignDay_BeginEnvironmentResetMode), "FullResetAtBeginEnvironment");
    }
    
    public enum SizingPeriod_DesignDay_DayType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="CustomDay1")]
        CustomDay1 = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CustomDay2")]
        CustomDay2 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Friday")]
        Friday = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Holiday")]
        Holiday = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Monday")]
        Monday = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Saturday")]
        Saturday = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="SummerDesignDay")]
        SummerDesignDay = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Sunday")]
        Sunday = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Thursday")]
        Thursday = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Tuesday")]
        Tuesday = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Wednesday")]
        Wednesday = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="WinterDesignDay")]
        WinterDesignDay = 11,
    }
    
    public enum SizingPeriod_DesignDay_DryBulbTemperatureRangeModifierType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DefaultMultipliers")]
        DefaultMultipliers = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferenceSchedule")]
        DifferenceSchedule = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MultiplierSchedule")]
        MultiplierSchedule = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureProfileSchedule")]
        TemperatureProfileSchedule = 4,
    }
    
    public enum SizingPeriod_DesignDay_HumidityConditionType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DewPoint")]
        DewPoint = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Enthalpy")]
        Enthalpy = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HumidityRatio")]
        HumidityRatio = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="RelativeHumiditySchedule")]
        RelativeHumiditySchedule = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="WetBulb")]
        WetBulb = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="WetBulbProfileDefaultMultipliers")]
        WetBulbProfileDefaultMultipliers = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="WetBulbProfileDifferenceSchedule")]
        WetBulbProfileDifferenceSchedule = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="WetBulbProfileMultiplierSchedule")]
        WetBulbProfileMultiplierSchedule = 8,
    }
    
    public enum SizingPeriod_DesignDay_SolarModelIndicator
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAEClearSky")]
        ASHRAEClearSky = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAETau")]
        ASHRAETau = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ASHRAETau2017")]
        ASHRAETau2017 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ZhangHuang")]
        ZhangHuang = 5,
    }
    
    public enum SizingPeriod_DesignDay_BeginEnvironmentResetMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FullResetAtBeginEnvironment")]
        FullResetAtBeginEnvironment = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SuppressAllBeginEnvironmentResets")]
        SuppressAllBeginEnvironmentResets = 2,
    }
    
    [Description("Use a weather file period for design sizing calculations.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SizingPeriod_WeatherFileDays : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("begin_month")]
public System.Nullable<float> BeginMonth { get; set; } = null;
        

[JsonProperty("begin_day_of_month")]
public System.Nullable<float> BeginDayOfMonth { get; set; } = null;
        

[JsonProperty("end_month")]
public System.Nullable<float> EndMonth { get; set; } = null;
        

[JsonProperty("end_day_of_month")]
public System.Nullable<float> EndDayOfMonth { get; set; } = null;
        

[Description(@"=[|Sunday|Monday|Tuesday|Wednesday|Thursday|Friday|Saturday|SummerDesignDay|WinterDesignDay| |CustomDay1|CustomDay2]; if you use SummerDesignDay or WinterDesignDay or the CustomDays then this will apply to the whole period; other days (i.e., Monday) will signify a start day and normal sequence of subsequent days")]
[JsonProperty("day_of_week_for_start_day")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public SizingPeriod_WeatherFileDays_DayOfWeekForStartDay DayOfWeekForStartDay { get; set; } = (SizingPeriod_WeatherFileDays_DayOfWeekForStartDay)Enum.Parse(typeof(SizingPeriod_WeatherFileDays_DayOfWeekForStartDay), "Monday");
        

[Description("If yes or blank, use daylight saving period as specified on Weatherfile. If no, d" +
    "o not use the daylight saving period as specified on the Weatherfile.")]
[JsonProperty("use_weather_file_daylight_saving_period")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes UseWeatherFileDaylightSavingPeriod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("use_weather_file_rain_and_snow_indicators")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes UseWeatherFileRainAndSnowIndicators { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
    
    public enum SizingPeriod_WeatherFileDays_DayOfWeekForStartDay
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CustomDay1")]
        CustomDay1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CustomDay2")]
        CustomDay2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Friday")]
        Friday = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Monday")]
        Monday = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Saturday")]
        Saturday = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="SummerDesignDay")]
        SummerDesignDay = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Sunday")]
        Sunday = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Thursday")]
        Thursday = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Tuesday")]
        Tuesday = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Wednesday")]
        Wednesday = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="WinterDesignDay")]
        WinterDesignDay = 11,
    }
    
    [Description("Use a weather file period for design sizing calculations. EPW weather files are c" +
        "reated with typical and extreme periods created heuristically from the weather f" +
        "ile data. For more details on these periods, see AuxiliaryPrograms document.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SizingPeriod_WeatherFileConditionType : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Following is a list of all possible types of Extreme and Typical periods that mig" +
    "ht be identified in the Weather File. Not all possible types are available for a" +
    "ll weather files.")]
[JsonProperty("period_selection")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public SizingPeriod_WeatherFileConditionType_PeriodSelection PeriodSelection { get; set; } = (SizingPeriod_WeatherFileConditionType_PeriodSelection)Enum.Parse(typeof(SizingPeriod_WeatherFileConditionType_PeriodSelection), "AutumnTypical");
        

[Description(@"=[|Sunday|Monday|Tuesday|Wednesday|Thursday|Friday|Saturday|SummerDesignDay|WinterDesignDay| |CustomDay1|CustomDay2]; if you use SummerDesignDay or WinterDesignDay or the CustomDays then this will apply to the whole period; other days (i.e., Monday) will signify a start day and normal sequence of subsequent days")]
[JsonProperty("day_of_week_for_start_day")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public SizingPeriod_WeatherFileConditionType_DayOfWeekForStartDay DayOfWeekForStartDay { get; set; } = (SizingPeriod_WeatherFileConditionType_DayOfWeekForStartDay)Enum.Parse(typeof(SizingPeriod_WeatherFileConditionType_DayOfWeekForStartDay), "Monday");
        

[Description("If yes or blank, use daylight saving period as specified on Weatherfile. If no, d" +
    "o not use the daylight saving period as specified on the Weatherfile.")]
[JsonProperty("use_weather_file_daylight_saving_period")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes UseWeatherFileDaylightSavingPeriod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("use_weather_file_rain_and_snow_indicators")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes UseWeatherFileRainAndSnowIndicators { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
    
    public enum SizingPeriod_WeatherFileConditionType_PeriodSelection
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AutumnTypical")]
        AutumnTypical = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DrySeason")]
        DrySeason = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="NoDrySeason")]
        NoDrySeason = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="NoDrySeasonMax")]
        NoDrySeasonMax = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="NoDrySeasonMin")]
        NoDrySeasonMin = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="NoWetSeason")]
        NoWetSeason = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="NoWetSeasonMax")]
        NoWetSeasonMax = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="NoWetSeasonMin")]
        NoWetSeasonMin = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="SpringTypical")]
        SpringTypical = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="SummerExtreme")]
        SummerExtreme = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="SummerTypical")]
        SummerTypical = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TropicalCold")]
        TropicalCold = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="TropicalHot")]
        TropicalHot = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="WetSeason")]
        WetSeason = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="WinterExtreme")]
        WinterExtreme = 14,
        
        [System.Runtime.Serialization.EnumMember(Value="WinterTypical")]
        WinterTypical = 15,
    }
    
    public enum SizingPeriod_WeatherFileConditionType_DayOfWeekForStartDay
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CustomDay1")]
        CustomDay1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CustomDay2")]
        CustomDay2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Friday")]
        Friday = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Monday")]
        Monday = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Saturday")]
        Saturday = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="SummerDesignDay")]
        SummerDesignDay = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Sunday")]
        Sunday = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Thursday")]
        Thursday = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Tuesday")]
        Tuesday = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Wednesday")]
        Wednesday = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="WinterDesignDay")]
        WinterDesignDay = 11,
    }
    
    [Description("Specify a range of dates and other parameters for a simulation. Multiple run peri" +
        "ods may be input, but they may not overlap.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RunPeriod : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("begin_month")]
public System.Nullable<float> BeginMonth { get; set; } = null;
        

[JsonProperty("begin_day_of_month")]
public System.Nullable<float> BeginDayOfMonth { get; set; } = null;
        

[Description("Start year of the simulation, if this field is specified it must agree with the D" +
    "ay of Week for Start Day If this field is blank, the year will be selected to ma" +
    "tch the weekday, which is Sunday if not specified")]
[JsonProperty("begin_year")]
public System.Nullable<float> BeginYear { get; set; } = null;
        

[JsonProperty("end_month")]
public System.Nullable<float> EndMonth { get; set; } = null;
        

[JsonProperty("end_day_of_month")]
public System.Nullable<float> EndDayOfMonth { get; set; } = null;
        

[Description("end year of simulation, if specified")]
[JsonProperty("end_year")]
public System.Nullable<float> EndYear { get; set; } = null;
        

[Description("=[Sunday|Monday|Tuesday|Wednesday|Thursday|Friday|Saturday]; If no year is input," +
    " this field will default to Sunday If a year is input and this field is blank, t" +
    "he correct weekday is determined")]
[JsonProperty("day_of_week_for_start_day")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RunPeriod_DayOfWeekForStartDay DayOfWeekForStartDay { get; set; } = (RunPeriod_DayOfWeekForStartDay)Enum.Parse(typeof(RunPeriod_DayOfWeekForStartDay), "Friday");
        

[Description("If yes or blank, use holidays as specified on Weatherfile. If no, do not use the " +
    "holidays specified on the Weatherfile. Note: You can still specify holidays/spec" +
    "ial days using the RunPeriodControl:SpecialDays object(s).")]
[JsonProperty("use_weather_file_holidays_and_special_days")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes UseWeatherFileHolidaysAndSpecialDays { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("If yes or blank, use daylight saving period as specified on Weatherfile. If no, d" +
    "o not use the daylight saving period as specified on the Weatherfile.")]
[JsonProperty("use_weather_file_daylight_saving_period")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes UseWeatherFileDaylightSavingPeriod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("if yes and single day holiday falls on weekend, \"holiday\" occurs on following Mon" +
    "day")]
[JsonProperty("apply_weekend_holiday_rule")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes ApplyWeekendHolidayRule { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("use_weather_file_rain_indicators")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes UseWeatherFileRainIndicators { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("use_weather_file_snow_indicators")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes UseWeatherFileSnowIndicators { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("treat_weather_as_actual")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes TreatWeatherAsActual { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
    
    public enum RunPeriod_DayOfWeekForStartDay
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Friday")]
        Friday = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Monday")]
        Monday = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Saturday")]
        Saturday = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Sunday")]
        Sunday = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Thursday")]
        Thursday = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Tuesday")]
        Tuesday = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Wednesday")]
        Wednesday = 6,
    }
    
    [Description(@"This object sets up holidays/special days to be used during weather file run periods. (These are not used with SizingPeriod:* objects.) Depending on the value in the run period, days on the weather file may also be used. However, the weather file specification will take precedence over any specification shown here. (No error message on duplicate days or overlapping days).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RunPeriodControl_SpecialDays : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description(@"Dates can be several formats: <number>/<number>  (month/day) <number> <Month> <Month> <number> <Nth> <Weekday> in <Month) Last <WeekDay> in <Month> <Month> can be January, February, March, April, May, June, July, August, September, October, November, December Months can be the first 3 letters of the month <Weekday> can be Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday <Nth> can be 1 or 1st, 2 or 2nd, etc. up to 5(?)")]
[JsonProperty("start_date")]
public string StartDate { get; set; } = "";
        

[JsonProperty("duration")]
public System.Nullable<float> Duration { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Special Day Type selects the schedules appropriate for each day so labeled")]
[JsonProperty("special_day_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RunPeriodControl_SpecialDays_SpecialDayType SpecialDayType { get; set; } = (RunPeriodControl_SpecialDays_SpecialDayType)Enum.Parse(typeof(RunPeriodControl_SpecialDays_SpecialDayType), "Holiday");
    }
    
    public enum RunPeriodControl_SpecialDays_SpecialDayType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CustomDay1")]
        CustomDay1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CustomDay2")]
        CustomDay2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Holiday")]
        Holiday = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="SummerDesignDay")]
        SummerDesignDay = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="WinterDesignDay")]
        WinterDesignDay = 5,
    }
    
    [Description(@"This object sets up the daylight saving time period for any RunPeriod. Ignores any daylight saving time period on the weather file and uses this definition. These are not used with SizingPeriod:DesignDay objects. Use with SizingPeriod:WeatherFileDays object can be controlled in that object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RunPeriodControl_DaylightSavingTime : BHoMObject
    {
        

[JsonProperty("start_date")]
public string StartDate { get; set; } = "";
        

[Description(@"Dates can be several formats: <number>/<number>  (month/day) <number> <Month> <Month> <number> <Nth> <Weekday> in <Month) Last <WeekDay> in <Month> <Month> can be January, February, March, April, May, June, July, August, September, October, November, December Months can be the first 3 letters of the month <Weekday> can be Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday <Nth> can be 1 or 1st, 2 or 2nd, etc. up to 5(?)")]
[JsonProperty("end_date")]
public string EndDate { get; set; } = "";
    }
    
    [Description("This object is used to override internal sky temperature calculations.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WeatherProperty_SkyTemperature : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("The field indicates that the sky temperature will be imported from external sched" +
    "ules or calculated by alternative methods other than default.")]
[JsonProperty("calculation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WeatherProperty_SkyTemperature_CalculationType CalculationType { get; set; } = (WeatherProperty_SkyTemperature_CalculationType)Enum.Parse(typeof(WeatherProperty_SkyTemperature_CalculationType), "ClarkAllen");
        

[Description(@"if name matches a SizingPeriod:DesignDay, put in a day schedule of this name if name is for a SizingPeriod:WeatherFileDays, SizingPeriod:WeatherFileConditionType or RunPeriod, put in a full year schedule that covers the appropriate days. Required if Calculation Type is ScheduleValue, DifferenceScheduleDryBulbValue or DifferenceScheduleDewPointValue.")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description(@"If yes or blank, use Horizontal IR values from weather file when present, otherwise use the specified sky model. If no, always use the specified sky model and ignore the horizontal IR values from the weather file. For Calculation Type = ScheduleValue, DifferenceScheduleDryBulbValue or DifferenceScheduleDewPointValue, this field is ignored and the scheduled values are used.")]
[JsonProperty("use_weather_file_horizontal_ir")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes UseWeatherFileHorizontalIr { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
    
    public enum WeatherProperty_SkyTemperature_CalculationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BerdahlMartin")]
        BerdahlMartin = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Brunt")]
        Brunt = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ClarkAllen")]
        ClarkAllen = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferenceScheduleDewPointValue")]
        DifferenceScheduleDewPointValue = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferenceScheduleDryBulbValue")]
        DifferenceScheduleDryBulbValue = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Idso")]
        Idso = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="ScheduleValue")]
        ScheduleValue = 7,
    }
    
    [Description("This object should only be used for non-standard weather data. Standard weather d" +
        "ata such as TMY2, IWEC, and ASHRAE design day data are all measured at the defau" +
        "lt conditions and do not require this object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_WeatherStation : BHoMObject
    {
        

[JsonProperty("wind_sensor_height_above_ground")]
public System.Nullable<float> WindSensorHeightAboveGround { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[JsonProperty("wind_speed_profile_exponent")]
public System.Nullable<float> WindSpeedProfileExponent { get; set; } = (System.Nullable<float>)Single.Parse("0.14", CultureInfo.InvariantCulture);
        

[JsonProperty("wind_speed_profile_boundary_layer_thickness")]
public System.Nullable<float> WindSpeedProfileBoundaryLayerThickness { get; set; } = (System.Nullable<float>)Single.Parse("270", CultureInfo.InvariantCulture);
        

[JsonProperty("air_temperature_sensor_height_above_ground")]
public System.Nullable<float> AirTemperatureSensorHeightAboveGround { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
    }
    
    [Description(@"This object is used if the user requires advanced control over height-dependent variations in wind speed and temperature. When this object is not present, the default model for temperature dependence on height is used, and the wind speed is modeled according to the Terrain field of the BUILDING object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_HeightVariation : BHoMObject
    {
        

[Description("Set to zero for no wind speed dependence on height.")]
[JsonProperty("wind_speed_profile_exponent")]
public System.Nullable<float> WindSpeedProfileExponent { get; set; } = (System.Nullable<float>)Single.Parse("0.22", CultureInfo.InvariantCulture);
        

[JsonProperty("wind_speed_profile_boundary_layer_thickness")]
public System.Nullable<float> WindSpeedProfileBoundaryLayerThickness { get; set; } = (System.Nullable<float>)Single.Parse("370", CultureInfo.InvariantCulture);
        

[Description("Set to zero for no air temperature dependence on height.")]
[JsonProperty("air_temperature_gradient_coefficient")]
public System.Nullable<float> AirTemperatureGradientCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0.0065", CultureInfo.InvariantCulture);
    }
    
    [Description(@"These temperatures are specifically for those surfaces that have the outside environment of ""Ground"". Documentation about what values these should be is located in the Auxiliary programs document (Ground Heat Transfer) as well as the InputOutput Reference. CAUTION - Do not use the ""undisturbed"" ground temperatures from the weather data. These values are too extreme for the soil under a conditioned building. For best results, use the Slab or Basement program to calculate custom monthly average ground temperatures (see Auxiliary Programs). For typical commercial buildings in the USA, a reasonable default value is 2C less than the average indoor space temperature.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_BuildingSurface : BHoMObject
    {
        

[JsonProperty("january_ground_temperature")]
public System.Nullable<float> JanuaryGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[JsonProperty("february_ground_temperature")]
public System.Nullable<float> FebruaryGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[JsonProperty("march_ground_temperature")]
public System.Nullable<float> MarchGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[JsonProperty("april_ground_temperature")]
public System.Nullable<float> AprilGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[JsonProperty("may_ground_temperature")]
public System.Nullable<float> MayGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[JsonProperty("june_ground_temperature")]
public System.Nullable<float> JuneGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[JsonProperty("july_ground_temperature")]
public System.Nullable<float> JulyGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[JsonProperty("august_ground_temperature")]
public System.Nullable<float> AugustGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[JsonProperty("september_ground_temperature")]
public System.Nullable<float> SeptemberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[JsonProperty("october_ground_temperature")]
public System.Nullable<float> OctoberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[JsonProperty("november_ground_temperature")]
public System.Nullable<float> NovemberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[JsonProperty("december_ground_temperature")]
public System.Nullable<float> DecemberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
    }
    
    [Description("These temperatures are specifically for underground walls and ground floors defin" +
        "ed with the C-factor and F-factor methods, and should be close to the monthly av" +
        "erage outdoor air temperature delayed by 3 months for the location.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_FCfactorMethod : BHoMObject
    {
        

[JsonProperty("january_ground_temperature")]
public System.Nullable<float> JanuaryGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("february_ground_temperature")]
public System.Nullable<float> FebruaryGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("march_ground_temperature")]
public System.Nullable<float> MarchGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("april_ground_temperature")]
public System.Nullable<float> AprilGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("may_ground_temperature")]
public System.Nullable<float> MayGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("june_ground_temperature")]
public System.Nullable<float> JuneGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("july_ground_temperature")]
public System.Nullable<float> JulyGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("august_ground_temperature")]
public System.Nullable<float> AugustGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("september_ground_temperature")]
public System.Nullable<float> SeptemberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("october_ground_temperature")]
public System.Nullable<float> OctoberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("november_ground_temperature")]
public System.Nullable<float> NovemberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("december_ground_temperature")]
public System.Nullable<float> DecemberGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
    }
    
    [Description("These temperatures are specifically for the Surface Ground Heat Exchanger and sho" +
        "uld probably be close to the average outdoor air temperature for the location. T" +
        "hey are not used in other models.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_Shallow : BHoMObject
    {
        

[JsonProperty("january_surface_ground_temperature")]
public System.Nullable<float> JanuarySurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("february_surface_ground_temperature")]
public System.Nullable<float> FebruarySurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("march_surface_ground_temperature")]
public System.Nullable<float> MarchSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("april_surface_ground_temperature")]
public System.Nullable<float> AprilSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("may_surface_ground_temperature")]
public System.Nullable<float> MaySurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("june_surface_ground_temperature")]
public System.Nullable<float> JuneSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("july_surface_ground_temperature")]
public System.Nullable<float> JulySurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("august_surface_ground_temperature")]
public System.Nullable<float> AugustSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("september_surface_ground_temperature")]
public System.Nullable<float> SeptemberSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("october_surface_ground_temperature")]
public System.Nullable<float> OctoberSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("november_surface_ground_temperature")]
public System.Nullable<float> NovemberSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("december_surface_ground_temperature")]
public System.Nullable<float> DecemberSurfaceGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
    }
    
    [Description("These temperatures are specifically for the ground heat exchangers that would use" +
        " \"deep\" (3-4 m depth) ground temperatures for their heat source. They are not us" +
        "ed in other models.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_Deep : BHoMObject
    {
        

[JsonProperty("january_deep_ground_temperature")]
public System.Nullable<float> JanuaryDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

[JsonProperty("february_deep_ground_temperature")]
public System.Nullable<float> FebruaryDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

[JsonProperty("march_deep_ground_temperature")]
public System.Nullable<float> MarchDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

[JsonProperty("april_deep_ground_temperature")]
public System.Nullable<float> AprilDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

[JsonProperty("may_deep_ground_temperature")]
public System.Nullable<float> MayDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

[JsonProperty("june_deep_ground_temperature")]
public System.Nullable<float> JuneDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

[JsonProperty("july_deep_ground_temperature")]
public System.Nullable<float> JulyDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

[JsonProperty("august_deep_ground_temperature")]
public System.Nullable<float> AugustDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

[JsonProperty("september_deep_ground_temperature")]
public System.Nullable<float> SeptemberDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

[JsonProperty("october_deep_ground_temperature")]
public System.Nullable<float> OctoberDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

[JsonProperty("november_deep_ground_temperature")]
public System.Nullable<float> NovemberDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

[JsonProperty("december_deep_ground_temperature")]
public System.Nullable<float> DecemberDeepGroundTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
    }
    
    [Description("Undisturbed ground temperature object using a detailed finite difference 1-D mode" +
        "l")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_Undisturbed_FiniteDifference : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("soil_thermal_conductivity")]
public System.Nullable<float> SoilThermalConductivity { get; set; } = null;
        

[JsonProperty("soil_density")]
public System.Nullable<float> SoilDensity { get; set; } = null;
        

[JsonProperty("soil_specific_heat")]
public System.Nullable<float> SoilSpecificHeat { get; set; } = null;
        

[JsonProperty("soil_moisture_content_volume_fraction")]
public System.Nullable<float> SoilMoistureContentVolumeFraction { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_moisture_content_volume_fraction_at_saturation")]
public System.Nullable<float> SoilMoistureContentVolumeFractionAtSaturation { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description(@"This specifies the ground cover effects during evapotranspiration calculations. The value roughly represents the following cases: = 0   : concrete or other solid, non-permeable ground surface material = 0.5 : short grass, much like a manicured lawn = 1   : standard reference state (12 cm grass) = 1.5 : wild growth")]
[JsonProperty("evapotranspiration_ground_cover_parameter")]
public System.Nullable<float> EvapotranspirationGroundCoverParameter { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
    }
    
    [Description("Undisturbed ground temperature object using the Kusuda-Achenbach 1965 correlation" +
        ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_Undisturbed_KusudaAchenbach : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("soil_thermal_conductivity")]
public System.Nullable<float> SoilThermalConductivity { get; set; } = null;
        

[JsonProperty("soil_density")]
public System.Nullable<float> SoilDensity { get; set; } = null;
        

[JsonProperty("soil_specific_heat")]
public System.Nullable<float> SoilSpecificHeat { get; set; } = null;
        

[Description("Annual average surface temperature If left blank the Site:GroundTemperature:Shall" +
    "ow object must be included in the input The soil temperature, amplitude, and pha" +
    "se shift must all be included or omitted together")]
[JsonProperty("average_soil_surface_temperature")]
public System.Nullable<float> AverageSoilSurfaceTemperature { get; set; } = null;
        

[Description("Annual average surface temperature variation from average. If left blank the Site" +
    ":GroundTemperature:Shallow object must be included in the input The soil tempera" +
    "ture, amplitude, and phase shift must all be included or omitted together")]
[JsonProperty("average_amplitude_of_surface_temperature")]
public System.Nullable<float> AverageAmplitudeOfSurfaceTemperature { get; set; } = null;
        

[Description(@"The phase shift of minimum surface temperature, or the day of the year when the minimum surface temperature occurs. If left blank the Site:GroundTemperature:Shallow object must be included in the input The soil temperature, amplitude, and phase shift must all be included or omitted together")]
[JsonProperty("phase_shift_of_minimum_surface_temperature")]
public System.Nullable<float> PhaseShiftOfMinimumSurfaceTemperature { get; set; } = null;
    }
    
    [Description("Undisturbed ground temperature object using the Xing 2014 2 harmonic parameter mo" +
        "del.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_Undisturbed_Xing : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("soil_thermal_conductivity")]
public System.Nullable<float> SoilThermalConductivity { get; set; } = null;
        

[JsonProperty("soil_density")]
public System.Nullable<float> SoilDensity { get; set; } = null;
        

[JsonProperty("soil_specific_heat")]
public System.Nullable<float> SoilSpecificHeat { get; set; } = null;
        

[JsonProperty("average_soil_surface_tempeature")]
public System.Nullable<float> AverageSoilSurfaceTempeature { get; set; } = null;
        

[JsonProperty("soil_surface_temperature_amplitude_1")]
public System.Nullable<float> SoilSurfaceTemperatureAmplitude1 { get; set; } = null;
        

[JsonProperty("soil_surface_temperature_amplitude_2")]
public System.Nullable<float> SoilSurfaceTemperatureAmplitude2 { get; set; } = null;
        

[JsonProperty("phase_shift_of_temperature_amplitude_1")]
public System.Nullable<float> PhaseShiftOfTemperatureAmplitude1 { get; set; } = null;
        

[JsonProperty("phase_shift_of_temperature_amplitude_2")]
public System.Nullable<float> PhaseShiftOfTemperatureAmplitude2 { get; set; } = null;
    }
    
    [Description("Ground-coupled slab model for on-grade and in-grade cases with or without insulat" +
        "ion.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundDomain_Slab : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("ground_domain_depth")]
public System.Nullable<float> GroundDomainDepth { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[JsonProperty("aspect_ratio")]
public System.Nullable<float> AspectRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("perimeter_offset")]
public System.Nullable<float> PerimeterOffset { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_thermal_conductivity")]
public System.Nullable<float> SoilThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_density")]
public System.Nullable<float> SoilDensity { get; set; } = (System.Nullable<float>)Single.Parse("2800", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_specific_heat")]
public System.Nullable<float> SoilSpecificHeat { get; set; } = (System.Nullable<float>)Single.Parse("850", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_moisture_content_volume_fraction")]
public System.Nullable<float> SoilMoistureContentVolumeFraction { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_moisture_content_volume_fraction_at_saturation")]
public System.Nullable<float> SoilMoistureContentVolumeFractionAtSaturation { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[JsonProperty("undisturbed_ground_temperature_model_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Site_GroundDomain_Slab_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (Site_GroundDomain_Slab_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(Site_GroundDomain_Slab_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

[JsonProperty("undisturbed_ground_temperature_model_name")]
public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

[Description(@"This specifies the ground cover effects during evapotranspiration calculations. The value roughly represents the following cases: = 0   : concrete or other solid, non-permeable ground surface material = 0.5 : short grass, much like a manicured lawn = 1   : standard reference state (12 cm grass) = 1.5 : wild growth")]
[JsonProperty("evapotranspiration_ground_cover_parameter")]
public System.Nullable<float> EvapotranspirationGroundCoverParameter { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

[JsonProperty("slab_boundary_condition_model_name")]
public string SlabBoundaryConditionModelName { get; set; } = "";
        

[Description("This field specifies whether the slab is located \"in-grade\" or \"on-grade\"")]
[JsonProperty("slab_location")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Site_GroundDomain_Slab_SlabLocation SlabLocation { get; set; } = (Site_GroundDomain_Slab_SlabLocation)Enum.Parse(typeof(Site_GroundDomain_Slab_SlabLocation), "InGrade");
        

[Description("Only applicable for the in-grade case")]
[JsonProperty("slab_material_name")]
public string SlabMaterialName { get; set; } = "";
        

[Description("This field specifies the presence of insulation beneath the slab. Only required f" +
    "or in-grade case.")]
[JsonProperty("horizontal_insulation")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes HorizontalInsulation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("This field specifies the horizontal insulation material.")]
[JsonProperty("horizontal_insulation_material_name")]
public string HorizontalInsulationMaterialName { get; set; } = "";
        

[Description("This field specifies whether the horizontal insulation fully insulates the surfac" +
    "e or is perimeter only insulation")]
[JsonProperty("horizontal_insulation_extents")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Site_GroundDomain_Slab_HorizontalInsulationExtents HorizontalInsulationExtents { get; set; } = (Site_GroundDomain_Slab_HorizontalInsulationExtents)Enum.Parse(typeof(Site_GroundDomain_Slab_HorizontalInsulationExtents), "Full");
        

[Description("This field specifies the width of the underfloor perimeter insulation")]
[JsonProperty("perimeter_insulation_width")]
public System.Nullable<float> PerimeterInsulationWidth { get; set; } = null;
        

[Description("This field specifies the presence of vertical insulation at the slab edge.")]
[JsonProperty("vertical_insulation")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes VerticalInsulation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("This field specifies the vertical insulation material.")]
[JsonProperty("vertical_insulation_material_name")]
public string VerticalInsulationMaterialName { get; set; } = "";
        

[Description("Only used when including vertical insulation This field specifies the depth of th" +
    "e vertical insulation")]
[JsonProperty("vertical_insulation_depth")]
public System.Nullable<float> VerticalInsulationDepth { get; set; } = null;
        

[Description("This field specifies the ground domain simulation timestep.")]
[JsonProperty("simulation_timestep")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Site_GroundDomain_Slab_SimulationTimestep SimulationTimestep { get; set; } = (Site_GroundDomain_Slab_SimulationTimestep)Enum.Parse(typeof(Site_GroundDomain_Slab_SimulationTimestep), "Hourly");
        

[JsonProperty("geometric_mesh_coefficient")]
public System.Nullable<float> GeometricMeshCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1.6", CultureInfo.InvariantCulture);
        

[JsonProperty("mesh_density_parameter")]
public System.Nullable<float> MeshDensityParameter { get; set; } = (System.Nullable<float>)Single.Parse("6", CultureInfo.InvariantCulture);
    }
    
    public enum Site_GroundDomain_Slab_UndisturbedGroundTemperatureModelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:FiniteDifference")]
        SiteGroundTemperatureUndisturbedFiniteDifference = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:KusudaAchenbach")]
        SiteGroundTemperatureUndisturbedKusudaAchenbach = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:Xing")]
        SiteGroundTemperatureUndisturbedXing = 2,
    }
    
    public enum Site_GroundDomain_Slab_SlabLocation
    {
        
        [System.Runtime.Serialization.EnumMember(Value="InGrade")]
        InGrade = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="OnGrade")]
        OnGrade = 1,
    }
    
    public enum Site_GroundDomain_Slab_HorizontalInsulationExtents
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Full")]
        Full = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Perimeter")]
        Perimeter = 2,
    }
    
    public enum Site_GroundDomain_Slab_SimulationTimestep
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Hourly")]
        Hourly = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Timestep")]
        Timestep = 2,
    }
    
    [Description("Ground-coupled basement model for simulating basements or other underground zones" +
        ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundDomain_Basement : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("The depth from ground surface to the deep ground boundary of the domain.")]
[JsonProperty("ground_domain_depth")]
public System.Nullable<float> GroundDomainDepth { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("This defines the height to width ratio of the basement zone.")]
[JsonProperty("aspect_ratio")]
public System.Nullable<float> AspectRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("The distance from the basement wall edge to the edge of the ground domain")]
[JsonProperty("perimeter_offset")]
public System.Nullable<float> PerimeterOffset { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_thermal_conductivity")]
public System.Nullable<float> SoilThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_density")]
public System.Nullable<float> SoilDensity { get; set; } = (System.Nullable<float>)Single.Parse("2800", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_specific_heat")]
public System.Nullable<float> SoilSpecificHeat { get; set; } = (System.Nullable<float>)Single.Parse("850", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_moisture_content_volume_fraction")]
public System.Nullable<float> SoilMoistureContentVolumeFraction { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_moisture_content_volume_fraction_at_saturation")]
public System.Nullable<float> SoilMoistureContentVolumeFractionAtSaturation { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[JsonProperty("undisturbed_ground_temperature_model_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Site_GroundDomain_Basement_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (Site_GroundDomain_Basement_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(Site_GroundDomain_Basement_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

[JsonProperty("undisturbed_ground_temperature_model_name")]
public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

[Description(@"This specifies the ground cover effects during evapotranspiration calculations. The value roughly represents the following cases: = 0   : concrete or other solid, non-permeable ground surface material = 0.5 : short grass, much like a manicured lawn = 1   : standard reference state (12 cm grass) = 1.5 : wild growth")]
[JsonProperty("evapotranspiration_ground_cover_parameter")]
public System.Nullable<float> EvapotranspirationGroundCoverParameter { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

[JsonProperty("basement_floor_boundary_condition_model_name")]
public string BasementFloorBoundaryConditionModelName { get; set; } = "";
        

[Description("This field specifies the presence of insulation beneath the basement floor.")]
[JsonProperty("horizontal_insulation")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes HorizontalInsulation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("horizontal_insulation_material_name")]
public string HorizontalInsulationMaterialName { get; set; } = "";
        

[Description("This field specifies whether the horizontal insulation fully insulates the surfac" +
    "e or is perimeter only insulation")]
[JsonProperty("horizontal_insulation_extents")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Site_GroundDomain_Basement_HorizontalInsulationExtents HorizontalInsulationExtents { get; set; } = (Site_GroundDomain_Basement_HorizontalInsulationExtents)Enum.Parse(typeof(Site_GroundDomain_Basement_HorizontalInsulationExtents), "Full");
        

[Description("Width of horizontal perimeter insulation measured from foundation wall inside sur" +
    "face.")]
[JsonProperty("perimeter_horizontal_insulation_width")]
public System.Nullable<float> PerimeterHorizontalInsulationWidth { get; set; } = null;
        

[Description("Depth measured from ground surface.")]
[JsonProperty("basement_wall_depth")]
public System.Nullable<float> BasementWallDepth { get; set; } = null;
        

[JsonProperty("basement_wall_boundary_condition_model_name")]
public string BasementWallBoundaryConditionModelName { get; set; } = "";
        

[JsonProperty("vertical_insulation")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes VerticalInsulation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("basement_wall_vertical_insulation_material_name")]
public string BasementWallVerticalInsulationMaterialName { get; set; } = "";
        

[Description("Depth measured from the ground surface.")]
[JsonProperty("vertical_insulation_depth")]
public System.Nullable<float> VerticalInsulationDepth { get; set; } = null;
        

[Description("This field specifies the basement domain simulation interval.")]
[JsonProperty("simulation_timestep")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Site_GroundDomain_Basement_SimulationTimestep SimulationTimestep { get; set; } = (Site_GroundDomain_Basement_SimulationTimestep)Enum.Parse(typeof(Site_GroundDomain_Basement_SimulationTimestep), "Hourly");
        

[JsonProperty("mesh_density_parameter")]
public System.Nullable<float> MeshDensityParameter { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
    }
    
    public enum Site_GroundDomain_Basement_UndisturbedGroundTemperatureModelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:FiniteDifference")]
        SiteGroundTemperatureUndisturbedFiniteDifference = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:KusudaAchenbach")]
        SiteGroundTemperatureUndisturbedKusudaAchenbach = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Undisturbed:Xing")]
        SiteGroundTemperatureUndisturbedXing = 2,
    }
    
    public enum Site_GroundDomain_Basement_HorizontalInsulationExtents
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Full")]
        Full = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Perimeter")]
        Perimeter = 2,
    }
    
    public enum Site_GroundDomain_Basement_SimulationTimestep
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Hourly")]
        Hourly = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Timestep")]
        Timestep = 2,
    }
    
    [Description("Specifies the ground reflectance values used to calculate ground reflected solar." +
        " The ground reflectance can be further modified when snow is on the ground by Si" +
        "te:GroundReflectance:SnowModifier.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundReflectance : BHoMObject
    {
        

[JsonProperty("january_ground_reflectance")]
public System.Nullable<float> JanuaryGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("february_ground_reflectance")]
public System.Nullable<float> FebruaryGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("march_ground_reflectance")]
public System.Nullable<float> MarchGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("april_ground_reflectance")]
public System.Nullable<float> AprilGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("may_ground_reflectance")]
public System.Nullable<float> MayGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("june_ground_reflectance")]
public System.Nullable<float> JuneGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("july_ground_reflectance")]
public System.Nullable<float> JulyGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("august_ground_reflectance")]
public System.Nullable<float> AugustGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("september_ground_reflectance")]
public System.Nullable<float> SeptemberGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("october_ground_reflectance")]
public System.Nullable<float> OctoberGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("november_ground_reflectance")]
public System.Nullable<float> NovemberGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("december_ground_reflectance")]
public System.Nullable<float> DecemberGroundReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
    }
    
    [Description("Specifies ground reflectance multipliers when snow resident on the ground. These " +
        "multipliers are applied to the \"normal\" ground reflectances specified in Site:Gr" +
        "oundReflectance.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundReflectance_SnowModifier : BHoMObject
    {
        

[Description(@"Value for modifying the ""normal"" ground reflectance when Snow is on ground when calculating the ""Ground Reflected Solar Radiation Value"" a value of 1.0 here uses the ""normal"" ground reflectance Ground Reflected Solar = (BeamSolar*CosSunZenith + DiffuseSolar)*GroundReflectance This would be further modified by the Snow Ground Reflectance Modifier when Snow was on the ground When Snow on ground, effective GroundReflectance is normal GroundReflectance*""Ground Reflectance Snow Modifier"" Ground Reflectance achieved in this manner will be restricted to [0.0,1.0]")]
[JsonProperty("ground_reflected_solar_modifier")]
public System.Nullable<float> GroundReflectedSolarModifier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description(@"Value for modifying the ""normal"" daylighting ground reflectance when Snow is on ground when calculating the ""Ground Reflected Solar Radiation Value"" a value of 1.0 here uses the ""normal"" ground reflectance Ground Reflected Solar = (BeamSolar*CosSunZenith + DiffuseSolar)*GroundReflectance This would be further modified by the Snow Ground Reflectance Modifier when Snow was on the ground When Snow on ground, effective GroundReflectance is normal GroundReflectance*""Daylighting Ground Reflectance Snow Modifier"" Ground Reflectance achieved in this manner will be restricted to [0.0,1.0]")]
[JsonProperty("daylighting_ground_reflected_solar_modifier")]
public System.Nullable<float> DaylightingGroundReflectedSolarModifier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    [Description("Used to calculate water mains temperatures delivered by underground water main pi" +
        "pes. Water mains temperatures are a function of outdoor climate conditions and v" +
        "ary with time of year.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_WaterMainsTemperature : BHoMObject
    {
        

[Description("If calculation method is CorrelationFromWeatherFile, the two numeric input fields" +
    " are ignored. Instead, EnergyPlus calculates them from weather file.")]
[JsonProperty("calculation_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Site_WaterMainsTemperature_CalculationMethod CalculationMethod { get; set; } = (Site_WaterMainsTemperature_CalculationMethod)Enum.Parse(typeof(Site_WaterMainsTemperature_CalculationMethod), "CorrelationFromWeatherFile");
        

[JsonProperty("temperature_schedule_name")]
public string TemperatureScheduleName { get; set; } = "";
        

[Description("If calculation method is CorrelationFromWeatherFile or Schedule, this input field" +
    " is ignored.")]
[JsonProperty("annual_average_outdoor_air_temperature")]
public System.Nullable<float> AnnualAverageOutdoorAirTemperature { get; set; } = null;
        

[Description("If calculation method is CorrelationFromWeatherFile or Schedule, this input field" +
    " is ignored.")]
[JsonProperty("maximum_difference_in_monthly_average_outdoor_air_temperatures")]
public System.Nullable<float> MaximumDifferenceInMonthlyAverageOutdoorAirTemperatures { get; set; } = null;
    }
    
    public enum Site_WaterMainsTemperature_CalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Correlation")]
        Correlation = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CorrelationFromWeatherFile")]
        CorrelationFromWeatherFile = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 3,
    }
    
    [Description("Used to describe the amount of water precipitation at the building site. Precipit" +
        "ation includes both rain and the equivalent water content of snow.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_Precipitation : BHoMObject
    {
        

[JsonProperty("precipitation_model_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Site_Precipitation_PrecipitationModelType PrecipitationModelType { get; set; } = (Site_Precipitation_PrecipitationModelType)Enum.Parse(typeof(Site_Precipitation_PrecipitationModelType), "ScheduleAndDesignLevel");
        

[Description("meters of water per year used for design level")]
[JsonProperty("design_level_for_total_annual_precipitation")]
public System.Nullable<float> DesignLevelForTotalAnnualPrecipitation { get; set; } = null;
        

[Description("Schedule values in meters of water per hour values should be non-negative")]
[JsonProperty("precipitation_rates_schedule_name")]
public string PrecipitationRatesScheduleName { get; set; } = "";
        

[Description("meters of water per year from average weather statistics")]
[JsonProperty("average_total_annual_precipitation")]
public System.Nullable<float> AverageTotalAnnualPrecipitation { get; set; } = null;
    }
    
    public enum Site_Precipitation_PrecipitationModelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ScheduleAndDesignLevel")]
        ScheduleAndDesignLevel = 0,
    }
    
    [Description("Used to describe the amount of irrigation on the ecoroof surface over the course " +
        "of the simulation runperiod.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoofIrrigation : BHoMObject
    {
        

[Description("SmartSchedule will not allow irrigation when soil is already moist. Current thres" +
    "hold set at 30% of saturation.")]
[JsonProperty("irrigation_model_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RoofIrrigation_IrrigationModelType IrrigationModelType { get; set; } = (RoofIrrigation_IrrigationModelType)Enum.Parse(typeof(RoofIrrigation_IrrigationModelType), "Schedule");
        

[Description("Schedule values in meters of water per hour values should be non-negative")]
[JsonProperty("irrigation_rate_schedule_name")]
public string IrrigationRateScheduleName { get; set; } = "";
        

[Description("Used with SmartSchedule to set the saturation level at which no irrigation is all" +
    "owed.")]
[JsonProperty("irrigation_maximum_saturation_threshold")]
public System.Nullable<float> IrrigationMaximumSaturationThreshold { get; set; } = (System.Nullable<float>)Single.Parse("40", CultureInfo.InvariantCulture);
    }
    
    public enum RoofIrrigation_IrrigationModelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SmartSchedule")]
        SmartSchedule = 1,
    }
    
    [Description("If this object is omitted, the default solar and visible spectrum data will be us" +
        "ed.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_SolarAndVisibleSpectrum : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("The method specifies which of the solar and visible spectrum data to use in the c" +
    "alculations. Choices: Default - existing hard-wired spectrum data in EnergyPlus." +
    " UserDefined - user specified spectrum data referenced by the next two fields")]
[JsonProperty("spectrum_data_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Site_SolarAndVisibleSpectrum_SpectrumDataMethod SpectrumDataMethod { get; set; } = (Site_SolarAndVisibleSpectrum_SpectrumDataMethod)Enum.Parse(typeof(Site_SolarAndVisibleSpectrum_SpectrumDataMethod), "Default");
        

[JsonProperty("solar_spectrum_data_object_name")]
public string SolarSpectrumDataObjectName { get; set; } = "";
        

[JsonProperty("visible_spectrum_data_object_name")]
public string VisibleSpectrumDataObjectName { get; set; } = "";
    }
    
    public enum Site_SolarAndVisibleSpectrum_SpectrumDataMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Default")]
        Default = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="UserDefined")]
        UserDefined = 2,
    }
    
    [Description("Spectrum Data Type is followed by up to 107 sets of normal-incidence measured val" +
        "ues of [wavelength, spectrum] for wavelengths covering the solar (0.25 to 2.5 mi" +
        "crons) or visible spectrum (0.38 to 0.78 microns)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_SpectrumData : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("spectrum_data_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Site_SpectrumData_SpectrumDataType SpectrumDataType { get; set; } = (Site_SpectrumData_SpectrumDataType)Enum.Parse(typeof(Site_SpectrumData_SpectrumDataType), "Solar");
        

[JsonProperty("wavelength")]
public System.Nullable<float> Wavelength { get; set; } = null;
        

[JsonProperty("spectrum")]
public System.Nullable<float> Spectrum { get; set; } = null;
        

[JsonProperty("wavelength_1")]
public System.Nullable<float> Wavelength1 { get; set; } = null;
        

[JsonProperty("spectrum_2")]
public System.Nullable<float> Spectrum2 { get; set; } = null;
        

[JsonProperty("extensions")]
public string Extensions { get; set; } = "";
    }
    
    public enum Site_SpectrumData_SpectrumDataType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Solar")]
        Solar = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Visible")]
        Visible = 1,
    }
}
