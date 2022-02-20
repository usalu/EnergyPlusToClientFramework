using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description(@"This object can be used with CoilSystem:Cooling:DX to model on/off cycling control of single stage air systems. Setpoints are modulated to run coil full on or full off depending on zone conditions. Intended for use with ZoneControl:Thermostat:StagedDualSetpoint")]
    [JsonObject("SetpointManager:SingleZone:OneStageCooling")]
    public class SetpointManager_SingleZone_OneStageCooling : BHoMObject
    {
        

        [Description("This is the setpoint value applied when cooling device is to cycle ON")]
        [JsonProperty("cooling_stage_on_supply_air_setpoint_temperature")]
        public System.Nullable<float> CoolingStageOnSupplyAirSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-99", CultureInfo.InvariantCulture);
        

        [Description("This is the setpoint value applied when cooling device is to cycle OFF")]
        [JsonProperty("cooling_stage_off_supply_air_setpoint_temperature")]
        public System.Nullable<float> CoolingStageOffSupplyAirSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("99", CultureInfo.InvariantCulture);
        

        [JsonProperty("control_zone_name")]
        public string ControlZoneName { get; set; } = "";
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}