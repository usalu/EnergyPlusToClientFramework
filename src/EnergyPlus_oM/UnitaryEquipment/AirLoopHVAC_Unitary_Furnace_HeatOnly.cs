using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    [Description("Unitary system, heating-only with constant volume supply fan (continuous or cycli" +
                 "ng) and heating coil (gas, electric, hot water, or steam). Identical to AirLoopH" +
                 "VAC:UnitaryHeatOnly.")]
    [JsonObject("AirLoopHVAC:Unitary:Furnace:HeatOnly")]
    public class AirLoopHVAC_Unitary_Furnace_HeatOnly : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("furnace_air_inlet_node_name")]
        public string FurnaceAirInletNodeName { get; set; } = "";
        

        [JsonProperty("furnace_air_outlet_node_name")]
        public string FurnaceAirOutletNodeName { get; set; } = "";
        

        [Description(@"A fan operating mode schedule value of 0 indicates cycling fan mode (supply air fan cycles on and off in tandem with the heating coil). Any other schedule value indicates continuous fan mode (supply air fan operates continuously regardless of heating coil operation). Leaving this schedule name blank will default to cycling fan mode for the entire simulation period.")]
        [JsonProperty("supply_air_fan_operating_mode_schedule_name")]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [JsonProperty("maximum_supply_air_temperature")]
        public string MaximumSupplyAirTemperature { get; set; } = (System.String)"80";
        

        [Description("This value should be > 0 and <= than the fan air flow rate.")]
        [JsonProperty("heating_supply_air_flow_rate")]
        public string HeatingSupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("controlling_zone_or_thermostat_location")]
        public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

        [Description("Fan:ConstantVolume only works with continuous fan operating mode (i.e. fan operat" +
                     "ing mode schedule values are greater than 0).")]
        [JsonProperty("supply_fan_object_type")]
        public AirLoopHVAC_Unitary_Furnace_HeatOnly_SupplyFanObjectType SupplyFanObjectType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatOnly_SupplyFanObjectType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatOnly_SupplyFanObjectType), "FanConstantVolume");
        

        [JsonProperty("supply_fan_name")]
        public string SupplyFanName { get; set; } = "";
        

        [JsonProperty("fan_placement")]
        public AirLoopHVAC_Unitary_Furnace_HeatOnly_FanPlacement FanPlacement { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatOnly_FanPlacement)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatOnly_FanPlacement), "BlowThrough");
        

        [Description("works with gas, electric, hot water and steam heating coils")]
        [JsonProperty("heating_coil_object_type")]
        public AirLoopHVAC_Unitary_Furnace_HeatOnly_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_Unitary_Furnace_HeatOnly_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_Unitary_Furnace_HeatOnly_HeatingCoilObjectType), "CoilHeatingElectric");
        

        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
    }
}