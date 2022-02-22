namespace BH.oM.Adapters.EnergyPlus.Schedules
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
    using BH.oM.Adapters.EnergyPlus.LocationandClimate;
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
    
    
    [Description("ScheduleTypeLimits specifies the data types and limits for the values contained i" +
        "n schedules")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ScheduleTypeLimits : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("lower limit (real or integer) for the Schedule Type. e.g. if fraction, this is 0." +
    "0")]
[JsonProperty("lower_limit_value")]
public System.Nullable<float> LowerLimitValue { get; set; } = null;
        

[Description("upper limit (real or integer) for the Schedule Type. e.g. if fraction, this is 1." +
    "0")]
[JsonProperty("upper_limit_value")]
public System.Nullable<float> UpperLimitValue { get; set; } = null;
        

[Description("Numeric type is either Continuous (all numbers within the min and max are valid o" +
    "r Discrete (only integer numbers between min and max are valid. (Could also allo" +
    "w REAL and INTEGER to mean the same things)")]
[JsonProperty("numeric_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ScheduleTypeLimits_NumericType NumericType { get; set; } = (ScheduleTypeLimits_NumericType)Enum.Parse(typeof(ScheduleTypeLimits_NumericType), "Continuous");
        

[Description("Temperature (C or F) DeltaTemperature (C or F) PrecipitationRate (m/hr or ft/hr) " +
    "Angle (degrees) Convection Coefficient (W/m2-K or Btu/sqft-hr-F) Activity Level " +
    "(W/person) Velocity (m/s or ft/min) Capacity (W or Btu/h) Power (W)")]
[JsonProperty("unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ScheduleTypeLimits_UnitType UnitType { get; set; } = (ScheduleTypeLimits_UnitType)Enum.Parse(typeof(ScheduleTypeLimits_UnitType), "Dimensionless");
    }
    
    public enum ScheduleTypeLimits_NumericType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Continuous")]
        Continuous = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Discrete")]
        Discrete = 1,
    }
    
    public enum ScheduleTypeLimits_UnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ActivityLevel")]
        ActivityLevel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Angle")]
        Angle = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Availability")]
        Availability = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Capacity")]
        Capacity = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Control")]
        Control = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="ConvectionCoefficient")]
        ConvectionCoefficient = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="DeltaTemperature")]
        DeltaTemperature = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Mode")]
        Mode = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Percent")]
        Percent = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="PrecipitationRate")]
        PrecipitationRate = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Velocity")]
        Velocity = 14,
    }
    
    [Description("A Schedule:Day:Hourly contains 24 values for each hour of the day.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Day_Hourly : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("schedule_type_limits_name")]
public string ScheduleTypeLimitsName { get; set; } = "";
        

[JsonProperty("hour_1")]
public System.Nullable<float> Hour1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_2")]
public System.Nullable<float> Hour2 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_3")]
public System.Nullable<float> Hour3 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_4")]
public System.Nullable<float> Hour4 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_5")]
public System.Nullable<float> Hour5 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_6")]
public System.Nullable<float> Hour6 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_7")]
public System.Nullable<float> Hour7 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_8")]
public System.Nullable<float> Hour8 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_9")]
public System.Nullable<float> Hour9 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_10")]
public System.Nullable<float> Hour10 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_11")]
public System.Nullable<float> Hour11 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_12")]
public System.Nullable<float> Hour12 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_13")]
public System.Nullable<float> Hour13 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_14")]
public System.Nullable<float> Hour14 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_15")]
public System.Nullable<float> Hour15 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_16")]
public System.Nullable<float> Hour16 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_17")]
public System.Nullable<float> Hour17 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_18")]
public System.Nullable<float> Hour18 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_19")]
public System.Nullable<float> Hour19 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_20")]
public System.Nullable<float> Hour20 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_21")]
public System.Nullable<float> Hour21 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_22")]
public System.Nullable<float> Hour22 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_23")]
public System.Nullable<float> Hour23 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("hour_24")]
public System.Nullable<float> Hour24 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description("A Schedule:Day:Interval contains a full day of values with specified end times fo" +
        "r each value Currently, is set up to allow for 10 minute intervals for an entire" +
        " day.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Day_Interval : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("schedule_type_limits_name")]
public string ScheduleTypeLimitsName { get; set; } = "";
        

[Description(@"when the interval does not match the user specified timestep a Average choice will average between the intervals request (to timestep resolution. A No choice will use the interval value at the simulation timestep without regard to if it matches the boundary or not. A Linear choice will interpolate linearly between successive values.")]
[JsonProperty("interpolate_to_timestep")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Schedule_Day_Interval_InterpolateToTimestep InterpolateToTimestep { get; set; } = (Schedule_Day_Interval_InterpolateToTimestep)Enum.Parse(typeof(Schedule_Day_Interval_InterpolateToTimestep), "No");
        

[JsonProperty("data")]
public string Data { get; set; } = "";
    }
    
    public enum Schedule_Day_Interval_InterpolateToTimestep
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Average")]
        Average = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Linear")]
        Linear = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="No")]
        No = 3,
    }
    
    [Description("Schedule:Day:List will allow the user to list 24 hours worth of values, which can" +
        " be sub-hourly in nature.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Day_List : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("schedule_type_limits_name")]
public string ScheduleTypeLimitsName { get; set; } = "";
        

[Description(@"when the interval does not match the user specified timestep a ""Average"" choice will average between the intervals request (to timestep resolution. A ""No"" choice will use the interval value at the simulation timestep without regard to if it matches the boundary or not. A ""Linear"" choice will interpolate linearly between successive values.")]
[JsonProperty("interpolate_to_timestep")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Schedule_Day_List_InterpolateToTimestep InterpolateToTimestep { get; set; } = (Schedule_Day_List_InterpolateToTimestep)Enum.Parse(typeof(Schedule_Day_List_InterpolateToTimestep), "No");
        

[Description("Must be evenly divisible into 60")]
[JsonProperty("minutes_per_item")]
public System.Nullable<float> MinutesPerItem { get; set; } = null;
        

[JsonProperty("extensions")]
public string Extensions { get; set; } = "";
    }
    
    public enum Schedule_Day_List_InterpolateToTimestep
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Average")]
        Average = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Linear")]
        Linear = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="No")]
        No = 3,
    }
    
    [Description("A Schedule:Week:Daily contains 12 Schedule:Day:Hourly objects, one for each day t" +
        "ype.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Week_Daily : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("sunday_schedule_day_name")]
public string SundayScheduleDayName { get; set; } = "";
        

[JsonProperty("monday_schedule_day_name")]
public string MondayScheduleDayName { get; set; } = "";
        

[JsonProperty("tuesday_schedule_day_name")]
public string TuesdayScheduleDayName { get; set; } = "";
        

[JsonProperty("wednesday_schedule_day_name")]
public string WednesdayScheduleDayName { get; set; } = "";
        

[JsonProperty("thursday_schedule_day_name")]
public string ThursdayScheduleDayName { get; set; } = "";
        

[JsonProperty("friday_schedule_day_name")]
public string FridayScheduleDayName { get; set; } = "";
        

[JsonProperty("saturday_schedule_day_name")]
public string SaturdayScheduleDayName { get; set; } = "";
        

[JsonProperty("holiday_schedule_day_name")]
public string HolidayScheduleDayName { get; set; } = "";
        

[JsonProperty("summerdesignday_schedule_day_name")]
public string SummerdesigndayScheduleDayName { get; set; } = "";
        

[JsonProperty("winterdesignday_schedule_day_name")]
public string WinterdesigndayScheduleDayName { get; set; } = "";
        

[JsonProperty("customday1_schedule_day_name")]
public string Customday1ScheduleDayName { get; set; } = "";
        

[JsonProperty("customday2_schedule_day_name")]
public string Customday2ScheduleDayName { get; set; } = "";
    }
    
    [Description("Compact definition for Schedule:Day:List")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Week_Compact : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("data")]
public string Data { get; set; } = "";
    }
    
    [Description("A Schedule:Year contains from 1 to 52 week schedules")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Year : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("schedule_type_limits_name")]
public string ScheduleTypeLimitsName { get; set; } = "";
        

[JsonProperty("schedule_weeks")]
public string ScheduleWeeks { get; set; } = "";
    }
    
    [Description(@"Irregular object. Does not follow the usual definition for fields. Fields A3... are: Through: Date For: Applicable days (ref: Schedule:Week:Compact) Interpolate: Average/Linear/No (ref: Schedule:Day:Interval) -- optional, if not used will be ""No"" Until: <Time> (ref: Schedule:Day:Interval) <numeric value> words ""Through"",""For"",""Interpolate"",""Until"" must be included.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Compact : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("schedule_type_limits_name")]
public string ScheduleTypeLimitsName { get; set; } = "";
        

[JsonProperty("data")]
public string Data { get; set; } = "";
    }
    
    [Description("Constant hourly value for entire year.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Constant : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("schedule_type_limits_name")]
public string ScheduleTypeLimitsName { get; set; } = "";
        

[JsonProperty("hourly_value")]
public System.Nullable<float> HourlyValue { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description("A Schedule:File:Shading points to a CSV file that has 8760-8784 hours of sunlit f" +
        "raction data for all or some of the exterior surfaces.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_File_Shading : BHoMObject
    {
        

[Description("The name of the file that writes all shading data.")]
[JsonProperty("file_name")]
public string FileName { get; set; } = "";
    }
    
    [Description("A Schedule:File points to a text computer file that has 8760-8784 hours of data.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_File : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("schedule_type_limits_name")]
public string ScheduleTypeLimitsName { get; set; } = "";
        

[JsonProperty("file_name")]
public string FileName { get; set; } = "";
        

[JsonProperty("column_number")]
public System.Nullable<float> ColumnNumber { get; set; } = null;
        

[JsonProperty("rows_to_skip_at_top")]
public System.Nullable<float> RowsToSkipAtTop { get; set; } = null;
        

[Description("8760 hours does not account for leap years, 8784 does. should be either 8760 or 8" +
    "784")]
[JsonProperty("number_of_hours_of_data")]
public System.Nullable<float> NumberOfHoursOfData { get; set; } = (System.Nullable<float>)Single.Parse("8760", CultureInfo.InvariantCulture);
        

[JsonProperty("column_separator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Schedule_File_ColumnSeparator ColumnSeparator { get; set; } = (Schedule_File_ColumnSeparator)Enum.Parse(typeof(Schedule_File_ColumnSeparator), "Comma");
        

[Description(@"when the interval does not match the user specified timestep a ""Yes"" choice will average between the intervals request (to timestep resolution. a ""No"" choice will use the interval value at the simulation timestep without regard to if it matches the boundary or not.")]
[JsonProperty("interpolate_to_timestep")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes InterpolateToTimestep { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Must be evenly divisible into 60")]
[JsonProperty("minutes_per_item")]
public System.Nullable<float> MinutesPerItem { get; set; } = null;
    }
    
    public enum Schedule_File_ColumnSeparator
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Comma")]
        Comma = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Semicolon")]
        Semicolon = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Space")]
        Space = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Tab")]
        Tab = 4,
    }
}
