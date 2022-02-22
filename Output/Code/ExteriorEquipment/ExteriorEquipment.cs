namespace BH.oM.Adapters.EnergyPlus.ExteriorEquipment
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
    
    
    [Description("only used for Meter type reporting, does not affect building loads")]
    [JsonObject("Exterior:Lights")]
    public class Exterior_Lights : BHoMObject, IEnergyPlusClass
    {
        

[Description("units in schedule should be fraction applied to capacity of the exterior lights e" +
    "quipment, generally (0.0 - 1.0)")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[JsonProperty("design_level")]
public System.Nullable<float> DesignLevel { get; set; } = null;
        

[Description("Astronomical Clock option overrides schedule to turn lights off when sun is up")]
[JsonProperty("control_option")]
public Exterior_Lights_ControlOption ControlOption { get; set; } = (Exterior_Lights_ControlOption)Enum.Parse(typeof(Exterior_Lights_ControlOption), "AstronomicalClock");
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum Exterior_Lights_ControlOption
    {
        
        [JsonProperty("AstronomicalClock")]
        AstronomicalClock = 0,
        
        [JsonProperty("ScheduleNameOnly")]
        ScheduleNameOnly = 1,
    }
    
    [Description("only used for Meter type reporting, does not affect building loads")]
    [JsonObject("Exterior:FuelEquipment")]
    public class Exterior_FuelEquipment : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("fuel_use_type")]
public Exterior_FuelEquipment_FuelUseType FuelUseType { get; set; } = (Exterior_FuelEquipment_FuelUseType)Enum.Parse(typeof(Exterior_FuelEquipment_FuelUseType), "Coal");
        

[Description("units in schedule should be fraction applied to capacity of the exterior fuel equ" +
    "ipment, generally (0.0 - 1.0)")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[JsonProperty("design_level")]
public System.Nullable<float> DesignLevel { get; set; } = null;
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum Exterior_FuelEquipment_FuelUseType
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("Diesel")]
        Diesel = 1,
        
        [JsonProperty("DistrictCooling")]
        DistrictCooling = 2,
        
        [JsonProperty("DistrictHeating")]
        DistrictHeating = 3,
        
        [JsonProperty("Electricity")]
        Electricity = 4,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 5,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 6,
        
        [JsonProperty("Gasoline")]
        Gasoline = 7,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 8,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 9,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 10,
        
        [JsonProperty("Propane")]
        Propane = 11,
        
        [JsonProperty("Steam")]
        Steam = 12,
        
        [JsonProperty("Water")]
        Water = 13,
    }
    
    [Description("only used for Meter type reporting, does not affect building loads")]
    [JsonObject("Exterior:WaterEquipment")]
    public class Exterior_WaterEquipment : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("fuel_use_type")]
public Exterior_WaterEquipment_FuelUseType FuelUseType { get; set; } = (Exterior_WaterEquipment_FuelUseType)Enum.Parse(typeof(Exterior_WaterEquipment_FuelUseType), "Water");
        

[Description("units in Schedule should be fraction applied to capacity of the exterior water eq" +
    "uipment, generally (0.0 - 1.0)")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[JsonProperty("design_level")]
public System.Nullable<float> DesignLevel { get; set; } = null;
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum Exterior_WaterEquipment_FuelUseType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Water")]
        Water = 1,
    }
}
