using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("Pipe model with transport delay and heat transfer to the environment.")]
    [JsonObject("Pipe:Indoor")]
    public class Pipe_Indoor : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [JsonProperty("fluid_inlet_node_name")]
        public string FluidInletNodeName { get; set; } = "";
        

        [JsonProperty("fluid_outlet_node_name")]
        public string FluidOutletNodeName { get; set; } = "";
        

        [JsonProperty("environment_type")]
        public Pipe_Indoor_EnvironmentType EnvironmentType { get; set; } = (Pipe_Indoor_EnvironmentType)Enum.Parse(typeof(Pipe_Indoor_EnvironmentType), "Zone");
        

        [JsonProperty("ambient_temperature_zone_name")]
        public string AmbientTemperatureZoneName { get; set; } = "";
        

        [JsonProperty("ambient_temperature_schedule_name")]
        public string AmbientTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("ambient_air_velocity_schedule_name")]
        public string AmbientAirVelocityScheduleName { get; set; } = "";
        

        [JsonProperty("pipe_inside_diameter")]
        public System.Nullable<float> PipeInsideDiameter { get; set; } = null;
        

        [JsonProperty("pipe_length")]
        public System.Nullable<float> PipeLength { get; set; } = null;
    }
}