using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Virtual container component that consists of a DX cooling coil and its associated" +
                 " controls. This control object supports several different types of DX cooling co" +
                 "ils and may be placed directly in an air loop branch or outdoor air equipment li" +
                 "st.")]
    public class CoilSystem_Cooling_DX : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("dx_cooling_coil_system_inlet_node_name")]
        public string DxCoolingCoilSystemInletNodeName { get; set; } = "";
        

        [JsonProperty("dx_cooling_coil_system_outlet_node_name")]
        public string DxCoolingCoilSystemOutletNodeName { get; set; } = "";
        

        [JsonProperty("dx_cooling_coil_system_sensor_node_name")]
        public string DxCoolingCoilSystemSensorNodeName { get; set; } = "";
        

        [JsonProperty("cooling_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CoilSystem_Cooling_DX_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (CoilSystem_Cooling_DX_CoolingCoilObjectType)Enum.Parse(typeof(CoilSystem_Cooling_DX_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
        

        [Description(@"None = meet sensible load only Multimode = activate enhanced dehumidification mode as needed and meet sensible load. If no sensible load exists, and Run on Latent Load = Yes, and a latent load exists, the unit will operate to meet the latent load. Valid only with Coil:Cooling:DX:TwoStageWithHumidityControlMode or CoilSystem:Cooling:DX:HeatExchangerAssisted. CoolReheat = cool beyond the dry-bulb setpoint. as required to meet the humidity setpoint. Valid for all coil types. For all dehumidification controls, the max humidity setpoint on the Sensor Node is used. SetpointManager:SingleZone:Humidity:Maximum, SetpointManager:MultiZone:Humidity:Maximum, or SetpointManager:MultiZone:MaximumHumidity:Average, and SetpointManager:OutdoorAirPretreat (optional) objects.")]
        [JsonProperty("dehumidification_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CoilSystem_Cooling_DX_DehumidificationControlType DehumidificationControlType { get; set; } = (CoilSystem_Cooling_DX_DehumidificationControlType)Enum.Parse(typeof(CoilSystem_Cooling_DX_DehumidificationControlType), "None");
        

        [Description("If Yes, unit will run if there is a sensible load. If No, unit will not run if th" +
                     "ere is only a sensible load. Dehumidification controls will be active if specifi" +
                     "ed.")]
        [JsonProperty("run_on_sensible_load")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes RunOnSensibleLoad { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("If Yes, unit will run if there is a latent load. even if there is no sensible loa" +
                     "d. If No, unit will not run only if there is a latent load. Dehumidification con" +
                     "trols will be active if specified.")]
        [JsonProperty("run_on_latent_load")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes RunOnLatentLoad { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description(@"This input field is designed for use with DX cooling coils with low air flow to capacity ratio range (100 - 300 cfm/ton). Typical application is 100% dedicated outdoor air system (DOAS). Other air loop or zone HVAC systems with low flow to capacity ratio range may also use this input field. If Yes, the DX cooling coil runs as 100% DOAS DX coil or low flow to capacity ratio range. If No, the DX cooling coil runs as a regular DX coil. If left blank the default is regular DX coil.")]
        [JsonProperty("use_outdoor_air_dx_cooling_coil")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseOutdoorAirDxCoolingCoil { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("DX cooling coil leaving minimum air temperature defines the minimum DX cooling co" +
                     "il leaving air temperature that should be maintained to avoid frost formation. T" +
                     "his input field is optional and only used along with the input field above.")]
        [JsonProperty("outdoor_air_dx_cooling_coil_leaving_minimum_air_temperature")]
        public System.Nullable<float> OutdoorAirDxCoolingCoilLeavingMinimumAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
}