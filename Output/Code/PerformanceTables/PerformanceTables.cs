namespace BH.oM.Adapters.EnergyPlus.PerformanceTables
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
    
    
    [Description("An independent variable representing a single dimension of a Table:Lookup object." +
        "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Table_IndependentVariable : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="interpolation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Table_IndependentVariable_InterpolationMethod InterpolationMethod { get; set; } = (Table_IndependentVariable_InterpolationMethod)Enum.Parse(typeof(Table_IndependentVariable_InterpolationMethod), "Linear");
        

[JsonProperty(PropertyName="extrapolation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Table_IndependentVariable_ExtrapolationMethod ExtrapolationMethod { get; set; } = (Table_IndependentVariable_ExtrapolationMethod)Enum.Parse(typeof(Table_IndependentVariable_ExtrapolationMethod), "Constant");
        

[JsonProperty(PropertyName="minimum_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> MinimumValue { get; set; } = null;
        

[JsonProperty(PropertyName="maximum_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> MaximumValue { get; set; } = null;
        

[JsonProperty(PropertyName="normalization_reference_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NormalizationReferenceValue { get; set; } = null;
        

[JsonProperty(PropertyName="unit_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Table_IndependentVariable_UnitType UnitType { get; set; } = (Table_IndependentVariable_UnitType)Enum.Parse(typeof(Table_IndependentVariable_UnitType), "Dimensionless");
        

[JsonProperty(PropertyName="external_file_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ExternalFileName { get; set; } = "";
        

[JsonProperty(PropertyName="external_file_column_number", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> ExternalFileColumnNumber { get; set; } = null;
        

[JsonProperty(PropertyName="external_file_starting_row_number", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> ExternalFileStartingRowNumber { get; set; } = null;
        

[JsonProperty(PropertyName="values", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Values { get; set; } = "";
    }
    
    public enum Table_IndependentVariable_InterpolationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Cubic")]
        Cubic = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Linear")]
        Linear = 2,
    }
    
    public enum Table_IndependentVariable_ExtrapolationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Linear")]
        Linear = 2,
    }
    
    public enum Table_IndependentVariable_UnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Angle")]
        Angle = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 7,
    }
    
    [Description("A sorted list of independent variables used by one or more Table:Lookup objects.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Table_IndependentVariableList : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="independent_variables", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string IndependentVariables { get; set; } = "";
    }
    
    [Description(@"Lookup tables are used in place of curves and can represent any number of independent variables (defined as Table:IndependentVariable objects in a Table:IndependentVariableList). Output values are interpolated within the bounds defined by each independent variable and extrapolated beyond the bounds according to the interpolation/extrapolation methods defined by each independent variable.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Table_Lookup : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="independent_variable_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string IndependentVariableListName { get; set; } = "";
        

[JsonProperty(PropertyName="normalization_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Table_Lookup_NormalizationMethod NormalizationMethod { get; set; } = (Table_Lookup_NormalizationMethod)Enum.Parse(typeof(Table_Lookup_NormalizationMethod), "None");
        

[JsonProperty(PropertyName="normalization_divisor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NormalizationDivisor { get; set; } = (System.Nullable<double>)Double.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="minimum_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> MinimumOutput { get; set; } = null;
        

[JsonProperty(PropertyName="maximum_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> MaximumOutput { get; set; } = null;
        

[JsonProperty(PropertyName="output_unit_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Table_Lookup_OutputUnitType OutputUnitType { get; set; } = (Table_Lookup_OutputUnitType)Enum.Parse(typeof(Table_Lookup_OutputUnitType), "Dimensionless");
        

[JsonProperty(PropertyName="external_file_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ExternalFileName { get; set; } = "";
        

[JsonProperty(PropertyName="external_file_column_number", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> ExternalFileColumnNumber { get; set; } = null;
        

[JsonProperty(PropertyName="external_file_starting_row_number", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> ExternalFileStartingRowNumber { get; set; } = null;
        

[JsonProperty(PropertyName="values", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Values { get; set; } = "";
    }
    
    public enum Table_Lookup_NormalizationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AutomaticWithDivisor")]
        AutomaticWithDivisor = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DivisorOnly")]
        DivisorOnly = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 3,
    }
    
    public enum Table_Lookup_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Capacity")]
        Capacity = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Pressure")]
        Pressure = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
    }
}
