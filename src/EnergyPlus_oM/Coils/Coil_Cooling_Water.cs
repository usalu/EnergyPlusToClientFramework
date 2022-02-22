namespace BH.oM.Adapters.EnergyPlus.Coils
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
    using Newtonsoft.Json;
    using BH.oM.Base;
    using BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts;
    using BH.oM.Adapters.EnergyPlus.AirDistribution;
    using BH.oM.Adapters.EnergyPlus.AirflowNetwork;
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
    
    
    [Description("Chilled water cooling coil, NTU-effectiveness model, with inputs for design enter" +
        "ing and leaving conditions.")]
    [JsonObject("Coil:Cooling:Water")]
    public class Coil_Cooling_Water : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("design_water_flow_rate")]
public string DesignWaterFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_air_flow_rate")]
public string DesignAirFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_inlet_water_temperature")]
public string DesignInletWaterTemperature { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_inlet_air_temperature")]
public string DesignInletAirTemperature { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_outlet_air_temperature")]
public string DesignOutletAirTemperature { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_inlet_air_humidity_ratio")]
public string DesignInletAirHumidityRatio { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_outlet_air_humidity_ratio")]
public string DesignOutletAirHumidityRatio { get; set; } = (System.String)"Autosize";
        

[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("type_of_analysis")]
public Coil_Cooling_Water_TypeOfAnalysis TypeOfAnalysis { get; set; } = (Coil_Cooling_Water_TypeOfAnalysis)Enum.Parse(typeof(Coil_Cooling_Water_TypeOfAnalysis), "SimpleAnalysis");
        

[JsonProperty("heat_exchanger_configuration")]
public Coil_Cooling_Water_HeatExchangerConfiguration HeatExchangerConfiguration { get; set; } = (Coil_Cooling_Water_HeatExchangerConfiguration)Enum.Parse(typeof(Coil_Cooling_Water_HeatExchangerConfiguration), "CounterFlow");
        

[JsonProperty("condensate_collection_water_storage_tank_name")]
public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

[Description("This input field is optional. If specified, it is used for sizing the Design Wate" +
    "r Flow Rate. If blank or omitted, the Loop Design Temperature Difference value s" +
    "pecified in Sizing:Plant object is used for sizing the Design Water Flow Rate.")]
[JsonProperty("design_water_temperature_difference")]
public System.Nullable<float> DesignWaterTemperatureDifference { get; set; } = null;
    }
}
