using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [Description("Models hybrid photovoltaic-thermal (PVT) solar collectors that convert incident s" +
                 "olar energy into both electricity and useful thermal energy by heating air or wa" +
                 "ter.")]
    [JsonObject("SolarCollector:FlatPlate:PhotovoltaicThermal")]
    public class SolarCollector_FlatPlate_PhotovoltaicThermal : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("surface_name")]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty("photovoltaic_thermal_model_performance_name")]
        public string PhotovoltaicThermalModelPerformanceName { get; set; } = "";
        

        [Description("Enter the name of a Generator:Photovoltaic object.")]
        [JsonProperty("photovoltaic_name")]
        public string PhotovoltaicName { get; set; } = "";
        

        [JsonProperty("thermal_working_fluid_type")]
        public SolarCollector_FlatPlate_PhotovoltaicThermal_ThermalWorkingFluidType ThermalWorkingFluidType { get; set; } = (SolarCollector_FlatPlate_PhotovoltaicThermal_ThermalWorkingFluidType)Enum.Parse(typeof(SolarCollector_FlatPlate_PhotovoltaicThermal_ThermalWorkingFluidType), "Air");
        

        [JsonProperty("water_inlet_node_name")]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty("water_outlet_node_name")]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("design_flow_rate")]
        public string DesignFlowRate { get; set; } = "";
    }
}