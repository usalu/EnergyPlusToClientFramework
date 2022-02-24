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
    public class EnergyPlusJson : BHoMObject
    {
        

[JsonProperty(PropertyName="SurfaceProperty:HeatTransferAlgorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm> SurfaceProperty_HeatTransferAlgorithm_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:HeatTransferAlgorithm:MultipleSurface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm_MultipleSurface> SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:HeatTransferAlgorithm:SurfaceList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm_SurfaceList> SurfaceProperty_HeatTransferAlgorithm_SurfaceList_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:HeatTransferAlgorithm:Construction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm_Construction> SurfaceProperty_HeatTransferAlgorithm_Construction_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:HeatBalanceSourceTerm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatBalanceSourceTerm> SurfaceProperty_HeatBalanceSourceTerm_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceControl:MovableInsulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceControl_MovableInsulation> SurfaceControl_MovableInsulation_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:OtherSideCoefficients", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_OtherSideCoefficients> SurfaceProperty_OtherSideCoefficients_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:OtherSideConditionsModel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_OtherSideConditionsModel> SurfaceProperty_OtherSideConditionsModel_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:Underwater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_Underwater> SurfaceProperty_Underwater_List { get; set; } = null;
        

[JsonProperty(PropertyName="Foundation:Kiva", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.Foundation_Kiva> Foundation_Kiva_List { get; set; } = null;
        

[JsonProperty(PropertyName="Foundation:Kiva:Settings", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.Foundation_Kiva_Settings> Foundation_Kiva_Settings_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:ExposedFoundationPerimeter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ExposedFoundationPerimeter> SurfaceProperty_ExposedFoundationPerimeter_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceConvectionAlgorithm:Inside:AdaptiveModelSelections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceConvectionAlgorithm:Outside:AdaptiveModelSelections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceConvectionAlgorithm:Inside:UserCurve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Inside_UserCurve> SurfaceConvectionAlgorithm_Inside_UserCurve_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceConvectionAlgorithm:Outside:UserCurve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Outside_UserCurve> SurfaceConvectionAlgorithm_Outside_UserCurve_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:ConvectionCoefficients", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ConvectionCoefficients> SurfaceProperty_ConvectionCoefficients_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:ConvectionCoefficients:MultipleSurface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ConvectionCoefficients_MultipleSurface> SurfaceProperty_ConvectionCoefficients_MultipleSurface_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperties:VaporCoefficients", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperties_VaporCoefficients> SurfaceProperties_VaporCoefficients_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:ExteriorNaturalVentedCavity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ExteriorNaturalVentedCavity> SurfaceProperty_ExteriorNaturalVentedCavity_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:SolarIncidentInside", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_SolarIncidentInside> SurfaceProperty_SolarIncidentInside_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:LocalEnvironment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_LocalEnvironment> SurfaceProperty_LocalEnvironment_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneProperty:LocalEnvironment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.ZoneProperty_LocalEnvironment> ZoneProperty_LocalEnvironment_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceProperty:SurroundingSurfaces", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_SurroundingSurfaces> SurfaceProperty_SurroundingSurfaces_List { get; set; } = null;
        

[JsonProperty(PropertyName="ComplexFenestrationProperty:SolarAbsorbedLayers", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.ComplexFenestrationProperty_SolarAbsorbedLayers> ComplexFenestrationProperty_SolarAbsorbedLayers_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneProperty:UserViewFactors:BySurfaceName", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.ZoneProperty_UserViewFactors_BySurfaceName> ZoneProperty_UserViewFactors_BySurfaceName_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC> AirLoopHVAC_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:OutdoorAirSystem:EquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_OutdoorAirSystem_EquipmentList> AirLoopHVAC_OutdoorAirSystem_EquipmentList_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:OutdoorAirSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_OutdoorAirSystem> AirLoopHVAC_OutdoorAirSystem_List { get; set; } = null;
        

[JsonProperty(PropertyName="OutdoorAir:Mixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.OutdoorAir_Mixer> OutdoorAir_Mixer_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:ZoneSplitter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ZoneSplitter> AirLoopHVAC_ZoneSplitter_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:SupplyPlenum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_SupplyPlenum> AirLoopHVAC_SupplyPlenum_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:SupplyPath", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_SupplyPath> AirLoopHVAC_SupplyPath_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:ZoneMixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ZoneMixer> AirLoopHVAC_ZoneMixer_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:ReturnPlenum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ReturnPlenum> AirLoopHVAC_ReturnPlenum_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:ReturnPath", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ReturnPath> AirLoopHVAC_ReturnPath_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:DedicatedOutdoorAirSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_DedicatedOutdoorAirSystem> AirLoopHVAC_DedicatedOutdoorAirSystem_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:Mixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_Mixer> AirLoopHVAC_Mixer_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:Splitter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_Splitter> AirLoopHVAC_Splitter_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:SimulationControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_SimulationControl AirflowNetwork_SimulationControl { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:MultiZone:Zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Zone> AirflowNetwork_MultiZone_Zone_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:MultiZone:Surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Surface> AirflowNetwork_MultiZone_Surface_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:MultiZone:ReferenceCrackConditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_ReferenceCrackConditions> AirflowNetwork_MultiZone_ReferenceCrackConditions_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:MultiZone:Surface:Crack", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Surface_Crack> AirflowNetwork_MultiZone_Surface_Crack_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:MultiZone:Surface:EffectiveLeakageArea", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Surface_EffectiveLeakageArea> AirflowNetwork_MultiZone_Surface_EffectiveLeakageArea_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:MultiZone:Component:DetailedOpening", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_DetailedOpening> AirflowNetwork_MultiZone_Component_DetailedOpening_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:MultiZone:Component:SimpleOpening", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_SimpleOpening> AirflowNetwork_MultiZone_Component_SimpleOpening_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:MultiZone:Component:HorizontalOpening", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_HorizontalOpening> AirflowNetwork_MultiZone_Component_HorizontalOpening_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:MultiZone:Component:ZoneExhaustFan", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_ZoneExhaustFan> AirflowNetwork_MultiZone_Component_ZoneExhaustFan_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:MultiZone:ExternalNode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_ExternalNode> AirflowNetwork_MultiZone_ExternalNode_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:MultiZone:WindPressureCoefficientArray", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_WindPressureCoefficientArray> AirflowNetwork_MultiZone_WindPressureCoefficientArray_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:MultiZone:WindPressureCoefficientValues", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_WindPressureCoefficientValues> AirflowNetwork_MultiZone_WindPressureCoefficientValues_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:ZoneControl:PressureController", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_ZoneControl_PressureController AirflowNetwork_ZoneControl_PressureController { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:Distribution:Node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Node> AirflowNetwork_Distribution_Node_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:Leak", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Leak> AirflowNetwork_Distribution_Component_Leak_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:LeakageRatio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_LeakageRatio> AirflowNetwork_Distribution_Component_LeakageRatio_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:Duct", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Duct> AirflowNetwork_Distribution_Component_Duct_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:Fan", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Fan> AirflowNetwork_Distribution_Component_Fan_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:Coil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Coil> AirflowNetwork_Distribution_Component_Coil_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:HeatExchanger", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_HeatExchanger> AirflowNetwork_Distribution_Component_HeatExchanger_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:TerminalUnit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_TerminalUnit> AirflowNetwork_Distribution_Component_TerminalUnit_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:ConstantPressureDrop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_ConstantPressureDrop> AirflowNetwork_Distribution_Component_ConstantPressureDrop_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:OutdoorAirFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_OutdoorAirFlow> AirflowNetwork_Distribution_Component_OutdoorAirFlow_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:ReliefAirFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_ReliefAirFlow> AirflowNetwork_Distribution_Component_ReliefAirFlow_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:Distribution:Linkage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Linkage> AirflowNetwork_Distribution_Linkage_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:Distribution:DuctViewFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_DuctViewFactors> AirflowNetwork_Distribution_DuctViewFactors_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:OccupantVentilationControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_OccupantVentilationControl> AirflowNetwork_OccupantVentilationControl_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:IntraZone:Node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_IntraZone_Node> AirflowNetwork_IntraZone_Node_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirflowNetwork:IntraZone:Linkage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_IntraZone_Linkage> AirflowNetwork_IntraZone_Linkage_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_Water> Coil_Cooling_Water_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:Water:DetailedGeometry", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_Water_DetailedGeometry> Coil_Cooling_Water_DetailedGeometry_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:DX", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX> Coil_Cooling_DX_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:DX:CurveFit:Performance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_CurveFit_Performance> Coil_Cooling_DX_CurveFit_Performance_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:DX:CurveFit:OperatingMode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_CurveFit_OperatingMode> Coil_Cooling_DX_CurveFit_OperatingMode_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:DX:CurveFit:Speed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_CurveFit_Speed> Coil_Cooling_DX_CurveFit_Speed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:DX:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_SingleSpeed> Coil_Cooling_DX_SingleSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:DX:TwoSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_TwoSpeed> Coil_Cooling_DX_TwoSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:DX:MultiSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_MultiSpeed> Coil_Cooling_DX_MultiSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:DX:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_VariableSpeed> Coil_Cooling_DX_VariableSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:DX:TwoStageWithHumidityControlMode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_TwoStageWithHumidityControlMode> Coil_Cooling_DX_TwoStageWithHumidityControlMode_List { get; set; } = null;
        

[JsonProperty(PropertyName="CoilPerformance:DX:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilPerformance_DX_Cooling> CoilPerformance_DX_Cooling_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:DX:VariableRefrigerantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_VariableRefrigerantFlow> Coil_Cooling_DX_VariableRefrigerantFlow_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:DX:VariableRefrigerantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_VariableRefrigerantFlow> Coil_Heating_DX_VariableRefrigerantFlow_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:DX:VariableRefrigerantFlow:FluidTemperatureControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_VariableRefrigerantFlow_FluidTemperatureControl> Coil_Cooling_DX_VariableRefrigerantFlow_FluidTemperatureControl_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:DX:VariableRefrigerantFlow:FluidTemperatureControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_VariableRefrigerantFlow_FluidTemperatureControl> Coil_Heating_DX_VariableRefrigerantFlow_FluidTemperatureControl_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Water> Coil_Heating_Water_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:Steam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Steam> Coil_Heating_Steam_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Electric> Coil_Heating_Electric_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:Electric:MultiStage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Electric_MultiStage> Coil_Heating_Electric_MultiStage_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:Fuel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Fuel> Coil_Heating_Fuel_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:Gas:MultiStage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Gas_MultiStage> Coil_Heating_Gas_MultiStage_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:Desuperheater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Desuperheater> Coil_Heating_Desuperheater_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:DX:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_SingleSpeed> Coil_Heating_DX_SingleSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:DX:MultiSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_MultiSpeed> Coil_Heating_DX_MultiSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:DX:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_VariableSpeed> Coil_Heating_DX_VariableSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:WaterToAirHeatPump:ParameterEstimation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_WaterToAirHeatPump_ParameterEstimation> Coil_Cooling_WaterToAirHeatPump_ParameterEstimation_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:WaterToAirHeatPump:ParameterEstimation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_WaterToAirHeatPump_ParameterEstimation> Coil_Heating_WaterToAirHeatPump_ParameterEstimation_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:WaterToAirHeatPump:EquationFit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_WaterToAirHeatPump_EquationFit> Coil_Cooling_WaterToAirHeatPump_EquationFit_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:WaterToAirHeatPump:VariableSpeedEquationFit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_WaterToAirHeatPump_VariableSpeedEquationFit> Coil_Cooling_WaterToAirHeatPump_VariableSpeedEquationFit_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:WaterToAirHeatPump:EquationFit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_WaterToAirHeatPump_EquationFit> Coil_Heating_WaterToAirHeatPump_EquationFit_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Heating:WaterToAirHeatPump:VariableSpeedEquationFit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_WaterToAirHeatPump_VariableSpeedEquationFit> Coil_Heating_WaterToAirHeatPump_VariableSpeedEquationFit_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:WaterHeating:AirToWaterHeatPump:Pumped", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_AirToWaterHeatPump_Pumped> Coil_WaterHeating_AirToWaterHeatPump_Pumped_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:WaterHeating:AirToWaterHeatPump:Wrapped", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_AirToWaterHeatPump_Wrapped> Coil_WaterHeating_AirToWaterHeatPump_Wrapped_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:WaterHeating:AirToWaterHeatPump:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed> Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:WaterHeating:Desuperheater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_Desuperheater> Coil_WaterHeating_Desuperheater_List { get; set; } = null;
        

[JsonProperty(PropertyName="CoilSystem:Cooling:DX", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Cooling_DX> CoilSystem_Cooling_DX_List { get; set; } = null;
        

[JsonProperty(PropertyName="CoilSystem:Heating:DX", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Heating_DX> CoilSystem_Heating_DX_List { get; set; } = null;
        

[JsonProperty(PropertyName="CoilSystem:Cooling:Water:HeatExchangerAssisted", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Cooling_Water_HeatExchangerAssisted> CoilSystem_Cooling_Water_HeatExchangerAssisted_List { get; set; } = null;
        

[JsonProperty(PropertyName="CoilSystem:Cooling:DX:HeatExchangerAssisted", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Cooling_DX_HeatExchangerAssisted> CoilSystem_Cooling_DX_HeatExchangerAssisted_List { get; set; } = null;
        

[JsonProperty(PropertyName="CoilSystem:IntegratedHeatPump:AirSource", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_IntegratedHeatPump_AirSource> CoilSystem_IntegratedHeatPump_AirSource_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:Cooling:DX:SingleSpeed:ThermalStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_SingleSpeed_ThermalStorage> Coil_Cooling_DX_SingleSpeed_ThermalStorage_List { get; set; } = null;
        

[JsonProperty(PropertyName="Compliance:Building", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.ComplianceObjects.Compliance_Building Compliance_Building { get; set; } = null;
        

[JsonProperty(PropertyName="CoolingTower:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_SingleSpeed> CoolingTower_SingleSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="CoolingTower:TwoSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_TwoSpeed> CoolingTower_TwoSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="CoolingTower:VariableSpeed:Merkel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_VariableSpeed_Merkel> CoolingTower_VariableSpeed_Merkel_List { get; set; } = null;
        

[JsonProperty(PropertyName="CoolingTower:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_VariableSpeed> CoolingTower_VariableSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="CoolingTowerPerformance:CoolTools", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTowerPerformance_CoolTools> CoolingTowerPerformance_CoolTools_List { get; set; } = null;
        

[JsonProperty(PropertyName="CoolingTowerPerformance:YorkCalc", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTowerPerformance_YorkCalc> CoolingTowerPerformance_YorkCalc_List { get; set; } = null;
        

[JsonProperty(PropertyName="EvaporativeFluidCooler:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.EvaporativeFluidCooler_SingleSpeed> EvaporativeFluidCooler_SingleSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="EvaporativeFluidCooler:TwoSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.EvaporativeFluidCooler_TwoSpeed> EvaporativeFluidCooler_TwoSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="FluidCooler:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.FluidCooler_SingleSpeed> FluidCooler_SingleSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="FluidCooler:TwoSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.FluidCooler_TwoSpeed> FluidCooler_TwoSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatExchanger:System", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_System> GroundHeatExchanger_System_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatExchanger:Vertical:Properties", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Vertical_Properties> GroundHeatExchanger_Vertical_Properties_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatExchanger:Vertical:Array", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Vertical_Array> GroundHeatExchanger_Vertical_Array_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatExchanger:Vertical:Single", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Vertical_Single> GroundHeatExchanger_Vertical_Single_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatExchanger:ResponseFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_ResponseFactors> GroundHeatExchanger_ResponseFactors_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatExchanger:Pond", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Pond> GroundHeatExchanger_Pond_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatExchanger:Surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Surface> GroundHeatExchanger_Surface_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatExchanger:HorizontalTrench", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_HorizontalTrench> GroundHeatExchanger_HorizontalTrench_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatExchanger:Slinky", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Slinky> GroundHeatExchanger_Slinky_List { get; set; } = null;
        

[JsonProperty(PropertyName="HeatExchanger:FluidToFluid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.HeatExchanger_FluidToFluid> HeatExchanger_FluidToFluid_List { get; set; } = null;
        

[JsonProperty(PropertyName="Controller:WaterCoil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Controllers.Controller_WaterCoil> Controller_WaterCoil_List { get; set; } = null;
        

[JsonProperty(PropertyName="Controller:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Controllers.Controller_OutdoorAir> Controller_OutdoorAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="Controller:MechanicalVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Controllers.Controller_MechanicalVentilation> Controller_MechanicalVentilation_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:ControllerList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Controllers.AirLoopHVAC_ControllerList> AirLoopHVAC_ControllerList_List { get; set; } = null;
        

[JsonProperty(PropertyName="Daylighting:Controls", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Daylighting_Controls> Daylighting_Controls_List { get; set; } = null;
        

[JsonProperty(PropertyName="Daylighting:ReferencePoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Daylighting_ReferencePoint> Daylighting_ReferencePoint_List { get; set; } = null;
        

[JsonProperty(PropertyName="Daylighting:DELight:ComplexFenestration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Daylighting_DELight_ComplexFenestration> Daylighting_DELight_ComplexFenestration_List { get; set; } = null;
        

[JsonProperty(PropertyName="DaylightingDevice:Tubular", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.DaylightingDevice_Tubular> DaylightingDevice_Tubular_List { get; set; } = null;
        

[JsonProperty(PropertyName="DaylightingDevice:Shelf", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.DaylightingDevice_Shelf> DaylightingDevice_Shelf_List { get; set; } = null;
        

[JsonProperty(PropertyName="DaylightingDevice:LightWell", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.DaylightingDevice_LightWell> DaylightingDevice_LightWell_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:DaylightFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Output_DaylightFactors> Output_DaylightFactors_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:IlluminanceMap", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Output_IlluminanceMap> Output_IlluminanceMap_List { get; set; } = null;
        

[JsonProperty(PropertyName="OutputControl:IlluminanceMap:Style", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Daylighting.OutputControl_IlluminanceMap_Style OutputControl_IlluminanceMap_Style { get; set; } = null;
        

[JsonProperty(PropertyName="DemandManagerAssignmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManagerAssignmentList> DemandManagerAssignmentList_List { get; set; } = null;
        

[JsonProperty(PropertyName="DemandManager:ExteriorLights", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_ExteriorLights> DemandManager_ExteriorLights_List { get; set; } = null;
        

[JsonProperty(PropertyName="DemandManager:Lights", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_Lights> DemandManager_Lights_List { get; set; } = null;
        

[JsonProperty(PropertyName="DemandManager:ElectricEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_ElectricEquipment> DemandManager_ElectricEquipment_List { get; set; } = null;
        

[JsonProperty(PropertyName="DemandManager:Thermostats", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_Thermostats> DemandManager_Thermostats_List { get; set; } = null;
        

[JsonProperty(PropertyName="DemandManager:Ventilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_Ventilation> DemandManager_Ventilation_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Control> GroundHeatTransfer_Control_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Slab:Materials", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_Materials> GroundHeatTransfer_Slab_Materials_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Slab:MatlProps", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_MatlProps> GroundHeatTransfer_Slab_MatlProps_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Slab:BoundConds", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_BoundConds> GroundHeatTransfer_Slab_BoundConds_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Slab:BldgProps", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_BldgProps> GroundHeatTransfer_Slab_BldgProps_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Slab:Insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_Insulation> GroundHeatTransfer_Slab_Insulation_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Slab:EquivalentSlab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_EquivalentSlab> GroundHeatTransfer_Slab_EquivalentSlab_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Slab:AutoGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_AutoGrid> GroundHeatTransfer_Slab_AutoGrid_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Slab:ManualGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_ManualGrid> GroundHeatTransfer_Slab_ManualGrid_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Slab:XFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_XFACE> GroundHeatTransfer_Slab_XFACE_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Slab:YFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_YFACE> GroundHeatTransfer_Slab_YFACE_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Slab:ZFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_ZFACE> GroundHeatTransfer_Slab_ZFACE_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:SimParameters", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_SimParameters> GroundHeatTransfer_Basement_SimParameters_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:MatlProps", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_MatlProps> GroundHeatTransfer_Basement_MatlProps_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:Insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_Insulation> GroundHeatTransfer_Basement_Insulation_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:SurfaceProps", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_SurfaceProps> GroundHeatTransfer_Basement_SurfaceProps_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:BldgData", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_BldgData> GroundHeatTransfer_Basement_BldgData_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:Interior", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_Interior> GroundHeatTransfer_Basement_Interior_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:ComBldg", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_ComBldg> GroundHeatTransfer_Basement_ComBldg_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:EquivSlab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_EquivSlab> GroundHeatTransfer_Basement_EquivSlab_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:EquivAutoGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_EquivAutoGrid> GroundHeatTransfer_Basement_EquivAutoGrid_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:AutoGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_AutoGrid> GroundHeatTransfer_Basement_AutoGrid_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:ManualGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_ManualGrid> GroundHeatTransfer_Basement_ManualGrid_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:XFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_XFACE> GroundHeatTransfer_Basement_XFACE_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:YFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_YFACE> GroundHeatTransfer_Basement_YFACE_List { get; set; } = null;
        

[JsonProperty(PropertyName="GroundHeatTransfer:Basement:ZFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_ZFACE> GroundHeatTransfer_Basement_ZFACE_List { get; set; } = null;
        

[JsonProperty(PropertyName="CurrencyType", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Economics.CurrencyType CurrencyType { get; set; } = null;
        

[JsonProperty(PropertyName="ComponentCost:Adjustments", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.ComponentCost_Adjustments> ComponentCost_Adjustments_List { get; set; } = null;
        

[JsonProperty(PropertyName="ComponentCost:Reference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.ComponentCost_Reference> ComponentCost_Reference_List { get; set; } = null;
        

[JsonProperty(PropertyName="ComponentCost:LineItem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.ComponentCost_LineItem> ComponentCost_LineItem_List { get; set; } = null;
        

[JsonProperty(PropertyName="UtilityCost:Tariff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Tariff> UtilityCost_Tariff_List { get; set; } = null;
        

[JsonProperty(PropertyName="UtilityCost:Qualify", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Qualify> UtilityCost_Qualify_List { get; set; } = null;
        

[JsonProperty(PropertyName="UtilityCost:Charge:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Charge_Simple> UtilityCost_Charge_Simple_List { get; set; } = null;
        

[JsonProperty(PropertyName="UtilityCost:Charge:Block", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Charge_Block> UtilityCost_Charge_Block_List { get; set; } = null;
        

[JsonProperty(PropertyName="UtilityCost:Ratchet", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Ratchet> UtilityCost_Ratchet_List { get; set; } = null;
        

[JsonProperty(PropertyName="UtilityCost:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Variable> UtilityCost_Variable_List { get; set; } = null;
        

[JsonProperty(PropertyName="UtilityCost:Computation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Computation> UtilityCost_Computation_List { get; set; } = null;
        

[JsonProperty(PropertyName="LifeCycleCost:Parameters", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_Parameters LifeCycleCost_Parameters { get; set; } = null;
        

[JsonProperty(PropertyName="LifeCycleCost:RecurringCosts", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_RecurringCosts> LifeCycleCost_RecurringCosts_List { get; set; } = null;
        

[JsonProperty(PropertyName="LifeCycleCost:NonrecurringCost", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_NonrecurringCost> LifeCycleCost_NonrecurringCost_List { get; set; } = null;
        

[JsonProperty(PropertyName="LifeCycleCost:UsePriceEscalation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_UsePriceEscalation> LifeCycleCost_UsePriceEscalation_List { get; set; } = null;
        

[JsonProperty(PropertyName="LifeCycleCost:UseAdjustment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_UseAdjustment> LifeCycleCost_UseAdjustment_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:InternalCombustionEngine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_InternalCombustionEngine> Generator_InternalCombustionEngine_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:CombustionTurbine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_CombustionTurbine> Generator_CombustionTurbine_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:MicroTurbine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_MicroTurbine> Generator_MicroTurbine_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:Photovoltaic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_Photovoltaic> Generator_Photovoltaic_List { get; set; } = null;
        

[JsonProperty(PropertyName="PhotovoltaicPerformance:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.PhotovoltaicPerformance_Simple> PhotovoltaicPerformance_Simple_List { get; set; } = null;
        

[JsonProperty(PropertyName="PhotovoltaicPerformance:EquivalentOne-Diode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.PhotovoltaicPerformance_EquivalentOneDiode> PhotovoltaicPerformance_EquivalentOneDiode_List { get; set; } = null;
        

[JsonProperty(PropertyName="PhotovoltaicPerformance:Sandia", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.PhotovoltaicPerformance_Sandia> PhotovoltaicPerformance_Sandia_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:PVWatts", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_PVWatts> Generator_PVWatts_List { get; set; } = null;
        

[JsonProperty(PropertyName="ElectricLoadCenter:Inverter:PVWatts", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_PVWatts> ElectricLoadCenter_Inverter_PVWatts_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:FuelCell", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell> Generator_FuelCell_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:FuelCell:PowerModule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_PowerModule> Generator_FuelCell_PowerModule_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:FuelCell:AirSupply", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_AirSupply> Generator_FuelCell_AirSupply_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:FuelCell:WaterSupply", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_WaterSupply> Generator_FuelCell_WaterSupply_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:FuelCell:AuxiliaryHeater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_AuxiliaryHeater> Generator_FuelCell_AuxiliaryHeater_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:FuelCell:ExhaustGasToWaterHeatExchanger", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_ExhaustGasToWaterHeatExchanger> Generator_FuelCell_ExhaustGasToWaterHeatExchanger_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:FuelCell:ElectricalStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_ElectricalStorage> Generator_FuelCell_ElectricalStorage_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:FuelCell:Inverter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_Inverter> Generator_FuelCell_Inverter_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:FuelCell:StackCooler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_StackCooler> Generator_FuelCell_StackCooler_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:MicroCHP", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_MicroCHP> Generator_MicroCHP_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:MicroCHP:NonNormalizedParameters", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_MicroCHP_NonNormalizedParameters> Generator_MicroCHP_NonNormalizedParameters_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:FuelSupply", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelSupply> Generator_FuelSupply_List { get; set; } = null;
        

[JsonProperty(PropertyName="Generator:WindTurbine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_WindTurbine> Generator_WindTurbine_List { get; set; } = null;
        

[JsonProperty(PropertyName="ElectricLoadCenter:Generators", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Generators> ElectricLoadCenter_Generators_List { get; set; } = null;
        

[JsonProperty(PropertyName="ElectricLoadCenter:Inverter:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_Simple> ElectricLoadCenter_Inverter_Simple_List { get; set; } = null;
        

[JsonProperty(PropertyName="ElectricLoadCenter:Inverter:FunctionOfPower", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_FunctionOfPower> ElectricLoadCenter_Inverter_FunctionOfPower_List { get; set; } = null;
        

[JsonProperty(PropertyName="ElectricLoadCenter:Inverter:LookUpTable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_LookUpTable> ElectricLoadCenter_Inverter_LookUpTable_List { get; set; } = null;
        

[JsonProperty(PropertyName="ElectricLoadCenter:Storage:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_Simple> ElectricLoadCenter_Storage_Simple_List { get; set; } = null;
        

[JsonProperty(PropertyName="ElectricLoadCenter:Storage:Battery", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_Battery> ElectricLoadCenter_Storage_Battery_List { get; set; } = null;
        

[JsonProperty(PropertyName="ElectricLoadCenter:Storage:LiIonNMCBattery", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_LiIonNMCBattery> ElectricLoadCenter_Storage_LiIonNMCBattery_List { get; set; } = null;
        

[JsonProperty(PropertyName="ElectricLoadCenter:Transformer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Transformer> ElectricLoadCenter_Transformer_List { get; set; } = null;
        

[JsonProperty(PropertyName="ElectricLoadCenter:Distribution", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Distribution> ElectricLoadCenter_Distribution_List { get; set; } = null;
        

[JsonProperty(PropertyName="ElectricLoadCenter:Storage:Converter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_Converter> ElectricLoadCenter_Storage_Converter_List { get; set; } = null;
        

[JsonProperty(PropertyName="EnergyManagementSystem:Sensor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Sensor> EnergyManagementSystem_Sensor_List { get; set; } = null;
        

[JsonProperty(PropertyName="EnergyManagementSystem:Actuator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Actuator> EnergyManagementSystem_Actuator_List { get; set; } = null;
        

[JsonProperty(PropertyName="EnergyManagementSystem:ProgramCallingManager", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_ProgramCallingManager> EnergyManagementSystem_ProgramCallingManager_List { get; set; } = null;
        

[JsonProperty(PropertyName="EnergyManagementSystem:Program", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Program> EnergyManagementSystem_Program_List { get; set; } = null;
        

[JsonProperty(PropertyName="EnergyManagementSystem:Subroutine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Subroutine> EnergyManagementSystem_Subroutine_List { get; set; } = null;
        

[JsonProperty(PropertyName="EnergyManagementSystem:GlobalVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_GlobalVariable> EnergyManagementSystem_GlobalVariable_List { get; set; } = null;
        

[JsonProperty(PropertyName="EnergyManagementSystem:OutputVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_OutputVariable> EnergyManagementSystem_OutputVariable_List { get; set; } = null;
        

[JsonProperty(PropertyName="EnergyManagementSystem:MeteredOutputVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_MeteredOutputVariable> EnergyManagementSystem_MeteredOutputVariable_List { get; set; } = null;
        

[JsonProperty(PropertyName="EnergyManagementSystem:TrendVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_TrendVariable> EnergyManagementSystem_TrendVariable_List { get; set; } = null;
        

[JsonProperty(PropertyName="EnergyManagementSystem:InternalVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_InternalVariable> EnergyManagementSystem_InternalVariable_List { get; set; } = null;
        

[JsonProperty(PropertyName="EnergyManagementSystem:CurveOrTableIndexVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_CurveOrTableIndexVariable> EnergyManagementSystem_CurveOrTableIndexVariable_List { get; set; } = null;
        

[JsonProperty(PropertyName="EnergyManagementSystem:ConstructionIndexVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_ConstructionIndexVariable> EnergyManagementSystem_ConstructionIndexVariable_List { get; set; } = null;
        

[JsonProperty(PropertyName="EvaporativeCooler:Direct:CelDekPad", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Direct_CelDekPad> EvaporativeCooler_Direct_CelDekPad_List { get; set; } = null;
        

[JsonProperty(PropertyName="EvaporativeCooler:Indirect:CelDekPad", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Indirect_CelDekPad> EvaporativeCooler_Indirect_CelDekPad_List { get; set; } = null;
        

[JsonProperty(PropertyName="EvaporativeCooler:Indirect:WetCoil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Indirect_WetCoil> EvaporativeCooler_Indirect_WetCoil_List { get; set; } = null;
        

[JsonProperty(PropertyName="EvaporativeCooler:Indirect:ResearchSpecial", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Indirect_ResearchSpecial> EvaporativeCooler_Indirect_ResearchSpecial_List { get; set; } = null;
        

[JsonProperty(PropertyName="EvaporativeCooler:Direct:ResearchSpecial", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Direct_ResearchSpecial> EvaporativeCooler_Direct_ResearchSpecial_List { get; set; } = null;
        

[JsonProperty(PropertyName="Exterior:Lights", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExteriorEquipment.Exterior_Lights> Exterior_Lights_List { get; set; } = null;
        

[JsonProperty(PropertyName="Exterior:FuelEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExteriorEquipment.Exterior_FuelEquipment> Exterior_FuelEquipment_List { get; set; } = null;
        

[JsonProperty(PropertyName="Exterior:WaterEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExteriorEquipment.Exterior_WaterEquipment> Exterior_WaterEquipment_List { get; set; } = null;
        

[JsonProperty(PropertyName="ExternalInterface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface> ExternalInterface_List { get; set; } = null;
        

[JsonProperty(PropertyName="ExternalInterface:Schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_Schedule> ExternalInterface_Schedule_List { get; set; } = null;
        

[JsonProperty(PropertyName="ExternalInterface:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_Variable> ExternalInterface_Variable_List { get; set; } = null;
        

[JsonProperty(PropertyName="ExternalInterface:Actuator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_Actuator> ExternalInterface_Actuator_List { get; set; } = null;
        

[JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitImport", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport> ExternalInterface_FunctionalMockupUnitImport_List { get; set; } = null;
        

[JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitImport:From:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_From_Variable> ExternalInterface_FunctionalMockupUnitImport_From_Variable_List { get; set; } = null;
        

[JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitImport:To:Schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_To_Schedule> ExternalInterface_FunctionalMockupUnitImport_To_Schedule_List { get; set; } = null;
        

[JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitImport:To:Actuator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_To_Actuator> ExternalInterface_FunctionalMockupUnitImport_To_Actuator_List { get; set; } = null;
        

[JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitImport:To:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_To_Variable> ExternalInterface_FunctionalMockupUnitImport_To_Variable_List { get; set; } = null;
        

[JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitExport:From:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_From_Variable> ExternalInterface_FunctionalMockupUnitExport_From_Variable_List { get; set; } = null;
        

[JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitExport:To:Schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_To_Schedule> ExternalInterface_FunctionalMockupUnitExport_To_Schedule_List { get; set; } = null;
        

[JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitExport:To:Actuator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_To_Actuator> ExternalInterface_FunctionalMockupUnitExport_To_Actuator_List { get; set; } = null;
        

[JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitExport:To:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_To_Variable> ExternalInterface_FunctionalMockupUnitExport_To_Variable_List { get; set; } = null;
        

[JsonProperty(PropertyName="Fan:SystemModel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_SystemModel> Fan_SystemModel_List { get; set; } = null;
        

[JsonProperty(PropertyName="Fan:ConstantVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_ConstantVolume> Fan_ConstantVolume_List { get; set; } = null;
        

[JsonProperty(PropertyName="Fan:VariableVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_VariableVolume> Fan_VariableVolume_List { get; set; } = null;
        

[JsonProperty(PropertyName="Fan:OnOff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_OnOff> Fan_OnOff_List { get; set; } = null;
        

[JsonProperty(PropertyName="Fan:ZoneExhaust", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_ZoneExhaust> Fan_ZoneExhaust_List { get; set; } = null;
        

[JsonProperty(PropertyName="FanPerformance:NightVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.FanPerformance_NightVentilation> FanPerformance_NightVentilation_List { get; set; } = null;
        

[JsonProperty(PropertyName="Fan:ComponentModel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_ComponentModel> Fan_ComponentModel_List { get; set; } = null;
        

[JsonProperty(PropertyName="FluidProperties:Name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Name> FluidProperties_Name_List { get; set; } = null;
        

[JsonProperty(PropertyName="FluidProperties:GlycolConcentration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_GlycolConcentration> FluidProperties_GlycolConcentration_List { get; set; } = null;
        

[JsonProperty(PropertyName="FluidProperties:Temperatures", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Temperatures> FluidProperties_Temperatures_List { get; set; } = null;
        

[JsonProperty(PropertyName="FluidProperties:Saturated", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Saturated> FluidProperties_Saturated_List { get; set; } = null;
        

[JsonProperty(PropertyName="FluidProperties:Superheated", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Superheated> FluidProperties_Superheated_List { get; set; } = null;
        

[JsonProperty(PropertyName="FluidProperties:Concentration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Concentration> FluidProperties_Concentration_List { get; set; } = null;
        

[JsonProperty(PropertyName="Matrix:TwoDimension", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.GeneralDataEntry.Matrix_TwoDimension> Matrix_TwoDimension_List { get; set; } = null;
        

[JsonProperty(PropertyName="HeatExchanger:AirToAir:FlatPlate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_AirToAir_FlatPlate> HeatExchanger_AirToAir_FlatPlate_List { get; set; } = null;
        

[JsonProperty(PropertyName="HeatExchanger:AirToAir:SensibleAndLatent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_AirToAir_SensibleAndLatent> HeatExchanger_AirToAir_SensibleAndLatent_List { get; set; } = null;
        

[JsonProperty(PropertyName="HeatExchanger:Desiccant:BalancedFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_Desiccant_BalancedFlow> HeatExchanger_Desiccant_BalancedFlow_List { get; set; } = null;
        

[JsonProperty(PropertyName="HeatExchanger:Desiccant:BalancedFlow:PerformanceDataType1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_Desiccant_BalancedFlow_PerformanceDataType1> HeatExchanger_Desiccant_BalancedFlow_PerformanceDataType1_List { get; set; } = null;
        

[JsonProperty(PropertyName="Humidifier:Steam:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Humidifier_Steam_Electric> Humidifier_Steam_Electric_List { get; set; } = null;
        

[JsonProperty(PropertyName="Humidifier:Steam:Gas", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Humidifier_Steam_Gas> Humidifier_Steam_Gas_List { get; set; } = null;
        

[JsonProperty(PropertyName="Dehumidifier:Desiccant:NoFans", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Dehumidifier_Desiccant_NoFans> Dehumidifier_Desiccant_NoFans_List { get; set; } = null;
        

[JsonProperty(PropertyName="Dehumidifier:Desiccant:System", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Dehumidifier_Desiccant_System> Dehumidifier_Desiccant_System_List { get; set; } = null;
        

[JsonProperty(PropertyName="DesignSpecification:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_OutdoorAir> DesignSpecification_OutdoorAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="DesignSpecification:ZoneAirDistribution", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_ZoneAirDistribution> DesignSpecification_ZoneAirDistribution_List { get; set; } = null;
        

[JsonProperty(PropertyName="Sizing:Parameters", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_Parameters Sizing_Parameters { get; set; } = null;
        

[JsonProperty(PropertyName="Sizing:Zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_Zone> Sizing_Zone_List { get; set; } = null;
        

[JsonProperty(PropertyName="DesignSpecification:ZoneHVAC:Sizing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_ZoneHVAC_Sizing> DesignSpecification_ZoneHVAC_Sizing_List { get; set; } = null;
        

[JsonProperty(PropertyName="DesignSpecification:AirTerminal:Sizing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_AirTerminal_Sizing> DesignSpecification_AirTerminal_Sizing_List { get; set; } = null;
        

[JsonProperty(PropertyName="Sizing:System", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_System> Sizing_System_List { get; set; } = null;
        

[JsonProperty(PropertyName="Sizing:Plant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_Plant> Sizing_Plant_List { get; set; } = null;
        

[JsonProperty(PropertyName="OutputControl:Sizing:Style", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.HVACDesignObjects.OutputControl_Sizing_Style OutputControl_Sizing_Style { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Thermostat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Thermostat> HVACTemplate_Thermostat_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Zone:IdealLoadsAirSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_IdealLoadsAirSystem> HVACTemplate_Zone_IdealLoadsAirSystem_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Zone:BaseboardHeat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_BaseboardHeat> HVACTemplate_Zone_BaseboardHeat_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Zone:FanCoil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_FanCoil> HVACTemplate_Zone_FanCoil_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Zone:PTAC", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_PTAC> HVACTemplate_Zone_PTAC_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Zone:PTHP", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_PTHP> HVACTemplate_Zone_PTHP_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Zone:WaterToAirHeatPump", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_WaterToAirHeatPump> HVACTemplate_Zone_WaterToAirHeatPump_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Zone:VRF", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VRF> HVACTemplate_Zone_VRF_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Zone:Unitary", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_Unitary> HVACTemplate_Zone_Unitary_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Zone:VAV", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VAV> HVACTemplate_Zone_VAV_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Zone:VAV:FanPowered", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VAV_FanPowered> HVACTemplate_Zone_VAV_FanPowered_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Zone:VAV:HeatAndCool", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VAV_HeatAndCool> HVACTemplate_Zone_VAV_HeatAndCool_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Zone:ConstantVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_ConstantVolume> HVACTemplate_Zone_ConstantVolume_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Zone:DualDuct", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_DualDuct> HVACTemplate_Zone_DualDuct_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:System:VRF", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_VRF> HVACTemplate_System_VRF_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:System:Unitary", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_Unitary> HVACTemplate_System_Unitary_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:System:UnitaryHeatPump:AirToAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_UnitaryHeatPump_AirToAir> HVACTemplate_System_UnitaryHeatPump_AirToAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:System:UnitarySystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_UnitarySystem> HVACTemplate_System_UnitarySystem_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:System:VAV", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_VAV> HVACTemplate_System_VAV_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:System:PackagedVAV", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_PackagedVAV> HVACTemplate_System_PackagedVAV_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:System:ConstantVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_ConstantVolume> HVACTemplate_System_ConstantVolume_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:System:DualDuct", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_DualDuct> HVACTemplate_System_DualDuct_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:System:DedicatedOutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_DedicatedOutdoorAir> HVACTemplate_System_DedicatedOutdoorAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Plant:ChilledWaterLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_ChilledWaterLoop HVACTemplate_Plant_ChilledWaterLoop { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Plant:Chiller", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Chiller> HVACTemplate_Plant_Chiller_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Plant:Chiller:ObjectReference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Chiller_ObjectReference> HVACTemplate_Plant_Chiller_ObjectReference_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Plant:Tower", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Tower> HVACTemplate_Plant_Tower_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Plant:Tower:ObjectReference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Tower_ObjectReference> HVACTemplate_Plant_Tower_ObjectReference_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Plant:HotWaterLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_HotWaterLoop HVACTemplate_Plant_HotWaterLoop { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Plant:Boiler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Boiler> HVACTemplate_Plant_Boiler_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Plant:Boiler:ObjectReference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Boiler_ObjectReference> HVACTemplate_Plant_Boiler_ObjectReference_List { get; set; } = null;
        

[JsonProperty(PropertyName="HVACTemplate:Plant:MixedWaterLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_MixedWaterLoop HVACTemplate_Plant_MixedWaterLoop { get; set; } = null;
        

[JsonProperty(PropertyName="HybridModel:Zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HybridModel.HybridModel_Zone> HybridModel_Zone_List { get; set; } = null;
        

[JsonProperty(PropertyName="People", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.People> People_List { get; set; } = null;
        

[JsonProperty(PropertyName="ComfortViewFactorAngles", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ComfortViewFactorAngles> ComfortViewFactorAngles_List { get; set; } = null;
        

[JsonProperty(PropertyName="Lights", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.Lights> Lights_List { get; set; } = null;
        

[JsonProperty(PropertyName="ElectricEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ElectricEquipment> ElectricEquipment_List { get; set; } = null;
        

[JsonProperty(PropertyName="GasEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.GasEquipment> GasEquipment_List { get; set; } = null;
        

[JsonProperty(PropertyName="HotWaterEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.HotWaterEquipment> HotWaterEquipment_List { get; set; } = null;
        

[JsonProperty(PropertyName="SteamEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SteamEquipment> SteamEquipment_List { get; set; } = null;
        

[JsonProperty(PropertyName="OtherEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.OtherEquipment> OtherEquipment_List { get; set; } = null;
        

[JsonProperty(PropertyName="ElectricEquipment:ITE:AirCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ElectricEquipment_ITE_AirCooled> ElectricEquipment_ITE_AirCooled_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneBaseboard:OutdoorTemperatureControlled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneBaseboard_OutdoorTemperatureControlled> ZoneBaseboard_OutdoorTemperatureControlled_List { get; set; } = null;
        

[JsonProperty(PropertyName="SwimmingPool:Indoor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SwimmingPool_Indoor> SwimmingPool_Indoor_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneContaminantSourceAndSink:CarbonDioxide", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_CarbonDioxide> ZoneContaminantSourceAndSink_CarbonDioxide_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneContaminantSourceAndSink:Generic:Constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_Constant> ZoneContaminantSourceAndSink_Generic_Constant_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceContaminantSourceAndSink:Generic:PressureDriven", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SurfaceContaminantSourceAndSink_Generic_PressureDriven> SurfaceContaminantSourceAndSink_Generic_PressureDriven_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneContaminantSourceAndSink:Generic:CutoffModel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_CutoffModel> ZoneContaminantSourceAndSink_Generic_CutoffModel_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneContaminantSourceAndSink:Generic:DecaySource", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_DecaySource> ZoneContaminantSourceAndSink_Generic_DecaySource_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceContaminantSourceAndSink:Generic:BoundaryLayerDiffusion", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SurfaceContaminantSourceAndSink_Generic_BoundaryLayerDiffusion> SurfaceContaminantSourceAndSink_Generic_BoundaryLayerDiffusion_List { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceContaminantSourceAndSink:Generic:DepositionVelocitySink", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SurfaceContaminantSourceAndSink_Generic_DepositionVelocitySink> SurfaceContaminantSourceAndSink_Generic_DepositionVelocitySink_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneContaminantSourceAndSink:Generic:DepositionRateSink", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_DepositionRateSink> ZoneContaminantSourceAndSink_Generic_DepositionRateSink_List { get; set; } = null;
        

[JsonProperty(PropertyName="Site:Location", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_Location Site_Location { get; set; } = null;
        

[JsonProperty(PropertyName="Site:VariableLocation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_VariableLocation Site_VariableLocation { get; set; } = null;
        

[JsonProperty(PropertyName="SizingPeriod:DesignDay", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.SizingPeriod_DesignDay> SizingPeriod_DesignDay_List { get; set; } = null;
        

[JsonProperty(PropertyName="SizingPeriod:WeatherFileDays", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.SizingPeriod_WeatherFileDays> SizingPeriod_WeatherFileDays_List { get; set; } = null;
        

[JsonProperty(PropertyName="SizingPeriod:WeatherFileConditionType", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.SizingPeriod_WeatherFileConditionType> SizingPeriod_WeatherFileConditionType_List { get; set; } = null;
        

[JsonProperty(PropertyName="RunPeriod", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.RunPeriod> RunPeriod_List { get; set; } = null;
        

[JsonProperty(PropertyName="RunPeriodControl:SpecialDays", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.RunPeriodControl_SpecialDays> RunPeriodControl_SpecialDays_List { get; set; } = null;
        

[JsonProperty(PropertyName="RunPeriodControl:DaylightSavingTime", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.RunPeriodControl_DaylightSavingTime RunPeriodControl_DaylightSavingTime { get; set; } = null;
        

[JsonProperty(PropertyName="WeatherProperty:SkyTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.WeatherProperty_SkyTemperature> WeatherProperty_SkyTemperature_List { get; set; } = null;
        

[JsonProperty(PropertyName="Site:WeatherStation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_WeatherStation Site_WeatherStation { get; set; } = null;
        

[JsonProperty(PropertyName="Site:HeightVariation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_HeightVariation Site_HeightVariation { get; set; } = null;
        

[JsonProperty(PropertyName="Site:GroundTemperature:BuildingSurface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_BuildingSurface Site_GroundTemperature_BuildingSurface { get; set; } = null;
        

[JsonProperty(PropertyName="Site:GroundTemperature:FCfactorMethod", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_FCfactorMethod Site_GroundTemperature_FCfactorMethod { get; set; } = null;
        

[JsonProperty(PropertyName="Site:GroundTemperature:Shallow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Shallow Site_GroundTemperature_Shallow { get; set; } = null;
        

[JsonProperty(PropertyName="Site:GroundTemperature:Deep", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Deep Site_GroundTemperature_Deep { get; set; } = null;
        

[JsonProperty(PropertyName="Site:GroundTemperature:Undisturbed:FiniteDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Undisturbed_FiniteDifference> Site_GroundTemperature_Undisturbed_FiniteDifference_List { get; set; } = null;
        

[JsonProperty(PropertyName="Site:GroundTemperature:Undisturbed:KusudaAchenbach", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Undisturbed_KusudaAchenbach> Site_GroundTemperature_Undisturbed_KusudaAchenbach_List { get; set; } = null;
        

[JsonProperty(PropertyName="Site:GroundTemperature:Undisturbed:Xing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Undisturbed_Xing> Site_GroundTemperature_Undisturbed_Xing_List { get; set; } = null;
        

[JsonProperty(PropertyName="Site:GroundDomain:Slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundDomain_Slab> Site_GroundDomain_Slab_List { get; set; } = null;
        

[JsonProperty(PropertyName="Site:GroundDomain:Basement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundDomain_Basement> Site_GroundDomain_Basement_List { get; set; } = null;
        

[JsonProperty(PropertyName="Site:GroundReflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundReflectance Site_GroundReflectance { get; set; } = null;
        

[JsonProperty(PropertyName="Site:GroundReflectance:SnowModifier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundReflectance_SnowModifier> Site_GroundReflectance_SnowModifier_List { get; set; } = null;
        

[JsonProperty(PropertyName="Site:WaterMainsTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_WaterMainsTemperature> Site_WaterMainsTemperature_List { get; set; } = null;
        

[JsonProperty(PropertyName="Site:Precipitation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_Precipitation> Site_Precipitation_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoofIrrigation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.RoofIrrigation> RoofIrrigation_List { get; set; } = null;
        

[JsonProperty(PropertyName="Site:SolarAndVisibleSpectrum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_SolarAndVisibleSpectrum Site_SolarAndVisibleSpectrum { get; set; } = null;
        

[JsonProperty(PropertyName="Site:SpectrumData", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_SpectrumData> Site_SpectrumData_List { get; set; } = null;
        

[JsonProperty(PropertyName="Branch", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Branch> Branch_List { get; set; } = null;
        

[JsonProperty(PropertyName="BranchList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.BranchList> BranchList_List { get; set; } = null;
        

[JsonProperty(PropertyName="Connector:Splitter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Connector_Splitter> Connector_Splitter_List { get; set; } = null;
        

[JsonProperty(PropertyName="Connector:Mixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Connector_Mixer> Connector_Mixer_List { get; set; } = null;
        

[JsonProperty(PropertyName="ConnectorList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.ConnectorList> ConnectorList_List { get; set; } = null;
        

[JsonProperty(PropertyName="NodeList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.NodeList> NodeList_List { get; set; } = null;
        

[JsonProperty(PropertyName="OutdoorAir:Node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.OutdoorAir_Node> OutdoorAir_Node_List { get; set; } = null;
        

[JsonProperty(PropertyName="OutdoorAir:NodeList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.OutdoorAir_NodeList> OutdoorAir_NodeList_List { get; set; } = null;
        

[JsonProperty(PropertyName="Pipe:Adiabatic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Adiabatic> Pipe_Adiabatic_List { get; set; } = null;
        

[JsonProperty(PropertyName="Pipe:Adiabatic:Steam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Adiabatic_Steam> Pipe_Adiabatic_Steam_List { get; set; } = null;
        

[JsonProperty(PropertyName="Pipe:Indoor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Indoor> Pipe_Indoor_List { get; set; } = null;
        

[JsonProperty(PropertyName="Pipe:Outdoor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Outdoor> Pipe_Outdoor_List { get; set; } = null;
        

[JsonProperty(PropertyName="Pipe:Underground", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Underground> Pipe_Underground_List { get; set; } = null;
        

[JsonProperty(PropertyName="PipingSystem:Underground:Domain", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.PipingSystem_Underground_Domain> PipingSystem_Underground_Domain_List { get; set; } = null;
        

[JsonProperty(PropertyName="PipingSystem:Underground:PipeCircuit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.PipingSystem_Underground_PipeCircuit> PipingSystem_Underground_PipeCircuit_List { get; set; } = null;
        

[JsonProperty(PropertyName="PipingSystem:Underground:PipeSegment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.PipingSystem_Underground_PipeSegment> PipingSystem_Underground_PipeSegment_List { get; set; } = null;
        

[JsonProperty(PropertyName="Duct", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Duct> Duct_List { get; set; } = null;
        

[JsonProperty(PropertyName="LoadProfile:Plant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NonZoneEquipment.LoadProfile_Plant> LoadProfile_Plant_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:TemperatureSensorOffset:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_OutdoorAir> FaultModel_TemperatureSensorOffset_OutdoorAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:HumiditySensorOffset:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_HumiditySensorOffset_OutdoorAir> FaultModel_HumiditySensorOffset_OutdoorAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:EnthalpySensorOffset:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_EnthalpySensorOffset_OutdoorAir> FaultModel_EnthalpySensorOffset_OutdoorAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:TemperatureSensorOffset:ReturnAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_ReturnAir> FaultModel_TemperatureSensorOffset_ReturnAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:EnthalpySensorOffset:ReturnAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_EnthalpySensorOffset_ReturnAir> FaultModel_EnthalpySensorOffset_ReturnAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:TemperatureSensorOffset:ChillerSupplyWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_ChillerSupplyWater> FaultModel_TemperatureSensorOffset_ChillerSupplyWater_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:TemperatureSensorOffset:CoilSupplyAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_CoilSupplyAir> FaultModel_TemperatureSensorOffset_CoilSupplyAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:TemperatureSensorOffset:CondenserSupplyWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_CondenserSupplyWater> FaultModel_TemperatureSensorOffset_CondenserSupplyWater_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:ThermostatOffset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_ThermostatOffset> FaultModel_ThermostatOffset_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:HumidistatOffset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_HumidistatOffset> FaultModel_HumidistatOffset_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:Fouling:AirFilter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_AirFilter> FaultModel_Fouling_AirFilter_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:Fouling:Boiler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_Boiler> FaultModel_Fouling_Boiler_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:Fouling:EvaporativeCooler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_EvaporativeCooler> FaultModel_Fouling_EvaporativeCooler_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:Fouling:Chiller", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_Chiller> FaultModel_Fouling_Chiller_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:Fouling:CoolingTower", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_CoolingTower> FaultModel_Fouling_CoolingTower_List { get; set; } = null;
        

[JsonProperty(PropertyName="FaultModel:Fouling:Coil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_Coil> FaultModel_Fouling_Coil_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:VariableDictionary", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_VariableDictionary> Output_VariableDictionary_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Surfaces:List", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Surfaces_List> Output_Surfaces_List_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Surfaces:Drawing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Surfaces_Drawing> Output_Surfaces_Drawing_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Schedules", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Schedules> Output_Schedules_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Constructions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Constructions> Output_Constructions_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:EnergyManagementSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_EnergyManagementSystem Output_EnergyManagementSystem { get; set; } = null;
        

[JsonProperty(PropertyName="OutputControl:SurfaceColorScheme", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.OutputControl_SurfaceColorScheme> OutputControl_SurfaceColorScheme_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Table:SummaryReports", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_SummaryReports Output_Table_SummaryReports { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Table:TimeBins", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_TimeBins> Output_Table_TimeBins_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Table:Monthly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_Monthly> Output_Table_Monthly_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Table:Annual", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_Annual> Output_Table_Annual_List { get; set; } = null;
        

[JsonProperty(PropertyName="OutputControl:Table:Style", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.OutputControl_Table_Style OutputControl_Table_Style { get; set; } = null;
        

[JsonProperty(PropertyName="OutputControl:ReportingTolerances", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.OutputControl_ReportingTolerances OutputControl_ReportingTolerances { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Variable> Output_Variable_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Meter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter> Output_Meter_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Meter:MeterFileOnly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter_MeterFileOnly> Output_Meter_MeterFileOnly_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Meter:Cumulative", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter_Cumulative> Output_Meter_Cumulative_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Meter:Cumulative:MeterFileOnly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter_Cumulative_MeterFileOnly> Output_Meter_Cumulative_MeterFileOnly_List { get; set; } = null;
        

[JsonProperty(PropertyName="Meter:Custom", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Meter_Custom> Meter_Custom_List { get; set; } = null;
        

[JsonProperty(PropertyName="Meter:CustomDecrement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Meter_CustomDecrement> Meter_CustomDecrement_List { get; set; } = null;
        

[JsonProperty(PropertyName="OutputControl:Files", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.OutputControl_Files OutputControl_Files { get; set; } = null;
        

[JsonProperty(PropertyName="Output:JSON", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_JSON Output_JSON { get; set; } = null;
        

[JsonProperty(PropertyName="Output:SQLite", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_SQLite Output_SQLite { get; set; } = null;
        

[JsonProperty(PropertyName="Output:EnvironmentalImpactFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_EnvironmentalImpactFactors> Output_EnvironmentalImpactFactors_List { get; set; } = null;
        

[JsonProperty(PropertyName="EnvironmentalImpactFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.EnvironmentalImpactFactors> EnvironmentalImpactFactors_List { get; set; } = null;
        

[JsonProperty(PropertyName="FuelFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.FuelFactors> FuelFactors_List { get; set; } = null;
        

[JsonProperty(PropertyName="Output:Diagnostics", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Diagnostics Output_Diagnostics { get; set; } = null;
        

[JsonProperty(PropertyName="Output:DebuggingData", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_DebuggingData Output_DebuggingData { get; set; } = null;
        

[JsonProperty(PropertyName="Output:PreprocessorMessage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_PreprocessorMessage> Output_PreprocessorMessage_List { get; set; } = null;
        

[JsonProperty(PropertyName="Parametric:SetValueForRun", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Parametrics.Parametric_SetValueForRun> Parametric_SetValueForRun_List { get; set; } = null;
        

[JsonProperty(PropertyName="Parametric:Logic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Parametrics.Parametric_Logic Parametric_Logic { get; set; } = null;
        

[JsonProperty(PropertyName="Parametric:RunControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Parametrics.Parametric_RunControl Parametric_RunControl { get; set; } = null;
        

[JsonProperty(PropertyName="Parametric:FileNameSuffix", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Parametrics.Parametric_FileNameSuffix Parametric_FileNameSuffix { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:Linear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Linear> Curve_Linear_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:QuadLinear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_QuadLinear> Curve_QuadLinear_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:QuintLinear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_QuintLinear> Curve_QuintLinear_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:Quadratic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Quadratic> Curve_Quadratic_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:Cubic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Cubic> Curve_Cubic_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:Quartic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Quartic> Curve_Quartic_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:Exponent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Exponent> Curve_Exponent_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:Bicubic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Bicubic> Curve_Bicubic_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:Biquadratic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Biquadratic> Curve_Biquadratic_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:QuadraticLinear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_QuadraticLinear> Curve_QuadraticLinear_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:CubicLinear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_CubicLinear> Curve_CubicLinear_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:Triquadratic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Triquadratic> Curve_Triquadratic_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:Functional:PressureDrop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Functional_PressureDrop> Curve_Functional_PressureDrop_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:FanPressureRise", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_FanPressureRise> Curve_FanPressureRise_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:ExponentialSkewNormal", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_ExponentialSkewNormal> Curve_ExponentialSkewNormal_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:Sigmoid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Sigmoid> Curve_Sigmoid_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:RectangularHyperbola1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_RectangularHyperbola1> Curve_RectangularHyperbola1_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:RectangularHyperbola2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_RectangularHyperbola2> Curve_RectangularHyperbola2_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:ExponentialDecay", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_ExponentialDecay> Curve_ExponentialDecay_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:DoubleExponentialDecay", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_DoubleExponentialDecay> Curve_DoubleExponentialDecay_List { get; set; } = null;
        

[JsonProperty(PropertyName="Curve:ChillerPartLoadWithLift", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_ChillerPartLoadWithLift> Curve_ChillerPartLoadWithLift_List { get; set; } = null;
        

[JsonProperty(PropertyName="Table:IndependentVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceTables.Table_IndependentVariable> Table_IndependentVariable_List { get; set; } = null;
        

[JsonProperty(PropertyName="Table:IndependentVariableList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceTables.Table_IndependentVariableList> Table_IndependentVariableList_List { get; set; } = null;
        

[JsonProperty(PropertyName="Table:Lookup", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceTables.Table_Lookup> Table_Lookup_List { get; set; } = null;
        

[JsonProperty(PropertyName="Boiler:HotWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Boiler_HotWater> Boiler_HotWater_List { get; set; } = null;
        

[JsonProperty(PropertyName="Boiler:Steam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Boiler_Steam> Boiler_Steam_List { get; set; } = null;
        

[JsonProperty(PropertyName="Chiller:Electric:EIR", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Electric_EIR> Chiller_Electric_EIR_List { get; set; } = null;
        

[JsonProperty(PropertyName="Chiller:Electric:ReformulatedEIR", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Electric_ReformulatedEIR> Chiller_Electric_ReformulatedEIR_List { get; set; } = null;
        

[JsonProperty(PropertyName="Chiller:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Electric> Chiller_Electric_List { get; set; } = null;
        

[JsonProperty(PropertyName="Chiller:Absorption:Indirect", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Absorption_Indirect> Chiller_Absorption_Indirect_List { get; set; } = null;
        

[JsonProperty(PropertyName="Chiller:Absorption", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Absorption> Chiller_Absorption_List { get; set; } = null;
        

[JsonProperty(PropertyName="Chiller:ConstantCOP", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_ConstantCOP> Chiller_ConstantCOP_List { get; set; } = null;
        

[JsonProperty(PropertyName="Chiller:EngineDriven", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_EngineDriven> Chiller_EngineDriven_List { get; set; } = null;
        

[JsonProperty(PropertyName="Chiller:CombustionTurbine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_CombustionTurbine> Chiller_CombustionTurbine_List { get; set; } = null;
        

[JsonProperty(PropertyName="ChillerHeater:Absorption:DirectFired", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.ChillerHeater_Absorption_DirectFired> ChillerHeater_Absorption_DirectFired_List { get; set; } = null;
        

[JsonProperty(PropertyName="ChillerHeater:Absorption:DoubleEffect", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.ChillerHeater_Absorption_DoubleEffect> ChillerHeater_Absorption_DoubleEffect_List { get; set; } = null;
        

[JsonProperty(PropertyName="HeatPump:PlantLoop:EIR:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_PlantLoop_EIR_Cooling> HeatPump_PlantLoop_EIR_Cooling_List { get; set; } = null;
        

[JsonProperty(PropertyName="HeatPump:PlantLoop:EIR:Heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_PlantLoop_EIR_Heating> HeatPump_PlantLoop_EIR_Heating_List { get; set; } = null;
        

[JsonProperty(PropertyName="HeatPump:WaterToWater:EquationFit:Heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_EquationFit_Heating> HeatPump_WaterToWater_EquationFit_Heating_List { get; set; } = null;
        

[JsonProperty(PropertyName="HeatPump:WaterToWater:EquationFit:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_EquationFit_Cooling> HeatPump_WaterToWater_EquationFit_Cooling_List { get; set; } = null;
        

[JsonProperty(PropertyName="HeatPump:WaterToWater:ParameterEstimation:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_ParameterEstimation_Cooling> HeatPump_WaterToWater_ParameterEstimation_Cooling_List { get; set; } = null;
        

[JsonProperty(PropertyName="HeatPump:WaterToWater:ParameterEstimation:Heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_ParameterEstimation_Heating> HeatPump_WaterToWater_ParameterEstimation_Heating_List { get; set; } = null;
        

[JsonProperty(PropertyName="DistrictCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.DistrictCooling> DistrictCooling_List { get; set; } = null;
        

[JsonProperty(PropertyName="DistrictHeating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.DistrictHeating> DistrictHeating_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantComponent:TemperatureSource", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.PlantComponent_TemperatureSource> PlantComponent_TemperatureSource_List { get; set; } = null;
        

[JsonProperty(PropertyName="CentralHeatPumpSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.CentralHeatPumpSystem> CentralHeatPumpSystem_List { get; set; } = null;
        

[JsonProperty(PropertyName="ChillerHeaterPerformance:Electric:EIR", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.ChillerHeaterPerformance_Electric_EIR> ChillerHeaterPerformance_Electric_EIR_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentList> PlantEquipmentList_List { get; set; } = null;
        

[JsonProperty(PropertyName="CondenserEquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.CondenserEquipmentList> CondenserEquipmentList_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperation:Uncontrolled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_Uncontrolled> PlantEquipmentOperation_Uncontrolled_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperation:CoolingLoad", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_CoolingLoad> PlantEquipmentOperation_CoolingLoad_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperation:HeatingLoad", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_HeatingLoad> PlantEquipmentOperation_HeatingLoad_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorDryBulb", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDryBulb> PlantEquipmentOperation_OutdoorDryBulb_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorWetBulb", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorWetBulb> PlantEquipmentOperation_OutdoorWetBulb_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorRelativeHumidity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorRelativeHumidity> PlantEquipmentOperation_OutdoorRelativeHumidity_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorDewpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDewpoint> PlantEquipmentOperation_OutdoorDewpoint_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperation:ComponentSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_ComponentSetpoint> PlantEquipmentOperation_ComponentSetpoint_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperation:ThermalEnergyStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_ThermalEnergyStorage> PlantEquipmentOperation_ThermalEnergyStorage_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorDryBulbDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDryBulbDifference> PlantEquipmentOperation_OutdoorDryBulbDifference_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorWetBulbDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorWetBulbDifference> PlantEquipmentOperation_OutdoorWetBulbDifference_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorDewpointDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDewpointDifference> PlantEquipmentOperation_OutdoorDewpointDifference_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperationSchemes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperationSchemes> PlantEquipmentOperationSchemes_List { get; set; } = null;
        

[JsonProperty(PropertyName="CondenserEquipmentOperationSchemes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.CondenserEquipmentOperationSchemes> CondenserEquipmentOperationSchemes_List { get; set; } = null;
        

[JsonProperty(PropertyName="TemperingValve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserFlowControl.TemperingValve> TemperingValve_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserLoops.PlantLoop> PlantLoop_List { get; set; } = null;
        

[JsonProperty(PropertyName="CondenserLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserLoops.CondenserLoop> CondenserLoop_List { get; set; } = null;
        

[JsonProperty(PropertyName="Pump:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.Pump_VariableSpeed> Pump_VariableSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Pump:ConstantSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.Pump_ConstantSpeed> Pump_ConstantSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Pump:VariableSpeed:Condensate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.Pump_VariableSpeed_Condensate> Pump_VariableSpeed_Condensate_List { get; set; } = null;
        

[JsonProperty(PropertyName="HeaderedPumps:ConstantSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.HeaderedPumps_ConstantSpeed> HeaderedPumps_ConstantSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="HeaderedPumps:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.HeaderedPumps_VariableSpeed> HeaderedPumps_VariableSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="PythonPlugin:SearchPaths", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_SearchPaths PythonPlugin_SearchPaths { get; set; } = null;
        

[JsonProperty(PropertyName="PythonPlugin:Instance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_Instance> PythonPlugin_Instance_List { get; set; } = null;
        

[JsonProperty(PropertyName="PythonPlugin:Variables", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_Variables PythonPlugin_Variables { get; set; } = null;
        

[JsonProperty(PropertyName="PythonPlugin:TrendVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_TrendVariable> PythonPlugin_TrendVariable_List { get; set; } = null;
        

[JsonProperty(PropertyName="PythonPlugin:OutputVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_OutputVariable> PythonPlugin_OutputVariable_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:Case", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Case> Refrigeration_Case_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:CompressorRack", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_CompressorRack> Refrigeration_CompressorRack_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:CaseAndWalkInList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_CaseAndWalkInList> Refrigeration_CaseAndWalkInList_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:Condenser:AirCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_AirCooled> Refrigeration_Condenser_AirCooled_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:Condenser:EvaporativeCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_EvaporativeCooled> Refrigeration_Condenser_EvaporativeCooled_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:Condenser:WaterCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_WaterCooled> Refrigeration_Condenser_WaterCooled_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:Condenser:Cascade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_Cascade> Refrigeration_Condenser_Cascade_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:GasCooler:AirCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_GasCooler_AirCooled> Refrigeration_GasCooler_AirCooled_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:TransferLoadList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_TransferLoadList> Refrigeration_TransferLoadList_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:Subcooler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Subcooler> Refrigeration_Subcooler_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:Compressor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Compressor> Refrigeration_Compressor_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:CompressorList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_CompressorList> Refrigeration_CompressorList_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:System", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_System> Refrigeration_System_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:TranscriticalSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_TranscriticalSystem> Refrigeration_TranscriticalSystem_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:SecondarySystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_SecondarySystem> Refrigeration_SecondarySystem_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:WalkIn", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_WalkIn> Refrigeration_WalkIn_List { get; set; } = null;
        

[JsonProperty(PropertyName="Refrigeration:AirChiller", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_AirChiller> Refrigeration_AirChiller_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:RefrigerationChillerSet", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.ZoneHVAC_RefrigerationChillerSet> ZoneHVAC_RefrigerationChillerSet_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAirModelType", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirModelType> RoomAirModelType_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAir:TemperaturePattern:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_UserDefined> RoomAir_TemperaturePattern_UserDefined_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAir:TemperaturePattern:ConstantGradient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_ConstantGradient> RoomAir_TemperaturePattern_ConstantGradient_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAir:TemperaturePattern:TwoGradient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_TwoGradient> RoomAir_TemperaturePattern_TwoGradient_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAir:TemperaturePattern:NondimensionalHeight", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_NondimensionalHeight> RoomAir_TemperaturePattern_NondimensionalHeight_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAir:TemperaturePattern:SurfaceMapping", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_SurfaceMapping> RoomAir_TemperaturePattern_SurfaceMapping_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAir:Node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node> RoomAir_Node_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAirSettings:OneNodeDisplacementVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_OneNodeDisplacementVentilation> RoomAirSettings_OneNodeDisplacementVentilation_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAirSettings:ThreeNodeDisplacementVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_ThreeNodeDisplacementVentilation> RoomAirSettings_ThreeNodeDisplacementVentilation_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAirSettings:CrossVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_CrossVentilation> RoomAirSettings_CrossVentilation_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAirSettings:UnderFloorAirDistributionInterior", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_UnderFloorAirDistributionInterior> RoomAirSettings_UnderFloorAirDistributionInterior_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAirSettings:UnderFloorAirDistributionExterior", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_UnderFloorAirDistributionExterior> RoomAirSettings_UnderFloorAirDistributionExterior_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAir:Node:AirflowNetwork", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork> RoomAir_Node_AirflowNetwork_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAir:Node:AirflowNetwork:AdjacentSurfaceList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork_AdjacentSurfaceList> RoomAir_Node_AirflowNetwork_AdjacentSurfaceList_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAir:Node:AirflowNetwork:InternalGains", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork_InternalGains> RoomAir_Node_AirflowNetwork_InternalGains_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAir:Node:AirflowNetwork:HVACEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork_HVACEquipment> RoomAir_Node_AirflowNetwork_HVACEquipment_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoomAirSettings:AirflowNetwork", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_AirflowNetwork> RoomAirSettings_AirflowNetwork_List { get; set; } = null;
        

[JsonProperty(PropertyName="ScheduleTypeLimits", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.ScheduleTypeLimits> ScheduleTypeLimits_List { get; set; } = null;
        

[JsonProperty(PropertyName="Schedule:Day:Hourly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Day_Hourly> Schedule_Day_Hourly_List { get; set; } = null;
        

[JsonProperty(PropertyName="Schedule:Day:Interval", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Day_Interval> Schedule_Day_Interval_List { get; set; } = null;
        

[JsonProperty(PropertyName="Schedule:Day:List", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Day_List> Schedule_Day_List_List { get; set; } = null;
        

[JsonProperty(PropertyName="Schedule:Week:Daily", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Week_Daily> Schedule_Week_Daily_List { get; set; } = null;
        

[JsonProperty(PropertyName="Schedule:Week:Compact", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Week_Compact> Schedule_Week_Compact_List { get; set; } = null;
        

[JsonProperty(PropertyName="Schedule:Year", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Year> Schedule_Year_List { get; set; } = null;
        

[JsonProperty(PropertyName="Schedule:Compact", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Compact> Schedule_Compact_List { get; set; } = null;
        

[JsonProperty(PropertyName="Schedule:Constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Constant> Schedule_Constant_List { get; set; } = null;
        

[JsonProperty(PropertyName="Schedule:File:Shading", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.Schedules.Schedule_File_Shading Schedule_File_Shading { get; set; } = null;
        

[JsonProperty(PropertyName="Schedule:File", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_File> Schedule_File_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:Scheduled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Scheduled> SetpointManager_Scheduled_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:Scheduled:DualSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Scheduled_DualSetpoint> SetpointManager_Scheduled_DualSetpoint_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:OutdoorAirReset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_OutdoorAirReset> SetpointManager_OutdoorAirReset_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:SingleZone:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Reheat> SetpointManager_SingleZone_Reheat_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:SingleZone:Heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Heating> SetpointManager_SingleZone_Heating_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:SingleZone:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Cooling> SetpointManager_SingleZone_Cooling_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:SingleZone:Humidity:Minimum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Humidity_Minimum> SetpointManager_SingleZone_Humidity_Minimum_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:SingleZone:Humidity:Maximum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Humidity_Maximum> SetpointManager_SingleZone_Humidity_Maximum_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:MixedAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MixedAir> SetpointManager_MixedAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:OutdoorAirPretreat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_OutdoorAirPretreat> SetpointManager_OutdoorAirPretreat_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:Warmest", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Warmest> SetpointManager_Warmest_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:Coldest", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Coldest> SetpointManager_Coldest_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:ReturnAirBypassFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_ReturnAirBypassFlow> SetpointManager_ReturnAirBypassFlow_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:WarmestTemperatureFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_WarmestTemperatureFlow> SetpointManager_WarmestTemperatureFlow_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:MultiZone:Heating:Average", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Heating_Average> SetpointManager_MultiZone_Heating_Average_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:MultiZone:Cooling:Average", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Cooling_Average> SetpointManager_MultiZone_Cooling_Average_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:MultiZone:MinimumHumidity:Average", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_MinimumHumidity_Average> SetpointManager_MultiZone_MinimumHumidity_Average_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:MultiZone:MaximumHumidity:Average", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_MaximumHumidity_Average> SetpointManager_MultiZone_MaximumHumidity_Average_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:MultiZone:Humidity:Minimum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Humidity_Minimum> SetpointManager_MultiZone_Humidity_Minimum_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:MultiZone:Humidity:Maximum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Humidity_Maximum> SetpointManager_MultiZone_Humidity_Maximum_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:FollowOutdoorAirTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_FollowOutdoorAirTemperature> SetpointManager_FollowOutdoorAirTemperature_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:FollowSystemNodeTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_FollowSystemNodeTemperature> SetpointManager_FollowSystemNodeTemperature_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:FollowGroundTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_FollowGroundTemperature> SetpointManager_FollowGroundTemperature_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:CondenserEnteringReset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_CondenserEnteringReset> SetpointManager_CondenserEnteringReset_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:CondenserEnteringReset:Ideal", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_CondenserEnteringReset_Ideal> SetpointManager_CondenserEnteringReset_Ideal_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:SingleZone:OneStageCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_OneStageCooling> SetpointManager_SingleZone_OneStageCooling_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:SingleZone:OneStageHeating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_OneStageHeating> SetpointManager_SingleZone_OneStageHeating_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:ReturnTemperature:ChilledWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_ReturnTemperature_ChilledWater> SetpointManager_ReturnTemperature_ChilledWater_List { get; set; } = null;
        

[JsonProperty(PropertyName="SetpointManager:ReturnTemperature:HotWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_ReturnTemperature_HotWater> SetpointManager_ReturnTemperature_HotWater_List { get; set; } = null;
        

[JsonProperty(PropertyName="Version", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.Version Version { get; set; } = null;
        

[JsonProperty(PropertyName="SimulationControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.SimulationControl SimulationControl { get; set; } = null;
        

[JsonProperty(PropertyName="PerformancePrecisionTradeoffs", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.PerformancePrecisionTradeoffs PerformancePrecisionTradeoffs { get; set; } = null;
        

[JsonProperty(PropertyName="Building", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.Building Building { get; set; } = null;
        

[JsonProperty(PropertyName="ShadowCalculation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.ShadowCalculation ShadowCalculation { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceConvectionAlgorithm:Inside", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.SurfaceConvectionAlgorithm_Inside SurfaceConvectionAlgorithm_Inside { get; set; } = null;
        

[JsonProperty(PropertyName="SurfaceConvectionAlgorithm:Outside", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.SurfaceConvectionAlgorithm_Outside SurfaceConvectionAlgorithm_Outside { get; set; } = null;
        

[JsonProperty(PropertyName="HeatBalanceAlgorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.HeatBalanceAlgorithm HeatBalanceAlgorithm { get; set; } = null;
        

[JsonProperty(PropertyName="HeatBalanceSettings:ConductionFiniteDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.HeatBalanceSettings_ConductionFiniteDifference HeatBalanceSettings_ConductionFiniteDifference { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneAirHeatBalanceAlgorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.ZoneAirHeatBalanceAlgorithm ZoneAirHeatBalanceAlgorithm { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneAirContaminantBalance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.ZoneAirContaminantBalance ZoneAirContaminantBalance { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneAirMassFlowConservation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.ZoneAirMassFlowConservation ZoneAirMassFlowConservation { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneCapacitanceMultiplier:ResearchSpecial", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SimulationParameters.ZoneCapacitanceMultiplier_ResearchSpecial> ZoneCapacitanceMultiplier_ResearchSpecial_List { get; set; } = null;
        

[JsonProperty(PropertyName="Timestep", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.Timestep Timestep { get; set; } = null;
        

[JsonProperty(PropertyName="ConvergenceLimits", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.ConvergenceLimits ConvergenceLimits { get; set; } = null;
        

[JsonProperty(PropertyName="HVACSystemRootFindingAlgorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.SimulationParameters.HVACSystemRootFindingAlgorithm HVACSystemRootFindingAlgorithm { get; set; } = null;
        

[JsonProperty(PropertyName="SolarCollectorPerformance:FlatPlate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollectorPerformance_FlatPlate> SolarCollectorPerformance_FlatPlate_List { get; set; } = null;
        

[JsonProperty(PropertyName="SolarCollector:FlatPlate:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_FlatPlate_Water> SolarCollector_FlatPlate_Water_List { get; set; } = null;
        

[JsonProperty(PropertyName="SolarCollector:FlatPlate:PhotovoltaicThermal", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_FlatPlate_PhotovoltaicThermal> SolarCollector_FlatPlate_PhotovoltaicThermal_List { get; set; } = null;
        

[JsonProperty(PropertyName="SolarCollectorPerformance:PhotovoltaicThermal:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollectorPerformance_PhotovoltaicThermal_Simple> SolarCollectorPerformance_PhotovoltaicThermal_Simple_List { get; set; } = null;
        

[JsonProperty(PropertyName="SolarCollector:IntegralCollectorStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_IntegralCollectorStorage> SolarCollector_IntegralCollectorStorage_List { get; set; } = null;
        

[JsonProperty(PropertyName="SolarCollectorPerformance:IntegralCollectorStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollectorPerformance_IntegralCollectorStorage> SolarCollectorPerformance_IntegralCollectorStorage_List { get; set; } = null;
        

[JsonProperty(PropertyName="SolarCollector:UnglazedTranspired", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_UnglazedTranspired> SolarCollector_UnglazedTranspired_List { get; set; } = null;
        

[JsonProperty(PropertyName="SolarCollector:UnglazedTranspired:Multisystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_UnglazedTranspired_Multisystem> SolarCollector_UnglazedTranspired_Multisystem_List { get; set; } = null;
        

[JsonProperty(PropertyName="Material", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material> Material_List { get; set; } = null;
        

[JsonProperty(PropertyName="Material:NoMass", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_NoMass> Material_NoMass_List { get; set; } = null;
        

[JsonProperty(PropertyName="Material:InfraredTransparent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_InfraredTransparent> Material_InfraredTransparent_List { get; set; } = null;
        

[JsonProperty(PropertyName="Material:AirGap", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_AirGap> Material_AirGap_List { get; set; } = null;
        

[JsonProperty(PropertyName="Material:RoofVegetation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_RoofVegetation> Material_RoofVegetation_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:SimpleGlazingSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_SimpleGlazingSystem> WindowMaterial_SimpleGlazingSystem_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:Glazing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Glazing> WindowMaterial_Glazing_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:GlazingGroup:Thermochromic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_GlazingGroup_Thermochromic> WindowMaterial_GlazingGroup_Thermochromic_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:Glazing:RefractionExtinctionMethod", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Glazing_RefractionExtinctionMethod> WindowMaterial_Glazing_RefractionExtinctionMethod_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:Gas", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Gas> WindowMaterial_Gas_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowGap:SupportPillar", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowGap_SupportPillar> WindowGap_SupportPillar_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowGap:DeflectionState", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowGap_DeflectionState> WindowGap_DeflectionState_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:GasMixture", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_GasMixture> WindowMaterial_GasMixture_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:Gap", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Gap> WindowMaterial_Gap_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:Shade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Shade> WindowMaterial_Shade_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:ComplexShade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_ComplexShade> WindowMaterial_ComplexShade_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:Blind", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Blind> WindowMaterial_Blind_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:Screen", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Screen> WindowMaterial_Screen_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:Shade:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Shade_EquivalentLayer> WindowMaterial_Shade_EquivalentLayer_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:Drape:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Drape_EquivalentLayer> WindowMaterial_Drape_EquivalentLayer_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:Blind:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Blind_EquivalentLayer> WindowMaterial_Blind_EquivalentLayer_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:Screen:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Screen_EquivalentLayer> WindowMaterial_Screen_EquivalentLayer_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:Glazing:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Glazing_EquivalentLayer> WindowMaterial_Glazing_EquivalentLayer_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowMaterial:Gap:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Gap_EquivalentLayer> WindowMaterial_Gap_EquivalentLayer_List { get; set; } = null;
        

[JsonProperty(PropertyName="MaterialProperty:MoisturePenetrationDepth:Settings", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_MoisturePenetrationDepth_Settings> MaterialProperty_MoisturePenetrationDepth_Settings_List { get; set; } = null;
        

[JsonProperty(PropertyName="MaterialProperty:PhaseChange", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_PhaseChange> MaterialProperty_PhaseChange_List { get; set; } = null;
        

[JsonProperty(PropertyName="MaterialProperty:PhaseChangeHysteresis", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_PhaseChangeHysteresis> MaterialProperty_PhaseChangeHysteresis_List { get; set; } = null;
        

[JsonProperty(PropertyName="MaterialProperty:VariableThermalConductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_VariableThermalConductivity> MaterialProperty_VariableThermalConductivity_List { get; set; } = null;
        

[JsonProperty(PropertyName="MaterialProperty:HeatAndMoistureTransfer:Settings", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Settings> MaterialProperty_HeatAndMoistureTransfer_Settings_List { get; set; } = null;
        

[JsonProperty(PropertyName="MaterialProperty:HeatAndMoistureTransfer:SorptionIsotherm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_SorptionIsotherm> MaterialProperty_HeatAndMoistureTransfer_SorptionIsotherm_List { get; set; } = null;
        

[JsonProperty(PropertyName="MaterialProperty:HeatAndMoistureTransfer:Suction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Suction> MaterialProperty_HeatAndMoistureTransfer_Suction_List { get; set; } = null;
        

[JsonProperty(PropertyName="MaterialProperty:HeatAndMoistureTransfer:Redistribution", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Redistribution> MaterialProperty_HeatAndMoistureTransfer_Redistribution_List { get; set; } = null;
        

[JsonProperty(PropertyName="MaterialProperty:HeatAndMoistureTransfer:Diffusion", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Diffusion> MaterialProperty_HeatAndMoistureTransfer_Diffusion_List { get; set; } = null;
        

[JsonProperty(PropertyName="MaterialProperty:HeatAndMoistureTransfer:ThermalConductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_ThermalConductivity> MaterialProperty_HeatAndMoistureTransfer_ThermalConductivity_List { get; set; } = null;
        

[JsonProperty(PropertyName="MaterialProperty:GlazingSpectralData", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_GlazingSpectralData> MaterialProperty_GlazingSpectralData_List { get; set; } = null;
        

[JsonProperty(PropertyName="Construction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction> Construction_List { get; set; } = null;
        

[JsonProperty(PropertyName="Construction:CfactorUndergroundWall", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_CfactorUndergroundWall> Construction_CfactorUndergroundWall_List { get; set; } = null;
        

[JsonProperty(PropertyName="Construction:FfactorGroundFloor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_FfactorGroundFloor> Construction_FfactorGroundFloor_List { get; set; } = null;
        

[JsonProperty(PropertyName="ConstructionProperty:InternalHeatSource", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.ConstructionProperty_InternalHeatSource> ConstructionProperty_InternalHeatSource_List { get; set; } = null;
        

[JsonProperty(PropertyName="Construction:AirBoundary", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_AirBoundary> Construction_AirBoundary_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowThermalModel:Params", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowThermalModel_Params> WindowThermalModel_Params_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowsCalculationEngine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowsCalculationEngine> WindowsCalculationEngine_List { get; set; } = null;
        

[JsonProperty(PropertyName="Construction:ComplexFenestrationState", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_ComplexFenestrationState> Construction_ComplexFenestrationState_List { get; set; } = null;
        

[JsonProperty(PropertyName="Construction:WindowEquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_WindowEquivalentLayer> Construction_WindowEquivalentLayer_List { get; set; } = null;
        

[JsonProperty(PropertyName="Construction:WindowDataFile", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_WindowDataFile> Construction_WindowDataFile_List { get; set; } = null;
        

[JsonProperty(PropertyName="AvailabilityManager:Scheduled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_Scheduled> AvailabilityManager_Scheduled_List { get; set; } = null;
        

[JsonProperty(PropertyName="AvailabilityManager:ScheduledOn", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_ScheduledOn> AvailabilityManager_ScheduledOn_List { get; set; } = null;
        

[JsonProperty(PropertyName="AvailabilityManager:ScheduledOff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_ScheduledOff> AvailabilityManager_ScheduledOff_List { get; set; } = null;
        

[JsonProperty(PropertyName="AvailabilityManager:OptimumStart", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_OptimumStart> AvailabilityManager_OptimumStart_List { get; set; } = null;
        

[JsonProperty(PropertyName="AvailabilityManager:NightCycle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_NightCycle> AvailabilityManager_NightCycle_List { get; set; } = null;
        

[JsonProperty(PropertyName="AvailabilityManager:DifferentialThermostat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_DifferentialThermostat> AvailabilityManager_DifferentialThermostat_List { get; set; } = null;
        

[JsonProperty(PropertyName="AvailabilityManager:HighTemperatureTurnOff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_HighTemperatureTurnOff> AvailabilityManager_HighTemperatureTurnOff_List { get; set; } = null;
        

[JsonProperty(PropertyName="AvailabilityManager:HighTemperatureTurnOn", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_HighTemperatureTurnOn> AvailabilityManager_HighTemperatureTurnOn_List { get; set; } = null;
        

[JsonProperty(PropertyName="AvailabilityManager:LowTemperatureTurnOff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_LowTemperatureTurnOff> AvailabilityManager_LowTemperatureTurnOff_List { get; set; } = null;
        

[JsonProperty(PropertyName="AvailabilityManager:LowTemperatureTurnOn", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_LowTemperatureTurnOn> AvailabilityManager_LowTemperatureTurnOn_List { get; set; } = null;
        

[JsonProperty(PropertyName="AvailabilityManager:NightVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_NightVentilation> AvailabilityManager_NightVentilation_List { get; set; } = null;
        

[JsonProperty(PropertyName="AvailabilityManager:HybridVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_HybridVentilation> AvailabilityManager_HybridVentilation_List { get; set; } = null;
        

[JsonProperty(PropertyName="AvailabilityManagerAssignmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManagerAssignmentList> AvailabilityManagerAssignmentList_List { get; set; } = null;
        

[JsonProperty(PropertyName="GlobalGeometryRules", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GlobalGeometryRules GlobalGeometryRules { get; set; } = null;
        

[JsonProperty(PropertyName="GeometryTransform", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GeometryTransform GeometryTransform { get; set; } = null;
        

[JsonProperty(PropertyName="Zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Zone> Zone_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.ZoneList> ZoneList_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneGroup", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.ZoneGroup> ZoneGroup_List { get; set; } = null;
        

[JsonProperty(PropertyName="BuildingSurface:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.BuildingSurface_Detailed> BuildingSurface_Detailed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Wall:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Detailed> Wall_Detailed_List { get; set; } = null;
        

[JsonProperty(PropertyName="RoofCeiling:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.RoofCeiling_Detailed> RoofCeiling_Detailed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Floor:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_Detailed> Floor_Detailed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Wall:Exterior", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Exterior> Wall_Exterior_List { get; set; } = null;
        

[JsonProperty(PropertyName="Wall:Adiabatic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Adiabatic> Wall_Adiabatic_List { get; set; } = null;
        

[JsonProperty(PropertyName="Wall:Underground", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Underground> Wall_Underground_List { get; set; } = null;
        

[JsonProperty(PropertyName="Wall:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Interzone> Wall_Interzone_List { get; set; } = null;
        

[JsonProperty(PropertyName="Roof", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Roof> Roof_List { get; set; } = null;
        

[JsonProperty(PropertyName="Ceiling:Adiabatic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Ceiling_Adiabatic> Ceiling_Adiabatic_List { get; set; } = null;
        

[JsonProperty(PropertyName="Ceiling:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Ceiling_Interzone> Ceiling_Interzone_List { get; set; } = null;
        

[JsonProperty(PropertyName="Floor:GroundContact", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_GroundContact> Floor_GroundContact_List { get; set; } = null;
        

[JsonProperty(PropertyName="Floor:Adiabatic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_Adiabatic> Floor_Adiabatic_List { get; set; } = null;
        

[JsonProperty(PropertyName="Floor:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_Interzone> Floor_Interzone_List { get; set; } = null;
        

[JsonProperty(PropertyName="FenestrationSurface:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.FenestrationSurface_Detailed> FenestrationSurface_Detailed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Window", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Window> Window_List { get; set; } = null;
        

[JsonProperty(PropertyName="Door", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Door> Door_List { get; set; } = null;
        

[JsonProperty(PropertyName="GlazedDoor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GlazedDoor> GlazedDoor_List { get; set; } = null;
        

[JsonProperty(PropertyName="Window:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Window_Interzone> Window_Interzone_List { get; set; } = null;
        

[JsonProperty(PropertyName="Door:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Door_Interzone> Door_Interzone_List { get; set; } = null;
        

[JsonProperty(PropertyName="GlazedDoor:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GlazedDoor_Interzone> GlazedDoor_Interzone_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowShadingControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowShadingControl> WindowShadingControl_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowProperty:FrameAndDivider", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowProperty_FrameAndDivider> WindowProperty_FrameAndDivider_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowProperty:AirflowControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowProperty_AirflowControl> WindowProperty_AirflowControl_List { get; set; } = null;
        

[JsonProperty(PropertyName="WindowProperty:StormWindow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowProperty_StormWindow> WindowProperty_StormWindow_List { get; set; } = null;
        

[JsonProperty(PropertyName="InternalMass", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.InternalMass> InternalMass_List { get; set; } = null;
        

[JsonProperty(PropertyName="Shading:Site", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Site> Shading_Site_List { get; set; } = null;
        

[JsonProperty(PropertyName="Shading:Building", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Building> Shading_Building_List { get; set; } = null;
        

[JsonProperty(PropertyName="Shading:Site:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Site_Detailed> Shading_Site_Detailed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Shading:Building:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Building_Detailed> Shading_Building_Detailed_List { get; set; } = null;
        

[JsonProperty(PropertyName="Shading:Overhang", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Overhang> Shading_Overhang_List { get; set; } = null;
        

[JsonProperty(PropertyName="Shading:Overhang:Projection", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Overhang_Projection> Shading_Overhang_Projection_List { get; set; } = null;
        

[JsonProperty(PropertyName="Shading:Fin", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Fin> Shading_Fin_List { get; set; } = null;
        

[JsonProperty(PropertyName="Shading:Fin:Projection", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Fin_Projection> Shading_Fin_Projection_List { get; set; } = null;
        

[JsonProperty(PropertyName="Shading:Zone:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Zone_Detailed> Shading_Zone_Detailed_List { get; set; } = null;
        

[JsonProperty(PropertyName="ShadingProperty:Reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.ShadingProperty_Reflectance> ShadingProperty_Reflectance_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:UnitarySystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitarySystem> AirLoopHVAC_UnitarySystem_List { get; set; } = null;
        

[JsonProperty(PropertyName="UnitarySystemPerformance:Multispeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.UnitarySystemPerformance_Multispeed> UnitarySystemPerformance_Multispeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:Unitary:Furnace:HeatOnly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_Unitary_Furnace_HeatOnly> AirLoopHVAC_Unitary_Furnace_HeatOnly_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:Unitary:Furnace:HeatCool", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_Unitary_Furnace_HeatCool> AirLoopHVAC_Unitary_Furnace_HeatCool_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:UnitaryHeatOnly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatOnly> AirLoopHVAC_UnitaryHeatOnly_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:UnitaryHeatCool", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatCool> AirLoopHVAC_UnitaryHeatCool_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:UnitaryHeatPump:AirToAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatPump_AirToAir> AirLoopHVAC_UnitaryHeatPump_AirToAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:UnitaryHeatPump:WaterToAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatPump_WaterToAir> AirLoopHVAC_UnitaryHeatPump_WaterToAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:UnitaryHeatCool:VAVChangeoverBypass", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass> AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirLoopHVAC:UnitaryHeatPump:AirToAir:MultiSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed> AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:ForcedAir:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.ZoneHVAC_ForcedAir_UserDefined> ZoneHVAC_ForcedAir_UserDefined_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.AirTerminal_SingleDuct_UserDefined> AirTerminal_SingleDuct_UserDefined_List { get; set; } = null;
        

[JsonProperty(PropertyName="Coil:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.Coil_UserDefined> Coil_UserDefined_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantComponent:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.PlantComponent_UserDefined> PlantComponent_UserDefined_List { get; set; } = null;
        

[JsonProperty(PropertyName="PlantEquipmentOperation:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.PlantEquipmentOperation_UserDefined> PlantEquipmentOperation_UserDefined_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirConditioner:VariableRefrigerantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow> AirConditioner_VariableRefrigerantFlow_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl> AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:HR", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR> AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneTerminalUnitList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.ZoneTerminalUnitList> ZoneTerminalUnitList_List { get; set; } = null;
        

[JsonProperty(PropertyName="WaterHeater:Mixed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_Mixed> WaterHeater_Mixed_List { get; set; } = null;
        

[JsonProperty(PropertyName="WaterHeater:Stratified", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_Stratified> WaterHeater_Stratified_List { get; set; } = null;
        

[JsonProperty(PropertyName="WaterHeater:Sizing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_Sizing> WaterHeater_Sizing_List { get; set; } = null;
        

[JsonProperty(PropertyName="WaterHeater:HeatPump:PumpedCondenser", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_HeatPump_PumpedCondenser> WaterHeater_HeatPump_PumpedCondenser_List { get; set; } = null;
        

[JsonProperty(PropertyName="WaterHeater:HeatPump:WrappedCondenser", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_HeatPump_WrappedCondenser> WaterHeater_HeatPump_WrappedCondenser_List { get; set; } = null;
        

[JsonProperty(PropertyName="ThermalStorage:Ice:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_Ice_Simple> ThermalStorage_Ice_Simple_List { get; set; } = null;
        

[JsonProperty(PropertyName="ThermalStorage:Ice:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_Ice_Detailed> ThermalStorage_Ice_Detailed_List { get; set; } = null;
        

[JsonProperty(PropertyName="ThermalStorage:ChilledWater:Mixed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_ChilledWater_Mixed> ThermalStorage_ChilledWater_Mixed_List { get; set; } = null;
        

[JsonProperty(PropertyName="ThermalStorage:ChilledWater:Stratified", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_ChilledWater_Stratified> ThermalStorage_ChilledWater_Stratified_List { get; set; } = null;
        

[JsonProperty(PropertyName="WaterUse:Equipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Equipment> WaterUse_Equipment_List { get; set; } = null;
        

[JsonProperty(PropertyName="WaterUse:Connections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Connections> WaterUse_Connections_List { get; set; } = null;
        

[JsonProperty(PropertyName="WaterUse:Storage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Storage> WaterUse_Storage_List { get; set; } = null;
        

[JsonProperty(PropertyName="WaterUse:Well", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Well> WaterUse_Well_List { get; set; } = null;
        

[JsonProperty(PropertyName="WaterUse:RainCollector", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_RainCollector> WaterUse_RainCollector_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneInfiltration:DesignFlowRate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneInfiltration_DesignFlowRate> ZoneInfiltration_DesignFlowRate_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneInfiltration:EffectiveLeakageArea", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneInfiltration_EffectiveLeakageArea> ZoneInfiltration_EffectiveLeakageArea_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneInfiltration:FlowCoefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneInfiltration_FlowCoefficient> ZoneInfiltration_FlowCoefficient_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneVentilation:DesignFlowRate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneVentilation_DesignFlowRate> ZoneVentilation_DesignFlowRate_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneVentilation:WindandStackOpenArea", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneVentilation_WindandStackOpenArea> ZoneVentilation_WindandStackOpenArea_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneAirBalance:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneAirBalance_OutdoorAir> ZoneAirBalance_OutdoorAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneMixing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneMixing> ZoneMixing_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneCrossMixing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneCrossMixing> ZoneCrossMixing_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneRefrigerationDoorMixing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneRefrigerationDoorMixing> ZoneRefrigerationDoorMixing_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneEarthtube", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneEarthtube> ZoneEarthtube_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneCoolTower:Shower", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneCoolTower_Shower> ZoneCoolTower_Shower_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneThermalChimney", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneThermalChimney> ZoneThermalChimney_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:ConstantVolume:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_Reheat> AirTerminal_SingleDuct_ConstantVolume_Reheat_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:ConstantVolume:NoReheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_NoReheat> AirTerminal_SingleDuct_ConstantVolume_NoReheat_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:VAV:NoReheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_NoReheat> AirTerminal_SingleDuct_VAV_NoReheat_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:VAV:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_Reheat> AirTerminal_SingleDuct_VAV_Reheat_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:VAV:Reheat:VariableSpeedFan", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan> AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:VAV:HeatAndCool:NoReheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_HeatAndCool_NoReheat> AirTerminal_SingleDuct_VAV_HeatAndCool_NoReheat_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:VAV:HeatAndCool:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat> AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:SeriesPIU:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_SeriesPIU_Reheat> AirTerminal_SingleDuct_SeriesPIU_Reheat_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:ParallelPIU:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ParallelPIU_Reheat> AirTerminal_SingleDuct_ParallelPIU_Reheat_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:ConstantVolume:FourPipeInduction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction> AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:ConstantVolume:FourPipeBeam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_FourPipeBeam> AirTerminal_SingleDuct_ConstantVolume_FourPipeBeam_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:ConstantVolume:CooledBeam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_CooledBeam> AirTerminal_SingleDuct_ConstantVolume_CooledBeam_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:SingleDuct:Mixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_Mixer> AirTerminal_SingleDuct_Mixer_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:DualDuct:ConstantVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_DualDuct_ConstantVolume> AirTerminal_DualDuct_ConstantVolume_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:DualDuct:VAV", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_DualDuct_VAV> AirTerminal_DualDuct_VAV_List { get; set; } = null;
        

[JsonProperty(PropertyName="AirTerminal:DualDuct:VAV:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_DualDuct_VAV_OutdoorAir> AirTerminal_DualDuct_VAV_OutdoorAir_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:AirDistributionUnit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.ZoneHVAC_AirDistributionUnit> ZoneHVAC_AirDistributionUnit_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneControl:Humidistat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Humidistat> ZoneControl_Humidistat_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneControl:Thermostat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat> ZoneControl_Thermostat_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneControl:Thermostat:OperativeTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_OperativeTemperature> ZoneControl_Thermostat_OperativeTemperature_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneControl:Thermostat:ThermalComfort", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_ThermalComfort> ZoneControl_Thermostat_ThermalComfort_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneControl:Thermostat:TemperatureAndHumidity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_TemperatureAndHumidity> ZoneControl_Thermostat_TemperatureAndHumidity_List { get; set; } = null;
        

[JsonProperty(PropertyName="ThermostatSetpoint:SingleHeating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_SingleHeating> ThermostatSetpoint_SingleHeating_List { get; set; } = null;
        

[JsonProperty(PropertyName="ThermostatSetpoint:SingleCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_SingleCooling> ThermostatSetpoint_SingleCooling_List { get; set; } = null;
        

[JsonProperty(PropertyName="ThermostatSetpoint:SingleHeatingOrCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_SingleHeatingOrCooling> ThermostatSetpoint_SingleHeatingOrCooling_List { get; set; } = null;
        

[JsonProperty(PropertyName="ThermostatSetpoint:DualSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_DualSetpoint> ThermostatSetpoint_DualSetpoint_List { get; set; } = null;
        

[JsonProperty(PropertyName="ThermostatSetpoint:ThermalComfort:Fanger:SingleHeating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_SingleHeating> ThermostatSetpoint_ThermalComfort_Fanger_SingleHeating_List { get; set; } = null;
        

[JsonProperty(PropertyName="ThermostatSetpoint:ThermalComfort:Fanger:SingleCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_SingleCooling> ThermostatSetpoint_ThermalComfort_Fanger_SingleCooling_List { get; set; } = null;
        

[JsonProperty(PropertyName="ThermostatSetpoint:ThermalComfort:Fanger:SingleHeatingOrCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_SingleHeatingOrCooling> ThermostatSetpoint_ThermalComfort_Fanger_SingleHeatingOrCooling_List { get; set; } = null;
        

[JsonProperty(PropertyName="ThermostatSetpoint:ThermalComfort:Fanger:DualSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_DualSetpoint> ThermostatSetpoint_ThermalComfort_Fanger_DualSetpoint_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneControl:Thermostat:StagedDualSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_StagedDualSetpoint> ZoneControl_Thermostat_StagedDualSetpoint_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneControl:ContaminantController", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_ContaminantController> ZoneControl_ContaminantController_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:EquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections.ZoneHVAC_EquipmentList> ZoneHVAC_EquipmentList_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:EquipmentConnections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections.ZoneHVAC_EquipmentConnections> ZoneHVAC_EquipmentConnections_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:IdealLoadsAirSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_IdealLoadsAirSystem> ZoneHVAC_IdealLoadsAirSystem_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:FourPipeFanCoil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_FourPipeFanCoil> ZoneHVAC_FourPipeFanCoil_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:WindowAirConditioner", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_WindowAirConditioner> ZoneHVAC_WindowAirConditioner_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:PackagedTerminalAirConditioner", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_PackagedTerminalAirConditioner> ZoneHVAC_PackagedTerminalAirConditioner_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:PackagedTerminalHeatPump", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_PackagedTerminalHeatPump> ZoneHVAC_PackagedTerminalHeatPump_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:WaterToAirHeatPump", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_WaterToAirHeatPump> ZoneHVAC_WaterToAirHeatPump_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:Dehumidifier:DX", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_Dehumidifier_DX> ZoneHVAC_Dehumidifier_DX_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:EnergyRecoveryVentilator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_EnergyRecoveryVentilator> ZoneHVAC_EnergyRecoveryVentilator_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:EnergyRecoveryVentilator:Controller", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_EnergyRecoveryVentilator_Controller> ZoneHVAC_EnergyRecoveryVentilator_Controller_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:UnitVentilator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_UnitVentilator> ZoneHVAC_UnitVentilator_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:UnitHeater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_UnitHeater> ZoneHVAC_UnitHeater_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:EvaporativeCoolerUnit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_EvaporativeCoolerUnit> ZoneHVAC_EvaporativeCoolerUnit_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:HybridUnitaryHVAC", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_HybridUnitaryHVAC> ZoneHVAC_HybridUnitaryHVAC_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:OutdoorAirUnit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_OutdoorAirUnit> ZoneHVAC_OutdoorAirUnit_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:OutdoorAirUnit:EquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_OutdoorAirUnit_EquipmentList> ZoneHVAC_OutdoorAirUnit_EquipmentList_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:TerminalUnit:VariableRefrigerantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_TerminalUnit_VariableRefrigerantFlow> ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:Baseboard:RadiantConvective:Water:Design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Water_Design> ZoneHVAC_Baseboard_RadiantConvective_Water_Design_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:Baseboard:RadiantConvective:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Water> ZoneHVAC_Baseboard_RadiantConvective_Water_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:Baseboard:RadiantConvective:Steam:Design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Steam_Design> ZoneHVAC_Baseboard_RadiantConvective_Steam_Design_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:Baseboard:RadiantConvective:Steam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Steam> ZoneHVAC_Baseboard_RadiantConvective_Steam_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:Baseboard:RadiantConvective:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Electric> ZoneHVAC_Baseboard_RadiantConvective_Electric_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:CoolingPanel:RadiantConvective:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_CoolingPanel_RadiantConvective_Water> ZoneHVAC_CoolingPanel_RadiantConvective_Water_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:Baseboard:Convective:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_Convective_Water> ZoneHVAC_Baseboard_Convective_Water_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:Baseboard:Convective:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_Convective_Electric> ZoneHVAC_Baseboard_Convective_Electric_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:LowTemperatureRadiant:VariableFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_VariableFlow> ZoneHVAC_LowTemperatureRadiant_VariableFlow_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:LowTemperatureRadiant:VariableFlow:Design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design> ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:LowTemperatureRadiant:ConstantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_ConstantFlow> ZoneHVAC_LowTemperatureRadiant_ConstantFlow_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:LowTemperatureRadiant:ConstantFlow:Design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design> ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:LowTemperatureRadiant:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_Electric> ZoneHVAC_LowTemperatureRadiant_Electric_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:LowTemperatureRadiant:SurfaceGroup", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_SurfaceGroup> ZoneHVAC_LowTemperatureRadiant_SurfaceGroup_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:HighTemperatureRadiant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_HighTemperatureRadiant> ZoneHVAC_HighTemperatureRadiant_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:VentilatedSlab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_VentilatedSlab> ZoneHVAC_VentilatedSlab_List { get; set; } = null;
        

[JsonProperty(PropertyName="ZoneHVAC:VentilatedSlab:SlabGroup", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_VentilatedSlab_SlabGroup> ZoneHVAC_VentilatedSlab_SlabGroup_List { get; set; } = null;
    }
    
    public enum EmptyNoYes
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="No")]
        No = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Yes")]
        Yes = 2,
    }
}
