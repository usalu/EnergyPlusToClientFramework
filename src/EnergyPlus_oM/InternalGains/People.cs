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
    [JsonObject("People")]
    public class People : BHoMObject
    {
        

[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[Description("units in schedule should be fraction applied to number of people (0.0 - 1.0)")]
[JsonProperty("number_of_people_schedule_name")]
public string NumberOfPeopleScheduleName { get; set; } = "";
        

[Description(@"The entered calculation method is used to create the maximum number of people for this set of attributes (i.e. sensible fraction, schedule, etc) Choices: People -- simply enter number of occupants. People per Zone Floor Area -- enter the number to apply. Value * Floor Area = Number of people Zone Floor Area per Person -- enter the number to apply. Floor Area / Value = Number of people")]
[JsonProperty("number_of_people_calculation_method")]
public EmptyNoYes NumberOfPeopleCalculationMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "People");
        

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
public EmptyNoYes EnableAshrae55ComfortWarnings { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("optional (only required for thermal comfort runs)")]
[JsonProperty("mean_radiant_temperature_calculation_type")]
public EmptyNoYes MeanRadiantTemperatureCalculationType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ZoneAveraged");
        

[Description("optional (only required for runs of thermal comfort models: Fanger, Pierce, KSU, " +
    "CoolingEffectASH55 and AnkleDraftASH55)")]
[JsonProperty("surface_name_angle_factor_list_name")]
public string SurfaceNameAngleFactorListName { get; set; } = "";
        

[Description("units in schedule are 0.0 to 1.0 optional (only required for runs of thermal comf" +
    "ort models: Fanger, Pierce, KSU, CoolingEffectASH55 and AnkleDraftASH55)")]
[JsonProperty("work_efficiency_schedule_name")]
public string WorkEfficiencyScheduleName { get; set; } = "";
        

[JsonProperty("clothing_insulation_calculation_method")]
public EmptyNoYes ClothingInsulationCalculationMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ClothingInsulationSchedule");
        

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
public EmptyNoYes ThermalComfortModel1Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

[Description("optional (second type of thermal comfort model and results reporting)")]
[JsonProperty("thermal_comfort_model_2_type")]
public EmptyNoYes ThermalComfortModel2Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

[Description("optional (third thermal comfort model and report type)")]
[JsonProperty("thermal_comfort_model_3_type")]
public EmptyNoYes ThermalComfortModel3Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

[Description("optional (fourth thermal comfort model and report type)")]
[JsonProperty("thermal_comfort_model_4_type")]
public EmptyNoYes ThermalComfortModel4Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

[Description("optional (fifth thermal comfort model and report type)")]
[JsonProperty("thermal_comfort_model_5_type")]
public EmptyNoYes ThermalComfortModel5Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

[Description("optional (sixth thermal comfort model and report type)")]
[JsonProperty("thermal_comfort_model_6_type")]
public EmptyNoYes ThermalComfortModel6Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

[Description("optional (seventh thermal comfort model and report type)")]
[JsonProperty("thermal_comfort_model_7_type")]
public EmptyNoYes ThermalComfortModel7Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

[Description("units in the schedule are m/s this is the schedule of the air speed at the 0.1 m " +
    "above the floor optional (only required for runs of thermal comfort models Ankle" +
    "DraftASH55)")]
[JsonProperty("ankle_level_air_velocity_schedule_name")]
public string AnkleLevelAirVelocityScheduleName { get; set; } = "";
    }
}
