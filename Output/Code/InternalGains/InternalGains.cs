namespace BH.oM.Adapters.EnergyPlus.InternalGains
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
    
    
    [Description("Sets internal gains and contaminant rates for occupants in the zone. If you use a" +
        " ZoneList in the Zone or ZoneList name field then this definition applies to all" +
        " the zones in the ZoneList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class People : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[Description("units in schedule should be fraction applied to number of people (0.0 - 1.0)")]
[JsonProperty("number_of_people_schedule_name")]
public string NumberOfPeopleScheduleName { get; set; } = "";
        

[Description(@"The entered calculation method is used to create the maximum number of people for this set of attributes (i.e. sensible fraction, schedule, etc) Choices: People -- simply enter number of occupants. People per Zone Floor Area -- enter the number to apply. Value * Floor Area = Number of people Zone Floor Area per Person -- enter the number to apply. Floor Area / Value = Number of people")]
[JsonProperty("number_of_people_calculation_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_NumberOfPeopleCalculationMethod NumberOfPeopleCalculationMethod { get; set; } = (People_NumberOfPeopleCalculationMethod)Enum.Parse(typeof(People_NumberOfPeopleCalculationMethod), "People");
        

[JsonProperty("number_of_people")]
public System.Nullable<float> NumberOfPeople { get; set; } = null;
        

[JsonProperty("people_per_zone_floor_area")]
public System.Nullable<float> PeoplePerZoneFloorArea { get; set; } = null;
        

[JsonProperty("zone_floor_area_per_person")]
public System.Nullable<float> ZoneFloorAreaPerPerson { get; set; } = null;
        

[Description("This is radiant fraction of the sensible heat released by people in a zone. This " +
    "value will be multiplied by the total sensible heat released by people yields th" +
    "e amount of long wavelength radiation gain from people in a zone. Default value " +
    "is 0.30.")]
[JsonProperty("fraction_radiant")]
public System.Nullable<float> FractionRadiant { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

[Description("if input, overrides program calculated sensible/latent split")]
[JsonProperty("sensible_heat_fraction")]
public string SensibleHeatFraction { get; set; } = (System.String)"Autocalculate";
        

[Description("Note that W has to be converted to mets in TC routine units in schedule are W/per" +
    "son")]
[JsonProperty("activity_level_schedule_name")]
public string ActivityLevelScheduleName { get; set; } = "";
        

[Description("CO2 generation rate per unit of activity level. The default value is obtained fro" +
    "m ASHRAE Std 62.1 at 0.0084 cfm/met/person over the general adult population.")]
[JsonProperty("carbon_dioxide_generation_rate")]
public System.Nullable<float> CarbonDioxideGenerationRate { get; set; } = (System.Nullable<float>)Single.Parse("3.82E-08", CultureInfo.InvariantCulture);
        

[JsonProperty("enable_ashrae_55_comfort_warnings")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes EnableAshrae55ComfortWarnings { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("optional (only required for thermal comfort runs)")]
[JsonProperty("mean_radiant_temperature_calculation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_MeanRadiantTemperatureCalculationType MeanRadiantTemperatureCalculationType { get; set; } = (People_MeanRadiantTemperatureCalculationType)Enum.Parse(typeof(People_MeanRadiantTemperatureCalculationType), "ZoneAveraged");
        

[Description("optional (only required for runs of thermal comfort models: Fanger, Pierce, KSU, " +
    "CoolingEffectASH55 and AnkleDraftASH55)")]
[JsonProperty("surface_name_angle_factor_list_name")]
public string SurfaceNameAngleFactorListName { get; set; } = "";
        

[Description("units in schedule are 0.0 to 1.0 optional (only required for runs of thermal comf" +
    "ort models: Fanger, Pierce, KSU, CoolingEffectASH55 and AnkleDraftASH55)")]
[JsonProperty("work_efficiency_schedule_name")]
public string WorkEfficiencyScheduleName { get; set; } = "";
        

[JsonProperty("clothing_insulation_calculation_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ClothingInsulationCalculationMethod ClothingInsulationCalculationMethod { get; set; } = (People_ClothingInsulationCalculationMethod)Enum.Parse(typeof(People_ClothingInsulationCalculationMethod), "ClothingInsulationSchedule");
        

[Description("a schedule value of 1 for the Scheduled method, and 2 for the DynamicClothingMode" +
    "lASHRAE55 method")]
[JsonProperty("clothing_insulation_calculation_method_schedule_name")]
public string ClothingInsulationCalculationMethodScheduleName { get; set; } = "";
        

[Description("use \"Clo\" from ASHRAE or Thermal Comfort guides optional (only required for runs " +
    "of thermal comfort models: Fanger, Pierce, KSU, CoolingEffectASH55 and AnkleDraf" +
    "tASH55)")]
[JsonProperty("clothing_insulation_schedule_name")]
public string ClothingInsulationScheduleName { get; set; } = "";
        

[Description("units in the schedule are m/s optional (only required for runs of thermal comfort" +
    " models: Fanger, Pierce, KSU, CoolingEffectASH55 and AnkleDraftASH55)")]
[JsonProperty("air_velocity_schedule_name")]
public string AirVelocityScheduleName { get; set; } = "";
        

[Description("optional (only needed for people thermal comfort results reporting)")]
[JsonProperty("thermal_comfort_model_1_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel1Type ThermalComfortModel1Type { get; set; } = (People_ThermalComfortModel1Type)Enum.Parse(typeof(People_ThermalComfortModel1Type), "AdaptiveASH55");
        

[Description("optional (second type of thermal comfort model and results reporting)")]
[JsonProperty("thermal_comfort_model_2_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel2Type ThermalComfortModel2Type { get; set; } = (People_ThermalComfortModel2Type)Enum.Parse(typeof(People_ThermalComfortModel2Type), "AdaptiveASH55");
        

[Description("optional (third thermal comfort model and report type)")]
[JsonProperty("thermal_comfort_model_3_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel3Type ThermalComfortModel3Type { get; set; } = (People_ThermalComfortModel3Type)Enum.Parse(typeof(People_ThermalComfortModel3Type), "AdaptiveASH55");
        

[Description("optional (fourth thermal comfort model and report type)")]
[JsonProperty("thermal_comfort_model_4_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel4Type ThermalComfortModel4Type { get; set; } = (People_ThermalComfortModel4Type)Enum.Parse(typeof(People_ThermalComfortModel4Type), "AdaptiveASH55");
        

[Description("optional (fifth thermal comfort model and report type)")]
[JsonProperty("thermal_comfort_model_5_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel5Type ThermalComfortModel5Type { get; set; } = (People_ThermalComfortModel5Type)Enum.Parse(typeof(People_ThermalComfortModel5Type), "AdaptiveASH55");
        

[Description("optional (sixth thermal comfort model and report type)")]
[JsonProperty("thermal_comfort_model_6_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel6Type ThermalComfortModel6Type { get; set; } = (People_ThermalComfortModel6Type)Enum.Parse(typeof(People_ThermalComfortModel6Type), "AdaptiveASH55");
        

[Description("optional (seventh thermal comfort model and report type)")]
[JsonProperty("thermal_comfort_model_7_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel7Type ThermalComfortModel7Type { get; set; } = (People_ThermalComfortModel7Type)Enum.Parse(typeof(People_ThermalComfortModel7Type), "AdaptiveASH55");
        

[Description("units in the schedule are m/s this is the schedule of the air speed at the 0.1 m " +
    "above the floor optional (only required for runs of thermal comfort models Ankle" +
    "DraftASH55)")]
[JsonProperty("ankle_level_air_velocity_schedule_name")]
public string AnkleLevelAirVelocityScheduleName { get; set; } = "";
    }
    
    public enum People_NumberOfPeopleCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Area/Person")]
        AreaPerson = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="People")]
        People = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="People/Area")]
        PeopleArea = 3,
    }
    
    public enum People_MeanRadiantTemperatureCalculationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AngleFactor")]
        AngleFactor = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceWeighted")]
        SurfaceWeighted = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAveraged")]
        ZoneAveraged = 3,
    }
    
    public enum People_ClothingInsulationCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CalculationMethodSchedule")]
        CalculationMethodSchedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ClothingInsulationSchedule")]
        ClothingInsulationSchedule = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DynamicClothingModelASHRAE55")]
        DynamicClothingModelASHRAE55 = 3,
    }
    
    public enum People_ThermalComfortModel1Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASH55")]
        AdaptiveASH55 = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251")]
        AdaptiveCEN15251 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AnkleDraftASH55")]
        AnkleDraftASH55 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingEffectASH55")]
        CoolingEffectASH55 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Fanger")]
        Fanger = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="KSU")]
        KSU = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Pierce")]
        Pierce = 6,
    }
    
    public enum People_ThermalComfortModel2Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASH55")]
        AdaptiveASH55 = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251")]
        AdaptiveCEN15251 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AnkleDraftASH55")]
        AnkleDraftASH55 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingEffectASH55")]
        CoolingEffectASH55 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Fanger")]
        Fanger = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="KSU")]
        KSU = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Pierce")]
        Pierce = 6,
    }
    
    public enum People_ThermalComfortModel3Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASH55")]
        AdaptiveASH55 = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251")]
        AdaptiveCEN15251 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AnkleDraftASH55")]
        AnkleDraftASH55 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingEffectASH55")]
        CoolingEffectASH55 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Fanger")]
        Fanger = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="KSU")]
        KSU = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Pierce")]
        Pierce = 6,
    }
    
    public enum People_ThermalComfortModel4Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASH55")]
        AdaptiveASH55 = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251")]
        AdaptiveCEN15251 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AnkleDraftASH55")]
        AnkleDraftASH55 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingEffectASH55")]
        CoolingEffectASH55 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Fanger")]
        Fanger = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="KSU")]
        KSU = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Pierce")]
        Pierce = 6,
    }
    
    public enum People_ThermalComfortModel5Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASH55")]
        AdaptiveASH55 = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251")]
        AdaptiveCEN15251 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AnkleDraftASH55")]
        AnkleDraftASH55 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingEffectASH55")]
        CoolingEffectASH55 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Fanger")]
        Fanger = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="KSU")]
        KSU = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Pierce")]
        Pierce = 6,
    }
    
    public enum People_ThermalComfortModel6Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASH55")]
        AdaptiveASH55 = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251")]
        AdaptiveCEN15251 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AnkleDraftASH55")]
        AnkleDraftASH55 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingEffectASH55")]
        CoolingEffectASH55 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Fanger")]
        Fanger = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="KSU")]
        KSU = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Pierce")]
        Pierce = 6,
    }
    
    public enum People_ThermalComfortModel7Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASH55")]
        AdaptiveASH55 = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251")]
        AdaptiveCEN15251 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AnkleDraftASH55")]
        AnkleDraftASH55 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingEffectASH55")]
        CoolingEffectASH55 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Fanger")]
        Fanger = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="KSU")]
        KSU = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Pierce")]
        Pierce = 6,
    }
    
    [Description("Used to specify radiant view factors for thermal comfort calculations.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ComfortViewFactorAngles : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("surface_1_name")]
public string Surface1Name { get; set; } = "";
        

[JsonProperty("angle_factor_1")]
public System.Nullable<float> AngleFactor1 { get; set; } = null;
        

[JsonProperty("surface_2_name")]
public string Surface2Name { get; set; } = "";
        

[JsonProperty("angle_factor_2")]
public System.Nullable<float> AngleFactor2 { get; set; } = null;
        

[JsonProperty("surface_3_name")]
public string Surface3Name { get; set; } = "";
        

[JsonProperty("angle_factor_3")]
public System.Nullable<float> AngleFactor3 { get; set; } = null;
        

[JsonProperty("surface_4_name")]
public string Surface4Name { get; set; } = "";
        

[JsonProperty("angle_factor_4")]
public System.Nullable<float> AngleFactor4 { get; set; } = null;
        

[JsonProperty("surface_5_name")]
public string Surface5Name { get; set; } = "";
        

[JsonProperty("angle_factor_5")]
public System.Nullable<float> AngleFactor5 { get; set; } = null;
        

[JsonProperty("surface_6_name")]
public string Surface6Name { get; set; } = "";
        

[JsonProperty("angle_factor_6")]
public System.Nullable<float> AngleFactor6 { get; set; } = null;
        

[JsonProperty("surface_7_name")]
public string Surface7Name { get; set; } = "";
        

[JsonProperty("angle_factor_7")]
public System.Nullable<float> AngleFactor7 { get; set; } = null;
        

[JsonProperty("surface_8_name")]
public string Surface8Name { get; set; } = "";
        

[JsonProperty("angle_factor_8")]
public System.Nullable<float> AngleFactor8 { get; set; } = null;
        

[JsonProperty("surface_9_name")]
public string Surface9Name { get; set; } = "";
        

[JsonProperty("angle_factor_9")]
public System.Nullable<float> AngleFactor9 { get; set; } = null;
        

[JsonProperty("surface_10_name")]
public string Surface10Name { get; set; } = "";
        

[JsonProperty("angle_factor_10")]
public System.Nullable<float> AngleFactor10 { get; set; } = null;
        

[JsonProperty("surface_11_name")]
public string Surface11Name { get; set; } = "";
        

[JsonProperty("angle_factor_11")]
public System.Nullable<float> AngleFactor11 { get; set; } = null;
        

[JsonProperty("surface_12_name")]
public string Surface12Name { get; set; } = "";
        

[JsonProperty("angle_factor_12")]
public System.Nullable<float> AngleFactor12 { get; set; } = null;
        

[JsonProperty("surface_13_name")]
public string Surface13Name { get; set; } = "";
        

[JsonProperty("angle_factor_13")]
public System.Nullable<float> AngleFactor13 { get; set; } = null;
        

[JsonProperty("surface_14_name")]
public string Surface14Name { get; set; } = "";
        

[JsonProperty("angle_factor_14")]
public System.Nullable<float> AngleFactor14 { get; set; } = null;
        

[JsonProperty("surface_15_name")]
public string Surface15Name { get; set; } = "";
        

[JsonProperty("angle_factor_15")]
public System.Nullable<float> AngleFactor15 { get; set; } = null;
        

[JsonProperty("surface_16_name")]
public string Surface16Name { get; set; } = "";
        

[JsonProperty("angle_factor_16")]
public System.Nullable<float> AngleFactor16 { get; set; } = null;
        

[JsonProperty("surface_17_name")]
public string Surface17Name { get; set; } = "";
        

[JsonProperty("angle_factor_17")]
public System.Nullable<float> AngleFactor17 { get; set; } = null;
        

[JsonProperty("surface_18_name")]
public string Surface18Name { get; set; } = "";
        

[JsonProperty("angle_factor_18")]
public System.Nullable<float> AngleFactor18 { get; set; } = null;
        

[JsonProperty("surface_19_name")]
public string Surface19Name { get; set; } = "";
        

[JsonProperty("angle_factor_19")]
public System.Nullable<float> AngleFactor19 { get; set; } = null;
        

[JsonProperty("surface_20_name")]
public string Surface20Name { get; set; } = "";
        

[JsonProperty("angle_factor_20")]
public System.Nullable<float> AngleFactor20 { get; set; } = null;
    }
    
    [Description("Sets internal gains for lights in the zone. If you use a ZoneList in the Zone or " +
        "ZoneList name field then this definition applies to all the zones in the ZoneLis" +
        "t.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Lights : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[Description("units in schedule should be fraction applied to design level of lights, generally" +
    " (0.0 - 1.0)")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description(@"The entered calculation method is used to create the maximum amount of lights for this set of attributes Choices: LightingLevel => Lighting Level -- simply enter watts of lights Watts/Area => Watts per Zone Floor Area -- enter the number to apply. Value * Floor Area = Lights Watts/Person => Watts per Person -- enter the number to apply. Value * Occupants = Lights")]
[JsonProperty("design_level_calculation_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Lights_DesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = (Lights_DesignLevelCalculationMethod)Enum.Parse(typeof(Lights_DesignLevelCalculationMethod), "LightingLevel");
        

[JsonProperty("lighting_level")]
public System.Nullable<float> LightingLevel { get; set; } = null;
        

[JsonProperty("watts_per_zone_floor_area")]
public System.Nullable<float> WattsPerZoneFloorArea { get; set; } = null;
        

[JsonProperty("watts_per_person")]
public System.Nullable<float> WattsPerPerson { get; set; } = null;
        

[Description("Used only for sizing calculation if return-air-fraction coefficients are specifie" +
    "d.")]
[JsonProperty("return_air_fraction")]
public System.Nullable<float> ReturnAirFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_radiant")]
public System.Nullable<float> FractionRadiant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_visible")]
public System.Nullable<float> FractionVisible { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("For Daylighting:Controls must be 0 or 1:  0 = no dimming control, 1 = full dimmin" +
    "g control")]
[JsonProperty("fraction_replaceable")]
public System.Nullable<float> FractionReplaceable { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
        

[JsonProperty("return_air_fraction_calculated_from_plenum_temperature")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes ReturnAirFractionCalculatedFromPlenumTemperature { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Used only if Return Air Fraction Is Calculated from Plenum Temperature = Yes Equa" +
    "tion is Return Air Fraction = Coefficient#1 - Coefficient#2 X PlenumTemp(degC)")]
[JsonProperty("return_air_fraction_function_of_plenum_temperature_coefficient_1")]
public System.Nullable<float> ReturnAirFractionFunctionOfPlenumTemperatureCoefficient1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only if Return Air Fraction Is Calculated from Plenum Temperature = Yes Equa" +
    "tion is Return Air Fraction = Coefficient#1 - Coefficient#2 X PlenumTemp(degC)")]
[JsonProperty("return_air_fraction_function_of_plenum_temperature_coefficient_2")]
public System.Nullable<float> ReturnAirFractionFunctionOfPlenumTemperatureCoefficient2 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Name of the return air node for this heat gain. If left blank, defaults to the fi" +
    "rst return air node for the zone. Leave this field blank when using a ZoneList n" +
    "ame.")]
[JsonProperty("return_air_heat_gain_node_name")]
public string ReturnAirHeatGainNodeName { get; set; } = "";
    }
    
    public enum Lights_DesignLevelCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LightingLevel")]
        LightingLevel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Area")]
        WattsArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Person")]
        WattsPerson = 3,
    }
    
    [Description("Sets internal gains for electric equipment in the zone. If you use a ZoneList in " +
        "the Zone or ZoneList name field then this definition applies to all the zones in" +
        " the ZoneList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricEquipment : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[Description("units in schedule should be fraction applied to design level of electric equipmen" +
    "t, generally (0.0 - 1.0)")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description(@"The entered calculation method is used to create the maximum amount of electric equipment for this set of attributes Choices: EquipmentLevel => Equipment Level -- simply enter watts of equipment Watts/Area => Watts per Zone Floor Area -- enter the number to apply. Value * Floor Area = Equipment Level Watts/Person => Watts per Person -- enter the number to apply. Value * Occupants = Equipment Level")]
[JsonProperty("design_level_calculation_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ElectricEquipment_DesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = (ElectricEquipment_DesignLevelCalculationMethod)Enum.Parse(typeof(ElectricEquipment_DesignLevelCalculationMethod), "EquipmentLevel");
        

[JsonProperty("design_level")]
public System.Nullable<float> DesignLevel { get; set; } = null;
        

[JsonProperty("watts_per_zone_floor_area")]
public System.Nullable<float> WattsPerZoneFloorArea { get; set; } = null;
        

[JsonProperty("watts_per_person")]
public System.Nullable<float> WattsPerPerson { get; set; } = null;
        

[JsonProperty("fraction_latent")]
public System.Nullable<float> FractionLatent { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_radiant")]
public System.Nullable<float> FractionRadiant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_lost")]
public System.Nullable<float> FractionLost { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum ElectricEquipment_DesignLevelCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="EquipmentLevel")]
        EquipmentLevel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Area")]
        WattsArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Person")]
        WattsPerson = 3,
    }
    
    [Description("Sets internal gains and contaminant rates for gas equipment in the zone. If you u" +
        "se a ZoneList in the Zone name field then this definition applies to all those z" +
        "ones.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GasEquipment : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[Description("units in Schedule should be fraction applied to design level of gas equipment, ge" +
    "nerally (0.0 - 1.0)")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description(@"The entered calculation method is used to create the maximum amount of gas equipment for this set of attributes Choices: EquipmentLevel => Design Level -- simply enter power input of equipment Watts/Area or Power/Area => Power per Zone Floor Area -- enter the number to apply. Value * Floor Area = Equipment Level Watts/Person or Power/Person => Power per Person -- enter the number to apply. Value * Occupants = Equipment Level")]
[JsonProperty("design_level_calculation_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GasEquipment_DesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = (GasEquipment_DesignLevelCalculationMethod)Enum.Parse(typeof(GasEquipment_DesignLevelCalculationMethod), "EquipmentLevel");
        

[JsonProperty("design_level")]
public System.Nullable<float> DesignLevel { get; set; } = null;
        

[JsonProperty("power_per_zone_floor_area")]
public System.Nullable<float> PowerPerZoneFloorArea { get; set; } = null;
        

[JsonProperty("power_per_person")]
public System.Nullable<float> PowerPerPerson { get; set; } = null;
        

[JsonProperty("fraction_latent")]
public System.Nullable<float> FractionLatent { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_radiant")]
public System.Nullable<float> FractionRadiant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_lost")]
public System.Nullable<float> FractionLost { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"CO2 generation rate per unit of power input The default value assumes the equipment is fully vented. For unvented equipment, a suggested value is 3.45E-8 m3/s-W. This value is converted from a natural gas CO2 emission rate of 117 lbs CO2 per million Btu. The maximum value assumes to be 10 times of the recommended value.")]
[JsonProperty("carbon_dioxide_generation_rate")]
public System.Nullable<float> CarbonDioxideGenerationRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum GasEquipment_DesignLevelCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="EquipmentLevel")]
        EquipmentLevel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Power/Area")]
        PowerArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Power/Person")]
        PowerPerson = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Area")]
        WattsArea = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Person")]
        WattsPerson = 5,
    }
    
    [Description("Sets internal gains for hot water equipment in the zone. If you use a ZoneList in" +
        " the Zone name field then this definition applies to all those zones.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HotWaterEquipment : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[Description("units in Schedule should be fraction applied to design level of hot water equipme" +
    "nt, generally (0.0 - 1.0)")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description(@"The entered calculation method is used to create the maximum amount of hot water equipment for this set of attributes Choices: EquipmentLevel => Design Level -- simply enter power input of equipment Watts/Area or Power/Area => Power per Zone Floor Area -- enter the number to apply. Value * Floor Area = Equipment Level Watts/Person or Power/Person => Power per Person -- enter the number to apply. Value * Occupants = Equipment Level")]
[JsonProperty("design_level_calculation_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public HotWaterEquipment_DesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = (HotWaterEquipment_DesignLevelCalculationMethod)Enum.Parse(typeof(HotWaterEquipment_DesignLevelCalculationMethod), "EquipmentLevel");
        

[JsonProperty("design_level")]
public System.Nullable<float> DesignLevel { get; set; } = null;
        

[JsonProperty("power_per_zone_floor_area")]
public System.Nullable<float> PowerPerZoneFloorArea { get; set; } = null;
        

[JsonProperty("power_per_person")]
public System.Nullable<float> PowerPerPerson { get; set; } = null;
        

[JsonProperty("fraction_latent")]
public System.Nullable<float> FractionLatent { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_radiant")]
public System.Nullable<float> FractionRadiant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_lost")]
public System.Nullable<float> FractionLost { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum HotWaterEquipment_DesignLevelCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="EquipmentLevel")]
        EquipmentLevel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Power/Area")]
        PowerArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Power/Person")]
        PowerPerson = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Area")]
        WattsArea = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Person")]
        WattsPerson = 5,
    }
    
    [Description("Sets internal gains for steam equipment in the zone.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SteamEquipment : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[Description("units in Schedule should be fraction applied to design level of steam equipment, " +
    "generally (0.0 - 1.0)")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description(@"The entered calculation method is used to create the maximum amount of steam equipment for this set of attributes Choices: EquipmentLevel => Design Level -- simply enter power input of equipment Watts/Area or Power/Area => Power per Zone Floor Area -- enter the number to apply. Value * Floor Area = Equipment Level Watts/Person or Power/Person => Power per Person -- enter the number to apply. Value * Occupants = Equipment Level")]
[JsonProperty("design_level_calculation_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public SteamEquipment_DesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = (SteamEquipment_DesignLevelCalculationMethod)Enum.Parse(typeof(SteamEquipment_DesignLevelCalculationMethod), "EquipmentLevel");
        

[JsonProperty("design_level")]
public System.Nullable<float> DesignLevel { get; set; } = null;
        

[JsonProperty("power_per_zone_floor_area")]
public System.Nullable<float> PowerPerZoneFloorArea { get; set; } = null;
        

[JsonProperty("power_per_person")]
public System.Nullable<float> PowerPerPerson { get; set; } = null;
        

[JsonProperty("fraction_latent")]
public System.Nullable<float> FractionLatent { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_radiant")]
public System.Nullable<float> FractionRadiant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_lost")]
public System.Nullable<float> FractionLost { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum SteamEquipment_DesignLevelCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="EquipmentLevel")]
        EquipmentLevel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Power/Area")]
        PowerArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Power/Person")]
        PowerPerson = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Area")]
        WattsArea = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Person")]
        WattsPerson = 5,
    }
    
    [Description("Sets internal gains or losses for \"other\" equipment in the zone.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OtherEquipment : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("fuel_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OtherEquipment_FuelType FuelType { get; set; } = (OtherEquipment_FuelType)Enum.Parse(typeof(OtherEquipment_FuelType), "None");
        

[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[Description("units in Schedule should be fraction applied to design level of other equipment, " +
    "generally (0.0 - 1.0)")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description(@"The entered calculation method is used to create the maximum amount of other equipment. to set a loss, use a negative value in the following fields. for this set of attributes Choices: EquipmentLevel => Design Level -- simply enter power input of equipment Watts/Area or Power/Area => Power per Zone Floor Area -- enter the number to apply. Value * Floor Area = Equipment Level Watts/Person or Power/Person => Power per Person -- enter the number to apply. Value * Occupants = Equipment Level")]
[JsonProperty("design_level_calculation_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OtherEquipment_DesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = (OtherEquipment_DesignLevelCalculationMethod)Enum.Parse(typeof(OtherEquipment_DesignLevelCalculationMethod), "EquipmentLevel");
        

[JsonProperty("design_level")]
public System.Nullable<float> DesignLevel { get; set; } = null;
        

[JsonProperty("power_per_zone_floor_area")]
public System.Nullable<float> PowerPerZoneFloorArea { get; set; } = null;
        

[JsonProperty("power_per_person")]
public System.Nullable<float> PowerPerPerson { get; set; } = null;
        

[JsonProperty("fraction_latent")]
public System.Nullable<float> FractionLatent { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_radiant")]
public System.Nullable<float> FractionRadiant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("fraction_lost")]
public System.Nullable<float> FractionLost { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("CO2 generation rate per unit of power input The default value assumes the equipme" +
    "nt is fully vented.")]
[JsonProperty("carbon_dioxide_generation_rate")]
public System.Nullable<float> CarbonDioxideGenerationRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum OtherEquipment_FuelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coal")]
        Coal = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Diesel")]
        Diesel = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictCooling")]
        DistrictCooling = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictHeating")]
        DistrictHeating = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Electricity")]
        Electricity = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo1")]
        FuelOilNo1 = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo2")]
        FuelOilNo2 = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Gasoline")]
        Gasoline = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="NaturalGas")]
        NaturalGas = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel1")]
        OtherFuel1 = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel2")]
        OtherFuel2 = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Propane")]
        Propane = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 14,
    }
    
    public enum OtherEquipment_DesignLevelCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="EquipmentLevel")]
        EquipmentLevel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Power/Area")]
        PowerArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Power/Person")]
        PowerPerson = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Area")]
        WattsArea = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Person")]
        WattsPerson = 5,
    }
    
    [Description("This object describes air-cooled electric information technology equipment (ITE) " +
        "which has variable power consumption as a function of loading and temperature.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricEquipment_ITE_AirCooled : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description(@"The specified method is used to calculate the IT inlet temperature and zone return air temperature. If FlowFromSystem is chosen, the zone is assumed to be well-mixed. If FlowControlWithApproachTemperatures is chosen, Supply and Return approach temperature should be defined to indicate the temperature difference due to the air distribution. When FlowControlWithApproachTemperatures is chosen, the inputs of Air Inlet Connection Type, Design Recirculation Fraction and Recirculation Function of Loading and Supply Temperature Curve Name are ignored. For multiple ITE objects defined for one zone, the same calculation method should apply. The FlowControlWithApproachTemperatures only applies to ITE zones with single duct VAV terminal unit. Other return air heat gains from window or lights are not allowed when FlowControlWithApproachTemperatures is chosen.")]
[JsonProperty("air_flow_calculation_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ElectricEquipment_ITE_AirCooled_AirFlowCalculationMethod AirFlowCalculationMethod { get; set; } = (ElectricEquipment_ITE_AirCooled_AirFlowCalculationMethod)Enum.Parse(typeof(ElectricEquipment_ITE_AirCooled_AirFlowCalculationMethod), "FlowFromSystem");
        

[Description("The entered calculation method is used to specify the design power input Watts/Un" +
    "it => Watts per Unit -- Design Power = Watts per Unit * Number of Units Watts/Ar" +
    "ea => Watts per Zone Floor Area -- Design Power = Watts per Zone Floor Area * Fl" +
    "oor Area")]
[JsonProperty("design_power_input_calculation_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ElectricEquipment_ITE_AirCooled_DesignPowerInputCalculationMethod DesignPowerInputCalculationMethod { get; set; } = (ElectricEquipment_ITE_AirCooled_DesignPowerInputCalculationMethod)Enum.Parse(typeof(ElectricEquipment_ITE_AirCooled_DesignPowerInputCalculationMethod), "Empty");
        

[JsonProperty("watts_per_unit")]
public System.Nullable<float> WattsPerUnit { get; set; } = null;
        

[JsonProperty("number_of_units")]
public System.Nullable<float> NumberOfUnits { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("watts_per_zone_floor_area")]
public System.Nullable<float> WattsPerZoneFloorArea { get; set; } = null;
        

[Description("Operating schedule for this equipment, fraction applied to the design power input" +
    ", generally (0.0 - 1.0) If this field is blank, the schedule is assumed to alway" +
    "s be 1.0.")]
[JsonProperty("design_power_input_schedule_name")]
public string DesignPowerInputScheduleName { get; set; } = "";
        

[Description("CPU loading schedule for this equipment as a fraction from 0.0 (idle) to 1.0 (ful" +
    "l load). If this field is blank, the schedule is assumed to always be 1.0.")]
[JsonProperty("cpu_loading_schedule_name")]
public string CpuLoadingScheduleName { get; set; } = "";
        

[Description(@"The name of a two-variable curve or table lookup object which modifies the CPU power input as a function of CPU loading (x) and air inlet node temperature (y). This curve (table) should equal 1.0 at design conditions (CPU loading = 1.0 and Design Entering Air Temperature).")]
[JsonProperty("cpu_power_input_function_of_loading_and_air_temperature_curve_name")]
public string CpuPowerInputFunctionOfLoadingAndAirTemperatureCurveName { get; set; } = "";
        

[Description("The fraction of the total power input at design conditions which is for the cooli" +
    "ng fan(s)")]
[JsonProperty("design_fan_power_input_fraction")]
public System.Nullable<float> DesignFanPowerInputFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The cooling fan air flow rate per total electric power input at design conditions" +
    "")]
[JsonProperty("design_fan_air_flow_rate_per_power_input")]
public System.Nullable<float> DesignFanAirFlowRatePerPowerInput { get; set; } = null;
        

[Description(@"The name of a two-variable curve or table lookup object which modifies the cooling air flow rate as a function of CPU loading (x) and air inlet node temperature (y). This curve (table) should equal 1.0 at design conditions (CPU loading = 1.0 and Design Entering Air Temperature).")]
[JsonProperty("air_flow_function_of_loading_and_air_temperature_curve_name")]
public string AirFlowFunctionOfLoadingAndAirTemperatureCurveName { get; set; } = "";
        

[Description("The name of a single-variable curve or table lookup object which modifies the coo" +
    "ling fan power as a function of flow fraction (x). This curve (table) should equ" +
    "al 1.0 at a flow fraction of 1.0.")]
[JsonProperty("fan_power_input_function_of_flow_curve_name")]
public string FanPowerInputFunctionOfFlowCurveName { get; set; } = "";
        

[Description("The entering air temperature at design conditions.")]
[JsonProperty("design_entering_air_temperature")]
public System.Nullable<float> DesignEnteringAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

[Description("Specifies the allowable operating conditions for the air inlet conditions. Used f" +
    "or reporting time outside allowable conditions.")]
[JsonProperty("environmental_class")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ElectricEquipment_ITE_AirCooled_EnvironmentalClass EnvironmentalClass { get; set; } = (ElectricEquipment_ITE_AirCooled_EnvironmentalClass)Enum.Parse(typeof(ElectricEquipment_ITE_AirCooled_EnvironmentalClass), "None");
        

[Description(@"Specifies the type of connection between the zone and the ITE air inlet node. AdjustedSupply = ITE inlet temperature will be the current Supply Air Node temperature adjusted by the current recirculation fraction. All heat output is added to the zone air heat balance as a convective gain. ZoneAirNode = ITE air inlet condition is  the average zone condition. All heat output is added to the zone air heat balance as a convective gain. RoomAirModel = ITE air inlet and outlet are connected to room air model nodes. This field is only used when Air Flow Calculation Method is FlowFromSystem.")]
[JsonProperty("air_inlet_connection_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ElectricEquipment_ITE_AirCooled_AirInletConnectionType AirInletConnectionType { get; set; } = (ElectricEquipment_ITE_AirCooled_AirInletConnectionType)Enum.Parse(typeof(ElectricEquipment_ITE_AirCooled_AirInletConnectionType), "AdjustedSupply");
        

[Description("Name of a RoomAir:Node object which is connected to the ITE air inlet.")]
[JsonProperty("air_inlet_room_air_model_node_name")]
public string AirInletRoomAirModelNodeName { get; set; } = "";
        

[Description("Name of a RoomAir:Node object which is connected to the ITE air outlet.")]
[JsonProperty("air_outlet_room_air_model_node_name")]
public string AirOutletRoomAirModelNodeName { get; set; } = "";
        

[Description("Name of the supply air inlet node serving this ITE. Required if the Air Node Conn" +
    "ection Type = AdjustedSupply. Also required if Calculation Method = FlowControlW" +
    "ithApproachTemperatures. Also required if reporting of Supply Heat Index is desi" +
    "red.")]
[JsonProperty("supply_air_node_name")]
public string SupplyAirNodeName { get; set; } = "";
        

[Description(@"The recirculation fraction for this equipment at design conditions. This field is used only if the Air Node Connection Type = AdjustedSupply. The default is 0.0 (no recirculation). This field is only used when Air Flow Calculation Method is FlowFromSystem.")]
[JsonProperty("design_recirculation_fraction")]
public System.Nullable<float> DesignRecirculationFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"The name of a two-variable curve or table lookup object which modifies the recirculation fractionas a function of CPU loading (x) and supply air node temperature (y). This curve (table) should equal 1.0 at design conditions (CPU loading = 1.0 and Design Entering Air Temperature).This field is used only if the Air Node Connection Type = AdjustedSupply. If this curve is left blank, then the curve is assumed to always equal 1.0. This field is only used when Air Flow Calculation Method is FlowFromSystem.")]
[JsonProperty("recirculation_function_of_loading_and_supply_temperature_curve_name")]
public string RecirculationFunctionOfLoadingAndSupplyTemperatureCurveName { get; set; } = "";
        

[Description("The efficiency of the power supply system serving this ITE")]
[JsonProperty("design_electric_power_supply_efficiency")]
public System.Nullable<float> DesignElectricPowerSupplyEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description(@"The name of a single-variable curve or table lookup object which modifies the electric power supply efficiency as a function of part-load ratio (x). This curve (table) should equal 1.0 at full load (PLR = 1.0). If this curve is left blank, then the curve is assumed to always equal 1.0.")]
[JsonProperty("electric_power_supply_efficiency_function_of_part_load_ratio_curve_name")]
public string ElectricPowerSupplyEfficiencyFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

[Description("Fraction of the electric power supply losses which are a heat gain to the zone If" +
    " this field is <1.0, the remainder of the losses are assumed to be lost to the o" +
    "utdoors.")]
[JsonProperty("fraction_of_electric_power_supply_losses_to_zone")]
public System.Nullable<float> FractionOfElectricPowerSupplyLossesToZone { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("cpu_end_use_subcategory")]
public string CpuEndUseSubcategory { get; set; } = (System.String)"ITE-CPU";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("fan_end_use_subcategory")]
public string FanEndUseSubcategory { get; set; } = (System.String)"ITE-Fans";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("electric_power_supply_end_use_subcategory")]
public string ElectricPowerSupplyEndUseSubcategory { get; set; } = (System.String)"ITE-UPS";
        

[Description(@"The difference of the IT inlet temperature from the AHU supply air temperature. Either Supply Temperature Difference or Supply Temperature Difference Schedule is required if Air Flow Calculation Method is set to FlowControlWithApproachTemperatures. This field is ignored when Air Flow Calculation Method is FlowFromSystem.")]
[JsonProperty("supply_temperature_difference")]
public System.Nullable<float> SupplyTemperatureDifference { get; set; } = null;
        

[Description(@"The difference schedule of the IT inlet temperature from the AHU supply air temperature. Either Supply Temperature Difference or Supply Temperature Difference Schedule is required if Air Flow Calculation Method is set to FlowControlWithApproachTemperatures. This field is ignored when Air Flow Calculation Method is FlowFromSystem.")]
[JsonProperty("supply_temperature_difference_schedule")]
public string SupplyTemperatureDifferenceSchedule { get; set; } = "";
        

[Description(@"The difference of the the actual AHU return air temperature to the IT equipment outlet temperature. Either Return Temperature Difference or Return Temperature Difference Schedule is required if Air Flow Calculation Method is set to FlowControlWithApproachTemperatures. This field is ignored when Air Flow Calculation Method is FlowFromSystem.")]
[JsonProperty("return_temperature_difference")]
public System.Nullable<float> ReturnTemperatureDifference { get; set; } = null;
        

[Description(@"The difference schedule of the actual AHU return air temperature to the IT equipment outlet temperature. Either Return Temperature Difference or Return Temperature Difference Schedule is required if Air Flow Calculation Method is set to FlowControlWithApproachTemperatures. This field is ignored when Air Flow Calculation Method is FlowFromSystem.")]
[JsonProperty("return_temperature_difference_schedule")]
public string ReturnTemperatureDifferenceSchedule { get; set; } = "";
    }
    
    public enum ElectricEquipment_ITE_AirCooled_AirFlowCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowControlWithApproachTemperatures")]
        FlowControlWithApproachTemperatures = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowFromSystem")]
        FlowFromSystem = 2,
    }
    
    public enum ElectricEquipment_ITE_AirCooled_DesignPowerInputCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Area")]
        WattsArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Watts/Unit")]
        WattsUnit = 2,
    }
    
    public enum ElectricEquipment_ITE_AirCooled_EnvironmentalClass
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="A1")]
        A1 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="A2")]
        A2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="A3")]
        A3 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="A4")]
        A4 = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="B")]
        B = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="C")]
        C = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 7,
    }
    
    public enum ElectricEquipment_ITE_AirCooled_AirInletConnectionType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjustedSupply")]
        AdjustedSupply = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="RoomAirModel")]
        RoomAirModel = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAirNode")]
        ZoneAirNode = 3,
    }
    
    [Description("Specifies outside temperature-controlled electric baseboard heating.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneBaseboard_OutdoorTemperatureControlled : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("units in Schedule should be fraction applied to capacity of the baseboard heat eq" +
    "uipment, generally (0.0 - 1.0)")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[JsonProperty("capacity_at_low_temperature")]
public System.Nullable<float> CapacityAtLowTemperature { get; set; } = null;
        

[JsonProperty("low_temperature")]
public System.Nullable<float> LowTemperature { get; set; } = null;
        

[JsonProperty("capacity_at_high_temperature")]
public System.Nullable<float> CapacityAtHighTemperature { get; set; } = null;
        

[JsonProperty("high_temperature")]
public System.Nullable<float> HighTemperature { get; set; } = null;
        

[JsonProperty("fraction_radiant")]
public System.Nullable<float> FractionRadiant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    [Description("Specifies an indoor swimming pools linked to a floor surface. The pool is assumed" +
        " to cover the entire floor to which it is linked.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SwimmingPool_Indoor : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("Name of the floor surface where the pool is located.")]
[JsonProperty("surface_name")]
public string SurfaceName { get; set; } = "";
        

[JsonProperty("average_depth")]
public System.Nullable<float> AverageDepth { get; set; } = null;
        

[JsonProperty("activity_factor_schedule_name")]
public string ActivityFactorScheduleName { get; set; } = "";
        

[JsonProperty("make_up_water_supply_schedule_name")]
public string MakeUpWaterSupplyScheduleName { get; set; } = "";
        

[JsonProperty("cover_schedule_name")]
public string CoverScheduleName { get; set; } = "";
        

[JsonProperty("cover_evaporation_factor")]
public System.Nullable<float> CoverEvaporationFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("cover_convection_factor")]
public System.Nullable<float> CoverConvectionFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("cover_short_wavelength_radiation_factor")]
public System.Nullable<float> CoverShortWavelengthRadiationFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("cover_long_wavelength_radiation_factor")]
public System.Nullable<float> CoverLongWavelengthRadiationFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("pool_water_inlet_node")]
public string PoolWaterInletNode { get; set; } = "";
        

[JsonProperty("pool_water_outlet_node")]
public string PoolWaterOutletNode { get; set; } = "";
        

[JsonProperty("pool_heating_system_maximum_water_flow_rate")]
public System.Nullable<float> PoolHeatingSystemMaximumWaterFlowRate { get; set; } = null;
        

[Description("Power input per pool water flow rate")]
[JsonProperty("pool_miscellaneous_equipment_power")]
public System.Nullable<float> PoolMiscellaneousEquipmentPower { get; set; } = null;
        

[JsonProperty("setpoint_temperature_schedule")]
public string SetpointTemperatureSchedule { get; set; } = "";
        

[JsonProperty("maximum_number_of_people")]
public System.Nullable<float> MaximumNumberOfPeople { get; set; } = null;
        

[JsonProperty("people_schedule")]
public string PeopleSchedule { get; set; } = "";
        

[JsonProperty("people_heat_gain_schedule")]
public string PeopleHeatGainSchedule { get; set; } = "";
    }
    
    [Description("Represents internal CO2 gains and sinks in the zone.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneContaminantSourceAndSink_CarbonDioxide : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Positive values represent sources and negative values represent sinks.")]
[JsonProperty("design_generation_rate")]
public System.Nullable<float> DesignGenerationRate { get; set; } = null;
        

[Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
    "Design Generation Rate")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
    }
    
    [Description("Sets internal generic contaminant gains and sinks in a zone with constant values." +
        "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneContaminantSourceAndSink_Generic_Constant : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("The values represent source.")]
[JsonProperty("design_generation_rate")]
public System.Nullable<float> DesignGenerationRate { get; set; } = null;
        

[Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
    "Design Generation Rate")]
[JsonProperty("generation_schedule_name")]
public string GenerationScheduleName { get; set; } = "";
        

[Description("The value represent sink.")]
[JsonProperty("design_removal_coefficient")]
public System.Nullable<float> DesignRemovalCoefficient { get; set; } = null;
        

[Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
    "Design removal Coefficient")]
[JsonProperty("removal_schedule_name")]
public string RemovalScheduleName { get; set; } = "";
    }
    
    [Description("Simulate generic contaminant source driven by the pressure difference across a su" +
        "rface.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceContaminantSourceAndSink_Generic_PressureDriven : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("surface_name")]
public string SurfaceName { get; set; } = "";
        

[JsonProperty("design_generation_rate_coefficient")]
public System.Nullable<float> DesignGenerationRateCoefficient { get; set; } = null;
        

[Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
    "Design Generation Rate Coefficient")]
[JsonProperty("generation_schedule_name")]
public string GenerationScheduleName { get; set; } = "";
        

[JsonProperty("generation_exponent")]
public System.Nullable<float> GenerationExponent { get; set; } = null;
    }
    
    [Description("Simulate generic contaminant source driven by the cutoff concentration model.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneContaminantSourceAndSink_Generic_CutoffModel : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("design_generation_rate_coefficient")]
public System.Nullable<float> DesignGenerationRateCoefficient { get; set; } = null;
        

[Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
    "Design Generation Rate Coefficient")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description("When the zone concentration level is greater than the cutoff level, emission stop" +
    "s, and the source level is zero.")]
[JsonProperty("cutoff_generic_contaminant_at_which_emission_ceases")]
public System.Nullable<float> CutoffGenericContaminantAtWhichEmissionCeases { get; set; } = null;
    }
    
    [Description("Simulate generic contaminant source driven by the cutoff concentration model.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneContaminantSourceAndSink_Generic_DecaySource : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("initial_emission_rate")]
public System.Nullable<float> InitialEmissionRate { get; set; } = null;
        

[Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
    "Initial Emission Rate. When the value is equal to 1.0, the time will be reset to" +
    " zero.")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[JsonProperty("delay_time_constant")]
public System.Nullable<float> DelayTimeConstant { get; set; } = null;
    }
    
    [Description("Simulate generic contaminant source driven by the boundary layer diffusion contro" +
        "lled model.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceContaminantSourceAndSink_Generic_BoundaryLayerDiffusion : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("surface_name")]
public string SurfaceName { get; set; } = "";
        

[JsonProperty("mass_transfer_coefficient")]
public System.Nullable<float> MassTransferCoefficient { get; set; } = null;
        

[Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
    "Initial Emission Rate. When the value is equal to 1.0, the time will be reset to" +
    " zero.")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[JsonProperty("henry_adsorption_constant_or_partition_coefficient")]
public System.Nullable<float> HenryAdsorptionConstantOrPartitionCoefficient { get; set; } = null;
    }
    
    [Description("Simulate generic contaminant source driven by the boundary layer diffusion contro" +
        "lled model.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceContaminantSourceAndSink_Generic_DepositionVelocitySink : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("surface_name")]
public string SurfaceName { get; set; } = "";
        

[JsonProperty("deposition_velocity")]
public System.Nullable<float> DepositionVelocity { get; set; } = null;
        

[Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
    "Initial Emission Rate. When the value is equal to 1.0, the time will be reset to" +
    " zero.")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
    }
    
    [Description("Simulate generic contaminant source driven by the boundary layer diffusion contro" +
        "lled model.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneContaminantSourceAndSink_Generic_DepositionRateSink : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("deposition_rate")]
public System.Nullable<float> DepositionRate { get; set; } = null;
        

[Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
    "Initial Emission Rate. When the value is equal to 1.0, the time will be reset to" +
    " zero.")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
    }
}
