using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("Models vertical ground heat exchangers systems using the response factor approach" +
                 " developed by Eskilson. Response factors are calculated using a finite line sour" +
                 "ce model assuming uniform heat flux at the borehole wall.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatExchanger_System : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty("design_flow_rate")]
        public System.Nullable<float> DesignFlowRate { get; set; } = null;
        

        [JsonProperty("undisturbed_ground_temperature_model_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatExchanger_System_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (GroundHeatExchanger_System_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(GroundHeatExchanger_System_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

        [JsonProperty("undisturbed_ground_temperature_model_name")]
        public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

        [JsonProperty("ground_thermal_conductivity")]
        public System.Nullable<float> GroundThermalConductivity { get; set; } = null;
        

        [JsonProperty("ground_thermal_heat_capacity")]
        public System.Nullable<float> GroundThermalHeatCapacity { get; set; } = null;
        

        [JsonProperty("ghe_vertical_responsefactors_object_name")]
        public string GheVerticalResponsefactorsObjectName { get; set; } = "";
        

        [JsonProperty("ghe_vertical_array_object_name")]
        public string GheVerticalArrayObjectName { get; set; } = "";
        

        [JsonProperty("vertical_well_locations")]
        public string VerticalWellLocations { get; set; } = "";
    }
}