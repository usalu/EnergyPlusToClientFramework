namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
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
    
    
    [Description("Regular materials described with full set of thermal properties")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Material : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="roughness", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Material_Roughness Roughness { get; set; } = (Material_Roughness)Enum.Parse(typeof(Material_Roughness), "MediumRough");
        

[JsonProperty(PropertyName="thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[JsonProperty(PropertyName="conductivity")]
public System.Nullable<float> Conductivity { get; set; } = null;
        

[JsonProperty(PropertyName="density")]
public System.Nullable<float> Density { get; set; } = null;
        

[JsonProperty(PropertyName="specific_heat")]
public System.Nullable<float> SpecificHeat { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_absorptance")]
public System.Nullable<float> ThermalAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="solar_absorptance")]
public System.Nullable<float> SolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="visible_absorptance")]
public System.Nullable<float> VisibleAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
    }
    
    public enum Material_Roughness
    {
        
        [System.Runtime.Serialization.EnumMember(Value="MediumRough")]
        MediumRough = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MediumSmooth")]
        MediumSmooth = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Rough")]
        Rough = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Smooth")]
        Smooth = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="VeryRough")]
        VeryRough = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="VerySmooth")]
        VerySmooth = 5,
    }
    
    [Description("Regular materials properties described whose principal description is R (Thermal " +
        "Resistance)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Material_NoMass : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="roughness", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Material_NoMass_Roughness Roughness { get; set; } = (Material_NoMass_Roughness)Enum.Parse(typeof(Material_NoMass_Roughness), "MediumRough");
        

[JsonProperty(PropertyName="thermal_resistance")]
public System.Nullable<float> ThermalResistance { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_absorptance")]
public System.Nullable<float> ThermalAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="solar_absorptance")]
public System.Nullable<float> SolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="visible_absorptance")]
public System.Nullable<float> VisibleAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
    }
    
    public enum Material_NoMass_Roughness
    {
        
        [System.Runtime.Serialization.EnumMember(Value="MediumRough")]
        MediumRough = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MediumSmooth")]
        MediumSmooth = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Rough")]
        Rough = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Smooth")]
        Smooth = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="VeryRough")]
        VeryRough = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="VerySmooth")]
        VerySmooth = 5,
    }
    
    [Description(@"Special infrared transparent material. Similar to a Material:Nomass with low thermal resistance. High absorptance in both wavelengths. Area will be doubled internally to make internal radiant exchange accurate. Should be only material in single layer surface construction. All thermal properties are set internally. User needs only to supply name. Cannot be used with ConductionFiniteDifference solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Material_InfraredTransparent : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
    }
    
    [Description("Air Space in Opaque Construction")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Material_AirGap : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="thermal_resistance")]
public System.Nullable<float> ThermalResistance { get; set; } = null;
    }
    
    [Description(@"EcoRoof model, plant layer plus soil layer Implemented by Portland State University (Sailor et al., January, 2007) only one material must be referenced per simulation though the same EcoRoof material could be used in multiple constructions. New moisture redistribution scheme (2010) requires higher number of timesteps per hour (minimum 12 recommended).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Material_RoofVegetation : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("The ecoroof module is designed for short plants and shrubs.")]
[JsonProperty(PropertyName="height_of_plants")]
public System.Nullable<float> HeightOfPlants { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("Entire surface is assumed covered, so decrease LAI accordingly.")]
[JsonProperty(PropertyName="leaf_area_index")]
public System.Nullable<float> LeafAreaIndex { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Leaf reflectivity (albedo) is typically 0.18-0.25")]
[JsonProperty(PropertyName="leaf_reflectivity")]
public System.Nullable<float> LeafReflectivity { get; set; } = (System.Nullable<float>)Single.Parse("0.22", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="leaf_emissivity")]
public System.Nullable<float> LeafEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.95", CultureInfo.InvariantCulture);
        

[Description("This depends upon plant type")]
[JsonProperty(PropertyName="minimum_stomatal_resistance")]
public System.Nullable<float> MinimumStomatalResistance { get; set; } = (System.Nullable<float>)Single.Parse("180", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="soil_layer_name")]
public string SoilLayerName { get; set; } = (System.String)"Green Roof Soil";
        

[JsonProperty(PropertyName="roughness", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Material_RoofVegetation_Roughness Roughness { get; set; } = (Material_RoofVegetation_Roughness)Enum.Parse(typeof(Material_RoofVegetation_Roughness), "MediumRough");
        

[Description("thickness of the soil layer of the EcoRoof Soil depths of 0.15m (6in) and 0.30m (" +
    "12in) are common.")]
[JsonProperty(PropertyName="thickness")]
public System.Nullable<float> Thickness { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("Thermal conductivity of dry soil. Typical ecoroof soils range from 0.3 to 0.5")]
[JsonProperty(PropertyName="conductivity_of_dry_soil")]
public System.Nullable<float> ConductivityOfDrySoil { get; set; } = (System.Nullable<float>)Single.Parse("0.35", CultureInfo.InvariantCulture);
        

[Description("Density of dry soil (the code modifies this as the soil becomes moist) Typical ec" +
    "oroof soils range from 400 to 1000 (dry to wet)")]
[JsonProperty(PropertyName="density_of_dry_soil")]
public System.Nullable<float> DensityOfDrySoil { get; set; } = (System.Nullable<float>)Single.Parse("1100", CultureInfo.InvariantCulture);
        

[Description("Specific heat of dry soil")]
[JsonProperty(PropertyName="specific_heat_of_dry_soil")]
public System.Nullable<float> SpecificHeatOfDrySoil { get; set; } = (System.Nullable<float>)Single.Parse("1200", CultureInfo.InvariantCulture);
        

[Description("Soil emissivity is typically in range of 0.90 to 0.98")]
[JsonProperty(PropertyName="thermal_absorptance")]
public System.Nullable<float> ThermalAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Solar absorptance of dry soil (1-albedo) is typically 0.60 to 0.85 corresponding " +
    "to a dry albedo of 0.15 to 0.40")]
[JsonProperty(PropertyName="solar_absorptance")]
public System.Nullable<float> SolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="visible_absorptance")]
public System.Nullable<float> VisibleAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.75", CultureInfo.InvariantCulture);
        

[Description("Maximum moisture content is typically less than 0.5")]
[JsonProperty(PropertyName="saturation_volumetric_moisture_content_of_the_soil_layer")]
public System.Nullable<float> SaturationVolumetricMoistureContentOfTheSoilLayer { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="residual_volumetric_moisture_content_of_the_soil_layer")]
public System.Nullable<float> ResidualVolumetricMoistureContentOfTheSoilLayer { get; set; } = (System.Nullable<float>)Single.Parse("0.01", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="initial_volumetric_moisture_content_of_the_soil_layer")]
public System.Nullable<float> InitialVolumetricMoistureContentOfTheSoilLayer { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("Advanced calculation requires increased number of timesteps (recommended >20).")]
[JsonProperty(PropertyName="moisture_diffusion_calculation_method", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Material_RoofVegetation_MoistureDiffusionCalculationMethod MoistureDiffusionCalculationMethod { get; set; } = (Material_RoofVegetation_MoistureDiffusionCalculationMethod)Enum.Parse(typeof(Material_RoofVegetation_MoistureDiffusionCalculationMethod), "Advanced");
    }
    
    public enum Material_RoofVegetation_Roughness
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MediumRough")]
        MediumRough = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MediumSmooth")]
        MediumSmooth = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Rough")]
        Rough = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Smooth")]
        Smooth = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="VeryRough")]
        VeryRough = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="VerySmooth")]
        VerySmooth = 6,
    }
    
    public enum Material_RoofVegetation_MoistureDiffusionCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Advanced")]
        Advanced = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Simple")]
        Simple = 2,
    }
    
    [Description("Alternate method of describing windows This window material object is used to def" +
        "ine an entire glazing system using simple performance parameters.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_SimpleGlazingSystem : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Enter U-Factor including film coefficients Note that the effective upper limit fo" +
    "r U-factor is 5.8 W/m2-K")]
[JsonProperty(PropertyName="u_factor")]
public System.Nullable<float> UFactor { get; set; } = null;
        

[Description("SHGC at Normal Incidence")]
[JsonProperty(PropertyName="solar_heat_gain_coefficient")]
public System.Nullable<float> SolarHeatGainCoefficient { get; set; } = null;
        

[Description("VT at Normal Incidence optional")]
[JsonProperty(PropertyName="visible_transmittance")]
public System.Nullable<float> VisibleTransmittance { get; set; } = null;
    }
    
    [Description("Glass material properties for Windows or Glass Doors Transmittance/Reflectance in" +
        "put method.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Glazing : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="optical_data_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_Glazing_OpticalDataType OpticalDataType { get; set; } = (WindowMaterial_Glazing_OpticalDataType)Enum.Parse(typeof(WindowMaterial_Glazing_OpticalDataType), "BSDF");
        

[Description("Used only when Optical Data Type = Spectral")]
[JsonProperty(PropertyName="window_glass_spectral_data_set_name")]
public string WindowGlassSpectralDataSetName { get; set; } = "";
        

[JsonProperty(PropertyName="thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty(PropertyName="solar_transmittance_at_normal_incidence")]
public System.Nullable<float> SolarTransmittanceAtNormalIncidence { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
    "outdoor air")]
[JsonProperty(PropertyName="front_side_solar_reflectance_at_normal_incidence")]
public System.Nullable<float> FrontSideSolarReflectanceAtNormalIncidence { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
    "one air")]
[JsonProperty(PropertyName="back_side_solar_reflectance_at_normal_incidence")]
public System.Nullable<float> BackSideSolarReflectanceAtNormalIncidence { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty(PropertyName="visible_transmittance_at_normal_incidence")]
public System.Nullable<float> VisibleTransmittanceAtNormalIncidence { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty(PropertyName="front_side_visible_reflectance_at_normal_incidence")]
public System.Nullable<float> FrontSideVisibleReflectanceAtNormalIncidence { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty(PropertyName="back_side_visible_reflectance_at_normal_incidence")]
public System.Nullable<float> BackSideVisibleReflectanceAtNormalIncidence { get; set; } = null;
        

[JsonProperty(PropertyName="infrared_transmittance_at_normal_incidence")]
public System.Nullable<float> InfraredTransmittanceAtNormalIncidence { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="front_side_infrared_hemispherical_emissivity")]
public System.Nullable<float> FrontSideInfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="back_side_infrared_hemispherical_emissivity")]
public System.Nullable<float> BackSideInfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="conductivity")]
public System.Nullable<float> Conductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="dirt_correction_factor_for_solar_and_visible_transmittance")]
public System.Nullable<float> DirtCorrectionFactorForSolarAndVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="solar_diffusing", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes SolarDiffusing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("coefficient used for deflection calculations. Used only with complex fenestration" +
    " when deflection model is set to TemperatureAndPressureInput")]
[JsonProperty(PropertyName="young_s_modulus")]
public System.Nullable<float> YoungSModulus { get; set; } = (System.Nullable<float>)Single.Parse("72000000000", CultureInfo.InvariantCulture);
        

[Description("coefficient used for deflection calculations. Used only with complex fenestration" +
    " when deflection model is set to TemperatureAndPressureInput")]
[JsonProperty(PropertyName="poisson_s_ratio")]
public System.Nullable<float> PoissonSRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.22", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAndAngle")]
[JsonProperty(PropertyName="window_glass_spectral_and_incident_angle_transmittance_data_set_table_name")]
public string WindowGlassSpectralAndIncidentAngleTransmittanceDataSetTableName { get; set; } = "";
        

[Description("Used only when Optical Data Type = SpectralAndAngle")]
[JsonProperty(PropertyName="window_glass_spectral_and_incident_angle_front_reflectance_data_set_table_name")]
public string WindowGlassSpectralAndIncidentAngleFrontReflectanceDataSetTableName { get; set; } = "";
        

[Description("Used only when Optical Data Type = SpectralAndAngle")]
[JsonProperty(PropertyName="window_glass_spectral_and_incident_angle_back_reflectance_data_set_table_name")]
public string WindowGlassSpectralAndIncidentAngleBackReflectanceDataSetTableName { get; set; } = "";
    }
    
    public enum WindowMaterial_Glazing_OpticalDataType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="BSDF")]
        BSDF = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Spectral")]
        Spectral = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SpectralAndAngle")]
        SpectralAndAngle = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SpectralAverage")]
        SpectralAverage = 3,
    }
    
    [Description("thermochromic glass at different temperatures")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_GlazingGroup_Thermochromic : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="temperature_data")]
public string TemperatureData { get; set; } = "";
    }
    
    [Description("Glass material properties for Windows or Glass Doors Index of Refraction/Extincti" +
        "on Coefficient input method Not to be used for coated glass")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Glazing_RefractionExtinctionMethod : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[JsonProperty(PropertyName="solar_index_of_refraction")]
public System.Nullable<float> SolarIndexOfRefraction { get; set; } = null;
        

[JsonProperty(PropertyName="solar_extinction_coefficient")]
public System.Nullable<float> SolarExtinctionCoefficient { get; set; } = null;
        

[JsonProperty(PropertyName="visible_index_of_refraction")]
public System.Nullable<float> VisibleIndexOfRefraction { get; set; } = null;
        

[JsonProperty(PropertyName="visible_extinction_coefficient")]
public System.Nullable<float> VisibleExtinctionCoefficient { get; set; } = null;
        

[JsonProperty(PropertyName="infrared_transmittance_at_normal_incidence")]
public System.Nullable<float> InfraredTransmittanceAtNormalIncidence { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Emissivity of front and back side assumed equal")]
[JsonProperty(PropertyName="infrared_hemispherical_emissivity")]
public System.Nullable<float> InfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="conductivity")]
public System.Nullable<float> Conductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="dirt_correction_factor_for_solar_and_visible_transmittance")]
public System.Nullable<float> DirtCorrectionFactorForSolarAndVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="solar_diffusing", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes SolarDiffusing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
    
    [Description("Gas material properties that are used in Windows or Glass Doors")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Gas : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="gas_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_Gas_GasType GasType { get; set; } = (WindowMaterial_Gas_GasType)Enum.Parse(typeof(WindowMaterial_Gas_GasType), "Air");
        

[JsonProperty(PropertyName="thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="conductivity_coefficient_a")]
public System.Nullable<float> ConductivityCoefficientA { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="conductivity_coefficient_b")]
public System.Nullable<float> ConductivityCoefficientB { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="conductivity_coefficient_c")]
public System.Nullable<float> ConductivityCoefficientC { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="viscosity_coefficient_a")]
public System.Nullable<float> ViscosityCoefficientA { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="viscosity_coefficient_b")]
public System.Nullable<float> ViscosityCoefficientB { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="viscosity_coefficient_c")]
public System.Nullable<float> ViscosityCoefficientC { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="specific_heat_coefficient_a")]
public System.Nullable<float> SpecificHeatCoefficientA { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="specific_heat_coefficient_b")]
public System.Nullable<float> SpecificHeatCoefficientB { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="specific_heat_coefficient_c")]
public System.Nullable<float> SpecificHeatCoefficientC { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="molecular_weight")]
public System.Nullable<float> MolecularWeight { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="specific_heat_ratio")]
public System.Nullable<float> SpecificHeatRatio { get; set; } = null;
    }
    
    public enum WindowMaterial_Gas_GasType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Air")]
        Air = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Argon")]
        Argon = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Custom")]
        Custom = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Krypton")]
        Krypton = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Xenon")]
        Xenon = 4,
    }
    
    [Description("used to define pillar geometry for support pillars")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowGap_SupportPillar : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="spacing")]
public System.Nullable<float> Spacing { get; set; } = (System.Nullable<float>)Single.Parse("0.04", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="radius")]
public System.Nullable<float> Radius { get; set; } = (System.Nullable<float>)Single.Parse("0.0004", CultureInfo.InvariantCulture);
    }
    
    [Description("Used to enter data describing deflection state of the gap. It is referenced from " +
        "WindowMaterial:Gap object only and it is used only when deflection model is set " +
        "to MeasuredDeflection, otherwise it is ignored.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowGap_DeflectionState : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("If left blank will be considered that gap has no deflection.")]
[JsonProperty(PropertyName="deflected_thickness")]
public System.Nullable<float> DeflectedThickness { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="initial_temperature")]
public System.Nullable<float> InitialTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="initial_pressure")]
public System.Nullable<float> InitialPressure { get; set; } = (System.Nullable<float>)Single.Parse("101325", CultureInfo.InvariantCulture);
    }
    
    [Description("Gas mixtures that are used in Windows or Glass Doors")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_GasMixture : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[JsonProperty(PropertyName="number_of_gases_in_mixture")]
public System.Nullable<float> NumberOfGasesInMixture { get; set; } = null;
        

[JsonProperty(PropertyName="gas_1_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_GasMixture_Gas1Type Gas1Type { get; set; } = (WindowMaterial_GasMixture_Gas1Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas1Type), "Air");
        

[JsonProperty(PropertyName="gas_1_fraction")]
public System.Nullable<float> Gas1Fraction { get; set; } = null;
        

[JsonProperty(PropertyName="gas_2_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_GasMixture_Gas2Type Gas2Type { get; set; } = (WindowMaterial_GasMixture_Gas2Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas2Type), "Air");
        

[JsonProperty(PropertyName="gas_2_fraction")]
public System.Nullable<float> Gas2Fraction { get; set; } = null;
        

[JsonProperty(PropertyName="gas_3_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_GasMixture_Gas3Type Gas3Type { get; set; } = (WindowMaterial_GasMixture_Gas3Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas3Type), "Air");
        

[JsonProperty(PropertyName="gas_3_fraction")]
public System.Nullable<float> Gas3Fraction { get; set; } = null;
        

[JsonProperty(PropertyName="gas_4_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_GasMixture_Gas4Type Gas4Type { get; set; } = (WindowMaterial_GasMixture_Gas4Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas4Type), "Air");
        

[JsonProperty(PropertyName="gas_4_fraction")]
public System.Nullable<float> Gas4Fraction { get; set; } = null;
    }
    
    public enum WindowMaterial_GasMixture_Gas1Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Air")]
        Air = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Argon")]
        Argon = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Krypton")]
        Krypton = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Xenon")]
        Xenon = 3,
    }
    
    public enum WindowMaterial_GasMixture_Gas2Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Air")]
        Air = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Argon")]
        Argon = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Krypton")]
        Krypton = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Xenon")]
        Xenon = 3,
    }
    
    public enum WindowMaterial_GasMixture_Gas3Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Air")]
        Air = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Argon")]
        Argon = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Krypton")]
        Krypton = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Xenon")]
        Xenon = 3,
    }
    
    public enum WindowMaterial_GasMixture_Gas4Type
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Air")]
        Air = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Argon")]
        Argon = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Krypton")]
        Krypton = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Xenon")]
        Xenon = 3,
    }
    
    [Description(@"Used to define the gap between two layers in a complex fenestration system, where the Construction:ComplexFenestrationState object is used. It is referenced as a layer in the Construction:ComplexFenestrationState object. It cannot be referenced as a layer from the Construction object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Gap : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[Description("This field should reference only WindowMaterial:Gas or WindowMaterial:GasMixture " +
    "objects")]
[JsonProperty(PropertyName="gas_or_gas_mixture_")]
public string GasOrGasMixture { get; set; } = "";
        

[JsonProperty(PropertyName="pressure")]
public System.Nullable<float> Pressure { get; set; } = (System.Nullable<float>)Single.Parse("101325", CultureInfo.InvariantCulture);
        

[Description("If left blank, it will be considered that gap is not deflected")]
[JsonProperty(PropertyName="deflection_state")]
public string DeflectionState { get; set; } = "";
        

[Description("If left blank, it will be considered that gap does not have support pillars")]
[JsonProperty(PropertyName="support_pillar")]
public string SupportPillar { get; set; } = "";
    }
    
    [Description(@"Specifies the properties of window shade materials. Reflectance and emissivity properties are assumed to be the same on both sides of the shade. Shades are considered to be perfect diffusers (all transmitted and reflected radiation is hemispherically-diffuse) independent of angle of incidence.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Shade : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Assumed independent of incidence angle")]
[JsonProperty(PropertyName="solar_transmittance")]
public System.Nullable<float> SolarTransmittance { get; set; } = null;
        

[Description("Assumed same for both sides Assumed independent of incidence angle")]
[JsonProperty(PropertyName="solar_reflectance")]
public System.Nullable<float> SolarReflectance { get; set; } = null;
        

[Description("Assumed independent of incidence angle")]
[JsonProperty(PropertyName="visible_transmittance")]
public System.Nullable<float> VisibleTransmittance { get; set; } = null;
        

[Description("Assumed same for both sides Assumed independent of incidence angle")]
[JsonProperty(PropertyName="visible_reflectance")]
public System.Nullable<float> VisibleReflectance { get; set; } = null;
        

[JsonProperty(PropertyName="infrared_hemispherical_emissivity")]
public System.Nullable<float> InfraredHemisphericalEmissivity { get; set; } = null;
        

[JsonProperty(PropertyName="infrared_transmittance")]
public System.Nullable<float> InfraredTransmittance { get; set; } = null;
        

[JsonProperty(PropertyName="thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[JsonProperty(PropertyName="conductivity")]
public System.Nullable<float> Conductivity { get; set; } = null;
        

[JsonProperty(PropertyName="shade_to_glass_distance")]
public System.Nullable<float> ShadeToGlassDistance { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="top_opening_multiplier")]
public System.Nullable<float> TopOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="bottom_opening_multiplier")]
public System.Nullable<float> BottomOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="left_side_opening_multiplier")]
public System.Nullable<float> LeftSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="right_side_opening_multiplier")]
public System.Nullable<float> RightSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="airflow_permeability")]
public System.Nullable<float> AirflowPermeability { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description("Complex window shading layer thermal properties")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_ComplexShade : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="layer_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_ComplexShade_LayerType LayerType { get; set; } = (WindowMaterial_ComplexShade_LayerType)Enum.Parse(typeof(WindowMaterial_ComplexShade_LayerType), "OtherShadingType");
        

[JsonProperty(PropertyName="thickness")]
public System.Nullable<float> Thickness { get; set; } = (System.Nullable<float>)Single.Parse("0.002", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="conductivity")]
public System.Nullable<float> Conductivity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="ir_transmittance")]
public System.Nullable<float> IrTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="front_emissivity")]
public System.Nullable<float> FrontEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="back_emissivity")]
public System.Nullable<float> BackEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="top_opening_multiplier")]
public System.Nullable<float> TopOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="bottom_opening_multiplier")]
public System.Nullable<float> BottomOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="left_side_opening_multiplier")]
public System.Nullable<float> LeftSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="right_side_opening_multiplier")]
public System.Nullable<float> RightSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="front_opening_multiplier")]
public System.Nullable<float> FrontOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="slat_width")]
public System.Nullable<float> SlatWidth { get; set; } = (System.Nullable<float>)Single.Parse("0.016", CultureInfo.InvariantCulture);
        

[Description("Distance between adjacent slat faces")]
[JsonProperty(PropertyName="slat_spacing")]
public System.Nullable<float> SlatSpacing { get; set; } = (System.Nullable<float>)Single.Parse("0.012", CultureInfo.InvariantCulture);
        

[Description("Distance between top and bottom surfaces of slat Slat is assumed to be rectangula" +
    "r in cross section and flat")]
[JsonProperty(PropertyName="slat_thickness")]
public System.Nullable<float> SlatThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.0006", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="slat_angle")]
public System.Nullable<float> SlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="slat_conductivity")]
public System.Nullable<float> SlatConductivity { get; set; } = (System.Nullable<float>)Single.Parse("160", CultureInfo.InvariantCulture);
        

[Description("this value represents curvature radius of the slat. if the slat is flat use zero." +
    " if this value is not zero, then it must be > SlatWidth/2.")]
[JsonProperty(PropertyName="slat_curve")]
public System.Nullable<float> SlatCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum WindowMaterial_ComplexShade_LayerType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BSDF")]
        BSDF = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherShadingType")]
        OtherShadingType = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Perforated")]
        Perforated = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="VenetianHorizontal")]
        VenetianHorizontal = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="VenetianVertical")]
        VenetianVertical = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Woven")]
        Woven = 6,
    }
    
    [Description("Window blind thermal properties")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Blind : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="slat_orientation", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_Blind_SlatOrientation SlatOrientation { get; set; } = (WindowMaterial_Blind_SlatOrientation)Enum.Parse(typeof(WindowMaterial_Blind_SlatOrientation), "Horizontal");
        

[JsonProperty(PropertyName="slat_width")]
public System.Nullable<float> SlatWidth { get; set; } = null;
        

[Description("Distance between adjacent slat faces")]
[JsonProperty(PropertyName="slat_separation")]
public System.Nullable<float> SlatSeparation { get; set; } = null;
        

[Description("Distance between top and bottom surfaces of slat Slat is assumed to be rectangula" +
    "r in cross section and flat")]
[JsonProperty(PropertyName="slat_thickness")]
public System.Nullable<float> SlatThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.00025", CultureInfo.InvariantCulture);
        

[Description(@"If WindowShadingControl referencing the window that incorporates this blind has Type of Slat Angle Control for Blinds = FixedSlatAngle, then this is the fixed value of the slat angle; If WindowShadingControl referencing the window that incorporates this blind has Type of Slat Angle Control for Blinds = BlockBeamSolar, then this is the slat angle when slat angle control is not in effect (e.g., when there is no beam solar on the blind); Not used if WindowShadingControl referencing the window that incorporates this blind has Type of Slat Angle Control for Blinds = ScheduledSlatAngle.")]
[JsonProperty(PropertyName="slat_angle")]
public System.Nullable<float> SlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("45", CultureInfo.InvariantCulture);
        

[Description("default is for aluminum")]
[JsonProperty(PropertyName="slat_conductivity")]
public System.Nullable<float> SlatConductivity { get; set; } = (System.Nullable<float>)Single.Parse("221", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="slat_beam_solar_transmittance")]
public System.Nullable<float> SlatBeamSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="front_side_slat_beam_solar_reflectance")]
public System.Nullable<float> FrontSideSlatBeamSolarReflectance { get; set; } = null;
        

[JsonProperty(PropertyName="back_side_slat_beam_solar_reflectance")]
public System.Nullable<float> BackSideSlatBeamSolarReflectance { get; set; } = null;
        

[Description("Must equal \"Slat beam solar transmittance\"")]
[JsonProperty(PropertyName="slat_diffuse_solar_transmittance")]
public System.Nullable<float> SlatDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Must equal \"Front Side Slat Beam Solar Reflectance\"")]
[JsonProperty(PropertyName="front_side_slat_diffuse_solar_reflectance")]
public System.Nullable<float> FrontSideSlatDiffuseSolarReflectance { get; set; } = null;
        

[Description("Must equal \"Back Side Slat Beam Solar Reflectance\"")]
[JsonProperty(PropertyName="back_side_slat_diffuse_solar_reflectance")]
public System.Nullable<float> BackSideSlatDiffuseSolarReflectance { get; set; } = null;
        

[Description("Required for detailed daylighting calculation")]
[JsonProperty(PropertyName="slat_beam_visible_transmittance")]
public System.Nullable<float> SlatBeamVisibleTransmittance { get; set; } = null;
        

[Description("Required for detailed daylighting calculation")]
[JsonProperty(PropertyName="front_side_slat_beam_visible_reflectance")]
public System.Nullable<float> FrontSideSlatBeamVisibleReflectance { get; set; } = null;
        

[Description("Required for detailed daylighting calculation")]
[JsonProperty(PropertyName="back_side_slat_beam_visible_reflectance")]
public System.Nullable<float> BackSideSlatBeamVisibleReflectance { get; set; } = null;
        

[Description("Used only for detailed daylighting calculation Must equal \"Slat Beam Visible Tran" +
    "smittance\"")]
[JsonProperty(PropertyName="slat_diffuse_visible_transmittance")]
public System.Nullable<float> SlatDiffuseVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Required for detailed daylighting calculation Must equal \"Front Side Slat Beam Vi" +
    "sible Reflectance\"")]
[JsonProperty(PropertyName="front_side_slat_diffuse_visible_reflectance")]
public System.Nullable<float> FrontSideSlatDiffuseVisibleReflectance { get; set; } = null;
        

[Description("Required for detailed daylighting calculation Must equal \"Back Side Slat Beam Vis" +
    "ible Reflectance\"")]
[JsonProperty(PropertyName="back_side_slat_diffuse_visible_reflectance")]
public System.Nullable<float> BackSideSlatDiffuseVisibleReflectance { get; set; } = null;
        

[JsonProperty(PropertyName="slat_infrared_hemispherical_transmittance")]
public System.Nullable<float> SlatInfraredHemisphericalTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="front_side_slat_infrared_hemispherical_emissivity")]
public System.Nullable<float> FrontSideSlatInfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="back_side_slat_infrared_hemispherical_emissivity")]
public System.Nullable<float> BackSideSlatInfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="blind_to_glass_distance")]
public System.Nullable<float> BlindToGlassDistance { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="blind_top_opening_multiplier")]
public System.Nullable<float> BlindTopOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="blind_bottom_opening_multiplier")]
public System.Nullable<float> BlindBottomOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="blind_left_side_opening_multiplier")]
public System.Nullable<float> BlindLeftSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="blind_right_side_opening_multiplier")]
public System.Nullable<float> BlindRightSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("Used only if WindowShadingControl referencing the window that incorporates this b" +
    "lind varies the slat angle (i.e., WindowShadingControl with Type of Slat Angle C" +
    "ontrol for Blinds = ScheduledSlatAngle or BlockBeamSolar)")]
[JsonProperty(PropertyName="minimum_slat_angle")]
public System.Nullable<float> MinimumSlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only if WindowShadingControl referencing the window that incorporates this b" +
    "lind varies the slat angle (i.e., WindowShadingControl with Type of Slat Angle C" +
    "ontrol for Blinds = ScheduledSlatAngle or BlockBeamSolar)")]
[JsonProperty(PropertyName="maximum_slat_angle")]
public System.Nullable<float> MaximumSlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("180", CultureInfo.InvariantCulture);
    }
    
    public enum WindowMaterial_Blind_SlatOrientation
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Horizontal")]
        Horizontal = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Vertical")]
        Vertical = 2,
    }
    
    [Description("Window screen physical properties. Can only be located on the exterior side of a " +
        "window construction.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Screen : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Select the method used to account for the beam solar reflected off the material s" +
    "urface.")]
[JsonProperty(PropertyName="reflected_beam_transmittance_accounting_method", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_Screen_ReflectedBeamTransmittanceAccountingMethod ReflectedBeamTransmittanceAccountingMethod { get; set; } = (WindowMaterial_Screen_ReflectedBeamTransmittanceAccountingMethod)Enum.Parse(typeof(WindowMaterial_Screen_ReflectedBeamTransmittanceAccountingMethod), "ModelAsDiffuse");
        

[Description("Diffuse reflectance of the screen material over the entire solar radiation spectr" +
    "um. Assumed to be the same for both sides of the screen.")]
[JsonProperty(PropertyName="diffuse_solar_reflectance")]
public System.Nullable<float> DiffuseSolarReflectance { get; set; } = null;
        

[Description("Diffuse visible reflectance of the screen material averaged over the solar spectr" +
    "um and weighted by the response of the human eye. Assumed to be the same for bot" +
    "h sides of the screen.")]
[JsonProperty(PropertyName="diffuse_visible_reflectance")]
public System.Nullable<float> DiffuseVisibleReflectance { get; set; } = null;
        

[Description("Long-wave emissivity of the screen material. Assumed to be the same for both side" +
    "s of the screen.")]
[JsonProperty(PropertyName="thermal_hemispherical_emissivity")]
public System.Nullable<float> ThermalHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Thermal conductivity of the screen material. Default is for aluminum.")]
[JsonProperty(PropertyName="conductivity")]
public System.Nullable<float> Conductivity { get; set; } = (System.Nullable<float>)Single.Parse("221", CultureInfo.InvariantCulture);
        

[Description("Spacing assumed to be the same in both directions.")]
[JsonProperty(PropertyName="screen_material_spacing")]
public System.Nullable<float> ScreenMaterialSpacing { get; set; } = null;
        

[Description("Diameter assumed to be the same in both directions.")]
[JsonProperty(PropertyName="screen_material_diameter")]
public System.Nullable<float> ScreenMaterialDiameter { get; set; } = null;
        

[Description("Distance from the window screen to the adjacent glass surface.")]
[JsonProperty(PropertyName="screen_to_glass_distance")]
public System.Nullable<float> ScreenToGlassDistance { get; set; } = (System.Nullable<float>)Single.Parse("0.025", CultureInfo.InvariantCulture);
        

[Description("Effective area for air flow at the top of the screen divided by the perpendicular" +
    " area between the glass and the top of the screen.")]
[JsonProperty(PropertyName="top_opening_multiplier")]
public System.Nullable<float> TopOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Effective area for air flow at the bottom of the screen divided by the perpendicu" +
    "lar area between the glass and the bottom of the screen.")]
[JsonProperty(PropertyName="bottom_opening_multiplier")]
public System.Nullable<float> BottomOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Effective area for air flow at the left side of the screen divided by the perpend" +
    "icular area between the glass and the left side of the screen.")]
[JsonProperty(PropertyName="left_side_opening_multiplier")]
public System.Nullable<float> LeftSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Effective area for air flow at the right side of the screen divided by the perpen" +
    "dicular area between the glass and the right side of the screen.")]
[JsonProperty(PropertyName="right_side_opening_multiplier")]
public System.Nullable<float> RightSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Select the resolution of azimuth and altitude angles for the screen transmittance" +
    " map. A value of 0 means no transmittance map will be generated. Valid values fo" +
    "r this field are 0, 1, 2, 3 and 5.")]
[JsonProperty(PropertyName="angle_of_resolution_for_screen_transmittance_output_map")]
public System.Nullable<float> AngleOfResolutionForScreenTransmittanceOutputMap { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum WindowMaterial_Screen_ReflectedBeamTransmittanceAccountingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DoNotModel")]
        DoNotModel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ModelAsDiffuse")]
        ModelAsDiffuse = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ModelAsDirectBeam")]
        ModelAsDirectBeam = 3,
    }
    
    [Description("Specifies the properties of equivalent layer window shade material Shades are con" +
        "sidered to be perfect diffusers (all transmitted and reflected radiation is hemi" +
        "spherically-diffuse) independent of angle of incidence. Shade represents roller " +
        "blinds.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Shade_EquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("The beam-beam solar transmittance at normal incidence. This value is the same as " +
    "the openness area fraction of the shade material. Assumed to be the same for fro" +
    "nt and back sides.")]
[JsonProperty(PropertyName="shade_beam_beam_solar_transmittance")]
public System.Nullable<float> ShadeBeamBeamSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The front side beam-diffuse solar transmittance at normal incidence averaged over" +
    " the entire spectrum of solar radiation.")]
[JsonProperty(PropertyName="front_side_shade_beam_diffuse_solar_transmittance")]
public System.Nullable<float> FrontSideShadeBeamDiffuseSolarTransmittance { get; set; } = null;
        

[Description("The back side beam-diffuse solar transmittance at normal incidence averaged over " +
    "the entire spectrum of solar radiation.")]
[JsonProperty(PropertyName="back_side_shade_beam_diffuse_solar_transmittance")]
public System.Nullable<float> BackSideShadeBeamDiffuseSolarTransmittance { get; set; } = null;
        

[Description("The front side beam-diffuse solar reflectance at normal incidence averaged over t" +
    "he entire spectrum of solar radiation.")]
[JsonProperty(PropertyName="front_side_shade_beam_diffuse_solar_reflectance")]
public System.Nullable<float> FrontSideShadeBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The back side beam-diffuse solar reflectance at normal incidence averaged over th" +
    "e entire spectrum of solar radiation.")]
[JsonProperty(PropertyName="back_side_shade_beam_diffuse_solar_reflectance")]
public System.Nullable<float> BackSideShadeBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The beam-beam visible transmittance at normal incidence averaged over the visible" +
    " spectrum range of solar radiation. Assumed to be the same for front and back si" +
    "des of the shade.")]
[JsonProperty(PropertyName="shade_beam_beam_visible_transmittance_at_normal_incidence")]
public System.Nullable<float> ShadeBeamBeamVisibleTransmittanceAtNormalIncidence { get; set; } = null;
        

[Description("The beam-diffuse visible transmittance at normal incidence averaged over the visi" +
    "ble spectrum range of solar radiation. Assumed to be the same for front and back" +
    " sides of the shade.")]
[JsonProperty(PropertyName="shade_beam_diffuse_visible_transmittance_at_normal_incidence")]
public System.Nullable<float> ShadeBeamDiffuseVisibleTransmittanceAtNormalIncidence { get; set; } = null;
        

[Description("The beam-diffuse visible reflectance at normal incidence averaged over the visibl" +
    "e spectrum range of solar radiation. Assumed to be the same for front and back s" +
    "ides of the shade.")]
[JsonProperty(PropertyName="shade_beam_diffuse_visible_reflectance_at_normal_incidence")]
public System.Nullable<float> ShadeBeamDiffuseVisibleReflectanceAtNormalIncidence { get; set; } = null;
        

[Description("The long-wave transmittance of the shade material at zero shade openness. Assumed" +
    " to be the same for front and back sides of the shade.")]
[JsonProperty(PropertyName="shade_material_infrared_transmittance")]
public System.Nullable<float> ShadeMaterialInfraredTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

[Description("The front side long-wave emissivity of the shade material at zero shade openness." +
    " Openness fraction is used to calculate the effective emissivity value.")]
[JsonProperty(PropertyName="front_side_shade_material_infrared_emissivity")]
public System.Nullable<float> FrontSideShadeMaterialInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.91", CultureInfo.InvariantCulture);
        

[Description("The back side long-wave emissivity of the shade material at zero shade openness. " +
    "Openness fraction is used to calculate the effective emissivity value.")]
[JsonProperty(PropertyName="back_side_shade_material_infrared_emissivity")]
public System.Nullable<float> BackSideShadeMaterialInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.91", CultureInfo.InvariantCulture);
    }
    
    [Description(@"Specifies the properties of equivalent layer drape fabric materials. Shades are considered to be perfect diffusers (all transmitted and reflected radiation is hemispherically-diffuse) independent of angle of incidence. unpleated drape fabric is treated as thin and flat layer.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Drape_EquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("The beam-beam solar transmittance at normal incidence. This value is the same as " +
    "the openness area fraction of the drape fabric. Assumed to be same for front and" +
    " back sides.")]
[JsonProperty(PropertyName="drape_beam_beam_solar_transmittance_at_normal_incidence")]
public System.Nullable<float> DrapeBeamBeamSolarTransmittanceAtNormalIncidence { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The front side beam-diffuse solar transmittance at normal incidence averaged over" +
    " the entire spectrum of solar radiation. Assumed to be the same for front and ba" +
    "ck sides.")]
[JsonProperty(PropertyName="front_side_drape_beam_diffuse_solar_transmittance")]
public System.Nullable<float> FrontSideDrapeBeamDiffuseSolarTransmittance { get; set; } = null;
        

[Description("The back side beam-diffuse solar transmittance at normal incidence averaged over " +
    "the entire spectrum of solar radiation. Assumed to be the same for front and bac" +
    "k sides.")]
[JsonProperty(PropertyName="back_side_drape_beam_diffuse_solar_transmittance")]
public System.Nullable<float> BackSideDrapeBeamDiffuseSolarTransmittance { get; set; } = null;
        

[Description("The front side beam-diffuse solar reflectance at normal incidence averaged over t" +
    "he entire spectrum of solar radiation.")]
[JsonProperty(PropertyName="front_side_drape_beam_diffuse_solar_reflectance")]
public System.Nullable<float> FrontSideDrapeBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The back side beam-diffuse solar reflectance at normal incidence averaged over th" +
    "e entire spectrum of solar radiation.")]
[JsonProperty(PropertyName="back_side_drape_beam_diffuse_solar_reflectance")]
public System.Nullable<float> BackSideDrapeBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The beam-beam visible transmittance at normal incidence averaged over the visible" +
    " spectrum of solar radiation. Assumed same for front and back sides.")]
[JsonProperty(PropertyName="drape_beam_beam_visible_transmittance")]
public System.Nullable<float> DrapeBeamBeamVisibleTransmittance { get; set; } = null;
        

[Description("The beam-diffuse visible transmittance at normal incidence averaged over the visi" +
    "ble spectrum range of solar radiation. Assumed to be the same for front and back" +
    " sides.")]
[JsonProperty(PropertyName="drape_beam_diffuse_visible_transmittance")]
public System.Nullable<float> DrapeBeamDiffuseVisibleTransmittance { get; set; } = null;
        

[Description("The beam-diffuse visible reflectance at normal incidence average over the visible" +
    " spectrum range of solar radiation. Assumed to be the same for front and back si" +
    "des.")]
[JsonProperty(PropertyName="drape_beam_diffuse_visible_reflectance")]
public System.Nullable<float> DrapeBeamDiffuseVisibleReflectance { get; set; } = null;
        

[Description("Long-wave transmittance of the drape fabric at zero openness fraction. Assumed sa" +
    "me for front and back sides.")]
[JsonProperty(PropertyName="drape_material_infrared_transmittance")]
public System.Nullable<float> DrapeMaterialInfraredTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

[Description("Front side long-wave emissivity of the drape fabric at zero shade openness. Openn" +
    "ess fraction specified above is used to calculate the effective emissivity value" +
    ".")]
[JsonProperty(PropertyName="front_side_drape_material_infrared_emissivity")]
public System.Nullable<float> FrontSideDrapeMaterialInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.87", CultureInfo.InvariantCulture);
        

[Description("Back side long-wave emissivity of the drape fabric at zero shade openness. Openne" +
    "ss fraction specified above is used to calculate the effective emissivity value." +
    "")]
[JsonProperty(PropertyName="back_side_drape_material_infrared_emissivity")]
public System.Nullable<float> BackSideDrapeMaterialInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.87", CultureInfo.InvariantCulture);
        

[Description("Width of the pleated section of the draped fabric. If the drape fabric is unpleat" +
    "ed or is flat, then the pleated section width is set to zero.")]
[JsonProperty(PropertyName="width_of_pleated_fabric")]
public System.Nullable<float> WidthOfPleatedFabric { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Length of the pleated section of the draped fabric. If the drape fabric is unplea" +
    "ted or is flat, then the pleated section length is set to zero.")]
[JsonProperty(PropertyName="length_of_pleated_fabric")]
public System.Nullable<float> LengthOfPleatedFabric { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description("Window equivalent layer blind slat optical and thermal properties. The model assu" +
        "mes that slats are thin and flat, applies correction empirical correlation to ac" +
        "count for curvature effect. Slats are assumed to transmit and reflect diffusely." +
        "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Blind_EquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="slat_orientation", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_Blind_EquivalentLayer_SlatOrientation SlatOrientation { get; set; } = (WindowMaterial_Blind_EquivalentLayer_SlatOrientation)Enum.Parse(typeof(WindowMaterial_Blind_EquivalentLayer_SlatOrientation), "Horizontal");
        

[JsonProperty(PropertyName="slat_width")]
public System.Nullable<float> SlatWidth { get; set; } = null;
        

[Description("Distance between adjacent slat faces")]
[JsonProperty(PropertyName="slat_separation")]
public System.Nullable<float> SlatSeparation { get; set; } = null;
        

[Description("Perpendicular length between the cord and the curve. Slat is assumed to be rectan" +
    "gular in cross section and flat. Crown=0.0625x\"Slat width\"")]
[JsonProperty(PropertyName="slat_crown")]
public System.Nullable<float> SlatCrown { get; set; } = (System.Nullable<float>)Single.Parse("0.0015", CultureInfo.InvariantCulture);
        

[Description("Slat angle is +ve if the tip of the slat front face is tilted upward, else the sl" +
    "at angle is -ve if the tip of the slat front face is tilted downward. The slat a" +
    "ngle varies between -90 to +90. The default value is 45 degrees.")]
[JsonProperty(PropertyName="slat_angle")]
public System.Nullable<float> SlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("45", CultureInfo.InvariantCulture);
        

[Description("The front side beam-diffuse solar transmittance of the slat at normal incidence a" +
    "veraged over the entire spectrum of solar radiation.")]
[JsonProperty(PropertyName="front_side_slat_beam_diffuse_solar_transmittance")]
public System.Nullable<float> FrontSideSlatBeamDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The back side beam-diffuse solar transmittance of the slat at normal incidence av" +
    "eraged over the entire spectrum of solar radiation.")]
[JsonProperty(PropertyName="back_side_slat_beam_diffuse_solar_transmittance")]
public System.Nullable<float> BackSideSlatBeamDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The front side beam-diffuse solar reflectance of the slat at normal incidence ave" +
    "raged over the entire spectrum of solar radiation.")]
[JsonProperty(PropertyName="front_side_slat_beam_diffuse_solar_reflectance")]
public System.Nullable<float> FrontSideSlatBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The back side beam-diffuse solar reflectance of the slat at normal incidence aver" +
    "aged over the entire spectrum of solar radiation.")]
[JsonProperty(PropertyName="back_side_slat_beam_diffuse_solar_reflectance")]
public System.Nullable<float> BackSideSlatBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The front side beam-diffuse visible transmittance of the slat at normal incidence" +
    " averaged over the visible spectrum range of solar radiation.")]
[JsonProperty(PropertyName="front_side_slat_beam_diffuse_visible_transmittance")]
public System.Nullable<float> FrontSideSlatBeamDiffuseVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The back side beam-diffuse visible transmittance of the slat at normal incidence " +
    "averaged over the visible spectrum range of solar radiation.")]
[JsonProperty(PropertyName="back_side_slat_beam_diffuse_visible_transmittance")]
public System.Nullable<float> BackSideSlatBeamDiffuseVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The front side beam-diffuse visible reflectance of the slat at normal incidence a" +
    "veraged over the visible spectrum range of solar radiation.")]
[JsonProperty(PropertyName="front_side_slat_beam_diffuse_visible_reflectance")]
public System.Nullable<float> FrontSideSlatBeamDiffuseVisibleReflectance { get; set; } = null;
        

[Description("The back side beam-diffuse visible reflectance of the slat at normal incidence av" +
    "eraged over the visible spectrum range of solar radiation.")]
[JsonProperty(PropertyName="back_side_slat_beam_diffuse_visible_reflectance")]
public System.Nullable<float> BackSideSlatBeamDiffuseVisibleReflectance { get; set; } = null;
        

[Description("The beam-diffuse solar transmittance of the slat averaged over the entire solar s" +
    "pectrum of solar radiation.")]
[JsonProperty(PropertyName="slat_diffuse_diffuse_solar_transmittance")]
public System.Nullable<float> SlatDiffuseDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The front side beam-diffuse solar reflectance of the slat averaged over the entir" +
    "e solar spectrum of solar radiation.")]
[JsonProperty(PropertyName="front_side_slat_diffuse_diffuse_solar_reflectance")]
public System.Nullable<float> FrontSideSlatDiffuseDiffuseSolarReflectance { get; set; } = null;
        

[Description("The back side beam-diffuse solar reflectance of the slat averaged over the entire" +
    " solar spectrum of solar radiation.")]
[JsonProperty(PropertyName="back_side_slat_diffuse_diffuse_solar_reflectance")]
public System.Nullable<float> BackSideSlatDiffuseDiffuseSolarReflectance { get; set; } = null;
        

[Description("The beam-diffuse visible transmittance of the slat averaged over the visible spec" +
    "trum range of solar radiation.")]
[JsonProperty(PropertyName="slat_diffuse_diffuse_visible_transmittance")]
public System.Nullable<float> SlatDiffuseDiffuseVisibleTransmittance { get; set; } = null;
        

[Description("The front side beam-diffuse visible reflectance of the slat averaged over the vis" +
    "ible spectrum range of solar radiation.")]
[JsonProperty(PropertyName="front_side_slat_diffuse_diffuse_visible_reflectance")]
public System.Nullable<float> FrontSideSlatDiffuseDiffuseVisibleReflectance { get; set; } = null;
        

[Description("The back side beam-diffuse visible reflectance of the slat averaged over the visi" +
    "ble spectrum range of solar radiation.")]
[JsonProperty(PropertyName="back_side_slat_diffuse_diffuse_visible_reflectance")]
public System.Nullable<float> BackSideSlatDiffuseDiffuseVisibleReflectance { get; set; } = null;
        

[Description("Long-wave hemispherical transmittance of the slat material. Assumed to be the sam" +
    "e for both sides of the slat.")]
[JsonProperty(PropertyName="slat_infrared_transmittance")]
public System.Nullable<float> SlatInfraredTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Front side long-wave hemispherical emissivity of the slat material.")]
[JsonProperty(PropertyName="front_side_slat_infrared_emissivity")]
public System.Nullable<float> FrontSideSlatInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Back side long-wave hemispherical emissivity of the slat material.")]
[JsonProperty(PropertyName="back_side_slat_infrared_emissivity")]
public System.Nullable<float> BackSideSlatInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description(@"Used only if slat angle control is desired to either maximize solar gain (MaximizeSolar), maximize visibility while eliminating beam solar radiation (BlockBeamSolar), or fixed slate angle (FixedSlatAngle). If FixedSlatAngle is selected, the slat angle entered above is used.")]
[JsonProperty(PropertyName="slat_angle_control", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_Blind_EquivalentLayer_SlatAngleControl SlatAngleControl { get; set; } = (WindowMaterial_Blind_EquivalentLayer_SlatAngleControl)Enum.Parse(typeof(WindowMaterial_Blind_EquivalentLayer_SlatAngleControl), "FixedSlatAngle");
    }
    
    public enum WindowMaterial_Blind_EquivalentLayer_SlatOrientation
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Horizontal")]
        Horizontal = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Vertical")]
        Vertical = 2,
    }
    
    public enum WindowMaterial_Blind_EquivalentLayer_SlatAngleControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BlockBeamSolar")]
        BlockBeamSolar = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedSlatAngle")]
        FixedSlatAngle = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MaximizeSolar")]
        MaximizeSolar = 3,
    }
    
    [Description("Equivalent layer window screen physical properties. Can only be located on the ex" +
        "terior side of a window construction.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Screen_EquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description(@"The beam-beam transmittance of the screen material at normal incidence. This input field is the same as the material openness area fraction and can be autocalculated from the wire spacing and wire and diameter. Assumed to be the same for both sides of the screen.")]
[JsonProperty(PropertyName="screen_beam_beam_solar_transmittance", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> ScreenBeamBeamSolarTransmittance { get; set; } = null;
        

[Description("The beam-diffuse solar transmittance of the screen material at normal incidence a" +
    "veraged over the entire spectrum of solar radiation. Assumed to be the same for " +
    "both sides of the screen.")]
[JsonProperty(PropertyName="screen_beam_diffuse_solar_transmittance")]
public System.Nullable<float> ScreenBeamDiffuseSolarTransmittance { get; set; } = null;
        

[Description("The beam-diffuse solar reflectance of the screen material at normal incidence ave" +
    "raged over the entire spectrum of solar radiation. Assumed to be the same for bo" +
    "th sides of the screen.")]
[JsonProperty(PropertyName="screen_beam_diffuse_solar_reflectance")]
public System.Nullable<float> ScreenBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The beam-beam visible transmittance of the screen material at normal incidence av" +
    "eraged over the visible spectrum range of solar radiation. Assumed to be the sam" +
    "e for both sides of the screen.")]
[JsonProperty(PropertyName="screen_beam_beam_visible_transmittance")]
public System.Nullable<float> ScreenBeamBeamVisibleTransmittance { get; set; } = null;
        

[Description("The beam-diffuse visible transmittance of the screen material at normal incidence" +
    " averaged over the visible spectrum range of solar radiation. Assumed to be the " +
    "same for both sides of the screen.")]
[JsonProperty(PropertyName="screen_beam_diffuse_visible_transmittance")]
public System.Nullable<float> ScreenBeamDiffuseVisibleTransmittance { get; set; } = null;
        

[Description("Beam-diffuse visible reflectance of the screen material at normal incidence avera" +
    "ged over the visible spectrum range of solar radiation. Assumed to be the same f" +
    "or both sides of the screen.")]
[JsonProperty(PropertyName="screen_beam_diffuse_visible_reflectance")]
public System.Nullable<float> ScreenBeamDiffuseVisibleReflectance { get; set; } = null;
        

[Description("The long-wave hemispherical transmittance of the screen material. Assumed to be t" +
    "he same for both sides of the screen.")]
[JsonProperty(PropertyName="screen_infrared_transmittance")]
public System.Nullable<float> ScreenInfraredTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0.02", CultureInfo.InvariantCulture);
        

[Description("The long-wave hemispherical emissivity of the screen material. Assumed to be the " +
    "same for both sides of the screen.")]
[JsonProperty(PropertyName="screen_infrared_emissivity")]
public System.Nullable<float> ScreenInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.93", CultureInfo.InvariantCulture);
        

[Description("Spacing assumed to be the same in both directions.")]
[JsonProperty(PropertyName="screen_wire_spacing")]
public System.Nullable<float> ScreenWireSpacing { get; set; } = (System.Nullable<float>)Single.Parse("0.025", CultureInfo.InvariantCulture);
        

[Description("Diameter assumed to be the same in both directions.")]
[JsonProperty(PropertyName="screen_wire_diameter")]
public System.Nullable<float> ScreenWireDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.005", CultureInfo.InvariantCulture);
    }
    
    [Description("Glass material properties for Windows or Glass Doors Transmittance/Reflectance in" +
        "put method.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Glazing_EquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Spectral is not currently supported and SpectralAverage is the default.")]
[JsonProperty(PropertyName="optical_data_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_Glazing_EquivalentLayer_OpticalDataType OpticalDataType { get; set; } = (WindowMaterial_Glazing_EquivalentLayer_OpticalDataType)Enum.Parse(typeof(WindowMaterial_Glazing_EquivalentLayer_OpticalDataType), "SpectralAverage");
        

[Description("Spectral data is not currently supported. Used only when Optical Data Type = Spec" +
    "tral")]
[JsonProperty(PropertyName="window_glass_spectral_data_set_name")]
public string WindowGlassSpectralDataSetName { get; set; } = "";
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty(PropertyName="front_side_beam_beam_solar_transmittance")]
public System.Nullable<float> FrontSideBeamBeamSolarTransmittance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty(PropertyName="back_side_beam_beam_solar_transmittance")]
public System.Nullable<float> BackSideBeamBeamSolarTransmittance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
    "outdoor air")]
[JsonProperty(PropertyName="front_side_beam_beam_solar_reflectance")]
public System.Nullable<float> FrontSideBeamBeamSolarReflectance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
    "one air")]
[JsonProperty(PropertyName="back_side_beam_beam_solar_reflectance")]
public System.Nullable<float> BackSideBeamBeamSolarReflectance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty(PropertyName="front_side_beam_beam_visible_solar_transmittance")]
public System.Nullable<float> FrontSideBeamBeamVisibleSolarTransmittance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty(PropertyName="back_side_beam_beam_visible_solar_transmittance")]
public System.Nullable<float> BackSideBeamBeamVisibleSolarTransmittance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
    "outdoor air")]
[JsonProperty(PropertyName="front_side_beam_beam_visible_solar_reflectance")]
public System.Nullable<float> FrontSideBeamBeamVisibleSolarReflectance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
    "one air")]
[JsonProperty(PropertyName="back_side_beam_beam_visible_solar_reflectance")]
public System.Nullable<float> BackSideBeamBeamVisibleSolarReflectance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty(PropertyName="front_side_beam_diffuse_solar_transmittance")]
public System.Nullable<float> FrontSideBeamDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty(PropertyName="back_side_beam_diffuse_solar_transmittance")]
public System.Nullable<float> BackSideBeamDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
    "outdoor air")]
[JsonProperty(PropertyName="front_side_beam_diffuse_solar_reflectance")]
public System.Nullable<float> FrontSideBeamDiffuseSolarReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
    "one air")]
[JsonProperty(PropertyName="back_side_beam_diffuse_solar_reflectance")]
public System.Nullable<float> BackSideBeamDiffuseSolarReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty(PropertyName="front_side_beam_diffuse_visible_solar_transmittance")]
public System.Nullable<float> FrontSideBeamDiffuseVisibleSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty(PropertyName="back_side_beam_diffuse_visible_solar_transmittance")]
public System.Nullable<float> BackSideBeamDiffuseVisibleSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
    "outdoor air")]
[JsonProperty(PropertyName="front_side_beam_diffuse_visible_solar_reflectance")]
public System.Nullable<float> FrontSideBeamDiffuseVisibleSolarReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
    "one air")]
[JsonProperty(PropertyName="back_side_beam_diffuse_visible_solar_reflectance")]
public System.Nullable<float> BackSideBeamDiffuseVisibleSolarReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Used only when Optical Data Type = SpectralAverage If this field is autocalculate, then the diffuse-diffuse solar transmittance is automatically estimated from other inputs and used in subsequent calculations. If this field is zero or positive, then the value entered here will be used.")]
[JsonProperty(PropertyName="diffuse_diffuse_solar_transmittance", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> DiffuseDiffuseSolarTransmittance { get; set; } = null;
        

[Description(@"Used only when Optical Data Type = SpectralAverage If this field is autocalculate, then the front diffuse-diffuse solar reflectance is automatically estimated from other inputs and used in subsequent calculations. If this field is zero or positive, then the value entered here will be used. Front Side is side closest to outdoor air.")]
[JsonProperty(PropertyName="front_side_diffuse_diffuse_solar_reflectance", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> FrontSideDiffuseDiffuseSolarReflectance { get; set; } = null;
        

[Description(@"Used only when Optical Data Type = SpectralAverage If this field is autocalculate, then the back diffuse-diffuse solar reflectance is automatically estimated from other inputs and used in subsequent calculations. If this field is zero or positive, then the value entered here will be used. Back side is side closest to indoor air.")]
[JsonProperty(PropertyName="back_side_diffuse_diffuse_solar_reflectance", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> BackSideDiffuseDiffuseSolarReflectance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage This input field is not used c" +
    "urrently.")]
[JsonProperty(PropertyName="diffuse_diffuse_visible_solar_transmittance", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> DiffuseDiffuseVisibleSolarTransmittance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage This input field is not used c" +
    "urrently.")]
[JsonProperty(PropertyName="front_side_diffuse_diffuse_visible_solar_reflectance", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> FrontSideDiffuseDiffuseVisibleSolarReflectance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage This input field is not used c" +
    "urrently.")]
[JsonProperty(PropertyName="back_side_diffuse_diffuse_visible_solar_reflectance", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> BackSideDiffuseDiffuseVisibleSolarReflectance { get; set; } = null;
        

[Description("The long-wave hemispherical transmittance of the glazing. Assumed to be the same " +
    "for both sides of the glazing.")]
[JsonProperty(PropertyName="infrared_transmittance_applies_to_front_and_back_")]
public System.Nullable<float> InfraredTransmittanceAppliesToFrontAndBack { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The front side long-wave hemispherical emissivity of the glazing.")]
[JsonProperty(PropertyName="front_side_infrared_emissivity")]
public System.Nullable<float> FrontSideInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[Description("The back side long-wave hemispherical emissivity of the glazing.")]
[JsonProperty(PropertyName="back_side_infrared_emissivity")]
public System.Nullable<float> BackSideInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[Description("This is the R-Value in SI for the glass. The default value is an approximation fo" +
    "r a single layer of glass at 1/4\" inch thickness. This field is used only for mo" +
    "vable insulation defined with this material type.")]
[JsonProperty(PropertyName="thermal_resistance")]
public System.Nullable<float> ThermalResistance { get; set; } = (System.Nullable<float>)Single.Parse("0.158", CultureInfo.InvariantCulture);
    }
    
    public enum WindowMaterial_Glazing_EquivalentLayer_OpticalDataType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Spectral")]
        Spectral = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SpectralAverage")]
        SpectralAverage = 2,
    }
    
    [Description("Gas material properties that are used in Windows Equivalent Layer References only" +
        " WindowMaterial:Gas properties")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Gap_EquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="gas_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_Gap_EquivalentLayer_GasType GasType { get; set; } = (WindowMaterial_Gap_EquivalentLayer_GasType)Enum.Parse(typeof(WindowMaterial_Gap_EquivalentLayer_GasType), "AIR");
        

[JsonProperty(PropertyName="thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[Description(@"Sealed means the gap is enclosed and gas tight, i.e., no venting to indoor or outdoor environment. VentedIndoor means the gap is vented to indoor environment, and VentedOutdoor means the gap is vented to the outdoor environment. The gap types VentedIndoor and VentedOutdoor are used with gas type ""Air"" only.")]
[JsonProperty(PropertyName="gap_vent_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowMaterial_Gap_EquivalentLayer_GapVentType GapVentType { get; set; } = (WindowMaterial_Gap_EquivalentLayer_GapVentType)Enum.Parse(typeof(WindowMaterial_Gap_EquivalentLayer_GapVentType), "Sealed");
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="conductivity_coefficient_a")]
public System.Nullable<float> ConductivityCoefficientA { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="conductivity_coefficient_b")]
public System.Nullable<float> ConductivityCoefficientB { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="conductivity_coefficient_c")]
public System.Nullable<float> ConductivityCoefficientC { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="viscosity_coefficient_a")]
public System.Nullable<float> ViscosityCoefficientA { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="viscosity_coefficient_b")]
public System.Nullable<float> ViscosityCoefficientB { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="viscosity_coefficient_c")]
public System.Nullable<float> ViscosityCoefficientC { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="specific_heat_coefficient_a")]
public System.Nullable<float> SpecificHeatCoefficientA { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="specific_heat_coefficient_b")]
public System.Nullable<float> SpecificHeatCoefficientB { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="specific_heat_coefficient_c")]
public System.Nullable<float> SpecificHeatCoefficientC { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="molecular_weight")]
public System.Nullable<float> MolecularWeight { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty(PropertyName="specific_heat_ratio")]
public System.Nullable<float> SpecificHeatRatio { get; set; } = null;
    }
    
    public enum WindowMaterial_Gap_EquivalentLayer_GasType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AIR")]
        AIR = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ARGON")]
        ARGON = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CUSTOM")]
        CUSTOM = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="KRYPTON")]
        KRYPTON = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="XENON")]
        XENON = 4,
    }
    
    public enum WindowMaterial_Gap_EquivalentLayer_GapVentType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Sealed")]
        Sealed = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="VentedIndoor")]
        VentedIndoor = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="VentedOutdoor")]
        VentedOutdoor = 2,
    }
    
    [Description("Additional properties for moisture using EMPD procedure HeatBalanceAlgorithm choi" +
        "ce=MoisturePenetrationDepthConductionTransferFunction only Has no effect with ot" +
        "her HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_MoisturePenetrationDepth_Settings : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Ratio of water vapor permeability of stagnant air to water vapor permeability of " +
    "material")]
[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_equation_coefficient_a")]
public System.Nullable<float> MoistureEquationCoefficientA { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_equation_coefficient_b")]
public System.Nullable<float> MoistureEquationCoefficientB { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_equation_coefficient_c")]
public System.Nullable<float> MoistureEquationCoefficientC { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_equation_coefficient_d")]
public System.Nullable<float> MoistureEquationCoefficientD { get; set; } = null;
        

[JsonProperty(PropertyName="surface_layer_penetration_depth", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> SurfaceLayerPenetrationDepth { get; set; } = null;
        

[JsonProperty(PropertyName="deep_layer_penetration_depth", ItemConverterType=typeof(EnergyPlus_oM.EPNullToAutosizeJsonConverter))]
public System.Nullable<float> DeepLayerPenetrationDepth { get; set; } = null;
        

[JsonProperty(PropertyName="coating_layer_thickness")]
public System.Nullable<float> CoatingLayerThickness { get; set; } = null;
        

[Description("The coating\'s resistance to water vapor diffusion relative to the resistance to w" +
    "ater vapor diffusion in stagnant air (see Water Vapor Diffusion Resistance Facto" +
    "r above).")]
[JsonProperty(PropertyName="coating_layer_water_vapor_diffusion_resistance_factor")]
public System.Nullable<float> CoatingLayerWaterVaporDiffusionResistanceFactor { get; set; } = null;
    }
    
    [Description(@"Additional properties for temperature dependent thermal conductivity and enthalpy for Phase Change Materials (PCM) HeatBalanceAlgorithm = CondFD(ConductionFiniteDifference) solution algorithm only. Constructions with this should use the detailed CondFD process. Has no effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_PhaseChange : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("The base temperature is 20C. This is the thermal conductivity change per degree e" +
    "xcursion from 20C. This variable conductivity function is overridden by the Vari" +
    "ableThermalConductivity object, if present.")]
[JsonProperty(PropertyName="temperature_coefficient_for_thermal_conductivity")]
public System.Nullable<float> TemperatureCoefficientForThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_1")]
public System.Nullable<float> Temperature1 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 1")]
[JsonProperty(PropertyName="enthalpy_1")]
public System.Nullable<float> Enthalpy1 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_2")]
public System.Nullable<float> Temperature2 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 2")]
[JsonProperty(PropertyName="enthalpy_2")]
public System.Nullable<float> Enthalpy2 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_3")]
public System.Nullable<float> Temperature3 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 3")]
[JsonProperty(PropertyName="enthalpy_3")]
public System.Nullable<float> Enthalpy3 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_4")]
public System.Nullable<float> Temperature4 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 4")]
[JsonProperty(PropertyName="enthalpy_4")]
public System.Nullable<float> Enthalpy4 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_5")]
public System.Nullable<float> Temperature5 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 5")]
[JsonProperty(PropertyName="enthalpy_5")]
public System.Nullable<float> Enthalpy5 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_6")]
public System.Nullable<float> Temperature6 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 6")]
[JsonProperty(PropertyName="enthalpy_6")]
public System.Nullable<float> Enthalpy6 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_7")]
public System.Nullable<float> Temperature7 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 7")]
[JsonProperty(PropertyName="enthalpy_7")]
public System.Nullable<float> Enthalpy7 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_8")]
public System.Nullable<float> Temperature8 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 8")]
[JsonProperty(PropertyName="enthalpy_8")]
public System.Nullable<float> Enthalpy8 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_9")]
public System.Nullable<float> Temperature9 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 1")]
[JsonProperty(PropertyName="enthalpy_9")]
public System.Nullable<float> Enthalpy9 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_10")]
public System.Nullable<float> Temperature10 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 2")]
[JsonProperty(PropertyName="enthalpy_10")]
public System.Nullable<float> Enthalpy10 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_11")]
public System.Nullable<float> Temperature11 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 3")]
[JsonProperty(PropertyName="enthalpy_11")]
public System.Nullable<float> Enthalpy11 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_12")]
public System.Nullable<float> Temperature12 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 14")]
[JsonProperty(PropertyName="enthalpy_12")]
public System.Nullable<float> Enthalpy12 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_13")]
public System.Nullable<float> Temperature13 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 15")]
[JsonProperty(PropertyName="enthalpy_13")]
public System.Nullable<float> Enthalpy13 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_14")]
public System.Nullable<float> Temperature14 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 16")]
[JsonProperty(PropertyName="enthalpy_14")]
public System.Nullable<float> Enthalpy14 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_15")]
public System.Nullable<float> Temperature15 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 17")]
[JsonProperty(PropertyName="enthalpy_15")]
public System.Nullable<float> Enthalpy15 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty(PropertyName="temperature_16")]
public System.Nullable<float> Temperature16 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 16")]
[JsonProperty(PropertyName="enthalpy_16")]
public System.Nullable<float> Enthalpy16 { get; set; } = null;
    }
    
    [Description(@"Additional properties for temperature dependent thermal conductivity and enthalpy for Phase Change Materials (PCM) with separate melting and freezing curves. HeatBalanceAlgorithm = CondFD (ConductionFiniteDifference) solution algorithm only. Constructions with this should use the detailed CondFD process. Has no effect with other HeatBalanceAlgorithm solution algorithms.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_PhaseChangeHysteresis : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("The total latent heat absorbed or rejected during the transition from solid to li" +
    "quid, or back")]
[JsonProperty(PropertyName="latent_heat_during_the_entire_phase_change_process")]
public System.Nullable<float> LatentHeatDuringTheEntirePhaseChangeProcess { get; set; } = null;
        

[Description("The thermal conductivity used by this material when the material is fully liquid")]
[JsonProperty(PropertyName="liquid_state_thermal_conductivity")]
public System.Nullable<float> LiquidStateThermalConductivity { get; set; } = null;
        

[Description("The density used by this material when the material is fully liquid")]
[JsonProperty(PropertyName="liquid_state_density")]
public System.Nullable<float> LiquidStateDensity { get; set; } = null;
        

[Description("The constant specific heat used for the fully melted (liquid) state")]
[JsonProperty(PropertyName="liquid_state_specific_heat")]
public System.Nullable<float> LiquidStateSpecificHeat { get; set; } = null;
        

[Description("The total melting range of the material is the sum of low and high temperature di" +
    "fference of melting curve.")]
[JsonProperty(PropertyName="high_temperature_difference_of_melting_curve")]
public System.Nullable<float> HighTemperatureDifferenceOfMeltingCurve { get; set; } = null;
        

[Description("The temperature at which the melting curve peaks")]
[JsonProperty(PropertyName="peak_melting_temperature")]
public System.Nullable<float> PeakMeltingTemperature { get; set; } = null;
        

[Description("The total melting range of the material is the sum of low and high temperature di" +
    "fference of melting curve.")]
[JsonProperty(PropertyName="low_temperature_difference_of_melting_curve")]
public System.Nullable<float> LowTemperatureDifferenceOfMeltingCurve { get; set; } = null;
        

[Description("The thermal conductivity used by this material when the material is fully solid")]
[JsonProperty(PropertyName="solid_state_thermal_conductivity")]
public System.Nullable<float> SolidStateThermalConductivity { get; set; } = null;
        

[Description("The density used by this material when the material is fully solid")]
[JsonProperty(PropertyName="solid_state_density")]
public System.Nullable<float> SolidStateDensity { get; set; } = null;
        

[Description("The constant specific heat used for the fully frozen (crystallized) state")]
[JsonProperty(PropertyName="solid_state_specific_heat")]
public System.Nullable<float> SolidStateSpecificHeat { get; set; } = null;
        

[Description("The total freezing range of the material is the sum of low and high temperature d" +
    "ifference of freezing curve.")]
[JsonProperty(PropertyName="high_temperature_difference_of_freezing_curve")]
public System.Nullable<float> HighTemperatureDifferenceOfFreezingCurve { get; set; } = null;
        

[Description("The temperature at which the freezing curve peaks")]
[JsonProperty(PropertyName="peak_freezing_temperature")]
public System.Nullable<float> PeakFreezingTemperature { get; set; } = null;
        

[Description("The total freezing range of the material is the sum of low and high temperature d" +
    "ifference of freezing curve.")]
[JsonProperty(PropertyName="low_temperature_difference_of_freezing_curve")]
public System.Nullable<float> LowTemperatureDifferenceOfFreezingCurve { get; set; } = null;
    }
    
    [Description(@"Additional properties for temperature dependent thermal conductivity using piecewise linear temperature-conductivity function. HeatBalanceAlgorithm = CondFD(ConductionFiniteDifference) solution algorithm only. Has no effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_VariableThermalConductivity : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty(PropertyName="temperature_1")]
public System.Nullable<float> Temperature1 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 1")]
[JsonProperty(PropertyName="thermal_conductivity_1")]
public System.Nullable<float> ThermalConductivity1 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty(PropertyName="temperature_2")]
public System.Nullable<float> Temperature2 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 2")]
[JsonProperty(PropertyName="thermal_conductivity_2")]
public System.Nullable<float> ThermalConductivity2 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty(PropertyName="temperature_3")]
public System.Nullable<float> Temperature3 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 3")]
[JsonProperty(PropertyName="thermal_conductivity_3")]
public System.Nullable<float> ThermalConductivity3 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty(PropertyName="temperature_4")]
public System.Nullable<float> Temperature4 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 4")]
[JsonProperty(PropertyName="thermal_conductivity_4")]
public System.Nullable<float> ThermalConductivity4 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty(PropertyName="temperature_5")]
public System.Nullable<float> Temperature5 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 5")]
[JsonProperty(PropertyName="thermal_conductivity_5")]
public System.Nullable<float> ThermalConductivity5 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty(PropertyName="temperature_6")]
public System.Nullable<float> Temperature6 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 6")]
[JsonProperty(PropertyName="thermal_conductivity_6")]
public System.Nullable<float> ThermalConductivity6 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty(PropertyName="temperature_7")]
public System.Nullable<float> Temperature7 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 7")]
[JsonProperty(PropertyName="thermal_conductivity_7")]
public System.Nullable<float> ThermalConductivity7 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty(PropertyName="temperature_8")]
public System.Nullable<float> Temperature8 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 8")]
[JsonProperty(PropertyName="thermal_conductivity_8")]
public System.Nullable<float> ThermalConductivity8 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty(PropertyName="temperature_9")]
public System.Nullable<float> Temperature9 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 9")]
[JsonProperty(PropertyName="thermal_conductivity_9")]
public System.Nullable<float> ThermalConductivity9 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty(PropertyName="temperature_10")]
public System.Nullable<float> Temperature10 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 10")]
[JsonProperty(PropertyName="thermal_conductivity_10")]
public System.Nullable<float> ThermalConductivity10 { get; set; } = null;
    }
    
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
        "ly. Additional material properties for surfaces. Has no effect with other HeatBa" +
        "lanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_HeatAndMoistureTransfer_Settings : BHoMObject
    {
        

[Description("Material Name that the moisture properties will be added to. This augments materi" +
    "al properties needed for combined heat and moisture transfer for surfaces.")]
[JsonProperty(PropertyName="material_name")]
public string MaterialName { get; set; } = "";
        

[JsonProperty(PropertyName="porosity")]
public System.Nullable<float> Porosity { get; set; } = null;
        

[Description("units are the water/material density ratio at the beginning of each run period.")]
[JsonProperty(PropertyName="initial_water_content_ratio")]
public System.Nullable<float> InitialWaterContentRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
    }
    
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
        "ly. Relationship between moisture content and relative humidity fraction. Has no" +
        " effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_HeatAndMoistureTransfer_SorptionIsotherm : BHoMObject
    {
        

[Description("The Material Name that the moisture sorption isotherm will be added to.")]
[JsonProperty(PropertyName="material_name")]
public string MaterialName { get; set; } = "";
        

[Description("Number of data Coordinates")]
[JsonProperty(PropertyName="number_of_isotherm_coordinates")]
public System.Nullable<float> NumberOfIsothermCoordinates { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_1")]
public System.Nullable<float> RelativeHumidityFraction1 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_1")]
public System.Nullable<float> MoistureContent1 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_2")]
public System.Nullable<float> RelativeHumidityFraction2 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_2")]
public System.Nullable<float> MoistureContent2 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_3")]
public System.Nullable<float> RelativeHumidityFraction3 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_3")]
public System.Nullable<float> MoistureContent3 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_4")]
public System.Nullable<float> RelativeHumidityFraction4 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_4")]
public System.Nullable<float> MoistureContent4 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_5")]
public System.Nullable<float> RelativeHumidityFraction5 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_5")]
public System.Nullable<float> MoistureContent5 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_6")]
public System.Nullable<float> RelativeHumidityFraction6 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_6")]
public System.Nullable<float> MoistureContent6 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_7")]
public System.Nullable<float> RelativeHumidityFraction7 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_7")]
public System.Nullable<float> MoistureContent7 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_8")]
public System.Nullable<float> RelativeHumidityFraction8 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_8")]
public System.Nullable<float> MoistureContent8 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_9")]
public System.Nullable<float> RelativeHumidityFraction9 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_9")]
public System.Nullable<float> MoistureContent9 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_10")]
public System.Nullable<float> RelativeHumidityFraction10 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_10")]
public System.Nullable<float> MoistureContent10 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_11")]
public System.Nullable<float> RelativeHumidityFraction11 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_11")]
public System.Nullable<float> MoistureContent11 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_12")]
public System.Nullable<float> RelativeHumidityFraction12 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_12")]
public System.Nullable<float> MoistureContent12 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_13")]
public System.Nullable<float> RelativeHumidityFraction13 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_13")]
public System.Nullable<float> MoistureContent13 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_14")]
public System.Nullable<float> RelativeHumidityFraction14 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_14")]
public System.Nullable<float> MoistureContent14 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_15")]
public System.Nullable<float> RelativeHumidityFraction15 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_15")]
public System.Nullable<float> MoistureContent15 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_16")]
public System.Nullable<float> RelativeHumidityFraction16 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_16")]
public System.Nullable<float> MoistureContent16 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_17")]
public System.Nullable<float> RelativeHumidityFraction17 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_17")]
public System.Nullable<float> MoistureContent17 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_18")]
public System.Nullable<float> RelativeHumidityFraction18 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_18")]
public System.Nullable<float> MoistureContent18 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_19")]
public System.Nullable<float> RelativeHumidityFraction19 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_19")]
public System.Nullable<float> MoistureContent19 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_20")]
public System.Nullable<float> RelativeHumidityFraction20 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_20")]
public System.Nullable<float> MoistureContent20 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_21")]
public System.Nullable<float> RelativeHumidityFraction21 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_21")]
public System.Nullable<float> MoistureContent21 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_22")]
public System.Nullable<float> RelativeHumidityFraction22 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_22")]
public System.Nullable<float> MoistureContent22 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_23")]
public System.Nullable<float> RelativeHumidityFraction23 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_23")]
public System.Nullable<float> MoistureContent23 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_24")]
public System.Nullable<float> RelativeHumidityFraction24 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_24")]
public System.Nullable<float> MoistureContent24 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_25")]
public System.Nullable<float> RelativeHumidityFraction25 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_25")]
public System.Nullable<float> MoistureContent25 { get; set; } = null;
    }
    
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
        "ly. Relationship between liquid suction transport coefficient and moisture conte" +
        "nt Has no effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_HeatAndMoistureTransfer_Suction : BHoMObject
    {
        

[Description("Material Name that the moisture properties will be added to.")]
[JsonProperty(PropertyName="material_name")]
public string MaterialName { get; set; } = "";
        

[Description("Number of Suction Liquid Transport Coefficient coordinates")]
[JsonProperty(PropertyName="number_of_suction_points")]
public System.Nullable<float> NumberOfSuctionPoints { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_1")]
public System.Nullable<float> MoistureContent1 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_1")]
public System.Nullable<float> LiquidTransportCoefficient1 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_2")]
public System.Nullable<float> MoistureContent2 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_2")]
public System.Nullable<float> LiquidTransportCoefficient2 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_3")]
public System.Nullable<float> MoistureContent3 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_3")]
public System.Nullable<float> LiquidTransportCoefficient3 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_4")]
public System.Nullable<float> MoistureContent4 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_4")]
public System.Nullable<float> LiquidTransportCoefficient4 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_5")]
public System.Nullable<float> MoistureContent5 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_5")]
public System.Nullable<float> LiquidTransportCoefficient5 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_6")]
public System.Nullable<float> MoistureContent6 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_6")]
public System.Nullable<float> LiquidTransportCoefficient6 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_7")]
public System.Nullable<float> MoistureContent7 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_7")]
public System.Nullable<float> LiquidTransportCoefficient7 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_8")]
public System.Nullable<float> MoistureContent8 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_8")]
public System.Nullable<float> LiquidTransportCoefficient8 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_9")]
public System.Nullable<float> MoistureContent9 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_9")]
public System.Nullable<float> LiquidTransportCoefficient9 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_10")]
public System.Nullable<float> MoistureContent10 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_10")]
public System.Nullable<float> LiquidTransportCoefficient10 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_11")]
public System.Nullable<float> MoistureContent11 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_11")]
public System.Nullable<float> LiquidTransportCoefficient11 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_12")]
public System.Nullable<float> MoistureContent12 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_12")]
public System.Nullable<float> LiquidTransportCoefficient12 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_13")]
public System.Nullable<float> MoistureContent13 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_13")]
public System.Nullable<float> LiquidTransportCoefficient13 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_14")]
public System.Nullable<float> MoistureContent14 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_14")]
public System.Nullable<float> LiquidTransportCoefficient14 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_15")]
public System.Nullable<float> MoistureContent15 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_15")]
public System.Nullable<float> LiquidTransportCoefficient15 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_16")]
public System.Nullable<float> MoistureContent16 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_16")]
public System.Nullable<float> LiquidTransportCoefficient16 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_17")]
public System.Nullable<float> MoistureContent17 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_17")]
public System.Nullable<float> LiquidTransportCoefficient17 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_18")]
public System.Nullable<float> MoistureContent18 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_18")]
public System.Nullable<float> LiquidTransportCoefficient18 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_19")]
public System.Nullable<float> MoistureContent19 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_19")]
public System.Nullable<float> LiquidTransportCoefficient19 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_20")]
public System.Nullable<float> MoistureContent20 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_20")]
public System.Nullable<float> LiquidTransportCoefficient20 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_21")]
public System.Nullable<float> MoistureContent21 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_21")]
public System.Nullable<float> LiquidTransportCoefficient21 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_22")]
public System.Nullable<float> MoistureContent22 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_22")]
public System.Nullable<float> LiquidTransportCoefficient22 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_23")]
public System.Nullable<float> MoistureContent23 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_23")]
public System.Nullable<float> LiquidTransportCoefficient23 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_24")]
public System.Nullable<float> MoistureContent24 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_24")]
public System.Nullable<float> LiquidTransportCoefficient24 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_25")]
public System.Nullable<float> MoistureContent25 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_25")]
public System.Nullable<float> LiquidTransportCoefficient25 { get; set; } = null;
    }
    
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
        "ly. Relationship between liquid transport coefficient and moisture content Has n" +
        "o effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_HeatAndMoistureTransfer_Redistribution : BHoMObject
    {
        

[Description("Moisture Material Name that the moisture properties will be added to.")]
[JsonProperty(PropertyName="material_name")]
public string MaterialName { get; set; } = "";
        

[Description("number of data points")]
[JsonProperty(PropertyName="number_of_redistribution_points")]
public System.Nullable<float> NumberOfRedistributionPoints { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_1")]
public System.Nullable<float> MoistureContent1 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_1")]
public System.Nullable<float> LiquidTransportCoefficient1 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_2")]
public System.Nullable<float> MoistureContent2 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_2")]
public System.Nullable<float> LiquidTransportCoefficient2 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_3")]
public System.Nullable<float> MoistureContent3 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_3")]
public System.Nullable<float> LiquidTransportCoefficient3 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_4")]
public System.Nullable<float> MoistureContent4 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_4")]
public System.Nullable<float> LiquidTransportCoefficient4 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_5")]
public System.Nullable<float> MoistureContent5 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_5")]
public System.Nullable<float> LiquidTransportCoefficient5 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_6")]
public System.Nullable<float> MoistureContent6 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_6")]
public System.Nullable<float> LiquidTransportCoefficient6 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_7")]
public System.Nullable<float> MoistureContent7 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_7")]
public System.Nullable<float> LiquidTransportCoefficient7 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_8")]
public System.Nullable<float> MoistureContent8 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_8")]
public System.Nullable<float> LiquidTransportCoefficient8 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_9")]
public System.Nullable<float> MoistureContent9 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_9")]
public System.Nullable<float> LiquidTransportCoefficient9 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_10")]
public System.Nullable<float> MoistureContent10 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_10")]
public System.Nullable<float> LiquidTransportCoefficient10 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_11")]
public System.Nullable<float> MoistureContent11 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_11")]
public System.Nullable<float> LiquidTransportCoefficient11 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_12")]
public System.Nullable<float> MoistureContent12 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_12")]
public System.Nullable<float> LiquidTransportCoefficient12 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_13")]
public System.Nullable<float> MoistureContent13 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_13")]
public System.Nullable<float> LiquidTransportCoefficient13 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_14")]
public System.Nullable<float> MoistureContent14 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_14")]
public System.Nullable<float> LiquidTransportCoefficient14 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_15")]
public System.Nullable<float> MoistureContent15 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_15")]
public System.Nullable<float> LiquidTransportCoefficient15 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_16")]
public System.Nullable<float> MoistureContent16 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_16")]
public System.Nullable<float> LiquidTransportCoefficient16 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_17")]
public System.Nullable<float> MoistureContent17 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_17")]
public System.Nullable<float> LiquidTransportCoefficient17 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_18")]
public System.Nullable<float> MoistureContent18 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_18")]
public System.Nullable<float> LiquidTransportCoefficient18 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_19")]
public System.Nullable<float> MoistureContent19 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_19")]
public System.Nullable<float> LiquidTransportCoefficient19 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_20")]
public System.Nullable<float> MoistureContent20 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_20")]
public System.Nullable<float> LiquidTransportCoefficient20 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_21")]
public System.Nullable<float> MoistureContent21 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_21")]
public System.Nullable<float> LiquidTransportCoefficient21 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_22")]
public System.Nullable<float> MoistureContent22 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_22")]
public System.Nullable<float> LiquidTransportCoefficient22 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_23")]
public System.Nullable<float> MoistureContent23 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_23")]
public System.Nullable<float> LiquidTransportCoefficient23 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_24")]
public System.Nullable<float> MoistureContent24 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_24")]
public System.Nullable<float> LiquidTransportCoefficient24 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_25")]
public System.Nullable<float> MoistureContent25 { get; set; } = null;
        

[JsonProperty(PropertyName="liquid_transport_coefficient_25")]
public System.Nullable<float> LiquidTransportCoefficient25 { get; set; } = null;
    }
    
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
        "ly. Relationship between water vapor diffusion and relative humidity fraction Ha" +
        "s no effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_HeatAndMoistureTransfer_Diffusion : BHoMObject
    {
        

[Description("Moisture Material Name that the moisture properties will be added to.")]
[JsonProperty(PropertyName="material_name")]
public string MaterialName { get; set; } = "";
        

[Description("Water Vapor Diffusion Resistance Factor")]
[JsonProperty(PropertyName="number_of_data_pairs")]
public System.Nullable<float> NumberOfDataPairs { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_1")]
public System.Nullable<float> RelativeHumidityFraction1 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_1")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor1 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_2")]
public System.Nullable<float> RelativeHumidityFraction2 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_2")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor2 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_3")]
public System.Nullable<float> RelativeHumidityFraction3 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_3")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor3 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_4")]
public System.Nullable<float> RelativeHumidityFraction4 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_4")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor4 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_5")]
public System.Nullable<float> RelativeHumidityFraction5 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_5")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor5 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_6")]
public System.Nullable<float> RelativeHumidityFraction6 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_6")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor6 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_7")]
public System.Nullable<float> RelativeHumidityFraction7 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_7")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor7 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_8")]
public System.Nullable<float> RelativeHumidityFraction8 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_8")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor8 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_9")]
public System.Nullable<float> RelativeHumidityFraction9 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_9")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor9 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_10")]
public System.Nullable<float> RelativeHumidityFraction10 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_10")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor10 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_11")]
public System.Nullable<float> RelativeHumidityFraction11 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_11")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor11 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_12")]
public System.Nullable<float> RelativeHumidityFraction12 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_12")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor12 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_13")]
public System.Nullable<float> RelativeHumidityFraction13 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_13")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor13 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_14")]
public System.Nullable<float> RelativeHumidityFraction14 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_14")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor14 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_15")]
public System.Nullable<float> RelativeHumidityFraction15 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_15")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor15 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_16")]
public System.Nullable<float> RelativeHumidityFraction16 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_16")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor16 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_17")]
public System.Nullable<float> RelativeHumidityFraction17 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_17")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor17 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_18")]
public System.Nullable<float> RelativeHumidityFraction18 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_18")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor18 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_19")]
public System.Nullable<float> RelativeHumidityFraction19 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_19")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor19 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_20")]
public System.Nullable<float> RelativeHumidityFraction20 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_20")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor20 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_21")]
public System.Nullable<float> RelativeHumidityFraction21 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_21")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor21 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_22")]
public System.Nullable<float> RelativeHumidityFraction22 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_22")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor22 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_23")]
public System.Nullable<float> RelativeHumidityFraction23 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_23")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor23 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_24")]
public System.Nullable<float> RelativeHumidityFraction24 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_24")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor24 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty(PropertyName="relative_humidity_fraction_25")]
public System.Nullable<float> RelativeHumidityFraction25 { get; set; } = null;
        

[JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_25")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor25 { get; set; } = null;
    }
    
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
        "ly. Relationship between thermal conductivity and moisture content Has no effect" +
        " with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_HeatAndMoistureTransfer_ThermalConductivity : BHoMObject
    {
        

[Description("Moisture Material Name that the Thermal Conductivity will be added to.")]
[JsonProperty(PropertyName="material_name")]
public string MaterialName { get; set; } = "";
        

[Description("number of data coordinates")]
[JsonProperty(PropertyName="number_of_thermal_coordinates")]
public System.Nullable<float> NumberOfThermalCoordinates { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_1")]
public System.Nullable<float> MoistureContent1 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_1")]
public System.Nullable<float> ThermalConductivity1 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_2")]
public System.Nullable<float> MoistureContent2 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_2")]
public System.Nullable<float> ThermalConductivity2 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_3")]
public System.Nullable<float> MoistureContent3 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_3")]
public System.Nullable<float> ThermalConductivity3 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_4")]
public System.Nullable<float> MoistureContent4 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_4")]
public System.Nullable<float> ThermalConductivity4 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_5")]
public System.Nullable<float> MoistureContent5 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_5")]
public System.Nullable<float> ThermalConductivity5 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_6")]
public System.Nullable<float> MoistureContent6 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_6")]
public System.Nullable<float> ThermalConductivity6 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_7")]
public System.Nullable<float> MoistureContent7 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_7")]
public System.Nullable<float> ThermalConductivity7 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_8")]
public System.Nullable<float> MoistureContent8 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_8")]
public System.Nullable<float> ThermalConductivity8 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_9")]
public System.Nullable<float> MoistureContent9 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_9")]
public System.Nullable<float> ThermalConductivity9 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_10")]
public System.Nullable<float> MoistureContent10 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_10")]
public System.Nullable<float> ThermalConductivity10 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_11")]
public System.Nullable<float> MoistureContent11 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_11")]
public System.Nullable<float> ThermalConductivity11 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_12")]
public System.Nullable<float> MoistureContent12 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_12")]
public System.Nullable<float> ThermalConductivity12 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_13")]
public System.Nullable<float> MoistureContent13 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_13")]
public System.Nullable<float> ThermalConductivity13 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_14")]
public System.Nullable<float> MoistureContent14 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_14")]
public System.Nullable<float> ThermalConductivity14 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_15")]
public System.Nullable<float> MoistureContent15 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_15")]
public System.Nullable<float> ThermalConductivity15 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_16")]
public System.Nullable<float> MoistureContent16 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_16")]
public System.Nullable<float> ThermalConductivity16 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_17")]
public System.Nullable<float> MoistureContent17 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_17")]
public System.Nullable<float> ThermalConductivity17 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_18")]
public System.Nullable<float> MoistureContent18 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_18")]
public System.Nullable<float> ThermalConductivity18 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_19")]
public System.Nullable<float> MoistureContent19 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_19")]
public System.Nullable<float> ThermalConductivity19 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_20")]
public System.Nullable<float> MoistureContent20 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_20")]
public System.Nullable<float> ThermalConductivity20 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_21")]
public System.Nullable<float> MoistureContent21 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_21")]
public System.Nullable<float> ThermalConductivity21 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_22")]
public System.Nullable<float> MoistureContent22 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_22")]
public System.Nullable<float> ThermalConductivity22 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_23")]
public System.Nullable<float> MoistureContent23 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_23")]
public System.Nullable<float> ThermalConductivity23 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_24")]
public System.Nullable<float> MoistureContent24 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_24")]
public System.Nullable<float> ThermalConductivity24 { get; set; } = null;
        

[JsonProperty(PropertyName="moisture_content_25")]
public System.Nullable<float> MoistureContent25 { get; set; } = null;
        

[JsonProperty(PropertyName="thermal_conductivity_25")]
public System.Nullable<float> ThermalConductivity25 { get; set; } = null;
    }
    
    [Description("Name is followed by up to 800 sets of normal-incidence measured values of [wavele" +
        "ngth, transmittance, front reflectance, back reflectance] for wavelengths coveri" +
        "ng the solar spectrum (from about 0.25 to 2.5 microns)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_GlazingSpectralData : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="wavelength_1")]
public System.Nullable<float> Wavelength1 { get; set; } = null;
        

[JsonProperty(PropertyName="transmittance_1")]
public System.Nullable<float> Transmittance1 { get; set; } = null;
        

[JsonProperty(PropertyName="front_reflectance_1")]
public System.Nullable<float> FrontReflectance1 { get; set; } = null;
        

[JsonProperty(PropertyName="back_reflectance_1")]
public System.Nullable<float> BackReflectance1 { get; set; } = null;
        

[JsonProperty(PropertyName="wavelength_2")]
public System.Nullable<float> Wavelength2 { get; set; } = null;
        

[JsonProperty(PropertyName="transmittance_2")]
public System.Nullable<float> Transmittance2 { get; set; } = null;
        

[JsonProperty(PropertyName="front_reflectance_2")]
public System.Nullable<float> FrontReflectance2 { get; set; } = null;
        

[JsonProperty(PropertyName="back_reflectance_2")]
public System.Nullable<float> BackReflectance2 { get; set; } = null;
        

[JsonProperty(PropertyName="wavelength_3")]
public System.Nullable<float> Wavelength3 { get; set; } = null;
        

[JsonProperty(PropertyName="transmittance_3")]
public System.Nullable<float> Transmittance3 { get; set; } = null;
        

[JsonProperty(PropertyName="front_reflectance_3")]
public System.Nullable<float> FrontReflectance3 { get; set; } = null;
        

[JsonProperty(PropertyName="back_reflectance_3")]
public System.Nullable<float> BackReflectance3 { get; set; } = null;
        

[JsonProperty(PropertyName="wavelength_4")]
public System.Nullable<float> Wavelength4 { get; set; } = null;
        

[JsonProperty(PropertyName="transmittance_4")]
public System.Nullable<float> Transmittance4 { get; set; } = null;
        

[JsonProperty(PropertyName="front_reflectance_4")]
public System.Nullable<float> FrontReflectance4 { get; set; } = null;
        

[JsonProperty(PropertyName="back_reflectance_4")]
public System.Nullable<float> BackReflectance4 { get; set; } = null;
        

[JsonProperty(PropertyName="extensions")]
public string Extensions { get; set; } = "";
    }
    
    [Description("Start with outside layer and work your way to the inside layer Up to 10 layers to" +
        "tal, 8 for windows Enter the material name for each layer")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="outside_layer")]
public string OutsideLayer { get; set; } = "";
        

[JsonProperty(PropertyName="layer_2")]
public string Layer2 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_3")]
public string Layer3 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_4")]
public string Layer4 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_5")]
public string Layer5 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_6")]
public string Layer6 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_7")]
public string Layer7 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_8")]
public string Layer8 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_9")]
public string Layer9 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_10")]
public string Layer10 { get; set; } = "";
    }
    
    [Description("Alternate method of describing underground wall constructions")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction_CfactorUndergroundWall : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Enter C-Factor without film coefficients or soil")]
[JsonProperty(PropertyName="c_factor")]
public System.Nullable<float> CFactor { get; set; } = null;
        

[Description("Enter height of the underground wall")]
[JsonProperty(PropertyName="height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("Alternate method of describing slab-on-grade or underground floor constructions")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction_FfactorGroundFloor : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="f_factor")]
public System.Nullable<float> FFactor { get; set; } = null;
        

[Description("Enter area of the floor")]
[JsonProperty(PropertyName="area")]
public System.Nullable<float> Area { get; set; } = null;
        

[Description("Enter exposed perimeter of the floor")]
[JsonProperty(PropertyName="perimeterexposed")]
public System.Nullable<float> Perimeterexposed { get; set; } = null;
    }
    
    [Description("Internal heat source to be attached to a construction layer")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ConstructionProperty_InternalHeatSource : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("refers to the list of materials which follows")]
[JsonProperty(PropertyName="thermal_source_present_after_layer_number")]
public System.Nullable<float> ThermalSourcePresentAfterLayerNumber { get; set; } = null;
        

[Description("refers to the list of materials which follows")]
[JsonProperty(PropertyName="temperature_calculation_requested_after_layer_number")]
public System.Nullable<float> TemperatureCalculationRequestedAfterLayerNumber { get; set; } = null;
        

[Description("1 = 1-dimensional calculation, 2 = 2-dimensional calculation")]
[JsonProperty(PropertyName="dimensions_for_the_ctf_calculation")]
public System.Nullable<float> DimensionsForTheCtfCalculation { get; set; } = null;
        

[Description("uniform spacing between tubes or resistance wires in direction perpendicular to m" +
    "ain intended direction of heat transfer")]
[JsonProperty(PropertyName="tube_spacing")]
public System.Nullable<float> TubeSpacing { get; set; } = null;
        

[Description(@"used in conjunction with field Temperature Calculation Requested After Layer Number this field is the location perpendicular to the main direction of heat transfer 0.0 means in line with the tubing, 1.0 means at the midpoint between two adjacent pipes this field is ignored for 1-D calculations")]
[JsonProperty(PropertyName="two_dimensional_temperature_calculation_position")]
public System.Nullable<float> TwoDimensionalTemperatureCalculationPosition { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description(@"Indicates an open boundary between two zones. It may be used for base surfaces and fenestration surfaces. The two adjacent zones are grouped together for solar, daylighting and radiant exchange. When this construction type is used, the Outside Boundary Condition of the surface (or the base surface of a fenestration surface) must be either Surface or Zone. A base surface with Construction:AirBoundary cannot hold any fenestration surfaces.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction_AirBoundary : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("This field controls how air exchange is modeled across this boundary.")]
[JsonProperty(PropertyName="air_exchange_method", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Construction_AirBoundary_AirExchangeMethod AirExchangeMethod { get; set; } = (Construction_AirBoundary_AirExchangeMethod)Enum.Parse(typeof(Construction_AirBoundary_AirExchangeMethod), "None");
        

[Description("If the Air Exchange Method is SimpleMixing then this field specifies the air chan" +
    "ges per hour using the volume of the smaller zone as the basis. If an AirflowNet" +
    "work simulation is active this field is ignored.")]
[JsonProperty(PropertyName="simple_mixing_air_changes_per_hour")]
public System.Nullable<float> SimpleMixingAirChangesPerHour { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("If the Air Exchange Method is SimpleMixing then this field specifies the air exch" +
    "ange schedule. If this field is blank, the schedule is always 1.0. If an Airflow" +
    "Network simulation is active this field is ignored.")]
[JsonProperty(PropertyName="simple_mixing_schedule_name")]
public string SimpleMixingScheduleName { get; set; } = "";
    }
    
    public enum Construction_AirBoundary_AirExchangeMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SimpleMixing")]
        SimpleMixing = 2,
    }
    
    [Description("object is used to select which thermal model should be used in tarcog simulations" +
        "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowThermalModel_Params : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="standard", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowThermalModel_Params_Standard Standard { get; set; } = (WindowThermalModel_Params_Standard)Enum.Parse(typeof(WindowThermalModel_Params_Standard), "ISO15099");
        

[JsonProperty(PropertyName="thermal_model", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowThermalModel_Params_ThermalModel ThermalModel { get; set; } = (WindowThermalModel_Params_ThermalModel)Enum.Parse(typeof(WindowThermalModel_Params_ThermalModel), "ISO15099");
        

[JsonProperty(PropertyName="sdscalar")]
public System.Nullable<float> Sdscalar { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="deflection_model", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowThermalModel_Params_DeflectionModel DeflectionModel { get; set; } = (WindowThermalModel_Params_DeflectionModel)Enum.Parse(typeof(WindowThermalModel_Params_DeflectionModel), "NoDeflection");
        

[JsonProperty(PropertyName="vacuum_pressure_limit")]
public System.Nullable<float> VacuumPressureLimit { get; set; } = (System.Nullable<float>)Single.Parse("13.238", CultureInfo.InvariantCulture);
        

[Description("This is temperature in time of window fabrication")]
[JsonProperty(PropertyName="initial_temperature")]
public System.Nullable<float> InitialTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25", CultureInfo.InvariantCulture);
        

[Description("This is pressure in time of window fabrication")]
[JsonProperty(PropertyName="initial_pressure")]
public System.Nullable<float> InitialPressure { get; set; } = (System.Nullable<float>)Single.Parse("101325", CultureInfo.InvariantCulture);
    }
    
    public enum WindowThermalModel_Params_Standard
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="EN673Declared")]
        EN673Declared = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="EN673Design")]
        EN673Design = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ISO15099")]
        ISO15099 = 3,
    }
    
    public enum WindowThermalModel_Params_ThermalModel
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConvectiveScalarModel_NoSDThickness")]
        ConvectiveScalarModelNoSDThickness = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ConvectiveScalarModel_withSDThickness")]
        ConvectiveScalarModelWithSDThickness = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ISO15099")]
        ISO15099 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ScaledCavityWidth")]
        ScaledCavityWidth = 4,
    }
    
    public enum WindowThermalModel_Params_DeflectionModel
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeasuredDeflection")]
        MeasuredDeflection = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="NoDeflection")]
        NoDeflection = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureAndPressureInput")]
        TemperatureAndPressureInput = 3,
    }
    
    [Description(@"Describes which window model will be used in calculations. Built in windows model will use algorithms that are part of EnergyPlus, while ExternalWindowsModel will use Windows-CalcEngine library to perform optical and thermal performances of windows and doors.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowsCalculationEngine : BHoMObject
    {
        

[JsonProperty(PropertyName="windows_engine", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WindowsCalculationEngine_WindowsEngine WindowsEngine { get; set; } = (WindowsCalculationEngine_WindowsEngine)Enum.Parse(typeof(WindowsCalculationEngine_WindowsEngine), "BuiltInWindowsModel");
    }
    
    public enum WindowsCalculationEngine_WindowsEngine
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BuiltInWindowsModel")]
        BuiltInWindowsModel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ExternalWindowsModel")]
        ExternalWindowsModel = 2,
    }
    
    [Description("Describes one state for a complex glazing system These input objects are typicall" +
        "y generated by using WINDOW software and export to IDF syntax")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction_ComplexFenestrationState : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="basis_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Construction_ComplexFenestrationState_BasisType BasisType { get; set; } = (Construction_ComplexFenestrationState_BasisType)Enum.Parse(typeof(Construction_ComplexFenestrationState_BasisType), "LBNLWINDOW");
        

[JsonProperty(PropertyName="basis_symmetry_type", ItemConverterType=typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Construction_ComplexFenestrationState_BasisSymmetryType BasisSymmetryType { get; set; } = (Construction_ComplexFenestrationState_BasisSymmetryType)Enum.Parse(typeof(Construction_ComplexFenestrationState_BasisSymmetryType), "None");
        

[JsonProperty(PropertyName="window_thermal_model")]
public string WindowThermalModel { get; set; } = "";
        

[JsonProperty(PropertyName="basis_matrix_name")]
public string BasisMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="solar_optical_complex_front_transmittance_matrix_name")]
public string SolarOpticalComplexFrontTransmittanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="solar_optical_complex_back_reflectance_matrix_name")]
public string SolarOpticalComplexBackReflectanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="visible_optical_complex_front_transmittance_matrix_name")]
public string VisibleOpticalComplexFrontTransmittanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="visible_optical_complex_back_transmittance_matrix_name")]
public string VisibleOpticalComplexBackTransmittanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="outside_layer_name")]
public string OutsideLayerName { get; set; } = "";
        

[JsonProperty(PropertyName="outside_layer_directional_front_absoptance_matrix_name")]
public string OutsideLayerDirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="outside_layer_directional_back_absoptance_matrix_name")]
public string OutsideLayerDirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="gap_1_name")]
public string Gap1Name { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty(PropertyName="cfs_gap_1_directional_front_absoptance_matrix_name")]
public string CfsGap1DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty(PropertyName="cfs_gap_1_directional_back_absoptance_matrix_name")]
public string CfsGap1DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="layer_2_name")]
public string Layer2Name { get; set; } = "";
        

[JsonProperty(PropertyName="layer_2_directional_front_absoptance_matrix_name")]
public string Layer2DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="layer_2_directional_back_absoptance_matrix_name")]
public string Layer2DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="gap_2_name")]
public string Gap2Name { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty(PropertyName="gap_2_directional_front_absoptance_matrix_name")]
public string Gap2DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty(PropertyName="gap_2_directional_back_absoptance_matrix_name")]
public string Gap2DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="layer_3_material")]
public string Layer3Material { get; set; } = "";
        

[JsonProperty(PropertyName="layer_3_directional_front_absoptance_matrix_name")]
public string Layer3DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="layer_3_directional_back_absoptance_matrix_name")]
public string Layer3DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="gap_3_name")]
public string Gap3Name { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty(PropertyName="gap_3_directional_front_absoptance_matrix_name")]
public string Gap3DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty(PropertyName="gap_3_directional_back_absoptance_matrix_name")]
public string Gap3DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="layer_4_name")]
public string Layer4Name { get; set; } = "";
        

[JsonProperty(PropertyName="layer_4_directional_front_absoptance_matrix_name")]
public string Layer4DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="layer_4_directional_back_absoptance_matrix_name")]
public string Layer4DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="gap_4_name")]
public string Gap4Name { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty(PropertyName="gap_4_directional_front_absoptance_matrix_name")]
public string Gap4DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty(PropertyName="gap_4_directional_back_absoptance_matrix_name")]
public string Gap4DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="layer_5_name")]
public string Layer5Name { get; set; } = "";
        

[JsonProperty(PropertyName="layer_5_directional_front_absoptance_matrix_name")]
public string Layer5DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty(PropertyName="layer_5_directional_back_absoptance_matrix_name")]
public string Layer5DirectionalBackAbsoptanceMatrixName { get; set; } = "";
    }
    
    public enum Construction_ComplexFenestrationState_BasisType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LBNLWINDOW")]
        LBNLWINDOW = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="UserDefined")]
        UserDefined = 2,
    }
    
    public enum Construction_ComplexFenestrationState_BasisSymmetryType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Axisymmetric")]
        Axisymmetric = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 2,
    }
    
    [Description("Start with outside layer and work your way to the inside Layer Up to 11 layers to" +
        "tal. Up to six solid layers and up to five gaps. Enter the material name for eac" +
        "h layer")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction_WindowEquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="outside_layer")]
public string OutsideLayer { get; set; } = "";
        

[JsonProperty(PropertyName="layer_2")]
public string Layer2 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_3")]
public string Layer3 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_4")]
public string Layer4 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_5")]
public string Layer5 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_6")]
public string Layer6 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_7")]
public string Layer7 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_8")]
public string Layer8 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_9")]
public string Layer9 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_10")]
public string Layer10 { get; set; } = "";
        

[JsonProperty(PropertyName="layer_11")]
public string Layer11 { get; set; } = "";
    }
    
    [Description("Initiates search of the Window data file for a window called Name.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction_WindowDataFile : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("default file name is \"Window5DataFile.dat\" limit on this field is 100 characters." +
    "")]
[JsonProperty(PropertyName="file_name")]
public string FileName { get; set; } = "";
    }
}
