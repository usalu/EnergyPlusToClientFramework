//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Converters;
//using NJsonSchema;
//using NJsonSchema.Annotations;

//namespace EPJsonClientCodeGenerator
//{
//    public partial class EPJsonSchema
//    {
//        [JsonProperty("$schema")]
//        public Uri Schema { get; set; }

//        [JsonProperty("properties")]
//        public Dictionary<string, EPJsonSchemaProperty> Properties { get; set; }

//        [JsonProperty("required")]
//        public string[] EPJsonSchemaRequired { get; set; }

//        [JsonProperty("epJSON_schema_version")]
//        public string EpJsonSchemaVersion { get; set; }

//        [JsonProperty("epJSON_schema_build")]
//        public string EpJsonSchemaBuild { get; set; }
//    }

//    public partial class EPJsonSchemaProperty
//    {
//        [JsonProperty("patternProperties")]
//        public PatternProperties PatternProperties { get; set; }

//        [JsonProperty("group")]
//        public string Group { get; set; }

//        [JsonProperty("legacy_idd")]
//        public LegacyIdd LegacyIdd { get; set; }

//        [JsonProperty("type")]
//        public ItemsType Type { get; set; }

//        [JsonProperty("maxProperties", NullValueHandling = NullValueHandling.Ignore)]
//        public long? MaxProperties { get; set; }

//        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
//        public string Memo { get; set; }

//        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
//        public Format? Format { get; set; }

//        [JsonProperty("min_fields", NullValueHandling = NullValueHandling.Ignore)]
//        public double? MinFields { get; set; }

//        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
//        public Name Name { get; set; }

//        [JsonProperty("minProperties", NullValueHandling = NullValueHandling.Ignore)]
//        public long? MinProperties { get; set; }

//        [JsonProperty("extensible_size", NullValueHandling = NullValueHandling.Ignore)]
//        public double? ExtensibleSize { get; set; }

//        [JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? AdditionalProperties { get; set; }
//    }

//    public partial class LegacyIdd
//    {
//        [JsonProperty("field_info")]
//        public Dictionary<string, FieldInfo> FieldInfo { get; set; }

//        [JsonProperty("fields")]
//        public string[] Fields { get; set; }

//        [JsonProperty("alphas")]
//        public Alphas Alphas { get; set; }

//        [JsonProperty("numerics")]
//        public Alphas Numerics { get; set; }

//        [JsonProperty("extensibles", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] Extensibles { get; set; }

//        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
//        public string Extension { get; set; }
//    }

//    public partial class Alphas
//    {
//        [JsonProperty("fields")]
//        public string[] Fields { get; set; }

//        [JsonProperty("extensions", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] Extensions { get; set; }
//    }

//    public partial class FieldInfo
//    {
//        [JsonProperty("field_name")]
//        public string FieldName { get; set; }

//        [JsonProperty("field_type")]
//        public FieldType FieldType { get; set; }
//    }

//    public partial class Name
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("retaincase", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? Retaincase { get; set; }

//        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
//        public string Default { get; set; }

//        [JsonProperty("is_required", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? IsRequired { get; set; }

//        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] Reference { get; set; }

//        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
//        public string Note { get; set; }

//        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
//        public DataType? DataType { get; set; }

//        [JsonProperty("object_list", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] ObjectList { get; set; }

//        [JsonProperty("reference-class-name", NullValueHandling = NullValueHandling.Ignore)]
//        public ReferenceClassName[] ReferenceClassName { get; set; }
//    }

//    public partial class PatternProperties
//    {
//        [JsonProperty(".*", NullValueHandling = NullValueHandling.Ignore)]
//        public OptionalField OptionalField { get; set; }

//        [JsonProperty("^.*\\S.*$", NullValueHandling = NullValueHandling.Ignore)]
//        public NecessaryField NecessaryField { get; set; }
//    }

//    public partial class OptionalField
//    {
//        [JsonProperty("type")]
//        public ItemsType Type { get; set; }

//        [JsonProperty("properties")]
//        public Dictionary<string, Property> Properties { get; set; }

//        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] PurpleRequired { get; set; }
//    }

//    public partial class Property : SProperty
//    {
//        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
//        public EPFieldType? Type { get; set; }

//        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
//        public Default? Default { get; set; }

//        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
//        public string Note { get; set; }

//        [JsonProperty("enum", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] Enum { get; set; }

//        [JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Minimum { get; set; }

//        [JsonProperty("maximum", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Maximum { get; set; }

//        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
//        public string Units { get; set; }

//        [JsonProperty("exclusiveMinimum", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? ExclusiveMinimum { get; set; }

//        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
//        public PurpleItems Items { get; set; }

//        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
//        public DataType? DataType { get; set; }

//        [JsonProperty("object_list", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] ObjectList { get; set; }

//        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] Reference { get; set; }

//        [JsonProperty("retaincase", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? Retaincase { get; set; }

//        [JsonProperty("anyOf", NullValueHandling = NullValueHandling.Ignore)]
//        public PropertyAnyOf[] AnyOf { get; set; }

//        [JsonProperty("exclusiveMaximum", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? ExclusiveMaximum { get; set; }

//        [JsonProperty("ip-units", NullValueHandling = NullValueHandling.Ignore)]
//        public string IpUnits { get; set; }

//        [JsonProperty("external_list", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] ExternalList { get; set; }

//        [JsonProperty("unitsBasedOnField", NullValueHandling = NullValueHandling.Ignore)]
//        public PurpleUnitsBasedOnField? UnitsBasedOnField { get; set; }
//    }

//    public partial class PropertyAnyOf
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Minimum { get; set; }

//        [JsonProperty("exclusiveMinimum", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? ExclusiveMinimum { get; set; }

//        [JsonProperty("enum", NullValueHandling = NullValueHandling.Ignore)]
//        public EnumUnion[] Enum { get; set; }

//        [JsonProperty("maximum", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Maximum { get; set; }

//        [JsonProperty("exclusiveMaximum", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? ExclusiveMaximum { get; set; }
//    }

//    public partial class PurpleItems
//    {
//        [JsonProperty("properties")]
//        public PurpleProperties Properties { get; set; }

//        [JsonProperty("type")]
//        public ItemsType Type { get; set; }

//        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] ItemsRequired { get; set; }
//    }

//    public partial class PurpleProperties
//    {
//        [JsonProperty("shading_zone_group_zonelist_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ShadingZoneGroupZonelistName { get; set; }

//        [JsonProperty("surface_segment_exposed", NullValueHandling = NullValueHandling.Ignore)]
//        public PerformRun SurfaceSegmentExposed { get; set; }

//        [JsonProperty("surface_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko SurfaceName { get; set; }

//        [JsonProperty("surface_view_factor", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog SurfaceViewFactor { get; set; }

//        [JsonProperty("from_surface", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko FromSurface { get; set; }

//        [JsonProperty("to_surface", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ToSurface { get; set; }

//        [JsonProperty("view_factor", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ViewFactor { get; set; }

//        [JsonProperty("internal_gain_object_type", NullValueHandling = NullValueHandling.Ignore)]
//        public InternalGainObjectType InternalGainObjectType { get; set; }

//        [JsonProperty("internal_gain_object_name", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl InternalGainObjectName { get; set; }

//        [JsonProperty("fraction_of_gains_to_node", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog FractionOfGainsToNode { get; set; }

//        [JsonProperty("zonehvac_or_air_terminal_equipment_object_type", NullValueHandling = NullValueHandling.Ignore)]
//        public InternalGainObjectType ZonehvacOrAirTerminalEquipmentObjectType { get; set; }

//        [JsonProperty("zonehvac_or_air_terminal_equipment_object_name", NullValueHandling = NullValueHandling.Ignore)]
//        public ErlVariableName ZonehvacOrAirTerminalEquipmentObjectName { get; set; }

//        [JsonProperty("fraction_of_output_or_supply_air_from_hvac_equipment", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog FractionOfOutputOrSupplyAirFromHvacEquipment { get; set; }

//        [JsonProperty("fraction_of_input_or_return_air_to_hvac_equipment", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog FractionOfInputOrReturnAirToHvacEquipment { get; set; }

//        [JsonProperty("compressor_speed_at_loading_index", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog CompressorSpeedAtLoadingIndex { get; set; }

//        [JsonProperty("loading_index_evaporative_capacity_multiplier_function_of_temperature_curve_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko LoadingIndexEvaporativeCapacityMultiplierFunctionOfTemperatureCurveName { get; set; }

//        [JsonProperty("loading_index_compressor_power_multiplier_function_of_temperature_curve_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko LoadingIndexCompressorPowerMultiplierFunctionOfTemperatureCurveName { get; set; }

//        [JsonProperty("zone_terminal_unit_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ZoneTerminalUnitName { get; set; }

//        [JsonProperty("node_or_nodelist_name", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl NodeOrNodelistName { get; set; }

//        [JsonProperty("outdoor_air_system_collector_inlet_node", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl OutdoorAirSystemCollectorInletNode { get; set; }

//        [JsonProperty("outdoor_air_system_collector_outlet_node", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl OutdoorAirSystemCollectorOutletNode { get; set; }

//        [JsonProperty("outdoor_air_system_mixed_air_node", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl OutdoorAirSystemMixedAirNode { get; set; }

//        [JsonProperty("outdoor_air_system_zone_node", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl OutdoorAirSystemZoneNode { get; set; }

//        [JsonProperty("erl_variable_name", NullValueHandling = NullValueHandling.Ignore)]
//        public ErlVariableName ErlVariableName { get; set; }

//        [JsonProperty("year_escalation", NullValueHandling = NullValueHandling.Ignore)]
//        public ErlVariableName YearEscalation { get; set; }

//        [JsonProperty("perform_run", NullValueHandling = NullValueHandling.Ignore)]
//        public PerformRun PerformRun { get; set; }

//        [JsonProperty("suffix_for_file_name_in_run", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl SuffixForFileNameInRun { get; set; }

//        [JsonProperty("report_name", NullValueHandling = NullValueHandling.Ignore)]
//        public InternalGainObjectType ReportName { get; set; }

//        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
//        public InternalGainObjectType Key { get; set; }
//    }

//    public partial class PuneHedgehog
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
//        public string Note { get; set; }

//        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
//        public string Units { get; set; }

//        [JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Minimum { get; set; }

//        [JsonProperty("exclusiveMinimum", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? ExclusiveMinimum { get; set; }

//        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Default { get; set; }

//        [JsonProperty("maximum", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Maximum { get; set; }
//    }

//    public partial class ErlVariableName
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("note")]
//        public string Note { get; set; }
//    }

//    public partial class TartuGecko
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
//        public DataType? DataType { get; set; }

//        [JsonProperty("object_list", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] ObjectList { get; set; }

//        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
//        public string Note { get; set; }

//        [JsonProperty("enum", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] Enum { get; set; }

//        [JsonProperty("external_list", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] ExternalList { get; set; }
//    }

//    public partial class LivingstoneSouthernWhiteFacedOwl
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }
//    }

//    public partial class InternalGainObjectType
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("enum")]
//        public string[] Enum { get; set; }
//    }

//    public partial class PerformRun
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("enum")]
//        public string[] Enum { get; set; }

//        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
//        public string Default { get; set; }

//        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
//        public string Note { get; set; }
//    }

//    public partial class NecessaryField
//    {
//        [JsonProperty("type")]
//        public ItemsType Type { get; set; }

//        [JsonProperty("properties")]
//        public Dictionary<string, SProperty> Properties { get; set; }

//        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] SRequired { get; set; }
//    }

//    public partial class SProperty
//    {
//        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
//        public EPFieldType? Type { get; set; }

//        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
//        public DataType? DataType { get; set; }

//        [JsonProperty("object_list", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] ObjectList { get; set; }

//        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
//        public string Note { get; set; }

//        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
//        public Default? Default { get; set; }

//        [JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Minimum { get; set; }

//        [JsonProperty("exclusiveMinimum", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? ExclusiveMinimum { get; set; }

//        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
//        public string Units { get; set; }

//        [JsonProperty("maximum", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Maximum { get; set; }

//        [JsonProperty("exclusiveMaximum", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? ExclusiveMaximum { get; set; }

//        [JsonProperty("enum", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] Enum { get; set; }

//        [JsonProperty("ip-units", NullValueHandling = NullValueHandling.Ignore)]
//        public string IpUnits { get; set; }

//        [JsonProperty("retaincase", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? Retaincase { get; set; }

//        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
//        public FluffyItems Items { get; set; }

//        [JsonProperty("unitsBasedOnField", NullValueHandling = NullValueHandling.Ignore)]
//        public FluffyUnitsBasedOnField? UnitsBasedOnField { get; set; }

//        [JsonProperty("minItems", NullValueHandling = NullValueHandling.Ignore)]
//        public long? MinItems { get; set; }

//        [JsonProperty("maxItems", NullValueHandling = NullValueHandling.Ignore)]
//        public long? MaxItems { get; set; }

//        [JsonProperty("anyOf", NullValueHandling = NullValueHandling.Ignore)]
//        public PropertyAnyOf[] AnyOf { get; set; }

//        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] Reference { get; set; }

//        [JsonProperty("external_list", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] ExternalList { get; set; }
//    }

//    public partial class FluffyItems
//    {
//        [JsonProperty("properties")]
//        public FluffyProperties Properties { get; set; }

//        [JsonProperty("type")]
//        public ItemsType Type { get; set; }

//        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
//        public string[] ItemsRequired { get; set; }
//    }

//    public partial class FluffyProperties
//    {
//        [JsonProperty("wavelength", NullValueHandling = NullValueHandling.Ignore)]
//        public DeltaAdjacentAirTemperaturePair Wavelength { get; set; }

//        [JsonProperty("spectrum", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl Spectrum { get; set; }

//        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
//        public Value Value { get; set; }

//        [JsonProperty("transmittance", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl Transmittance { get; set; }

//        [JsonProperty("front_reflectance", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl FrontReflectance { get; set; }

//        [JsonProperty("back_reflectance", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl BackReflectance { get; set; }

//        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
//        public CustomBlockXPosition Time { get; set; }

//        [JsonProperty("value_until_time", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl ValueUntilTime { get; set; }

//        [JsonProperty("daytype_list", NullValueHandling = NullValueHandling.Ignore)]
//        public ErlVariableName DaytypeList { get; set; }

//        [JsonProperty("schedule_day_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ScheduleDayName { get; set; }

//        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
//        public Field Field { get; set; }

//        [JsonProperty("zone_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ZoneName { get; set; }

//        [JsonProperty("surface_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko SurfaceName { get; set; }

//        [JsonProperty("core_diameter_for_surface", NullValueHandling = NullValueHandling.Ignore)]
//        public CoreForSurface CoreDiameterForSurface { get; set; }

//        [JsonProperty("core_length_for_surface", NullValueHandling = NullValueHandling.Ignore)]
//        public CoreForSurface CoreLengthForSurface { get; set; }

//        [JsonProperty("core_numbers_for_surface", NullValueHandling = NullValueHandling.Ignore)]
//        public ForSurface CoreNumbersForSurface { get; set; }

//        [JsonProperty("slab_inlet_node_name_for_surface", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl SlabInletNodeNameForSurface { get; set; }

//        [JsonProperty("slab_outlet_node_name_for_surface", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl SlabOutletNodeNameForSurface { get; set; }

//        [JsonProperty("schedule_week_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ScheduleWeekName { get; set; }

//        [JsonProperty("start_month", NullValueHandling = NullValueHandling.Ignore)]
//        public AreaOfGlassReachInDoorsFacingZone StartMonth { get; set; }

//        [JsonProperty("start_day", NullValueHandling = NullValueHandling.Ignore)]
//        public AreaOfGlassReachInDoorsFacingZone StartDay { get; set; }

//        [JsonProperty("end_month", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog EndMonth { get; set; }

//        [JsonProperty("end_day", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog EndDay { get; set; }

//        [JsonProperty("optical_data_temperature", NullValueHandling = NullValueHandling.Ignore)]
//        public OpticalDataTemperature OpticalDataTemperature { get; set; }

//        [JsonProperty("window_material_glazing_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko WindowMaterialGlazingName { get; set; }

//        [JsonProperty("vertex_x_coordinate", NullValueHandling = NullValueHandling.Ignore)]
//        public DeltaAdjacentAirTemperaturePair VertexXCoordinate { get; set; }

//        [JsonProperty("vertex_y_coordinate", NullValueHandling = NullValueHandling.Ignore)]
//        public DeltaAdjacentAirTemperaturePair VertexYCoordinate { get; set; }

//        [JsonProperty("vertex_z_coordinate", NullValueHandling = NullValueHandling.Ignore)]
//        public DeltaAdjacentAirTemperaturePair VertexZCoordinate { get; set; }

//        [JsonProperty("fenestration_surface_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko FenestrationSurfaceName { get; set; }

//        [JsonProperty("custom_block_material_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko CustomBlockMaterialName { get; set; }

//        [JsonProperty("custom_block_depth", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog CustomBlockDepth { get; set; }

//        [JsonProperty("custom_block_x_position", NullValueHandling = NullValueHandling.Ignore)]
//        public CustomBlockXPosition CustomBlockXPosition { get; set; }

//        [JsonProperty("custom_block_z_position", NullValueHandling = NullValueHandling.Ignore)]
//        public CustomBlockXPosition CustomBlockZPosition { get; set; }

//        [JsonProperty("surrounding_surface_name", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl SurroundingSurfaceName { get; set; }

//        [JsonProperty("surrounding_surface_view_factor", NullValueHandling = NullValueHandling.Ignore)]
//        public AreaOfGlassReachInDoorsFacingZone SurroundingSurfaceViewFactor { get; set; }

//        [JsonProperty("surrounding_surface_temperature_schedule_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko SurroundingSurfaceTemperatureScheduleName { get; set; }

//        [JsonProperty("collection_surface_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko CollectionSurfaceName { get; set; }

//        [JsonProperty("pair_zeta_nondimensional_height", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl PairZetaNondimensionalHeight { get; set; }

//        [JsonProperty("pair_delta_adjacent_air_temperature", NullValueHandling = NullValueHandling.Ignore)]
//        public AreaOfGlassReachInDoorsFacingZone PairDeltaAdjacentAirTemperature { get; set; }

//        [JsonProperty("surface_name_pair", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko SurfaceNamePair { get; set; }

//        [JsonProperty("delta_adjacent_air_temperature_pair", NullValueHandling = NullValueHandling.Ignore)]
//        public DeltaAdjacentAirTemperaturePair DeltaAdjacentAirTemperaturePair { get; set; }

//        [JsonProperty("roomairflownetwork_node_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko RoomairflownetworkNodeName { get; set; }

//        [JsonProperty("outlet_node_name", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl OutletNodeName { get; set; }

//        [JsonProperty("inlet_node_name", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl InletNodeName { get; set; }

//        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl NodeName { get; set; }

//        [JsonProperty("daylighting_reference_point_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko DaylightingReferencePointName { get; set; }

//        [JsonProperty("fraction_of_zone_controlled_by_reference_point", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog FractionOfZoneControlledByReferencePoint { get; set; }

//        [JsonProperty("illuminance_setpoint_at_reference_point", NullValueHandling = NullValueHandling.Ignore)]
//        public AreaOfGlassReachInDoorsFacingZone IlluminanceSetpointAtReferencePoint { get; set; }

//        [JsonProperty("transition_zone_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko TransitionZoneName { get; set; }

//        [JsonProperty("transition_zone_length", NullValueHandling = NullValueHandling.Ignore)]
//        public AreaOfGlassReachInDoorsFacingZone TransitionZoneLength { get; set; }

//        [JsonProperty("mode_name", NullValueHandling = NullValueHandling.Ignore)]
//        public ModeName ModeName { get; set; }

//        [JsonProperty("mode_supply_air_temperature_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ModeSupplyAirTemperatureLookupTableName { get; set; }

//        [JsonProperty("mode_supply_air_humidity_ratio_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ModeSupplyAirHumidityRatioLookupTableName { get; set; }

//        [JsonProperty("mode_system_electric_power_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ModeSystemElectricPowerLookupTableName { get; set; }

//        [JsonProperty("mode_supply_fan_electric_power_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ModeSupplyFanElectricPowerLookupTableName { get; set; }

//        [JsonProperty("mode_external_static_pressure_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ModeExternalStaticPressureLookupTableName { get; set; }

//        [JsonProperty("mode_system_second_fuel_consumption_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ModeSystemSecondFuelConsumptionLookupTableName { get; set; }

//        [JsonProperty("mode_system_third_fuel_consumption_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ModeSystemThirdFuelConsumptionLookupTableName { get; set; }

//        [JsonProperty("mode_system_water_use_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ModeSystemWaterUseLookupTableName { get; set; }

//        [JsonProperty("mode_minimum_outdoor_air_temperature", NullValueHandling = NullValueHandling.Ignore)]
//        public CustomBlockXPosition ModeMinimumOutdoorAirTemperature { get; set; }

//        [JsonProperty("mode_maximum_outdoor_air_temperature", NullValueHandling = NullValueHandling.Ignore)]
//        public CustomBlockXPosition ModeMaximumOutdoorAirTemperature { get; set; }

//        [JsonProperty("mode_minimum_outdoor_air_humidity_ratio", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ModeMinimumOutdoorAirHumidityRatio { get; set; }

//        [JsonProperty("mode_maximum_outdoor_air_humidity_ratio", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ModeMaximumOutdoorAirHumidityRatio { get; set; }

//        [JsonProperty("mode_minimum_outdoor_air_relative_humidity", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ModeMinimumOutdoorAirRelativeHumidity { get; set; }

//        [JsonProperty("mode_maximum_outdoor_air_relative_humidity", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ModeMaximumOutdoorAirRelativeHumidity { get; set; }

//        [JsonProperty("mode_minimum_return_air_temperature", NullValueHandling = NullValueHandling.Ignore)]
//        public CustomBlockXPosition ModeMinimumReturnAirTemperature { get; set; }

//        [JsonProperty("mode_maximum_return_air_temperature", NullValueHandling = NullValueHandling.Ignore)]
//        public CustomBlockXPosition ModeMaximumReturnAirTemperature { get; set; }

//        [JsonProperty("mode_minimum_return_air_humidity_ratio", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ModeMinimumReturnAirHumidityRatio { get; set; }

//        [JsonProperty("mode_maximum_return_air_humidity_ratio", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ModeMaximumReturnAirHumidityRatio { get; set; }

//        [JsonProperty("mode_minimum_return_air_relative_humidity", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ModeMinimumReturnAirRelativeHumidity { get; set; }

//        [JsonProperty("mode_maximum_return_air_relative_humidity", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ModeMaximumReturnAirRelativeHumidity { get; set; }

//        [JsonProperty("mode_minimum_outdoor_air_fraction", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ModeMinimumOutdoorAirFraction { get; set; }

//        [JsonProperty("mode_maximum_outdoor_air_fraction", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ModeMaximumOutdoorAirFraction { get; set; }

//        [JsonProperty("mode_minimum_supply_air_mass_flow_rate_ratio", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ModeMinimumSupplyAirMassFlowRateRatio { get; set; }

//        [JsonProperty("mode_maximum_supply_air_mass_flow_rate_ratio", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ModeMaximumSupplyAirMassFlowRateRatio { get; set; }

//        [JsonProperty("fraction_of_radiant_energy_to_surface", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog FractionOfRadiantEnergyToSurface { get; set; }

//        [JsonProperty("flow_fraction_for_surface", NullValueHandling = NullValueHandling.Ignore)]
//        public ForSurface FlowFractionForSurface { get; set; }

//        [JsonProperty("zone_equipment_object_type", NullValueHandling = NullValueHandling.Ignore)]
//        public InternalGainObjectType ZoneEquipmentObjectType { get; set; }

//        [JsonProperty("zone_equipment_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ZoneEquipmentName { get; set; }

//        [JsonProperty("zone_equipment_cooling_sequence", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ZoneEquipmentCoolingSequence { get; set; }

//        [JsonProperty("zone_equipment_heating_or_no_load_sequence", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog ZoneEquipmentHeatingOrNoLoadSequence { get; set; }

//        [JsonProperty("zone_equipment_sequential_cooling_fraction_schedule_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ZoneEquipmentSequentialCoolingFractionScheduleName { get; set; }

//        [JsonProperty("zone_equipment_sequential_heating_fraction_schedule_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ZoneEquipmentSequentialHeatingFractionScheduleName { get; set; }

//        [JsonProperty("equipment_object_type", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko EquipmentObjectType { get; set; }

//        [JsonProperty("equipment_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko EquipmentName { get; set; }

//        [JsonProperty("electric_equipment_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ElectricEquipmentName { get; set; }

//        [JsonProperty("speed_flow_fraction", NullValueHandling = NullValueHandling.Ignore)]
//        public AreaOfGlassReachInDoorsFacingZone SpeedFlowFraction { get; set; }

//        [JsonProperty("speed_electric_power_fraction", NullValueHandling = NullValueHandling.Ignore)]
//        public AreaOfGlassReachInDoorsFacingZone SpeedElectricPowerFraction { get; set; }

//        [JsonProperty("heating_speed_supply_air_flow_ratio", NullValueHandling = NullValueHandling.Ignore)]
//        public IngSpeedSupplyAirFlowRatio HeatingSpeedSupplyAirFlowRatio { get; set; }

//        [JsonProperty("cooling_speed_supply_air_flow_ratio", NullValueHandling = NullValueHandling.Ignore)]
//        public IngSpeedSupplyAirFlowRatio CoolingSpeedSupplyAirFlowRatio { get; set; }

//        [JsonProperty("compressor_speed_at_loading_index", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog CompressorSpeedAtLoadingIndex { get; set; }

//        [JsonProperty("loading_index_evaporative_capacity_multiplier_function_of_temperature_curve_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko LoadingIndexEvaporativeCapacityMultiplierFunctionOfTemperatureCurveName { get; set; }

//        [JsonProperty("loading_index_compressor_power_multiplier_function_of_temperature_curve_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko LoadingIndexCompressorPowerMultiplierFunctionOfTemperatureCurveName { get; set; }

//        [JsonProperty("zone_or_zonelist_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ZoneOrZonelistName { get; set; }

//        [JsonProperty("design_specification_outdoor_air_object_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko DesignSpecificationOutdoorAirObjectName { get; set; }

//        [JsonProperty("design_specification_zone_air_distribution_object_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko DesignSpecificationZoneAirDistributionObjectName { get; set; }

//        [JsonProperty("component_object_type", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ComponentObjectType { get; set; }

//        [JsonProperty("component_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ComponentName { get; set; }

//        [JsonProperty("component_inlet_node_name", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl ComponentInletNodeName { get; set; }

//        [JsonProperty("component_outlet_node_name", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl ComponentOutletNodeName { get; set; }

//        [JsonProperty("airloophvac_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko AirloophvacName { get; set; }

//        [JsonProperty("branch_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko BranchName { get; set; }

//        [JsonProperty("outlet_branch_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko OutletBranchName { get; set; }

//        [JsonProperty("inlet_branch_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko InletBranchName { get; set; }

//        [JsonProperty("pipe_circuit", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko PipeCircuit { get; set; }

//        [JsonProperty("pipe_segment", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko PipeSegment { get; set; }

//        [JsonProperty("ghe_vertical_single_object_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko GheVerticalSingleObjectName { get; set; }

//        [JsonProperty("g_function_ln_t_ts_value", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl GFunctionLnTTsValue { get; set; }

//        [JsonProperty("g_function_g_value", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl GFunctionGValue { get; set; }

//        [JsonProperty("program_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ProgramName { get; set; }

//        [JsonProperty("program_line", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl ProgramLine { get; set; }

//        [JsonProperty("parametric_logic_line", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl ParametricLogicLine { get; set; }

//        [JsonProperty("availability_manager_object_type", NullValueHandling = NullValueHandling.Ignore)]
//        public InternalGainObjectType AvailabilityManagerObjectType { get; set; }

//        [JsonProperty("availability_manager_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko AvailabilityManagerName { get; set; }

//        [JsonProperty("case_or_walkin_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko CaseOrWalkinName { get; set; }

//        [JsonProperty("cascade_condenser_name_or_secondary_system_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko CascadeCondenserNameOrSecondarySystemName { get; set; }

//        [JsonProperty("refrigeration_compressor_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko RefrigerationCompressorName { get; set; }

//        [JsonProperty("total_insulated_surface_area_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog TotalInsulatedSurfaceAreaFacingZone { get; set; }

//        [JsonProperty("insulated_surface_u_value_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog InsulatedSurfaceUValueFacingZone { get; set; }

//        [JsonProperty("area_of_glass_reach_in_doors_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
//        public AreaOfGlassReachInDoorsFacingZone AreaOfGlassReachInDoorsFacingZone { get; set; }

//        [JsonProperty("height_of_glass_reach_in_doors_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
//        public AreaOfGlassReachInDoorsFacingZone HeightOfGlassReachInDoorsFacingZone { get; set; }

//        [JsonProperty("glass_reach_in_door_u_value_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog GlassReachInDoorUValueFacingZone { get; set; }

//        [JsonProperty("glass_reach_in_door_opening_schedule_name_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko GlassReachInDoorOpeningScheduleNameFacingZone { get; set; }

//        [JsonProperty("area_of_stocking_doors_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
//        public AreaOfGlassReachInDoorsFacingZone AreaOfStockingDoorsFacingZone { get; set; }

//        [JsonProperty("height_of_stocking_doors_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
//        public AreaOfGlassReachInDoorsFacingZone HeightOfStockingDoorsFacingZone { get; set; }

//        [JsonProperty("stocking_door_u_value_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog StockingDoorUValueFacingZone { get; set; }

//        [JsonProperty("stocking_door_opening_schedule_name_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko StockingDoorOpeningScheduleNameFacingZone { get; set; }

//        [JsonProperty("stocking_door_opening_protection_type_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
//        public PerformRun StockingDoorOpeningProtectionTypeFacingZone { get; set; }

//        [JsonProperty("air_chiller_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko AirChillerName { get; set; }

//        [JsonProperty("demandmanager_object_type", NullValueHandling = NullValueHandling.Ignore)]
//        public InternalGainObjectType DemandmanagerObjectType { get; set; }

//        [JsonProperty("demandmanager_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko DemandmanagerName { get; set; }

//        [JsonProperty("exterior_lights_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ExteriorLightsName { get; set; }

//        [JsonProperty("lights_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko LightsName { get; set; }

//        [JsonProperty("thermostat_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ThermostatName { get; set; }

//        [JsonProperty("controller_outdoor_air_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko ControllerOutdoorAirName { get; set; }

//        [JsonProperty("constituent_name", NullValueHandling = NullValueHandling.Ignore)]
//        public InternalGainObjectType ConstituentName { get; set; }

//        [JsonProperty("molar_fraction", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog MolarFraction { get; set; }

//        [JsonProperty("generator_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko GeneratorName { get; set; }

//        [JsonProperty("generator_object_type", NullValueHandling = NullValueHandling.Ignore)]
//        public InternalGainObjectType GeneratorObjectType { get; set; }

//        [JsonProperty("generator_rated_electric_power_output", NullValueHandling = NullValueHandling.Ignore)]
//        public DeltaAdjacentAirTemperaturePair GeneratorRatedElectricPowerOutput { get; set; }

//        [JsonProperty("generator_availability_schedule_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko GeneratorAvailabilityScheduleName { get; set; }

//        [JsonProperty("generator_rated_thermal_to_electrical_power_ratio", NullValueHandling = NullValueHandling.Ignore)]
//        public ErlVariableName GeneratorRatedThermalToElectricalPowerRatio { get; set; }

//        [JsonProperty("meter_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko MeterName { get; set; }

//        [JsonProperty("water_use_equipment_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko WaterUseEquipmentName { get; set; }

//        [JsonProperty("output_value", NullValueHandling = NullValueHandling.Ignore)]
//        public OutputValue OutputValue { get; set; }

//        [JsonProperty("value_for_run", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl ValueForRun { get; set; }

//        [JsonProperty("independent_variable_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko IndependentVariableName { get; set; }

//        [JsonProperty("year_multiplier", NullValueHandling = NullValueHandling.Ignore)]
//        public ErlVariableName YearMultiplier { get; set; }

//        [JsonProperty("variable_or_meter_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko VariableOrMeterName { get; set; }

//        [JsonProperty("aggregation_type_for_variable_or_meter", NullValueHandling = NullValueHandling.Ignore)]
//        public PerformRun AggregationTypeForVariableOrMeter { get; set; }

//        [JsonProperty("variable_or_meter_or_ems_variable_or_field_name", NullValueHandling = NullValueHandling.Ignore)]
//        public TartuGecko VariableOrMeterOrEmsVariableOrFieldName { get; set; }

//        [JsonProperty("digits_after_decimal", NullValueHandling = NullValueHandling.Ignore)]
//        public PuneHedgehog DigitsAfterDecimal { get; set; }

//        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl KeyName { get; set; }

//        [JsonProperty("output_variable_or_meter_name", NullValueHandling = NullValueHandling.Ignore)]
//        public LivingstoneSouthernWhiteFacedOwl OutputVariableOrMeterName { get; set; }

//        [JsonProperty("search_path", NullValueHandling = NullValueHandling.Ignore)]
//        public SearchPath SearchPath { get; set; }

//        [JsonProperty("variable_name", NullValueHandling = NullValueHandling.Ignore)]
//        public ErlVariableName VariableName { get; set; }
//    }

//    public partial class AreaOfGlassReachInDoorsFacingZone
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
//        public string Units { get; set; }

//        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Default { get; set; }

//        [JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Minimum { get; set; }

//        [JsonProperty("maximum", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Maximum { get; set; }

//        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
//        public string Note { get; set; }
//    }

//    public partial class IngSpeedSupplyAirFlowRatio
//    {
//        [JsonProperty("note")]
//        public string Note { get; set; }

//        [JsonProperty("anyOf")]
//        public CoolingSpeedSupplyAirFlowRatioAnyOf[] AnyOf { get; set; }
//    }

//    public partial class CoolingSpeedSupplyAirFlowRatioAnyOf
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Minimum { get; set; }

//        [JsonProperty("exclusiveMinimum", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? ExclusiveMinimum { get; set; }

//        [JsonProperty("enum", NullValueHandling = NullValueHandling.Ignore)]
//        public EnumEnum[] Enum { get; set; }
//    }

//    public partial class CoreForSurface
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("minimum")]
//        public double Minimum { get; set; }

//        [JsonProperty("units")]
//        public Units Units { get; set; }
//    }

//    public partial class ForSurface
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("minimum")]
//        public double Minimum { get; set; }
//    }

//    public partial class CustomBlockXPosition
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("note")]
//        public string Note { get; set; }

//        [JsonProperty("units")]
//        public string Units { get; set; }
//    }

//    public partial class DeltaAdjacentAirTemperaturePair
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("units")]
//        public Units Units { get; set; }
//    }

//    public partial class Field
//    {
//        [JsonProperty("anyOf")]
//        public LivingstoneSouthernWhiteFacedOwl[] AnyOf { get; set; }
//    }

//    public partial class ModeName
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("retaincase")]
//        public bool Retaincase { get; set; }

//        [JsonProperty("note")]
//        public string Note { get; set; }
//    }

//    public partial class OpticalDataTemperature
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("units")]
//        public string Units { get; set; }

//        [JsonProperty("ip-units")]
//        public string IpUnits { get; set; }
//    }

//    public partial class OutputValue
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("unitsBasedOnField")]
//        public string UnitsBasedOnField { get; set; }
//    }

//    public partial class SearchPath
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("retaincase")]
//        public bool Retaincase { get; set; }
//    }

//    public partial class Value
//    {
//        [JsonProperty("type")]
//        public EPFieldType Type { get; set; }

//        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
//        public double? Default { get; set; }
//    }

//    public enum Format { CompactSchedule, FluidProperty, SingleLine, Spectral, Vertices, ViewFactor };

//    public enum FieldType { A, N };

//    public enum DataType { ExternalList, ObjectList };

//    public enum ReferenceClassName { ValidBranchEquipmentTypes, ValidCondenserEquipmentTypes, ValidOaSysEquipmentTypes, ValidPlantEquipmentTypes };

//    public enum EPFieldType { Array, Number, String };

//    public enum EnumEnum { Autocalculate, Autosize, OptionalField };

//    public enum ItemsType { Object };

//    public enum PurpleUnitsBasedOnField { FluidPropertyType, VariableType };

//    public enum Units { DeltaC, M, Micron, W };

//    public enum FluffyUnitsBasedOnField { InputUnitTypeForV, InputUnitTypeForW, InputUnitTypeForX, InputUnitTypeForY, InputUnitTypeForZ, OutputUnitType, UnitType };

//    public partial struct EnumUnion
//    {
//        public EnumEnum? Enum;
//        public long? Integer;

//        public static implicit operator EnumUnion(EnumEnum Enum) => new EnumUnion { Enum = Enum };
//        public static implicit operator EnumUnion(long Integer) => new EnumUnion { Integer = Integer };
//    }

//    public partial struct Default
//    {
//        public double? Double;
//        public string String;

//        public static implicit operator Default(double Double) => new Default { Double = Double };
//        public static implicit operator Default(string String) => new Default { String = String };
//    }

//    public partial class EPJsonSchema
//    {
//        public static EPJsonSchema FromJson(string json) => JsonConvert.DeserializeObject<EPJsonSchema>(json, Converter.Settings);
//    }

//    public static class Serialize
//    {
//        public static string ToJson(this EPJsonSchema self) => JsonConvert.SerializeObject(self, Converter.Settings);
//    }

//    internal static class Converter
//    {
//        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
//        {
//            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
//            DateParseHandling = DateParseHandling.None,
//            Converters = {
//                FormatConverter.Singleton,
//                FieldTypeConverter.Singleton,
//                DataTypeConverter.Singleton,
//                ReferenceClassNameConverter.Singleton,
//                EPFieldTypeConverter.Singleton,
//                EnumUnionConverter.Singleton,
//                EnumEnumConverter.Singleton,
//                DefaultConverter.Singleton,
//                ItemsTypeConverter.Singleton,
//                PurpleUnitsBasedOnFieldConverter.Singleton,
//                UnitsConverter.Singleton,
//                FluffyUnitsBasedOnFieldConverter.Singleton,
//                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
//            },
//        };
//    }

//    internal class FormatConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(Format) || t == typeof(Format?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "FluidProperty":
//                    return Format.FluidProperty;
//                case "Spectral":
//                    return Format.Spectral;
//                case "ViewFactor":
//                    return Format.ViewFactor;
//                case "compactSchedule":
//                    return Format.CompactSchedule;
//                case "singleLine":
//                    return Format.SingleLine;
//                case "vertices":
//                    return Format.Vertices;
//            }
//            throw new Exception("Cannot unmarshal type Format");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (Format)untypedValue;
//            switch (value)
//            {
//                case Format.FluidProperty:
//                    serializer.Serialize(writer, "FluidProperty");
//                    return;
//                case Format.Spectral:
//                    serializer.Serialize(writer, "Spectral");
//                    return;
//                case Format.ViewFactor:
//                    serializer.Serialize(writer, "ViewFactor");
//                    return;
//                case Format.CompactSchedule:
//                    serializer.Serialize(writer, "compactSchedule");
//                    return;
//                case Format.SingleLine:
//                    serializer.Serialize(writer, "singleLine");
//                    return;
//                case Format.Vertices:
//                    serializer.Serialize(writer, "vertices");
//                    return;
//            }
//            throw new Exception("Cannot marshal type Format");
//        }

//        public static readonly FormatConverter Singleton = new FormatConverter();
//    }

//    internal class FieldTypeConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(FieldType) || t == typeof(FieldType?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "a":
//                    return FieldType.A;
//                case "n":
//                    return FieldType.N;
//            }
//            throw new Exception("Cannot unmarshal type FieldType");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (FieldType)untypedValue;
//            switch (value)
//            {
//                case FieldType.A:
//                    serializer.Serialize(writer, "a");
//                    return;
//                case FieldType.N:
//                    serializer.Serialize(writer, "n");
//                    return;
//            }
//            throw new Exception("Cannot marshal type FieldType");
//        }

//        public static readonly FieldTypeConverter Singleton = new FieldTypeConverter();
//    }

//    internal class DataTypeConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(DataType) || t == typeof(DataType?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "external_list":
//                    return DataType.ExternalList;
//                case "object_list":
//                    return DataType.ObjectList;
//            }
//            throw new Exception("Cannot unmarshal type DataType");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (DataType)untypedValue;
//            switch (value)
//            {
//                case DataType.ExternalList:
//                    serializer.Serialize(writer, "external_list");
//                    return;
//                case DataType.ObjectList:
//                    serializer.Serialize(writer, "object_list");
//                    return;
//            }
//            throw new Exception("Cannot marshal type DataType");
//        }

//        public static readonly DataTypeConverter Singleton = new DataTypeConverter();
//    }

//    internal class ReferenceClassNameConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(ReferenceClassName) || t == typeof(ReferenceClassName?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "validBranchEquipmentTypes":
//                    return ReferenceClassName.ValidBranchEquipmentTypes;
//                case "validCondenserEquipmentTypes":
//                    return ReferenceClassName.ValidCondenserEquipmentTypes;
//                case "validOASysEquipmentTypes":
//                    return ReferenceClassName.ValidOaSysEquipmentTypes;
//                case "validPlantEquipmentTypes":
//                    return ReferenceClassName.ValidPlantEquipmentTypes;
//            }
//            throw new Exception("Cannot unmarshal type ReferenceClassName");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (ReferenceClassName)untypedValue;
//            switch (value)
//            {
//                case ReferenceClassName.ValidBranchEquipmentTypes:
//                    serializer.Serialize(writer, "validBranchEquipmentTypes");
//                    return;
//                case ReferenceClassName.ValidCondenserEquipmentTypes:
//                    serializer.Serialize(writer, "validCondenserEquipmentTypes");
//                    return;
//                case ReferenceClassName.ValidOaSysEquipmentTypes:
//                    serializer.Serialize(writer, "validOASysEquipmentTypes");
//                    return;
//                case ReferenceClassName.ValidPlantEquipmentTypes:
//                    serializer.Serialize(writer, "validPlantEquipmentTypes");
//                    return;
//            }
//            throw new Exception("Cannot marshal type ReferenceClassName");
//        }

//        public static readonly ReferenceClassNameConverter Singleton = new ReferenceClassNameConverter();
//    }

//    internal class EPFieldTypeConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(EPFieldType) || t == typeof(EPFieldType?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "array":
//                    return EPFieldType.Array;
//                case "number":
//                    return EPFieldType.Number;
//                case "string":
//                    return EPFieldType.String;
//            }
//            throw new Exception("Cannot unmarshal type EPFieldType");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (EPFieldType)untypedValue;
//            switch (value)
//            {
//                case EPFieldType.Array:
//                    serializer.Serialize(writer, "array");
//                    return;
//                case EPFieldType.Number:
//                    serializer.Serialize(writer, "number");
//                    return;
//                case EPFieldType.String:
//                    serializer.Serialize(writer, "string");
//                    return;
//            }
//            throw new Exception("Cannot marshal type EPFieldType");
//        }

//        public static readonly EPFieldTypeConverter Singleton = new EPFieldTypeConverter();
//    }

//    internal class EnumUnionConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(EnumUnion) || t == typeof(EnumUnion?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            switch (reader.TokenType)
//            {
//                case JsonToken.Integer:
//                    var integerValue = serializer.Deserialize<long>(reader);
//                    return new EnumUnion { Integer = integerValue };
//                case JsonToken.String:
//                case JsonToken.Date:
//                    var stringValue = serializer.Deserialize<string>(reader);
//                    switch (stringValue)
//                    {
//                        case "":
//                            return new EnumUnion { Enum = EnumEnum.OptionalField };
//                        case "Autocalculate":
//                            return new EnumUnion { Enum = EnumEnum.Autocalculate };
//                        case "Autosize":
//                            return new EnumUnion { Enum = EnumEnum.Autosize };
//                    }
//                    break;
//            }
//            throw new Exception("Cannot unmarshal type EnumUnion");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            var value = (EnumUnion)untypedValue;
//            if (value.Integer != null)
//            {
//                serializer.Serialize(writer, value.Integer.Value);
//                return;
//            }
//            if (value.Enum != null)
//            {
//                switch (value.Enum)
//                {
//                    case EnumEnum.OptionalField:
//                        serializer.Serialize(writer, "");
//                        return;
//                    case EnumEnum.Autocalculate:
//                        serializer.Serialize(writer, "Autocalculate");
//                        return;
//                    case EnumEnum.Autosize:
//                        serializer.Serialize(writer, "Autosize");
//                        return;
//                }
//            }
//            throw new Exception("Cannot marshal type EnumUnion");
//        }

//        public static readonly EnumUnionConverter Singleton = new EnumUnionConverter();
//    }

//    internal class EnumEnumConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(EnumEnum) || t == typeof(EnumEnum?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "":
//                    return EnumEnum.OptionalField;
//                case "Autocalculate":
//                    return EnumEnum.Autocalculate;
//                case "Autosize":
//                    return EnumEnum.Autosize;
//            }
//            throw new Exception("Cannot unmarshal type EnumEnum");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (EnumEnum)untypedValue;
//            switch (value)
//            {
//                case EnumEnum.OptionalField:
//                    serializer.Serialize(writer, "");
//                    return;
//                case EnumEnum.Autocalculate:
//                    serializer.Serialize(writer, "Autocalculate");
//                    return;
//                case EnumEnum.Autosize:
//                    serializer.Serialize(writer, "Autosize");
//                    return;
//            }
//            throw new Exception("Cannot marshal type EnumEnum");
//        }

//        public static readonly EnumEnumConverter Singleton = new EnumEnumConverter();
//    }

//    internal class DefaultConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(Default) || t == typeof(Default?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            switch (reader.TokenType)
//            {
//                case JsonToken.Integer:
//                case JsonToken.Float:
//                    var doubleValue = serializer.Deserialize<double>(reader);
//                    return new Default { Double = doubleValue };
//                case JsonToken.String:
//                case JsonToken.Date:
//                    var stringValue = serializer.Deserialize<string>(reader);
//                    return new Default { String = stringValue };
//            }
//            throw new Exception("Cannot unmarshal type Default");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            var value = (Default)untypedValue;
//            if (value.Double != null)
//            {
//                serializer.Serialize(writer, value.Double.Value);
//                return;
//            }
//            if (value.String != null)
//            {
//                serializer.Serialize(writer, value.String);
//                return;
//            }
//            throw new Exception("Cannot marshal type Default");
//        }

//        public static readonly DefaultConverter Singleton = new DefaultConverter();
//    }

//    internal class ItemsTypeConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(ItemsType) || t == typeof(ItemsType?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            if (value == "object")
//            {
//                return ItemsType.Object;
//            }
//            throw new Exception("Cannot unmarshal type ItemsType");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (ItemsType)untypedValue;
//            if (value == ItemsType.Object)
//            {
//                serializer.Serialize(writer, "object");
//                return;
//            }
//            throw new Exception("Cannot marshal type ItemsType");
//        }

//        public static readonly ItemsTypeConverter Singleton = new ItemsTypeConverter();
//    }

//    internal class PurpleUnitsBasedOnFieldConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(PurpleUnitsBasedOnField) || t == typeof(PurpleUnitsBasedOnField?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "fluid_property_type":
//                    return PurpleUnitsBasedOnField.FluidPropertyType;
//                case "variable_type":
//                    return PurpleUnitsBasedOnField.VariableType;
//            }
//            throw new Exception("Cannot unmarshal type PurpleUnitsBasedOnField");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (PurpleUnitsBasedOnField)untypedValue;
//            switch (value)
//            {
//                case PurpleUnitsBasedOnField.FluidPropertyType:
//                    serializer.Serialize(writer, "fluid_property_type");
//                    return;
//                case PurpleUnitsBasedOnField.VariableType:
//                    serializer.Serialize(writer, "variable_type");
//                    return;
//            }
//            throw new Exception("Cannot marshal type PurpleUnitsBasedOnField");
//        }

//        public static readonly PurpleUnitsBasedOnFieldConverter Singleton = new PurpleUnitsBasedOnFieldConverter();
//    }

//    internal class UnitsConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(Units) || t == typeof(Units?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "W":
//                    return Units.W;
//                case "deltaC":
//                    return Units.DeltaC;
//                case "m":
//                    return Units.M;
//                case "micron":
//                    return Units.Micron;
//            }
//            throw new Exception("Cannot unmarshal type Units");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (Units)untypedValue;
//            switch (value)
//            {
//                case Units.W:
//                    serializer.Serialize(writer, "W");
//                    return;
//                case Units.DeltaC:
//                    serializer.Serialize(writer, "deltaC");
//                    return;
//                case Units.M:
//                    serializer.Serialize(writer, "m");
//                    return;
//                case Units.Micron:
//                    serializer.Serialize(writer, "micron");
//                    return;
//            }
//            throw new Exception("Cannot marshal type Units");
//        }

//        public static readonly UnitsConverter Singleton = new UnitsConverter();
//    }

//    internal class FluffyUnitsBasedOnFieldConverter : JsonConverter
//    {
//        public override bool CanConvert(Type t) => t == typeof(FluffyUnitsBasedOnField) || t == typeof(FluffyUnitsBasedOnField?);

//        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
//        {
//            if (reader.TokenType == JsonToken.Null) return null;
//            var value = serializer.Deserialize<string>(reader);
//            switch (value)
//            {
//                case "input_unit_type_for_v":
//                    return FluffyUnitsBasedOnField.InputUnitTypeForV;
//                case "input_unit_type_for_w":
//                    return FluffyUnitsBasedOnField.InputUnitTypeForW;
//                case "input_unit_type_for_x":
//                    return FluffyUnitsBasedOnField.InputUnitTypeForX;
//                case "input_unit_type_for_y":
//                    return FluffyUnitsBasedOnField.InputUnitTypeForY;
//                case "input_unit_type_for_z":
//                    return FluffyUnitsBasedOnField.InputUnitTypeForZ;
//                case "output_unit_type":
//                    return FluffyUnitsBasedOnField.OutputUnitType;
//                case "unit_type":
//                    return FluffyUnitsBasedOnField.UnitType;
//            }
//            throw new Exception("Cannot unmarshal type FluffyUnitsBasedOnField");
//        }

//        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
//        {
//            if (untypedValue == null)
//            {
//                serializer.Serialize(writer, null);
//                return;
//            }
//            var value = (FluffyUnitsBasedOnField)untypedValue;
//            switch (value)
//            {
//                case FluffyUnitsBasedOnField.InputUnitTypeForV:
//                    serializer.Serialize(writer, "input_unit_type_for_v");
//                    return;
//                case FluffyUnitsBasedOnField.InputUnitTypeForW:
//                    serializer.Serialize(writer, "input_unit_type_for_w");
//                    return;
//                case FluffyUnitsBasedOnField.InputUnitTypeForX:
//                    serializer.Serialize(writer, "input_unit_type_for_x");
//                    return;
//                case FluffyUnitsBasedOnField.InputUnitTypeForY:
//                    serializer.Serialize(writer, "input_unit_type_for_y");
//                    return;
//                case FluffyUnitsBasedOnField.InputUnitTypeForZ:
//                    serializer.Serialize(writer, "input_unit_type_for_z");
//                    return;
//                case FluffyUnitsBasedOnField.OutputUnitType:
//                    serializer.Serialize(writer, "output_unit_type");
//                    return;
//                case FluffyUnitsBasedOnField.UnitType:
//                    serializer.Serialize(writer, "unit_type");
//                    return;
//            }
//            throw new Exception("Cannot marshal type FluffyUnitsBasedOnField");
//        }

//        public static readonly FluffyUnitsBasedOnFieldConverter Singleton = new FluffyUnitsBasedOnFieldConverter();
//    }
//}
