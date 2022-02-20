namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
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
    
    
    [Description("This object is used to describe general outdoor air requirements which are refere" +
        "nced by other objects.")]
    [JsonObject("DesignSpecification:OutdoorAir")]
    public class DesignSpecification_OutdoorAir : BHoMObject
    {
        

[Description(@"Flow/Person => Outdoor Air Flow per Person * Occupancy = Design Flow Rate, Flow/Area => Outdoor Air Flow per Zone Floor Area * Zone Floor Area = Design Flow Rate, Flow/Zone => Outdoor Air Flow per Zone = Design Flow Rate, AirChanges/Hour => Outdoor Air Flow Air Changes per Hour * Zone Volume adjusted for m3/s = Design Flow Rate")]
[JsonProperty("outdoor_air_method")]
public EmptyNoYes OutdoorAirMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Flow/Person");
        

[Description(@"0.00944 m3/s is equivalent to 20 cfm per person This input is only used if the field Outdoor Air Method is Flow/Person, Sum, or Maximum For sizing, the design number of occupants is used. For outdoor air flow control, the use of design occupants or current occupants depends on the component and DCV options. AirTerminal:SingleDuct:VAV:NoReheat, AirTerminal:SingleDuct:VAV:Reheat use the DCV flag specified in Controller:MechanicalVentilation AirTerminal:DualDuct:VAV:OutdoorAir and ZoneHVAC:IdealLoadsAirSystem have their own DCV control input. ZoneHVAC:FourPipeFanCoil always uses current occupants.")]
[JsonProperty("outdoor_air_flow_per_person")]
public System.Nullable<float> OutdoorAirFlowPerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is only used if the field Outdoor Air Method is Flow/Area, Sum, or Max" +
    "imum")]
[JsonProperty("outdoor_air_flow_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowPerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is only used if the field Outdoor Air Method is Flow/Zone, Sum, or Max" +
    "imum")]
[JsonProperty("outdoor_air_flow_per_zone")]
public System.Nullable<float> OutdoorAirFlowPerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is only used if the field Outdoor Air Method is AirChanges/Hour, Sum, " +
    "or Maximum")]
[JsonProperty("outdoor_air_flow_air_changes_per_hour")]
public System.Nullable<float> OutdoorAirFlowAirChangesPerHour { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Schedule values are multiplied by the Outdoor Air Flow rate calculated using the previous four inputs. Schedule values are limited to 0 to 1. If left blank, the schedule defaults to 1.0. This schedule is ignored during sizing. All other components which reference this design specification use the current schedule value to calculate the current outdoor air requirement. This includes AirTerminal:SingleDuct:VAV:NoReheat, AirTerminal:SingleDuct:VAV:Reheat, AirTerminal:DualDuct:VAV:OutdoorAir, ZoneHVAC:FourPipeFanCoil, and ZoneHVAC:IdealLoadsAirSystem. This schedule will also be applied by Controller:MechanicalVentilation for all System Outdoor Air Methods.")]
[JsonProperty("outdoor_air_schedule_name")]
public string OutdoorAirScheduleName { get; set; } = "";
        

[Description("This input is only used to calculate the minimum outdoor air flow rate when the f" +
    "ield System Outdoor Air Method = ProportionalControlBasedOnDesignOARate in Contr" +
    "oller:MechanicalVentilation.")]
[JsonProperty("proportional_control_minimum_outdoor_air_flow_rate_schedule_name")]
public string ProportionalControlMinimumOutdoorAirFlowRateScheduleName { get; set; } = "";
    }
}
