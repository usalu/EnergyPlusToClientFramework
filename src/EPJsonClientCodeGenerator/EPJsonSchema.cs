using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NJsonSchema;
using NJsonSchema.Annotations;

namespace EPJsonClientCodeGenerator
{
    public partial class EPJsonSchema : JsonSchema
    {
        [JsonProperty("$schema")]
        public Uri Schema { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, EPObjectJsonSchemeProperty> Properties { get; set; }

        [JsonProperty("required")]
        public string[] EPJsonSchemaRequired { get; set; }

        [JsonProperty("epJSON_schema_version")]
        public string EpJsonSchemaVersion { get; set; }

        [JsonProperty("epJSON_schema_build")]
        public string EpJsonSchemaBuild { get; set; }
    }

    public partial class EPObjectJsonSchemeProperty : JsonSchemaProperty
    {
        [JsonProperty("patternProperties")]
        public EPPatternProperties EPPatternProperties { get; set; }

        [JsonProperty("group")]
        public string EPGroup { get; set; }

        [JsonProperty("legacy_idd")]
        public EPLegacyIdd EPLegacyIdd { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("maxProperties", NullValueHandling = NullValueHandling.Ignore)]
        public long? EPMaxProperties { get; set; }

        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string EPMemo { get; set; }

        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public EPFormat? EPFormat { get; set; }

        [JsonProperty("min_fields", NullValueHandling = NullValueHandling.Ignore)]
        public double? EPMinFields { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public EPName EPName { get; set; }

        [JsonProperty("minProperties", NullValueHandling = NullValueHandling.Ignore)]
        public long? EPMinProperties { get; set; }

        [JsonProperty("extensible_size", NullValueHandling = NullValueHandling.Ignore)]
        public double? EPExtensibleSize { get; set; }

        [JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdditionalProperties { get; set; }
    }

    public partial class EPLegacyIdd
    {
        [JsonProperty("field_info")]
        public Dictionary<string, EPLegacyFieldInfo> EPLegacyFieldInfo { get; set; }

        [JsonProperty("fields")]
        public string[] EPLegacyFields { get; set; }

        [JsonProperty("alphas")]
        public EPLegacyAlphas EPLegacyAlphas { get; set; }

        [JsonProperty("numerics")]
        public EPLegacyAlphas EPLegacyNumerics { get; set; }

        [JsonProperty("extensibles", NullValueHandling = NullValueHandling.Ignore)]
        public string[] EPLegacyExtensibles { get; set; }

        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public string EPLegacyExtension { get; set; }
    }

    public partial class EPLegacyAlphas
    {
        [JsonProperty("fields")]
        public string[] Fields { get; set; }

        [JsonProperty("extensions", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Extensions { get; set; }
    }

    public partial class EPLegacyFieldInfo
    {
        [JsonProperty("field_name")]
        public string FieldName { get; set; }

        [JsonProperty("field_type")]
        public EPLegacyFieldType EPLegacyFieldType { get; set; }
    }

    public partial class EPName
    {
        [JsonProperty("type")]
        public EPFieldType Type { get; set; }

        [JsonProperty("retaincase", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Retaincase { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public string Default { get; set; }

        [JsonProperty("is_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRequired { get; set; }

        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Reference { get; set; }

        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
        public EPList? EPList { get; set; }

        [JsonProperty("object_list", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ObjectList { get; set; }

        [JsonProperty("reference-class-name", NullValueHandling = NullValueHandling.Ignore)]
        public EPReferenceClassName[] EPReferenceClassName { get; set; }
    }

    public partial class EPPatternProperties
    {
        [JsonProperty(".*", NullValueHandling = NullValueHandling.Ignore)]
        public OptionalField OptionalField { get; set; }

        [JsonProperty("^.*\\S.*$", NullValueHandling = NullValueHandling.Ignore)]
        public NecessaryField NecessaryField { get; set; }
    }
    public partial class NecessaryField : JsonSchema
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, EPFieldProperty> Properties { get; set; }

        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Required { get; set; }
    }

    public partial class OptionalField : JsonSchema
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, EPFieldProperty> Properties { get; set; }

        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Required { get; set; }
    }

    public partial class EPFieldProperty : JsonSchemaProperty
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldType? EPType { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public Default? Default { get; set; }

        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string EPNote { get; set; }

        [JsonProperty("enum", NullValueHandling = NullValueHandling.Ignore)]
        public string[] EPEnum { get; set; }

        [JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
        public double? Minimum { get; set; }

        [JsonProperty("maximum", NullValueHandling = NullValueHandling.Ignore)]
        public double? Maximum { get; set; }

        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
        public string Units { get; set; }

        [JsonProperty("exclusiveMinimum", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExclusiveMinimum { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public JsonSchema Items { get; set; }

        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
        public EPList? EPList { get; set; }

        [JsonProperty("object_list", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ObjectList { get; set; }

        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Reference { get; set; }

        [JsonProperty("retaincase", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Retaincase { get; set; }

        [JsonProperty("anyOf", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty[] AnyOf { get; set; }

        [JsonProperty("exclusiveMaximum", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExclusiveMaximum { get; set; }

        [JsonProperty("ip-units", NullValueHandling = NullValueHandling.Ignore)]
        public string IpUnits { get; set; }

        [JsonProperty("external_list", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ExternalList { get; set; }

        [JsonProperty("unitsBasedOnField", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitsBasedOnField { get; set; }
    }

    public partial class EPFields
    {
        [JsonProperty("shading_zone_group_zonelist_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ShadingZoneGroupZonelistName { get; set; }

        [JsonProperty("surface_segment_exposed", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty SurfaceSegmentExposed { get; set; }

        [JsonProperty("surface_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty SurfaceName { get; set; }

        [JsonProperty("surface_view_factor", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty SurfaceViewFactor { get; set; }

        [JsonProperty("from_surface", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty FromSurface { get; set; }

        [JsonProperty("to_surface", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ToSurface { get; set; }

        [JsonProperty("view_factor", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ViewFactor { get; set; }

        [JsonProperty("internal_gain_object_type", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty InternalGainObjectType { get; set; }

        [JsonProperty("internal_gain_object_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty InternalGainObjectName { get; set; }

        [JsonProperty("fraction_of_gains_to_node", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty FractionOfGainsToNode { get; set; }

        [JsonProperty("zonehvac_or_air_terminal_equipment_object_type", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ZonehvacOrAirTerminalEquipmentObjectType { get; set; }

        [JsonProperty("zonehvac_or_air_terminal_equipment_object_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ZonehvacOrAirTerminalEquipmentObjectName { get; set; }

        [JsonProperty("fraction_of_output_or_supply_air_from_hvac_equipment", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty FractionOfOutputOrSupplyAirFromHvacEquipment { get; set; }

        [JsonProperty("fraction_of_input_or_return_air_to_hvac_equipment", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty FractionOfInputOrReturnAirToHvacEquipment { get; set; }

        [JsonProperty("zone_terminal_unit_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ZoneTerminalUnitName { get; set; }

        [JsonProperty("node_or_nodelist_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty NodeOrNodelistName { get; set; }

        [JsonProperty("outdoor_air_system_collector_inlet_node", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty OutdoorAirSystemCollectorInletNode { get; set; }

        [JsonProperty("outdoor_air_system_collector_outlet_node", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty OutdoorAirSystemCollectorOutletNode { get; set; }

        [JsonProperty("outdoor_air_system_mixed_air_node", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty OutdoorAirSystemMixedAirNode { get; set; }

        [JsonProperty("outdoor_air_system_zone_node", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty OutdoorAirSystemZoneNode { get; set; }

        [JsonProperty("erl_variable_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ErlVariableName { get; set; }

        [JsonProperty("year_escalation", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty YearEscalation { get; set; }

        [JsonProperty("perform_run", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty PerformRun { get; set; }

        [JsonProperty("suffix_for_file_name_in_run", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty SuffixForFileNameInRun { get; set; }

        [JsonProperty("report_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ReportName { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty Key { get; set; }

        [JsonProperty("wavelength", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty Wavelength { get; set; }

        [JsonProperty("spectrum", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty Spectrum { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty Value { get; set; }

        [JsonProperty("transmittance", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty Transmittance { get; set; }

        [JsonProperty("front_reflectance", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty FrontReflectance { get; set; }

        [JsonProperty("back_reflectance", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty BackReflectance { get; set; }

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty Time { get; set; }

        [JsonProperty("value_until_time", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ValueUntilTime { get; set; }

        [JsonProperty("daytype_list", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty DaytypeList { get; set; }

        [JsonProperty("schedule_day_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ScheduleDayName { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty EPFieldProperty { get; set; }

        [JsonProperty("zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ZoneName { get; set; }

        [JsonProperty("core_diameter_for_surface", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty CoreDiameterForSurface { get; set; }

        [JsonProperty("core_length_for_surface", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty CoreLengthForSurface { get; set; }

        [JsonProperty("core_numbers_for_surface", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty CoreNumbersForSurface { get; set; }

        [JsonProperty("slab_inlet_node_name_for_surface", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty SlabInletNodeNameForSurface { get; set; }

        [JsonProperty("slab_outlet_node_name_for_surface", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty SlabOutletNodeNameForSurface { get; set; }

        [JsonProperty("schedule_week_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ScheduleWeekName { get; set; }

        [JsonProperty("start_month", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty StartMonth { get; set; }

        [JsonProperty("start_day", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty StartDay { get; set; }

        [JsonProperty("end_month", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty EndMonth { get; set; }

        [JsonProperty("end_day", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty EndDay { get; set; }

        [JsonProperty("optical_data_temperature", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty OpticalDataTemperature { get; set; }

        [JsonProperty("window_material_glazing_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty WindowMaterialGlazingName { get; set; }

        [JsonProperty("vertex_x_coordinate", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty VertexXCoordinate { get; set; }

        [JsonProperty("vertex_y_coordinate", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty VertexYCoordinate { get; set; }

        [JsonProperty("vertex_z_coordinate", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty VertexZCoordinate { get; set; }

        [JsonProperty("fenestration_surface_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty FenestrationSurfaceName { get; set; }

        [JsonProperty("custom_block_material_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty CustomBlockMaterialName { get; set; }

        [JsonProperty("custom_block_depth", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty CustomBlockDepth { get; set; }

        [JsonProperty("custom_block_x_position", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty CustomBlockXPosition { get; set; }

        [JsonProperty("custom_block_z_position", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty CustomBlockZPosition { get; set; }

        [JsonProperty("surrounding_surface_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty SurroundingSurfaceName { get; set; }

        [JsonProperty("surrounding_surface_view_factor", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty SurroundingSurfaceViewFactor { get; set; }

        [JsonProperty("surrounding_surface_temperature_schedule_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty SurroundingSurfaceTemperatureScheduleName { get; set; }

        [JsonProperty("collection_surface_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty CollectionSurfaceName { get; set; }

        [JsonProperty("pair_zeta_nondimensional_height", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty PairZetaNondimensionalHeight { get; set; }

        [JsonProperty("pair_delta_adjacent_air_temperature", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty PairDeltaAdjacentAirTemperature { get; set; }

        [JsonProperty("surface_name_pair", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty SurfaceNamePair { get; set; }

        [JsonProperty("delta_adjacent_air_temperature_pair", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty DeltaAdjacentAirTemperaturePair { get; set; }

        [JsonProperty("roomairflownetwork_node_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty RoomairflownetworkNodeName { get; set; }

        [JsonProperty("outlet_node_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty OutletNodeName { get; set; }

        [JsonProperty("inlet_node_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty InletNodeName { get; set; }

        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty NodeName { get; set; }

        [JsonProperty("daylighting_reference_point_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty DaylightingReferencePointName { get; set; }

        [JsonProperty("fraction_of_zone_controlled_by_reference_point", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty FractionOfZoneControlledByReferencePoint { get; set; }

        [JsonProperty("illuminance_setpoint_at_reference_point", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty IlluminanceSetpointAtReferencePoint { get; set; }

        [JsonProperty("transition_zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty TransitionZoneName { get; set; }

        [JsonProperty("transition_zone_length", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty TransitionZoneLength { get; set; }

        [JsonProperty("mode_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeName { get; set; }

        [JsonProperty("mode_supply_air_temperature_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeSupplyAirTemperatureLookupTableName { get; set; }

        [JsonProperty("mode_supply_air_humidity_ratio_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeSupplyAirHumidityRatioLookupTableName { get; set; }

        [JsonProperty("mode_system_electric_power_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeSystemElectricPowerLookupTableName { get; set; }

        [JsonProperty("mode_supply_fan_electric_power_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeSupplyFanElectricPowerLookupTableName { get; set; }

        [JsonProperty("mode_external_static_pressure_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeExternalStaticPressureLookupTableName { get; set; }

        [JsonProperty("mode_system_second_fuel_consumption_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeSystemSecondFuelConsumptionLookupTableName { get; set; }

        [JsonProperty("mode_system_third_fuel_consumption_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeSystemThirdFuelConsumptionLookupTableName { get; set; }

        [JsonProperty("mode_system_water_use_lookup_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeSystemWaterUseLookupTableName { get; set; }

        [JsonProperty("mode_minimum_outdoor_air_temperature", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMinimumOutdoorAirTemperature { get; set; }

        [JsonProperty("mode_maximum_outdoor_air_temperature", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMaximumOutdoorAirTemperature { get; set; }

        [JsonProperty("mode_minimum_outdoor_air_humidity_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMinimumOutdoorAirHumidityRatio { get; set; }

        [JsonProperty("mode_maximum_outdoor_air_humidity_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMaximumOutdoorAirHumidityRatio { get; set; }

        [JsonProperty("mode_minimum_outdoor_air_relative_humidity", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMinimumOutdoorAirRelativeHumidity { get; set; }

        [JsonProperty("mode_maximum_outdoor_air_relative_humidity", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMaximumOutdoorAirRelativeHumidity { get; set; }

        [JsonProperty("mode_minimum_return_air_temperature", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMinimumReturnAirTemperature { get; set; }

        [JsonProperty("mode_maximum_return_air_temperature", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMaximumReturnAirTemperature { get; set; }

        [JsonProperty("mode_minimum_return_air_humidity_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMinimumReturnAirHumidityRatio { get; set; }

        [JsonProperty("mode_maximum_return_air_humidity_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMaximumReturnAirHumidityRatio { get; set; }

        [JsonProperty("mode_minimum_return_air_relative_humidity", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMinimumReturnAirRelativeHumidity { get; set; }

        [JsonProperty("mode_maximum_return_air_relative_humidity", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMaximumReturnAirRelativeHumidity { get; set; }

        [JsonProperty("mode_minimum_outdoor_air_fraction", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMinimumOutdoorAirFraction { get; set; }

        [JsonProperty("mode_maximum_outdoor_air_fraction", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMaximumOutdoorAirFraction { get; set; }

        [JsonProperty("mode_minimum_supply_air_mass_flow_rate_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMinimumSupplyAirMassFlowRateRatio { get; set; }

        [JsonProperty("mode_maximum_supply_air_mass_flow_rate_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ModeMaximumSupplyAirMassFlowRateRatio { get; set; }

        [JsonProperty("fraction_of_radiant_energy_to_surface", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty FractionOfRadiantEnergyToSurface { get; set; }

        [JsonProperty("flow_fraction_for_surface", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty FlowFractionForSurface { get; set; }

        [JsonProperty("zone_equipment_object_type", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ZoneEquipmentObjectType { get; set; }

        [JsonProperty("zone_equipment_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ZoneEquipmentName { get; set; }

        [JsonProperty("zone_equipment_cooling_sequence", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ZoneEquipmentCoolingSequence { get; set; }

        [JsonProperty("zone_equipment_heating_or_no_load_sequence", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ZoneEquipmentHeatingOrNoLoadSequence { get; set; }

        [JsonProperty("zone_equipment_sequential_cooling_fraction_schedule_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ZoneEquipmentSequentialCoolingFractionScheduleName { get; set; }

        [JsonProperty("zone_equipment_sequential_heating_fraction_schedule_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ZoneEquipmentSequentialHeatingFractionScheduleName { get; set; }

        [JsonProperty("equipment_object_type", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty EquipmentObjectType { get; set; }

        [JsonProperty("equipment_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty EquipmentName { get; set; }

        [JsonProperty("electric_equipment_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ElectricEquipmentName { get; set; }

        [JsonProperty("speed_flow_fraction", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty SpeedFlowFraction { get; set; }

        [JsonProperty("speed_electric_power_fraction", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty SpeedElectricPowerFraction { get; set; }

        [JsonProperty("heating_speed_supply_air_flow_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty HeatingSpeedSupplyAirFlowRatio { get; set; }

        [JsonProperty("cooling_speed_supply_air_flow_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty CoolingSpeedSupplyAirFlowRatio { get; set; }

        [JsonProperty("compressor_speed_at_loading_index", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty CompressorSpeedAtLoadingIndex { get; set; }

        [JsonProperty("loading_index_evaporative_capacity_multiplier_function_of_temperature_curve_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty LoadingIndexEvaporativeCapacityMultiplierFunctionOfTemperatureCurveName { get; set; }

        [JsonProperty("loading_index_compressor_power_multiplier_function_of_temperature_curve_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty LoadingIndexCompressorPowerMultiplierFunctionOfTemperatureCurveName { get; set; }

        [JsonProperty("zone_or_zonelist_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ZoneOrZonelistName { get; set; }

        [JsonProperty("design_specification_outdoor_air_object_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty DesignSpecificationOutdoorAirObjectName { get; set; }

        [JsonProperty("design_specification_zone_air_distribution_object_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty DesignSpecificationZoneAirDistributionObjectName { get; set; }

        [JsonProperty("component_object_type", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ComponentObjectType { get; set; }

        [JsonProperty("component_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ComponentName { get; set; }

        [JsonProperty("component_inlet_node_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ComponentInletNodeName { get; set; }

        [JsonProperty("component_outlet_node_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ComponentOutletNodeName { get; set; }

        [JsonProperty("airloophvac_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty AirloophvacName { get; set; }

        [JsonProperty("branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty BranchName { get; set; }

        [JsonProperty("outlet_branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty OutletBranchName { get; set; }

        [JsonProperty("inlet_branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty InletBranchName { get; set; }

        [JsonProperty("pipe_circuit", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty PipeCircuit { get; set; }

        [JsonProperty("pipe_segment", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty PipeSegment { get; set; }

        [JsonProperty("ghe_vertical_single_object_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty GheVerticalSingleObjectName { get; set; }

        [JsonProperty("g_function_ln_t_ts_value", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty GFunctionLnTTsValue { get; set; }

        [JsonProperty("g_function_g_value", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty GFunctionGValue { get; set; }

        [JsonProperty("program_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ProgramName { get; set; }

        [JsonProperty("program_line", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ProgramLine { get; set; }

        [JsonProperty("parametric_logic_line", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ParametricLogicLine { get; set; }

        [JsonProperty("availability_manager_object_type", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty AvailabilityManagerObjectType { get; set; }

        [JsonProperty("availability_manager_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty AvailabilityManagerName { get; set; }

        [JsonProperty("case_or_walkin_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty CaseOrWalkinName { get; set; }

        [JsonProperty("cascade_condenser_name_or_secondary_system_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty CascadeCondenserNameOrSecondarySystemName { get; set; }

        [JsonProperty("refrigeration_compressor_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty RefrigerationCompressorName { get; set; }

        [JsonProperty("total_insulated_surface_area_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty TotalInsulatedSurfaceAreaFacingZone { get; set; }

        [JsonProperty("insulated_surface_u_value_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty InsulatedSurfaceUValueFacingZone { get; set; }

        [JsonProperty("area_of_glass_reach_in_doors_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty AreaOfGlassReachInDoorsFacingZone { get; set; }

        [JsonProperty("height_of_glass_reach_in_doors_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty HeightOfGlassReachInDoorsFacingZone { get; set; }

        [JsonProperty("glass_reach_in_door_u_value_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty GlassReachInDoorUValueFacingZone { get; set; }

        [JsonProperty("glass_reach_in_door_opening_schedule_name_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty GlassReachInDoorOpeningScheduleNameFacingZone { get; set; }

        [JsonProperty("area_of_stocking_doors_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty AreaOfStockingDoorsFacingZone { get; set; }

        [JsonProperty("height_of_stocking_doors_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty HeightOfStockingDoorsFacingZone { get; set; }

        [JsonProperty("stocking_door_u_value_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty StockingDoorUValueFacingZone { get; set; }

        [JsonProperty("stocking_door_opening_schedule_name_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty StockingDoorOpeningScheduleNameFacingZone { get; set; }

        [JsonProperty("stocking_door_opening_protection_type_facing_zone", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty StockingDoorOpeningProtectionTypeFacingZone { get; set; }

        [JsonProperty("air_chiller_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty AirChillerName { get; set; }

        [JsonProperty("demandmanager_object_type", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty DemandmanagerObjectType { get; set; }

        [JsonProperty("demandmanager_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty DemandmanagerName { get; set; }

        [JsonProperty("exterior_lights_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ExteriorLightsName { get; set; }

        [JsonProperty("lights_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty LightsName { get; set; }

        [JsonProperty("thermostat_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ThermostatName { get; set; }

        [JsonProperty("controller_outdoor_air_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ControllerOutdoorAirName { get; set; }

        [JsonProperty("constituent_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ConstituentName { get; set; }

        [JsonProperty("molar_fraction", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty MolarFraction { get; set; }

        [JsonProperty("generator_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty GeneratorName { get; set; }

        [JsonProperty("generator_object_type", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty GeneratorObjectType { get; set; }

        [JsonProperty("generator_rated_electric_power_output", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty GeneratorRatedElectricPowerOutput { get; set; }

        [JsonProperty("generator_availability_schedule_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty GeneratorAvailabilityScheduleName { get; set; }

        [JsonProperty("generator_rated_thermal_to_electrical_power_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty GeneratorRatedThermalToElectricalPowerRatio { get; set; }

        [JsonProperty("meter_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty MeterName { get; set; }

        [JsonProperty("water_use_equipment_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty WaterUseEquipmentName { get; set; }

        [JsonProperty("output_value", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty OutputValue { get; set; }

        [JsonProperty("value_for_run", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty ValueForRun { get; set; }

        [JsonProperty("independent_variable_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty IndependentVariableName { get; set; }

        [JsonProperty("year_multiplier", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty YearMultiplier { get; set; }

        [JsonProperty("variable_or_meter_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty VariableOrMeterName { get; set; }

        [JsonProperty("aggregation_type_for_variable_or_meter", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty AggregationTypeForVariableOrMeter { get; set; }

        [JsonProperty("variable_or_meter_or_ems_variable_or_field_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty VariableOrMeterOrEmsVariableOrFieldName { get; set; }

        [JsonProperty("digits_after_decimal", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty DigitsAfterDecimal { get; set; }

        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty KeyName { get; set; }

        [JsonProperty("output_variable_or_meter_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty OutputVariableOrMeterName { get; set; }

        [JsonProperty("search_path", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty SearchPath { get; set; }

        [JsonProperty("variable_name", NullValueHandling = NullValueHandling.Ignore)]
        public EPFieldProperty VariableName { get; set; }
    }


    public enum EPFormat { CompactSchedule, FluidProperty, SingleLine, Spectral, Vertices, ViewFactor };

    public enum EPLegacyFieldType { A, N };

    public enum EPList { ExternalList, ObjectList };

    public enum EPReferenceClassName { ValidBranchEquipmentTypes, ValidCondenserEquipmentTypes, ValidOaSysEquipmentTypes, ValidPlantEquipmentTypes };

    public enum EPFieldType { Array, Number, String };

    public enum EnumEnum { Autocalculate, Autosize, OptionalField };


    public partial struct EnumUnion
    {
        public EnumEnum? Enum;
        public long? Integer;

        public static implicit operator EnumUnion(EnumEnum Enum) => new EnumUnion { Enum = Enum };
        public static implicit operator EnumUnion(long Integer) => new EnumUnion { Integer = Integer };
    }

    public partial struct Default
    {
        public double? Double;
        public string String;

        public static implicit operator Default(double Double) => new Default { Double = Double };
        public static implicit operator Default(string String) => new Default { String = String };
    }

    public partial class EPJsonSchema
    {
        public static EPJsonSchema FromJson(string json) => JsonConvert.DeserializeObject<EPJsonSchema>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this EPJsonSchema self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                FormatConverter.Singleton,
                FieldTypeConverter.Singleton,
                DataTypeConverter.Singleton,
                ReferenceClassNameConverter.Singleton,
                EPFieldTypeConverter.Singleton,
                EnumUnionConverter.Singleton,
                EnumEnumConverter.Singleton,
                DefaultConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class FormatConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EPFormat) || t == typeof(EPFormat?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FluidProperty":
                    return EPFormat.FluidProperty;
                case "Spectral":
                    return EPFormat.Spectral;
                case "ViewFactor":
                    return EPFormat.ViewFactor;
                case "compactSchedule":
                    return EPFormat.CompactSchedule;
                case "singleLine":
                    return EPFormat.SingleLine;
                case "vertices":
                    return EPFormat.Vertices;
            }
            throw new Exception("Cannot unmarshal type EPFormat");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EPFormat)untypedValue;
            switch (value)
            {
                case EPFormat.FluidProperty:
                    serializer.Serialize(writer, "FluidProperty");
                    return;
                case EPFormat.Spectral:
                    serializer.Serialize(writer, "Spectral");
                    return;
                case EPFormat.ViewFactor:
                    serializer.Serialize(writer, "ViewFactor");
                    return;
                case EPFormat.CompactSchedule:
                    serializer.Serialize(writer, "compactSchedule");
                    return;
                case EPFormat.SingleLine:
                    serializer.Serialize(writer, "singleLine");
                    return;
                case EPFormat.Vertices:
                    serializer.Serialize(writer, "vertices");
                    return;
            }
            throw new Exception("Cannot marshal type EPFormat");
        }

        public static readonly FormatConverter Singleton = new FormatConverter();
    }

    internal class FieldTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EPLegacyFieldType) || t == typeof(EPLegacyFieldType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "a":
                    return EPLegacyFieldType.A;
                case "n":
                    return EPLegacyFieldType.N;
            }
            throw new Exception("Cannot unmarshal type EPLegacyFieldType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EPLegacyFieldType)untypedValue;
            switch (value)
            {
                case EPLegacyFieldType.A:
                    serializer.Serialize(writer, "a");
                    return;
                case EPLegacyFieldType.N:
                    serializer.Serialize(writer, "n");
                    return;
            }
            throw new Exception("Cannot marshal type EPLegacyFieldType");
        }

        public static readonly FieldTypeConverter Singleton = new FieldTypeConverter();
    }

    internal class DataTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EPList) || t == typeof(EPList?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "external_list":
                    return EPList.ExternalList;
                case "object_list":
                    return EPList.ObjectList;
            }
            throw new Exception("Cannot unmarshal type EPList");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EPList)untypedValue;
            switch (value)
            {
                case EPList.ExternalList:
                    serializer.Serialize(writer, "external_list");
                    return;
                case EPList.ObjectList:
                    serializer.Serialize(writer, "object_list");
                    return;
            }
            throw new Exception("Cannot marshal type EPList");
        }

        public static readonly DataTypeConverter Singleton = new DataTypeConverter();
    }

    internal class ReferenceClassNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EPReferenceClassName) || t == typeof(EPReferenceClassName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "validBranchEquipmentTypes":
                    return EPReferenceClassName.ValidBranchEquipmentTypes;
                case "validCondenserEquipmentTypes":
                    return EPReferenceClassName.ValidCondenserEquipmentTypes;
                case "validOASysEquipmentTypes":
                    return EPReferenceClassName.ValidOaSysEquipmentTypes;
                case "validPlantEquipmentTypes":
                    return EPReferenceClassName.ValidPlantEquipmentTypes;
            }
            throw new Exception("Cannot unmarshal type EPReferenceClassName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EPReferenceClassName)untypedValue;
            switch (value)
            {
                case EPReferenceClassName.ValidBranchEquipmentTypes:
                    serializer.Serialize(writer, "validBranchEquipmentTypes");
                    return;
                case EPReferenceClassName.ValidCondenserEquipmentTypes:
                    serializer.Serialize(writer, "validCondenserEquipmentTypes");
                    return;
                case EPReferenceClassName.ValidOaSysEquipmentTypes:
                    serializer.Serialize(writer, "validOASysEquipmentTypes");
                    return;
                case EPReferenceClassName.ValidPlantEquipmentTypes:
                    serializer.Serialize(writer, "validPlantEquipmentTypes");
                    return;
            }
            throw new Exception("Cannot marshal type EPReferenceClassName");
        }

        public static readonly ReferenceClassNameConverter Singleton = new ReferenceClassNameConverter();
    }

    internal class EPFieldTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EPFieldType) || t == typeof(EPFieldType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "array":
                    return EPFieldType.Array;
                case "number":
                    return EPFieldType.Number;
                case "string":
                    return EPFieldType.String;
            }
            throw new Exception("Cannot unmarshal type EPFieldType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EPFieldType)untypedValue;
            switch (value)
            {
                case EPFieldType.Array:
                    serializer.Serialize(writer, "array");
                    return;
                case EPFieldType.Number:
                    serializer.Serialize(writer, "number");
                    return;
                case EPFieldType.String:
                    serializer.Serialize(writer, "string");
                    return;
            }
            throw new Exception("Cannot marshal type EPFieldType");
        }

        public static readonly EPFieldTypeConverter Singleton = new EPFieldTypeConverter();
    }

    internal class EnumUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EnumUnion) || t == typeof(EnumUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new EnumUnion { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "":
                            return new EnumUnion { Enum = EnumEnum.OptionalField };
                        case "Autocalculate":
                            return new EnumUnion { Enum = EnumEnum.Autocalculate };
                        case "Autosize":
                            return new EnumUnion { Enum = EnumEnum.Autosize };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type EnumUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (EnumUnion)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case EnumEnum.OptionalField:
                        serializer.Serialize(writer, "");
                        return;
                    case EnumEnum.Autocalculate:
                        serializer.Serialize(writer, "Autocalculate");
                        return;
                    case EnumEnum.Autosize:
                        serializer.Serialize(writer, "Autosize");
                        return;
                }
            }
            throw new Exception("Cannot marshal type EnumUnion");
        }

        public static readonly EnumUnionConverter Singleton = new EnumUnionConverter();
    }

    internal class EnumEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EnumEnum) || t == typeof(EnumEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return EnumEnum.OptionalField;
                case "Autocalculate":
                    return EnumEnum.Autocalculate;
                case "Autosize":
                    return EnumEnum.Autosize;
            }
            throw new Exception("Cannot unmarshal type EnumEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EnumEnum)untypedValue;
            switch (value)
            {
                case EnumEnum.OptionalField:
                    serializer.Serialize(writer, "");
                    return;
                case EnumEnum.Autocalculate:
                    serializer.Serialize(writer, "Autocalculate");
                    return;
                case EnumEnum.Autosize:
                    serializer.Serialize(writer, "Autosize");
                    return;
            }
            throw new Exception("Cannot marshal type EnumEnum");
        }

        public static readonly EnumEnumConverter Singleton = new EnumEnumConverter();
    }

    internal class DefaultConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Default) || t == typeof(Default?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Default { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Default { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type Default");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Default)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type Default");
        }

        public static readonly DefaultConverter Singleton = new DefaultConverter();
    }

}
