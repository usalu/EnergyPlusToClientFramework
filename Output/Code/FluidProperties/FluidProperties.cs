namespace BH.oM.Adapters.EnergyPlus.FluidProperties
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
    
    
    [Description("potential fluid name/type in the input file repeat this object for each fluid")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FluidProperties_Name : BHoMObject
    {
        

[JsonProperty(PropertyName="fluid_name")]
public string FluidName { get; set; } = "";
        

[JsonProperty(PropertyName="fluid_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public FluidProperties_Name_FluidType FluidType { get; set; } = (FluidProperties_Name_FluidType)Enum.Parse(typeof(FluidProperties_Name_FluidType), "Glycol");
    }
    
    public enum FluidProperties_Name_FluidType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Glycol")]
        Glycol = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Refrigerant")]
        Refrigerant = 1,
    }
    
    [Description("glycol and what concentration it is")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FluidProperties_GlycolConcentration : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("or UserDefined Fluid (must show up as a glycol in FluidProperties:Name object)")]
[JsonProperty(PropertyName="glycol_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public FluidProperties_GlycolConcentration_GlycolType GlycolType { get; set; } = (FluidProperties_GlycolConcentration_GlycolType)Enum.Parse(typeof(FluidProperties_GlycolConcentration_GlycolType), "EthyleneGlycol");
        

[JsonProperty(PropertyName="user_defined_glycol_name")]
public string UserDefinedGlycolName { get; set; } = "";
        

[JsonProperty(PropertyName="glycol_concentration")]
public System.Nullable<float> GlycolConcentration { get; set; } = null;
    }
    
    public enum FluidProperties_GlycolConcentration_GlycolType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="EthyleneGlycol")]
        EthyleneGlycol = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PropyleneGlycol")]
        PropyleneGlycol = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="UserDefinedGlycolType")]
        UserDefinedGlycolType = 2,
    }
    
    [Description(@"property values for fluid properties list of up to 250 temperatures, note that number of property values must match the number of properties in other words, there must be a one-to-one correspondence between the property values in this list and the actual properties list in other syntax degrees C (for all temperature inputs)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FluidProperties_Temperatures : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="temperature_1")]
public System.Nullable<float> Temperature1 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_2")]
public System.Nullable<float> Temperature2 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_3")]
public System.Nullable<float> Temperature3 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_4")]
public System.Nullable<float> Temperature4 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_5")]
public System.Nullable<float> Temperature5 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_6")]
public System.Nullable<float> Temperature6 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_7")]
public System.Nullable<float> Temperature7 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_8")]
public System.Nullable<float> Temperature8 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_9")]
public System.Nullable<float> Temperature9 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_10")]
public System.Nullable<float> Temperature10 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_11")]
public System.Nullable<float> Temperature11 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_12")]
public System.Nullable<float> Temperature12 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_13")]
public System.Nullable<float> Temperature13 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_14")]
public System.Nullable<float> Temperature14 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_15")]
public System.Nullable<float> Temperature15 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_16")]
public System.Nullable<float> Temperature16 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_17")]
public System.Nullable<float> Temperature17 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_18")]
public System.Nullable<float> Temperature18 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_19")]
public System.Nullable<float> Temperature19 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_20")]
public System.Nullable<float> Temperature20 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_21")]
public System.Nullable<float> Temperature21 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_22")]
public System.Nullable<float> Temperature22 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_23")]
public System.Nullable<float> Temperature23 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_24")]
public System.Nullable<float> Temperature24 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_25")]
public System.Nullable<float> Temperature25 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_26")]
public System.Nullable<float> Temperature26 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_27")]
public System.Nullable<float> Temperature27 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_28")]
public System.Nullable<float> Temperature28 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_29")]
public System.Nullable<float> Temperature29 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_30")]
public System.Nullable<float> Temperature30 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_31")]
public System.Nullable<float> Temperature31 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_32")]
public System.Nullable<float> Temperature32 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_33")]
public System.Nullable<float> Temperature33 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_34")]
public System.Nullable<float> Temperature34 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_35")]
public System.Nullable<float> Temperature35 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_36")]
public System.Nullable<float> Temperature36 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_37")]
public System.Nullable<float> Temperature37 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_38")]
public System.Nullable<float> Temperature38 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_39")]
public System.Nullable<float> Temperature39 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_40")]
public System.Nullable<float> Temperature40 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_41")]
public System.Nullable<float> Temperature41 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_42")]
public System.Nullable<float> Temperature42 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_43")]
public System.Nullable<float> Temperature43 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_44")]
public System.Nullable<float> Temperature44 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_45")]
public System.Nullable<float> Temperature45 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_46")]
public System.Nullable<float> Temperature46 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_47")]
public System.Nullable<float> Temperature47 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_48")]
public System.Nullable<float> Temperature48 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_49")]
public System.Nullable<float> Temperature49 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_50")]
public System.Nullable<float> Temperature50 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_51")]
public System.Nullable<float> Temperature51 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_52")]
public System.Nullable<float> Temperature52 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_53")]
public System.Nullable<float> Temperature53 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_54")]
public System.Nullable<float> Temperature54 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_55")]
public System.Nullable<float> Temperature55 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_56")]
public System.Nullable<float> Temperature56 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_57")]
public System.Nullable<float> Temperature57 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_58")]
public System.Nullable<float> Temperature58 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_59")]
public System.Nullable<float> Temperature59 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_60")]
public System.Nullable<float> Temperature60 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_61")]
public System.Nullable<float> Temperature61 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_62")]
public System.Nullable<float> Temperature62 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_63")]
public System.Nullable<float> Temperature63 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_64")]
public System.Nullable<float> Temperature64 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_65")]
public System.Nullable<float> Temperature65 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_66")]
public System.Nullable<float> Temperature66 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_67")]
public System.Nullable<float> Temperature67 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_68")]
public System.Nullable<float> Temperature68 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_69")]
public System.Nullable<float> Temperature69 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_70")]
public System.Nullable<float> Temperature70 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_71")]
public System.Nullable<float> Temperature71 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_72")]
public System.Nullable<float> Temperature72 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_73")]
public System.Nullable<float> Temperature73 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_74")]
public System.Nullable<float> Temperature74 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_75")]
public System.Nullable<float> Temperature75 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_76")]
public System.Nullable<float> Temperature76 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_77")]
public System.Nullable<float> Temperature77 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_78")]
public System.Nullable<float> Temperature78 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_79")]
public System.Nullable<float> Temperature79 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_80")]
public System.Nullable<float> Temperature80 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_81")]
public System.Nullable<float> Temperature81 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_82")]
public System.Nullable<float> Temperature82 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_83")]
public System.Nullable<float> Temperature83 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_84")]
public System.Nullable<float> Temperature84 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_85")]
public System.Nullable<float> Temperature85 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_86")]
public System.Nullable<float> Temperature86 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_87")]
public System.Nullable<float> Temperature87 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_88")]
public System.Nullable<float> Temperature88 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_89")]
public System.Nullable<float> Temperature89 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_90")]
public System.Nullable<float> Temperature90 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_91")]
public System.Nullable<float> Temperature91 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_92")]
public System.Nullable<float> Temperature92 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_93")]
public System.Nullable<float> Temperature93 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_94")]
public System.Nullable<float> Temperature94 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_95")]
public System.Nullable<float> Temperature95 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_96")]
public System.Nullable<float> Temperature96 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_97")]
public System.Nullable<float> Temperature97 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_98")]
public System.Nullable<float> Temperature98 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_99")]
public System.Nullable<float> Temperature99 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_100")]
public System.Nullable<float> Temperature100 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_101")]
public System.Nullable<float> Temperature101 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_102")]
public System.Nullable<float> Temperature102 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_103")]
public System.Nullable<float> Temperature103 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_104")]
public System.Nullable<float> Temperature104 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_105")]
public System.Nullable<float> Temperature105 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_106")]
public System.Nullable<float> Temperature106 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_107")]
public System.Nullable<float> Temperature107 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_108")]
public System.Nullable<float> Temperature108 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_109")]
public System.Nullable<float> Temperature109 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_110")]
public System.Nullable<float> Temperature110 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_111")]
public System.Nullable<float> Temperature111 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_112")]
public System.Nullable<float> Temperature112 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_113")]
public System.Nullable<float> Temperature113 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_114")]
public System.Nullable<float> Temperature114 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_115")]
public System.Nullable<float> Temperature115 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_116")]
public System.Nullable<float> Temperature116 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_117")]
public System.Nullable<float> Temperature117 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_118")]
public System.Nullable<float> Temperature118 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_119")]
public System.Nullable<float> Temperature119 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_120")]
public System.Nullable<float> Temperature120 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_121")]
public System.Nullable<float> Temperature121 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_122")]
public System.Nullable<float> Temperature122 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_123")]
public System.Nullable<float> Temperature123 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_124")]
public System.Nullable<float> Temperature124 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_125")]
public System.Nullable<float> Temperature125 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_126")]
public System.Nullable<float> Temperature126 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_127")]
public System.Nullable<float> Temperature127 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_128")]
public System.Nullable<float> Temperature128 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_129")]
public System.Nullable<float> Temperature129 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_130")]
public System.Nullable<float> Temperature130 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_131")]
public System.Nullable<float> Temperature131 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_132")]
public System.Nullable<float> Temperature132 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_133")]
public System.Nullable<float> Temperature133 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_134")]
public System.Nullable<float> Temperature134 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_135")]
public System.Nullable<float> Temperature135 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_136")]
public System.Nullable<float> Temperature136 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_137")]
public System.Nullable<float> Temperature137 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_138")]
public System.Nullable<float> Temperature138 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_139")]
public System.Nullable<float> Temperature139 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_140")]
public System.Nullable<float> Temperature140 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_141")]
public System.Nullable<float> Temperature141 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_142")]
public System.Nullable<float> Temperature142 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_143")]
public System.Nullable<float> Temperature143 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_144")]
public System.Nullable<float> Temperature144 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_145")]
public System.Nullable<float> Temperature145 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_146")]
public System.Nullable<float> Temperature146 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_147")]
public System.Nullable<float> Temperature147 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_148")]
public System.Nullable<float> Temperature148 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_149")]
public System.Nullable<float> Temperature149 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_150")]
public System.Nullable<float> Temperature150 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_151")]
public System.Nullable<float> Temperature151 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_152")]
public System.Nullable<float> Temperature152 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_153")]
public System.Nullable<float> Temperature153 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_154")]
public System.Nullable<float> Temperature154 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_155")]
public System.Nullable<float> Temperature155 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_156")]
public System.Nullable<float> Temperature156 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_157")]
public System.Nullable<float> Temperature157 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_158")]
public System.Nullable<float> Temperature158 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_159")]
public System.Nullable<float> Temperature159 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_160")]
public System.Nullable<float> Temperature160 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_161")]
public System.Nullable<float> Temperature161 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_162")]
public System.Nullable<float> Temperature162 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_163")]
public System.Nullable<float> Temperature163 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_164")]
public System.Nullable<float> Temperature164 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_165")]
public System.Nullable<float> Temperature165 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_166")]
public System.Nullable<float> Temperature166 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_167")]
public System.Nullable<float> Temperature167 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_168")]
public System.Nullable<float> Temperature168 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_169")]
public System.Nullable<float> Temperature169 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_170")]
public System.Nullable<float> Temperature170 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_171")]
public System.Nullable<float> Temperature171 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_172")]
public System.Nullable<float> Temperature172 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_173")]
public System.Nullable<float> Temperature173 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_174")]
public System.Nullable<float> Temperature174 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_175")]
public System.Nullable<float> Temperature175 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_176")]
public System.Nullable<float> Temperature176 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_177")]
public System.Nullable<float> Temperature177 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_178")]
public System.Nullable<float> Temperature178 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_179")]
public System.Nullable<float> Temperature179 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_180")]
public System.Nullable<float> Temperature180 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_181")]
public System.Nullable<float> Temperature181 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_182")]
public System.Nullable<float> Temperature182 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_183")]
public System.Nullable<float> Temperature183 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_184")]
public System.Nullable<float> Temperature184 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_185")]
public System.Nullable<float> Temperature185 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_186")]
public System.Nullable<float> Temperature186 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_187")]
public System.Nullable<float> Temperature187 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_188")]
public System.Nullable<float> Temperature188 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_189")]
public System.Nullable<float> Temperature189 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_190")]
public System.Nullable<float> Temperature190 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_191")]
public System.Nullable<float> Temperature191 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_192")]
public System.Nullable<float> Temperature192 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_193")]
public System.Nullable<float> Temperature193 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_194")]
public System.Nullable<float> Temperature194 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_195")]
public System.Nullable<float> Temperature195 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_196")]
public System.Nullable<float> Temperature196 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_197")]
public System.Nullable<float> Temperature197 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_198")]
public System.Nullable<float> Temperature198 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_199")]
public System.Nullable<float> Temperature199 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_200")]
public System.Nullable<float> Temperature200 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_201")]
public System.Nullable<float> Temperature201 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_202")]
public System.Nullable<float> Temperature202 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_203")]
public System.Nullable<float> Temperature203 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_204")]
public System.Nullable<float> Temperature204 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_205")]
public System.Nullable<float> Temperature205 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_206")]
public System.Nullable<float> Temperature206 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_207")]
public System.Nullable<float> Temperature207 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_208")]
public System.Nullable<float> Temperature208 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_209")]
public System.Nullable<float> Temperature209 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_210")]
public System.Nullable<float> Temperature210 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_211")]
public System.Nullable<float> Temperature211 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_212")]
public System.Nullable<float> Temperature212 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_213")]
public System.Nullable<float> Temperature213 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_214")]
public System.Nullable<float> Temperature214 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_215")]
public System.Nullable<float> Temperature215 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_216")]
public System.Nullable<float> Temperature216 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_217")]
public System.Nullable<float> Temperature217 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_218")]
public System.Nullable<float> Temperature218 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_219")]
public System.Nullable<float> Temperature219 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_220")]
public System.Nullable<float> Temperature220 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_221")]
public System.Nullable<float> Temperature221 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_222")]
public System.Nullable<float> Temperature222 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_223")]
public System.Nullable<float> Temperature223 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_224")]
public System.Nullable<float> Temperature224 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_225")]
public System.Nullable<float> Temperature225 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_226")]
public System.Nullable<float> Temperature226 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_227")]
public System.Nullable<float> Temperature227 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_228")]
public System.Nullable<float> Temperature228 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_229")]
public System.Nullable<float> Temperature229 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_230")]
public System.Nullable<float> Temperature230 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_231")]
public System.Nullable<float> Temperature231 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_232")]
public System.Nullable<float> Temperature232 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_233")]
public System.Nullable<float> Temperature233 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_234")]
public System.Nullable<float> Temperature234 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_235")]
public System.Nullable<float> Temperature235 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_236")]
public System.Nullable<float> Temperature236 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_237")]
public System.Nullable<float> Temperature237 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_238")]
public System.Nullable<float> Temperature238 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_239")]
public System.Nullable<float> Temperature239 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_240")]
public System.Nullable<float> Temperature240 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_241")]
public System.Nullable<float> Temperature241 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_242")]
public System.Nullable<float> Temperature242 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_243")]
public System.Nullable<float> Temperature243 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_244")]
public System.Nullable<float> Temperature244 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_245")]
public System.Nullable<float> Temperature245 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_246")]
public System.Nullable<float> Temperature246 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_247")]
public System.Nullable<float> Temperature247 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_248")]
public System.Nullable<float> Temperature248 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_249")]
public System.Nullable<float> Temperature249 { get; set; } = null;
        

[JsonProperty(PropertyName="temperature_250")]
public System.Nullable<float> Temperature250 { get; set; } = null;
    }
    
    [Description("fluid properties for the saturated region")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FluidProperties_Saturated : BHoMObject
    {
        

[JsonProperty(PropertyName="fluid_name")]
public string FluidName { get; set; } = "";
        

[Description("Enthalpy Units are J/kg Density Units are kg/m3 SpecificHeat Units are J/kg-K Pre" +
    "ssure Units are Pa")]
[JsonProperty(PropertyName="fluid_property_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public FluidProperties_Saturated_FluidPropertyType FluidPropertyType { get; set; } = (FluidProperties_Saturated_FluidPropertyType)Enum.Parse(typeof(FluidProperties_Saturated_FluidPropertyType), "Density");
        

[Description("Fluid=saturated fluid FluidGas=saturated vapor")]
[JsonProperty(PropertyName="fluid_phase", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public FluidProperties_Saturated_FluidPhase FluidPhase { get; set; } = (FluidProperties_Saturated_FluidPhase)Enum.Parse(typeof(FluidProperties_Saturated_FluidPhase), "Fluid");
        

[Description("Enter the name of a FluidProperties:Temperatures object.")]
[JsonProperty(PropertyName="temperature_values_name")]
public string TemperatureValuesName { get; set; } = "";
        

[JsonProperty(PropertyName="property_value_1")]
public System.Nullable<float> PropertyValue1 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_2")]
public System.Nullable<float> PropertyValue2 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_3")]
public System.Nullable<float> PropertyValue3 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_4")]
public System.Nullable<float> PropertyValue4 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_5")]
public System.Nullable<float> PropertyValue5 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_6")]
public System.Nullable<float> PropertyValue6 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_7")]
public System.Nullable<float> PropertyValue7 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_8")]
public System.Nullable<float> PropertyValue8 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_9")]
public System.Nullable<float> PropertyValue9 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_10")]
public System.Nullable<float> PropertyValue10 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_11")]
public System.Nullable<float> PropertyValue11 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_12")]
public System.Nullable<float> PropertyValue12 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_13")]
public System.Nullable<float> PropertyValue13 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_14")]
public System.Nullable<float> PropertyValue14 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_15")]
public System.Nullable<float> PropertyValue15 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_16")]
public System.Nullable<float> PropertyValue16 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_17")]
public System.Nullable<float> PropertyValue17 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_18")]
public System.Nullable<float> PropertyValue18 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_19")]
public System.Nullable<float> PropertyValue19 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_20")]
public System.Nullable<float> PropertyValue20 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_21")]
public System.Nullable<float> PropertyValue21 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_22")]
public System.Nullable<float> PropertyValue22 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_23")]
public System.Nullable<float> PropertyValue23 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_24")]
public System.Nullable<float> PropertyValue24 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_25")]
public System.Nullable<float> PropertyValue25 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_26")]
public System.Nullable<float> PropertyValue26 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_27")]
public System.Nullable<float> PropertyValue27 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_28")]
public System.Nullable<float> PropertyValue28 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_29")]
public System.Nullable<float> PropertyValue29 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_30")]
public System.Nullable<float> PropertyValue30 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_31")]
public System.Nullable<float> PropertyValue31 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_32")]
public System.Nullable<float> PropertyValue32 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_33")]
public System.Nullable<float> PropertyValue33 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_34")]
public System.Nullable<float> PropertyValue34 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_35")]
public System.Nullable<float> PropertyValue35 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_36")]
public System.Nullable<float> PropertyValue36 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_37")]
public System.Nullable<float> PropertyValue37 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_38")]
public System.Nullable<float> PropertyValue38 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_39")]
public System.Nullable<float> PropertyValue39 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_40")]
public System.Nullable<float> PropertyValue40 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_41")]
public System.Nullable<float> PropertyValue41 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_42")]
public System.Nullable<float> PropertyValue42 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_43")]
public System.Nullable<float> PropertyValue43 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_44")]
public System.Nullable<float> PropertyValue44 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_45")]
public System.Nullable<float> PropertyValue45 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_46")]
public System.Nullable<float> PropertyValue46 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_47")]
public System.Nullable<float> PropertyValue47 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_48")]
public System.Nullable<float> PropertyValue48 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_49")]
public System.Nullable<float> PropertyValue49 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_50")]
public System.Nullable<float> PropertyValue50 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_51")]
public System.Nullable<float> PropertyValue51 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_52")]
public System.Nullable<float> PropertyValue52 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_53")]
public System.Nullable<float> PropertyValue53 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_54")]
public System.Nullable<float> PropertyValue54 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_55")]
public System.Nullable<float> PropertyValue55 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_56")]
public System.Nullable<float> PropertyValue56 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_57")]
public System.Nullable<float> PropertyValue57 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_58")]
public System.Nullable<float> PropertyValue58 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_59")]
public System.Nullable<float> PropertyValue59 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_60")]
public System.Nullable<float> PropertyValue60 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_61")]
public System.Nullable<float> PropertyValue61 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_62")]
public System.Nullable<float> PropertyValue62 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_63")]
public System.Nullable<float> PropertyValue63 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_64")]
public System.Nullable<float> PropertyValue64 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_65")]
public System.Nullable<float> PropertyValue65 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_66")]
public System.Nullable<float> PropertyValue66 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_67")]
public System.Nullable<float> PropertyValue67 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_68")]
public System.Nullable<float> PropertyValue68 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_69")]
public System.Nullable<float> PropertyValue69 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_70")]
public System.Nullable<float> PropertyValue70 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_71")]
public System.Nullable<float> PropertyValue71 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_72")]
public System.Nullable<float> PropertyValue72 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_73")]
public System.Nullable<float> PropertyValue73 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_74")]
public System.Nullable<float> PropertyValue74 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_75")]
public System.Nullable<float> PropertyValue75 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_76")]
public System.Nullable<float> PropertyValue76 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_77")]
public System.Nullable<float> PropertyValue77 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_78")]
public System.Nullable<float> PropertyValue78 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_79")]
public System.Nullable<float> PropertyValue79 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_80")]
public System.Nullable<float> PropertyValue80 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_81")]
public System.Nullable<float> PropertyValue81 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_82")]
public System.Nullable<float> PropertyValue82 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_83")]
public System.Nullable<float> PropertyValue83 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_84")]
public System.Nullable<float> PropertyValue84 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_85")]
public System.Nullable<float> PropertyValue85 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_86")]
public System.Nullable<float> PropertyValue86 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_87")]
public System.Nullable<float> PropertyValue87 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_88")]
public System.Nullable<float> PropertyValue88 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_89")]
public System.Nullable<float> PropertyValue89 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_90")]
public System.Nullable<float> PropertyValue90 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_91")]
public System.Nullable<float> PropertyValue91 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_92")]
public System.Nullable<float> PropertyValue92 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_93")]
public System.Nullable<float> PropertyValue93 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_94")]
public System.Nullable<float> PropertyValue94 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_95")]
public System.Nullable<float> PropertyValue95 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_96")]
public System.Nullable<float> PropertyValue96 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_97")]
public System.Nullable<float> PropertyValue97 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_98")]
public System.Nullable<float> PropertyValue98 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_99")]
public System.Nullable<float> PropertyValue99 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_100")]
public System.Nullable<float> PropertyValue100 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_101")]
public System.Nullable<float> PropertyValue101 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_102")]
public System.Nullable<float> PropertyValue102 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_103")]
public System.Nullable<float> PropertyValue103 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_104")]
public System.Nullable<float> PropertyValue104 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_105")]
public System.Nullable<float> PropertyValue105 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_106")]
public System.Nullable<float> PropertyValue106 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_107")]
public System.Nullable<float> PropertyValue107 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_108")]
public System.Nullable<float> PropertyValue108 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_109")]
public System.Nullable<float> PropertyValue109 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_110")]
public System.Nullable<float> PropertyValue110 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_111")]
public System.Nullable<float> PropertyValue111 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_112")]
public System.Nullable<float> PropertyValue112 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_113")]
public System.Nullable<float> PropertyValue113 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_114")]
public System.Nullable<float> PropertyValue114 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_115")]
public System.Nullable<float> PropertyValue115 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_116")]
public System.Nullable<float> PropertyValue116 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_117")]
public System.Nullable<float> PropertyValue117 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_118")]
public System.Nullable<float> PropertyValue118 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_119")]
public System.Nullable<float> PropertyValue119 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_120")]
public System.Nullable<float> PropertyValue120 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_121")]
public System.Nullable<float> PropertyValue121 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_122")]
public System.Nullable<float> PropertyValue122 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_123")]
public System.Nullable<float> PropertyValue123 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_124")]
public System.Nullable<float> PropertyValue124 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_125")]
public System.Nullable<float> PropertyValue125 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_126")]
public System.Nullable<float> PropertyValue126 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_127")]
public System.Nullable<float> PropertyValue127 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_128")]
public System.Nullable<float> PropertyValue128 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_129")]
public System.Nullable<float> PropertyValue129 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_130")]
public System.Nullable<float> PropertyValue130 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_131")]
public System.Nullable<float> PropertyValue131 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_132")]
public System.Nullable<float> PropertyValue132 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_133")]
public System.Nullable<float> PropertyValue133 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_134")]
public System.Nullable<float> PropertyValue134 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_135")]
public System.Nullable<float> PropertyValue135 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_136")]
public System.Nullable<float> PropertyValue136 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_137")]
public System.Nullable<float> PropertyValue137 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_138")]
public System.Nullable<float> PropertyValue138 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_139")]
public System.Nullable<float> PropertyValue139 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_140")]
public System.Nullable<float> PropertyValue140 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_141")]
public System.Nullable<float> PropertyValue141 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_142")]
public System.Nullable<float> PropertyValue142 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_143")]
public System.Nullable<float> PropertyValue143 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_144")]
public System.Nullable<float> PropertyValue144 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_145")]
public System.Nullable<float> PropertyValue145 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_146")]
public System.Nullable<float> PropertyValue146 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_147")]
public System.Nullable<float> PropertyValue147 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_148")]
public System.Nullable<float> PropertyValue148 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_149")]
public System.Nullable<float> PropertyValue149 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_150")]
public System.Nullable<float> PropertyValue150 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_151")]
public System.Nullable<float> PropertyValue151 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_152")]
public System.Nullable<float> PropertyValue152 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_153")]
public System.Nullable<float> PropertyValue153 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_154")]
public System.Nullable<float> PropertyValue154 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_155")]
public System.Nullable<float> PropertyValue155 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_156")]
public System.Nullable<float> PropertyValue156 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_157")]
public System.Nullable<float> PropertyValue157 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_158")]
public System.Nullable<float> PropertyValue158 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_159")]
public System.Nullable<float> PropertyValue159 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_160")]
public System.Nullable<float> PropertyValue160 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_161")]
public System.Nullable<float> PropertyValue161 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_162")]
public System.Nullable<float> PropertyValue162 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_163")]
public System.Nullable<float> PropertyValue163 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_164")]
public System.Nullable<float> PropertyValue164 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_165")]
public System.Nullable<float> PropertyValue165 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_166")]
public System.Nullable<float> PropertyValue166 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_167")]
public System.Nullable<float> PropertyValue167 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_168")]
public System.Nullable<float> PropertyValue168 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_169")]
public System.Nullable<float> PropertyValue169 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_170")]
public System.Nullable<float> PropertyValue170 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_171")]
public System.Nullable<float> PropertyValue171 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_172")]
public System.Nullable<float> PropertyValue172 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_173")]
public System.Nullable<float> PropertyValue173 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_174")]
public System.Nullable<float> PropertyValue174 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_175")]
public System.Nullable<float> PropertyValue175 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_176")]
public System.Nullable<float> PropertyValue176 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_177")]
public System.Nullable<float> PropertyValue177 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_178")]
public System.Nullable<float> PropertyValue178 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_179")]
public System.Nullable<float> PropertyValue179 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_180")]
public System.Nullable<float> PropertyValue180 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_181")]
public System.Nullable<float> PropertyValue181 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_182")]
public System.Nullable<float> PropertyValue182 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_183")]
public System.Nullable<float> PropertyValue183 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_184")]
public System.Nullable<float> PropertyValue184 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_185")]
public System.Nullable<float> PropertyValue185 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_186")]
public System.Nullable<float> PropertyValue186 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_187")]
public System.Nullable<float> PropertyValue187 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_188")]
public System.Nullable<float> PropertyValue188 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_189")]
public System.Nullable<float> PropertyValue189 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_190")]
public System.Nullable<float> PropertyValue190 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_191")]
public System.Nullable<float> PropertyValue191 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_192")]
public System.Nullable<float> PropertyValue192 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_193")]
public System.Nullable<float> PropertyValue193 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_194")]
public System.Nullable<float> PropertyValue194 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_195")]
public System.Nullable<float> PropertyValue195 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_196")]
public System.Nullable<float> PropertyValue196 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_197")]
public System.Nullable<float> PropertyValue197 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_198")]
public System.Nullable<float> PropertyValue198 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_199")]
public System.Nullable<float> PropertyValue199 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_200")]
public System.Nullable<float> PropertyValue200 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_201")]
public System.Nullable<float> PropertyValue201 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_202")]
public System.Nullable<float> PropertyValue202 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_203")]
public System.Nullable<float> PropertyValue203 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_204")]
public System.Nullable<float> PropertyValue204 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_205")]
public System.Nullable<float> PropertyValue205 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_206")]
public System.Nullable<float> PropertyValue206 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_207")]
public System.Nullable<float> PropertyValue207 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_208")]
public System.Nullable<float> PropertyValue208 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_209")]
public System.Nullable<float> PropertyValue209 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_210")]
public System.Nullable<float> PropertyValue210 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_211")]
public System.Nullable<float> PropertyValue211 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_212")]
public System.Nullable<float> PropertyValue212 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_213")]
public System.Nullable<float> PropertyValue213 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_214")]
public System.Nullable<float> PropertyValue214 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_215")]
public System.Nullable<float> PropertyValue215 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_216")]
public System.Nullable<float> PropertyValue216 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_217")]
public System.Nullable<float> PropertyValue217 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_218")]
public System.Nullable<float> PropertyValue218 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_219")]
public System.Nullable<float> PropertyValue219 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_220")]
public System.Nullable<float> PropertyValue220 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_221")]
public System.Nullable<float> PropertyValue221 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_222")]
public System.Nullable<float> PropertyValue222 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_223")]
public System.Nullable<float> PropertyValue223 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_224")]
public System.Nullable<float> PropertyValue224 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_225")]
public System.Nullable<float> PropertyValue225 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_226")]
public System.Nullable<float> PropertyValue226 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_227")]
public System.Nullable<float> PropertyValue227 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_228")]
public System.Nullable<float> PropertyValue228 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_229")]
public System.Nullable<float> PropertyValue229 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_230")]
public System.Nullable<float> PropertyValue230 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_231")]
public System.Nullable<float> PropertyValue231 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_232")]
public System.Nullable<float> PropertyValue232 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_233")]
public System.Nullable<float> PropertyValue233 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_234")]
public System.Nullable<float> PropertyValue234 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_235")]
public System.Nullable<float> PropertyValue235 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_236")]
public System.Nullable<float> PropertyValue236 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_237")]
public System.Nullable<float> PropertyValue237 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_238")]
public System.Nullable<float> PropertyValue238 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_239")]
public System.Nullable<float> PropertyValue239 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_240")]
public System.Nullable<float> PropertyValue240 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_241")]
public System.Nullable<float> PropertyValue241 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_242")]
public System.Nullable<float> PropertyValue242 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_243")]
public System.Nullable<float> PropertyValue243 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_244")]
public System.Nullable<float> PropertyValue244 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_245")]
public System.Nullable<float> PropertyValue245 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_246")]
public System.Nullable<float> PropertyValue246 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_247")]
public System.Nullable<float> PropertyValue247 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_248")]
public System.Nullable<float> PropertyValue248 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_249")]
public System.Nullable<float> PropertyValue249 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_250")]
public System.Nullable<float> PropertyValue250 { get; set; } = null;
    }
    
    public enum FluidProperties_Saturated_FluidPropertyType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Density")]
        Density = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Enthalpy")]
        Enthalpy = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Pressure")]
        Pressure = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SpecificHeat")]
        SpecificHeat = 3,
    }
    
    public enum FluidProperties_Saturated_FluidPhase
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Fluid")]
        Fluid = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FluidGas")]
        FluidGas = 1,
    }
    
    [Description("fluid properties for the superheated region")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FluidProperties_Superheated : BHoMObject
    {
        

[JsonProperty(PropertyName="fluid_name")]
public string FluidName { get; set; } = "";
        

[Description("Enthalpy Units are J/kg Density Units are kg/m3")]
[JsonProperty(PropertyName="fluid_property_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public FluidProperties_Superheated_FluidPropertyType FluidPropertyType { get; set; } = (FluidProperties_Superheated_FluidPropertyType)Enum.Parse(typeof(FluidProperties_Superheated_FluidPropertyType), "Density");
        

[Description("Enter the name of a FluidProperties:Temperatures object.")]
[JsonProperty(PropertyName="temperature_values_name")]
public string TemperatureValuesName { get; set; } = "";
        

[Description("pressure for this list of properties")]
[JsonProperty(PropertyName="pressure")]
public System.Nullable<float> Pressure { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_1")]
public System.Nullable<float> PropertyValue1 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_2")]
public System.Nullable<float> PropertyValue2 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_3")]
public System.Nullable<float> PropertyValue3 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_4")]
public System.Nullable<float> PropertyValue4 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_5")]
public System.Nullable<float> PropertyValue5 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_6")]
public System.Nullable<float> PropertyValue6 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_7")]
public System.Nullable<float> PropertyValue7 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_8")]
public System.Nullable<float> PropertyValue8 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_9")]
public System.Nullable<float> PropertyValue9 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_10")]
public System.Nullable<float> PropertyValue10 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_11")]
public System.Nullable<float> PropertyValue11 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_12")]
public System.Nullable<float> PropertyValue12 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_13")]
public System.Nullable<float> PropertyValue13 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_14")]
public System.Nullable<float> PropertyValue14 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_15")]
public System.Nullable<float> PropertyValue15 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_16")]
public System.Nullable<float> PropertyValue16 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_17")]
public System.Nullable<float> PropertyValue17 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_18")]
public System.Nullable<float> PropertyValue18 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_19")]
public System.Nullable<float> PropertyValue19 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_20")]
public System.Nullable<float> PropertyValue20 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_21")]
public System.Nullable<float> PropertyValue21 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_22")]
public System.Nullable<float> PropertyValue22 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_23")]
public System.Nullable<float> PropertyValue23 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_24")]
public System.Nullable<float> PropertyValue24 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_25")]
public System.Nullable<float> PropertyValue25 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_26")]
public System.Nullable<float> PropertyValue26 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_27")]
public System.Nullable<float> PropertyValue27 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_28")]
public System.Nullable<float> PropertyValue28 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_29")]
public System.Nullable<float> PropertyValue29 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_30")]
public System.Nullable<float> PropertyValue30 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_31")]
public System.Nullable<float> PropertyValue31 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_32")]
public System.Nullable<float> PropertyValue32 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_33")]
public System.Nullable<float> PropertyValue33 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_34")]
public System.Nullable<float> PropertyValue34 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_35")]
public System.Nullable<float> PropertyValue35 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_36")]
public System.Nullable<float> PropertyValue36 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_37")]
public System.Nullable<float> PropertyValue37 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_38")]
public System.Nullable<float> PropertyValue38 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_39")]
public System.Nullable<float> PropertyValue39 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_40")]
public System.Nullable<float> PropertyValue40 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_41")]
public System.Nullable<float> PropertyValue41 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_42")]
public System.Nullable<float> PropertyValue42 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_43")]
public System.Nullable<float> PropertyValue43 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_44")]
public System.Nullable<float> PropertyValue44 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_45")]
public System.Nullable<float> PropertyValue45 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_46")]
public System.Nullable<float> PropertyValue46 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_47")]
public System.Nullable<float> PropertyValue47 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_48")]
public System.Nullable<float> PropertyValue48 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_49")]
public System.Nullable<float> PropertyValue49 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_50")]
public System.Nullable<float> PropertyValue50 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_51")]
public System.Nullable<float> PropertyValue51 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_52")]
public System.Nullable<float> PropertyValue52 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_53")]
public System.Nullable<float> PropertyValue53 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_54")]
public System.Nullable<float> PropertyValue54 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_55")]
public System.Nullable<float> PropertyValue55 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_56")]
public System.Nullable<float> PropertyValue56 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_57")]
public System.Nullable<float> PropertyValue57 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_58")]
public System.Nullable<float> PropertyValue58 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_59")]
public System.Nullable<float> PropertyValue59 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_60")]
public System.Nullable<float> PropertyValue60 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_61")]
public System.Nullable<float> PropertyValue61 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_62")]
public System.Nullable<float> PropertyValue62 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_63")]
public System.Nullable<float> PropertyValue63 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_64")]
public System.Nullable<float> PropertyValue64 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_65")]
public System.Nullable<float> PropertyValue65 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_66")]
public System.Nullable<float> PropertyValue66 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_67")]
public System.Nullable<float> PropertyValue67 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_68")]
public System.Nullable<float> PropertyValue68 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_69")]
public System.Nullable<float> PropertyValue69 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_70")]
public System.Nullable<float> PropertyValue70 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_71")]
public System.Nullable<float> PropertyValue71 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_72")]
public System.Nullable<float> PropertyValue72 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_73")]
public System.Nullable<float> PropertyValue73 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_74")]
public System.Nullable<float> PropertyValue74 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_75")]
public System.Nullable<float> PropertyValue75 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_76")]
public System.Nullable<float> PropertyValue76 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_77")]
public System.Nullable<float> PropertyValue77 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_78")]
public System.Nullable<float> PropertyValue78 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_79")]
public System.Nullable<float> PropertyValue79 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_80")]
public System.Nullable<float> PropertyValue80 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_81")]
public System.Nullable<float> PropertyValue81 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_82")]
public System.Nullable<float> PropertyValue82 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_83")]
public System.Nullable<float> PropertyValue83 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_84")]
public System.Nullable<float> PropertyValue84 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_85")]
public System.Nullable<float> PropertyValue85 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_86")]
public System.Nullable<float> PropertyValue86 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_87")]
public System.Nullable<float> PropertyValue87 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_88")]
public System.Nullable<float> PropertyValue88 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_89")]
public System.Nullable<float> PropertyValue89 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_90")]
public System.Nullable<float> PropertyValue90 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_91")]
public System.Nullable<float> PropertyValue91 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_92")]
public System.Nullable<float> PropertyValue92 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_93")]
public System.Nullable<float> PropertyValue93 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_94")]
public System.Nullable<float> PropertyValue94 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_95")]
public System.Nullable<float> PropertyValue95 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_96")]
public System.Nullable<float> PropertyValue96 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_97")]
public System.Nullable<float> PropertyValue97 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_98")]
public System.Nullable<float> PropertyValue98 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_99")]
public System.Nullable<float> PropertyValue99 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_100")]
public System.Nullable<float> PropertyValue100 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_101")]
public System.Nullable<float> PropertyValue101 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_102")]
public System.Nullable<float> PropertyValue102 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_103")]
public System.Nullable<float> PropertyValue103 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_104")]
public System.Nullable<float> PropertyValue104 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_105")]
public System.Nullable<float> PropertyValue105 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_106")]
public System.Nullable<float> PropertyValue106 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_107")]
public System.Nullable<float> PropertyValue107 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_108")]
public System.Nullable<float> PropertyValue108 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_109")]
public System.Nullable<float> PropertyValue109 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_110")]
public System.Nullable<float> PropertyValue110 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_111")]
public System.Nullable<float> PropertyValue111 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_112")]
public System.Nullable<float> PropertyValue112 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_113")]
public System.Nullable<float> PropertyValue113 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_114")]
public System.Nullable<float> PropertyValue114 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_115")]
public System.Nullable<float> PropertyValue115 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_116")]
public System.Nullable<float> PropertyValue116 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_117")]
public System.Nullable<float> PropertyValue117 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_118")]
public System.Nullable<float> PropertyValue118 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_119")]
public System.Nullable<float> PropertyValue119 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_120")]
public System.Nullable<float> PropertyValue120 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_121")]
public System.Nullable<float> PropertyValue121 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_122")]
public System.Nullable<float> PropertyValue122 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_123")]
public System.Nullable<float> PropertyValue123 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_124")]
public System.Nullable<float> PropertyValue124 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_125")]
public System.Nullable<float> PropertyValue125 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_126")]
public System.Nullable<float> PropertyValue126 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_127")]
public System.Nullable<float> PropertyValue127 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_128")]
public System.Nullable<float> PropertyValue128 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_129")]
public System.Nullable<float> PropertyValue129 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_130")]
public System.Nullable<float> PropertyValue130 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_131")]
public System.Nullable<float> PropertyValue131 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_132")]
public System.Nullable<float> PropertyValue132 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_133")]
public System.Nullable<float> PropertyValue133 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_134")]
public System.Nullable<float> PropertyValue134 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_135")]
public System.Nullable<float> PropertyValue135 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_136")]
public System.Nullable<float> PropertyValue136 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_137")]
public System.Nullable<float> PropertyValue137 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_138")]
public System.Nullable<float> PropertyValue138 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_139")]
public System.Nullable<float> PropertyValue139 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_140")]
public System.Nullable<float> PropertyValue140 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_141")]
public System.Nullable<float> PropertyValue141 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_142")]
public System.Nullable<float> PropertyValue142 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_143")]
public System.Nullable<float> PropertyValue143 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_144")]
public System.Nullable<float> PropertyValue144 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_145")]
public System.Nullable<float> PropertyValue145 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_146")]
public System.Nullable<float> PropertyValue146 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_147")]
public System.Nullable<float> PropertyValue147 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_148")]
public System.Nullable<float> PropertyValue148 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_149")]
public System.Nullable<float> PropertyValue149 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_150")]
public System.Nullable<float> PropertyValue150 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_151")]
public System.Nullable<float> PropertyValue151 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_152")]
public System.Nullable<float> PropertyValue152 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_153")]
public System.Nullable<float> PropertyValue153 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_154")]
public System.Nullable<float> PropertyValue154 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_155")]
public System.Nullable<float> PropertyValue155 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_156")]
public System.Nullable<float> PropertyValue156 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_157")]
public System.Nullable<float> PropertyValue157 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_158")]
public System.Nullable<float> PropertyValue158 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_159")]
public System.Nullable<float> PropertyValue159 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_160")]
public System.Nullable<float> PropertyValue160 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_161")]
public System.Nullable<float> PropertyValue161 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_162")]
public System.Nullable<float> PropertyValue162 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_163")]
public System.Nullable<float> PropertyValue163 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_164")]
public System.Nullable<float> PropertyValue164 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_165")]
public System.Nullable<float> PropertyValue165 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_166")]
public System.Nullable<float> PropertyValue166 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_167")]
public System.Nullable<float> PropertyValue167 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_168")]
public System.Nullable<float> PropertyValue168 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_169")]
public System.Nullable<float> PropertyValue169 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_170")]
public System.Nullable<float> PropertyValue170 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_171")]
public System.Nullable<float> PropertyValue171 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_172")]
public System.Nullable<float> PropertyValue172 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_173")]
public System.Nullable<float> PropertyValue173 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_174")]
public System.Nullable<float> PropertyValue174 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_175")]
public System.Nullable<float> PropertyValue175 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_176")]
public System.Nullable<float> PropertyValue176 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_177")]
public System.Nullable<float> PropertyValue177 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_178")]
public System.Nullable<float> PropertyValue178 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_179")]
public System.Nullable<float> PropertyValue179 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_180")]
public System.Nullable<float> PropertyValue180 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_181")]
public System.Nullable<float> PropertyValue181 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_182")]
public System.Nullable<float> PropertyValue182 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_183")]
public System.Nullable<float> PropertyValue183 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_184")]
public System.Nullable<float> PropertyValue184 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_185")]
public System.Nullable<float> PropertyValue185 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_186")]
public System.Nullable<float> PropertyValue186 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_187")]
public System.Nullable<float> PropertyValue187 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_188")]
public System.Nullable<float> PropertyValue188 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_189")]
public System.Nullable<float> PropertyValue189 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_190")]
public System.Nullable<float> PropertyValue190 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_191")]
public System.Nullable<float> PropertyValue191 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_192")]
public System.Nullable<float> PropertyValue192 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_193")]
public System.Nullable<float> PropertyValue193 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_194")]
public System.Nullable<float> PropertyValue194 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_195")]
public System.Nullable<float> PropertyValue195 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_196")]
public System.Nullable<float> PropertyValue196 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_197")]
public System.Nullable<float> PropertyValue197 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_198")]
public System.Nullable<float> PropertyValue198 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_199")]
public System.Nullable<float> PropertyValue199 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_200")]
public System.Nullable<float> PropertyValue200 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_201")]
public System.Nullable<float> PropertyValue201 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_202")]
public System.Nullable<float> PropertyValue202 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_203")]
public System.Nullable<float> PropertyValue203 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_204")]
public System.Nullable<float> PropertyValue204 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_205")]
public System.Nullable<float> PropertyValue205 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_206")]
public System.Nullable<float> PropertyValue206 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_207")]
public System.Nullable<float> PropertyValue207 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_208")]
public System.Nullable<float> PropertyValue208 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_209")]
public System.Nullable<float> PropertyValue209 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_210")]
public System.Nullable<float> PropertyValue210 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_211")]
public System.Nullable<float> PropertyValue211 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_212")]
public System.Nullable<float> PropertyValue212 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_213")]
public System.Nullable<float> PropertyValue213 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_214")]
public System.Nullable<float> PropertyValue214 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_215")]
public System.Nullable<float> PropertyValue215 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_216")]
public System.Nullable<float> PropertyValue216 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_217")]
public System.Nullable<float> PropertyValue217 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_218")]
public System.Nullable<float> PropertyValue218 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_219")]
public System.Nullable<float> PropertyValue219 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_220")]
public System.Nullable<float> PropertyValue220 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_221")]
public System.Nullable<float> PropertyValue221 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_222")]
public System.Nullable<float> PropertyValue222 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_223")]
public System.Nullable<float> PropertyValue223 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_224")]
public System.Nullable<float> PropertyValue224 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_225")]
public System.Nullable<float> PropertyValue225 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_226")]
public System.Nullable<float> PropertyValue226 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_227")]
public System.Nullable<float> PropertyValue227 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_228")]
public System.Nullable<float> PropertyValue228 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_229")]
public System.Nullable<float> PropertyValue229 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_230")]
public System.Nullable<float> PropertyValue230 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_231")]
public System.Nullable<float> PropertyValue231 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_232")]
public System.Nullable<float> PropertyValue232 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_233")]
public System.Nullable<float> PropertyValue233 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_234")]
public System.Nullable<float> PropertyValue234 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_235")]
public System.Nullable<float> PropertyValue235 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_236")]
public System.Nullable<float> PropertyValue236 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_237")]
public System.Nullable<float> PropertyValue237 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_238")]
public System.Nullable<float> PropertyValue238 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_239")]
public System.Nullable<float> PropertyValue239 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_240")]
public System.Nullable<float> PropertyValue240 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_241")]
public System.Nullable<float> PropertyValue241 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_242")]
public System.Nullable<float> PropertyValue242 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_243")]
public System.Nullable<float> PropertyValue243 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_244")]
public System.Nullable<float> PropertyValue244 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_245")]
public System.Nullable<float> PropertyValue245 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_246")]
public System.Nullable<float> PropertyValue246 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_247")]
public System.Nullable<float> PropertyValue247 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_248")]
public System.Nullable<float> PropertyValue248 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_249")]
public System.Nullable<float> PropertyValue249 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_250")]
public System.Nullable<float> PropertyValue250 { get; set; } = null;
    }
    
    public enum FluidProperties_Superheated_FluidPropertyType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Density")]
        Density = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Enthalpy")]
        Enthalpy = 1,
    }
    
    [Description("fluid properties for water/other fluid mixtures")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FluidProperties_Concentration : BHoMObject
    {
        

[Description("should not be any of the defaults (Water, EthyleneGlycol, or PropyleneGlycol)")]
[JsonProperty(PropertyName="fluid_name")]
public string FluidName { get; set; } = "";
        

[Description("Density Units are kg/m3 SpecificHeat Units are J/kg-K Conductivity Units are W/m-" +
    "K Viscosity Units are N-s/m2")]
[JsonProperty(PropertyName="fluid_property_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public FluidProperties_Concentration_FluidPropertyType FluidPropertyType { get; set; } = (FluidProperties_Concentration_FluidPropertyType)Enum.Parse(typeof(FluidProperties_Concentration_FluidPropertyType), "Conductivity");
        

[Description("Enter the name of a FluidProperties:Temperatures object.")]
[JsonProperty(PropertyName="temperature_values_name")]
public string TemperatureValuesName { get; set; } = "";
        

[Description("Glycol concentration for this list of properties entered as a fraction")]
[JsonProperty(PropertyName="concentration")]
public System.Nullable<float> Concentration { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_1")]
public System.Nullable<float> PropertyValue1 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_2")]
public System.Nullable<float> PropertyValue2 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_3")]
public System.Nullable<float> PropertyValue3 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_4")]
public System.Nullable<float> PropertyValue4 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_5")]
public System.Nullable<float> PropertyValue5 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_6")]
public System.Nullable<float> PropertyValue6 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_7")]
public System.Nullable<float> PropertyValue7 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_8")]
public System.Nullable<float> PropertyValue8 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_9")]
public System.Nullable<float> PropertyValue9 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_10")]
public System.Nullable<float> PropertyValue10 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_11")]
public System.Nullable<float> PropertyValue11 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_12")]
public System.Nullable<float> PropertyValue12 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_13")]
public System.Nullable<float> PropertyValue13 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_14")]
public System.Nullable<float> PropertyValue14 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_15")]
public System.Nullable<float> PropertyValue15 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_16")]
public System.Nullable<float> PropertyValue16 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_17")]
public System.Nullable<float> PropertyValue17 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_18")]
public System.Nullable<float> PropertyValue18 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_19")]
public System.Nullable<float> PropertyValue19 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_20")]
public System.Nullable<float> PropertyValue20 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_21")]
public System.Nullable<float> PropertyValue21 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_22")]
public System.Nullable<float> PropertyValue22 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_23")]
public System.Nullable<float> PropertyValue23 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_24")]
public System.Nullable<float> PropertyValue24 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_25")]
public System.Nullable<float> PropertyValue25 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_26")]
public System.Nullable<float> PropertyValue26 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_27")]
public System.Nullable<float> PropertyValue27 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_28")]
public System.Nullable<float> PropertyValue28 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_29")]
public System.Nullable<float> PropertyValue29 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_30")]
public System.Nullable<float> PropertyValue30 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_31")]
public System.Nullable<float> PropertyValue31 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_32")]
public System.Nullable<float> PropertyValue32 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_33")]
public System.Nullable<float> PropertyValue33 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_34")]
public System.Nullable<float> PropertyValue34 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_35")]
public System.Nullable<float> PropertyValue35 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_36")]
public System.Nullable<float> PropertyValue36 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_37")]
public System.Nullable<float> PropertyValue37 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_38")]
public System.Nullable<float> PropertyValue38 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_39")]
public System.Nullable<float> PropertyValue39 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_40")]
public System.Nullable<float> PropertyValue40 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_41")]
public System.Nullable<float> PropertyValue41 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_42")]
public System.Nullable<float> PropertyValue42 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_43")]
public System.Nullable<float> PropertyValue43 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_44")]
public System.Nullable<float> PropertyValue44 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_45")]
public System.Nullable<float> PropertyValue45 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_46")]
public System.Nullable<float> PropertyValue46 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_47")]
public System.Nullable<float> PropertyValue47 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_48")]
public System.Nullable<float> PropertyValue48 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_49")]
public System.Nullable<float> PropertyValue49 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_50")]
public System.Nullable<float> PropertyValue50 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_51")]
public System.Nullable<float> PropertyValue51 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_52")]
public System.Nullable<float> PropertyValue52 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_53")]
public System.Nullable<float> PropertyValue53 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_54")]
public System.Nullable<float> PropertyValue54 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_55")]
public System.Nullable<float> PropertyValue55 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_56")]
public System.Nullable<float> PropertyValue56 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_57")]
public System.Nullable<float> PropertyValue57 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_58")]
public System.Nullable<float> PropertyValue58 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_59")]
public System.Nullable<float> PropertyValue59 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_60")]
public System.Nullable<float> PropertyValue60 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_61")]
public System.Nullable<float> PropertyValue61 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_62")]
public System.Nullable<float> PropertyValue62 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_63")]
public System.Nullable<float> PropertyValue63 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_64")]
public System.Nullable<float> PropertyValue64 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_65")]
public System.Nullable<float> PropertyValue65 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_66")]
public System.Nullable<float> PropertyValue66 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_67")]
public System.Nullable<float> PropertyValue67 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_68")]
public System.Nullable<float> PropertyValue68 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_69")]
public System.Nullable<float> PropertyValue69 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_70")]
public System.Nullable<float> PropertyValue70 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_71")]
public System.Nullable<float> PropertyValue71 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_72")]
public System.Nullable<float> PropertyValue72 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_73")]
public System.Nullable<float> PropertyValue73 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_74")]
public System.Nullable<float> PropertyValue74 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_75")]
public System.Nullable<float> PropertyValue75 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_76")]
public System.Nullable<float> PropertyValue76 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_77")]
public System.Nullable<float> PropertyValue77 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_78")]
public System.Nullable<float> PropertyValue78 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_79")]
public System.Nullable<float> PropertyValue79 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_80")]
public System.Nullable<float> PropertyValue80 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_81")]
public System.Nullable<float> PropertyValue81 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_82")]
public System.Nullable<float> PropertyValue82 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_83")]
public System.Nullable<float> PropertyValue83 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_84")]
public System.Nullable<float> PropertyValue84 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_85")]
public System.Nullable<float> PropertyValue85 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_86")]
public System.Nullable<float> PropertyValue86 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_87")]
public System.Nullable<float> PropertyValue87 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_88")]
public System.Nullable<float> PropertyValue88 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_89")]
public System.Nullable<float> PropertyValue89 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_90")]
public System.Nullable<float> PropertyValue90 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_91")]
public System.Nullable<float> PropertyValue91 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_92")]
public System.Nullable<float> PropertyValue92 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_93")]
public System.Nullable<float> PropertyValue93 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_94")]
public System.Nullable<float> PropertyValue94 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_95")]
public System.Nullable<float> PropertyValue95 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_96")]
public System.Nullable<float> PropertyValue96 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_97")]
public System.Nullable<float> PropertyValue97 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_98")]
public System.Nullable<float> PropertyValue98 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_99")]
public System.Nullable<float> PropertyValue99 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_100")]
public System.Nullable<float> PropertyValue100 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_101")]
public System.Nullable<float> PropertyValue101 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_102")]
public System.Nullable<float> PropertyValue102 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_103")]
public System.Nullable<float> PropertyValue103 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_104")]
public System.Nullable<float> PropertyValue104 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_105")]
public System.Nullable<float> PropertyValue105 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_106")]
public System.Nullable<float> PropertyValue106 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_107")]
public System.Nullable<float> PropertyValue107 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_108")]
public System.Nullable<float> PropertyValue108 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_109")]
public System.Nullable<float> PropertyValue109 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_110")]
public System.Nullable<float> PropertyValue110 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_111")]
public System.Nullable<float> PropertyValue111 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_112")]
public System.Nullable<float> PropertyValue112 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_113")]
public System.Nullable<float> PropertyValue113 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_114")]
public System.Nullable<float> PropertyValue114 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_115")]
public System.Nullable<float> PropertyValue115 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_116")]
public System.Nullable<float> PropertyValue116 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_117")]
public System.Nullable<float> PropertyValue117 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_118")]
public System.Nullable<float> PropertyValue118 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_119")]
public System.Nullable<float> PropertyValue119 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_120")]
public System.Nullable<float> PropertyValue120 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_121")]
public System.Nullable<float> PropertyValue121 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_122")]
public System.Nullable<float> PropertyValue122 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_123")]
public System.Nullable<float> PropertyValue123 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_124")]
public System.Nullable<float> PropertyValue124 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_125")]
public System.Nullable<float> PropertyValue125 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_126")]
public System.Nullable<float> PropertyValue126 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_127")]
public System.Nullable<float> PropertyValue127 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_128")]
public System.Nullable<float> PropertyValue128 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_129")]
public System.Nullable<float> PropertyValue129 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_130")]
public System.Nullable<float> PropertyValue130 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_131")]
public System.Nullable<float> PropertyValue131 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_132")]
public System.Nullable<float> PropertyValue132 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_133")]
public System.Nullable<float> PropertyValue133 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_134")]
public System.Nullable<float> PropertyValue134 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_135")]
public System.Nullable<float> PropertyValue135 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_136")]
public System.Nullable<float> PropertyValue136 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_137")]
public System.Nullable<float> PropertyValue137 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_138")]
public System.Nullable<float> PropertyValue138 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_139")]
public System.Nullable<float> PropertyValue139 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_140")]
public System.Nullable<float> PropertyValue140 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_141")]
public System.Nullable<float> PropertyValue141 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_142")]
public System.Nullable<float> PropertyValue142 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_143")]
public System.Nullable<float> PropertyValue143 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_144")]
public System.Nullable<float> PropertyValue144 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_145")]
public System.Nullable<float> PropertyValue145 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_146")]
public System.Nullable<float> PropertyValue146 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_147")]
public System.Nullable<float> PropertyValue147 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_148")]
public System.Nullable<float> PropertyValue148 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_149")]
public System.Nullable<float> PropertyValue149 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_150")]
public System.Nullable<float> PropertyValue150 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_151")]
public System.Nullable<float> PropertyValue151 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_152")]
public System.Nullable<float> PropertyValue152 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_153")]
public System.Nullable<float> PropertyValue153 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_154")]
public System.Nullable<float> PropertyValue154 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_155")]
public System.Nullable<float> PropertyValue155 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_156")]
public System.Nullable<float> PropertyValue156 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_157")]
public System.Nullable<float> PropertyValue157 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_158")]
public System.Nullable<float> PropertyValue158 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_159")]
public System.Nullable<float> PropertyValue159 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_160")]
public System.Nullable<float> PropertyValue160 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_161")]
public System.Nullable<float> PropertyValue161 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_162")]
public System.Nullable<float> PropertyValue162 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_163")]
public System.Nullable<float> PropertyValue163 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_164")]
public System.Nullable<float> PropertyValue164 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_165")]
public System.Nullable<float> PropertyValue165 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_166")]
public System.Nullable<float> PropertyValue166 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_167")]
public System.Nullable<float> PropertyValue167 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_168")]
public System.Nullable<float> PropertyValue168 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_169")]
public System.Nullable<float> PropertyValue169 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_170")]
public System.Nullable<float> PropertyValue170 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_171")]
public System.Nullable<float> PropertyValue171 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_172")]
public System.Nullable<float> PropertyValue172 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_173")]
public System.Nullable<float> PropertyValue173 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_174")]
public System.Nullable<float> PropertyValue174 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_175")]
public System.Nullable<float> PropertyValue175 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_176")]
public System.Nullable<float> PropertyValue176 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_177")]
public System.Nullable<float> PropertyValue177 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_178")]
public System.Nullable<float> PropertyValue178 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_179")]
public System.Nullable<float> PropertyValue179 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_180")]
public System.Nullable<float> PropertyValue180 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_181")]
public System.Nullable<float> PropertyValue181 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_182")]
public System.Nullable<float> PropertyValue182 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_183")]
public System.Nullable<float> PropertyValue183 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_184")]
public System.Nullable<float> PropertyValue184 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_185")]
public System.Nullable<float> PropertyValue185 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_186")]
public System.Nullable<float> PropertyValue186 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_187")]
public System.Nullable<float> PropertyValue187 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_188")]
public System.Nullable<float> PropertyValue188 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_189")]
public System.Nullable<float> PropertyValue189 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_190")]
public System.Nullable<float> PropertyValue190 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_191")]
public System.Nullable<float> PropertyValue191 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_192")]
public System.Nullable<float> PropertyValue192 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_193")]
public System.Nullable<float> PropertyValue193 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_194")]
public System.Nullable<float> PropertyValue194 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_195")]
public System.Nullable<float> PropertyValue195 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_196")]
public System.Nullable<float> PropertyValue196 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_197")]
public System.Nullable<float> PropertyValue197 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_198")]
public System.Nullable<float> PropertyValue198 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_199")]
public System.Nullable<float> PropertyValue199 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_200")]
public System.Nullable<float> PropertyValue200 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_201")]
public System.Nullable<float> PropertyValue201 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_202")]
public System.Nullable<float> PropertyValue202 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_203")]
public System.Nullable<float> PropertyValue203 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_204")]
public System.Nullable<float> PropertyValue204 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_205")]
public System.Nullable<float> PropertyValue205 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_206")]
public System.Nullable<float> PropertyValue206 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_207")]
public System.Nullable<float> PropertyValue207 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_208")]
public System.Nullable<float> PropertyValue208 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_209")]
public System.Nullable<float> PropertyValue209 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_210")]
public System.Nullable<float> PropertyValue210 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_211")]
public System.Nullable<float> PropertyValue211 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_212")]
public System.Nullable<float> PropertyValue212 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_213")]
public System.Nullable<float> PropertyValue213 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_214")]
public System.Nullable<float> PropertyValue214 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_215")]
public System.Nullable<float> PropertyValue215 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_216")]
public System.Nullable<float> PropertyValue216 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_217")]
public System.Nullable<float> PropertyValue217 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_218")]
public System.Nullable<float> PropertyValue218 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_219")]
public System.Nullable<float> PropertyValue219 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_220")]
public System.Nullable<float> PropertyValue220 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_221")]
public System.Nullable<float> PropertyValue221 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_222")]
public System.Nullable<float> PropertyValue222 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_223")]
public System.Nullable<float> PropertyValue223 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_224")]
public System.Nullable<float> PropertyValue224 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_225")]
public System.Nullable<float> PropertyValue225 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_226")]
public System.Nullable<float> PropertyValue226 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_227")]
public System.Nullable<float> PropertyValue227 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_228")]
public System.Nullable<float> PropertyValue228 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_229")]
public System.Nullable<float> PropertyValue229 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_230")]
public System.Nullable<float> PropertyValue230 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_231")]
public System.Nullable<float> PropertyValue231 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_232")]
public System.Nullable<float> PropertyValue232 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_233")]
public System.Nullable<float> PropertyValue233 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_234")]
public System.Nullable<float> PropertyValue234 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_235")]
public System.Nullable<float> PropertyValue235 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_236")]
public System.Nullable<float> PropertyValue236 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_237")]
public System.Nullable<float> PropertyValue237 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_238")]
public System.Nullable<float> PropertyValue238 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_239")]
public System.Nullable<float> PropertyValue239 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_240")]
public System.Nullable<float> PropertyValue240 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_241")]
public System.Nullable<float> PropertyValue241 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_242")]
public System.Nullable<float> PropertyValue242 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_243")]
public System.Nullable<float> PropertyValue243 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_244")]
public System.Nullable<float> PropertyValue244 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_245")]
public System.Nullable<float> PropertyValue245 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_246")]
public System.Nullable<float> PropertyValue246 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_247")]
public System.Nullable<float> PropertyValue247 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_248")]
public System.Nullable<float> PropertyValue248 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_249")]
public System.Nullable<float> PropertyValue249 { get; set; } = null;
        

[JsonProperty(PropertyName="property_value_250")]
public System.Nullable<float> PropertyValue250 { get; set; } = null;
    }
    
    public enum FluidProperties_Concentration_FluidPropertyType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Conductivity")]
        Conductivity = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Density")]
        Density = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SpecificHeat")]
        SpecificHeat = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Viscosity")]
        Viscosity = 3,
    }
}
