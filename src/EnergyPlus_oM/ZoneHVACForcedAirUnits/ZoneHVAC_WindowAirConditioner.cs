using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Window air conditioner. Forced-convection cooling-only unit with supply fan, dire" +
                 "ct expansion (DX) cooling coil, and fixed-position outdoor air mixer.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_WindowAirConditioner : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("maximum_supply_air_flow_rate")]
        public string MaximumSupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("maximum_outdoor_air_flow_rate")]
        public string MaximumOutdoorAirFlowRate { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("currently only one OutdoorAir:Mixer object type is available.")]
        [JsonProperty("outdoor_air_mixer_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WindowAirConditioner_OutdoorAirMixerObjectType OutdoorAirMixerObjectType { get; set; } = (ZoneHVAC_WindowAirConditioner_OutdoorAirMixerObjectType)Enum.Parse(typeof(ZoneHVAC_WindowAirConditioner_OutdoorAirMixerObjectType), "OutdoorAirMixer");
        

        [JsonProperty("outdoor_air_mixer_name")]
        public string OutdoorAirMixerName { get; set; } = "";
        

        [Description(@"Fan:ConstantVolume only works when continuous fan operation is used the entire simulation (all supply air fan operating mode schedule values are greater than 0). If any fan operating mode schedule values are 0 a Fan:SystemModel or Fan:OnOff object must be used.")]
        [JsonProperty("supply_air_fan_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WindowAirConditioner_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (ZoneHVAC_WindowAirConditioner_SupplyAirFanObjectType)Enum.Parse(typeof(ZoneHVAC_WindowAirConditioner_SupplyAirFanObjectType), "FanConstantVolume");
        

        [Description("Fan type Fan:ConstantVolume is used with continuous fan and fan type Fan:OnOff is" +
                     " used with cycling Fan.")]
        [JsonProperty("supply_air_fan_name")]
        public string SupplyAirFanName { get; set; } = "";
        

        [JsonProperty("cooling_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WindowAirConditioner_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (ZoneHVAC_WindowAirConditioner_CoolingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_WindowAirConditioner_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

        [JsonProperty("dx_cooling_coil_name")]
        public string DxCoolingCoilName { get; set; } = "";
        

        [Description(@"Enter the name of a schedule that controls fan operation. Schedule Name values of 0 denote cycling fan operation (fan cycles with cooling coil). Schedule values greater than 0 denote constant fan operation (fan runs continually regardless of coil operation). The fan operating mode defaults to cycling fan operation if this field is left blank.")]
        [JsonProperty("supply_air_fan_operating_mode_schedule_name")]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [JsonProperty("fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WindowAirConditioner_FanPlacement FanPlacement { get; set; } = (ZoneHVAC_WindowAirConditioner_FanPlacement)Enum.Parse(typeof(ZoneHVAC_WindowAirConditioner_FanPlacement), "BlowThrough");
        

        [JsonProperty("cooling_convergence_tolerance")]
        public System.Nullable<float> CoolingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty("availability_manager_list_name")]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty("design_specification_zonehvac_sizing_object_name")]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
}