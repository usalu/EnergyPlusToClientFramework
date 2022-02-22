using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers
{
    [Description(@"This compound object models a desiccant heat exchanger, an optional heater, and associated fans. The process air stream is the air which is dehumidified. The regeneration air stream is the air which is heated to regenerate the desiccant. The desiccant heat exchanger transfers both sensible and latent energy between the process and regeneration air streams. The desiccant dehumidifier is typically used in an AirLoopHVAC:OutdoorAirSystem, but can also be specified in any AirLoopHVAC.")]
    public class Dehumidifier_Desiccant_System : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("desiccant_heat_exchanger_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_System_DesiccantHeatExchangerObjectType DesiccantHeatExchangerObjectType { get; set; } = (Dehumidifier_Desiccant_System_DesiccantHeatExchangerObjectType)Enum.Parse(typeof(Dehumidifier_Desiccant_System_DesiccantHeatExchangerObjectType), "HeatExchangerDesiccantBalancedFlow");
        

        [JsonProperty("desiccant_heat_exchanger_name")]
        public string DesiccantHeatExchangerName { get; set; } = "";
        

        [JsonProperty("sensor_node_name")]
        public string SensorNodeName { get; set; } = "";
        

        [JsonProperty("regeneration_air_fan_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_System_RegenerationAirFanObjectType RegenerationAirFanObjectType { get; set; } = (Dehumidifier_Desiccant_System_RegenerationAirFanObjectType)Enum.Parse(typeof(Dehumidifier_Desiccant_System_RegenerationAirFanObjectType), "FanConstantVolume");
        

        [JsonProperty("regeneration_air_fan_name")]
        public string RegenerationAirFanName { get; set; } = "";
        

        [JsonProperty("regeneration_air_fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_System_RegenerationAirFanPlacement RegenerationAirFanPlacement { get; set; } = (Dehumidifier_Desiccant_System_RegenerationAirFanPlacement)Enum.Parse(typeof(Dehumidifier_Desiccant_System_RegenerationAirFanPlacement), "DrawThrough");
        

        [Description(@"works with gas, electric, hot water and steam heating coils. For autosizing the regeneration air heating coil the Design Coil Inlet Air Condition used is the outdoor air condition if the desiccant system is on the primary air loop, or else if the desiccant system is on outdoor air system then it is the return air condition. The Design Coil Outlet Air Temperature is the Regeneration Inlet Air Setpoint Temperature specified in the input field below.")]
        [JsonProperty("regeneration_air_heater_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_System_RegenerationAirHeaterObjectType RegenerationAirHeaterObjectType { get; set; } = (Dehumidifier_Desiccant_System_RegenerationAirHeaterObjectType)Enum.Parse(typeof(Dehumidifier_Desiccant_System_RegenerationAirHeaterObjectType), "CoilHeatingElectric");
        

        [JsonProperty("regeneration_air_heater_name")]
        public string RegenerationAirHeaterName { get; set; } = "";
        

        [Description("This value is also used as regeneration air heater design coil air outlet tempera" +
                     "ture for autosizing calculation of the heater.")]
        [JsonProperty("regeneration_inlet_air_setpoint_temperature")]
        public System.Nullable<float> RegenerationInletAirSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("46", CultureInfo.InvariantCulture);
        

        [JsonProperty("companion_cooling_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_System_CompanionCoolingCoilObjectType CompanionCoolingCoilObjectType { get; set; } = (Dehumidifier_Desiccant_System_CompanionCoolingCoilObjectType)Enum.Parse(typeof(Dehumidifier_Desiccant_System_CompanionCoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

        [JsonProperty("companion_cooling_coil_name")]
        public string CompanionCoolingCoilName { get; set; } = "";
        

        [Description("Select Yes if the companion cooling coil is located directly upstream of the desi" +
                     "ccant heat exchanger\'s process air inlet node.")]
        [JsonProperty("companion_cooling_coil_upstream_of_dehumidifier_process_inlet")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes CompanionCoolingCoilUpstreamOfDehumidifierProcessInlet { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("companion_coil_regeneration_air_heating")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes CompanionCoilRegenerationAirHeating { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("exhaust_fan_maximum_flow_rate")]
        public System.Nullable<float> ExhaustFanMaximumFlowRate { get; set; } = null;
        

        [JsonProperty("exhaust_fan_maximum_power")]
        public System.Nullable<float> ExhaustFanMaximumPower { get; set; } = null;
        

        [Description("Curve object type must be Curve:Quadratic or Curve:Cubic")]
        [JsonProperty("exhaust_fan_power_curve_name")]
        public string ExhaustFanPowerCurveName { get; set; } = "";
    }
}