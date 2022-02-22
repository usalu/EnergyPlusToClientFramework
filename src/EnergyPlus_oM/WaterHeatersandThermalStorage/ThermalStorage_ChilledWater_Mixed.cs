using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    [Description("Chilled water storage with a well-mixed, single-node tank. The chilled water is \"" +
                 "used\" by drawing from the \"Use Side\" of the water tank. The tank is indirectly c" +
                 "harged by circulating cold water through the \"Source Side\" of the water tank.")]
    [JsonObject("ThermalStorage:ChilledWater:Mixed")]
    public class ThermalStorage_ChilledWater_Mixed : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("tank_volume")]
        public System.Nullable<float> TankVolume { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [JsonProperty("setpoint_temperature_schedule_name")]
        public string SetpointTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("deadband_temperature_difference")]
        public System.Nullable<float> DeadbandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("minimum_temperature_limit")]
        public System.Nullable<float> MinimumTemperatureLimit { get; set; } = null;
        

        [JsonProperty("nominal_cooling_capacity")]
        public System.Nullable<float> NominalCoolingCapacity { get; set; } = null;
        

        [JsonProperty("ambient_temperature_indicator")]
        public ThermalStorage_ChilledWater_Mixed_AmbientTemperatureIndicator AmbientTemperatureIndicator { get; set; } = (ThermalStorage_ChilledWater_Mixed_AmbientTemperatureIndicator)Enum.Parse(typeof(ThermalStorage_ChilledWater_Mixed_AmbientTemperatureIndicator), "Outdoors");
        

        [JsonProperty("ambient_temperature_schedule_name")]
        public string AmbientTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("ambient_temperature_zone_name")]
        public string AmbientTemperatureZoneName { get; set; } = "";
        

        [Description("required when field Ambient Temperature Indicator=Outdoors")]
        [JsonProperty("ambient_temperature_outdoor_air_node_name")]
        public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

        [JsonProperty("heat_gain_coefficient_from_ambient_temperature")]
        public System.Nullable<float> HeatGainCoefficientFromAmbientTemperature { get; set; } = null;
        

        [JsonProperty("use_side_inlet_node_name")]
        public string UseSideInletNodeName { get; set; } = "";
        

        [JsonProperty("use_side_outlet_node_name")]
        public string UseSideOutletNodeName { get; set; } = "";
        

        [JsonProperty("use_side_heat_transfer_effectiveness")]
        public System.Nullable<float> UseSideHeatTransferEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Availability schedule name for use side. Schedule value > 0 means the system is a" +
                     "vailable. If this field is blank, the system is always available.")]
        [JsonProperty("use_side_availability_schedule_name")]
        public string UseSideAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("use_side_design_flow_rate")]
        public string UseSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("source_side_inlet_node_name")]
        public string SourceSideInletNodeName { get; set; } = "";
        

        [JsonProperty("source_side_outlet_node_name")]
        public string SourceSideOutletNodeName { get; set; } = "";
        

        [JsonProperty("source_side_heat_transfer_effectiveness")]
        public System.Nullable<float> SourceSideHeatTransferEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Availability schedule name for source side. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("source_side_availability_schedule_name")]
        public string SourceSideAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("source_side_design_flow_rate")]
        public string SourceSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("Parameter for autosizing design flow rates for indirectly cooled water tanks time" +
                     " required to lower temperature of entire tank from 14.4C to 9.0C")]
        [JsonProperty("tank_recovery_time")]
        public System.Nullable<float> TankRecoveryTime { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
    }
}