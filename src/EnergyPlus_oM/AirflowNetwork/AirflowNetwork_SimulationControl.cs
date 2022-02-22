namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using BH.oM.Base;
    using BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts;
    using BH.oM.Adapters.EnergyPlus.AirDistribution;
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
    
    
    [Description("This object defines the global parameters used in an Airflow Network simulation.")]
    [JsonObject("AirflowNetwork:SimulationControl")]
    public class AirflowNetwork_SimulationControl : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"NoMultizoneOrDistribution: Only perform Simple calculations (objects ZoneInfiltration:*, ZoneVentilation:*, ZoneMixing, ZoneCrossMixing, ZoneRefrigerationDoorMixing, ZoneAirBalance:OutdoorAir, ZoneEarthtube, ZoneThermalChimney, and ZoneCoolTower:Shower); MultizoneWithoutDistribution: Use AirflowNetwork objects to simulate multizone Airflows driven by wind during simulation time, and objects of ZoneInfiltration:*, ZoneVentilation:*, ZoneMixing, ZoneCrossMixing ZoneRefrigerationDoorMixing, ZoneAirBalance:OutdoorAir, ZoneEarthtube, ZoneThermalChimney, and ZoneCoolTower:Shower are ignored; MultizoneWithDistributionOnlyDuringFanOperation: Perform distribution system calculations during system fan on time and Simple calculations during system Fan off time; MultizoneWithDistribution: Perform distribution system calculations during system fan on time and multizone Airflow driven by wind during system fan off time.")]
[JsonProperty("airflownetwork_control")]
public AirflowNetwork_SimulationControl_AirflownetworkControl AirflownetworkControl { get; set; } = (AirflowNetwork_SimulationControl_AirflownetworkControl)Enum.Parse(typeof(AirflowNetwork_SimulationControl_AirflownetworkControl), "NoMultizoneOrDistribution");
        

[Description(@"Input: User must enter AirflowNetwork:MultiZone:WindPressureCoefficientArray, AirflowNetwork:MultiZone:ExternalNode, and AirflowNetwork:MultiZone:WindPressureCoefficientValues objects. SurfaceAverageCalculation: used only for rectangular buildings. If SurfaceAverageCalculation is selected, AirflowNetwork:MultiZone:WindPressureCoefficientArray, AirflowNetwork:MultiZone:ExternalNode, and AirflowNetwork:MultiZone:WindPressureCoefficientValues objects are not used.")]
[JsonProperty("wind_pressure_coefficient_type")]
public AirflowNetwork_SimulationControl_WindPressureCoefficientType WindPressureCoefficientType { get; set; } = (AirflowNetwork_SimulationControl_WindPressureCoefficientType)Enum.Parse(typeof(AirflowNetwork_SimulationControl_WindPressureCoefficientType), "SurfaceAverageCalculation");
        

[Description(@"If ExternalNode is selected, the height given in the AirflowNetwork:MultiZone:ExternalNode object will be used. If OpeningHeight is selected, the surface opening height (centroid) will be used to calculate local wind pressure This field is ignored when the choice of the Wind Pressure Coefficient Type field is SurfaceAverageCalculation.")]
[JsonProperty("height_selection_for_local_wind_pressure_calculation")]
public AirflowNetwork_SimulationControl_HeightSelectionForLocalWindPressureCalculation HeightSelectionForLocalWindPressureCalculation { get; set; } = (AirflowNetwork_SimulationControl_HeightSelectionForLocalWindPressureCalculation)Enum.Parse(typeof(AirflowNetwork_SimulationControl_HeightSelectionForLocalWindPressureCalculation), "OpeningHeight");
        

[Description("Used only if Wind Pressure Coefficient Type = SurfaceAverageCalculation, otherwis" +
    "e this field may be left blank.")]
[JsonProperty("building_type")]
public AirflowNetwork_SimulationControl_BuildingType BuildingType { get; set; } = (AirflowNetwork_SimulationControl_BuildingType)Enum.Parse(typeof(AirflowNetwork_SimulationControl_BuildingType), "LowRise");
        

[Description("Determines the maximum number of iterations used to converge on a solution. If th" +
    "is limit is exceeded, the program terminates.")]
[JsonProperty("maximum_number_of_iterations")]
public System.Nullable<float> MaximumNumberOfIterations { get; set; } = (System.Nullable<float>)Single.Parse("500", CultureInfo.InvariantCulture);
        

[JsonProperty("initialization_type")]
public AirflowNetwork_SimulationControl_InitializationType InitializationType { get; set; } = (AirflowNetwork_SimulationControl_InitializationType)Enum.Parse(typeof(AirflowNetwork_SimulationControl_InitializationType), "ZeroNodePressures");
        

[Description(@"This tolerance is defined as the absolute value of the sum of the mass Flow Rates divided by the sum of the absolute value of the mass Flow Rates. The mass Flow Rates described here refer to the mass Flow Rates at all Nodes in the AirflowNetwork model. The solution converges when both this tolerance and the tolerance in the next field (Absolute Airflow Convergence Tolerance) are satisfied.")]
[JsonProperty("relative_airflow_convergence_tolerance")]
public System.Nullable<float> RelativeAirflowConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.0001", CultureInfo.InvariantCulture);
        

[Description(@"This tolerance is defined as the absolute value of the sum of the mass flow rates. The mass flow rates described here refer to the mass flow rates at all nodes in the AirflowNetwork model. The solution converges when both this tolerance and the tolerance in the previous field (Relative Airflow Convergence Tolerance) are satisfied.")]
[JsonProperty("absolute_airflow_convergence_tolerance")]
public System.Nullable<float> AbsoluteAirflowConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("1E-06", CultureInfo.InvariantCulture);
        

[Description("Used only for AirflowNetwork:SimulationControl")]
[JsonProperty("convergence_acceleration_limit")]
public System.Nullable<float> ConvergenceAccelerationLimit { get; set; } = (System.Nullable<float>)Single.Parse("-0.5", CultureInfo.InvariantCulture);
        

[Description("Degrees clockwise from true North. Used only if Wind Pressure Coefficient Type = " +
    "SurfaceAverageCalculation.")]
[JsonProperty("azimuth_angle_of_long_axis_of_building")]
public System.Nullable<float> AzimuthAngleOfLongAxisOfBuilding { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only if Wind Pressure Coefficient Type = SurfaceAverageCalculation.")]
[JsonProperty("ratio_of_building_width_along_short_axis_to_width_along_long_axis")]
public System.Nullable<float> RatioOfBuildingWidthAlongShortAxisToWidthAlongLongAxis { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("If Yes, external node temperature is height dependent. If No, external node tempe" +
    "rature is based on zero height.")]
[JsonProperty("height_dependence_of_external_node_temperature")]
public EmptyNoYes HeightDependenceOfExternalNodeTemperature { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Select the solver to use for the pressure network solution")]
[JsonProperty("solver")]
public AirflowNetwork_SimulationControl_Solver Solver { get; set; } = (AirflowNetwork_SimulationControl_Solver)Enum.Parse(typeof(AirflowNetwork_SimulationControl_Solver), "SkylineLU");
        

[Description(@"Set this input to Yes to have zone equipment that are currently unsupported in the AirflowNetwork model allowed in the simulation if present. Setting this field to Yes, allows the following equipments to be modeled along an AirflowNetwork model: ZoneHVAC:Dehumidifier, ZoneHVAC:EnergyRecoveryVentilator, WaterHeater:HeatPump:*.")]
[JsonProperty("allow_unsupported_zone_equipment")]
public EmptyNoYes AllowUnsupportedZoneEquipment { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
}
