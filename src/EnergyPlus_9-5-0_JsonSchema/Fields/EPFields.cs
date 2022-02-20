using Newtonsoft.Json;

namespace EnergyPlus_9_5_0_JsonSchema.Fields
{
    public class EPFields
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
}