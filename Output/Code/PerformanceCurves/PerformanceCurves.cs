namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
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
    
    
    [Description(@"Linear curve with one independent variable. Input for the linear curve consists of a curve name, the two coefficients, and the maximum and minimum valid independent variable values. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*x")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_Linear : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_constant")]
public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

[JsonProperty("coefficient2_x")]
public System.Nullable<float> Coefficient2X { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Linear_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Linear_InputUnitTypeForX)Enum.Parse(typeof(Curve_Linear_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Linear_OutputUnitType OutputUnitType { get; set; } = (Curve_Linear_OutputUnitType)Enum.Parse(typeof(Curve_Linear_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_Linear_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Pressure")]
        Pressure = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 7,
    }
    
    public enum Curve_Linear_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Linear curve with four independent variables. Input for the linear curve consists of a curve name, the two coefficients, and the maximum and minimum valid independent variable values. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*w + C3*x + C4*y + C5*z")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_QuadLinear : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_constant")]
public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

[JsonProperty("coefficient2_w")]
public System.Nullable<float> Coefficient2W { get; set; } = null;
        

[JsonProperty("coefficient3_x")]
public System.Nullable<float> Coefficient3X { get; set; } = null;
        

[JsonProperty("coefficient4_y")]
public System.Nullable<float> Coefficient4Y { get; set; } = null;
        

[JsonProperty("coefficient5_z")]
public System.Nullable<float> Coefficient5Z { get; set; } = null;
        

[JsonProperty("minimum_value_of_w")]
public System.Nullable<float> MinimumValueOfW { get; set; } = null;
        

[JsonProperty("maximum_value_of_w")]
public System.Nullable<float> MaximumValueOfW { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[JsonProperty("minimum_value_of_y")]
public System.Nullable<float> MinimumValueOfY { get; set; } = null;
        

[JsonProperty("maximum_value_of_y")]
public System.Nullable<float> MaximumValueOfY { get; set; } = null;
        

[JsonProperty("minimum_value_of_z")]
public System.Nullable<float> MinimumValueOfZ { get; set; } = null;
        

[JsonProperty("maximum_value_of_z")]
public System.Nullable<float> MaximumValueOfZ { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_w")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_QuadLinear_InputUnitTypeForW InputUnitTypeForW { get; set; } = (Curve_QuadLinear_InputUnitTypeForW)Enum.Parse(typeof(Curve_QuadLinear_InputUnitTypeForW), "Dimensionless");
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_QuadLinear_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_QuadLinear_InputUnitTypeForX)Enum.Parse(typeof(Curve_QuadLinear_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("input_unit_type_for_y")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_QuadLinear_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_QuadLinear_InputUnitTypeForY)Enum.Parse(typeof(Curve_QuadLinear_InputUnitTypeForY), "Dimensionless");
        

[JsonProperty("input_unit_type_for_z")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_QuadLinear_InputUnitTypeForZ InputUnitTypeForZ { get; set; } = (Curve_QuadLinear_InputUnitTypeForZ)Enum.Parse(typeof(Curve_QuadLinear_InputUnitTypeForZ), "Dimensionless");
    }
    
    public enum Curve_QuadLinear_InputUnitTypeForW
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlowPerPower")]
        VolumetricFlowPerPower = 7,
    }
    
    public enum Curve_QuadLinear_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlowPerPower")]
        VolumetricFlowPerPower = 7,
    }
    
    public enum Curve_QuadLinear_InputUnitTypeForY
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlowPerPower")]
        VolumetricFlowPerPower = 7,
    }
    
    public enum Curve_QuadLinear_InputUnitTypeForZ
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlowPerPower")]
        VolumetricFlowPerPower = 7,
    }
    
    [Description(@"Linear curve with five independent variables. Input for the linear curve consists of a curve name, the two coefficients, and the maximum and minimum valid independent variable values. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*v + C3*w + C4*x + C5*y + C6*z")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_QuintLinear : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_constant")]
public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

[JsonProperty("coefficient2_v")]
public System.Nullable<float> Coefficient2V { get; set; } = null;
        

[JsonProperty("coefficient3_w")]
public System.Nullable<float> Coefficient3W { get; set; } = null;
        

[JsonProperty("coefficient4_x")]
public System.Nullable<float> Coefficient4X { get; set; } = null;
        

[JsonProperty("coefficient5_y")]
public System.Nullable<float> Coefficient5Y { get; set; } = null;
        

[JsonProperty("coefficient6_z")]
public System.Nullable<float> Coefficient6Z { get; set; } = null;
        

[JsonProperty("minimum_value_of_v")]
public System.Nullable<float> MinimumValueOfV { get; set; } = null;
        

[JsonProperty("maximum_value_of_v")]
public System.Nullable<float> MaximumValueOfV { get; set; } = null;
        

[JsonProperty("minimum_value_of_w")]
public System.Nullable<float> MinimumValueOfW { get; set; } = null;
        

[JsonProperty("maximum_value_of_w")]
public System.Nullable<float> MaximumValueOfW { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[JsonProperty("minimum_value_of_y")]
public System.Nullable<float> MinimumValueOfY { get; set; } = null;
        

[JsonProperty("maximum_value_of_y")]
public System.Nullable<float> MaximumValueOfY { get; set; } = null;
        

[JsonProperty("minimum_value_of_z")]
public System.Nullable<float> MinimumValueOfZ { get; set; } = null;
        

[JsonProperty("maximum_value_of_z")]
public System.Nullable<float> MaximumValueOfZ { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_v")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_QuintLinear_InputUnitTypeForV InputUnitTypeForV { get; set; } = (Curve_QuintLinear_InputUnitTypeForV)Enum.Parse(typeof(Curve_QuintLinear_InputUnitTypeForV), "Dimensionless");
        

[JsonProperty("input_unit_type_for_w")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_QuintLinear_InputUnitTypeForW InputUnitTypeForW { get; set; } = (Curve_QuintLinear_InputUnitTypeForW)Enum.Parse(typeof(Curve_QuintLinear_InputUnitTypeForW), "Dimensionless");
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_QuintLinear_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_QuintLinear_InputUnitTypeForX)Enum.Parse(typeof(Curve_QuintLinear_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("input_unit_type_for_y")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_QuintLinear_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_QuintLinear_InputUnitTypeForY)Enum.Parse(typeof(Curve_QuintLinear_InputUnitTypeForY), "Dimensionless");
        

[JsonProperty("input_unit_type_for_z")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_QuintLinear_InputUnitTypeForZ InputUnitTypeForZ { get; set; } = (Curve_QuintLinear_InputUnitTypeForZ)Enum.Parse(typeof(Curve_QuintLinear_InputUnitTypeForZ), "Dimensionless");
    }
    
    public enum Curve_QuintLinear_InputUnitTypeForV
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlowPerPower")]
        VolumetricFlowPerPower = 7,
    }
    
    public enum Curve_QuintLinear_InputUnitTypeForW
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlowPerPower")]
        VolumetricFlowPerPower = 7,
    }
    
    public enum Curve_QuintLinear_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlowPerPower")]
        VolumetricFlowPerPower = 7,
    }
    
    public enum Curve_QuintLinear_InputUnitTypeForY
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlowPerPower")]
        VolumetricFlowPerPower = 7,
    }
    
    public enum Curve_QuintLinear_InputUnitTypeForZ
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlowPerPower")]
        VolumetricFlowPerPower = 7,
    }
    
    [Description(@"Quadratic curve with one independent variable. Input for a quadratic curve consists of the curve name, the three coefficients, and the maximum and minimum valid independent variable values. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*x + C3*x**2")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_Quadratic : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_constant")]
public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

[JsonProperty("coefficient2_x")]
public System.Nullable<float> Coefficient2X { get; set; } = null;
        

[JsonProperty("coefficient3_x_2")]
public System.Nullable<float> Coefficient3X2 { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Quadratic_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Quadratic_InputUnitTypeForX)Enum.Parse(typeof(Curve_Quadratic_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Quadratic_OutputUnitType OutputUnitType { get; set; } = (Curve_Quadratic_OutputUnitType)Enum.Parse(typeof(Curve_Quadratic_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_Quadratic_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
    }
    
    public enum Curve_Quadratic_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Cubic curve with one independent variable. Input for a cubic curve consists of the curve name, the 4 coefficients, and the maximum and minimum valid independent variable values. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*x + C3*x**2 + C4*x**3")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_Cubic : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_constant")]
public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

[JsonProperty("coefficient2_x")]
public System.Nullable<float> Coefficient2X { get; set; } = null;
        

[JsonProperty("coefficient3_x_2")]
public System.Nullable<float> Coefficient3X2 { get; set; } = null;
        

[JsonProperty("coefficient4_x_3")]
public System.Nullable<float> Coefficient4X3 { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Cubic_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Cubic_InputUnitTypeForX)Enum.Parse(typeof(Curve_Cubic_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Cubic_OutputUnitType OutputUnitType { get; set; } = (Curve_Cubic_OutputUnitType)Enum.Parse(typeof(Curve_Cubic_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_Cubic_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
    }
    
    public enum Curve_Cubic_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Quartic (fourth order polynomial) curve with one independent variable. Input for a Quartic curve consists of the curve name, the five coefficients, and the maximum and minimum valid independent variable values. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*x + C3*x**2 + C4*x**3 + C5*x**4")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_Quartic : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_constant")]
public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

[JsonProperty("coefficient2_x")]
public System.Nullable<float> Coefficient2X { get; set; } = null;
        

[JsonProperty("coefficient3_x_2")]
public System.Nullable<float> Coefficient3X2 { get; set; } = null;
        

[JsonProperty("coefficient4_x_3")]
public System.Nullable<float> Coefficient4X3 { get; set; } = null;
        

[JsonProperty("coefficient5_x_4")]
public System.Nullable<float> Coefficient5X4 { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Quartic_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Quartic_InputUnitTypeForX)Enum.Parse(typeof(Curve_Quartic_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Quartic_OutputUnitType OutputUnitType { get; set; } = (Curve_Quartic_OutputUnitType)Enum.Parse(typeof(Curve_Quartic_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_Quartic_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
    }
    
    public enum Curve_Quartic_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Exponent curve with one independent variable. Input for a exponent curve consists of the curve name, the 3 coefficients, and the maximum and minimum valid independent variable values. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*x**C3 The independent variable x is raised to the C3 power, multiplied by C2, and C1 is added to the result.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_Exponent : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_constant")]
public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

[JsonProperty("coefficient2_constant")]
public System.Nullable<float> Coefficient2Constant { get; set; } = null;
        

[JsonProperty("coefficient3_constant")]
public System.Nullable<float> Coefficient3Constant { get; set; } = null;
        

[Description("Specify the minimum value of the independent variable x allowed")]
[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[Description("Specify the maximum value of the independent variable x allowed")]
[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Exponent_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Exponent_InputUnitTypeForX)Enum.Parse(typeof(Curve_Exponent_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Exponent_OutputUnitType OutputUnitType { get; set; } = (Curve_Exponent_OutputUnitType)Enum.Parse(typeof(Curve_Exponent_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_Exponent_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
    }
    
    public enum Curve_Exponent_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Cubic curve with two independent variables. Input consists of the curve name, the ten coefficients, and the minimum and maximum values for each of the independent variables. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*x + C3*x**2 + C4*y + C5*y**2 + C6*x*y + C7*x**3 + C8*y**3 + C9*x**2*y + C10*x*y**2")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_Bicubic : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_constant")]
public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

[JsonProperty("coefficient2_x")]
public System.Nullable<float> Coefficient2X { get; set; } = null;
        

[JsonProperty("coefficient3_x_2")]
public System.Nullable<float> Coefficient3X2 { get; set; } = null;
        

[JsonProperty("coefficient4_y")]
public System.Nullable<float> Coefficient4Y { get; set; } = null;
        

[JsonProperty("coefficient5_y_2")]
public System.Nullable<float> Coefficient5Y2 { get; set; } = null;
        

[JsonProperty("coefficient6_x_y")]
public System.Nullable<float> Coefficient6XY { get; set; } = null;
        

[JsonProperty("coefficient7_x_3")]
public System.Nullable<float> Coefficient7X3 { get; set; } = null;
        

[JsonProperty("coefficient8_y_3")]
public System.Nullable<float> Coefficient8Y3 { get; set; } = null;
        

[JsonProperty("coefficient9_x_2_y")]
public System.Nullable<float> Coefficient9X2Y { get; set; } = null;
        

[JsonProperty("coefficient10_x_y_2")]
public System.Nullable<float> Coefficient10XY2 { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[JsonProperty("minimum_value_of_y")]
public System.Nullable<float> MinimumValueOfY { get; set; } = null;
        

[JsonProperty("maximum_value_of_y")]
public System.Nullable<float> MaximumValueOfY { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Bicubic_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Bicubic_InputUnitTypeForX)Enum.Parse(typeof(Curve_Bicubic_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("input_unit_type_for_y")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Bicubic_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_Bicubic_InputUnitTypeForY)Enum.Parse(typeof(Curve_Bicubic_InputUnitTypeForY), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Bicubic_OutputUnitType OutputUnitType { get; set; } = (Curve_Bicubic_OutputUnitType)Enum.Parse(typeof(Curve_Bicubic_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_Bicubic_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
    }
    
    public enum Curve_Bicubic_InputUnitTypeForY
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
    }
    
    public enum Curve_Bicubic_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Quadratic curve with two independent variables. Input consists of the curve name, the six coefficients, and min and max values for each of the independent variables. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*x + C3*x**2 + C4*y + C5*y**2 + C6*x*y")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_Biquadratic : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_constant")]
public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

[JsonProperty("coefficient2_x")]
public System.Nullable<float> Coefficient2X { get; set; } = null;
        

[JsonProperty("coefficient3_x_2")]
public System.Nullable<float> Coefficient3X2 { get; set; } = null;
        

[JsonProperty("coefficient4_y")]
public System.Nullable<float> Coefficient4Y { get; set; } = null;
        

[JsonProperty("coefficient5_y_2")]
public System.Nullable<float> Coefficient5Y2 { get; set; } = null;
        

[JsonProperty("coefficient6_x_y")]
public System.Nullable<float> Coefficient6XY { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[JsonProperty("minimum_value_of_y")]
public System.Nullable<float> MinimumValueOfY { get; set; } = null;
        

[JsonProperty("maximum_value_of_y")]
public System.Nullable<float> MaximumValueOfY { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Biquadratic_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Biquadratic_InputUnitTypeForX)Enum.Parse(typeof(Curve_Biquadratic_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("input_unit_type_for_y")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Biquadratic_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_Biquadratic_InputUnitTypeForY)Enum.Parse(typeof(Curve_Biquadratic_InputUnitTypeForY), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Biquadratic_OutputUnitType OutputUnitType { get; set; } = (Curve_Biquadratic_OutputUnitType)Enum.Parse(typeof(Curve_Biquadratic_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_Biquadratic_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
    }
    
    public enum Curve_Biquadratic_InputUnitTypeForY
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
    }
    
    public enum Curve_Biquadratic_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Quadratic-linear curve with two independent variables. Input consists of the curve name, the six coefficients, and min and max values for each of the independent variables. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = (C1 + C2*x + C3*x**2) + (C4 + C5*x + C6*x**2)*y")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_QuadraticLinear : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_constant")]
public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

[JsonProperty("coefficient2_x")]
public System.Nullable<float> Coefficient2X { get; set; } = null;
        

[JsonProperty("coefficient3_x_2")]
public System.Nullable<float> Coefficient3X2 { get; set; } = null;
        

[JsonProperty("coefficient4_y")]
public System.Nullable<float> Coefficient4Y { get; set; } = null;
        

[JsonProperty("coefficient5_x_y")]
public System.Nullable<float> Coefficient5XY { get; set; } = null;
        

[JsonProperty("coefficient6_x_2_y")]
public System.Nullable<float> Coefficient6X2Y { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[JsonProperty("minimum_value_of_y")]
public System.Nullable<float> MinimumValueOfY { get; set; } = null;
        

[JsonProperty("maximum_value_of_y")]
public System.Nullable<float> MaximumValueOfY { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_QuadraticLinear_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_QuadraticLinear_InputUnitTypeForX)Enum.Parse(typeof(Curve_QuadraticLinear_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("input_unit_type_for_y")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_QuadraticLinear_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_QuadraticLinear_InputUnitTypeForY)Enum.Parse(typeof(Curve_QuadraticLinear_InputUnitTypeForY), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_QuadraticLinear_OutputUnitType OutputUnitType { get; set; } = (Curve_QuadraticLinear_OutputUnitType)Enum.Parse(typeof(Curve_QuadraticLinear_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_QuadraticLinear_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
    }
    
    public enum Curve_QuadraticLinear_InputUnitTypeForY
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
    }
    
    public enum Curve_QuadraticLinear_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Cubic-linear curve with two independent variables. Input consists of the curve name, the six coefficients, and min and max values for each of the independent variables. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = (C1 + C2*x + C3*x**2 + C4*x**3) + (C5 + C6*x)*y")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_CubicLinear : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_constant")]
public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

[JsonProperty("coefficient2_x")]
public System.Nullable<float> Coefficient2X { get; set; } = null;
        

[JsonProperty("coefficient3_x_2")]
public System.Nullable<float> Coefficient3X2 { get; set; } = null;
        

[JsonProperty("coefficient4_x_3")]
public System.Nullable<float> Coefficient4X3 { get; set; } = null;
        

[JsonProperty("coefficient5_y")]
public System.Nullable<float> Coefficient5Y { get; set; } = null;
        

[JsonProperty("coefficient6_x_y")]
public System.Nullable<float> Coefficient6XY { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[JsonProperty("minimum_value_of_y")]
public System.Nullable<float> MinimumValueOfY { get; set; } = null;
        

[JsonProperty("maximum_value_of_y")]
public System.Nullable<float> MaximumValueOfY { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_CubicLinear_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_CubicLinear_InputUnitTypeForX)Enum.Parse(typeof(Curve_CubicLinear_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("input_unit_type_for_y")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_CubicLinear_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_CubicLinear_InputUnitTypeForY)Enum.Parse(typeof(Curve_CubicLinear_InputUnitTypeForY), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_CubicLinear_OutputUnitType OutputUnitType { get; set; } = (Curve_CubicLinear_OutputUnitType)Enum.Parse(typeof(Curve_CubicLinear_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_CubicLinear_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 2,
    }
    
    public enum Curve_CubicLinear_InputUnitTypeForY
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 2,
    }
    
    public enum Curve_CubicLinear_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Quadratic curve with three independent variables. Input consists of the curve name, the twenty seven coefficients, and min and max values for each of the independent variables. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = a0 + a1*x**2 + a2*x + a3*y**2 + a4*y + a5*z**2 + a6*z + a7*x**2*y**2 + a8*x*y + a9*x*y**2 + a10*x**2*y + a11*x**2*z**2 + a12*x*z + a13*x*z**2 + a14*x**2*z + a15*y**2*z**2 + a16*y*z + a17*y*z**2 + a18*y**2*z + a19*x**2*y**2*z**2 + a20*x**2*y**2*z + a21*x**2*y*z**2 + a22*x*y**2*z**2 + a23*x**2*y*z + a24*x*y**2*z + a25*x*y*z**2 +a26*x*y*z")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_Triquadratic : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_constant")]
public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

[JsonProperty("coefficient2_x_2")]
public System.Nullable<float> Coefficient2X2 { get; set; } = null;
        

[JsonProperty("coefficient3_x")]
public System.Nullable<float> Coefficient3X { get; set; } = null;
        

[JsonProperty("coefficient4_y_2")]
public System.Nullable<float> Coefficient4Y2 { get; set; } = null;
        

[JsonProperty("coefficient5_y")]
public System.Nullable<float> Coefficient5Y { get; set; } = null;
        

[JsonProperty("coefficient6_z_2")]
public System.Nullable<float> Coefficient6Z2 { get; set; } = null;
        

[JsonProperty("coefficient7_z")]
public System.Nullable<float> Coefficient7Z { get; set; } = null;
        

[JsonProperty("coefficient8_x_2_y_2")]
public System.Nullable<float> Coefficient8X2Y2 { get; set; } = null;
        

[JsonProperty("coefficient9_x_y")]
public System.Nullable<float> Coefficient9XY { get; set; } = null;
        

[JsonProperty("coefficient10_x_y_2")]
public System.Nullable<float> Coefficient10XY2 { get; set; } = null;
        

[JsonProperty("coefficient11_x_2_y")]
public System.Nullable<float> Coefficient11X2Y { get; set; } = null;
        

[JsonProperty("coefficient12_x_2_z_2")]
public System.Nullable<float> Coefficient12X2Z2 { get; set; } = null;
        

[JsonProperty("coefficient13_x_z")]
public System.Nullable<float> Coefficient13XZ { get; set; } = null;
        

[JsonProperty("coefficient14_x_z_2")]
public System.Nullable<float> Coefficient14XZ2 { get; set; } = null;
        

[JsonProperty("coefficient15_x_2_z")]
public System.Nullable<float> Coefficient15X2Z { get; set; } = null;
        

[JsonProperty("coefficient16_y_2_z_2")]
public System.Nullable<float> Coefficient16Y2Z2 { get; set; } = null;
        

[JsonProperty("coefficient17_y_z")]
public System.Nullable<float> Coefficient17YZ { get; set; } = null;
        

[JsonProperty("coefficient18_y_z_2")]
public System.Nullable<float> Coefficient18YZ2 { get; set; } = null;
        

[JsonProperty("coefficient19_y_2_z")]
public System.Nullable<float> Coefficient19Y2Z { get; set; } = null;
        

[JsonProperty("coefficient20_x_2_y_2_z_2")]
public System.Nullable<float> Coefficient20X2Y2Z2 { get; set; } = null;
        

[JsonProperty("coefficient21_x_2_y_2_z")]
public System.Nullable<float> Coefficient21X2Y2Z { get; set; } = null;
        

[JsonProperty("coefficient22_x_2_y_z_2")]
public System.Nullable<float> Coefficient22X2YZ2 { get; set; } = null;
        

[JsonProperty("coefficient23_x_y_2_z_2")]
public System.Nullable<float> Coefficient23XY2Z2 { get; set; } = null;
        

[JsonProperty("coefficient24_x_2_y_z")]
public System.Nullable<float> Coefficient24X2YZ { get; set; } = null;
        

[JsonProperty("coefficient25_x_y_2_z")]
public System.Nullable<float> Coefficient25XY2Z { get; set; } = null;
        

[JsonProperty("coefficient26_x_y_z_2")]
public System.Nullable<float> Coefficient26XYZ2 { get; set; } = null;
        

[JsonProperty("coefficient27_x_y_z")]
public System.Nullable<float> Coefficient27XYZ { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[JsonProperty("minimum_value_of_y")]
public System.Nullable<float> MinimumValueOfY { get; set; } = null;
        

[JsonProperty("maximum_value_of_y")]
public System.Nullable<float> MaximumValueOfY { get; set; } = null;
        

[JsonProperty("minimum_value_of_z")]
public System.Nullable<float> MinimumValueOfZ { get; set; } = null;
        

[JsonProperty("maximum_value_of_z")]
public System.Nullable<float> MaximumValueOfZ { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Triquadratic_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Triquadratic_InputUnitTypeForX)Enum.Parse(typeof(Curve_Triquadratic_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("input_unit_type_for_y")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Triquadratic_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_Triquadratic_InputUnitTypeForY)Enum.Parse(typeof(Curve_Triquadratic_InputUnitTypeForY), "Dimensionless");
        

[JsonProperty("input_unit_type_for_z")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Triquadratic_InputUnitTypeForZ InputUnitTypeForZ { get; set; } = (Curve_Triquadratic_InputUnitTypeForZ)Enum.Parse(typeof(Curve_Triquadratic_InputUnitTypeForZ), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Triquadratic_OutputUnitType OutputUnitType { get; set; } = (Curve_Triquadratic_OutputUnitType)Enum.Parse(typeof(Curve_Triquadratic_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_Triquadratic_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
    }
    
    public enum Curve_Triquadratic_InputUnitTypeForY
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
    }
    
    public enum Curve_Triquadratic_InputUnitTypeForZ
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Distance")]
        Distance = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MassFlow")]
        MassFlow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Power")]
        Power = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VolumetricFlow")]
        VolumetricFlow = 6,
    }
    
    public enum Curve_Triquadratic_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description("Sets up curve information for minor loss and/or friction calculations in plant pr" +
        "essure simulations Expression: DeltaP = {K + f*(L/D)} * (rho * V^2) / 2")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_Functional_PressureDrop : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description("\"D\" in above expression, used to also calculate local velocity")]
[JsonProperty("diameter")]
public System.Nullable<float> Diameter { get; set; } = null;
        

[Description("\"K\" in above expression")]
[JsonProperty("minor_loss_coefficient")]
public System.Nullable<float> MinorLossCoefficient { get; set; } = null;
        

[Description("\"L\" in above expression")]
[JsonProperty("length")]
public System.Nullable<float> Length { get; set; } = null;
        

[Description("This will be used to calculate \"f\" from Moody-chart approximations")]
[JsonProperty("roughness")]
public System.Nullable<float> Roughness { get; set; } = null;
        

[Description("Optional way to set a constant value for \"f\", instead of using internal Moody-cha" +
    "rt approximations")]
[JsonProperty("fixed_friction_factor")]
public System.Nullable<float> FixedFrictionFactor { get; set; } = null;
    }
    
    [Description(@"Special curve type with two independent variables. Input for the fan total pressure rise curve consists of the curve name, the four coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = C1*Qfan**2+C2*Qfan+C3*Qfan*(Psm-Po)**0.5+C4*(Psm-Po) Po assumed to be zero See InputOut Reference for curve details")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_FanPressureRise : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_c1")]
public System.Nullable<float> Coefficient1C1 { get; set; } = null;
        

[JsonProperty("coefficient2_c2")]
public System.Nullable<float> Coefficient2C2 { get; set; } = null;
        

[JsonProperty("coefficient3_c3")]
public System.Nullable<float> Coefficient3C3 { get; set; } = null;
        

[JsonProperty("coefficient4_c4")]
public System.Nullable<float> Coefficient4C4 { get; set; } = null;
        

[JsonProperty("minimum_value_of_qfan")]
public System.Nullable<float> MinimumValueOfQfan { get; set; } = null;
        

[JsonProperty("maximum_value_of_qfan")]
public System.Nullable<float> MaximumValueOfQfan { get; set; } = null;
        

[JsonProperty("minimum_value_of_psm")]
public System.Nullable<float> MinimumValueOfPsm { get; set; } = null;
        

[JsonProperty("maximum_value_of_psm")]
public System.Nullable<float> MaximumValueOfPsm { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
    }
    
    [Description(@"Exponential-modified skew normal curve with one independent variable. Input consists of the curve name, the four coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = see Input Output Reference")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_ExponentialSkewNormal : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_c1")]
public System.Nullable<float> Coefficient1C1 { get; set; } = null;
        

[JsonProperty("coefficient2_c2")]
public System.Nullable<float> Coefficient2C2 { get; set; } = null;
        

[JsonProperty("coefficient3_c3")]
public System.Nullable<float> Coefficient3C3 { get; set; } = null;
        

[JsonProperty("coefficient4_c4")]
public System.Nullable<float> Coefficient4C4 { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_ExponentialSkewNormal_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_ExponentialSkewNormal_InputUnitTypeForX)Enum.Parse(typeof(Curve_ExponentialSkewNormal_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_ExponentialSkewNormal_OutputUnitType OutputUnitType { get; set; } = (Curve_ExponentialSkewNormal_OutputUnitType)Enum.Parse(typeof(Curve_ExponentialSkewNormal_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_ExponentialSkewNormal_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
    }
    
    public enum Curve_ExponentialSkewNormal_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Sigmoid curve with one independent variable. Input consists of the curve name, the five coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = C1+C2/[1+exp((C3-x)/C4)]**C5")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_Sigmoid : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_c1")]
public System.Nullable<float> Coefficient1C1 { get; set; } = null;
        

[JsonProperty("coefficient2_c2")]
public System.Nullable<float> Coefficient2C2 { get; set; } = null;
        

[JsonProperty("coefficient3_c3")]
public System.Nullable<float> Coefficient3C3 { get; set; } = null;
        

[JsonProperty("coefficient4_c4")]
public System.Nullable<float> Coefficient4C4 { get; set; } = null;
        

[JsonProperty("coefficient5_c5")]
public System.Nullable<float> Coefficient5C5 { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Sigmoid_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Sigmoid_InputUnitTypeForX)Enum.Parse(typeof(Curve_Sigmoid_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_Sigmoid_OutputUnitType OutputUnitType { get; set; } = (Curve_Sigmoid_OutputUnitType)Enum.Parse(typeof(Curve_Sigmoid_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_Sigmoid_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
    }
    
    public enum Curve_Sigmoid_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Rectangular hyperbola type 1 curve with one independent variable. Input consists of the curve name, the three coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = ((C1*x)/(C2+x))+C3")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_RectangularHyperbola1 : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_c1")]
public System.Nullable<float> Coefficient1C1 { get; set; } = null;
        

[JsonProperty("coefficient2_c2")]
public System.Nullable<float> Coefficient2C2 { get; set; } = null;
        

[JsonProperty("coefficient3_c3")]
public System.Nullable<float> Coefficient3C3 { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_RectangularHyperbola1_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_RectangularHyperbola1_InputUnitTypeForX)Enum.Parse(typeof(Curve_RectangularHyperbola1_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_RectangularHyperbola1_OutputUnitType OutputUnitType { get; set; } = (Curve_RectangularHyperbola1_OutputUnitType)Enum.Parse(typeof(Curve_RectangularHyperbola1_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_RectangularHyperbola1_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
    }
    
    public enum Curve_RectangularHyperbola1_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Rectangular hyperbola type 2 curve with one independent variable. Input consists of the curve name, the three coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = ((C1*x)/(C2+x))+(C3*x)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_RectangularHyperbola2 : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_c1")]
public System.Nullable<float> Coefficient1C1 { get; set; } = null;
        

[JsonProperty("coefficient2_c2")]
public System.Nullable<float> Coefficient2C2 { get; set; } = null;
        

[JsonProperty("coefficient3_c3")]
public System.Nullable<float> Coefficient3C3 { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_RectangularHyperbola2_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_RectangularHyperbola2_InputUnitTypeForX)Enum.Parse(typeof(Curve_RectangularHyperbola2_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_RectangularHyperbola2_OutputUnitType OutputUnitType { get; set; } = (Curve_RectangularHyperbola2_OutputUnitType)Enum.Parse(typeof(Curve_RectangularHyperbola2_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_RectangularHyperbola2_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
    }
    
    public enum Curve_RectangularHyperbola2_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Exponential decay curve with one independent variable. Input consists of the curve name, the three coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = C1+C2*exp(C3*x)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_ExponentialDecay : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_c1")]
public System.Nullable<float> Coefficient1C1 { get; set; } = null;
        

[JsonProperty("coefficient2_c2")]
public System.Nullable<float> Coefficient2C2 { get; set; } = null;
        

[JsonProperty("coefficient3_c3")]
public System.Nullable<float> Coefficient3C3 { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_ExponentialDecay_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_ExponentialDecay_InputUnitTypeForX)Enum.Parse(typeof(Curve_ExponentialDecay_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_ExponentialDecay_OutputUnitType OutputUnitType { get; set; } = (Curve_ExponentialDecay_OutputUnitType)Enum.Parse(typeof(Curve_ExponentialDecay_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_ExponentialDecay_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
    }
    
    public enum Curve_ExponentialDecay_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"Double exponential decay curve with one independent variable. Input consists of the curve name, the five coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = C1+C2*exp(C3*x)+C4*exp(C5*x)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_DoubleExponentialDecay : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_c1")]
public System.Nullable<float> Coefficient1C1 { get; set; } = null;
        

[JsonProperty("coefficient2_c2")]
public System.Nullable<float> Coefficient2C2 { get; set; } = null;
        

[JsonProperty("coefficient3_c3")]
public System.Nullable<float> Coefficient3C3 { get; set; } = null;
        

[JsonProperty("coefficient4_c4")]
public System.Nullable<float> Coefficient4C4 { get; set; } = null;
        

[JsonProperty("coefficient5_c5")]
public System.Nullable<float> Coefficient5C5 { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_DoubleExponentialDecay_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_DoubleExponentialDecay_InputUnitTypeForX)Enum.Parse(typeof(Curve_DoubleExponentialDecay_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_DoubleExponentialDecay_OutputUnitType OutputUnitType { get; set; } = (Curve_DoubleExponentialDecay_OutputUnitType)Enum.Parse(typeof(Curve_DoubleExponentialDecay_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_DoubleExponentialDecay_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
    }
    
    public enum Curve_DoubleExponentialDecay_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
    
    [Description(@"This chiller part-load performance curve has three independent variables. Input consists of the curve name, the twelve coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*x + C3*x**2 + C4*y + C5*y**2 + C6*x*y + C7*x**3 + C8*y**3 + C9*x**2*y + C10*x*y**2 + C11*x**2*y**2 + C12*z*y**3 x = dT* = normalized fractional Lift = dT / dTref y = PLR = part load ratio (cooling load/steady state capacity) z = Tdev* = normalized Tdev = Tdev / dTref Where: dT = Lift = Leaving Condenser Water Temperature - Leaving Chilled Water Temperature dTref = dT at the reference condition Tdev = Leaving Chilled Water Temperature - Reference Chilled Water Temperature")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_ChillerPartLoadWithLift : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[JsonProperty("coefficient1_c1")]
public System.Nullable<float> Coefficient1C1 { get; set; } = null;
        

[JsonProperty("coefficient2_c2")]
public System.Nullable<float> Coefficient2C2 { get; set; } = null;
        

[JsonProperty("coefficient3_c3")]
public System.Nullable<float> Coefficient3C3 { get; set; } = null;
        

[JsonProperty("coefficient4_c4")]
public System.Nullable<float> Coefficient4C4 { get; set; } = null;
        

[JsonProperty("coefficient5_c5")]
public System.Nullable<float> Coefficient5C5 { get; set; } = null;
        

[JsonProperty("coefficient6_c6")]
public System.Nullable<float> Coefficient6C6 { get; set; } = null;
        

[JsonProperty("coefficient7_c7")]
public System.Nullable<float> Coefficient7C7 { get; set; } = null;
        

[JsonProperty("coefficient8_c8")]
public System.Nullable<float> Coefficient8C8 { get; set; } = null;
        

[JsonProperty("coefficient9_c9")]
public System.Nullable<float> Coefficient9C9 { get; set; } = null;
        

[JsonProperty("coefficient10_c10")]
public System.Nullable<float> Coefficient10C10 { get; set; } = null;
        

[JsonProperty("coefficient11_c11")]
public System.Nullable<float> Coefficient11C11 { get; set; } = null;
        

[JsonProperty("coefficient12_c12")]
public System.Nullable<float> Coefficient12C12 { get; set; } = null;
        

[JsonProperty("minimum_value_of_x")]
public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

[JsonProperty("maximum_value_of_x")]
public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

[JsonProperty("minimum_value_of_y")]
public System.Nullable<float> MinimumValueOfY { get; set; } = null;
        

[JsonProperty("maximum_value_of_y")]
public System.Nullable<float> MaximumValueOfY { get; set; } = null;
        

[JsonProperty("minimum_value_of_z")]
public System.Nullable<float> MinimumValueOfZ { get; set; } = null;
        

[JsonProperty("maximum_value_of_z")]
public System.Nullable<float> MaximumValueOfZ { get; set; } = null;
        

[Description("Specify the minimum value calculated by this curve object")]
[JsonProperty("minimum_curve_output")]
public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

[Description("Specify the maximum value calculated by this curve object")]
[JsonProperty("maximum_curve_output")]
public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

[JsonProperty("input_unit_type_for_x")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_ChillerPartLoadWithLift_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_ChillerPartLoadWithLift_InputUnitTypeForX)Enum.Parse(typeof(Curve_ChillerPartLoadWithLift_InputUnitTypeForX), "Dimensionless");
        

[JsonProperty("input_unit_type_for_y")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_ChillerPartLoadWithLift_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_ChillerPartLoadWithLift_InputUnitTypeForY)Enum.Parse(typeof(Curve_ChillerPartLoadWithLift_InputUnitTypeForY), "Dimensionless");
        

[JsonProperty("input_unit_type_for_z")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_ChillerPartLoadWithLift_InputUnitTypeForZ InputUnitTypeForZ { get; set; } = (Curve_ChillerPartLoadWithLift_InputUnitTypeForZ)Enum.Parse(typeof(Curve_ChillerPartLoadWithLift_InputUnitTypeForZ), "Dimensionless");
        

[JsonProperty("output_unit_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Curve_ChillerPartLoadWithLift_OutputUnitType OutputUnitType { get; set; } = (Curve_ChillerPartLoadWithLift_OutputUnitType)Enum.Parse(typeof(Curve_ChillerPartLoadWithLift_OutputUnitType), "Dimensionless");
    }
    
    public enum Curve_ChillerPartLoadWithLift_InputUnitTypeForX
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
    }
    
    public enum Curve_ChillerPartLoadWithLift_InputUnitTypeForY
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
    }
    
    public enum Curve_ChillerPartLoadWithLift_InputUnitTypeForZ
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 1,
    }
    
    public enum Curve_ChillerPartLoadWithLift_OutputUnitType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
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
