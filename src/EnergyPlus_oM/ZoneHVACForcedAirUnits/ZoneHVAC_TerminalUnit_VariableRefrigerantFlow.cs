using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description(@"A terminal unit with variable refrigerant flow (VRF) DX cooling and heating coils (air-to-air heat pump). The VRF terminal units are served by an AirConditioner:VariableRefrigerantFlow or AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:* system. Terminal units can be configured as zone, air loop or outside air system equipment.")]
    [JsonObject("ZoneHVAC:TerminalUnit:VariableRefrigerantFlow")]
    public class ZoneHVAC_TerminalUnit_VariableRefrigerantFlow : BHoMObject, IEnergyPlusClass
    {
        

        [Description("The unit is available the entire simulation if this field is left blank Schedule " +
                     "values of 0 denote the unit is off.")]
        [JsonProperty("terminal_unit_availability_schedule")]
        public string TerminalUnitAvailabilitySchedule { get; set; } = "";
        

        [Description("the inlet node to the terminal unit")]
        [JsonProperty("terminal_unit_air_inlet_node_name")]
        public string TerminalUnitAirInletNodeName { get; set; } = "";
        

        [Description("the outlet node of the terminal unit")]
        [JsonProperty("terminal_unit_air_outlet_node_name")]
        public string TerminalUnitAirOutletNodeName { get; set; } = "";
        

        [JsonProperty("cooling_supply_air_flow_rate")]
        public string CoolingSupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("no_cooling_supply_air_flow_rate")]
        public string NoCoolingSupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("heating_supply_air_flow_rate")]
        public string HeatingSupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("no_heating_supply_air_flow_rate")]
        public string NoHeatingSupplyAirFlowRate { get; set; } = "";
        

        [Description(@"This field is used only when an oudoor air mixer is included. This field is set to zero flow when the VRF terminal unit is connected to central dedicated outdoor air through air terminal single duct mixer object. When this VRF terminal is used as air loop equipment the autosized flow rate will be set to 0 when an outdoor air system is connected to this air loop, otherwise the outdoor air flow rate will equal the maximum outdoor air flow rate.")]
        [JsonProperty("cooling_outdoor_air_flow_rate")]
        public string CoolingOutdoorAirFlowRate { get; set; } = "";
        

        [Description(@"This field is used only when an oudoor air mixer is included. This field is set to zero flow when the VRF terminal unit is connected to central dedicated outdoor air through air terminal single duct mixer object. When this VRF terminal is used as air loop equipment the autosized flow rate will be set to 0 when an outdoor air system is connected to this air loop, otherwise the outdoor air flow rate will equal the maximum outdoor air flow rate.")]
        [JsonProperty("heating_outdoor_air_flow_rate")]
        public string HeatingOutdoorAirFlowRate { get; set; } = "";
        

        [Description(@"This field is used only when an oudoor air mixer is included. This field is set to zero flow when the VRF terminal unit is connected to central dedicated outdoor air through air terminal single duct mixer object. When this VRF terminal is used as air loop equipment the autosized flow rate will be set to 0 when an outdoor air system is connected to this air loop, otherwise the outdoor air flow rate will equal the maximum outdoor air flow rate.")]
        [JsonProperty("no_load_outdoor_air_flow_rate")]
        public string NoLoadOutdoorAirFlowRate { get; set; } = "";
        

        [Description("Required for zone equipment. Leave blank if terminal unit is used in AirLoopHVAC:" +
                     "OutdoorAirSystem:EquipmentList. Also leave blank if terminal unit is used on mai" +
                     "n AirloopHVAC branch and terminal unit has no fan.")]
        [JsonProperty("supply_air_fan_operating_mode_schedule_name")]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [Description(@"Select fan placement as either blow through or draw through. Required for zone equipment. This field is ignored if the VRF terminal unit is used in AirLoopHVAC:OutdoorAirSystem:EquipmentList. This field is also ignored if VRF terminal unit is used on main AirloopHVAC branch and terminal unit has no fan.")]
        [JsonProperty("supply_air_fan_placement")]
        public ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanPlacement SupplyAirFanPlacement { get; set; } = (ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanPlacement)Enum.Parse(typeof(ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanPlacement), "BlowThrough");
        

        [Description(@"Supply Air Fan Object Type must be Fan:SystemModel, Fan:OnOff, or Fan:ConstantVolume if AirConditioner:VariableRefrigerantFlow is used to model VRF outdoor unit Supply Air Fan Object Type must be Fan:SystemModel or Fan:VariableVolume if AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl or AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:HR is used to model VRF outdoor unit Required for zone equipment. Leave blank if terminal unit is used in AirLoopHVAC:OutdoorAirSystem:EquipmentList. Also leave blank if terminal unit is used on main AirloopHVAC branch and terminal unit has no fan.")]
        [JsonProperty("supply_air_fan_object_type")]
        public ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanObjectType)Enum.Parse(typeof(ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanObjectType), "Empty");
        

        [JsonProperty("supply_air_fan_object_name")]
        public string SupplyAirFanObjectName { get; set; } = "";
        

        [Description(@"Currently only one type OutdoorAir:Mixer object is available. If this field is blank, and outside air mixer is not used. This field should be left blank if the VRF terminal unit is connected to central dedicated outdoor air through an AirTerminal:SingleDuct:Mixer object. This field may also be left blank when the VRF terminal is used in the air loop or outdoor air system.")]
        [JsonProperty("outside_air_mixer_object_type")]
        public ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_OutsideAirMixerObjectType OutsideAirMixerObjectType { get; set; } = (ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_OutsideAirMixerObjectType)Enum.Parse(typeof(ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_OutsideAirMixerObjectType), "OutdoorAirMixer");
        

        [Description(@"If this field is blank, the OutdoorAir:Mixer is not used. This optional field specifies the name of the OutdoorAir:Mixer object. When used, this name needs to match name of the OutdoorAir:Mixer object. This field should be left blank if the VRF terminal unit is connected to central dedicated outdoor air through an AirTerminal:SingleDuct:Mixer object. This field may also be left blank when the VRF terminal is used in the air loop or outdoor air system.")]
        [JsonProperty("outside_air_mixer_object_name")]
        public string OutsideAirMixerObjectName { get; set; } = "";
        

        [Description(@"Cooling Coil Type must be Coil:Cooling:DX:VariableRefrigerantFlow if AirConditioner:VariableRefrigerantFlow is used to model VRF outdoor unit Cooling Coil Type must be Coil:Cooling:DX:VariableRefrigerantFlow:FluidTemperatureControl if AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl or if AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:HR is used to model VRF outdoor unit This field may be left blank if heating-only mode is used")]
        [JsonProperty("cooling_coil_object_type")]
        public ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_CoolingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_CoolingCoilObjectType), "CoilCoolingDXVariableRefrigerantFlow");
        

        [Description("Cooling Coil Type must be Coil:Cooling:DX:VariableRefrigerantFlow This field may " +
                     "be left blank if heating-only mode is used")]
        [JsonProperty("cooling_coil_object_name")]
        public string CoolingCoilObjectName { get; set; } = "";
        

        [Description(@"Heating Coil Type must be Coil:Heating:DX:VariableRefrigerantFlow if AirConditioner:VariableRefrigerantFlow is used to model VRF outdoor unit Heating Coil Type must be Coil:Heating:DX:VariableRefrigerantFlow:FluidTemperatureControl if AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl or if AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:HR is used to model VRF outdoor unit This field may be left blank if cooling-only mode is used")]
        [JsonProperty("heating_coil_object_type")]
        public ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_HeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_HeatingCoilObjectType), "CoilHeatingDXVariableRefrigerantFlow");
        

        [Description("Heating Coil Type must be Coil:Heating:DX:VariableRefrigerantFlow This field may " +
                     "be left blank if cooling-only mode is used")]
        [JsonProperty("heating_coil_object_name")]
        public string HeatingCoilObjectName { get; set; } = "";
        

        [JsonProperty("zone_terminal_unit_on_parasitic_electric_energy_use")]
        public System.Nullable<float> ZoneTerminalUnitOnParasiticElectricEnergyUse { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("zone_terminal_unit_off_parasitic_electric_energy_use")]
        public System.Nullable<float> ZoneTerminalUnitOffParasiticElectricEnergyUse { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"If this terminal unit's heating coil is autosized, the heating capacity is sized to be equal to the cooling capacity multiplied by this sizing ratio. This input applies to the terminal unit heating coil and overrides the sizing ratio entered in the AirConditioner:VariableRefrigerantFlow object.")]
        [JsonProperty("rated_heating_capacity_sizing_ratio")]
        public System.Nullable<float> RatedHeatingCapacitySizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty("availability_manager_list_name")]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty("design_specification_zonehvac_sizing_object_name")]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
        

        [Description("works with gas, electric, hot water and steam heating coil.")]
        [JsonProperty("supplemental_heating_coil_object_type")]
        public ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplementalHeatingCoilObjectType SupplementalHeatingCoilObjectType { get; set; } = (ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplementalHeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplementalHeatingCoilObjectType), "CoilHeatingElectric");
        

        [Description("Needs to match in the supplemental heating coil object.")]
        [JsonProperty("supplemental_heating_coil_name")]
        public string SupplementalHeatingCoilName { get; set; } = "";
        

        [Description("Supply air temperature from the supplemental heater will not exceed this value.")]
        [JsonProperty("maximum_supply_air_temperature_from_supplemental_heater")]
        public string MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = (System.String)"Autosize";
        

        [Description("Supplemental heater will not operate when outdoor temperature exceeds this value." +
                     "")]
        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_supplemental_heater_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForSupplementalHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

        [Description(@"Used only for AirloopHVAC equipment on a main branch and defines zone name where thermostat is located. Not required for zone equipment. Leave blank if terminal unit is used in AirLoopHVAC:OutdoorAirSystem:EquipmentList. Required when terminal unit is used on main AirloopHVAC branch and coils are not set point controlled. When terminal unit is used in air loop and is load controlled, this zone's thermostat will control operation.")]
        [JsonProperty("controlling_zone_or_thermostat_location")]
        public string ControllingZoneOrThermostatLocation { get; set; } = "";
    }
}