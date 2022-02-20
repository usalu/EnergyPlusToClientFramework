using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Small-scale combined heat and power (micro CHP) electric generator using the model developed by IEA/ECBCS Annex 42 see www.cogen-sim.net. The model was developed for both internal combustion and Stirling cycle engines, but might be used for other types of residential CHP devices.")]
    [JsonObject("Generator:MicroCHP")]
    public class Generator_MicroCHP : BHoMObject
    {
        

        [Description("Enter the name of a Generator:MicroCHP:NonNormalizedParameters object.")]
        [JsonProperty("performance_parameters_name")]
        public string PerformanceParametersName { get; set; } = "";
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("cooling_water_inlet_node_name")]
        public string CoolingWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("cooling_water_outlet_node_name")]
        public string CoolingWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelSupply object.")]
        [JsonProperty("generator_fuel_supply_name")]
        public string GeneratorFuelSupplyName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
    }
}