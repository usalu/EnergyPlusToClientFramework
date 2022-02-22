namespace BH.oM.Adapters.EnergyPlus
{
    using System.ComponentModel;
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using BH.oM.Base;
    using AdvancedConstructionSurfaceZoneConcepts;
    using AirDistribution;
    using AirflowNetwork;
    using Coils;
    using ComplianceObjects;
    using CondenserEquipmentandHeatExchangers;
    using Controllers;
    using Daylighting;
    using DemandLimitingControls;
    using DetailedGroundHeatTransfer;
    using Economics;
    using ElectricLoadCenterGeneratorSpecifications;
    using EnergyManagementSystemEMS;
    using EvaporativeCoolers;
    using ExteriorEquipment;
    using ExternalInterface;
    using Fans;
    using FluidProperties;
    using GeneralDataEntry;
    using HeatRecovery;
    using HumidifiersandDehumidifiers;
    using HVACDesignObjects;
    using HVACTemplates;
    using HybridModel;
    using InternalGains;
    using LocationandClimate;
    using NodeBranchManagement;
    using NonZoneEquipment;
    using OperationalFaults;
    using OutputReporting;
    using Parametrics;
    using PerformanceCurves;
    using PerformanceTables;
    using PlantHeatingandCoolingEquipment;
    using PlantCondenserControl;
    using PlantCondenserFlowControl;
    using PlantCondenserLoops;
    using Pumps;
    using PythonPluginSystem;
    using Refrigeration;
    using RoomAirModels;
    using Schedules;
    using SetpointManagers;
    using SimulationParameters;
    using SolarCollectors;
    using SurfaceConstructionElements;
    using SystemAvailabilityManagers;
    using ThermalZonesandSurfaces;
    using UnitaryEquipment;
    using UserDefinedHVACandPlantComponentModels;
    using VariableRefrigerantFlowEquipment;
    using WaterHeatersandThermalStorage;
    using WaterSystems;
    using ZoneAirflow;
    using ZoneHVACAirLoopTerminalUnits;
    using ZoneHVACControlsandThermostats;
    using ZoneHVACEquipmentConnections;
    using ZoneHVACForcedAirUnits;
    using ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("Ultimate class that can be automatically (de)serialized and simulated.")]
    public class EnergyPlusJson : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("SurfaceProperty:HeatTransferAlgorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm> SurfaceProperty_HeatTransferAlgorithm_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:HeatTransferAlgorithm:MultipleSurface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm_MultipleSurface> SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:HeatTransferAlgorithm:SurfaceList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm_SurfaceList> SurfaceProperty_HeatTransferAlgorithm_SurfaceList_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:HeatTransferAlgorithm:Construction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm_Construction> SurfaceProperty_HeatTransferAlgorithm_Construction_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:HeatBalanceSourceTerm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatBalanceSourceTerm> SurfaceProperty_HeatBalanceSourceTerm_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceControl:MovableInsulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceControl_MovableInsulation> SurfaceControl_MovableInsulation_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:OtherSideCoefficients", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_OtherSideCoefficients> SurfaceProperty_OtherSideCoefficients_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:OtherSideConditionsModel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_OtherSideConditionsModel> SurfaceProperty_OtherSideConditionsModel_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:Underwater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_Underwater> SurfaceProperty_Underwater_Dictionary { get; set; } = null;
        

[JsonProperty("Foundation:Kiva", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.Foundation_Kiva> Foundation_Kiva_Dictionary { get; set; } = null;
        

[JsonProperty("Foundation:Kiva:Settings", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.Foundation_Kiva_Settings> Foundation_Kiva_Settings_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:ExposedFoundationPerimeter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ExposedFoundationPerimeter> SurfaceProperty_ExposedFoundationPerimeter_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceConvectionAlgorithm:Inside:AdaptiveModelSelections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections { get; set; } = null;
        

[JsonProperty("SurfaceConvectionAlgorithm:Outside:AdaptiveModelSelections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections { get; set; } = null;
        

[JsonProperty("SurfaceConvectionAlgorithm:Inside:UserCurve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Inside_UserCurve> SurfaceConvectionAlgorithm_Inside_UserCurve_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceConvectionAlgorithm:Outside:UserCurve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Outside_UserCurve> SurfaceConvectionAlgorithm_Outside_UserCurve_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:ConvectionCoefficients", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ConvectionCoefficients> SurfaceProperty_ConvectionCoefficients_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:ConvectionCoefficients:MultipleSurface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ConvectionCoefficients_MultipleSurface> SurfaceProperty_ConvectionCoefficients_MultipleSurface_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperties:VaporCoefficients", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperties_VaporCoefficients> SurfaceProperties_VaporCoefficients_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:ExteriorNaturalVentedCavity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ExteriorNaturalVentedCavity> SurfaceProperty_ExteriorNaturalVentedCavity_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:SolarIncidentInside", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_SolarIncidentInside> SurfaceProperty_SolarIncidentInside_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:LocalEnvironment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_LocalEnvironment> SurfaceProperty_LocalEnvironment_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneProperty:LocalEnvironment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.ZoneProperty_LocalEnvironment> ZoneProperty_LocalEnvironment_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceProperty:SurroundingSurfaces", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_SurroundingSurfaces> SurfaceProperty_SurroundingSurfaces_Dictionary { get; set; } = null;
        

[JsonProperty("ComplexFenestrationProperty:SolarAbsorbedLayers", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.ComplexFenestrationProperty_SolarAbsorbedLayers> ComplexFenestrationProperty_SolarAbsorbedLayers_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneProperty:UserViewFactors:BySurfaceName", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.ZoneProperty_UserViewFactors_BySurfaceName> ZoneProperty_UserViewFactors_BySurfaceName_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC> AirLoopHVAC_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:OutdoorAirSystem:EquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_OutdoorAirSystem_EquipmentList> AirLoopHVAC_OutdoorAirSystem_EquipmentList_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:OutdoorAirSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_OutdoorAirSystem> AirLoopHVAC_OutdoorAirSystem_Dictionary { get; set; } = null;
        

[JsonProperty("OutdoorAir:Mixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirDistribution.OutdoorAir_Mixer> OutdoorAir_Mixer_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:ZoneSplitter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ZoneSplitter> AirLoopHVAC_ZoneSplitter_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:SupplyPlenum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_SupplyPlenum> AirLoopHVAC_SupplyPlenum_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:SupplyPath", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_SupplyPath> AirLoopHVAC_SupplyPath_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:ZoneMixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ZoneMixer> AirLoopHVAC_ZoneMixer_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:ReturnPlenum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ReturnPlenum> AirLoopHVAC_ReturnPlenum_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:ReturnPath", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ReturnPath> AirLoopHVAC_ReturnPath_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:DedicatedOutdoorAirSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_DedicatedOutdoorAirSystem> AirLoopHVAC_DedicatedOutdoorAirSystem_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:Mixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_Mixer> AirLoopHVAC_Mixer_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:Splitter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_Splitter> AirLoopHVAC_Splitter_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:SimulationControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_SimulationControl AirflowNetwork_SimulationControl { get; set; } = null;
        

[JsonProperty("AirflowNetwork:MultiZone:Zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Zone> AirflowNetwork_MultiZone_Zone_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:MultiZone:Surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Surface> AirflowNetwork_MultiZone_Surface_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:MultiZone:ReferenceCrackConditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_ReferenceCrackConditions> AirflowNetwork_MultiZone_ReferenceCrackConditions_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:MultiZone:Surface:Crack", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Surface_Crack> AirflowNetwork_MultiZone_Surface_Crack_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:MultiZone:Surface:EffectiveLeakageArea", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Surface_EffectiveLeakageArea> AirflowNetwork_MultiZone_Surface_EffectiveLeakageArea_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:MultiZone:Component:DetailedOpening", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_DetailedOpening> AirflowNetwork_MultiZone_Component_DetailedOpening_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:MultiZone:Component:SimpleOpening", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_SimpleOpening> AirflowNetwork_MultiZone_Component_SimpleOpening_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:MultiZone:Component:HorizontalOpening", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_HorizontalOpening> AirflowNetwork_MultiZone_Component_HorizontalOpening_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:MultiZone:Component:ZoneExhaustFan", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_ZoneExhaustFan> AirflowNetwork_MultiZone_Component_ZoneExhaustFan_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:MultiZone:ExternalNode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_ExternalNode> AirflowNetwork_MultiZone_ExternalNode_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:MultiZone:WindPressureCoefficientArray", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_WindPressureCoefficientArray> AirflowNetwork_MultiZone_WindPressureCoefficientArray_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:MultiZone:WindPressureCoefficientValues", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_WindPressureCoefficientValues> AirflowNetwork_MultiZone_WindPressureCoefficientValues_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:ZoneControl:PressureController", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_ZoneControl_PressureController AirflowNetwork_ZoneControl_PressureController { get; set; } = null;
        

[JsonProperty("AirflowNetwork:Distribution:Node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Node> AirflowNetwork_Distribution_Node_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:Distribution:Component:Leak", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Leak> AirflowNetwork_Distribution_Component_Leak_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:Distribution:Component:LeakageRatio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_LeakageRatio> AirflowNetwork_Distribution_Component_LeakageRatio_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:Distribution:Component:Duct", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Duct> AirflowNetwork_Distribution_Component_Duct_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:Distribution:Component:Fan", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Fan> AirflowNetwork_Distribution_Component_Fan_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:Distribution:Component:Coil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Coil> AirflowNetwork_Distribution_Component_Coil_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:Distribution:Component:HeatExchanger", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_HeatExchanger> AirflowNetwork_Distribution_Component_HeatExchanger_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:Distribution:Component:TerminalUnit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_TerminalUnit> AirflowNetwork_Distribution_Component_TerminalUnit_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:Distribution:Component:ConstantPressureDrop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_ConstantPressureDrop> AirflowNetwork_Distribution_Component_ConstantPressureDrop_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:Distribution:Component:OutdoorAirFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_OutdoorAirFlow> AirflowNetwork_Distribution_Component_OutdoorAirFlow_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:Distribution:Component:ReliefAirFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_ReliefAirFlow> AirflowNetwork_Distribution_Component_ReliefAirFlow_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:Distribution:Linkage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Linkage> AirflowNetwork_Distribution_Linkage_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:Distribution:DuctViewFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_DuctViewFactors> AirflowNetwork_Distribution_DuctViewFactors_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:OccupantVentilationControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_OccupantVentilationControl> AirflowNetwork_OccupantVentilationControl_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:IntraZone:Node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_IntraZone_Node> AirflowNetwork_IntraZone_Node_Dictionary { get; set; } = null;
        

[JsonProperty("AirflowNetwork:IntraZone:Linkage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_IntraZone_Linkage> AirflowNetwork_IntraZone_Linkage_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_Water> Coil_Cooling_Water_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:Water:DetailedGeometry", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_Water_DetailedGeometry> Coil_Cooling_Water_DetailedGeometry_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:DX", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX> Coil_Cooling_DX_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:DX:CurveFit:Performance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_CurveFit_Performance> Coil_Cooling_DX_CurveFit_Performance_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:DX:CurveFit:OperatingMode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_CurveFit_OperatingMode> Coil_Cooling_DX_CurveFit_OperatingMode_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:DX:CurveFit:Speed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_CurveFit_Speed> Coil_Cooling_DX_CurveFit_Speed_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:DX:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_SingleSpeed> Coil_Cooling_DX_SingleSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:DX:TwoSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_TwoSpeed> Coil_Cooling_DX_TwoSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:DX:MultiSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_MultiSpeed> Coil_Cooling_DX_MultiSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:DX:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_VariableSpeed> Coil_Cooling_DX_VariableSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:DX:TwoStageWithHumidityControlMode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_TwoStageWithHumidityControlMode> Coil_Cooling_DX_TwoStageWithHumidityControlMode_Dictionary { get; set; } = null;
        

[JsonProperty("CoilPerformance:DX:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.CoilPerformance_DX_Cooling> CoilPerformance_DX_Cooling_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:DX:VariableRefrigerantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_VariableRefrigerantFlow> Coil_Cooling_DX_VariableRefrigerantFlow_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:DX:VariableRefrigerantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_VariableRefrigerantFlow> Coil_Heating_DX_VariableRefrigerantFlow_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:DX:VariableRefrigerantFlow:FluidTemperatureControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_VariableRefrigerantFlow_FluidTemperatureControl> Coil_Cooling_DX_VariableRefrigerantFlow_FluidTemperatureControl_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:DX:VariableRefrigerantFlow:FluidTemperatureControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_VariableRefrigerantFlow_FluidTemperatureControl> Coil_Heating_DX_VariableRefrigerantFlow_FluidTemperatureControl_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Water> Coil_Heating_Water_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:Steam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Steam> Coil_Heating_Steam_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Electric> Coil_Heating_Electric_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:Electric:MultiStage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Electric_MultiStage> Coil_Heating_Electric_MultiStage_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:Fuel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Fuel> Coil_Heating_Fuel_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:Gas:MultiStage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Gas_MultiStage> Coil_Heating_Gas_MultiStage_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:Desuperheater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Desuperheater> Coil_Heating_Desuperheater_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:DX:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_SingleSpeed> Coil_Heating_DX_SingleSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:DX:MultiSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_MultiSpeed> Coil_Heating_DX_MultiSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:DX:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_VariableSpeed> Coil_Heating_DX_VariableSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:WaterToAirHeatPump:ParameterEstimation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_WaterToAirHeatPump_ParameterEstimation> Coil_Cooling_WaterToAirHeatPump_ParameterEstimation_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:WaterToAirHeatPump:ParameterEstimation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_WaterToAirHeatPump_ParameterEstimation> Coil_Heating_WaterToAirHeatPump_ParameterEstimation_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:WaterToAirHeatPump:EquationFit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_WaterToAirHeatPump_EquationFit> Coil_Cooling_WaterToAirHeatPump_EquationFit_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:WaterToAirHeatPump:VariableSpeedEquationFit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_WaterToAirHeatPump_VariableSpeedEquationFit> Coil_Cooling_WaterToAirHeatPump_VariableSpeedEquationFit_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:WaterToAirHeatPump:EquationFit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_WaterToAirHeatPump_EquationFit> Coil_Heating_WaterToAirHeatPump_EquationFit_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Heating:WaterToAirHeatPump:VariableSpeedEquationFit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_WaterToAirHeatPump_VariableSpeedEquationFit> Coil_Heating_WaterToAirHeatPump_VariableSpeedEquationFit_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:WaterHeating:AirToWaterHeatPump:Pumped", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_AirToWaterHeatPump_Pumped> Coil_WaterHeating_AirToWaterHeatPump_Pumped_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:WaterHeating:AirToWaterHeatPump:Wrapped", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_AirToWaterHeatPump_Wrapped> Coil_WaterHeating_AirToWaterHeatPump_Wrapped_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:WaterHeating:AirToWaterHeatPump:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed> Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:WaterHeating:Desuperheater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_Desuperheater> Coil_WaterHeating_Desuperheater_Dictionary { get; set; } = null;
        

[JsonProperty("CoilSystem:Cooling:DX", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Cooling_DX> CoilSystem_Cooling_DX_Dictionary { get; set; } = null;
        

[JsonProperty("CoilSystem:Heating:DX", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Heating_DX> CoilSystem_Heating_DX_Dictionary { get; set; } = null;
        

[JsonProperty("CoilSystem:Cooling:Water:HeatExchangerAssisted", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Cooling_Water_HeatExchangerAssisted> CoilSystem_Cooling_Water_HeatExchangerAssisted_Dictionary { get; set; } = null;
        

[JsonProperty("CoilSystem:Cooling:DX:HeatExchangerAssisted", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Cooling_DX_HeatExchangerAssisted> CoilSystem_Cooling_DX_HeatExchangerAssisted_Dictionary { get; set; } = null;
        

[JsonProperty("CoilSystem:IntegratedHeatPump:AirSource", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_IntegratedHeatPump_AirSource> CoilSystem_IntegratedHeatPump_AirSource_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:Cooling:DX:SingleSpeed:ThermalStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_SingleSpeed_ThermalStorage> Coil_Cooling_DX_SingleSpeed_ThermalStorage_Dictionary { get; set; } = null;
        

[JsonProperty("Compliance:Building", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.ComplianceObjects.Compliance_Building Compliance_Building { get; set; } = null;
        

[JsonProperty("CoolingTower:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_SingleSpeed> CoolingTower_SingleSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("CoolingTower:TwoSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_TwoSpeed> CoolingTower_TwoSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("CoolingTower:VariableSpeed:Merkel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_VariableSpeed_Merkel> CoolingTower_VariableSpeed_Merkel_Dictionary { get; set; } = null;
        

[JsonProperty("CoolingTower:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_VariableSpeed> CoolingTower_VariableSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("CoolingTowerPerformance:CoolTools", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTowerPerformance_CoolTools> CoolingTowerPerformance_CoolTools_Dictionary { get; set; } = null;
        

[JsonProperty("CoolingTowerPerformance:YorkCalc", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTowerPerformance_YorkCalc> CoolingTowerPerformance_YorkCalc_Dictionary { get; set; } = null;
        

[JsonProperty("EvaporativeFluidCooler:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.EvaporativeFluidCooler_SingleSpeed> EvaporativeFluidCooler_SingleSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("EvaporativeFluidCooler:TwoSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.EvaporativeFluidCooler_TwoSpeed> EvaporativeFluidCooler_TwoSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("FluidCooler:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.FluidCooler_SingleSpeed> FluidCooler_SingleSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("FluidCooler:TwoSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.FluidCooler_TwoSpeed> FluidCooler_TwoSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatExchanger:System", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_System> GroundHeatExchanger_System_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatExchanger:Vertical:Properties", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Vertical_Properties> GroundHeatExchanger_Vertical_Properties_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatExchanger:Vertical:Array", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Vertical_Array> GroundHeatExchanger_Vertical_Array_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatExchanger:Vertical:Single", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Vertical_Single> GroundHeatExchanger_Vertical_Single_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatExchanger:ResponseFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_ResponseFactors> GroundHeatExchanger_ResponseFactors_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatExchanger:Pond", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Pond> GroundHeatExchanger_Pond_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatExchanger:Surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Surface> GroundHeatExchanger_Surface_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatExchanger:HorizontalTrench", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_HorizontalTrench> GroundHeatExchanger_HorizontalTrench_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatExchanger:Slinky", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Slinky> GroundHeatExchanger_Slinky_Dictionary { get; set; } = null;
        

[JsonProperty("HeatExchanger:FluidToFluid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.HeatExchanger_FluidToFluid> HeatExchanger_FluidToFluid_Dictionary { get; set; } = null;
        

[JsonProperty("Controller:WaterCoil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Controllers.Controller_WaterCoil> Controller_WaterCoil_Dictionary { get; set; } = null;
        

[JsonProperty("Controller:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Controllers.Controller_OutdoorAir> Controller_OutdoorAir_Dictionary { get; set; } = null;
        

[JsonProperty("Controller:MechanicalVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Controllers.Controller_MechanicalVentilation> Controller_MechanicalVentilation_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:ControllerList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Controllers.AirLoopHVAC_ControllerList> AirLoopHVAC_ControllerList_Dictionary { get; set; } = null;
        

[JsonProperty("Daylighting:Controls", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Daylighting.Daylighting_Controls> Daylighting_Controls_Dictionary { get; set; } = null;
        

[JsonProperty("Daylighting:ReferencePoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Daylighting.Daylighting_ReferencePoint> Daylighting_ReferencePoint_Dictionary { get; set; } = null;
        

[JsonProperty("Daylighting:DELight:ComplexFenestration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Daylighting.Daylighting_DELight_ComplexFenestration> Daylighting_DELight_ComplexFenestration_Dictionary { get; set; } = null;
        

[JsonProperty("DaylightingDevice:Tubular", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Daylighting.DaylightingDevice_Tubular> DaylightingDevice_Tubular_Dictionary { get; set; } = null;
        

[JsonProperty("DaylightingDevice:Shelf", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Daylighting.DaylightingDevice_Shelf> DaylightingDevice_Shelf_Dictionary { get; set; } = null;
        

[JsonProperty("DaylightingDevice:LightWell", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Daylighting.DaylightingDevice_LightWell> DaylightingDevice_LightWell_Dictionary { get; set; } = null;
        

[JsonProperty("Output:DaylightFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Daylighting.Output_DaylightFactors> Output_DaylightFactors_Dictionary { get; set; } = null;
        

[JsonProperty("Output:IlluminanceMap", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Daylighting.Output_IlluminanceMap> Output_IlluminanceMap_Dictionary { get; set; } = null;
        

[JsonProperty("OutputControl:IlluminanceMap:Style", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Daylighting.OutputControl_IlluminanceMap_Style OutputControl_IlluminanceMap_Style { get; set; } = null;
        

[JsonProperty("DemandManagerAssignmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManagerAssignmentList> DemandManagerAssignmentList_Dictionary { get; set; } = null;
        

[JsonProperty("DemandManager:ExteriorLights", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_ExteriorLights> DemandManager_ExteriorLights_Dictionary { get; set; } = null;
        

[JsonProperty("DemandManager:Lights", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_Lights> DemandManager_Lights_Dictionary { get; set; } = null;
        

[JsonProperty("DemandManager:ElectricEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_ElectricEquipment> DemandManager_ElectricEquipment_Dictionary { get; set; } = null;
        

[JsonProperty("DemandManager:Thermostats", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_Thermostats> DemandManager_Thermostats_Dictionary { get; set; } = null;
        

[JsonProperty("DemandManager:Ventilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_Ventilation> DemandManager_Ventilation_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Control> GroundHeatTransfer_Control_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Slab:Materials", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_Materials> GroundHeatTransfer_Slab_Materials_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Slab:MatlProps", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_MatlProps> GroundHeatTransfer_Slab_MatlProps_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Slab:BoundConds", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_BoundConds> GroundHeatTransfer_Slab_BoundConds_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Slab:BldgProps", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_BldgProps> GroundHeatTransfer_Slab_BldgProps_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Slab:Insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_Insulation> GroundHeatTransfer_Slab_Insulation_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Slab:EquivalentSlab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_EquivalentSlab> GroundHeatTransfer_Slab_EquivalentSlab_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Slab:AutoGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_AutoGrid> GroundHeatTransfer_Slab_AutoGrid_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Slab:ManualGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_ManualGrid> GroundHeatTransfer_Slab_ManualGrid_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Slab:XFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_XFACE> GroundHeatTransfer_Slab_XFACE_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Slab:YFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_YFACE> GroundHeatTransfer_Slab_YFACE_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Slab:ZFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_ZFACE> GroundHeatTransfer_Slab_ZFACE_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:SimParameters", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_SimParameters> GroundHeatTransfer_Basement_SimParameters_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:MatlProps", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_MatlProps> GroundHeatTransfer_Basement_MatlProps_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:Insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_Insulation> GroundHeatTransfer_Basement_Insulation_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:SurfaceProps", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_SurfaceProps> GroundHeatTransfer_Basement_SurfaceProps_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:BldgData", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_BldgData> GroundHeatTransfer_Basement_BldgData_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:Interior", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_Interior> GroundHeatTransfer_Basement_Interior_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:ComBldg", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_ComBldg> GroundHeatTransfer_Basement_ComBldg_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:EquivSlab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_EquivSlab> GroundHeatTransfer_Basement_EquivSlab_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:EquivAutoGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_EquivAutoGrid> GroundHeatTransfer_Basement_EquivAutoGrid_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:AutoGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_AutoGrid> GroundHeatTransfer_Basement_AutoGrid_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:ManualGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_ManualGrid> GroundHeatTransfer_Basement_ManualGrid_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:XFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_XFACE> GroundHeatTransfer_Basement_XFACE_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:YFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_YFACE> GroundHeatTransfer_Basement_YFACE_Dictionary { get; set; } = null;
        

[JsonProperty("GroundHeatTransfer:Basement:ZFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_ZFACE> GroundHeatTransfer_Basement_ZFACE_Dictionary { get; set; } = null;
        

[JsonProperty("CurrencyType", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Economics.CurrencyType CurrencyType { get; set; } = null;
        

[JsonProperty("ComponentCost:Adjustments", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.ComponentCost_Adjustments> ComponentCost_Adjustments_Dictionary { get; set; } = null;
        

[JsonProperty("ComponentCost:Reference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.ComponentCost_Reference> ComponentCost_Reference_Dictionary { get; set; } = null;
        

[JsonProperty("ComponentCost:LineItem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.ComponentCost_LineItem> ComponentCost_LineItem_Dictionary { get; set; } = null;
        

[JsonProperty("UtilityCost:Tariff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Tariff> UtilityCost_Tariff_Dictionary { get; set; } = null;
        

[JsonProperty("UtilityCost:Qualify", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Qualify> UtilityCost_Qualify_Dictionary { get; set; } = null;
        

[JsonProperty("UtilityCost:Charge:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Charge_Simple> UtilityCost_Charge_Simple_Dictionary { get; set; } = null;
        

[JsonProperty("UtilityCost:Charge:Block", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Charge_Block> UtilityCost_Charge_Block_Dictionary { get; set; } = null;
        

[JsonProperty("UtilityCost:Ratchet", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Ratchet> UtilityCost_Ratchet_Dictionary { get; set; } = null;
        

[JsonProperty("UtilityCost:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Variable> UtilityCost_Variable_Dictionary { get; set; } = null;
        

[JsonProperty("UtilityCost:Computation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Computation> UtilityCost_Computation_Dictionary { get; set; } = null;
        

[JsonProperty("LifeCycleCost:Parameters", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_Parameters LifeCycleCost_Parameters { get; set; } = null;
        

[JsonProperty("LifeCycleCost:RecurringCosts", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_RecurringCosts> LifeCycleCost_RecurringCosts_Dictionary { get; set; } = null;
        

[JsonProperty("LifeCycleCost:NonrecurringCost", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_NonrecurringCost> LifeCycleCost_NonrecurringCost_Dictionary { get; set; } = null;
        

[JsonProperty("LifeCycleCost:UsePriceEscalation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_UsePriceEscalation> LifeCycleCost_UsePriceEscalation_Dictionary { get; set; } = null;
        

[JsonProperty("LifeCycleCost:UseAdjustment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_UseAdjustment> LifeCycleCost_UseAdjustment_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:InternalCombustionEngine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_InternalCombustionEngine> Generator_InternalCombustionEngine_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:CombustionTurbine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_CombustionTurbine> Generator_CombustionTurbine_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:MicroTurbine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_MicroTurbine> Generator_MicroTurbine_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:Photovoltaic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_Photovoltaic> Generator_Photovoltaic_Dictionary { get; set; } = null;
        

[JsonProperty("PhotovoltaicPerformance:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.PhotovoltaicPerformance_Simple> PhotovoltaicPerformance_Simple_Dictionary { get; set; } = null;
        

[JsonProperty("PhotovoltaicPerformance:EquivalentOne-Diode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.PhotovoltaicPerformance_EquivalentOneDiode> PhotovoltaicPerformance_EquivalentOneDiode_Dictionary { get; set; } = null;
        

[JsonProperty("PhotovoltaicPerformance:Sandia", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.PhotovoltaicPerformance_Sandia> PhotovoltaicPerformance_Sandia_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:PVWatts", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_PVWatts> Generator_PVWatts_Dictionary { get; set; } = null;
        

[JsonProperty("ElectricLoadCenter:Inverter:PVWatts", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_PVWatts> ElectricLoadCenter_Inverter_PVWatts_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:FuelCell", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell> Generator_FuelCell_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:FuelCell:PowerModule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_PowerModule> Generator_FuelCell_PowerModule_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:FuelCell:AirSupply", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_AirSupply> Generator_FuelCell_AirSupply_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:FuelCell:WaterSupply", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_WaterSupply> Generator_FuelCell_WaterSupply_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:FuelCell:AuxiliaryHeater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_AuxiliaryHeater> Generator_FuelCell_AuxiliaryHeater_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:FuelCell:ExhaustGasToWaterHeatExchanger", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_ExhaustGasToWaterHeatExchanger> Generator_FuelCell_ExhaustGasToWaterHeatExchanger_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:FuelCell:ElectricalStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_ElectricalStorage> Generator_FuelCell_ElectricalStorage_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:FuelCell:Inverter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_Inverter> Generator_FuelCell_Inverter_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:FuelCell:StackCooler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_StackCooler> Generator_FuelCell_StackCooler_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:MicroCHP", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_MicroCHP> Generator_MicroCHP_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:MicroCHP:NonNormalizedParameters", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_MicroCHP_NonNormalizedParameters> Generator_MicroCHP_NonNormalizedParameters_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:FuelSupply", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelSupply> Generator_FuelSupply_Dictionary { get; set; } = null;
        

[JsonProperty("Generator:WindTurbine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_WindTurbine> Generator_WindTurbine_Dictionary { get; set; } = null;
        

[JsonProperty("ElectricLoadCenter:Generators", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Generators> ElectricLoadCenter_Generators_Dictionary { get; set; } = null;
        

[JsonProperty("ElectricLoadCenter:Inverter:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_Simple> ElectricLoadCenter_Inverter_Simple_Dictionary { get; set; } = null;
        

[JsonProperty("ElectricLoadCenter:Inverter:FunctionOfPower", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_FunctionOfPower> ElectricLoadCenter_Inverter_FunctionOfPower_Dictionary { get; set; } = null;
        

[JsonProperty("ElectricLoadCenter:Inverter:LookUpTable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_LookUpTable> ElectricLoadCenter_Inverter_LookUpTable_Dictionary { get; set; } = null;
        

[JsonProperty("ElectricLoadCenter:Storage:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_Simple> ElectricLoadCenter_Storage_Simple_Dictionary { get; set; } = null;
        

[JsonProperty("ElectricLoadCenter:Storage:Battery", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_Battery> ElectricLoadCenter_Storage_Battery_Dictionary { get; set; } = null;
        

[JsonProperty("ElectricLoadCenter:Storage:LiIonNMCBattery", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_LiIonNMCBattery> ElectricLoadCenter_Storage_LiIonNMCBattery_Dictionary { get; set; } = null;
        

[JsonProperty("ElectricLoadCenter:Transformer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Transformer> ElectricLoadCenter_Transformer_Dictionary { get; set; } = null;
        

[JsonProperty("ElectricLoadCenter:Distribution", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Distribution> ElectricLoadCenter_Distribution_Dictionary { get; set; } = null;
        

[JsonProperty("ElectricLoadCenter:Storage:Converter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_Converter> ElectricLoadCenter_Storage_Converter_Dictionary { get; set; } = null;
        

[JsonProperty("EnergyManagementSystem:Sensor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Sensor> EnergyManagementSystem_Sensor_Dictionary { get; set; } = null;
        

[JsonProperty("EnergyManagementSystem:Actuator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Actuator> EnergyManagementSystem_Actuator_Dictionary { get; set; } = null;
        

[JsonProperty("EnergyManagementSystem:ProgramCallingManager", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_ProgramCallingManager> EnergyManagementSystem_ProgramCallingManager_Dictionary { get; set; } = null;
        

[JsonProperty("EnergyManagementSystem:Program", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Program> EnergyManagementSystem_Program_Dictionary { get; set; } = null;
        

[JsonProperty("EnergyManagementSystem:Subroutine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Subroutine> EnergyManagementSystem_Subroutine_Dictionary { get; set; } = null;
        

[JsonProperty("EnergyManagementSystem:GlobalVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_GlobalVariable> EnergyManagementSystem_GlobalVariable_Dictionary { get; set; } = null;
        

[JsonProperty("EnergyManagementSystem:OutputVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_OutputVariable> EnergyManagementSystem_OutputVariable_Dictionary { get; set; } = null;
        

[JsonProperty("EnergyManagementSystem:MeteredOutputVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_MeteredOutputVariable> EnergyManagementSystem_MeteredOutputVariable_Dictionary { get; set; } = null;
        

[JsonProperty("EnergyManagementSystem:TrendVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_TrendVariable> EnergyManagementSystem_TrendVariable_Dictionary { get; set; } = null;
        

[JsonProperty("EnergyManagementSystem:InternalVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_InternalVariable> EnergyManagementSystem_InternalVariable_Dictionary { get; set; } = null;
        

[JsonProperty("EnergyManagementSystem:CurveOrTableIndexVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_CurveOrTableIndexVariable> EnergyManagementSystem_CurveOrTableIndexVariable_Dictionary { get; set; } = null;
        

[JsonProperty("EnergyManagementSystem:ConstructionIndexVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_ConstructionIndexVariable> EnergyManagementSystem_ConstructionIndexVariable_Dictionary { get; set; } = null;
        

[JsonProperty("EvaporativeCooler:Direct:CelDekPad", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Direct_CelDekPad> EvaporativeCooler_Direct_CelDekPad_Dictionary { get; set; } = null;
        

[JsonProperty("EvaporativeCooler:Indirect:CelDekPad", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Indirect_CelDekPad> EvaporativeCooler_Indirect_CelDekPad_Dictionary { get; set; } = null;
        

[JsonProperty("EvaporativeCooler:Indirect:WetCoil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Indirect_WetCoil> EvaporativeCooler_Indirect_WetCoil_Dictionary { get; set; } = null;
        

[JsonProperty("EvaporativeCooler:Indirect:ResearchSpecial", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Indirect_ResearchSpecial> EvaporativeCooler_Indirect_ResearchSpecial_Dictionary { get; set; } = null;
        

[JsonProperty("EvaporativeCooler:Direct:ResearchSpecial", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Direct_ResearchSpecial> EvaporativeCooler_Direct_ResearchSpecial_Dictionary { get; set; } = null;
        

[JsonProperty("Exterior:Lights", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExteriorEquipment.Exterior_Lights> Exterior_Lights_Dictionary { get; set; } = null;
        

[JsonProperty("Exterior:FuelEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExteriorEquipment.Exterior_FuelEquipment> Exterior_FuelEquipment_Dictionary { get; set; } = null;
        

[JsonProperty("Exterior:WaterEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExteriorEquipment.Exterior_WaterEquipment> Exterior_WaterEquipment_Dictionary { get; set; } = null;
        

[JsonProperty("ExternalInterface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface> ExternalInterface_Dictionary { get; set; } = null;
        

[JsonProperty("ExternalInterface:Schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_Schedule> ExternalInterface_Schedule_Dictionary { get; set; } = null;
        

[JsonProperty("ExternalInterface:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_Variable> ExternalInterface_Variable_Dictionary { get; set; } = null;
        

[JsonProperty("ExternalInterface:Actuator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_Actuator> ExternalInterface_Actuator_Dictionary { get; set; } = null;
        

[JsonProperty("ExternalInterface:FunctionalMockupUnitImport", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport> ExternalInterface_FunctionalMockupUnitImport_Dictionary { get; set; } = null;
        

[JsonProperty("ExternalInterface:FunctionalMockupUnitImport:From:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_From_Variable> ExternalInterface_FunctionalMockupUnitImport_From_Variable_Dictionary { get; set; } = null;
        

[JsonProperty("ExternalInterface:FunctionalMockupUnitImport:To:Schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_To_Schedule> ExternalInterface_FunctionalMockupUnitImport_To_Schedule_Dictionary { get; set; } = null;
        

[JsonProperty("ExternalInterface:FunctionalMockupUnitImport:To:Actuator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_To_Actuator> ExternalInterface_FunctionalMockupUnitImport_To_Actuator_Dictionary { get; set; } = null;
        

[JsonProperty("ExternalInterface:FunctionalMockupUnitImport:To:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_To_Variable> ExternalInterface_FunctionalMockupUnitImport_To_Variable_Dictionary { get; set; } = null;
        

[JsonProperty("ExternalInterface:FunctionalMockupUnitExport:From:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_From_Variable> ExternalInterface_FunctionalMockupUnitExport_From_Variable_Dictionary { get; set; } = null;
        

[JsonProperty("ExternalInterface:FunctionalMockupUnitExport:To:Schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_To_Schedule> ExternalInterface_FunctionalMockupUnitExport_To_Schedule_Dictionary { get; set; } = null;
        

[JsonProperty("ExternalInterface:FunctionalMockupUnitExport:To:Actuator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_To_Actuator> ExternalInterface_FunctionalMockupUnitExport_To_Actuator_Dictionary { get; set; } = null;
        

[JsonProperty("ExternalInterface:FunctionalMockupUnitExport:To:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_To_Variable> ExternalInterface_FunctionalMockupUnitExport_To_Variable_Dictionary { get; set; } = null;
        

[JsonProperty("Fan:SystemModel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Fans.Fan_SystemModel> Fan_SystemModel_Dictionary { get; set; } = null;
        

[JsonProperty("Fan:ConstantVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Fans.Fan_ConstantVolume> Fan_ConstantVolume_Dictionary { get; set; } = null;
        

[JsonProperty("Fan:VariableVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Fans.Fan_VariableVolume> Fan_VariableVolume_Dictionary { get; set; } = null;
        

[JsonProperty("Fan:OnOff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Fans.Fan_OnOff> Fan_OnOff_Dictionary { get; set; } = null;
        

[JsonProperty("Fan:ZoneExhaust", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Fans.Fan_ZoneExhaust> Fan_ZoneExhaust_Dictionary { get; set; } = null;
        

[JsonProperty("FanPerformance:NightVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Fans.FanPerformance_NightVentilation> FanPerformance_NightVentilation_Dictionary { get; set; } = null;
        

[JsonProperty("Fan:ComponentModel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Fans.Fan_ComponentModel> Fan_ComponentModel_Dictionary { get; set; } = null;
        

[JsonProperty("FluidProperties:Name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Name> FluidProperties_Name_Dictionary { get; set; } = null;
        

[JsonProperty("FluidProperties:GlycolConcentration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_GlycolConcentration> FluidProperties_GlycolConcentration_Dictionary { get; set; } = null;
        

[JsonProperty("FluidProperties:Temperatures", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Temperatures> FluidProperties_Temperatures_Dictionary { get; set; } = null;
        

[JsonProperty("FluidProperties:Saturated", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Saturated> FluidProperties_Saturated_Dictionary { get; set; } = null;
        

[JsonProperty("FluidProperties:Superheated", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Superheated> FluidProperties_Superheated_Dictionary { get; set; } = null;
        

[JsonProperty("FluidProperties:Concentration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Concentration> FluidProperties_Concentration_Dictionary { get; set; } = null;
        

[JsonProperty("Matrix:TwoDimension", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.GeneralDataEntry.Matrix_TwoDimension> Matrix_TwoDimension_Dictionary { get; set; } = null;
        

[JsonProperty("HeatExchanger:AirToAir:FlatPlate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_AirToAir_FlatPlate> HeatExchanger_AirToAir_FlatPlate_Dictionary { get; set; } = null;
        

[JsonProperty("HeatExchanger:AirToAir:SensibleAndLatent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_AirToAir_SensibleAndLatent> HeatExchanger_AirToAir_SensibleAndLatent_Dictionary { get; set; } = null;
        

[JsonProperty("HeatExchanger:Desiccant:BalancedFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_Desiccant_BalancedFlow> HeatExchanger_Desiccant_BalancedFlow_Dictionary { get; set; } = null;
        

[JsonProperty("HeatExchanger:Desiccant:BalancedFlow:PerformanceDataType1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_Desiccant_BalancedFlow_PerformanceDataType1> HeatExchanger_Desiccant_BalancedFlow_PerformanceDataType1_Dictionary { get; set; } = null;
        

[JsonProperty("Humidifier:Steam:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Humidifier_Steam_Electric> Humidifier_Steam_Electric_Dictionary { get; set; } = null;
        

[JsonProperty("Humidifier:Steam:Gas", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Humidifier_Steam_Gas> Humidifier_Steam_Gas_Dictionary { get; set; } = null;
        

[JsonProperty("Dehumidifier:Desiccant:NoFans", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Dehumidifier_Desiccant_NoFans> Dehumidifier_Desiccant_NoFans_Dictionary { get; set; } = null;
        

[JsonProperty("Dehumidifier:Desiccant:System", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Dehumidifier_Desiccant_System> Dehumidifier_Desiccant_System_Dictionary { get; set; } = null;
        

[JsonProperty("DesignSpecification:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_OutdoorAir> DesignSpecification_OutdoorAir_Dictionary { get; set; } = null;
        

[JsonProperty("DesignSpecification:ZoneAirDistribution", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_ZoneAirDistribution> DesignSpecification_ZoneAirDistribution_Dictionary { get; set; } = null;
        

[JsonProperty("Sizing:Parameters", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_Parameters Sizing_Parameters { get; set; } = null;
        

[JsonProperty("Sizing:Zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_Zone> Sizing_Zone_Dictionary { get; set; } = null;
        

[JsonProperty("DesignSpecification:ZoneHVAC:Sizing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_ZoneHVAC_Sizing> DesignSpecification_ZoneHVAC_Sizing_Dictionary { get; set; } = null;
        

[JsonProperty("DesignSpecification:AirTerminal:Sizing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_AirTerminal_Sizing> DesignSpecification_AirTerminal_Sizing_Dictionary { get; set; } = null;
        

[JsonProperty("Sizing:System", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_System> Sizing_System_Dictionary { get; set; } = null;
        

[JsonProperty("Sizing:Plant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_Plant> Sizing_Plant_Dictionary { get; set; } = null;
        

[JsonProperty("OutputControl:Sizing:Style", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.HVACDesignObjects.OutputControl_Sizing_Style OutputControl_Sizing_Style { get; set; } = null;
        

[JsonProperty("HVACTemplate:Thermostat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Thermostat> HVACTemplate_Thermostat_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Zone:IdealLoadsAirSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_IdealLoadsAirSystem> HVACTemplate_Zone_IdealLoadsAirSystem_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Zone:BaseboardHeat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_BaseboardHeat> HVACTemplate_Zone_BaseboardHeat_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Zone:FanCoil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_FanCoil> HVACTemplate_Zone_FanCoil_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Zone:PTAC", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_PTAC> HVACTemplate_Zone_PTAC_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Zone:PTHP", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_PTHP> HVACTemplate_Zone_PTHP_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Zone:WaterToAirHeatPump", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_WaterToAirHeatPump> HVACTemplate_Zone_WaterToAirHeatPump_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Zone:VRF", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VRF> HVACTemplate_Zone_VRF_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Zone:Unitary", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_Unitary> HVACTemplate_Zone_Unitary_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Zone:VAV", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VAV> HVACTemplate_Zone_VAV_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Zone:VAV:FanPowered", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VAV_FanPowered> HVACTemplate_Zone_VAV_FanPowered_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Zone:VAV:HeatAndCool", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VAV_HeatAndCool> HVACTemplate_Zone_VAV_HeatAndCool_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Zone:ConstantVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_ConstantVolume> HVACTemplate_Zone_ConstantVolume_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Zone:DualDuct", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_DualDuct> HVACTemplate_Zone_DualDuct_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:System:VRF", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_VRF> HVACTemplate_System_VRF_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:System:Unitary", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_Unitary> HVACTemplate_System_Unitary_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:System:UnitaryHeatPump:AirToAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_UnitaryHeatPump_AirToAir> HVACTemplate_System_UnitaryHeatPump_AirToAir_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:System:UnitarySystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_UnitarySystem> HVACTemplate_System_UnitarySystem_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:System:VAV", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_VAV> HVACTemplate_System_VAV_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:System:PackagedVAV", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_PackagedVAV> HVACTemplate_System_PackagedVAV_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:System:ConstantVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_ConstantVolume> HVACTemplate_System_ConstantVolume_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:System:DualDuct", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_DualDuct> HVACTemplate_System_DualDuct_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:System:DedicatedOutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_DedicatedOutdoorAir> HVACTemplate_System_DedicatedOutdoorAir_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Plant:ChilledWaterLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_ChilledWaterLoop HVACTemplate_Plant_ChilledWaterLoop { get; set; } = null;
        

[JsonProperty("HVACTemplate:Plant:Chiller", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Chiller> HVACTemplate_Plant_Chiller_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Plant:Chiller:ObjectReference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Chiller_ObjectReference> HVACTemplate_Plant_Chiller_ObjectReference_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Plant:Tower", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Tower> HVACTemplate_Plant_Tower_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Plant:Tower:ObjectReference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Tower_ObjectReference> HVACTemplate_Plant_Tower_ObjectReference_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Plant:HotWaterLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_HotWaterLoop HVACTemplate_Plant_HotWaterLoop { get; set; } = null;
        

[JsonProperty("HVACTemplate:Plant:Boiler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Boiler> HVACTemplate_Plant_Boiler_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Plant:Boiler:ObjectReference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Boiler_ObjectReference> HVACTemplate_Plant_Boiler_ObjectReference_Dictionary { get; set; } = null;
        

[JsonProperty("HVACTemplate:Plant:MixedWaterLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_MixedWaterLoop HVACTemplate_Plant_MixedWaterLoop { get; set; } = null;
        

[JsonProperty("HybridModel:Zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.HybridModel.HybridModel_Zone> HybridModel_Zone_Dictionary { get; set; } = null;
        

[JsonProperty("People", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.People> People_Dictionary { get; set; } = null;
        

[JsonProperty("ComfortViewFactorAngles", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.ComfortViewFactorAngles> ComfortViewFactorAngles_Dictionary { get; set; } = null;
        

[JsonProperty("Lights", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.Lights> Lights_Dictionary { get; set; } = null;
        

[JsonProperty("ElectricEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.ElectricEquipment> ElectricEquipment_Dictionary { get; set; } = null;
        

[JsonProperty("GasEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.GasEquipment> GasEquipment_Dictionary { get; set; } = null;
        

[JsonProperty("HotWaterEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.HotWaterEquipment> HotWaterEquipment_Dictionary { get; set; } = null;
        

[JsonProperty("SteamEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.SteamEquipment> SteamEquipment_Dictionary { get; set; } = null;
        

[JsonProperty("OtherEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.OtherEquipment> OtherEquipment_Dictionary { get; set; } = null;
        

[JsonProperty("ElectricEquipment:ITE:AirCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.ElectricEquipment_ITE_AirCooled> ElectricEquipment_ITE_AirCooled_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneBaseboard:OutdoorTemperatureControlled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.ZoneBaseboard_OutdoorTemperatureControlled> ZoneBaseboard_OutdoorTemperatureControlled_Dictionary { get; set; } = null;
        

[JsonProperty("SwimmingPool:Indoor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.SwimmingPool_Indoor> SwimmingPool_Indoor_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneContaminantSourceAndSink:CarbonDioxide", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_CarbonDioxide> ZoneContaminantSourceAndSink_CarbonDioxide_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneContaminantSourceAndSink:Generic:Constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_Constant> ZoneContaminantSourceAndSink_Generic_Constant_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceContaminantSourceAndSink:Generic:PressureDriven", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.SurfaceContaminantSourceAndSink_Generic_PressureDriven> SurfaceContaminantSourceAndSink_Generic_PressureDriven_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneContaminantSourceAndSink:Generic:CutoffModel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_CutoffModel> ZoneContaminantSourceAndSink_Generic_CutoffModel_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneContaminantSourceAndSink:Generic:DecaySource", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_DecaySource> ZoneContaminantSourceAndSink_Generic_DecaySource_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceContaminantSourceAndSink:Generic:BoundaryLayerDiffusion", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.SurfaceContaminantSourceAndSink_Generic_BoundaryLayerDiffusion> SurfaceContaminantSourceAndSink_Generic_BoundaryLayerDiffusion_Dictionary { get; set; } = null;
        

[JsonProperty("SurfaceContaminantSourceAndSink:Generic:DepositionVelocitySink", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.SurfaceContaminantSourceAndSink_Generic_DepositionVelocitySink> SurfaceContaminantSourceAndSink_Generic_DepositionVelocitySink_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneContaminantSourceAndSink:Generic:DepositionRateSink", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_DepositionRateSink> ZoneContaminantSourceAndSink_Generic_DepositionRateSink_Dictionary { get; set; } = null;
        

[JsonProperty("Site:Location", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_Location Site_Location { get; set; } = null;
        

[JsonProperty("Site:VariableLocation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_VariableLocation Site_VariableLocation { get; set; } = null;
        

[JsonProperty("SizingPeriod:DesignDay", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.SizingPeriod_DesignDay> SizingPeriod_DesignDay_Dictionary { get; set; } = null;
        

[JsonProperty("SizingPeriod:WeatherFileDays", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.SizingPeriod_WeatherFileDays> SizingPeriod_WeatherFileDays_Dictionary { get; set; } = null;
        

[JsonProperty("SizingPeriod:WeatherFileConditionType", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.SizingPeriod_WeatherFileConditionType> SizingPeriod_WeatherFileConditionType_Dictionary { get; set; } = null;
        

[JsonProperty("RunPeriod", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.RunPeriod> RunPeriod_Dictionary { get; set; } = null;
        

[JsonProperty("RunPeriodControl:SpecialDays", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.RunPeriodControl_SpecialDays> RunPeriodControl_SpecialDays_Dictionary { get; set; } = null;
        

[JsonProperty("RunPeriodControl:DaylightSavingTime", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.RunPeriodControl_DaylightSavingTime RunPeriodControl_DaylightSavingTime { get; set; } = null;
        

[JsonProperty("WeatherProperty:SkyTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.WeatherProperty_SkyTemperature> WeatherProperty_SkyTemperature_Dictionary { get; set; } = null;
        

[JsonProperty("Site:WeatherStation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_WeatherStation Site_WeatherStation { get; set; } = null;
        

[JsonProperty("Site:HeightVariation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_HeightVariation Site_HeightVariation { get; set; } = null;
        

[JsonProperty("Site:GroundTemperature:BuildingSurface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_BuildingSurface Site_GroundTemperature_BuildingSurface { get; set; } = null;
        

[JsonProperty("Site:GroundTemperature:FCfactorMethod", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_FCfactorMethod Site_GroundTemperature_FCfactorMethod { get; set; } = null;
        

[JsonProperty("Site:GroundTemperature:Shallow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Shallow Site_GroundTemperature_Shallow { get; set; } = null;
        

[JsonProperty("Site:GroundTemperature:Deep", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Deep Site_GroundTemperature_Deep { get; set; } = null;
        

[JsonProperty("Site:GroundTemperature:Undisturbed:FiniteDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Undisturbed_FiniteDifference> Site_GroundTemperature_Undisturbed_FiniteDifference_Dictionary { get; set; } = null;
        

[JsonProperty("Site:GroundTemperature:Undisturbed:KusudaAchenbach", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Undisturbed_KusudaAchenbach> Site_GroundTemperature_Undisturbed_KusudaAchenbach_Dictionary { get; set; } = null;
        

[JsonProperty("Site:GroundTemperature:Undisturbed:Xing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Undisturbed_Xing> Site_GroundTemperature_Undisturbed_Xing_Dictionary { get; set; } = null;
        

[JsonProperty("Site:GroundDomain:Slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundDomain_Slab> Site_GroundDomain_Slab_Dictionary { get; set; } = null;
        

[JsonProperty("Site:GroundDomain:Basement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundDomain_Basement> Site_GroundDomain_Basement_Dictionary { get; set; } = null;
        

[JsonProperty("Site:GroundReflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundReflectance Site_GroundReflectance { get; set; } = null;
        

[JsonProperty("Site:GroundReflectance:SnowModifier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundReflectance_SnowModifier> Site_GroundReflectance_SnowModifier_Dictionary { get; set; } = null;
        

[JsonProperty("Site:WaterMainsTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_WaterMainsTemperature> Site_WaterMainsTemperature_Dictionary { get; set; } = null;
        

[JsonProperty("Site:Precipitation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_Precipitation> Site_Precipitation_Dictionary { get; set; } = null;
        

[JsonProperty("RoofIrrigation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.RoofIrrigation> RoofIrrigation_Dictionary { get; set; } = null;
        

[JsonProperty("Site:SolarAndVisibleSpectrum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_SolarAndVisibleSpectrum Site_SolarAndVisibleSpectrum { get; set; } = null;
        

[JsonProperty("Site:SpectrumData", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_SpectrumData> Site_SpectrumData_Dictionary { get; set; } = null;
        

[JsonProperty("Branch", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Branch> Branch_Dictionary { get; set; } = null;
        

[JsonProperty("BranchList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.BranchList> BranchList_Dictionary { get; set; } = null;
        

[JsonProperty("Connector:Splitter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Connector_Splitter> Connector_Splitter_Dictionary { get; set; } = null;
        

[JsonProperty("Connector:Mixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Connector_Mixer> Connector_Mixer_Dictionary { get; set; } = null;
        

[JsonProperty("ConnectorList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.ConnectorList> ConnectorList_Dictionary { get; set; } = null;
        

[JsonProperty("NodeList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.NodeList> NodeList_Dictionary { get; set; } = null;
        

[JsonProperty("OutdoorAir:Node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.OutdoorAir_Node> OutdoorAir_Node_Dictionary { get; set; } = null;
        

[JsonProperty("OutdoorAir:NodeList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.OutdoorAir_NodeList> OutdoorAir_NodeList_Dictionary { get; set; } = null;
        

[JsonProperty("Pipe:Adiabatic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Adiabatic> Pipe_Adiabatic_Dictionary { get; set; } = null;
        

[JsonProperty("Pipe:Adiabatic:Steam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Adiabatic_Steam> Pipe_Adiabatic_Steam_Dictionary { get; set; } = null;
        

[JsonProperty("Pipe:Indoor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Indoor> Pipe_Indoor_Dictionary { get; set; } = null;
        

[JsonProperty("Pipe:Outdoor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Outdoor> Pipe_Outdoor_Dictionary { get; set; } = null;
        

[JsonProperty("Pipe:Underground", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Underground> Pipe_Underground_Dictionary { get; set; } = null;
        

[JsonProperty("PipingSystem:Underground:Domain", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.PipingSystem_Underground_Domain> PipingSystem_Underground_Domain_Dictionary { get; set; } = null;
        

[JsonProperty("PipingSystem:Underground:PipeCircuit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.PipingSystem_Underground_PipeCircuit> PipingSystem_Underground_PipeCircuit_Dictionary { get; set; } = null;
        

[JsonProperty("PipingSystem:Underground:PipeSegment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.PipingSystem_Underground_PipeSegment> PipingSystem_Underground_PipeSegment_Dictionary { get; set; } = null;
        

[JsonProperty("Duct", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Duct> Duct_Dictionary { get; set; } = null;
        

[JsonProperty("LoadProfile:Plant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.NonZoneEquipment.LoadProfile_Plant> LoadProfile_Plant_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:TemperatureSensorOffset:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_OutdoorAir> FaultModel_TemperatureSensorOffset_OutdoorAir_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:HumiditySensorOffset:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_HumiditySensorOffset_OutdoorAir> FaultModel_HumiditySensorOffset_OutdoorAir_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:EnthalpySensorOffset:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_EnthalpySensorOffset_OutdoorAir> FaultModel_EnthalpySensorOffset_OutdoorAir_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:TemperatureSensorOffset:ReturnAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_ReturnAir> FaultModel_TemperatureSensorOffset_ReturnAir_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:EnthalpySensorOffset:ReturnAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_EnthalpySensorOffset_ReturnAir> FaultModel_EnthalpySensorOffset_ReturnAir_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:TemperatureSensorOffset:ChillerSupplyWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_ChillerSupplyWater> FaultModel_TemperatureSensorOffset_ChillerSupplyWater_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:TemperatureSensorOffset:CoilSupplyAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_CoilSupplyAir> FaultModel_TemperatureSensorOffset_CoilSupplyAir_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:TemperatureSensorOffset:CondenserSupplyWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_CondenserSupplyWater> FaultModel_TemperatureSensorOffset_CondenserSupplyWater_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:ThermostatOffset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_ThermostatOffset> FaultModel_ThermostatOffset_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:HumidistatOffset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_HumidistatOffset> FaultModel_HumidistatOffset_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:Fouling:AirFilter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_AirFilter> FaultModel_Fouling_AirFilter_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:Fouling:Boiler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_Boiler> FaultModel_Fouling_Boiler_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:Fouling:EvaporativeCooler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_EvaporativeCooler> FaultModel_Fouling_EvaporativeCooler_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:Fouling:Chiller", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_Chiller> FaultModel_Fouling_Chiller_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:Fouling:CoolingTower", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_CoolingTower> FaultModel_Fouling_CoolingTower_Dictionary { get; set; } = null;
        

[JsonProperty("FaultModel:Fouling:Coil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_Coil> FaultModel_Fouling_Coil_Dictionary { get; set; } = null;
        

[JsonProperty("Output:VariableDictionary", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_VariableDictionary> Output_VariableDictionary_Dictionary { get; set; } = null;
        

[JsonProperty("Output:Surfaces:List", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Surfaces_List> Output_Surfaces_List_Dictionary { get; set; } = null;
        

[JsonProperty("Output:Surfaces:Drawing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Surfaces_Drawing> Output_Surfaces_Drawing_Dictionary { get; set; } = null;
        

[JsonProperty("Output:Schedules", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Schedules> Output_Schedules_Dictionary { get; set; } = null;
        

[JsonProperty("Output:Constructions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Constructions> Output_Constructions_Dictionary { get; set; } = null;
        

[JsonProperty("Output:EnergyManagementSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_EnergyManagementSystem Output_EnergyManagementSystem { get; set; } = null;
        

[JsonProperty("OutputControl:SurfaceColorScheme", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.OutputControl_SurfaceColorScheme> OutputControl_SurfaceColorScheme_Dictionary { get; set; } = null;
        

[JsonProperty("Output:Table:SummaryReports", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_SummaryReports Output_Table_SummaryReports { get; set; } = null;
        

[JsonProperty("Output:Table:TimeBins", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_TimeBins> Output_Table_TimeBins_Dictionary { get; set; } = null;
        

[JsonProperty("Output:Table:Monthly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_Monthly> Output_Table_Monthly_Dictionary { get; set; } = null;
        

[JsonProperty("Output:Table:Annual", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_Annual> Output_Table_Annual_Dictionary { get; set; } = null;
        

[JsonProperty("OutputControl:Table:Style", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.OutputControl_Table_Style OutputControl_Table_Style { get; set; } = null;
        

[JsonProperty("OutputControl:ReportingTolerances", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.OutputControl_ReportingTolerances OutputControl_ReportingTolerances { get; set; } = null;
        

[JsonProperty("Output:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Variable> Output_Variable_Dictionary { get; set; } = null;
        

[JsonProperty("Output:Meter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter> Output_Meter_Dictionary { get; set; } = null;
        

[JsonProperty("Output:Meter:MeterFileOnly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter_MeterFileOnly> Output_Meter_MeterFileOnly_Dictionary { get; set; } = null;
        

[JsonProperty("Output:Meter:Cumulative", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter_Cumulative> Output_Meter_Cumulative_Dictionary { get; set; } = null;
        

[JsonProperty("Output:Meter:Cumulative:MeterFileOnly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter_Cumulative_MeterFileOnly> Output_Meter_Cumulative_MeterFileOnly_Dictionary { get; set; } = null;
        

[JsonProperty("Meter:Custom", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Meter_Custom> Meter_Custom_Dictionary { get; set; } = null;
        

[JsonProperty("Meter:CustomDecrement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Meter_CustomDecrement> Meter_CustomDecrement_Dictionary { get; set; } = null;
        

[JsonProperty("OutputControl:Files", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.OutputControl_Files OutputControl_Files { get; set; } = null;
        

[JsonProperty("Output:JSON", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_JSON Output_JSON { get; set; } = null;
        

[JsonProperty("Output:SQLite", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_SQLite Output_SQLite { get; set; } = null;
        

[JsonProperty("Output:EnvironmentalImpactFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_EnvironmentalImpactFactors> Output_EnvironmentalImpactFactors_Dictionary { get; set; } = null;
        

[JsonProperty("EnvironmentalImpactFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.EnvironmentalImpactFactors> EnvironmentalImpactFactors_Dictionary { get; set; } = null;
        

[JsonProperty("FuelFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.FuelFactors> FuelFactors_Dictionary { get; set; } = null;
        

[JsonProperty("Output:Diagnostics", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Diagnostics Output_Diagnostics { get; set; } = null;
        

[JsonProperty("Output:DebuggingData", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_DebuggingData Output_DebuggingData { get; set; } = null;
        

[JsonProperty("Output:PreprocessorMessage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.OutputReporting.Output_PreprocessorMessage> Output_PreprocessorMessage_Dictionary { get; set; } = null;
        

[JsonProperty("Parametric:SetValueForRun", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Parametrics.Parametric_SetValueForRun> Parametric_SetValueForRun_Dictionary { get; set; } = null;
        

[JsonProperty("Parametric:Logic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Parametrics.Parametric_Logic Parametric_Logic { get; set; } = null;
        

[JsonProperty("Parametric:RunControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Parametrics.Parametric_RunControl Parametric_RunControl { get; set; } = null;
        

[JsonProperty("Parametric:FileNameSuffix", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Parametrics.Parametric_FileNameSuffix Parametric_FileNameSuffix { get; set; } = null;
        

[JsonProperty("Curve:Linear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Linear> Curve_Linear_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:QuadLinear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_QuadLinear> Curve_QuadLinear_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:QuintLinear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_QuintLinear> Curve_QuintLinear_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:Quadratic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Quadratic> Curve_Quadratic_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:Cubic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Cubic> Curve_Cubic_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:Quartic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Quartic> Curve_Quartic_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:Exponent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Exponent> Curve_Exponent_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:Bicubic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Bicubic> Curve_Bicubic_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:Biquadratic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Biquadratic> Curve_Biquadratic_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:QuadraticLinear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_QuadraticLinear> Curve_QuadraticLinear_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:CubicLinear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_CubicLinear> Curve_CubicLinear_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:Triquadratic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Triquadratic> Curve_Triquadratic_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:Functional:PressureDrop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Functional_PressureDrop> Curve_Functional_PressureDrop_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:FanPressureRise", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_FanPressureRise> Curve_FanPressureRise_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:ExponentialSkewNormal", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_ExponentialSkewNormal> Curve_ExponentialSkewNormal_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:Sigmoid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Sigmoid> Curve_Sigmoid_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:RectangularHyperbola1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_RectangularHyperbola1> Curve_RectangularHyperbola1_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:RectangularHyperbola2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_RectangularHyperbola2> Curve_RectangularHyperbola2_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:ExponentialDecay", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_ExponentialDecay> Curve_ExponentialDecay_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:DoubleExponentialDecay", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_DoubleExponentialDecay> Curve_DoubleExponentialDecay_Dictionary { get; set; } = null;
        

[JsonProperty("Curve:ChillerPartLoadWithLift", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_ChillerPartLoadWithLift> Curve_ChillerPartLoadWithLift_Dictionary { get; set; } = null;
        

[JsonProperty("Table:IndependentVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceTables.Table_IndependentVariable> Table_IndependentVariable_Dictionary { get; set; } = null;
        

[JsonProperty("Table:IndependentVariableList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceTables.Table_IndependentVariableList> Table_IndependentVariableList_Dictionary { get; set; } = null;
        

[JsonProperty("Table:Lookup", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PerformanceTables.Table_Lookup> Table_Lookup_Dictionary { get; set; } = null;
        

[JsonProperty("Boiler:HotWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Boiler_HotWater> Boiler_HotWater_Dictionary { get; set; } = null;
        

[JsonProperty("Boiler:Steam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Boiler_Steam> Boiler_Steam_Dictionary { get; set; } = null;
        

[JsonProperty("Chiller:Electric:EIR", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Electric_EIR> Chiller_Electric_EIR_Dictionary { get; set; } = null;
        

[JsonProperty("Chiller:Electric:ReformulatedEIR", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Electric_ReformulatedEIR> Chiller_Electric_ReformulatedEIR_Dictionary { get; set; } = null;
        

[JsonProperty("Chiller:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Electric> Chiller_Electric_Dictionary { get; set; } = null;
        

[JsonProperty("Chiller:Absorption:Indirect", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Absorption_Indirect> Chiller_Absorption_Indirect_Dictionary { get; set; } = null;
        

[JsonProperty("Chiller:Absorption", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Absorption> Chiller_Absorption_Dictionary { get; set; } = null;
        

[JsonProperty("Chiller:ConstantCOP", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_ConstantCOP> Chiller_ConstantCOP_Dictionary { get; set; } = null;
        

[JsonProperty("Chiller:EngineDriven", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_EngineDriven> Chiller_EngineDriven_Dictionary { get; set; } = null;
        

[JsonProperty("Chiller:CombustionTurbine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_CombustionTurbine> Chiller_CombustionTurbine_Dictionary { get; set; } = null;
        

[JsonProperty("ChillerHeater:Absorption:DirectFired", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.ChillerHeater_Absorption_DirectFired> ChillerHeater_Absorption_DirectFired_Dictionary { get; set; } = null;
        

[JsonProperty("ChillerHeater:Absorption:DoubleEffect", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.ChillerHeater_Absorption_DoubleEffect> ChillerHeater_Absorption_DoubleEffect_Dictionary { get; set; } = null;
        

[JsonProperty("HeatPump:PlantLoop:EIR:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_PlantLoop_EIR_Cooling> HeatPump_PlantLoop_EIR_Cooling_Dictionary { get; set; } = null;
        

[JsonProperty("HeatPump:PlantLoop:EIR:Heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_PlantLoop_EIR_Heating> HeatPump_PlantLoop_EIR_Heating_Dictionary { get; set; } = null;
        

[JsonProperty("HeatPump:WaterToWater:EquationFit:Heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_EquationFit_Heating> HeatPump_WaterToWater_EquationFit_Heating_Dictionary { get; set; } = null;
        

[JsonProperty("HeatPump:WaterToWater:EquationFit:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_EquationFit_Cooling> HeatPump_WaterToWater_EquationFit_Cooling_Dictionary { get; set; } = null;
        

[JsonProperty("HeatPump:WaterToWater:ParameterEstimation:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_ParameterEstimation_Cooling> HeatPump_WaterToWater_ParameterEstimation_Cooling_Dictionary { get; set; } = null;
        

[JsonProperty("HeatPump:WaterToWater:ParameterEstimation:Heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_ParameterEstimation_Heating> HeatPump_WaterToWater_ParameterEstimation_Heating_Dictionary { get; set; } = null;
        

[JsonProperty("DistrictCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.DistrictCooling> DistrictCooling_Dictionary { get; set; } = null;
        

[JsonProperty("DistrictHeating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.DistrictHeating> DistrictHeating_Dictionary { get; set; } = null;
        

[JsonProperty("PlantComponent:TemperatureSource", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.PlantComponent_TemperatureSource> PlantComponent_TemperatureSource_Dictionary { get; set; } = null;
        

[JsonProperty("CentralHeatPumpSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.CentralHeatPumpSystem> CentralHeatPumpSystem_Dictionary { get; set; } = null;
        

[JsonProperty("ChillerHeaterPerformance:Electric:EIR", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.ChillerHeaterPerformance_Electric_EIR> ChillerHeaterPerformance_Electric_EIR_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentList> PlantEquipmentList_Dictionary { get; set; } = null;
        

[JsonProperty("CondenserEquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.CondenserEquipmentList> CondenserEquipmentList_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperation:Uncontrolled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_Uncontrolled> PlantEquipmentOperation_Uncontrolled_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperation:CoolingLoad", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_CoolingLoad> PlantEquipmentOperation_CoolingLoad_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperation:HeatingLoad", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_HeatingLoad> PlantEquipmentOperation_HeatingLoad_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperation:OutdoorDryBulb", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDryBulb> PlantEquipmentOperation_OutdoorDryBulb_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperation:OutdoorWetBulb", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorWetBulb> PlantEquipmentOperation_OutdoorWetBulb_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperation:OutdoorRelativeHumidity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorRelativeHumidity> PlantEquipmentOperation_OutdoorRelativeHumidity_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperation:OutdoorDewpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDewpoint> PlantEquipmentOperation_OutdoorDewpoint_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperation:ComponentSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_ComponentSetpoint> PlantEquipmentOperation_ComponentSetpoint_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperation:ThermalEnergyStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_ThermalEnergyStorage> PlantEquipmentOperation_ThermalEnergyStorage_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperation:OutdoorDryBulbDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDryBulbDifference> PlantEquipmentOperation_OutdoorDryBulbDifference_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperation:OutdoorWetBulbDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorWetBulbDifference> PlantEquipmentOperation_OutdoorWetBulbDifference_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperation:OutdoorDewpointDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDewpointDifference> PlantEquipmentOperation_OutdoorDewpointDifference_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperationSchemes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperationSchemes> PlantEquipmentOperationSchemes_Dictionary { get; set; } = null;
        

[JsonProperty("CondenserEquipmentOperationSchemes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserControl.CondenserEquipmentOperationSchemes> CondenserEquipmentOperationSchemes_Dictionary { get; set; } = null;
        

[JsonProperty("TemperingValve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserFlowControl.TemperingValve> TemperingValve_Dictionary { get; set; } = null;
        

[JsonProperty("PlantLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserLoops.PlantLoop> PlantLoop_Dictionary { get; set; } = null;
        

[JsonProperty("CondenserLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PlantCondenserLoops.CondenserLoop> CondenserLoop_Dictionary { get; set; } = null;
        

[JsonProperty("Pump:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Pumps.Pump_VariableSpeed> Pump_VariableSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("Pump:ConstantSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Pumps.Pump_ConstantSpeed> Pump_ConstantSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("Pump:VariableSpeed:Condensate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Pumps.Pump_VariableSpeed_Condensate> Pump_VariableSpeed_Condensate_Dictionary { get; set; } = null;
        

[JsonProperty("HeaderedPumps:ConstantSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Pumps.HeaderedPumps_ConstantSpeed> HeaderedPumps_ConstantSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("HeaderedPumps:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Pumps.HeaderedPumps_VariableSpeed> HeaderedPumps_VariableSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("PythonPlugin:SearchPaths", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_SearchPaths PythonPlugin_SearchPaths { get; set; } = null;
        

[JsonProperty("PythonPlugin:Instance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_Instance> PythonPlugin_Instance_Dictionary { get; set; } = null;
        

[JsonProperty("PythonPlugin:Variables", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_Variables PythonPlugin_Variables { get; set; } = null;
        

[JsonProperty("PythonPlugin:TrendVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_TrendVariable> PythonPlugin_TrendVariable_Dictionary { get; set; } = null;
        

[JsonProperty("PythonPlugin:OutputVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_OutputVariable> PythonPlugin_OutputVariable_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:Case", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Case> Refrigeration_Case_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:CompressorRack", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_CompressorRack> Refrigeration_CompressorRack_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:CaseAndWalkInList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_CaseAndWalkInList> Refrigeration_CaseAndWalkInList_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:Condenser:AirCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_AirCooled> Refrigeration_Condenser_AirCooled_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:Condenser:EvaporativeCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_EvaporativeCooled> Refrigeration_Condenser_EvaporativeCooled_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:Condenser:WaterCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_WaterCooled> Refrigeration_Condenser_WaterCooled_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:Condenser:Cascade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_Cascade> Refrigeration_Condenser_Cascade_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:GasCooler:AirCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_GasCooler_AirCooled> Refrigeration_GasCooler_AirCooled_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:TransferLoadList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_TransferLoadList> Refrigeration_TransferLoadList_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:Subcooler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Subcooler> Refrigeration_Subcooler_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:Compressor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Compressor> Refrigeration_Compressor_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:CompressorList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_CompressorList> Refrigeration_CompressorList_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:System", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_System> Refrigeration_System_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:TranscriticalSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_TranscriticalSystem> Refrigeration_TranscriticalSystem_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:SecondarySystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_SecondarySystem> Refrigeration_SecondarySystem_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:WalkIn", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_WalkIn> Refrigeration_WalkIn_Dictionary { get; set; } = null;
        

[JsonProperty("Refrigeration:AirChiller", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_AirChiller> Refrigeration_AirChiller_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:RefrigerationChillerSet", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Refrigeration.ZoneHVAC_RefrigerationChillerSet> ZoneHVAC_RefrigerationChillerSet_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAirModelType", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirModelType> RoomAirModelType_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAir:TemperaturePattern:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_UserDefined> RoomAir_TemperaturePattern_UserDefined_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAir:TemperaturePattern:ConstantGradient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_ConstantGradient> RoomAir_TemperaturePattern_ConstantGradient_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAir:TemperaturePattern:TwoGradient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_TwoGradient> RoomAir_TemperaturePattern_TwoGradient_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAir:TemperaturePattern:NondimensionalHeight", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_NondimensionalHeight> RoomAir_TemperaturePattern_NondimensionalHeight_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAir:TemperaturePattern:SurfaceMapping", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_SurfaceMapping> RoomAir_TemperaturePattern_SurfaceMapping_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAir:Node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node> RoomAir_Node_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAirSettings:OneNodeDisplacementVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_OneNodeDisplacementVentilation> RoomAirSettings_OneNodeDisplacementVentilation_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAirSettings:ThreeNodeDisplacementVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_ThreeNodeDisplacementVentilation> RoomAirSettings_ThreeNodeDisplacementVentilation_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAirSettings:CrossVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_CrossVentilation> RoomAirSettings_CrossVentilation_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAirSettings:UnderFloorAirDistributionInterior", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_UnderFloorAirDistributionInterior> RoomAirSettings_UnderFloorAirDistributionInterior_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAirSettings:UnderFloorAirDistributionExterior", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_UnderFloorAirDistributionExterior> RoomAirSettings_UnderFloorAirDistributionExterior_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAir:Node:AirflowNetwork", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork> RoomAir_Node_AirflowNetwork_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAir:Node:AirflowNetwork:AdjacentSurfaceList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork_AdjacentSurfaceList> RoomAir_Node_AirflowNetwork_AdjacentSurfaceList_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAir:Node:AirflowNetwork:InternalGains", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork_InternalGains> RoomAir_Node_AirflowNetwork_InternalGains_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAir:Node:AirflowNetwork:HVACEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork_HVACEquipment> RoomAir_Node_AirflowNetwork_HVACEquipment_Dictionary { get; set; } = null;
        

[JsonProperty("RoomAirSettings:AirflowNetwork", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_AirflowNetwork> RoomAirSettings_AirflowNetwork_Dictionary { get; set; } = null;
        

[JsonProperty("ScheduleTypeLimits", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Schedules.ScheduleTypeLimits> ScheduleTypeLimits_Dictionary { get; set; } = null;
        

[JsonProperty("Schedule:Day:Hourly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Day_Hourly> Schedule_Day_Hourly_Dictionary { get; set; } = null;
        

[JsonProperty("Schedule:Day:Interval", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Day_Interval> Schedule_Day_Interval_Dictionary { get; set; } = null;
        

[JsonProperty("Schedule:Day:List", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Day_List> Schedule_Day_List_Dictionary { get; set; } = null;
        

[JsonProperty("Schedule:Week:Daily", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Week_Daily> Schedule_Week_Daily_Dictionary { get; set; } = null;
        

[JsonProperty("Schedule:Week:Compact", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Week_Compact> Schedule_Week_Compact_Dictionary { get; set; } = null;
        

[JsonProperty("Schedule:Year", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Year> Schedule_Year_Dictionary { get; set; } = null;
        

[JsonProperty("Schedule:Compact", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Compact> Schedule_Compact_Dictionary { get; set; } = null;
        

[JsonProperty("Schedule:Constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Constant> Schedule_Constant_Dictionary { get; set; } = null;
        

[JsonProperty("Schedule:File:Shading", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Schedules.Schedule_File_Shading Schedule_File_Shading { get; set; } = null;
        

[JsonProperty("Schedule:File", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.Schedules.Schedule_File> Schedule_File_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:Scheduled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Scheduled> SetpointManager_Scheduled_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:Scheduled:DualSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Scheduled_DualSetpoint> SetpointManager_Scheduled_DualSetpoint_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:OutdoorAirReset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_OutdoorAirReset> SetpointManager_OutdoorAirReset_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:SingleZone:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Reheat> SetpointManager_SingleZone_Reheat_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:SingleZone:Heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Heating> SetpointManager_SingleZone_Heating_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:SingleZone:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Cooling> SetpointManager_SingleZone_Cooling_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:SingleZone:Humidity:Minimum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Humidity_Minimum> SetpointManager_SingleZone_Humidity_Minimum_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:SingleZone:Humidity:Maximum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Humidity_Maximum> SetpointManager_SingleZone_Humidity_Maximum_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:MixedAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MixedAir> SetpointManager_MixedAir_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:OutdoorAirPretreat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_OutdoorAirPretreat> SetpointManager_OutdoorAirPretreat_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:Warmest", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Warmest> SetpointManager_Warmest_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:Coldest", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Coldest> SetpointManager_Coldest_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:ReturnAirBypassFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_ReturnAirBypassFlow> SetpointManager_ReturnAirBypassFlow_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:WarmestTemperatureFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_WarmestTemperatureFlow> SetpointManager_WarmestTemperatureFlow_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:MultiZone:Heating:Average", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Heating_Average> SetpointManager_MultiZone_Heating_Average_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:MultiZone:Cooling:Average", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Cooling_Average> SetpointManager_MultiZone_Cooling_Average_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:MultiZone:MinimumHumidity:Average", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_MinimumHumidity_Average> SetpointManager_MultiZone_MinimumHumidity_Average_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:MultiZone:MaximumHumidity:Average", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_MaximumHumidity_Average> SetpointManager_MultiZone_MaximumHumidity_Average_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:MultiZone:Humidity:Minimum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Humidity_Minimum> SetpointManager_MultiZone_Humidity_Minimum_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:MultiZone:Humidity:Maximum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Humidity_Maximum> SetpointManager_MultiZone_Humidity_Maximum_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:FollowOutdoorAirTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_FollowOutdoorAirTemperature> SetpointManager_FollowOutdoorAirTemperature_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:FollowSystemNodeTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_FollowSystemNodeTemperature> SetpointManager_FollowSystemNodeTemperature_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:FollowGroundTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_FollowGroundTemperature> SetpointManager_FollowGroundTemperature_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:CondenserEnteringReset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_CondenserEnteringReset> SetpointManager_CondenserEnteringReset_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:CondenserEnteringReset:Ideal", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_CondenserEnteringReset_Ideal> SetpointManager_CondenserEnteringReset_Ideal_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:SingleZone:OneStageCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_OneStageCooling> SetpointManager_SingleZone_OneStageCooling_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:SingleZone:OneStageHeating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_OneStageHeating> SetpointManager_SingleZone_OneStageHeating_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:ReturnTemperature:ChilledWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_ReturnTemperature_ChilledWater> SetpointManager_ReturnTemperature_ChilledWater_Dictionary { get; set; } = null;
        

[JsonProperty("SetpointManager:ReturnTemperature:HotWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_ReturnTemperature_HotWater> SetpointManager_ReturnTemperature_HotWater_Dictionary { get; set; } = null;
        

[JsonProperty("Version", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.Version Version { get; set; } = null;
        

[JsonProperty("SimulationControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.SimulationControl SimulationControl { get; set; } = null;
        

[JsonProperty("PerformancePrecisionTradeoffs", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.PerformancePrecisionTradeoffs PerformancePrecisionTradeoffs { get; set; } = null;
        

[JsonProperty("Building", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.Building Building { get; set; } = null;
        

[JsonProperty("ShadowCalculation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.ShadowCalculation ShadowCalculation { get; set; } = null;
        

[JsonProperty("SurfaceConvectionAlgorithm:Inside", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.SurfaceConvectionAlgorithm_Inside SurfaceConvectionAlgorithm_Inside { get; set; } = null;
        

[JsonProperty("SurfaceConvectionAlgorithm:Outside", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.SurfaceConvectionAlgorithm_Outside SurfaceConvectionAlgorithm_Outside { get; set; } = null;
        

[JsonProperty("HeatBalanceAlgorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.HeatBalanceAlgorithm HeatBalanceAlgorithm { get; set; } = null;
        

[JsonProperty("HeatBalanceSettings:ConductionFiniteDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.HeatBalanceSettings_ConductionFiniteDifference HeatBalanceSettings_ConductionFiniteDifference { get; set; } = null;
        

[JsonProperty("ZoneAirHeatBalanceAlgorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.ZoneAirHeatBalanceAlgorithm ZoneAirHeatBalanceAlgorithm { get; set; } = null;
        

[JsonProperty("ZoneAirContaminantBalance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.ZoneAirContaminantBalance ZoneAirContaminantBalance { get; set; } = null;
        

[JsonProperty("ZoneAirMassFlowConservation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.ZoneAirMassFlowConservation ZoneAirMassFlowConservation { get; set; } = null;
        

[JsonProperty("ZoneCapacitanceMultiplier:ResearchSpecial", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SimulationParameters.ZoneCapacitanceMultiplier_ResearchSpecial> ZoneCapacitanceMultiplier_ResearchSpecial_Dictionary { get; set; } = null;
        

[JsonProperty("Timestep", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.Timestep Timestep { get; set; } = null;
        

[JsonProperty("ConvergenceLimits", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.ConvergenceLimits ConvergenceLimits { get; set; } = null;
        

[JsonProperty("HVACSystemRootFindingAlgorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.HVACSystemRootFindingAlgorithm HVACSystemRootFindingAlgorithm { get; set; } = null;
        

[JsonProperty("SolarCollectorPerformance:FlatPlate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollectorPerformance_FlatPlate> SolarCollectorPerformance_FlatPlate_Dictionary { get; set; } = null;
        

[JsonProperty("SolarCollector:FlatPlate:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_FlatPlate_Water> SolarCollector_FlatPlate_Water_Dictionary { get; set; } = null;
        

[JsonProperty("SolarCollector:FlatPlate:PhotovoltaicThermal", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_FlatPlate_PhotovoltaicThermal> SolarCollector_FlatPlate_PhotovoltaicThermal_Dictionary { get; set; } = null;
        

[JsonProperty("SolarCollectorPerformance:PhotovoltaicThermal:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollectorPerformance_PhotovoltaicThermal_Simple> SolarCollectorPerformance_PhotovoltaicThermal_Simple_Dictionary { get; set; } = null;
        

[JsonProperty("SolarCollector:IntegralCollectorStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_IntegralCollectorStorage> SolarCollector_IntegralCollectorStorage_Dictionary { get; set; } = null;
        

[JsonProperty("SolarCollectorPerformance:IntegralCollectorStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollectorPerformance_IntegralCollectorStorage> SolarCollectorPerformance_IntegralCollectorStorage_Dictionary { get; set; } = null;
        

[JsonProperty("SolarCollector:UnglazedTranspired", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_UnglazedTranspired> SolarCollector_UnglazedTranspired_Dictionary { get; set; } = null;
        

[JsonProperty("SolarCollector:UnglazedTranspired:Multisystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_UnglazedTranspired_Multisystem> SolarCollector_UnglazedTranspired_Multisystem_Dictionary { get; set; } = null;
        

[JsonProperty("Material", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material> Material_Dictionary { get; set; } = null;
        

[JsonProperty("Material:NoMass", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_NoMass> Material_NoMass_Dictionary { get; set; } = null;
        

[JsonProperty("Material:InfraredTransparent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_InfraredTransparent> Material_InfraredTransparent_Dictionary { get; set; } = null;
        

[JsonProperty("Material:AirGap", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_AirGap> Material_AirGap_Dictionary { get; set; } = null;
        

[JsonProperty("Material:RoofVegetation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_RoofVegetation> Material_RoofVegetation_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:SimpleGlazingSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_SimpleGlazingSystem> WindowMaterial_SimpleGlazingSystem_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:Glazing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Glazing> WindowMaterial_Glazing_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:GlazingGroup:Thermochromic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_GlazingGroup_Thermochromic> WindowMaterial_GlazingGroup_Thermochromic_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:Glazing:RefractionExtinctionMethod", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Glazing_RefractionExtinctionMethod> WindowMaterial_Glazing_RefractionExtinctionMethod_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:Gas", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Gas> WindowMaterial_Gas_Dictionary { get; set; } = null;
        

[JsonProperty("WindowGap:SupportPillar", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowGap_SupportPillar> WindowGap_SupportPillar_Dictionary { get; set; } = null;
        

[JsonProperty("WindowGap:DeflectionState", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowGap_DeflectionState> WindowGap_DeflectionState_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:GasMixture", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_GasMixture> WindowMaterial_GasMixture_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:Gap", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Gap> WindowMaterial_Gap_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:Shade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Shade> WindowMaterial_Shade_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:ComplexShade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_ComplexShade> WindowMaterial_ComplexShade_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:Blind", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Blind> WindowMaterial_Blind_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:Screen", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Screen> WindowMaterial_Screen_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:Shade:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Shade_EquivalentLayer> WindowMaterial_Shade_EquivalentLayer_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:Drape:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Drape_EquivalentLayer> WindowMaterial_Drape_EquivalentLayer_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:Blind:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Blind_EquivalentLayer> WindowMaterial_Blind_EquivalentLayer_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:Screen:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Screen_EquivalentLayer> WindowMaterial_Screen_EquivalentLayer_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:Glazing:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Glazing_EquivalentLayer> WindowMaterial_Glazing_EquivalentLayer_Dictionary { get; set; } = null;
        

[JsonProperty("WindowMaterial:Gap:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Gap_EquivalentLayer> WindowMaterial_Gap_EquivalentLayer_Dictionary { get; set; } = null;
        

[JsonProperty("MaterialProperty:MoisturePenetrationDepth:Settings", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_MoisturePenetrationDepth_Settings> MaterialProperty_MoisturePenetrationDepth_Settings_Dictionary { get; set; } = null;
        

[JsonProperty("MaterialProperty:PhaseChange", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_PhaseChange> MaterialProperty_PhaseChange_Dictionary { get; set; } = null;
        

[JsonProperty("MaterialProperty:PhaseChangeHysteresis", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_PhaseChangeHysteresis> MaterialProperty_PhaseChangeHysteresis_Dictionary { get; set; } = null;
        

[JsonProperty("MaterialProperty:VariableThermalConductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_VariableThermalConductivity> MaterialProperty_VariableThermalConductivity_Dictionary { get; set; } = null;
        

[JsonProperty("MaterialProperty:HeatAndMoistureTransfer:Settings", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Settings> MaterialProperty_HeatAndMoistureTransfer_Settings_Dictionary { get; set; } = null;
        

[JsonProperty("MaterialProperty:HeatAndMoistureTransfer:SorptionIsotherm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_SorptionIsotherm> MaterialProperty_HeatAndMoistureTransfer_SorptionIsotherm_Dictionary { get; set; } = null;
        

[JsonProperty("MaterialProperty:HeatAndMoistureTransfer:Suction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Suction> MaterialProperty_HeatAndMoistureTransfer_Suction_Dictionary { get; set; } = null;
        

[JsonProperty("MaterialProperty:HeatAndMoistureTransfer:Redistribution", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Redistribution> MaterialProperty_HeatAndMoistureTransfer_Redistribution_Dictionary { get; set; } = null;
        

[JsonProperty("MaterialProperty:HeatAndMoistureTransfer:Diffusion", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Diffusion> MaterialProperty_HeatAndMoistureTransfer_Diffusion_Dictionary { get; set; } = null;
        

[JsonProperty("MaterialProperty:HeatAndMoistureTransfer:ThermalConductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_ThermalConductivity> MaterialProperty_HeatAndMoistureTransfer_ThermalConductivity_Dictionary { get; set; } = null;
        

[JsonProperty("MaterialProperty:GlazingSpectralData", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_GlazingSpectralData> MaterialProperty_GlazingSpectralData_Dictionary { get; set; } = null;
        

[JsonProperty("Construction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction> Construction_Dictionary { get; set; } = null;
        

[JsonProperty("Construction:CfactorUndergroundWall", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_CfactorUndergroundWall> Construction_CfactorUndergroundWall_Dictionary { get; set; } = null;
        

[JsonProperty("Construction:FfactorGroundFloor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_FfactorGroundFloor> Construction_FfactorGroundFloor_Dictionary { get; set; } = null;
        

[JsonProperty("ConstructionProperty:InternalHeatSource", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.ConstructionProperty_InternalHeatSource> ConstructionProperty_InternalHeatSource_Dictionary { get; set; } = null;
        

[JsonProperty("Construction:AirBoundary", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_AirBoundary> Construction_AirBoundary_Dictionary { get; set; } = null;
        

[JsonProperty("WindowThermalModel:Params", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowThermalModel_Params> WindowThermalModel_Params_Dictionary { get; set; } = null;
        

[JsonProperty("WindowsCalculationEngine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowsCalculationEngine> WindowsCalculationEngine_Dictionary { get; set; } = null;
        

[JsonProperty("Construction:ComplexFenestrationState", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_ComplexFenestrationState> Construction_ComplexFenestrationState_Dictionary { get; set; } = null;
        

[JsonProperty("Construction:WindowEquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_WindowEquivalentLayer> Construction_WindowEquivalentLayer_Dictionary { get; set; } = null;
        

[JsonProperty("Construction:WindowDataFile", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_WindowDataFile> Construction_WindowDataFile_Dictionary { get; set; } = null;
        

[JsonProperty("AvailabilityManager:Scheduled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_Scheduled> AvailabilityManager_Scheduled_Dictionary { get; set; } = null;
        

[JsonProperty("AvailabilityManager:ScheduledOn", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_ScheduledOn> AvailabilityManager_ScheduledOn_Dictionary { get; set; } = null;
        

[JsonProperty("AvailabilityManager:ScheduledOff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_ScheduledOff> AvailabilityManager_ScheduledOff_Dictionary { get; set; } = null;
        

[JsonProperty("AvailabilityManager:OptimumStart", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_OptimumStart> AvailabilityManager_OptimumStart_Dictionary { get; set; } = null;
        

[JsonProperty("AvailabilityManager:NightCycle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_NightCycle> AvailabilityManager_NightCycle_Dictionary { get; set; } = null;
        

[JsonProperty("AvailabilityManager:DifferentialThermostat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_DifferentialThermostat> AvailabilityManager_DifferentialThermostat_Dictionary { get; set; } = null;
        

[JsonProperty("AvailabilityManager:HighTemperatureTurnOff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_HighTemperatureTurnOff> AvailabilityManager_HighTemperatureTurnOff_Dictionary { get; set; } = null;
        

[JsonProperty("AvailabilityManager:HighTemperatureTurnOn", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_HighTemperatureTurnOn> AvailabilityManager_HighTemperatureTurnOn_Dictionary { get; set; } = null;
        

[JsonProperty("AvailabilityManager:LowTemperatureTurnOff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_LowTemperatureTurnOff> AvailabilityManager_LowTemperatureTurnOff_Dictionary { get; set; } = null;
        

[JsonProperty("AvailabilityManager:LowTemperatureTurnOn", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_LowTemperatureTurnOn> AvailabilityManager_LowTemperatureTurnOn_Dictionary { get; set; } = null;
        

[JsonProperty("AvailabilityManager:NightVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_NightVentilation> AvailabilityManager_NightVentilation_Dictionary { get; set; } = null;
        

[JsonProperty("AvailabilityManager:HybridVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_HybridVentilation> AvailabilityManager_HybridVentilation_Dictionary { get; set; } = null;
        

[JsonProperty("AvailabilityManagerAssignmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManagerAssignmentList> AvailabilityManagerAssignmentList_Dictionary { get; set; } = null;
        

[JsonProperty("GlobalGeometryRules", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GlobalGeometryRules GlobalGeometryRules { get; set; } = null;
        

[JsonProperty("GeometryTransform", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GeometryTransform GeometryTransform { get; set; } = null;
        

[JsonProperty("Zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Zone> Zone_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.ZoneList> ZoneList_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneGroup", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.ZoneGroup> ZoneGroup_Dictionary { get; set; } = null;
        

[JsonProperty("BuildingSurface:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.BuildingSurface_Detailed> BuildingSurface_Detailed_Dictionary { get; set; } = null;
        

[JsonProperty("Wall:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Detailed> Wall_Detailed_Dictionary { get; set; } = null;
        

[JsonProperty("RoofCeiling:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.RoofCeiling_Detailed> RoofCeiling_Detailed_Dictionary { get; set; } = null;
        

[JsonProperty("Floor:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_Detailed> Floor_Detailed_Dictionary { get; set; } = null;
        

[JsonProperty("Wall:Exterior", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Exterior> Wall_Exterior_Dictionary { get; set; } = null;
        

[JsonProperty("Wall:Adiabatic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Adiabatic> Wall_Adiabatic_Dictionary { get; set; } = null;
        

[JsonProperty("Wall:Underground", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Underground> Wall_Underground_Dictionary { get; set; } = null;
        

[JsonProperty("Wall:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Interzone> Wall_Interzone_Dictionary { get; set; } = null;
        

[JsonProperty("Roof", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Roof> Roof_Dictionary { get; set; } = null;
        

[JsonProperty("Ceiling:Adiabatic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Ceiling_Adiabatic> Ceiling_Adiabatic_Dictionary { get; set; } = null;
        

[JsonProperty("Ceiling:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Ceiling_Interzone> Ceiling_Interzone_Dictionary { get; set; } = null;
        

[JsonProperty("Floor:GroundContact", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_GroundContact> Floor_GroundContact_Dictionary { get; set; } = null;
        

[JsonProperty("Floor:Adiabatic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_Adiabatic> Floor_Adiabatic_Dictionary { get; set; } = null;
        

[JsonProperty("Floor:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_Interzone> Floor_Interzone_Dictionary { get; set; } = null;
        

[JsonProperty("FenestrationSurface:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.FenestrationSurface_Detailed> FenestrationSurface_Detailed_Dictionary { get; set; } = null;
        

[JsonProperty("Window", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Window> Window_Dictionary { get; set; } = null;
        

[JsonProperty("Door", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Door> Door_Dictionary { get; set; } = null;
        

[JsonProperty("GlazedDoor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GlazedDoor> GlazedDoor_Dictionary { get; set; } = null;
        

[JsonProperty("Window:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Window_Interzone> Window_Interzone_Dictionary { get; set; } = null;
        

[JsonProperty("Door:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Door_Interzone> Door_Interzone_Dictionary { get; set; } = null;
        

[JsonProperty("GlazedDoor:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GlazedDoor_Interzone> GlazedDoor_Interzone_Dictionary { get; set; } = null;
        

[JsonProperty("WindowShadingControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowShadingControl> WindowShadingControl_Dictionary { get; set; } = null;
        

[JsonProperty("WindowProperty:FrameAndDivider", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowProperty_FrameAndDivider> WindowProperty_FrameAndDivider_Dictionary { get; set; } = null;
        

[JsonProperty("WindowProperty:AirflowControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowProperty_AirflowControl> WindowProperty_AirflowControl_Dictionary { get; set; } = null;
        

[JsonProperty("WindowProperty:StormWindow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowProperty_StormWindow> WindowProperty_StormWindow_Dictionary { get; set; } = null;
        

[JsonProperty("InternalMass", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.InternalMass> InternalMass_Dictionary { get; set; } = null;
        

[JsonProperty("Shading:Site", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Site> Shading_Site_Dictionary { get; set; } = null;
        

[JsonProperty("Shading:Building", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Building> Shading_Building_Dictionary { get; set; } = null;
        

[JsonProperty("Shading:Site:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Site_Detailed> Shading_Site_Detailed_Dictionary { get; set; } = null;
        

[JsonProperty("Shading:Building:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Building_Detailed> Shading_Building_Detailed_Dictionary { get; set; } = null;
        

[JsonProperty("Shading:Overhang", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Overhang> Shading_Overhang_Dictionary { get; set; } = null;
        

[JsonProperty("Shading:Overhang:Projection", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Overhang_Projection> Shading_Overhang_Projection_Dictionary { get; set; } = null;
        

[JsonProperty("Shading:Fin", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Fin> Shading_Fin_Dictionary { get; set; } = null;
        

[JsonProperty("Shading:Fin:Projection", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Fin_Projection> Shading_Fin_Projection_Dictionary { get; set; } = null;
        

[JsonProperty("Shading:Zone:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Zone_Detailed> Shading_Zone_Detailed_Dictionary { get; set; } = null;
        

[JsonProperty("ShadingProperty:Reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.ShadingProperty_Reflectance> ShadingProperty_Reflectance_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:UnitarySystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitarySystem> AirLoopHVAC_UnitarySystem_Dictionary { get; set; } = null;
        

[JsonProperty("UnitarySystemPerformance:Multispeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UnitaryEquipment.UnitarySystemPerformance_Multispeed> UnitarySystemPerformance_Multispeed_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:Unitary:Furnace:HeatOnly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_Unitary_Furnace_HeatOnly> AirLoopHVAC_Unitary_Furnace_HeatOnly_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:Unitary:Furnace:HeatCool", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_Unitary_Furnace_HeatCool> AirLoopHVAC_Unitary_Furnace_HeatCool_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:UnitaryHeatOnly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatOnly> AirLoopHVAC_UnitaryHeatOnly_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:UnitaryHeatCool", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatCool> AirLoopHVAC_UnitaryHeatCool_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:UnitaryHeatPump:AirToAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatPump_AirToAir> AirLoopHVAC_UnitaryHeatPump_AirToAir_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:UnitaryHeatPump:WaterToAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatPump_WaterToAir> AirLoopHVAC_UnitaryHeatPump_WaterToAir_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:UnitaryHeatCool:VAVChangeoverBypass", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass> AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_Dictionary { get; set; } = null;
        

[JsonProperty("AirLoopHVAC:UnitaryHeatPump:AirToAir:MultiSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed> AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:ForcedAir:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.ZoneHVAC_ForcedAir_UserDefined> ZoneHVAC_ForcedAir_UserDefined_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.AirTerminal_SingleDuct_UserDefined> AirTerminal_SingleDuct_UserDefined_Dictionary { get; set; } = null;
        

[JsonProperty("Coil:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.Coil_UserDefined> Coil_UserDefined_Dictionary { get; set; } = null;
        

[JsonProperty("PlantComponent:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.PlantComponent_UserDefined> PlantComponent_UserDefined_Dictionary { get; set; } = null;
        

[JsonProperty("PlantEquipmentOperation:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.PlantEquipmentOperation_UserDefined> PlantEquipmentOperation_UserDefined_Dictionary { get; set; } = null;
        

[JsonProperty("AirConditioner:VariableRefrigerantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow> AirConditioner_VariableRefrigerantFlow_Dictionary { get; set; } = null;
        

[JsonProperty("AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl> AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_Dictionary { get; set; } = null;
        

[JsonProperty("AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:HR", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR> AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneTerminalUnitList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.ZoneTerminalUnitList> ZoneTerminalUnitList_Dictionary { get; set; } = null;
        

[JsonProperty("WaterHeater:Mixed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_Mixed> WaterHeater_Mixed_Dictionary { get; set; } = null;
        

[JsonProperty("WaterHeater:Stratified", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_Stratified> WaterHeater_Stratified_Dictionary { get; set; } = null;
        

[JsonProperty("WaterHeater:Sizing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_Sizing> WaterHeater_Sizing_Dictionary { get; set; } = null;
        

[JsonProperty("WaterHeater:HeatPump:PumpedCondenser", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_HeatPump_PumpedCondenser> WaterHeater_HeatPump_PumpedCondenser_Dictionary { get; set; } = null;
        

[JsonProperty("WaterHeater:HeatPump:WrappedCondenser", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_HeatPump_WrappedCondenser> WaterHeater_HeatPump_WrappedCondenser_Dictionary { get; set; } = null;
        

[JsonProperty("ThermalStorage:Ice:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_Ice_Simple> ThermalStorage_Ice_Simple_Dictionary { get; set; } = null;
        

[JsonProperty("ThermalStorage:Ice:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_Ice_Detailed> ThermalStorage_Ice_Detailed_Dictionary { get; set; } = null;
        

[JsonProperty("ThermalStorage:ChilledWater:Mixed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_ChilledWater_Mixed> ThermalStorage_ChilledWater_Mixed_Dictionary { get; set; } = null;
        

[JsonProperty("ThermalStorage:ChilledWater:Stratified", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_ChilledWater_Stratified> ThermalStorage_ChilledWater_Stratified_Dictionary { get; set; } = null;
        

[JsonProperty("WaterUse:Equipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Equipment> WaterUse_Equipment_Dictionary { get; set; } = null;
        

[JsonProperty("WaterUse:Connections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Connections> WaterUse_Connections_Dictionary { get; set; } = null;
        

[JsonProperty("WaterUse:Storage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Storage> WaterUse_Storage_Dictionary { get; set; } = null;
        

[JsonProperty("WaterUse:Well", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Well> WaterUse_Well_Dictionary { get; set; } = null;
        

[JsonProperty("WaterUse:RainCollector", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_RainCollector> WaterUse_RainCollector_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneInfiltration:DesignFlowRate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneInfiltration_DesignFlowRate> ZoneInfiltration_DesignFlowRate_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneInfiltration:EffectiveLeakageArea", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneInfiltration_EffectiveLeakageArea> ZoneInfiltration_EffectiveLeakageArea_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneInfiltration:FlowCoefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneInfiltration_FlowCoefficient> ZoneInfiltration_FlowCoefficient_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneVentilation:DesignFlowRate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneVentilation_DesignFlowRate> ZoneVentilation_DesignFlowRate_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneVentilation:WindandStackOpenArea", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneVentilation_WindandStackOpenArea> ZoneVentilation_WindandStackOpenArea_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneAirBalance:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneAirBalance_OutdoorAir> ZoneAirBalance_OutdoorAir_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneMixing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneMixing> ZoneMixing_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneCrossMixing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneCrossMixing> ZoneCrossMixing_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneRefrigerationDoorMixing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneRefrigerationDoorMixing> ZoneRefrigerationDoorMixing_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneEarthtube", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneEarthtube> ZoneEarthtube_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneCoolTower:Shower", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneCoolTower_Shower> ZoneCoolTower_Shower_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneThermalChimney", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneThermalChimney> ZoneThermalChimney_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:ConstantVolume:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_Reheat> AirTerminal_SingleDuct_ConstantVolume_Reheat_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:ConstantVolume:NoReheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_NoReheat> AirTerminal_SingleDuct_ConstantVolume_NoReheat_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:VAV:NoReheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_NoReheat> AirTerminal_SingleDuct_VAV_NoReheat_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:VAV:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_Reheat> AirTerminal_SingleDuct_VAV_Reheat_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:VAV:Reheat:VariableSpeedFan", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan> AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:VAV:HeatAndCool:NoReheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_HeatAndCool_NoReheat> AirTerminal_SingleDuct_VAV_HeatAndCool_NoReheat_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:VAV:HeatAndCool:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat> AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:SeriesPIU:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_SeriesPIU_Reheat> AirTerminal_SingleDuct_SeriesPIU_Reheat_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:ParallelPIU:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ParallelPIU_Reheat> AirTerminal_SingleDuct_ParallelPIU_Reheat_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:ConstantVolume:FourPipeInduction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction> AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:ConstantVolume:FourPipeBeam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_FourPipeBeam> AirTerminal_SingleDuct_ConstantVolume_FourPipeBeam_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:ConstantVolume:CooledBeam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_CooledBeam> AirTerminal_SingleDuct_ConstantVolume_CooledBeam_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:SingleDuct:Mixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_Mixer> AirTerminal_SingleDuct_Mixer_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:DualDuct:ConstantVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_DualDuct_ConstantVolume> AirTerminal_DualDuct_ConstantVolume_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:DualDuct:VAV", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_DualDuct_VAV> AirTerminal_DualDuct_VAV_Dictionary { get; set; } = null;
        

[JsonProperty("AirTerminal:DualDuct:VAV:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_DualDuct_VAV_OutdoorAir> AirTerminal_DualDuct_VAV_OutdoorAir_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:AirDistributionUnit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.ZoneHVAC_AirDistributionUnit> ZoneHVAC_AirDistributionUnit_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneControl:Humidistat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Humidistat> ZoneControl_Humidistat_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneControl:Thermostat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat> ZoneControl_Thermostat_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneControl:Thermostat:OperativeTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_OperativeTemperature> ZoneControl_Thermostat_OperativeTemperature_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneControl:Thermostat:ThermalComfort", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_ThermalComfort> ZoneControl_Thermostat_ThermalComfort_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneControl:Thermostat:TemperatureAndHumidity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_TemperatureAndHumidity> ZoneControl_Thermostat_TemperatureAndHumidity_Dictionary { get; set; } = null;
        

[JsonProperty("ThermostatSetpoint:SingleHeating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_SingleHeating> ThermostatSetpoint_SingleHeating_Dictionary { get; set; } = null;
        

[JsonProperty("ThermostatSetpoint:SingleCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_SingleCooling> ThermostatSetpoint_SingleCooling_Dictionary { get; set; } = null;
        

[JsonProperty("ThermostatSetpoint:SingleHeatingOrCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_SingleHeatingOrCooling> ThermostatSetpoint_SingleHeatingOrCooling_Dictionary { get; set; } = null;
        

[JsonProperty("ThermostatSetpoint:DualSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_DualSetpoint> ThermostatSetpoint_DualSetpoint_Dictionary { get; set; } = null;
        

[JsonProperty("ThermostatSetpoint:ThermalComfort:Fanger:SingleHeating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_SingleHeating> ThermostatSetpoint_ThermalComfort_Fanger_SingleHeating_Dictionary { get; set; } = null;
        

[JsonProperty("ThermostatSetpoint:ThermalComfort:Fanger:SingleCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_SingleCooling> ThermostatSetpoint_ThermalComfort_Fanger_SingleCooling_Dictionary { get; set; } = null;
        

[JsonProperty("ThermostatSetpoint:ThermalComfort:Fanger:SingleHeatingOrCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_SingleHeatingOrCooling> ThermostatSetpoint_ThermalComfort_Fanger_SingleHeatingOrCooling_Dictionary { get; set; } = null;
        

[JsonProperty("ThermostatSetpoint:ThermalComfort:Fanger:DualSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_DualSetpoint> ThermostatSetpoint_ThermalComfort_Fanger_DualSetpoint_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneControl:Thermostat:StagedDualSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_StagedDualSetpoint> ZoneControl_Thermostat_StagedDualSetpoint_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneControl:ContaminantController", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_ContaminantController> ZoneControl_ContaminantController_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:EquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections.ZoneHVAC_EquipmentList> ZoneHVAC_EquipmentList_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:EquipmentConnections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections.ZoneHVAC_EquipmentConnections> ZoneHVAC_EquipmentConnections_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:IdealLoadsAirSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_IdealLoadsAirSystem> ZoneHVAC_IdealLoadsAirSystem_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:FourPipeFanCoil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_FourPipeFanCoil> ZoneHVAC_FourPipeFanCoil_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:WindowAirConditioner", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_WindowAirConditioner> ZoneHVAC_WindowAirConditioner_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:PackagedTerminalAirConditioner", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_PackagedTerminalAirConditioner> ZoneHVAC_PackagedTerminalAirConditioner_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:PackagedTerminalHeatPump", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_PackagedTerminalHeatPump> ZoneHVAC_PackagedTerminalHeatPump_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:WaterToAirHeatPump", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_WaterToAirHeatPump> ZoneHVAC_WaterToAirHeatPump_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:Dehumidifier:DX", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_Dehumidifier_DX> ZoneHVAC_Dehumidifier_DX_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:EnergyRecoveryVentilator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_EnergyRecoveryVentilator> ZoneHVAC_EnergyRecoveryVentilator_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:EnergyRecoveryVentilator:Controller", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_EnergyRecoveryVentilator_Controller> ZoneHVAC_EnergyRecoveryVentilator_Controller_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:UnitVentilator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_UnitVentilator> ZoneHVAC_UnitVentilator_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:UnitHeater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_UnitHeater> ZoneHVAC_UnitHeater_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:EvaporativeCoolerUnit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_EvaporativeCoolerUnit> ZoneHVAC_EvaporativeCoolerUnit_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:HybridUnitaryHVAC", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_HybridUnitaryHVAC> ZoneHVAC_HybridUnitaryHVAC_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:OutdoorAirUnit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_OutdoorAirUnit> ZoneHVAC_OutdoorAirUnit_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:OutdoorAirUnit:EquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_OutdoorAirUnit_EquipmentList> ZoneHVAC_OutdoorAirUnit_EquipmentList_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:TerminalUnit:VariableRefrigerantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_TerminalUnit_VariableRefrigerantFlow> ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:Baseboard:RadiantConvective:Water:Design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Water_Design> ZoneHVAC_Baseboard_RadiantConvective_Water_Design_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:Baseboard:RadiantConvective:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Water> ZoneHVAC_Baseboard_RadiantConvective_Water_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:Baseboard:RadiantConvective:Steam:Design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Steam_Design> ZoneHVAC_Baseboard_RadiantConvective_Steam_Design_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:Baseboard:RadiantConvective:Steam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Steam> ZoneHVAC_Baseboard_RadiantConvective_Steam_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:Baseboard:RadiantConvective:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Electric> ZoneHVAC_Baseboard_RadiantConvective_Electric_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:CoolingPanel:RadiantConvective:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_CoolingPanel_RadiantConvective_Water> ZoneHVAC_CoolingPanel_RadiantConvective_Water_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:Baseboard:Convective:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_Convective_Water> ZoneHVAC_Baseboard_Convective_Water_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:Baseboard:Convective:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_Convective_Electric> ZoneHVAC_Baseboard_Convective_Electric_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:LowTemperatureRadiant:VariableFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_VariableFlow> ZoneHVAC_LowTemperatureRadiant_VariableFlow_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:LowTemperatureRadiant:VariableFlow:Design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design> ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:LowTemperatureRadiant:ConstantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_ConstantFlow> ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:LowTemperatureRadiant:ConstantFlow:Design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design> ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:LowTemperatureRadiant:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_Electric> ZoneHVAC_LowTemperatureRadiant_Electric_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:LowTemperatureRadiant:SurfaceGroup", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_SurfaceGroup> ZoneHVAC_LowTemperatureRadiant_SurfaceGroup_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:HighTemperatureRadiant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_HighTemperatureRadiant> ZoneHVAC_HighTemperatureRadiant_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:VentilatedSlab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_VentilatedSlab> ZoneHVAC_VentilatedSlab_Dictionary { get; set; } = null;
        

[JsonProperty("ZoneHVAC:VentilatedSlab:SlabGroup", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.Dictionary<string, BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_VentilatedSlab_SlabGroup> ZoneHVAC_VentilatedSlab_SlabGroup_Dictionary { get; set; } = null;
    }
}
