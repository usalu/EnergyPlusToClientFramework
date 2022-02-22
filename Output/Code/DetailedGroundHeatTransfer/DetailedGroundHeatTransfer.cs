namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
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
    
    
    [Description("Object determines if the Slab and Basement preprocessors are going to be executed" +
        ".")]
    public class GroundHeatTransfer_Control : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("run_basement_preprocessor")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes RunBasementPreprocessor { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("run_slab_preprocessor")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes RunSlabPreprocessor { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
    
    [Description("Object gives an overall description of the slab ground heat transfer model.")]
    public class GroundHeatTransfer_Slab_Materials : BHoMObject, IEnergyPlusClass
    {
        

[Description("This field specifies the number of different materials that will be used in the m" +
    "odel. Typically only a ground material and a slab material are used. (2 material" +
    "s)")]
[JsonProperty("nmat_number_of_materials")]
public System.Nullable<float> NmatNumberOfMaterials { get; set; } = null;
        

[Description(@"Two fields specify the albedo value of the surface: first for no snow coverage days; second for days with snow coverage. The albedo is the solar reflectivity of the surface, and can vary from 0.05 for blacktop to 0.95 for fresh snow. Typical values for North America reported by Bahnfleth range from 0.16 to 0.4.")]
[JsonProperty("albedo_surface_albedo_no_snow")]
public System.Nullable<float> AlbedoSurfaceAlbedoNoSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.16", CultureInfo.InvariantCulture);
        

[JsonProperty("albedo_surface_albedo_snow")]
public System.Nullable<float> AlbedoSurfaceAlbedoSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

[Description("EPSLW (No Snow and Snow) specifies the long wavelength (thermal) emissivity of th" +
    "e ground surface. primarily important for nighttime radiation to sky. typical va" +
    "lue .95")]
[JsonProperty("epslw_surface_emissivity_no_snow")]
public System.Nullable<float> EpslwSurfaceEmissivityNoSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.94", CultureInfo.InvariantCulture);
        

[JsonProperty("epslw_surface_emissivity_snow")]
public System.Nullable<float> EpslwSurfaceEmissivitySnow { get; set; } = (System.Nullable<float>)Single.Parse("0.86", CultureInfo.InvariantCulture);
        

[Description("fields Z0 (No Snow and Snow) describe the height at which an experimentally veloc" +
    "ity profile goes to zero. typical value= .75 cm")]
[JsonProperty("z0_surface_roughness_no_snow")]
public System.Nullable<float> Z0SurfaceRoughnessNoSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.75", CultureInfo.InvariantCulture);
        

[Description("typical value= .05 cm")]
[JsonProperty("z0_surface_roughness_snow")]
public System.Nullable<float> Z0SurfaceRoughnessSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

[Description(@"These fields specify the combined convective and radiative heat transfer coefficient between the slab top inside surface and the room air for the cases where heat is flowing downward, and upward. The program toggles between the two if the direction of the heat flux changes. Typical values can be found in the ASHRAE Handbook of Fundamentals, but should be about 6 W/(m2-K) for downward heat flow and 9 W/(m2-K) for upward heat flow. typical value= 4-10")]
[JsonProperty("hin_indoor_hconv_downward_flow")]
public System.Nullable<float> HinIndoorHconvDownwardFlow { get; set; } = (System.Nullable<float>)Single.Parse("6.13", CultureInfo.InvariantCulture);
        

[Description("typical value= 4-10")]
[JsonProperty("hin_indoor_hconv_upward")]
public System.Nullable<float> HinIndoorHconvUpward { get; set; } = (System.Nullable<float>)Single.Parse("9.26", CultureInfo.InvariantCulture);
    }
    
    [Description("This object contains the material properties for the materials used in the model." +
        " The fields are mostly self explanatory.")]
    public class GroundHeatTransfer_Slab_MatlProps : BHoMObject, IEnergyPlusClass
    {
        

[Description("Density of Slab Material typical value= 2300.0")]
[JsonProperty("rho_slab_material_density")]
public System.Nullable<float> RhoSlabMaterialDensity { get; set; } = (System.Nullable<float>)Single.Parse("2300", CultureInfo.InvariantCulture);
        

[Description("Density of Soil Material typical value= 1200.0")]
[JsonProperty("rho_soil_density")]
public System.Nullable<float> RhoSoilDensity { get; set; } = (System.Nullable<float>)Single.Parse("1200", CultureInfo.InvariantCulture);
        

[Description("Specific Heat of Slab Material typical value=650.0")]
[JsonProperty("cp_slab_cp")]
public System.Nullable<float> CpSlabCp { get; set; } = (System.Nullable<float>)Single.Parse("650", CultureInfo.InvariantCulture);
        

[Description("Specific Heat of Soil Material typical value= 1200.0")]
[JsonProperty("cp_soil_cp")]
public System.Nullable<float> CpSoilCp { get; set; } = (System.Nullable<float>)Single.Parse("1200", CultureInfo.InvariantCulture);
        

[Description("Conductivity of Slab Material typical value= .9")]
[JsonProperty("tcon_slab_k")]
public System.Nullable<float> TconSlabK { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Conductivity of Soil Material typical value= 1.0")]
[JsonProperty("tcon_soil_k")]
public System.Nullable<float> TconSoilK { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    [Description("Supplies some of the boundary conditions used in the ground heat transfer calcula" +
        "tions.")]
    public class GroundHeatTransfer_Slab_BoundConds : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"This field specifies whether or not to use the evapotransporation model. The inclusion of evapotransporation in the calculation has the greatest effect in warm dry climates, primarily on the ground surface temperature. This field can be used to turn the evapotransporation off and on to check sensitivity to it.")]
[JsonProperty("evtr_is_surface_evapotranspiration_modeled")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GroundHeatTransfer_Slab_BoundConds_EvtrIsSurfaceEvapotranspirationModeled EvtrIsSurfaceEvapotranspirationModeled { get; set; } = (GroundHeatTransfer_Slab_BoundConds_EvtrIsSurfaceEvapotranspirationModeled)Enum.Parse(typeof(GroundHeatTransfer_Slab_BoundConds_EvtrIsSurfaceEvapotranspirationModeled), "FALSE");
        

[Description("This field permits using a fixed temperature at the lower surface of the model in" +
    "stead of a zero heat flux condition. This change normally has a very small effec" +
    "t on the results. FALSE selects the zero flux lower boundary condition")]
[JsonProperty("fixbc_is_the_lower_boundary_at_a_fixed_temperature")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GroundHeatTransfer_Slab_BoundConds_FixbcIsTheLowerBoundaryAtAFixedTemperature FixbcIsTheLowerBoundaryAtAFixedTemperature { get; set; } = (GroundHeatTransfer_Slab_BoundConds_FixbcIsTheLowerBoundaryAtAFixedTemperature)Enum.Parse(typeof(GroundHeatTransfer_Slab_BoundConds_FixbcIsTheLowerBoundaryAtAFixedTemperature), "FALSE");
        

[Description("User input lower boundary temperature if FIXBC is TRUE Blank for FIXBC FALSE or t" +
    "o use the calculated 1-D deep ground temperature.")]
[JsonProperty("tdeepin")]
public System.Nullable<float> Tdeepin { get; set; } = null;
        

[Description(@"This field flags the use of a user specified heat transfer coefficient on the ground surface. This condition is used primarily for testing. For normal runs (USPHflag is FALSE) and the program calculates the heat transfer coefficient using the weather conditions.")]
[JsonProperty("usrhflag_is_the_ground_surface_h_specified_by_the_user_")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GroundHeatTransfer_Slab_BoundConds_UsrhflagIsTheGroundSurfaceHSpecifiedByTheUser UsrhflagIsTheGroundSurfaceHSpecifiedByTheUser { get; set; } = (GroundHeatTransfer_Slab_BoundConds_UsrhflagIsTheGroundSurfaceHSpecifiedByTheUser)Enum.Parse(typeof(GroundHeatTransfer_Slab_BoundConds_UsrhflagIsTheGroundSurfaceHSpecifiedByTheUser), "FALSE");
        

[Description("Used only if USRHflag is TRUE and the heat transfer coefficient value is specifie" +
    "d in this field.")]
[JsonProperty("userh_user_specified_ground_surface_heat_transfer_coefficient")]
public System.Nullable<float> UserhUserSpecifiedGroundSurfaceHeatTransferCoefficient { get; set; } = null;
    }
    
    public enum GroundHeatTransfer_Slab_BoundConds_EvtrIsSurfaceEvapotranspirationModeled
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FALSE")]
        FALSE = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="TRUE")]
        TRUE = 1,
    }
    
    public enum GroundHeatTransfer_Slab_BoundConds_FixbcIsTheLowerBoundaryAtAFixedTemperature
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FALSE")]
        FALSE = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="TRUE")]
        TRUE = 1,
    }
    
    public enum GroundHeatTransfer_Slab_BoundConds_UsrhflagIsTheGroundSurfaceHSpecifiedByTheUser
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FALSE")]
        FALSE = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="TRUE")]
        TRUE = 1,
    }
    
    [Description(@"Object provides information about the building and its operating conditions Monthly Average Temperature SetPoint fields specify the average indoor building set point temperatures for each month of the year. These fields are useful for simulating a building that is not temperature controlled for some of the year. In such a case, the average indoor set point temperatures can be obtained by first running the model in EnergyPlus with an insulated floor boundary condition, and then using the resulting monthly average zone temperatures in these fields.")]
    public class GroundHeatTransfer_Slab_BldgProps : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"This field specifies the number of years to iterate. Either the ground heat transfer calculations come to an an annual steady periodic condition by converging to a tolerance (see ConvTol field) or it runs for this number of years. A ten year maximum is usually sufficient.")]
[JsonProperty("iyrs_number_of_years_to_iterate")]
public System.Nullable<float> IyrsNumberOfYearsToIterate { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("Use only the value 0 here. Only a rectangular shape is implemented.")]
[JsonProperty("shape_slab_shape")]
public System.Nullable<float> ShapeSlabShape { get; set; } = null;
        

[Description("This field supplies the building height. This is used to calculate the building s" +
    "hadowing on the ground. typical value= 0-20")]
[JsonProperty("hbldg_building_height")]
public System.Nullable<float> HbldgBuildingHeight { get; set; } = null;
        

[Description("see memo on object for more information")]
[JsonProperty("tin1_january_indoor_average_temperature_setpoint")]
public System.Nullable<float> Tin1JanuaryIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description("see memo on object for more information")]
[JsonProperty("tin2_february_indoor_average_temperature_setpoint")]
public System.Nullable<float> Tin2FebruaryIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description("see memo on object for more information")]
[JsonProperty("tin3_march_indoor_average_temperature_setpoint")]
public System.Nullable<float> Tin3MarchIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description("see memo on object for more information")]
[JsonProperty("tin4_april_indoor_average_temperature_setpoint")]
public System.Nullable<float> Tin4AprilIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description("see memo on object for more information")]
[JsonProperty("tin5_may_indoor_average_temperature_setpoint")]
public System.Nullable<float> Tin5MayIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description("see memo on object for more information")]
[JsonProperty("tin6_june_indoor_average_temperature_setpoint")]
public System.Nullable<float> Tin6JuneIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description("see memo on object for more information")]
[JsonProperty("tin7_july_indoor_average_temperature_setpoint")]
public System.Nullable<float> Tin7JulyIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description("see memo on object for more information")]
[JsonProperty("tin8_august_indoor_average_temperature_setpoint")]
public System.Nullable<float> Tin8AugustIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description("see memo on object for more information")]
[JsonProperty("tin9_september_indoor_average_temperature_setpoint")]
public System.Nullable<float> Tin9SeptemberIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description("see memo on object for more information")]
[JsonProperty("tin10_october_indoor_average_temperature_setpoint")]
public System.Nullable<float> Tin10OctoberIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description("see memo on object for more information")]
[JsonProperty("tin11_november_indoor_average_temperature_setpoint")]
public System.Nullable<float> Tin11NovemberIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description("see memo on object for more information")]
[JsonProperty("tin12_december_indoor_average_temperature_setpoint")]
public System.Nullable<float> Tin12DecemberIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description("This field permits imposing a daily sinusoidal variation in the indoor setpoint t" +
    "emperature to simulate the effect of a setback profile. The value specified is t" +
    "he amplitude of the sine wave.")]
[JsonProperty("tinamp_daily_indoor_sine_wave_variation_amplitude")]
public System.Nullable<float> TinampDailyIndoorSineWaveVariationAmplitude { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field specifies the convergence tolerance used to control the iteration. Whe" +
    "n the temperature change of all nodes is less than the convergence value, iterat" +
    "ion ceases.")]
[JsonProperty("convtol_convergence_tolerance")]
public System.Nullable<float> ConvtolConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
    }
    
    [Description("This object supplies the information about insulation used around the slab. There" +
        " are two possible configurations: under the slab or vertical insulation around t" +
        "he slab.")]
    public class GroundHeatTransfer_Slab_Insulation : BHoMObject, IEnergyPlusClass
    {
        

[Description("This field provides the thermal resistance value of the under slab insulation. It" +
    " should be zero if the vertical insulation configuration is selected. typical va" +
    "lue= 0-2.0")]
[JsonProperty("rins_r_value_of_under_slab_insulation")]
public System.Nullable<float> RinsRValueOfUnderSlabInsulation { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This specifies the width of the perimeter strip of insulation under the slab. It " +
    "should be zero if for the vertical insulation configuration is selected. typical" +
    " value= 0-2.0")]
[JsonProperty("dins_width_of_strip_of_under_slab_insulation")]
public System.Nullable<float> DinsWidthOfStripOfUnderSlabInsulation { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field specifies the thermal resistance of the vertical insulation. It should" +
    " be zero if the under slab insulation configuration is selected. typical value= " +
    "0-3.0")]
[JsonProperty("rvins_r_value_of_vertical_insulation")]
public System.Nullable<float> RvinsRValueOfVerticalInsulation { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"This field specifies the depth of the vertical insulation into the ground in meters. It starts at the slab upper surface and extends into the ground. It should be zero if the under slab insulation configuration is selected. only use values= .2 .4 .6 .8 1.0 1.5 2.0 2.5 3.0")]
[JsonProperty("zvins_depth_of_vertical_insulation")]
public System.Nullable<float> ZvinsDepthOfVerticalInsulation { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Specifies if the vertical insulation configuration is being used. values: 1=yes v" +
    "ertical insulation 0=no under-slab insulation")]
[JsonProperty("ivins_flag_is_there_vertical_insulation")]
public string IvinsFlagIsThereVerticalInsulation { get; set; } = (System.String)"0";
    }
    
    [Description("Using an equivalent slab allows non-rectangular shapes to be modeled accurately. " +
        "Object uses the area - perimeter (area/perimeter) ratio to determine the size of" +
        " an equivalent rectangular slab. EnergyPlus users normally use this option.")]
    public class GroundHeatTransfer_Slab_EquivalentSlab : BHoMObject, IEnergyPlusClass
    {
        

[Description("Equivalent square slab is simulated,  side is 4*APRatio.")]
[JsonProperty("apratio_the_area_to_perimeter_ratio_for_this_slab")]
public System.Nullable<float> ApratioTheAreaToPerimeterRatioForThisSlab { get; set; } = null;
        

[Description(@"This field specifies the thickness of the slab. The slab top surface is level with the ground surface, so this is the depth into the ground. The slab depth has a significant effect on the temperature calculation, and it is also important for the auto-grid process. The finite difference grids are set in such a way that they use the slab thickness to determine the vertical grid spacing. Autogridding will fail if the slab thickness is specified larger than 0.25 meters.")]
[JsonProperty("slabdepth_thickness_of_slab_on_grade")]
public System.Nullable<float> SlabdepthThicknessOfSlabOnGrade { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("This field specifies the distance from the slab to the edge of the area that will" +
    " be modeled with the grid system. It is the basic size dimension that is used to" +
    " set the horizontal extent of the domain. 15 meters is a reasonable value.")]
[JsonProperty("clearance_distance_from_edge_of_slab_to_domain_edge")]
public System.Nullable<float> ClearanceDistanceFromEdgeOfSlabToDomainEdge { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

[Description("This field specifies the vertical distance from the slab to the bottom edge of th" +
    "e area that will be modeled with the grid system. 15 meters is a reasonable valu" +
    "e.")]
[JsonProperty("zclearance_distance_from_bottom_of_slab_to_domain_bottom")]
public System.Nullable<float> ZclearanceDistanceFromBottomOfSlabToDomainBottom { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
    }
    
    [Description("AutoGrid only necessary when EquivalentSlab option not chosen. Not normally neede" +
        "d by EnergyPlus users. This object permits user selection of rectangular slab di" +
        "mensions. NO SLAB DIMENSIONS LESS THAN 6 m.")]
    public class GroundHeatTransfer_Slab_AutoGrid : BHoMObject, IEnergyPlusClass
    {
        

[Description("typical values= 6 to 60.0")]
[JsonProperty("slabx_x_dimension_of_the_building_slab")]
public System.Nullable<float> SlabxXDimensionOfTheBuildingSlab { get; set; } = null;
        

[Description("typical values= 6 to 60.0")]
[JsonProperty("slaby_y_dimension_of_the_building_slab")]
public System.Nullable<float> SlabyYDimensionOfTheBuildingSlab { get; set; } = null;
        

[JsonProperty("slabdepth_thickness_of_slab_on_grade")]
public System.Nullable<float> SlabdepthThicknessOfSlabOnGrade { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[JsonProperty("clearance_distance_from_edge_of_slab_to_domain_edge")]
public System.Nullable<float> ClearanceDistanceFromEdgeOfSlabToDomainEdge { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

[JsonProperty("zclearance_distance_from_bottom_of_slab_to_domain_bottom")]
public System.Nullable<float> ZclearanceDistanceFromBottomOfSlabToDomainBottom { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
    }
    
    [Description("Manual Grid only necessary when using manual gridding (not recommended) Used only" +
        " in special cases when previous two objects are not used. User must input comple" +
        "te gridding information.")]
    public class GroundHeatTransfer_Slab_ManualGrid : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("nx_number_of_cells_in_the_x_direction")]
public System.Nullable<float> NxNumberOfCellsInTheXDirection { get; set; } = null;
        

[JsonProperty("ny_number_of_cells_in_the_y_direction")]
public System.Nullable<float> NyNumberOfCellsInTheYDirection { get; set; } = null;
        

[JsonProperty("nz_number_of_cells_in_the_z_direction")]
public System.Nullable<float> NzNumberOfCellsInTheZDirection { get; set; } = null;
        

[Description("typical values= 1-10")]
[JsonProperty("ibox_x_direction_cell_indicator_of_slab_edge")]
public System.Nullable<float> IboxXDirectionCellIndicatorOfSlabEdge { get; set; } = null;
        

[Description("typical values= 1-10")]
[JsonProperty("jbox_y_direction_cell_indicator_of_slab_edge")]
public System.Nullable<float> JboxYDirectionCellIndicatorOfSlabEdge { get; set; } = null;
    }
    
    [Description("This is only needed when using manual gridding (not recommended) XFACE: X Directi" +
        "on cell face coordinates: m")]
    public class GroundHeatTransfer_Slab_XFACE : BHoMObject, IEnergyPlusClass
    {
    }
    
    [Description("This is only needed when using manual gridding (not recommended) YFACE: Y Directi" +
        "on cell face coordinates: m,")]
    public class GroundHeatTransfer_Slab_YFACE : BHoMObject, IEnergyPlusClass
    {
    }
    
    [Description("This is only needed when using manual gridding (not recommended) ZFACE: Z Directi" +
        "on cell face coordinates: m")]
    public class GroundHeatTransfer_Slab_ZFACE : BHoMObject, IEnergyPlusClass
    {
    }
    
    [Description("Specifies certain parameters that control the Basement preprocessor ground heat t" +
        "ransfer simulation.")]
    public class GroundHeatTransfer_Basement_SimParameters : BHoMObject, IEnergyPlusClass
    {
        

[Description("0<F<1.0, typically 0.1 (0.3 for high k soil - saturated sand is about 2.6 w/m-K)")]
[JsonProperty("f_multiplier_for_the_adi_solution")]
public System.Nullable<float> FMultiplierForTheAdiSolution { get; set; } = null;
        

[Description("typically 15-30]")]
[JsonProperty("iyrs_maximum_number_of_yearly_iterations_")]
public System.Nullable<float> IyrsMaximumNumberOfYearlyIterations { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
    }
    
    [Description("Specifies the material properties for the Basement preprocessor ground heat trans" +
        "fer simulation. Only the Foundation Wall, Floor Slab, Soil, and Gravel propertie" +
        "s are currently used.")]
    public class GroundHeatTransfer_Basement_MatlProps : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("nmat_number_of_materials_in_this_domain")]
public System.Nullable<float> NmatNumberOfMaterialsInThisDomain { get; set; } = null;
        

[JsonProperty("density_for_foundation_wall")]
public System.Nullable<float> DensityForFoundationWall { get; set; } = (System.Nullable<float>)Single.Parse("2243", CultureInfo.InvariantCulture);
        

[JsonProperty("density_for_floor_slab")]
public System.Nullable<float> DensityForFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("2243", CultureInfo.InvariantCulture);
        

[JsonProperty("density_for_ceiling")]
public System.Nullable<float> DensityForCeiling { get; set; } = (System.Nullable<float>)Single.Parse("311", CultureInfo.InvariantCulture);
        

[JsonProperty("density_for_soil")]
public System.Nullable<float> DensityForSoil { get; set; } = (System.Nullable<float>)Single.Parse("1500", CultureInfo.InvariantCulture);
        

[JsonProperty("density_for_gravel")]
public System.Nullable<float> DensityForGravel { get; set; } = (System.Nullable<float>)Single.Parse("2000", CultureInfo.InvariantCulture);
        

[JsonProperty("density_for_wood")]
public System.Nullable<float> DensityForWood { get; set; } = (System.Nullable<float>)Single.Parse("449", CultureInfo.InvariantCulture);
        

[JsonProperty("specific_heat_for_foundation_wall")]
public System.Nullable<float> SpecificHeatForFoundationWall { get; set; } = (System.Nullable<float>)Single.Parse("880", CultureInfo.InvariantCulture);
        

[JsonProperty("specific_heat_for_floor_slab")]
public System.Nullable<float> SpecificHeatForFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("880", CultureInfo.InvariantCulture);
        

[JsonProperty("specific_heat_for_ceiling")]
public System.Nullable<float> SpecificHeatForCeiling { get; set; } = (System.Nullable<float>)Single.Parse("1530", CultureInfo.InvariantCulture);
        

[JsonProperty("specific_heat_for_soil")]
public System.Nullable<float> SpecificHeatForSoil { get; set; } = (System.Nullable<float>)Single.Parse("840", CultureInfo.InvariantCulture);
        

[JsonProperty("specific_heat_for_gravel")]
public System.Nullable<float> SpecificHeatForGravel { get; set; } = (System.Nullable<float>)Single.Parse("720", CultureInfo.InvariantCulture);
        

[JsonProperty("specific_heat_for_wood")]
public System.Nullable<float> SpecificHeatForWood { get; set; } = (System.Nullable<float>)Single.Parse("1530", CultureInfo.InvariantCulture);
        

[JsonProperty("thermal_conductivity_for_foundation_wall")]
public System.Nullable<float> ThermalConductivityForFoundationWall { get; set; } = (System.Nullable<float>)Single.Parse("1.4", CultureInfo.InvariantCulture);
        

[JsonProperty("thermal_conductivity_for_floor_slab")]
public System.Nullable<float> ThermalConductivityForFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("1.4", CultureInfo.InvariantCulture);
        

[JsonProperty("thermal_conductivity_for_ceiling")]
public System.Nullable<float> ThermalConductivityForCeiling { get; set; } = (System.Nullable<float>)Single.Parse("0.09", CultureInfo.InvariantCulture);
        

[JsonProperty("thermal_conductivity_for_soil")]
public System.Nullable<float> ThermalConductivityForSoil { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

[JsonProperty("thermal_conductivity_for_gravel")]
public System.Nullable<float> ThermalConductivityForGravel { get; set; } = (System.Nullable<float>)Single.Parse("1.9", CultureInfo.InvariantCulture);
        

[JsonProperty("thermal_conductivity_for_wood")]
public System.Nullable<float> ThermalConductivityForWood { get; set; } = (System.Nullable<float>)Single.Parse("0.12", CultureInfo.InvariantCulture);
    }
    
    [Description("Describes the insulation used on an exterior basement wall for the Basement prepr" +
        "ocessor ground heat transfer simulation.")]
    public class GroundHeatTransfer_Basement_Insulation : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("rext_r_value_of_any_exterior_insulation")]
public System.Nullable<float> RextRValueOfAnyExteriorInsulation { get; set; } = null;
        

[Description("True for full insulation False for insulation half way down side wall from grade " +
    "line")]
[JsonProperty("insfull_flag_is_the_wall_fully_insulated_")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GroundHeatTransfer_Basement_Insulation_InsfullFlagIsTheWallFullyInsulated InsfullFlagIsTheWallFullyInsulated { get; set; } = (GroundHeatTransfer_Basement_Insulation_InsfullFlagIsTheWallFullyInsulated)Enum.Parse(typeof(GroundHeatTransfer_Basement_Insulation_InsfullFlagIsTheWallFullyInsulated), "FALSE");
    }
    
    public enum GroundHeatTransfer_Basement_Insulation_InsfullFlagIsTheWallFullyInsulated
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FALSE")]
        FALSE = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="TRUE")]
        TRUE = 1,
    }
    
    [Description("Specifies the soil surface properties for the Basement preprocessor ground heat t" +
        "ransfer simulation.")]
    public class GroundHeatTransfer_Basement_SurfaceProps : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("albedo_surface_albedo_for_no_snow_conditions")]
public System.Nullable<float> AlbedoSurfaceAlbedoForNoSnowConditions { get; set; } = (System.Nullable<float>)Single.Parse("0.16", CultureInfo.InvariantCulture);
        

[JsonProperty("albedo_surface_albedo_for_snow_conditions")]
public System.Nullable<float> AlbedoSurfaceAlbedoForSnowConditions { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

[JsonProperty("epsln_surface_emissivity_no_snow")]
public System.Nullable<float> EpslnSurfaceEmissivityNoSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.94", CultureInfo.InvariantCulture);
        

[JsonProperty("epsln_surface_emissivity_with_snow")]
public System.Nullable<float> EpslnSurfaceEmissivityWithSnow { get; set; } = (System.Nullable<float>)Single.Parse("0.86", CultureInfo.InvariantCulture);
        

[JsonProperty("veght_surface_roughness_no_snow_conditions")]
public System.Nullable<float> VeghtSurfaceRoughnessNoSnowConditions { get; set; } = (System.Nullable<float>)Single.Parse("6", CultureInfo.InvariantCulture);
        

[JsonProperty("veght_surface_roughness_snow_conditions")]
public System.Nullable<float> VeghtSurfaceRoughnessSnowConditions { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

[Description("Typically, PET is False")]
[JsonProperty("pet_flag_potential_evapotranspiration_on_")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GroundHeatTransfer_Basement_SurfaceProps_PetFlagPotentialEvapotranspirationOn PetFlagPotentialEvapotranspirationOn { get; set; } = (GroundHeatTransfer_Basement_SurfaceProps_PetFlagPotentialEvapotranspirationOn)Enum.Parse(typeof(GroundHeatTransfer_Basement_SurfaceProps_PetFlagPotentialEvapotranspirationOn), "FALSE");
    }
    
    public enum GroundHeatTransfer_Basement_SurfaceProps_PetFlagPotentialEvapotranspirationOn
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FALSE")]
        FALSE = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="TRUE")]
        TRUE = 2,
    }
    
    [Description("Specifies the surface and gravel thicknesses used for the Basement preprocessor g" +
        "round heat transfer simulation.")]
    public class GroundHeatTransfer_Basement_BldgData : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("dwall_wall_thickness")]
public System.Nullable<float> DwallWallThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("dslab_floor_slab_thickness")]
public System.Nullable<float> DslabFloorSlabThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[JsonProperty("dgravxy_width_of_gravel_pit_beside_basement_wall")]
public System.Nullable<float> DgravxyWidthOfGravelPitBesideBasementWall { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

[JsonProperty("dgravzn_gravel_depth_extending_above_the_floor_slab")]
public System.Nullable<float> DgravznGravelDepthExtendingAboveTheFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("dgravzp_gravel_depth_below_the_floor_slab")]
public System.Nullable<float> DgravzpGravelDepthBelowTheFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
    }
    
    [Description("Provides the information needed to simulate the inside boundary conditions for th" +
        "e Basement preprocessor ground heat transfer simulation.")]
    public class GroundHeatTransfer_Basement_Interior : BHoMObject, IEnergyPlusClass
    {
        

[Description("for EnergyPlus this should be TRUE")]
[JsonProperty("cond_flag_is_the_basement_conditioned_")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GroundHeatTransfer_Basement_Interior_CondFlagIsTheBasementConditioned CondFlagIsTheBasementConditioned { get; set; } = (GroundHeatTransfer_Basement_Interior_CondFlagIsTheBasementConditioned)Enum.Parse(typeof(GroundHeatTransfer_Basement_Interior_CondFlagIsTheBasementConditioned), "TRUE");
        

[JsonProperty("hin_downward_convection_only_heat_transfer_coefficient")]
public System.Nullable<float> HinDownwardConvectionOnlyHeatTransferCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0.92", CultureInfo.InvariantCulture);
        

[JsonProperty("hin_upward_convection_only_heat_transfer_coefficient")]
public System.Nullable<float> HinUpwardConvectionOnlyHeatTransferCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("4.04", CultureInfo.InvariantCulture);
        

[JsonProperty("hin_horizontal_convection_only_heat_transfer_coefficient")]
public System.Nullable<float> HinHorizontalConvectionOnlyHeatTransferCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("3.08", CultureInfo.InvariantCulture);
        

[JsonProperty("hin_downward_combined_convection_and_radiation_heat_transfer_coefficient")]
public System.Nullable<float> HinDownwardCombinedConvectionAndRadiationHeatTransferCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("6.13", CultureInfo.InvariantCulture);
        

[JsonProperty("hin_upward_combined_convection_and_radiation_heat_transfer_coefficient")]
public System.Nullable<float> HinUpwardCombinedConvectionAndRadiationHeatTransferCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("9.26", CultureInfo.InvariantCulture);
        

[JsonProperty("hin_horizontal_combined_convection_and_radiation_heat_transfer_coefficient")]
public System.Nullable<float> HinHorizontalCombinedConvectionAndRadiationHeatTransferCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("8.29", CultureInfo.InvariantCulture);
    }
    
    public enum GroundHeatTransfer_Basement_Interior_CondFlagIsTheBasementConditioned
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FALSE")]
        FALSE = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="TRUE")]
        TRUE = 2,
    }
    
    [Description("ComBldg contains the monthly average temperatures (C) and possibility of daily va" +
        "riation amplitude")]
    public class GroundHeatTransfer_Basement_ComBldg : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("january_average_temperature")]
public System.Nullable<float> JanuaryAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[JsonProperty("february_average_temperature")]
public System.Nullable<float> FebruaryAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[JsonProperty("march_average_temperature")]
public System.Nullable<float> MarchAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[JsonProperty("april_average_temperature")]
public System.Nullable<float> AprilAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[JsonProperty("may_average_temperature")]
public System.Nullable<float> MayAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[JsonProperty("june_average_temperature")]
public System.Nullable<float> JuneAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[JsonProperty("july_average_temperature")]
public System.Nullable<float> JulyAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[JsonProperty("august_average_temperature")]
public System.Nullable<float> AugustAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[JsonProperty("september_average_temperature")]
public System.Nullable<float> SeptemberAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[JsonProperty("october_average_temperature")]
public System.Nullable<float> OctoberAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[JsonProperty("november_average_temperature")]
public System.Nullable<float> NovemberAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[JsonProperty("december_average_temperature")]
public System.Nullable<float> DecemberAverageTemperature { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

[Description("(Normally zero, just for checking)")]
[JsonProperty("daily_variation_sine_wave_amplitude")]
public System.Nullable<float> DailyVariationSineWaveAmplitude { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description("Using an equivalent slab allows non-rectangular shapes to be modeled accurately. " +
        "The simulation default should be EquivSizing=True")]
    public class GroundHeatTransfer_Basement_EquivSlab : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("apratio_the_area_to_perimeter_ratio_for_this_slab")]
public System.Nullable<float> ApratioTheAreaToPerimeterRatioForThisSlab { get; set; } = null;
        

[Description("Will the dimensions of an equivalent slab be calculated (TRUE) or will the dimens" +
    "ions be input directly? (FALSE)] Only advanced special simulations should use FA" +
    "LSE.")]
[JsonProperty("equivsizing_flag")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public GroundHeatTransfer_Basement_EquivSlab_EquivsizingFlag EquivsizingFlag { get; set; } = (GroundHeatTransfer_Basement_EquivSlab_EquivsizingFlag)Enum.Parse(typeof(GroundHeatTransfer_Basement_EquivSlab_EquivsizingFlag), "FALSE");
    }
    
    public enum GroundHeatTransfer_Basement_EquivSlab_EquivsizingFlag
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FALSE")]
        FALSE = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="TRUE")]
        TRUE = 1,
    }
    
    [Description("EquivAutoGrid necessary when EquivSizing=TRUE, TRUE is is the normal case.")]
    public class GroundHeatTransfer_Basement_EquivAutoGrid : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("clearance_distance_from_outside_of_wall_to_edge_of_3_d_ground_domain")]
public System.Nullable<float> ClearanceDistanceFromOutsideOfWallToEdgeOf3DGroundDomain { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

[JsonProperty("slabdepth_thickness_of_the_floor_slab")]
public System.Nullable<float> SlabdepthThicknessOfTheFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[JsonProperty("basedepth_depth_of_the_basement_wall_below_grade")]
public System.Nullable<float> BasedepthDepthOfTheBasementWallBelowGrade { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
    
    [Description("AutoGrid only necessary when EquivSizing is false If the modeled building is not " +
        "a rectangle or square, Equivalent sizing MUST be used to get accurate results")]
    public class GroundHeatTransfer_Basement_AutoGrid : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("clearance_distance_from_outside_of_wall_to_edge_")]
public System.Nullable<float> ClearanceDistanceFromOutsideOfWallToEdge { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

[JsonProperty("slabx_x_dimension_of_the_building_slab")]
public System.Nullable<float> SlabxXDimensionOfTheBuildingSlab { get; set; } = null;
        

[JsonProperty("slaby_y_dimension_of_the_building_slab")]
public System.Nullable<float> SlabyYDimensionOfTheBuildingSlab { get; set; } = null;
        

[JsonProperty("concagheight_height_of_the_foundation_wall_above_grade")]
public System.Nullable<float> ConcagheightHeightOfTheFoundationWallAboveGrade { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("slabdepth_thickness_of_the_floor_slab")]
public System.Nullable<float> SlabdepthThicknessOfTheFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[JsonProperty("basedepth_depth_of_the_basement_wall_below_grade")]
public System.Nullable<float> BasedepthDepthOfTheBasementWallBelowGrade { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
    
    [Description("Manual Grid only necessary using manual gridding (not recommended)")]
    public class GroundHeatTransfer_Basement_ManualGrid : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("nx_number_of_cells_in_the_x_direction_20_")]
public System.Nullable<float> NxNumberOfCellsInTheXDirection20 { get; set; } = null;
        

[JsonProperty("ny_number_of_cells_in_the_y_direction_20_")]
public System.Nullable<float> NyNumberOfCellsInTheYDirection20 { get; set; } = null;
        

[JsonProperty("nzag_number_of_cells_in_the_z_direction_above_grade_4_always_")]
public System.Nullable<float> NzagNumberOfCellsInTheZDirectionAboveGrade4Always { get; set; } = null;
        

[JsonProperty("nzbg_number_of_cells_in_z_direction_below_grade_10_35_")]
public System.Nullable<float> NzbgNumberOfCellsInZDirectionBelowGrade1035 { get; set; } = null;
        

[JsonProperty("ibase_x_direction_cell_indicator_of_slab_edge_5_20_")]
public System.Nullable<float> IbaseXDirectionCellIndicatorOfSlabEdge520 { get; set; } = null;
        

[JsonProperty("jbase_y_direction_cell_indicator_of_slab_edge_5_20_")]
public System.Nullable<float> JbaseYDirectionCellIndicatorOfSlabEdge520 { get; set; } = null;
        

[JsonProperty("kbase_z_direction_cell_indicator_of_the_top_of_the_floor_slab_5_20_")]
public System.Nullable<float> KbaseZDirectionCellIndicatorOfTheTopOfTheFloorSlab520 { get; set; } = null;
    }
    
    [Description("This is only needed when using manual gridding (not recommended) XFACE: X Directi" +
        "on cell face coordinates: m")]
    public class GroundHeatTransfer_Basement_XFACE : BHoMObject, IEnergyPlusClass
    {
    }
    
    [Description("This is only needed when using manual gridding (not recommended) YFACE: Y Directi" +
        "on cell face coordinates: m")]
    public class GroundHeatTransfer_Basement_YFACE : BHoMObject, IEnergyPlusClass
    {
    }
    
    [Description("This is only needed when using manual gridding (not recommended) ZFACE: Z Directi" +
        "on cell face coordinates: m")]
    public class GroundHeatTransfer_Basement_ZFACE : BHoMObject, IEnergyPlusClass
    {
    }
}
