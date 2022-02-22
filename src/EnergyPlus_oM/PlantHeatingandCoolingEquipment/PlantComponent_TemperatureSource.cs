using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description(@"Simulates an object of pre-determined (constant or scheduled) source temperature The object introduces fluid into the plant loop at the specified temperature and at the same flow rate as the fluid enters the component Fluid entering the component vanishes equivalent to the relief air in an air system")]
    [JsonObject("PlantComponent:TemperatureSource")]
    public class PlantComponent_TemperatureSource : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Name of the source inlet node")]
        [JsonProperty("inlet_node")]
        public string InletNode { get; set; } = "";
        

        [Description("Name of the source outlet node")]
        [JsonProperty("outlet_node")]
        public string OutletNode { get; set; } = "";
        

        [Description("The design volumetric flow rate for this source")]
        [JsonProperty("design_volume_flow_rate")]
        public string DesignVolumeFlowRate { get; set; } = "";
        

        [JsonProperty("temperature_specification_type")]
        public PlantComponent_TemperatureSource_TemperatureSpecificationType TemperatureSpecificationType { get; set; } = (PlantComponent_TemperatureSource_TemperatureSpecificationType)Enum.Parse(typeof(PlantComponent_TemperatureSource_TemperatureSpecificationType), "Constant");
        

        [Description("Used if Temperature Specification Type = Constant")]
        [JsonProperty("source_temperature")]
        public System.Nullable<float> SourceTemperature { get; set; } = null;
        

        [Description("Used if Temperature Specification Type = Scheduled")]
        [JsonProperty("source_temperature_schedule_name")]
        public string SourceTemperatureScheduleName { get; set; } = "";
    }
}