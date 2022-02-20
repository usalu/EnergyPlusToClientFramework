using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description(@"This object can be used with CoilSystem:Heating:DX, Coil:Heating:Fuel, Coil:Heating:Electric to model on/off cycling control of single stage air systems. Setpoints are modulated to run coil full on or full off depending on zone conditions. Intended for use with ZoneControl:Thermostat:StagedDualSetpoint.")]
    [JsonObject("SetpointManager:SingleZone:OneStageHeating")]
    public class SetpointManager_SingleZone_OneStageHeating : BHoMObject
    {
        

        [Description("This is the setpoint value applied when heating device is to cycle ON")]
        [JsonProperty("heating_stage_on_supply_air_setpoint_temperature")]
        public System.Nullable<float> HeatingStageOnSupplyAirSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("99", CultureInfo.InvariantCulture);
        

        [Description("This is the setpoint value applied when heating device is to cycle OFF")]
        [JsonProperty("heating_stage_off_supply_air_setpoint_temperature")]
        public System.Nullable<float> HeatingStageOffSupplyAirSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-99", CultureInfo.InvariantCulture);
        

        [JsonProperty("control_zone_name")]
        public string ControlZoneName { get; set; } = "";
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}