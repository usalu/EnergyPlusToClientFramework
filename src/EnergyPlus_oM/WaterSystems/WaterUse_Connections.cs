using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    [Description(@"A subsystem that groups together multiple WaterUse:Equipment components. As its name suggests, the object provides connections that are shared by these components, including: 1. Inlet node and outlet node connections to a plant loop 2. Connections to WaterUse:Storage objects to store and draw reclaimed water 3. Internal connections to simulate drainwater heat recovery.")]
    public class WaterUse_Connections : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [Description("If blank, or tank is empty, defaults to fresh water from the mains")]
        [JsonProperty("supply_water_storage_tank_name")]
        public string SupplyWaterStorageTankName { get; set; } = "";
        

        [JsonProperty("reclamation_water_storage_tank_name")]
        public string ReclamationWaterStorageTankName { get; set; } = "";
        

        [Description("Defaults to cold water supply temperature")]
        [JsonProperty("hot_water_supply_temperature_schedule_name")]
        public string HotWaterSupplyTemperatureScheduleName { get; set; } = "";
        

        [Description("Defaults to water temperatures calculated by Site:WaterMainsTemperature object")]
        [JsonProperty("cold_water_supply_temperature_schedule_name")]
        public string ColdWaterSupplyTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("drain_water_heat_exchanger_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterUse_Connections_DrainWaterHeatExchangerType DrainWaterHeatExchangerType { get; set; } = (WaterUse_Connections_DrainWaterHeatExchangerType)Enum.Parse(typeof(WaterUse_Connections_DrainWaterHeatExchangerType), "None");
        

        [JsonProperty("drain_water_heat_exchanger_destination")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterUse_Connections_DrainWaterHeatExchangerDestination DrainWaterHeatExchangerDestination { get; set; } = (WaterUse_Connections_DrainWaterHeatExchangerDestination)Enum.Parse(typeof(WaterUse_Connections_DrainWaterHeatExchangerDestination), "Plant");
        

        [JsonProperty("drain_water_heat_exchanger_u_factor_times_area")]
        public System.Nullable<float> DrainWaterHeatExchangerUFactorTimesArea { get; set; } = null;
        

        [JsonProperty("connections")]
        public string Connections { get; set; } = "";
    }
}