using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    [Description(@"This object models an air-source heat pump for water heating where the heating coil is wrapped around the tank, which is typical of residential HPWHs. For pumped condenser HPWHs, see WaterHeater:HeatPump:PumpedCondenser. WaterHeater:HeatPump:WrappedCondenser is a compound object that references other component objects - Coil:WaterHeating:AirToWaterHeatPump:Pumped, Fan:OnOff, WaterHeater:Mixed")]
    public class WaterHeater_HeatPump_WrappedCondenser : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. Schedule values of 0 denote the heat pump compressor is off and the parasitic electric energy is also off.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Defines the cut-out temperature where the heat pump compressor turns off. The hea" +
                     "t pump compressor setpoint temperature should always be greater than the water t" +
                     "ank\'s heater (element or burner) setpoint temperature.")]
        [JsonProperty("compressor_setpoint_temperature_schedule_name")]
        public string CompressorSetpointTemperatureScheduleName { get; set; } = "";
        

        [Description(@"Setpoint temperature minus the dead band temperature difference defines the cut-in temperature where the heat pump compressor turns on. The water tank's heater (element or burner) setpoint temperature should always be less than the heat pump compressor cut-in temperature.")]
        [JsonProperty("dead_band_temperature_difference")]
        public System.Nullable<float> DeadBandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("Distance from the bottom of the tank to the bottom of the wrapped condenser.")]
        [JsonProperty("condenser_bottom_location")]
        public System.Nullable<float> CondenserBottomLocation { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Distance from the bottom of the tank to the top of the wrapped condenser.")]
        [JsonProperty("condenser_top_location")]
        public System.Nullable<float> CondenserTopLocation { get; set; } = null;
        

        [Description("Actual air flow rate across the heat pump\'s air coil (evaporator). If autocalcula" +
                     "ted, the air flow rate is set equal to 5.035E-5 m3/s/W times the rated heating c" +
                     "apacity of the heat pump\'s DX coil.")]
        [JsonProperty("evaporator_air_flow_rate")]
        public string EvaporatorAirFlowRate { get; set; } = "";
        

        [Description("Defines the configuration of the airflow path through the air coil and fan sectio" +
                     "n.")]
        [JsonProperty("inlet_air_configuration")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_WrappedCondenser_InletAirConfiguration InletAirConfiguration { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_InletAirConfiguration)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_InletAirConfiguration), "OutdoorAirOnly");
        

        [Description("Zone air exhaust node name if Inlet Air Configuration is ZoneAirOnly or ZoneAndOu" +
                     "tdoorAir. Simply a unique Node Name if Inlet Air Configuration is Schedule. Othe" +
                     "rwise, leave field blank.")]
        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Zone Air Inlet Node Name if Inlet Air Configuration is ZoneAirOnly or ZoneAndOutd" +
                     "oorAir. Simply a unique Node Name if Inlet Air Configuration is Schedule. Otherw" +
                     "ise, leave field blank.")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Outdoor air node name if inlet air configuration is ZoneAndOutdoorAir or OutdoorA" +
                     "irOnly, otherwise leave field blank.")]
        [JsonProperty("outdoor_air_node_name")]
        public string OutdoorAirNodeName { get; set; } = "";
        

        [Description("Simply a unique Node Name if Inlet Air Configuration is ZoneAndOutdoorAir or Outd" +
                     "oorAirOnly, otherwise leave field blank.")]
        [JsonProperty("exhaust_air_node_name")]
        public string ExhaustAirNodeName { get; set; } = "";
        

        [Description("Used only if Inlet Air Configuration is Schedule, otherwise leave blank. Schedule" +
                     " values should be degrees C.")]
        [JsonProperty("inlet_air_temperature_schedule_name")]
        public string InletAirTemperatureScheduleName { get; set; } = "";
        

        [Description("Used only if Inlet Air Configuration is Schedule, otherwise leave blank. Schedule" +
                     " values are entered as a fraction (e.g. 0.5 is equal to 50%RH)")]
        [JsonProperty("inlet_air_humidity_schedule_name")]
        public string InletAirHumidityScheduleName { get; set; } = "";
        

        [Description("Used only if Inlet Air Configuration is ZoneAirOnly or ZoneAndOutdoorAir. Otherwi" +
                     "se, leave field blank.")]
        [JsonProperty("inlet_air_zone_name")]
        public string InletAirZoneName { get; set; } = "";
        

        [Description("Specify the type of water heater tank used by this heat pump water heater.")]
        [JsonProperty("tank_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_WrappedCondenser_TankObjectType TankObjectType { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_TankObjectType)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_TankObjectType), "Empty");
        

        [Description("Needs to match the name used in the corresponding Water Heater object. Must be a " +
                     "WaterHeater:Stratified tank.")]
        [JsonProperty("tank_name")]
        public string TankName { get; set; } = "";
        

        [Description("Used only when the heat pump water heater is connected to a plant loop, otherwise" +
                     " leave blank. Needs to match the name used in the corresponding Water Heater obj" +
                     "ect when connected to a plant loop.")]
        [JsonProperty("tank_use_side_inlet_node_name")]
        public string TankUseSideInletNodeName { get; set; } = "";
        

        [Description("Used only when the heat pump water heater is connected to a plant loop, otherwise" +
                     " leave blank. Needs to match the name used in the corresponding Water Heater obj" +
                     "ect when connected to a plant loop.")]
        [JsonProperty("tank_use_side_outlet_node_name")]
        public string TankUseSideOutletNodeName { get; set; } = "";
        

        [Description("Specify the type of DX coil used by this heat pump water heater. The only valid c" +
                     "hoice is Coil:WaterHeating:AirToWaterHeatPump:Wrapped")]
        [JsonProperty("dx_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_WrappedCondenser_DxCoilObjectType DxCoilObjectType { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_DxCoilObjectType)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_DxCoilObjectType), "Empty");
        

        [Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
                     "p:Wrapped object.")]
        [JsonProperty("dx_coil_name")]
        public string DxCoilName { get; set; } = "";
        

        [Description("Heat pump compressor will not operate when the inlet air dry-bulb temperature is " +
                     "below this value.")]
        [JsonProperty("minimum_inlet_air_temperature_for_compressor_operation")]
        public System.Nullable<float> MinimumInletAirTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Heat pump compressor will not operate when the inlet air dry-bulb temperature is " +
                     "above this value.")]
        [JsonProperty("maximum_inlet_air_temperature_for_compressor_operation")]
        public System.Nullable<float> MaximumInletAirTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("48.88888888889", CultureInfo.InvariantCulture);
        

        [Description("If Zone is selected, Inlet Air Configuration must be ZoneAirOnly or ZoneAndOutdoo" +
                     "rAir. If Schedule is selected, then you must provide a Compressor Ambient Temper" +
                     "ature Schedule Name below.")]
        [JsonProperty("compressor_location")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_WrappedCondenser_CompressorLocation CompressorLocation { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_CompressorLocation)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_CompressorLocation), "Outdoors");
        

        [Description("Used only if Compressor Location is Schedule, otherwise leave field blank.")]
        [JsonProperty("compressor_ambient_temperature_schedule_name")]
        public string CompressorAmbientTemperatureScheduleName { get; set; } = "";
        

        [Description("Specify the type of fan used by this heat pump water heater. The only valid choic" +
                     "es are Fan:SystemModel or Fan:OnOff.")]
        [JsonProperty("fan_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_WrappedCondenser_FanObjectType FanObjectType { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_FanObjectType)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_FanObjectType), "Empty");
        

        [Description("Needs to match the name used in the corresponding Fan:SystemModel or Fan:OnOff ob" +
                     "ject.")]
        [JsonProperty("fan_name")]
        public string FanName { get; set; } = "";
        

        [Description("BlowThrough means the fan is located before the air coil (upstream). DrawThrough " +
                     "means the fan is located after the air coil (downstream).")]
        [JsonProperty("fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_WrappedCondenser_FanPlacement FanPlacement { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_FanPlacement)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_FanPlacement), "DrawThrough");
        

        [Description("Parasitic electric power consumed when the heat pump compressor operates. Does no" +
                     "t contribute to water heating but can impact the zone air heat balance.")]
        [JsonProperty("on_cycle_parasitic_electric_load")]
        public System.Nullable<float> OnCycleParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Parasitic electric power consumed when the heat pump compressor is off. Does not " +
                     "contribute to water heating but can impact the zone air heat balance. Off-cycle " +
                     "parasitic power is 0 when the availability schedule is 0.")]
        [JsonProperty("off_cycle_parasitic_electric_load")]
        public System.Nullable<float> OffCycleParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field determines if the parasitic electric load impacts the zone air heat ba" +
                     "lance. If Zone is selected, Inlet Air Configuration must be ZoneAirOnly or ZoneA" +
                     "ndOutdoorAir.")]
        [JsonProperty("parasitic_heat_rejection_location")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_WrappedCondenser_ParasiticHeatRejectionLocation ParasiticHeatRejectionLocation { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_ParasiticHeatRejectionLocation)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_ParasiticHeatRejectionLocation), "Outdoors");
        

        [Description("Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise leave fi" +
                     "eld blank.")]
        [JsonProperty("inlet_air_mixer_node_name")]
        public string InletAirMixerNodeName { get; set; } = "";
        

        [Description("Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise leave fi" +
                     "eld blank.")]
        [JsonProperty("outlet_air_splitter_node_name")]
        public string OutletAirSplitterNodeName { get; set; } = "";
        

        [Description(@"Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise leave field blank. Schedule values define whether the heat pump draws its inlet air from the zone, outdoors or a combination of zone and outdoor air. A schedule value of 0 denotes inlet air is drawn only from the zone. A schedule value of 1 denotes inlet air is drawn only from outdoors. Schedule values between 0 and 1 denote a mixture of zone and outdoor air proportional to the schedule value.")]
        [JsonProperty("inlet_air_mixer_schedule_name")]
        public string InletAirMixerScheduleName { get; set; } = "";
        

        [Description(@"MutuallyExclusive means that once the tank heating element is active the heat pump is shut down until setpoint is reached. Simultaneous (default) means that both the tank heating element and heat pump are used at the same time recover the tank temperature.")]
        [JsonProperty("tank_element_control_logic")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_WrappedCondenser_TankElementControlLogic TankElementControlLogic { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_TankElementControlLogic)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_TankElementControlLogic), "Simultaneous");
        

        [Description("Used to indicate height of control sensor if Tank Object Type is WaterHeater:Stra" +
                     "tified If left blank, it will default to the height of Heater1")]
        [JsonProperty("control_sensor_1_height_in_stratified_tank")]
        public System.Nullable<float> ControlSensor1HeightInStratifiedTank { get; set; } = null;
        

        [Description("Weight to give Control Sensor 1 temperature")]
        [JsonProperty("control_sensor_1_weight")]
        public System.Nullable<float> ControlSensor1Weight { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Used to indicate height of control sensor if Tank Object Type is WaterHeater:Stra" +
                     "tified If left blank, it will default to the height of Heater2 The weight of thi" +
                     "s control sensor will be 1 - (wt. of control sensor 1)")]
        [JsonProperty("control_sensor_2_height_in_stratified_tank")]
        public System.Nullable<float> ControlSensor2HeightInStratifiedTank { get; set; } = null;
    }
}