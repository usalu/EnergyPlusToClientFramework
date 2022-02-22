namespace BH.oM.Adapters.EnergyPlus.PythonPluginSystem
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
    
    
    [Description(@"Add directories to the search path for Python plugin modules The directory containing the EnergyPlus executable file is automatically added so that the Python interpreter can find the packaged up pyenergyplus Python package. By default, the current working directory and input file directory are also added to the search path. However, this object allows modifying this behavior. With this object, searching these directories can be disabled, and users can add supplemental search paths that point to libraries of plugin scripts.")]
    [JsonObject("PythonPlugin:SearchPaths")]
    public class PythonPlugin_SearchPaths : BHoMObject, IEnergyPlusClass
    {
        

[Description("Adding the current working directory allows Python to find plugin scripts in the " +
    "current directory.")]
[JsonProperty("add_current_working_directory_to_search_path")]
public EmptyNoYes AddCurrentWorkingDirectoryToSearchPath { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("Enabling this will allow Python to find plugin scripts in the same directory as t" +
    "he running input file, even if that is not the current working directory.")]
[JsonProperty("add_input_file_directory_to_search_path")]
public EmptyNoYes AddInputFileDirectoryToSearchPath { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("py_search_paths")]
public string PySearchPaths { get; set; } = "";
    }
    
    [Description("A single plugin to be executed during the simulation, which can contain multiple " +
        "calling points for the same class instance by overriding multiple calling point " +
        "methods.")]
    [JsonObject("PythonPlugin:Instance")]
    public class PythonPlugin_Instance : BHoMObject, IEnergyPlusClass
    {
        

[Description("If this field is enabled, the plugin will be executed during warmup days, otherwi" +
    "se it will only be executed once warmup is completed and the actual run period b" +
    "egins")]
[JsonProperty("run_during_warmup_days")]
public EmptyNoYes RunDuringWarmupDays { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description(@"This is the name of the Python file, without a file extension. For ""plugin_b.py"", use just ""plugin_b"". The Python plugin file must be on the plugin system search path to be found during a simulation Additional directories can be added to the search path using the PythonPlugin:SearchPaths object")]
[JsonProperty("python_module_name")]
public string PythonModuleName { get; set; } = "";
        

[Description("This is the name of the class to be executed as a plugin during a simulation The " +
    "class must inherit the EnergyPlusPlugin base class")]
[JsonProperty("plugin_class_name")]
public string PluginClassName { get; set; } = "";
    }
    
    [Description("This object defines name identifiers for custom Python Plugin variable data that " +
        "should be shared among all running Python Plugins.")]
    [JsonObject("PythonPlugin:Variables")]
    public class PythonPlugin_Variables : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("global_py_vars")]
public string GlobalPyVars { get; set; } = "";
    }
    
    [Description("This object sets up a Python plugin trend variable from an Python plugin variable" +
        " A trend variable logs values across timesteps")]
    [JsonObject("PythonPlugin:TrendVariable")]
    public class PythonPlugin_TrendVariable : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("name_of_a_python_plugin_variable")]
public string NameOfAPythonPluginVariable { get; set; } = "";
        

[JsonProperty("number_of_timesteps_to_be_logged")]
public System.Nullable<float> NumberOfTimestepsToBeLogged { get; set; } = null;
    }
    
    [Description("This object sets up an EnergyPlus output variable from a Python Plugin variable")]
    [JsonObject("PythonPlugin:OutputVariable")]
    public class PythonPlugin_OutputVariable : BHoMObject, IEnergyPlusClass
    {
        

[Description("Must be listed in the PythonPlugin:Variables object")]
[JsonProperty("python_plugin_variable_name")]
public string PythonPluginVariableName { get; set; } = "";
        

[Description("If Metered is selected, the variable is automatically set to a \"Summed\" type, and" +
    " the Resource Type, Group Type, and End-Use Subcategory fields on this object ar" +
    "e required")]
[JsonProperty("type_of_data_in_variable")]
public PythonPlugin_OutputVariable_TypeOfDataInVariable TypeOfDataInVariable { get; set; } = (PythonPlugin_OutputVariable_TypeOfDataInVariable)Enum.Parse(typeof(PythonPlugin_OutputVariable_TypeOfDataInVariable), "Averaged");
        

[JsonProperty("update_frequency")]
public PythonPlugin_OutputVariable_UpdateFrequency UpdateFrequency { get; set; } = (PythonPlugin_OutputVariable_UpdateFrequency)Enum.Parse(typeof(PythonPlugin_OutputVariable_UpdateFrequency), "SystemTimestep");
        

[Description("optional but will result in dimensionless units for blank EnergyPlus units are st" +
    "andard SI units")]
[JsonProperty("units")]
public string Units { get; set; } = "";
        

[Description(@"This field is optional for regular output variables with ""Type of Data in Variable"" set to either Averaged or Summed. For Metered variables, this field is required. Choose the type of fuel, water, electricity, pollution or heat rate that should be metered.")]
[JsonProperty("resource_type")]
public PythonPlugin_OutputVariable_ResourceType ResourceType { get; set; } = (PythonPlugin_OutputVariable_ResourceType)Enum.Parse(typeof(PythonPlugin_OutputVariable_ResourceType), "Coal");
        

[Description(@"This field is optional for regular output variables with ""Type of Data in Variable"" set to either Averaged or Summed. For Metered variables, this field is required. Choose a general classification, building (internal services), HVAC (air systems), or plant (hydronic systems), or system")]
[JsonProperty("group_type")]
public PythonPlugin_OutputVariable_GroupType GroupType { get; set; } = (PythonPlugin_OutputVariable_GroupType)Enum.Parse(typeof(PythonPlugin_OutputVariable_GroupType), "Building");
        

[Description("This field is optional for regular output variables with \"Type of Data in Variabl" +
    "e\" set to either Averaged or Summed. For Metered variables, this field is requir" +
    "ed. Choose how the metered output should be classified for end-use category")]
[JsonProperty("end_use_category")]
public PythonPlugin_OutputVariable_EndUseCategory EndUseCategory { get; set; } = (PythonPlugin_OutputVariable_EndUseCategory)Enum.Parse(typeof(PythonPlugin_OutputVariable_EndUseCategory), "Baseboard");
        

[Description(@"This field is always optional. For regular output variables with ""Type of Data in Variable"" set to either Averaged or Summed, this field is completely ignored. For Metered variables, this field is optional, but allows custom categorization of the end-uses in the ABUPS End Uses by Subcategory table. Enter a user-defined subcategory for this metered output")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = "";
    }
    
    public enum PythonPlugin_OutputVariable_TypeOfDataInVariable
    {
        
        [JsonProperty("Averaged")]
        Averaged = 0,
        
        [JsonProperty("Metered")]
        Metered = 1,
        
        [JsonProperty("Summed")]
        Summed = 2,
    }
    
    public enum PythonPlugin_OutputVariable_UpdateFrequency
    {
        
        [JsonProperty("SystemTimestep")]
        SystemTimestep = 0,
        
        [JsonProperty("ZoneTimestep")]
        ZoneTimestep = 1,
    }
    
    public enum PythonPlugin_OutputVariable_ResourceType
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("CondensateWaterCollected")]
        CondensateWaterCollected = 1,
        
        [JsonProperty("Diesel")]
        Diesel = 2,
        
        [JsonProperty("DistrictCooling")]
        DistrictCooling = 3,
        
        [JsonProperty("DistrictHeating")]
        DistrictHeating = 4,
        
        [JsonProperty("Electricity")]
        Electricity = 5,
        
        [JsonProperty("ElectricityProducedOnSite")]
        ElectricityProducedOnSite = 6,
        
        [JsonProperty("EnergyTransfer")]
        EnergyTransfer = 7,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 8,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 9,
        
        [JsonProperty("Gasoline")]
        Gasoline = 10,
        
        [JsonProperty("MainsWaterSupply")]
        MainsWaterSupply = 11,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 12,
        
        [JsonProperty("OnSiteWaterProduced")]
        OnSiteWaterProduced = 13,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 14,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 15,
        
        [JsonProperty("Propane")]
        Propane = 16,
        
        [JsonProperty("RainWaterCollected")]
        RainWaterCollected = 17,
        
        [JsonProperty("SolarAirHeating")]
        SolarAirHeating = 18,
        
        [JsonProperty("SolarWaterHeating")]
        SolarWaterHeating = 19,
        
        [JsonProperty("Steam")]
        Steam = 20,
        
        [JsonProperty("WaterUse")]
        WaterUse = 21,
        
        [JsonProperty("WellWaterDrawn")]
        WellWaterDrawn = 22,
    }
    
    public enum PythonPlugin_OutputVariable_GroupType
    {
        
        [JsonProperty("Building")]
        Building = 0,
        
        [JsonProperty("HVAC")]
        HVAC = 1,
        
        [JsonProperty("Plant")]
        Plant = 2,
        
        [JsonProperty("System")]
        System = 3,
    }
    
    public enum PythonPlugin_OutputVariable_EndUseCategory
    {
        
        [JsonProperty("Baseboard")]
        Baseboard = 0,
        
        [JsonProperty("Boilers")]
        Boilers = 1,
        
        [JsonProperty("Chillers")]
        Chillers = 2,
        
        [JsonProperty("Cooling")]
        Cooling = 3,
        
        [JsonProperty("CoolingCoils")]
        CoolingCoils = 4,
        
        [JsonProperty("ExteriorEquipment")]
        ExteriorEquipment = 5,
        
        [JsonProperty("ExteriorLights")]
        ExteriorLights = 6,
        
        [JsonProperty("Fans")]
        Fans = 7,
        
        [JsonProperty("HeatRecovery")]
        HeatRecovery = 8,
        
        [JsonProperty("HeatRecoveryForCooling")]
        HeatRecoveryForCooling = 9,
        
        [JsonProperty("HeatRecoveryForHeating")]
        HeatRecoveryForHeating = 10,
        
        [JsonProperty("HeatRejection")]
        HeatRejection = 11,
        
        [JsonProperty("Heating")]
        Heating = 12,
        
        [JsonProperty("HeatingCoils")]
        HeatingCoils = 13,
        
        [JsonProperty("Humidifier")]
        Humidifier = 14,
        
        [JsonProperty("InteriorEquipment")]
        InteriorEquipment = 15,
        
        [JsonProperty("InteriorLights")]
        InteriorLights = 16,
        
        [JsonProperty("OnSiteGeneration")]
        OnSiteGeneration = 17,
        
        [JsonProperty("Pumps")]
        Pumps = 18,
        
        [JsonProperty("Refrigeration")]
        Refrigeration = 19,
        
        [JsonProperty("WaterSystems")]
        WaterSystems = 20,
    }
}
