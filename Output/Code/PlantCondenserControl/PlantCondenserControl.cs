namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
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
    
    
    [Description(@"List plant equipment in order of operating priority, 1st in list will be used 1st, etc Use only plant equipment in this list. If no equipment object types and equipment names are specified, then the corresponding PlantEquipmentOperation:* object will assume all available plant equipment for the loop should be OFF (not operate) within the specified lower/upper limit.")]
    public class PlantEquipmentList : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("equipment")]
public string Equipment { get; set; } = "";
    }
    
    [Description(@"List condenser equipment in order of operating priority, 1st in list will be used 1st, etc Use only condenser equipment in this list. If no equipment object types and equipment names are specified, then the corresponding PlantEquipmentOperation:* object will assume all available condenser equipment for the loop should be OFF (not operate) within the specified lower/upper limit.")]
    public class CondenserEquipmentList : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("equipment")]
public string Equipment { get; set; } = "";
    }
    
    [Description("Plant equipment operation scheme for uncontrolled operation. Specifies a group of" +
        " equipment that runs if the loop is active, unless turned off by the loop flow r" +
        "esolver to maintain continuity in the fluid loop.")]
    public class PlantEquipmentOperation_Uncontrolled : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("equipment_list_name")]
public string EquipmentListName { get; set; } = "";
    }
    
    [Description("Plant equipment operation scheme for cooling load range operation. Specifies one " +
        "or more groups of equipment which are available to operate for successive coolin" +
        "g load ranges.")]
    public class PlantEquipmentOperation_CoolingLoad : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("load_range_1_lower_limit")]
public System.Nullable<float> LoadRange1LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_1_upper_limit")]
public System.Nullable<float> LoadRange1UpperLimit { get; set; } = null;
        

[JsonProperty("range_1_equipment_list_name")]
public string Range1EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_2_lower_limit")]
public System.Nullable<float> LoadRange2LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_2_upper_limit")]
public System.Nullable<float> LoadRange2UpperLimit { get; set; } = null;
        

[JsonProperty("range_2_equipment_list_name")]
public string Range2EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_3_lower_limit")]
public System.Nullable<float> LoadRange3LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_3_upper_limit")]
public System.Nullable<float> LoadRange3UpperLimit { get; set; } = null;
        

[JsonProperty("range_3_equipment_list_name")]
public string Range3EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_4_lower_limit")]
public System.Nullable<float> LoadRange4LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_4_upper_limit")]
public System.Nullable<float> LoadRange4UpperLimit { get; set; } = null;
        

[JsonProperty("range_4_equipment_list_name")]
public string Range4EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_5_lower_limit")]
public System.Nullable<float> LoadRange5LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_5_upper_limit")]
public System.Nullable<float> LoadRange5UpperLimit { get; set; } = null;
        

[JsonProperty("range_5_equipment_list_name")]
public string Range5EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_6_lower_limit")]
public System.Nullable<float> LoadRange6LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_6_upper_limit")]
public System.Nullable<float> LoadRange6UpperLimit { get; set; } = null;
        

[JsonProperty("range_6_equipment_list_name")]
public string Range6EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_7_lower_limit")]
public System.Nullable<float> LoadRange7LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_7_upper_limit")]
public System.Nullable<float> LoadRange7UpperLimit { get; set; } = null;
        

[JsonProperty("range_7_equipment_list_name")]
public string Range7EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_8_lower_limit")]
public System.Nullable<float> LoadRange8LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_8_upper_limit")]
public System.Nullable<float> LoadRange8UpperLimit { get; set; } = null;
        

[JsonProperty("range_8_equipment_list_name")]
public string Range8EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_9_lower_limit")]
public System.Nullable<float> LoadRange9LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_9_upper_limit")]
public System.Nullable<float> LoadRange9UpperLimit { get; set; } = null;
        

[JsonProperty("range_9_equipment_list_name")]
public string Range9EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_10_lower_limit")]
public System.Nullable<float> LoadRange10LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_10_upper_limit")]
public System.Nullable<float> LoadRange10UpperLimit { get; set; } = null;
        

[JsonProperty("range_10_equipment_list_name")]
public string Range10EquipmentListName { get; set; } = "";
    }
    
    [Description("Plant equipment operation scheme for heating load range operation. Specifies one " +
        "or more groups of equipment which are available to operate for successive heatin" +
        "g load ranges.")]
    public class PlantEquipmentOperation_HeatingLoad : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("load_range_1_lower_limit")]
public System.Nullable<float> LoadRange1LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_1_upper_limit")]
public System.Nullable<float> LoadRange1UpperLimit { get; set; } = null;
        

[JsonProperty("range_1_equipment_list_name")]
public string Range1EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_2_lower_limit")]
public System.Nullable<float> LoadRange2LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_2_upper_limit")]
public System.Nullable<float> LoadRange2UpperLimit { get; set; } = null;
        

[JsonProperty("range_2_equipment_list_name")]
public string Range2EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_3_lower_limit")]
public System.Nullable<float> LoadRange3LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_3_upper_limit")]
public System.Nullable<float> LoadRange3UpperLimit { get; set; } = null;
        

[JsonProperty("range_3_equipment_list_name")]
public string Range3EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_4_lower_limit")]
public System.Nullable<float> LoadRange4LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_4_upper_limit")]
public System.Nullable<float> LoadRange4UpperLimit { get; set; } = null;
        

[JsonProperty("range_4_equipment_list_name")]
public string Range4EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_5_lower_limit")]
public System.Nullable<float> LoadRange5LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_5_upper_limit")]
public System.Nullable<float> LoadRange5UpperLimit { get; set; } = null;
        

[JsonProperty("range_5_equipment_list_name")]
public string Range5EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_6_lower_limit")]
public System.Nullable<float> LoadRange6LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_6_upper_limit")]
public System.Nullable<float> LoadRange6UpperLimit { get; set; } = null;
        

[JsonProperty("range_6_equipment_list_name")]
public string Range6EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_7_lower_limit")]
public System.Nullable<float> LoadRange7LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_7_upper_limit")]
public System.Nullable<float> LoadRange7UpperLimit { get; set; } = null;
        

[JsonProperty("range_7_equipment_list_name")]
public string Range7EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_8_lower_limit")]
public System.Nullable<float> LoadRange8LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_8_upper_limit")]
public System.Nullable<float> LoadRange8UpperLimit { get; set; } = null;
        

[JsonProperty("range_8_equipment_list_name")]
public string Range8EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_9_lower_limit")]
public System.Nullable<float> LoadRange9LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_9_upper_limit")]
public System.Nullable<float> LoadRange9UpperLimit { get; set; } = null;
        

[JsonProperty("range_9_equipment_list_name")]
public string Range9EquipmentListName { get; set; } = "";
        

[JsonProperty("load_range_10_lower_limit")]
public System.Nullable<float> LoadRange10LowerLimit { get; set; } = null;
        

[JsonProperty("load_range_10_upper_limit")]
public System.Nullable<float> LoadRange10UpperLimit { get; set; } = null;
        

[JsonProperty("range_10_equipment_list_name")]
public string Range10EquipmentListName { get; set; } = "";
    }
    
    [Description("Plant equipment operation scheme for outdoor dry-bulb temperature range operation" +
        ". Specifies one or more groups of equipment which are available to operate for s" +
        "uccessive outdoor dry-bulb temperature ranges.")]
    public class PlantEquipmentOperation_OutdoorDryBulb : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("dry_bulb_temperature_range_1_lower_limit")]
public System.Nullable<float> DryBulbTemperatureRange1LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_range_1_upper_limit")]
public System.Nullable<float> DryBulbTemperatureRange1UpperLimit { get; set; } = null;
        

[JsonProperty("range_1_equipment_list_name")]
public string Range1EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_range_2_lower_limit")]
public System.Nullable<float> DryBulbTemperatureRange2LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_range_2_upper_limit")]
public System.Nullable<float> DryBulbTemperatureRange2UpperLimit { get; set; } = null;
        

[JsonProperty("range_2_equipment_list_name")]
public string Range2EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_range_3_lower_limit")]
public System.Nullable<float> DryBulbTemperatureRange3LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_range_3_upper_limit")]
public System.Nullable<float> DryBulbTemperatureRange3UpperLimit { get; set; } = null;
        

[JsonProperty("range_3_equipment_list_name")]
public string Range3EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_range_4_lower_limit")]
public System.Nullable<float> DryBulbTemperatureRange4LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_range_4_upper_limit")]
public System.Nullable<float> DryBulbTemperatureRange4UpperLimit { get; set; } = null;
        

[JsonProperty("range_4_equipment_list_name")]
public string Range4EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_range_5_lower_limit")]
public System.Nullable<float> DryBulbTemperatureRange5LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_range_5_upper_limit")]
public System.Nullable<float> DryBulbTemperatureRange5UpperLimit { get; set; } = null;
        

[JsonProperty("range_5_equipment_list_name")]
public string Range5EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_range_6_lower_limit")]
public System.Nullable<float> DryBulbTemperatureRange6LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_range_6_upper_limit")]
public System.Nullable<float> DryBulbTemperatureRange6UpperLimit { get; set; } = null;
        

[JsonProperty("range_6_equipment_list_name")]
public string Range6EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_range_7_lower_limit")]
public System.Nullable<float> DryBulbTemperatureRange7LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_range_7_upper_limit")]
public System.Nullable<float> DryBulbTemperatureRange7UpperLimit { get; set; } = null;
        

[JsonProperty("range_7_equipment_list_name")]
public string Range7EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_range_8_lower_limit")]
public System.Nullable<float> DryBulbTemperatureRange8LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_range_8_upper_limit")]
public System.Nullable<float> DryBulbTemperatureRange8UpperLimit { get; set; } = null;
        

[JsonProperty("range_8_equipment_list_name")]
public string Range8EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_range_9_lower_limit")]
public System.Nullable<float> DryBulbTemperatureRange9LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_range_9_upper_limit")]
public System.Nullable<float> DryBulbTemperatureRange9UpperLimit { get; set; } = null;
        

[JsonProperty("range_9_equipment_list_name")]
public string Range9EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_range_10_lower_limit")]
public System.Nullable<float> DryBulbTemperatureRange10LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_range_10_upper_limit")]
public System.Nullable<float> DryBulbTemperatureRange10UpperLimit { get; set; } = null;
        

[JsonProperty("range_10_equipment_list_name")]
public string Range10EquipmentListName { get; set; } = "";
    }
    
    [Description("Plant equipment operation scheme for outdoor wet-bulb temperature range operation" +
        ". Specifies one or more groups of equipment which are available to operate for s" +
        "uccessive outdoor wet-bulb temperature ranges.")]
    public class PlantEquipmentOperation_OutdoorWetBulb : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("wet_bulb_temperature_range_1_lower_limit")]
public System.Nullable<float> WetBulbTemperatureRange1LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_range_1_upper_limit")]
public System.Nullable<float> WetBulbTemperatureRange1UpperLimit { get; set; } = null;
        

[JsonProperty("range_1_equipment_list_name")]
public string Range1EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_range_2_lower_limit")]
public System.Nullable<float> WetBulbTemperatureRange2LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_range_2_upper_limit")]
public System.Nullable<float> WetBulbTemperatureRange2UpperLimit { get; set; } = null;
        

[JsonProperty("range_2_equipment_list_name")]
public string Range2EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_range_3_lower_limit")]
public System.Nullable<float> WetBulbTemperatureRange3LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_range_3_upper_limit")]
public System.Nullable<float> WetBulbTemperatureRange3UpperLimit { get; set; } = null;
        

[JsonProperty("range_3_equipment_list_name")]
public string Range3EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_range_4_lower_limit")]
public System.Nullable<float> WetBulbTemperatureRange4LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_range_4_upper_limit")]
public System.Nullable<float> WetBulbTemperatureRange4UpperLimit { get; set; } = null;
        

[JsonProperty("range_4_equipment_list_name")]
public string Range4EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_range_5_lower_limit")]
public System.Nullable<float> WetBulbTemperatureRange5LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_range_5_upper_limit")]
public System.Nullable<float> WetBulbTemperatureRange5UpperLimit { get; set; } = null;
        

[JsonProperty("range_5_equipment_list_name")]
public string Range5EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_range_6_lower_limit")]
public System.Nullable<float> WetBulbTemperatureRange6LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_range_6_upper_limit")]
public System.Nullable<float> WetBulbTemperatureRange6UpperLimit { get; set; } = null;
        

[JsonProperty("range_6_equipment_list_name")]
public string Range6EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_range_7_lower_limit")]
public System.Nullable<float> WetBulbTemperatureRange7LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_range_7_upper_limit")]
public System.Nullable<float> WetBulbTemperatureRange7UpperLimit { get; set; } = null;
        

[JsonProperty("range_7_equipment_list_name")]
public string Range7EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_range_8_lower_limit")]
public System.Nullable<float> WetBulbTemperatureRange8LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_range_8_upper_limit")]
public System.Nullable<float> WetBulbTemperatureRange8UpperLimit { get; set; } = null;
        

[JsonProperty("range_8_equipment_list_name")]
public string Range8EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_range_9_lower_limit")]
public System.Nullable<float> WetBulbTemperatureRange9LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_range_9_upper_limit")]
public System.Nullable<float> WetBulbTemperatureRange9UpperLimit { get; set; } = null;
        

[JsonProperty("range_9_equipment_list_name")]
public string Range9EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_range_10_lower_limit")]
public System.Nullable<float> WetBulbTemperatureRange10LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_range_10_upper_limit")]
public System.Nullable<float> WetBulbTemperatureRange10UpperLimit { get; set; } = null;
        

[JsonProperty("range_10_equipment_list_name")]
public string Range10EquipmentListName { get; set; } = "";
    }
    
    [Description("Plant equipment operation scheme for outdoor relative humidity range operation. S" +
        "pecifies one or more groups of equipment which are available to operate for succ" +
        "essive outdoor relative humidity ranges.")]
    public class PlantEquipmentOperation_OutdoorRelativeHumidity : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("relative_humidity_range_1_lower_limit")]
public System.Nullable<float> RelativeHumidityRange1LowerLimit { get; set; } = null;
        

[JsonProperty("relative_humidity_range_1_upper_limit")]
public System.Nullable<float> RelativeHumidityRange1UpperLimit { get; set; } = null;
        

[JsonProperty("range_1_equipment_list_name")]
public string Range1EquipmentListName { get; set; } = "";
        

[JsonProperty("relative_humidity_range_2_lower_limit")]
public System.Nullable<float> RelativeHumidityRange2LowerLimit { get; set; } = null;
        

[JsonProperty("relative_humidity_range_2_upper_limit")]
public System.Nullable<float> RelativeHumidityRange2UpperLimit { get; set; } = null;
        

[JsonProperty("range_2_equipment_list_name")]
public string Range2EquipmentListName { get; set; } = "";
        

[JsonProperty("relative_humidity_range_3_lower_limit")]
public System.Nullable<float> RelativeHumidityRange3LowerLimit { get; set; } = null;
        

[JsonProperty("relative_humidity_range_3_upper_limit")]
public System.Nullable<float> RelativeHumidityRange3UpperLimit { get; set; } = null;
        

[JsonProperty("range_3_equipment_list_name")]
public string Range3EquipmentListName { get; set; } = "";
        

[JsonProperty("relative_humidity_range_4_lower_limit")]
public System.Nullable<float> RelativeHumidityRange4LowerLimit { get; set; } = null;
        

[JsonProperty("relative_humidity_range_4_upper_limit")]
public System.Nullable<float> RelativeHumidityRange4UpperLimit { get; set; } = null;
        

[JsonProperty("range_4_equipment_list_name")]
public string Range4EquipmentListName { get; set; } = "";
        

[JsonProperty("relative_humidity_range_5_lower_limit")]
public System.Nullable<float> RelativeHumidityRange5LowerLimit { get; set; } = null;
        

[JsonProperty("relative_humidity_range_5_upper_limit")]
public System.Nullable<float> RelativeHumidityRange5UpperLimit { get; set; } = null;
        

[JsonProperty("range_5_equipment_list_name")]
public string Range5EquipmentListName { get; set; } = "";
        

[JsonProperty("relative_humidity_range_6_lower_limit")]
public System.Nullable<float> RelativeHumidityRange6LowerLimit { get; set; } = null;
        

[JsonProperty("relative_humidity_range_6_upper_limit")]
public System.Nullable<float> RelativeHumidityRange6UpperLimit { get; set; } = null;
        

[JsonProperty("range_6_equipment_list_name")]
public string Range6EquipmentListName { get; set; } = "";
        

[JsonProperty("relative_humidity_range_7_lower_limit")]
public System.Nullable<float> RelativeHumidityRange7LowerLimit { get; set; } = null;
        

[JsonProperty("relative_humidity_range_7_upper_limit")]
public System.Nullable<float> RelativeHumidityRange7UpperLimit { get; set; } = null;
        

[JsonProperty("range_7_equipment_list_name")]
public string Range7EquipmentListName { get; set; } = "";
        

[JsonProperty("relative_humidity_range_8_lower_limit")]
public System.Nullable<float> RelativeHumidityRange8LowerLimit { get; set; } = null;
        

[JsonProperty("relative_humidity_range_8_upper_limit")]
public System.Nullable<float> RelativeHumidityRange8UpperLimit { get; set; } = null;
        

[JsonProperty("range_8_equipment_list_name")]
public string Range8EquipmentListName { get; set; } = "";
        

[JsonProperty("relative_humidity_range_9_lower_limit")]
public System.Nullable<float> RelativeHumidityRange9LowerLimit { get; set; } = null;
        

[JsonProperty("relative_humidity_range_9_upper_limit")]
public System.Nullable<float> RelativeHumidityRange9UpperLimit { get; set; } = null;
        

[JsonProperty("range_9_equipment_list_name")]
public string Range9EquipmentListName { get; set; } = "";
        

[JsonProperty("relative_humidity_range_10_lower_limit")]
public System.Nullable<float> RelativeHumidityRange10LowerLimit { get; set; } = null;
        

[JsonProperty("relative_humidity_range_10_upper_limit")]
public System.Nullable<float> RelativeHumidityRange10UpperLimit { get; set; } = null;
        

[JsonProperty("range_10_equipment_list_name")]
public string Range10EquipmentListName { get; set; } = "";
    }
    
    [Description("Plant equipment operation scheme for outdoor dewpoint temperature range operation" +
        ". Specifies one or more groups of equipment which are available to operate for s" +
        "uccessive outdoor dewpoint temperature ranges.")]
    public class PlantEquipmentOperation_OutdoorDewpoint : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("dewpoint_temperature_range_1_lower_limit")]
public System.Nullable<float> DewpointTemperatureRange1LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_range_1_upper_limit")]
public System.Nullable<float> DewpointTemperatureRange1UpperLimit { get; set; } = null;
        

[JsonProperty("range_1_equipment_list_name")]
public string Range1EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_range_2_lower_limit")]
public System.Nullable<float> DewpointTemperatureRange2LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_range_2_upper_limit")]
public System.Nullable<float> DewpointTemperatureRange2UpperLimit { get; set; } = null;
        

[JsonProperty("range_2_equipment_list_name")]
public string Range2EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_range_3_lower_limit")]
public System.Nullable<float> DewpointTemperatureRange3LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_range_3_upper_limit")]
public System.Nullable<float> DewpointTemperatureRange3UpperLimit { get; set; } = null;
        

[JsonProperty("range_3_equipment_list_name")]
public string Range3EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_range_4_lower_limit")]
public System.Nullable<float> DewpointTemperatureRange4LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_range_4_upper_limit")]
public System.Nullable<float> DewpointTemperatureRange4UpperLimit { get; set; } = null;
        

[JsonProperty("range_4_equipment_list_name")]
public string Range4EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_range_5_lower_limit")]
public System.Nullable<float> DewpointTemperatureRange5LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_range_5_upper_limit")]
public System.Nullable<float> DewpointTemperatureRange5UpperLimit { get; set; } = null;
        

[JsonProperty("range_5_equipment_list_name")]
public string Range5EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_range_6_lower_limit")]
public System.Nullable<float> DewpointTemperatureRange6LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_range_6_upper_limit")]
public System.Nullable<float> DewpointTemperatureRange6UpperLimit { get; set; } = null;
        

[JsonProperty("range_6_equipment_list_name")]
public string Range6EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_range_7_lower_limit")]
public System.Nullable<float> DewpointTemperatureRange7LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_range_7_upper_limit")]
public System.Nullable<float> DewpointTemperatureRange7UpperLimit { get; set; } = null;
        

[JsonProperty("range_7_equipment_list_name")]
public string Range7EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_range_8_lower_limit")]
public System.Nullable<float> DewpointTemperatureRange8LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_range_8_upper_limit")]
public System.Nullable<float> DewpointTemperatureRange8UpperLimit { get; set; } = null;
        

[JsonProperty("range_8_equipment_list_name")]
public string Range8EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_range_9_lower_limit")]
public System.Nullable<float> DewpointTemperatureRange9LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_range_9_upper_limit")]
public System.Nullable<float> DewpointTemperatureRange9UpperLimit { get; set; } = null;
        

[JsonProperty("range_9_equipment_list_name")]
public string Range9EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_range_10_lower_limit")]
public System.Nullable<float> DewpointTemperatureRange10LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_range_10_upper_limit")]
public System.Nullable<float> DewpointTemperatureRange10UpperLimit { get; set; } = null;
        

[JsonProperty("range_10_equipment_list_name")]
public string Range10EquipmentListName { get; set; } = "";
    }
    
    [Description("Plant equipment operation scheme for component setpoint operation. Specifies one " +
        "or pieces of equipment which are controlled to meet the temperature setpoint at " +
        "the component outlet node.")]
    public class PlantEquipmentOperation_ComponentSetpoint : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("equipment_1_object_type")]
public string Equipment1ObjectType { get; set; } = "";
        

[JsonProperty("equipment_1_name")]
public string Equipment1Name { get; set; } = "";
        

[JsonProperty("demand_calculation_1_node_name")]
public string DemandCalculation1NodeName { get; set; } = "";
        

[JsonProperty("setpoint_1_node_name")]
public string Setpoint1NodeName { get; set; } = "";
        

[JsonProperty("component_1_flow_rate")]
public string Component1FlowRate { get; set; } = "";
        

[JsonProperty("operation_1_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ComponentSetpoint_Operation1Type Operation1Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation1Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation1Type), "Cooling");
        

[JsonProperty("equipment_2_object_type")]
public string Equipment2ObjectType { get; set; } = "";
        

[JsonProperty("equipment_2_name")]
public string Equipment2Name { get; set; } = "";
        

[JsonProperty("demand_calculation_2_node_name")]
public string DemandCalculation2NodeName { get; set; } = "";
        

[JsonProperty("setpoint_2_node_name")]
public string Setpoint2NodeName { get; set; } = "";
        

[JsonProperty("component_2_flow_rate")]
public string Component2FlowRate { get; set; } = "";
        

[JsonProperty("operation_2_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ComponentSetpoint_Operation2Type Operation2Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation2Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation2Type), "Cooling");
        

[JsonProperty("equipment_3_object_type")]
public string Equipment3ObjectType { get; set; } = "";
        

[JsonProperty("equipment_3_name")]
public string Equipment3Name { get; set; } = "";
        

[JsonProperty("demand_calculation_3_node_name")]
public string DemandCalculation3NodeName { get; set; } = "";
        

[JsonProperty("setpoint_3_node_name")]
public string Setpoint3NodeName { get; set; } = "";
        

[JsonProperty("component_3_flow_rate")]
public string Component3FlowRate { get; set; } = "";
        

[JsonProperty("operation_3_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ComponentSetpoint_Operation3Type Operation3Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation3Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation3Type), "Cooling");
        

[JsonProperty("equipment_4_object_type")]
public string Equipment4ObjectType { get; set; } = "";
        

[JsonProperty("equipment_4_name")]
public string Equipment4Name { get; set; } = "";
        

[JsonProperty("demand_calculation_4_node_name")]
public string DemandCalculation4NodeName { get; set; } = "";
        

[JsonProperty("setpoint_4_node_name")]
public string Setpoint4NodeName { get; set; } = "";
        

[JsonProperty("component_4_flow_rate")]
public string Component4FlowRate { get; set; } = "";
        

[JsonProperty("operation_4_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ComponentSetpoint_Operation4Type Operation4Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation4Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation4Type), "Cooling");
        

[JsonProperty("equipment_5_object_type")]
public string Equipment5ObjectType { get; set; } = "";
        

[JsonProperty("equipment_5_name")]
public string Equipment5Name { get; set; } = "";
        

[JsonProperty("demand_calculation_5_node_name")]
public string DemandCalculation5NodeName { get; set; } = "";
        

[JsonProperty("setpoint_5_node_name")]
public string Setpoint5NodeName { get; set; } = "";
        

[JsonProperty("component_5_flow_rate")]
public string Component5FlowRate { get; set; } = "";
        

[JsonProperty("operation_5_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ComponentSetpoint_Operation5Type Operation5Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation5Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation5Type), "Cooling");
        

[JsonProperty("equipment_6_object_type")]
public string Equipment6ObjectType { get; set; } = "";
        

[JsonProperty("equipment_6_name")]
public string Equipment6Name { get; set; } = "";
        

[JsonProperty("demand_calculation_6_node_name")]
public string DemandCalculation6NodeName { get; set; } = "";
        

[JsonProperty("setpoint_6_node_name")]
public string Setpoint6NodeName { get; set; } = "";
        

[JsonProperty("component_6_flow_rate")]
public string Component6FlowRate { get; set; } = "";
        

[JsonProperty("operation_6_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ComponentSetpoint_Operation6Type Operation6Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation6Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation6Type), "Cooling");
        

[JsonProperty("equipment_7_object_type")]
public string Equipment7ObjectType { get; set; } = "";
        

[JsonProperty("equipment_7_name")]
public string Equipment7Name { get; set; } = "";
        

[JsonProperty("demand_calculation_7_node_name")]
public string DemandCalculation7NodeName { get; set; } = "";
        

[JsonProperty("setpoint_7_node_name")]
public string Setpoint7NodeName { get; set; } = "";
        

[JsonProperty("component_7_flow_rate")]
public string Component7FlowRate { get; set; } = "";
        

[JsonProperty("operation_7_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ComponentSetpoint_Operation7Type Operation7Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation7Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation7Type), "Cooling");
        

[JsonProperty("equipment_8_object_type")]
public string Equipment8ObjectType { get; set; } = "";
        

[JsonProperty("equipment_8_name")]
public string Equipment8Name { get; set; } = "";
        

[JsonProperty("demand_calculation_8_node_name")]
public string DemandCalculation8NodeName { get; set; } = "";
        

[JsonProperty("setpoint_8_node_name")]
public string Setpoint8NodeName { get; set; } = "";
        

[JsonProperty("component_8_flow_rate")]
public string Component8FlowRate { get; set; } = "";
        

[JsonProperty("operation_8_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ComponentSetpoint_Operation8Type Operation8Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation8Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation8Type), "Cooling");
        

[JsonProperty("equipment_9_object_type")]
public string Equipment9ObjectType { get; set; } = "";
        

[JsonProperty("equipment_9_name")]
public string Equipment9Name { get; set; } = "";
        

[JsonProperty("demand_calculation_9_node_name")]
public string DemandCalculation9NodeName { get; set; } = "";
        

[JsonProperty("setpoint_9_node_name")]
public string Setpoint9NodeName { get; set; } = "";
        

[JsonProperty("component_9_flow_rate")]
public string Component9FlowRate { get; set; } = "";
        

[JsonProperty("operation_9_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ComponentSetpoint_Operation9Type Operation9Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation9Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation9Type), "Cooling");
        

[JsonProperty("equipment_10_object_type")]
public string Equipment10ObjectType { get; set; } = "";
        

[JsonProperty("equipment_10_name")]
public string Equipment10Name { get; set; } = "";
        

[JsonProperty("demand_calculation_10_node_name")]
public string DemandCalculation10NodeName { get; set; } = "";
        

[JsonProperty("setpoint_10_node_name")]
public string Setpoint10NodeName { get; set; } = "";
        

[JsonProperty("component_10_flow_rate")]
public string Component10FlowRate { get; set; } = "";
        

[JsonProperty("operation_10_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ComponentSetpoint_Operation10Type Operation10Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation10Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation10Type), "Cooling");
    }
    
    public enum PlantEquipmentOperation_ComponentSetpoint_Operation1Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ComponentSetpoint_Operation2Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ComponentSetpoint_Operation3Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ComponentSetpoint_Operation4Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ComponentSetpoint_Operation5Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ComponentSetpoint_Operation6Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ComponentSetpoint_Operation7Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ComponentSetpoint_Operation8Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ComponentSetpoint_Operation9Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ComponentSetpoint_Operation10Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    [Description("Plant equipment operation scheme for simpler input to control thermal (ice) energ" +
        "y storage systems. It replaces a host of setpoint managers with simple, single i" +
        "nput values. For more complex controls, use the ComponentSetpoint scheme.")]
    public class PlantEquipmentOperation_ThermalEnergyStorage : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("on_peak_schedule")]
public string OnPeakSchedule { get; set; } = "";
        

[JsonProperty("charging_availability_schedule")]
public string ChargingAvailabilitySchedule { get; set; } = "";
        

[Description("Single temperature for chiller outlet when not in cooling season or during on-pea" +
    "k cooling (discharge)")]
[JsonProperty("non_charging_chilled_water_temperature")]
public System.Nullable<float> NonChargingChilledWaterTemperature { get; set; } = null;
        

[Description("Single temperature for chiller outlet when off-peak during cooling season (chargi" +
    "ng)")]
[JsonProperty("charging_chilled_water_temperature")]
public System.Nullable<float> ChargingChilledWaterTemperature { get; set; } = null;
        

[Description("This field is the type of object and should either be a chiller or some ice stora" +
    "ge equipment.")]
[JsonProperty("component_1_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component1ObjectType Component1ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component1ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component1ObjectType), "ChillerAbsorption");
        

[Description("This field is the name of either the chiller or ice storage equipment on the loop" +
    ".")]
[JsonProperty("component_1_name")]
public string Component1Name { get; set; } = "";
        

[Description("This field is the name of the inlet node for the component defined in the two pre" +
    "vious input fields.")]
[JsonProperty("component_1_demand_calculation_node_name")]
public string Component1DemandCalculationNodeName { get; set; } = "";
        

[Description("This field is the name of the outlet node for the component listed above.")]
[JsonProperty("component_1_setpoint_node_name")]
public string Component1SetpointNodeName { get; set; } = "";
        

[Description("This field is the flow rate for the component listed above.")]
[JsonProperty("component_1_flow_rate")]
public string Component1FlowRate { get; set; } = "";
        

[Description("This field is the operation type for the component listed above. For this plant e" +
    "quipment operation scheme, \"Cooling\" should be selected for chiller equipment wh" +
    "ile ice storage equipment should be defined as \"Dual\".")]
[JsonProperty("component_1_operation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component1OperationType Component1OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component1OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component1OperationType), "Cooling");
        

[JsonProperty("component_2_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component2ObjectType Component2ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component2ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component2ObjectType), "ChillerAbsorption");
        

[JsonProperty("component_2_name")]
public string Component2Name { get; set; } = "";
        

[JsonProperty("component_2_demand_calculation_node_name")]
public string Component2DemandCalculationNodeName { get; set; } = "";
        

[JsonProperty("component_2_setpoint_node_name")]
public string Component2SetpointNodeName { get; set; } = "";
        

[JsonProperty("component_2_flow_rate")]
public string Component2FlowRate { get; set; } = "";
        

[JsonProperty("component_2_operation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component2OperationType Component2OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component2OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component2OperationType), "Cooling");
        

[JsonProperty("component_3_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component3ObjectType Component3ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component3ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component3ObjectType), "ChillerAbsorption");
        

[JsonProperty("component_3_name")]
public string Component3Name { get; set; } = "";
        

[JsonProperty("component_3_demand_calculation_node_name")]
public string Component3DemandCalculationNodeName { get; set; } = "";
        

[JsonProperty("component_3_setpoint_node_name")]
public string Component3SetpointNodeName { get; set; } = "";
        

[JsonProperty("component_3_flow_rate")]
public string Component3FlowRate { get; set; } = "";
        

[JsonProperty("component_3_operation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component3OperationType Component3OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component3OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component3OperationType), "Cooling");
        

[JsonProperty("component_4_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component4ObjectType Component4ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component4ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component4ObjectType), "ChillerAbsorption");
        

[JsonProperty("component_4_name")]
public string Component4Name { get; set; } = "";
        

[JsonProperty("component_4_demand_calculation_node_name")]
public string Component4DemandCalculationNodeName { get; set; } = "";
        

[JsonProperty("component_4_setpoint_node_name")]
public string Component4SetpointNodeName { get; set; } = "";
        

[JsonProperty("component_4_flow_rate")]
public string Component4FlowRate { get; set; } = "";
        

[JsonProperty("component_4_operation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component4OperationType Component4OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component4OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component4OperationType), "Cooling");
        

[JsonProperty("component_5_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component5ObjectType Component5ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component5ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component5ObjectType), "ChillerAbsorption");
        

[JsonProperty("component_5_name")]
public string Component5Name { get; set; } = "";
        

[JsonProperty("component_5_demand_calculation_node_name")]
public string Component5DemandCalculationNodeName { get; set; } = "";
        

[JsonProperty("component_5_setpoint_node_name")]
public string Component5SetpointNodeName { get; set; } = "";
        

[JsonProperty("component_5_flow_rate")]
public string Component5FlowRate { get; set; } = "";
        

[JsonProperty("component_5_operation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component5OperationType Component5OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component5OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component5OperationType), "Cooling");
        

[JsonProperty("component_6_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component6ObjectType Component6ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component6ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component6ObjectType), "ChillerAbsorption");
        

[JsonProperty("component_6_name")]
public string Component6Name { get; set; } = "";
        

[JsonProperty("component_6_demand_calculation_node_name")]
public string Component6DemandCalculationNodeName { get; set; } = "";
        

[JsonProperty("component_6_setpoint_node_name")]
public string Component6SetpointNodeName { get; set; } = "";
        

[JsonProperty("component_6_flow_rate")]
public string Component6FlowRate { get; set; } = "";
        

[JsonProperty("component_6_operation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component6OperationType Component6OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component6OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component6OperationType), "Cooling");
        

[JsonProperty("component_7_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component7ObjectType Component7ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component7ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component7ObjectType), "ChillerAbsorption");
        

[JsonProperty("component_7_name")]
public string Component7Name { get; set; } = "";
        

[JsonProperty("component_7_demand_calculation_node_name")]
public string Component7DemandCalculationNodeName { get; set; } = "";
        

[JsonProperty("component_7_setpoint_node_name")]
public string Component7SetpointNodeName { get; set; } = "";
        

[JsonProperty("component_7_flow_rate")]
public string Component7FlowRate { get; set; } = "";
        

[JsonProperty("component_7_operation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component7OperationType Component7OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component7OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component7OperationType), "Cooling");
        

[JsonProperty("component_8_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component8ObjectType Component8ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component8ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component8ObjectType), "ChillerAbsorption");
        

[JsonProperty("component_8_name")]
public string Component8Name { get; set; } = "";
        

[JsonProperty("component_8_demand_calculation_node_name")]
public string Component8DemandCalculationNodeName { get; set; } = "";
        

[JsonProperty("component_8_setpoint_node_name")]
public string Component8SetpointNodeName { get; set; } = "";
        

[JsonProperty("component_8_flow_rate")]
public string Component8FlowRate { get; set; } = "";
        

[JsonProperty("component_8_operation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component8OperationType Component8OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component8OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component8OperationType), "Cooling");
        

[JsonProperty("component_9_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component9ObjectType Component9ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component9ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component9ObjectType), "ChillerAbsorption");
        

[JsonProperty("component_9_name")]
public string Component9Name { get; set; } = "";
        

[JsonProperty("component_9_demand_calculation_node_name")]
public string Component9DemandCalculationNodeName { get; set; } = "";
        

[JsonProperty("component_9_setpoint_node_name")]
public string Component9SetpointNodeName { get; set; } = "";
        

[JsonProperty("component_9_flow_rate")]
public string Component9FlowRate { get; set; } = "";
        

[JsonProperty("component_9_operation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component9OperationType Component9OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component9OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component9OperationType), "Cooling");
        

[JsonProperty("component_10_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component10ObjectType Component10ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component10ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component10ObjectType), "ChillerAbsorption");
        

[JsonProperty("component_10_name")]
public string Component10Name { get; set; } = "";
        

[JsonProperty("component_10_demand_calculation_node_name")]
public string Component10DemandCalculationNodeName { get; set; } = "";
        

[JsonProperty("component_10_setpoint_node_name")]
public string Component10SetpointNodeName { get; set; } = "";
        

[JsonProperty("component_10_flow_rate")]
public string Component10FlowRate { get; set; } = "";
        

[JsonProperty("component_10_operation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperation_ThermalEnergyStorage_Component10OperationType Component10OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component10OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component10OperationType), "Cooling");
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component1ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric")]
        ChillerElectric = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Detailed")]
        ThermalStorageIceDetailed = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Simple")]
        ThermalStorageIceSimple = 9,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component1OperationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component2ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric")]
        ChillerElectric = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Detailed")]
        ThermalStorageIceDetailed = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Simple")]
        ThermalStorageIceSimple = 9,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component2OperationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component3ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric")]
        ChillerElectric = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Detailed")]
        ThermalStorageIceDetailed = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Simple")]
        ThermalStorageIceSimple = 9,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component3OperationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component4ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric")]
        ChillerElectric = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Detailed")]
        ThermalStorageIceDetailed = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Simple")]
        ThermalStorageIceSimple = 9,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component4OperationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component5ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric")]
        ChillerElectric = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Detailed")]
        ThermalStorageIceDetailed = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Simple")]
        ThermalStorageIceSimple = 9,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component5OperationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component6ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric")]
        ChillerElectric = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Detailed")]
        ThermalStorageIceDetailed = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Simple")]
        ThermalStorageIceSimple = 9,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component6OperationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component7ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric")]
        ChillerElectric = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Detailed")]
        ThermalStorageIceDetailed = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Simple")]
        ThermalStorageIceSimple = 9,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component7OperationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component8ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric")]
        ChillerElectric = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Detailed")]
        ThermalStorageIceDetailed = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Simple")]
        ThermalStorageIceSimple = 9,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component8OperationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component9ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric")]
        ChillerElectric = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Detailed")]
        ThermalStorageIceDetailed = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Simple")]
        ThermalStorageIceSimple = 9,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component9OperationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component10ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric")]
        ChillerElectric = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Detailed")]
        ThermalStorageIceDetailed = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermalStorage:Ice:Simple")]
        ThermalStorageIceSimple = 9,
    }
    
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component10OperationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dual")]
        Dual = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
    }
    
    [Description(@"Plant equipment operation scheme for outdoor dry-bulb temperature difference operation. Specifies one or more groups of equipment which are available to operate for successive ranges based the difference between a reference node temperature and the outdoor dry-bulb temperature.")]
    public class PlantEquipmentOperation_OutdoorDryBulbDifference : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("reference_temperature_node_name")]
public string ReferenceTemperatureNodeName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_difference_range_1_lower_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange1LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_difference_range_1_upper_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange1UpperLimit { get; set; } = null;
        

[JsonProperty("range_1_equipment_list_name")]
public string Range1EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_difference_range_2_lower_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange2LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_difference_range_2_upper_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange2UpperLimit { get; set; } = null;
        

[JsonProperty("range_2_equipment_list_name")]
public string Range2EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_difference_range_3_lower_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange3LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_difference_range_3_upper_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange3UpperLimit { get; set; } = null;
        

[JsonProperty("range_3_equipment_list_name")]
public string Range3EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_difference_range_4_lower_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange4LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_difference_range_4_upper_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange4UpperLimit { get; set; } = null;
        

[JsonProperty("range_4_equipment_list_name")]
public string Range4EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_difference_range_5_lower_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange5LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_difference_range_5_upper_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange5UpperLimit { get; set; } = null;
        

[JsonProperty("range_5_equipment_list_name")]
public string Range5EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_difference_range_6_lower_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange6LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_difference_range_6_upper_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange6UpperLimit { get; set; } = null;
        

[JsonProperty("range_6_equipment_list_name")]
public string Range6EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_difference_range_7_lower_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange7LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_difference_range_7_upper_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange7UpperLimit { get; set; } = null;
        

[JsonProperty("range_7_equipment_list_name")]
public string Range7EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_difference_range_8_lower_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange8LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_difference_range_8_upper_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange8UpperLimit { get; set; } = null;
        

[JsonProperty("range_8_equipment_list_name")]
public string Range8EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_difference_range_9_lower_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange9LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_difference_range_9_upper_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange9UpperLimit { get; set; } = null;
        

[JsonProperty("range_9_equipment_list_name")]
public string Range9EquipmentListName { get; set; } = "";
        

[JsonProperty("dry_bulb_temperature_difference_range_10_lower_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange10LowerLimit { get; set; } = null;
        

[JsonProperty("dry_bulb_temperature_difference_range_10_upper_limit")]
public System.Nullable<float> DryBulbTemperatureDifferenceRange10UpperLimit { get; set; } = null;
        

[JsonProperty("range_10_equipment_list_name")]
public string Range10EquipmentListName { get; set; } = "";
    }
    
    [Description(@"Plant equipment operation scheme for outdoor wet-bulb temperature difference operation. Specifies one or more groups of equipment which are available to operate for successive ranges based the difference between a reference node temperature and the outdoor wet-bulb temperature.")]
    public class PlantEquipmentOperation_OutdoorWetBulbDifference : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("reference_temperature_node_name")]
public string ReferenceTemperatureNodeName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_difference_range_1_lower_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange1LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_difference_range_1_upper_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange1UpperLimit { get; set; } = null;
        

[JsonProperty("range_1_equipment_list_name")]
public string Range1EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_difference_range_2_lower_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange2LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_difference_range_2_upper_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange2UpperLimit { get; set; } = null;
        

[JsonProperty("range_2_equipment_list_name")]
public string Range2EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_difference_range_3_lower_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange3LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_difference_range_3_upper_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange3UpperLimit { get; set; } = null;
        

[JsonProperty("range_3_equipment_list_name")]
public string Range3EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_difference_range_4_lower_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange4LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_difference_range_4_upper_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange4UpperLimit { get; set; } = null;
        

[JsonProperty("range_4_equipment_list_name")]
public string Range4EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_difference_range_5_lower_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange5LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_difference_range_5_upper_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange5UpperLimit { get; set; } = null;
        

[JsonProperty("range_5_equipment_list_name")]
public string Range5EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_difference_range_6_lower_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange6LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_difference_range_6_upper_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange6UpperLimit { get; set; } = null;
        

[JsonProperty("range_6_equipment_list_name")]
public string Range6EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_difference_range_7_lower_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange7LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_difference_range_7_upper_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange7UpperLimit { get; set; } = null;
        

[JsonProperty("range_7_equipment_list_name")]
public string Range7EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_difference_range_8_lower_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange8LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_difference_range_8_upper_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange8UpperLimit { get; set; } = null;
        

[JsonProperty("range_8_equipment_list_name")]
public string Range8EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_difference_range_9_lower_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange9LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_difference_range_9_upper_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange9UpperLimit { get; set; } = null;
        

[JsonProperty("range_9_equipment_list_name")]
public string Range9EquipmentListName { get; set; } = "";
        

[JsonProperty("wet_bulb_temperature_difference_range_10_lower_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange10LowerLimit { get; set; } = null;
        

[JsonProperty("wet_bulb_temperature_difference_range_10_upper_limit")]
public System.Nullable<float> WetBulbTemperatureDifferenceRange10UpperLimit { get; set; } = null;
        

[JsonProperty("range_10_equipment_list_name")]
public string Range10EquipmentListName { get; set; } = "";
    }
    
    [Description(@"Plant equipment operation scheme for outdoor dewpoint temperature difference operation. Specifies one or more groups of equipment which are available to operate for successive ranges based the difference between a reference node temperature and the outdoor dewpoint temperature.")]
    public class PlantEquipmentOperation_OutdoorDewpointDifference : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("reference_temperature_node_name")]
public string ReferenceTemperatureNodeName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_difference_range_1_lower_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange1LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_difference_range_1_upper_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange1UpperLimit { get; set; } = null;
        

[JsonProperty("range_1_equipment_list_name")]
public string Range1EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_difference_range_2_lower_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange2LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_difference_range_2_upper_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange2UpperLimit { get; set; } = null;
        

[JsonProperty("range_2_equipment_list_name")]
public string Range2EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_difference_range_3_lower_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange3LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_difference_range_3_upper_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange3UpperLimit { get; set; } = null;
        

[JsonProperty("range_3_equipment_list_name")]
public string Range3EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_difference_range_4_lower_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange4LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_difference_range_4_upper_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange4UpperLimit { get; set; } = null;
        

[JsonProperty("range_4_equipment_list_name")]
public string Range4EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_difference_range_5_lower_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange5LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_difference_range_5_upper_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange5UpperLimit { get; set; } = null;
        

[JsonProperty("range_5_equipment_list_name")]
public string Range5EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_difference_range_6_lower_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange6LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_difference_range_6_upper_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange6UpperLimit { get; set; } = null;
        

[JsonProperty("range_6_equipment_list_name")]
public string Range6EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_difference_range_7_lower_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange7LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_difference_range_7_upper_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange7UpperLimit { get; set; } = null;
        

[JsonProperty("range_7_equipment_list_name")]
public string Range7EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_difference_range_8_lower_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange8LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_difference_range_8_upper_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange8UpperLimit { get; set; } = null;
        

[JsonProperty("range_8_equipment_list_name")]
public string Range8EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_difference_range_9_lower_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange9LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_difference_range_9_upper_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange9UpperLimit { get; set; } = null;
        

[JsonProperty("range_9_equipment_list_name")]
public string Range9EquipmentListName { get; set; } = "";
        

[JsonProperty("dewpoint_temperature_difference_range_10_lower_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange10LowerLimit { get; set; } = null;
        

[JsonProperty("dewpoint_temperature_difference_range_10_upper_limit")]
public System.Nullable<float> DewpointTemperatureDifferenceRange10UpperLimit { get; set; } = null;
        

[JsonProperty("range_10_equipment_list_name")]
public string Range10EquipmentListName { get; set; } = "";
    }
    
    [Description(@"Operation schemes are listed in ""priority"" order. Note that each scheme must address the entire load and/or condition ranges for the simulation. The actual one selected for use will be the first that is ""Scheduled"" on. That is, if control scheme 1 is not ""on"" and control scheme 2 is -- then control scheme 2 is selected. Only plant equipment should be listed on a Control Scheme for this item.")]
    public class PlantEquipmentOperationSchemes : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_scheme_1_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperationSchemes_ControlScheme1ObjectType ControlScheme1ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme1ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme1ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

[JsonProperty("control_scheme_1_name")]
public string ControlScheme1Name { get; set; } = "";
        

[JsonProperty("control_scheme_1_schedule_name")]
public string ControlScheme1ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_2_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperationSchemes_ControlScheme2ObjectType ControlScheme2ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme2ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme2ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

[JsonProperty("control_scheme_2_name")]
public string ControlScheme2Name { get; set; } = "";
        

[JsonProperty("control_scheme_2_schedule_name")]
public string ControlScheme2ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_3_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperationSchemes_ControlScheme3ObjectType ControlScheme3ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme3ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme3ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

[JsonProperty("control_scheme_3_name")]
public string ControlScheme3Name { get; set; } = "";
        

[JsonProperty("control_scheme_3_schedule_name")]
public string ControlScheme3ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_4_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperationSchemes_ControlScheme4ObjectType ControlScheme4ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme4ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme4ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

[JsonProperty("control_scheme_4_name")]
public string ControlScheme4Name { get; set; } = "";
        

[JsonProperty("control_scheme_4_schedule_name")]
public string ControlScheme4ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_5_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperationSchemes_ControlScheme5ObjectType ControlScheme5ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme5ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme5ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

[JsonProperty("control_scheme_5_name")]
public string ControlScheme5Name { get; set; } = "";
        

[JsonProperty("control_scheme_5_schedule_name")]
public string ControlScheme5ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_6_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperationSchemes_ControlScheme6ObjectType ControlScheme6ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme6ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme6ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

[JsonProperty("control_scheme_6_name")]
public string ControlScheme6Name { get; set; } = "";
        

[JsonProperty("control_scheme_6_schedule_name")]
public string ControlScheme6ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_7_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperationSchemes_ControlScheme7ObjectType ControlScheme7ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme7ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme7ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

[JsonProperty("control_scheme_7_name")]
public string ControlScheme7Name { get; set; } = "";
        

[JsonProperty("control_scheme_7_schedule_name")]
public string ControlScheme7ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_8_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantEquipmentOperationSchemes_ControlScheme8ObjectType ControlScheme8ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme8ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme8ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

[JsonProperty("control_scheme_8_name")]
public string ControlScheme8Name { get; set; } = "";
        

[JsonProperty("control_scheme_8_schedule_name")]
public string ControlScheme8ScheduleName { get; set; } = "";
    }
    
    public enum PlantEquipmentOperationSchemes_ControlScheme1ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ComponentSetpoint")]
        PlantEquipmentOperationComponentSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ThermalEnergyStorage")]
        PlantEquipmentOperationThermalEnergyStorage = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 12,
    }
    
    public enum PlantEquipmentOperationSchemes_ControlScheme2ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ComponentSetpoint")]
        PlantEquipmentOperationComponentSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ThermalEnergyStorage")]
        PlantEquipmentOperationThermalEnergyStorage = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 12,
    }
    
    public enum PlantEquipmentOperationSchemes_ControlScheme3ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ComponentSetpoint")]
        PlantEquipmentOperationComponentSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ThermalEnergyStorage")]
        PlantEquipmentOperationThermalEnergyStorage = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 12,
    }
    
    public enum PlantEquipmentOperationSchemes_ControlScheme4ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ComponentSetpoint")]
        PlantEquipmentOperationComponentSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ThermalEnergyStorage")]
        PlantEquipmentOperationThermalEnergyStorage = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 12,
    }
    
    public enum PlantEquipmentOperationSchemes_ControlScheme5ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ComponentSetpoint")]
        PlantEquipmentOperationComponentSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ThermalEnergyStorage")]
        PlantEquipmentOperationThermalEnergyStorage = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 12,
    }
    
    public enum PlantEquipmentOperationSchemes_ControlScheme6ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ComponentSetpoint")]
        PlantEquipmentOperationComponentSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ThermalEnergyStorage")]
        PlantEquipmentOperationThermalEnergyStorage = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 12,
    }
    
    public enum PlantEquipmentOperationSchemes_ControlScheme7ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ComponentSetpoint")]
        PlantEquipmentOperationComponentSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ThermalEnergyStorage")]
        PlantEquipmentOperationThermalEnergyStorage = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 12,
    }
    
    public enum PlantEquipmentOperationSchemes_ControlScheme8ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ComponentSetpoint")]
        PlantEquipmentOperationComponentSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:ThermalEnergyStorage")]
        PlantEquipmentOperationThermalEnergyStorage = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 12,
    }
    
    [Description(@"Operation schemes are listed in ""priority"" order. Note that each scheme must address the entire load and/or condition ranges for the simulation. The actual one selected for use will be the first that is ""Scheduled"" on. That is, if control scheme 1 is not ""on"" and control scheme 2 is -- then control scheme 2 is selected. Only condenser equipment should be listed on a Control Scheme for this item.")]
    public class CondenserEquipmentOperationSchemes : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_scheme_1_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CondenserEquipmentOperationSchemes_ControlScheme1ObjectType ControlScheme1ObjectType { get; set; } = (CondenserEquipmentOperationSchemes_ControlScheme1ObjectType)Enum.Parse(typeof(CondenserEquipmentOperationSchemes_ControlScheme1ObjectType), "PlantEquipmentOperationCoolingLoad");
        

[JsonProperty("control_scheme_1_name")]
public string ControlScheme1Name { get; set; } = "";
        

[JsonProperty("control_scheme_1_schedule_name")]
public string ControlScheme1ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_2_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CondenserEquipmentOperationSchemes_ControlScheme2ObjectType ControlScheme2ObjectType { get; set; } = (CondenserEquipmentOperationSchemes_ControlScheme2ObjectType)Enum.Parse(typeof(CondenserEquipmentOperationSchemes_ControlScheme2ObjectType), "PlantEquipmentOperationCoolingLoad");
        

[JsonProperty("control_scheme_2_name")]
public string ControlScheme2Name { get; set; } = "";
        

[JsonProperty("control_scheme_2_schedule_name")]
public string ControlScheme2ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_3_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CondenserEquipmentOperationSchemes_ControlScheme3ObjectType ControlScheme3ObjectType { get; set; } = (CondenserEquipmentOperationSchemes_ControlScheme3ObjectType)Enum.Parse(typeof(CondenserEquipmentOperationSchemes_ControlScheme3ObjectType), "PlantEquipmentOperationCoolingLoad");
        

[JsonProperty("control_scheme_3_name")]
public string ControlScheme3Name { get; set; } = "";
        

[JsonProperty("control_scheme_3_schedule_name")]
public string ControlScheme3ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_4_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CondenserEquipmentOperationSchemes_ControlScheme4ObjectType ControlScheme4ObjectType { get; set; } = (CondenserEquipmentOperationSchemes_ControlScheme4ObjectType)Enum.Parse(typeof(CondenserEquipmentOperationSchemes_ControlScheme4ObjectType), "PlantEquipmentOperationCoolingLoad");
        

[JsonProperty("control_scheme_4_name")]
public string ControlScheme4Name { get; set; } = "";
        

[JsonProperty("control_scheme_4_schedule_name")]
public string ControlScheme4ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_5_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CondenserEquipmentOperationSchemes_ControlScheme5ObjectType ControlScheme5ObjectType { get; set; } = (CondenserEquipmentOperationSchemes_ControlScheme5ObjectType)Enum.Parse(typeof(CondenserEquipmentOperationSchemes_ControlScheme5ObjectType), "PlantEquipmentOperationCoolingLoad");
        

[JsonProperty("control_scheme_5_name")]
public string ControlScheme5Name { get; set; } = "";
        

[JsonProperty("control_scheme_5_schedule_name")]
public string ControlScheme5ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_6_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CondenserEquipmentOperationSchemes_ControlScheme6ObjectType ControlScheme6ObjectType { get; set; } = (CondenserEquipmentOperationSchemes_ControlScheme6ObjectType)Enum.Parse(typeof(CondenserEquipmentOperationSchemes_ControlScheme6ObjectType), "PlantEquipmentOperationCoolingLoad");
        

[JsonProperty("control_scheme_6_name")]
public string ControlScheme6Name { get; set; } = "";
        

[JsonProperty("control_scheme_6_schedule_name")]
public string ControlScheme6ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_7_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CondenserEquipmentOperationSchemes_ControlScheme7ObjectType ControlScheme7ObjectType { get; set; } = (CondenserEquipmentOperationSchemes_ControlScheme7ObjectType)Enum.Parse(typeof(CondenserEquipmentOperationSchemes_ControlScheme7ObjectType), "PlantEquipmentOperationCoolingLoad");
        

[JsonProperty("control_scheme_7_name")]
public string ControlScheme7Name { get; set; } = "";
        

[JsonProperty("control_scheme_7_schedule_name")]
public string ControlScheme7ScheduleName { get; set; } = "";
        

[JsonProperty("control_scheme_8_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CondenserEquipmentOperationSchemes_ControlScheme8ObjectType ControlScheme8ObjectType { get; set; } = (CondenserEquipmentOperationSchemes_ControlScheme8ObjectType)Enum.Parse(typeof(CondenserEquipmentOperationSchemes_ControlScheme8ObjectType), "PlantEquipmentOperationCoolingLoad");
        

[JsonProperty("control_scheme_8_name")]
public string ControlScheme8Name { get; set; } = "";
        

[JsonProperty("control_scheme_8_schedule_name")]
public string ControlScheme8ScheduleName { get; set; } = "";
    }
    
    public enum CondenserEquipmentOperationSchemes_ControlScheme1ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 10,
    }
    
    public enum CondenserEquipmentOperationSchemes_ControlScheme2ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 10,
    }
    
    public enum CondenserEquipmentOperationSchemes_ControlScheme3ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 10,
    }
    
    public enum CondenserEquipmentOperationSchemes_ControlScheme4ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 10,
    }
    
    public enum CondenserEquipmentOperationSchemes_ControlScheme5ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 10,
    }
    
    public enum CondenserEquipmentOperationSchemes_ControlScheme6ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 10,
    }
    
    public enum CondenserEquipmentOperationSchemes_ControlScheme7ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 10,
    }
    
    public enum CondenserEquipmentOperationSchemes_ControlScheme8ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:CoolingLoad")]
        PlantEquipmentOperationCoolingLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:HeatingLoad")]
        PlantEquipmentOperationHeatingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpoint")]
        PlantEquipmentOperationOutdoorDewpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDewpointDifference")]
        PlantEquipmentOperationOutdoorDewpointDifference = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulb")]
        PlantEquipmentOperationOutdoorDryBulb = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorDryBulbDifference")]
        PlantEquipmentOperationOutdoorDryBulbDifference = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorRelativeHumidity")]
        PlantEquipmentOperationOutdoorRelativeHumidity = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulb")]
        PlantEquipmentOperationOutdoorWetBulb = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:OutdoorWetBulbDifference")]
        PlantEquipmentOperationOutdoorWetBulbDifference = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:Uncontrolled")]
        PlantEquipmentOperationUncontrolled = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="PlantEquipmentOperation:UserDefined")]
        PlantEquipmentOperationUserDefined = 10,
    }
}
