using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Direct expansion (DX) cooling coil and condensing unit (includes electric compressor and condenser fan), two-stage with humidity control mode (e.g. sub-cool or hot gas reheat). Optional inputs for moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Requires two to four sets of performance data, see CoilPerformance:DX:Cooling. Stages are modeled as a face-split coil.")]
    public class Coil_Cooling_DX_TwoStageWithHumidityControlMode : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("crankcase_heater_capacity")]
        public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [JsonProperty("number_of_capacity_stages")]
        public System.Nullable<float> NumberOfCapacityStages { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("number_of_enhanced_dehumidification_modes")]
        public System.Nullable<float> NumberOfEnhancedDehumidificationModes { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("normal_mode_stage_1_coil_performance_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage1CoilPerformanceObjectType NormalModeStage1CoilPerformanceObjectType { get; set; } = (Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage1CoilPerformanceObjectType)Enum.Parse(typeof(Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage1CoilPerformanceObjectType), "CoilPerformanceDXCooling");
        

        [JsonProperty("normal_mode_stage_1_coil_performance_name")]
        public string NormalModeStage1CoilPerformanceName { get; set; } = "";
        

        [JsonProperty("normal_mode_stage_1_2_coil_performance_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage12CoilPerformanceObjectType NormalModeStage12CoilPerformanceObjectType { get; set; } = (Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage12CoilPerformanceObjectType)Enum.Parse(typeof(Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage12CoilPerformanceObjectType), "CoilPerformanceDXCooling");
        

        [JsonProperty("normal_mode_stage_1_2_coil_performance_name")]
        public string NormalModeStage12CoilPerformanceName { get; set; } = "";
        

        [JsonProperty("dehumidification_mode_1_stage_1_coil_performance_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage1CoilPerformanceObjectType DehumidificationMode1Stage1CoilPerformanceObjectType { get; set; } = (Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage1CoilPerformanceObjectType)Enum.Parse(typeof(Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage1CoilPerformanceObjectType), "CoilPerformanceDXCooling");
        

        [JsonProperty("dehumidification_mode_1_stage_1_coil_performance_name")]
        public string DehumidificationMode1Stage1CoilPerformanceName { get; set; } = "";
        

        [JsonProperty("dehumidification_mode_1_stage_1_2_coil_performance_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage12CoilPerformanceObjectType DehumidificationMode1Stage12CoilPerformanceObjectType { get; set; } = (Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage12CoilPerformanceObjectType)Enum.Parse(typeof(Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage12CoilPerformanceObjectType), "CoilPerformanceDXCooling");
        

        [JsonProperty("dehumidification_mode_1_stage_1_2_coil_performance_name")]
        public string DehumidificationMode1Stage12CoilPerformanceName { get; set; } = "";
        

        [JsonProperty("supply_water_storage_tank_name")]
        public string SupplyWaterStorageTankName { get; set; } = "";
        

        [JsonProperty("condensate_collection_water_storage_tank_name")]
        public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

        [JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
        public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-25", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, the heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the DX coil is off.")]
        [JsonProperty("basin_heater_capacity")]
        public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
                     "or dry-bulb temperature when the basin heater turns on.")]
        [JsonProperty("basin_heater_setpoint_temperature")]
        public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty("basin_heater_operating_schedule_name")]
        public string BasinHeaterOperatingScheduleName { get; set; } = "";
    }
}