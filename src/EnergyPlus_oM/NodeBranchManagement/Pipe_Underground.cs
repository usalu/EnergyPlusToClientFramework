using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("Buried Pipe model: For pipes buried at a depth less than one meter, this is an al" +
                 "ternative object to: HeatExchanger:Surface")]
    public class Pipe_Underground : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [JsonProperty("fluid_inlet_node_name")]
        public string FluidInletNodeName { get; set; } = "";
        

        [JsonProperty("fluid_outlet_node_name")]
        public string FluidOutletNodeName { get; set; } = "";
        

        [JsonProperty("sun_exposure")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Pipe_Underground_SunExposure SunExposure { get; set; } = (Pipe_Underground_SunExposure)Enum.Parse(typeof(Pipe_Underground_SunExposure), "NoSun");
        

        [Description("pipe thickness is defined in the Construction object")]
        [JsonProperty("pipe_inside_diameter")]
        public System.Nullable<float> PipeInsideDiameter { get; set; } = null;
        

        [JsonProperty("pipe_length")]
        public System.Nullable<float> PipeLength { get; set; } = null;
        

        [JsonProperty("soil_material_name")]
        public string SoilMaterialName { get; set; } = "";
        

        [JsonProperty("undisturbed_ground_temperature_model_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Pipe_Underground_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (Pipe_Underground_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(Pipe_Underground_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

        [JsonProperty("undisturbed_ground_temperature_model_name")]
        public string UndisturbedGroundTemperatureModelName { get; set; } = "";
    }
}