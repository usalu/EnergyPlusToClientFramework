namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
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
    using BH.oM.Adapters.EnergyPlus.PythonPluginSystem;
    using BH.oM.Adapters.EnergyPlus.Refrigeration;
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
    
    
    [Description("Selects the type of room air model to be used in a given zone. If no RoomAirModel" +
        "Type object is specified then the default Mixing model (all zone air at the same" +
        " temperature) will be used.")]
    public class RoomAirModelType : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description(@"Mixing = Complete mixing air model UserDefined = UserDefined Room Air Temperature Patterns needs RoomAir:TemperaturePattern:UserDefined object referencing this Zone OneNodeDisplacementVentilation = Mundt roomair model for displacement ventilation with single floor air node needs RoomAirSettings:OneNodeDisplacementVentilation object referencing this Zone ThreeNodeDisplacementVentilation = RoomAir modeling using UCSD three-node displacement ventilation model needs RoomAirSettings:ThreeNodeDisplacementVentilation object referencing this Zone CrossVentilation = RoomAir modeling using UCSD two-zone cross ventilation model needs RoomAirSettings:CrossVentilation object referencing this Zone UnderFloorAirDistributionInterior = 2-Node UFAD model for interior zones needs RoomAirSettings:UnderFloorAirDistributionInterior object referencing this Zone UnderFloorAirDistributionExterior = RoomAir modeling using 2-Node UFAD model for exterior zones needs RoomAirSettings:UnderFloorAirDistributionExterior object referencing this Zone AirflowNetwork = RoomAir modeling using AirflowNetwork needs RoomAirSettings:AirflowNetwork object referencing this Zone")]
[JsonProperty("room_air_modeling_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RoomAirModelType_RoomAirModelingType RoomAirModelingType { get; set; } = (RoomAirModelType_RoomAirModelingType)Enum.Parse(typeof(RoomAirModelType_RoomAirModelingType), "Mixing");
        

[JsonProperty("air_temperature_coupling_strategy")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public RoomAirModelType_AirTemperatureCouplingStrategy AirTemperatureCouplingStrategy { get; set; } = (RoomAirModelType_AirTemperatureCouplingStrategy)Enum.Parse(typeof(RoomAirModelType_AirTemperatureCouplingStrategy), "Direct");
    }
}
