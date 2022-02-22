namespace BH.oM.Adapters.EnergyPlus.Controllers
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
    
    
    [Description(@"Controller for a water coil which is located directly in an air loop branch or outdoor air equipment list. Controls the coil water flow to meet the specified leaving air setpoint(s). Used with Coil:Heating:Water, Coil:Cooling:Water, Coil:Cooling:Water:DetailedGeometry, and CoilSystem:Cooling:Water:HeatexchangerAssisted.")]
    [JsonObject("Controller:WaterCoil")]
    public class Controller_WaterCoil : BHoMObject, IEnergyPlusClass
    {
        

[Description("keys HumidityRatio or TemperatureAndHumidityRatio requires a ZoneControl:Humidist" +
    "at object along with SetpointManager:SingleZone:Humidity:Maximum, SetpointManage" +
    "r:MultiZone:MaximumHumidity:Average, or SetpointManager:Multizone:Humidity:Maxim" +
    "um object")]
[JsonProperty("control_variable")]
public Controller_WaterCoil_ControlVariable ControlVariable { get; set; } = (Controller_WaterCoil_ControlVariable)Enum.Parse(typeof(Controller_WaterCoil_ControlVariable), "HumidityRatio");
        

[Description("Leave blank to have this automatically selected from coil type. Chilled water coi" +
    "ls should be reverse action Hot water coils should be normal action")]
[JsonProperty("action")]
public Controller_WaterCoil_Action Action { get; set; } = (Controller_WaterCoil_Action)Enum.Parse(typeof(Controller_WaterCoil_Action), "Normal");
        

[JsonProperty("actuator_variable")]
public Controller_WaterCoil_ActuatorVariable ActuatorVariable { get; set; } = (Controller_WaterCoil_ActuatorVariable)Enum.Parse(typeof(Controller_WaterCoil_ActuatorVariable), "Flow");
        

[JsonProperty("sensor_node_name")]
public string SensorNodeName { get; set; } = "";
        

[JsonProperty("actuator_node_name")]
public string ActuatorNodeName { get; set; } = "";
        

[JsonProperty("controller_convergence_tolerance")]
public string ControllerConvergenceTolerance { get; set; } = (System.String)"Autosize";
        

[JsonProperty("maximum_actuated_flow")]
public string MaximumActuatedFlow { get; set; } = (System.String)"Autosize";
        

[JsonProperty("minimum_actuated_flow")]
public System.Nullable<float> MinimumActuatedFlow { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}
