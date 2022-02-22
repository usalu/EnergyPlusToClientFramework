namespace BH.oM.Adapters.EnergyPlus.Daylighting
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
    
    
    [Description("Dimming of overhead electric lighting is determined from each reference point. Gl" +
        "are from daylighting is also calculated.")]
    [JsonObject("Daylighting:Controls")]
    public class Daylighting_Controls : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[JsonProperty("daylighting_method")]
public Daylighting_Controls_DaylightingMethod DaylightingMethod { get; set; } = (Daylighting_Controls_DaylightingMethod)Enum.Parse(typeof(Daylighting_Controls_DaylightingMethod), "SplitFlux");
        

[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("lighting_control_type")]
public Daylighting_Controls_LightingControlType LightingControlType { get; set; } = (Daylighting_Controls_LightingControlType)Enum.Parse(typeof(Daylighting_Controls_LightingControlType), "Continuous");
        

[JsonProperty("minimum_input_power_fraction_for_continuous_or_continuousoff_dimming_control")]
public System.Nullable<float> MinimumInputPowerFractionForContinuousOrContinuousoffDimmingControl { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_light_output_fraction_for_continuous_or_continuousoff_dimming_control")]
public System.Nullable<float> MinimumLightOutputFractionForContinuousOrContinuousoffDimmingControl { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("The number of steps, excluding off, in a stepped lighting control system. If Ligh" +
    "ting Control Type is Stepped, this field must be greater than zero. The steps ar" +
    "e assumed to be equally spaced.")]
[JsonProperty("number_of_stepped_control_steps")]
public System.Nullable<float> NumberOfSteppedControlSteps { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("probability_lighting_will_be_reset_when_needed_in_manual_stepped_control")]
public System.Nullable<float> ProbabilityLightingWillBeResetWhenNeededInManualSteppedControl { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("glare_calculation_daylighting_reference_point_name")]
public string GlareCalculationDaylightingReferencePointName { get; set; } = "";
        

[JsonProperty("glare_calculation_azimuth_angle_of_view_direction_clockwise_from_zone_y_axis")]
public System.Nullable<float> GlareCalculationAzimuthAngleOfViewDirectionClockwiseFromZoneYAxis { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The default is for general office work")]
[JsonProperty("maximum_allowable_discomfort_glare_index")]
public System.Nullable<float> MaximumAllowableDiscomfortGlareIndex { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description(@"Maximum surface area for nodes in gridding all surfaces in the DElight zone. All reflective and transmitting surfaces will be subdivided into approximately square nodes that do not exceed this maximum. Higher resolution subdivisions require greater calculation times, but generally produce more accurate results.")]
[JsonProperty("delight_gridding_resolution")]
public System.Nullable<float> DelightGriddingResolution { get; set; } = null;
        

[JsonProperty("control_data")]
public string ControlData { get; set; } = "";
    }
}
