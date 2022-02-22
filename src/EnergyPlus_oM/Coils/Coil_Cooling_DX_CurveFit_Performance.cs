using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("DX cooling coil performance specification referencing one or more operating modes" +
                 ". Mode 1 is always the base design operating mode. Additional modes are optional" +
                 " states such as subcool reheat for humidity control.")]
    public class Coil_Cooling_DX_CurveFit_Performance : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("crankcase_heater_capacity")]
        public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
        public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-25", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description(@"Enter pressure drop for the unit containing the coil. This value is only used to calculate Energy Efficiency Ratio (EER), Integrated Energy Efficiency Ratio (IEER), and the Standard Rating (Net) Cooling Capacity. This value is not used for modeling the evaporator fan during simulations.")]
        [JsonProperty("unit_internal_static_air_pressure")]
        public System.Nullable<float> UnitInternalStaticAirPressure { get; set; } = null;
        

        [JsonProperty("capacity_control_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_CurveFit_Performance_CapacityControlMethod CapacityControlMethod { get; set; } = (Coil_Cooling_DX_CurveFit_Performance_CapacityControlMethod)Enum.Parse(typeof(Coil_Cooling_DX_CurveFit_Performance_CapacityControlMethod), "Discrete");
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, the heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the DX coil is off.")]
        [JsonProperty("evaporative_condenser_basin_heater_capacity")]
        public System.Nullable<float> EvaporativeCondenserBasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
                     "or dry-bulb temperature when the basin heater turns on.")]
        [JsonProperty("evaporative_condenser_basin_heater_setpoint_temperature")]
        public System.Nullable<float> EvaporativeCondenserBasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty("evaporative_condenser_basin_heater_operating_schedule_name")]
        public string EvaporativeCondenserBasinHeaterOperatingScheduleName { get; set; } = "";
        

        [JsonProperty("compressor_fuel_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_CurveFit_Performance_CompressorFuelType CompressorFuelType { get; set; } = (Coil_Cooling_DX_CurveFit_Performance_CompressorFuelType)Enum.Parse(typeof(Coil_Cooling_DX_CurveFit_Performance_CompressorFuelType), "Electricity");
        

        [Description("Operating Mode 1 is always used as the base design operating mode.")]
        [JsonProperty("base_operating_mode")]
        public string BaseOperatingMode { get; set; } = "";
        

        [Description(@"The alternative operating mode is used for enhanced dehumidification. If this is blank, the coil will always operate in the base operating mode. If an alternate mode is defined here, the coil will use the enhanced mode if activated by the parent system controls.")]
        [JsonProperty("alternative_operating_mode_1")]
        public string AlternativeOperatingMode1 { get; set; } = "";
        

        [Description(@"The alternative operating mode is used for enhanced dehumidification. If this is blank, the coil will always operate in the base operating mode or Alternative Mode 1. If both Alternative Operating Mode 1 and Mode 2 are defined here, the coil will perform both Subcool and Reheat modes for enhanced dehumidification. Alternative Operating Mode 1 is used as Subcool mode, and Alternative Operating Mode 2 is used as Reheat mode.")]
        [JsonProperty("alternative_operating_mode_2")]
        public string AlternativeOperatingMode2 { get; set; } = "";
    }
}