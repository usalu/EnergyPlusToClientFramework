using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("This object is used for air-source integrated heat pump, a collection of its work" +
                 "ing modes.")]
    [JsonObject("CoilSystem:IntegratedHeatPump:AirSource")]
    public class CoilSystem_IntegratedHeatPump_AirSource : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("supply_hot_water_flow_sensor_node_name")]
        public string SupplyHotWaterFlowSensorNodeName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:Cooling:DX:VariableSpeed objec" +
                     "t.")]
        [JsonProperty("space_cooling_coil_name")]
        public string SpaceCoolingCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:Heating:DX:VariableSpeed objec" +
                     "t.")]
        [JsonProperty("space_heating_coil_name")]
        public string SpaceHeatingCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
                     "p:VariableSpeed object.")]
        [JsonProperty("dedicated_water_heating_coil_name")]
        public string DedicatedWaterHeatingCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
                     "p:VariableSpeed object.")]
        [JsonProperty("scwh_coil_name")]
        public string ScwhCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:Cooling:DX:VariableSpeed objec" +
                     "t.")]
        [JsonProperty("scdwh_cooling_coil_name")]
        public string ScdwhCoolingCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
                     "p:VariableSpeed object.")]
        [JsonProperty("scdwh_water_heating_coil_name")]
        public string ScdwhWaterHeatingCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:Heating:DX:VariableSpeed objec" +
                     "t.")]
        [JsonProperty("shdwh_heating_coil_name")]
        public string ShdwhHeatingCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
                     "p:VariableSpeed object.")]
        [JsonProperty("shdwh_water_heating_coil_name")]
        public string ShdwhWaterHeatingCoilName { get; set; } = "";
        

        [Description("Indoor Temperature above which Indoor Overcooling is Allowed during Cooling Opera" +
                     "tion")]
        [JsonProperty("indoor_temperature_limit_for_scwh_mode")]
        public System.Nullable<float> IndoorTemperatureLimitForScwhMode { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

        [Description("Ambient Temperature above which Indoor Overcooling is Allowed during Cooling Oper" +
                     "ation")]
        [JsonProperty("ambient_temperature_limit_for_scwh_mode")]
        public System.Nullable<float> AmbientTemperatureLimitForScwhMode { get; set; } = (System.Nullable<float>)Single.Parse("27", CultureInfo.InvariantCulture);
        

        [Description("Indoor Temperature above which Water Heating has the higher priority and Space He" +
                     "ating Call Can be ignored.")]
        [JsonProperty("indoor_temperature_above_which_wh_has_higher_priority")]
        public System.Nullable<float> IndoorTemperatureAboveWhichWhHasHigherPriority { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

        [Description("Ambient Temperature above which Water Heating has the higher priority and Space H" +
                     "eating Call Can be ignored.")]
        [JsonProperty("ambient_temperature_above_which_wh_has_higher_priority")]
        public System.Nullable<float> AmbientTemperatureAboveWhichWhHasHigherPriority { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

        [Description("0: match space cooling load in SCWH mode, 1: match water heating load in SCWH mod" +
                     "e")]
        [JsonProperty("flag_to_indicate_load_control_in_scwh_mode")]
        public System.Nullable<float> FlagToIndicateLoadControlInScwhMode { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("minimum_speed_level_for_scwh_mode")]
        public System.Nullable<float> MinimumSpeedLevelForScwhMode { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_water_flow_volume_before_switching_from_scdwh_to_scwh_mode")]
        public System.Nullable<float> MaximumWaterFlowVolumeBeforeSwitchingFromScdwhToScwhMode { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("minimum_speed_level_for_scdwh_mode")]
        public System.Nullable<float> MinimumSpeedLevelForScdwhMode { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_running_time_before_allowing_electric_resistance_heat_use_during_shdwh_mo" +
                      "de")]
        public System.Nullable<float> MaximumRunningTimeBeforeAllowingElectricResistanceHeatUseDuringShdwhMode { get; set; } = (System.Nullable<float>)Single.Parse("360", CultureInfo.InvariantCulture);
        

        [JsonProperty("minimum_speed_level_for_shdwh_mode")]
        public System.Nullable<float> MinimumSpeedLevelForShdwhMode { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}