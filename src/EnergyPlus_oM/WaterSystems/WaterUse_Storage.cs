using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    [Description(@"A water storage tank. If the building model is to include any on-site water collection, wells, or storing and reuse of graywater, then a WaterUse:Storage object is needed. Each WaterUse:Storage can serve as a central node and make connections to numerous sources of supply or numerous components with demand. If a maximum capacity is not specified, the tank is assumed to have unlimited capacity.")]
    public class WaterUse_Storage : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("water_quality_subcategory")]
        public string WaterQualitySubcategory { get; set; } = "";
        

        [Description("Defaults to unlimited capacity.")]
        [JsonProperty("maximum_capacity")]
        public System.Nullable<float> MaximumCapacity { get; set; } = null;
        

        [JsonProperty("initial_volume")]
        public System.Nullable<float> InitialVolume { get; set; } = null;
        

        [Description("Defaults to unlimited flow.")]
        [JsonProperty("design_in_flow_rate")]
        public System.Nullable<float> DesignInFlowRate { get; set; } = null;
        

        [Description("Defaults to unlimited flow.")]
        [JsonProperty("design_out_flow_rate")]
        public System.Nullable<float> DesignOutFlowRate { get; set; } = null;
        

        [Description("If blank, overflow is discarded")]
        [JsonProperty("overflow_destination")]
        public string OverflowDestination { get; set; } = "";
        

        [JsonProperty("type_of_supply_controlled_by_float_valve")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterUse_Storage_TypeOfSupplyControlledByFloatValve TypeOfSupplyControlledByFloatValve { get; set; } = (WaterUse_Storage_TypeOfSupplyControlledByFloatValve)Enum.Parse(typeof(WaterUse_Storage_TypeOfSupplyControlledByFloatValve), "GroundwaterWell");
        

        [Description("Lower range of target storage level e.g. float valve kicks on")]
        [JsonProperty("float_valve_on_capacity")]
        public System.Nullable<float> FloatValveOnCapacity { get; set; } = null;
        

        [Description("Upper range of target storage level e.g. float valve kicks off")]
        [JsonProperty("float_valve_off_capacity")]
        public System.Nullable<float> FloatValveOffCapacity { get; set; } = null;
        

        [Description("Lower range of secondary target storage level used to keep tanks at a minimum lev" +
                     "el using mains water if well can\'t keep up")]
        [JsonProperty("backup_mains_capacity")]
        public System.Nullable<float> BackupMainsCapacity { get; set; } = null;
        

        [JsonProperty("other_tank_name")]
        public string OtherTankName { get; set; } = "";
        

        [JsonProperty("water_thermal_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterUse_Storage_WaterThermalMode WaterThermalMode { get; set; } = (WaterUse_Storage_WaterThermalMode)Enum.Parse(typeof(WaterUse_Storage_WaterThermalMode), "ScheduledTemperature");
        

        [JsonProperty("water_temperature_schedule_name")]
        public string WaterTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("ambient_temperature_indicator")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterUse_Storage_AmbientTemperatureIndicator AmbientTemperatureIndicator { get; set; } = (WaterUse_Storage_AmbientTemperatureIndicator)Enum.Parse(typeof(WaterUse_Storage_AmbientTemperatureIndicator), "Outdoors");
        

        [JsonProperty("ambient_temperature_schedule_name")]
        public string AmbientTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("tank_surface_area")]
        public System.Nullable<float> TankSurfaceArea { get; set; } = null;
        

        [JsonProperty("tank_u_value")]
        public System.Nullable<float> TankUValue { get; set; } = null;
        

        [JsonProperty("tank_outside_surface_material_name")]
        public string TankOutsideSurfaceMaterialName { get; set; } = "";
    }
}