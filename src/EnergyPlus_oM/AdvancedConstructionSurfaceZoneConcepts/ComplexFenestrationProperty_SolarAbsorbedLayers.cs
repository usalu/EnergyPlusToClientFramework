using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Used to provide solar radiation absorbed in fenestration layers. References surfa" +
                 "ce-construction pair and if that pair is used in a simulation, then program will" +
                 " use value provided in schedules instead of calculating it.")]
    [JsonObject("ComplexFenestrationProperty:SolarAbsorbedLayers")]
    public class ComplexFenestrationProperty_SolarAbsorbedLayers : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("fenestration_surface")]
        public string FenestrationSurface { get; set; } = "";
        

        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [Description("Values in schedule are expected to be in W/m2")]
        [JsonProperty("layer_1_solar_radiation_absorbed_schedule_name")]
        public string Layer1SolarRadiationAbsorbedScheduleName { get; set; } = "";
        

        [Description("Values in schedule are expected to be in W/m2")]
        [JsonProperty("layer_2_solar_radiation_absorbed_schedule_name")]
        public string Layer2SolarRadiationAbsorbedScheduleName { get; set; } = "";
        

        [Description("Values in schedule are expected to be in W/m2")]
        [JsonProperty("layer_3_solar_radiation_absorbed_schedule_name")]
        public string Layer3SolarRadiationAbsorbedScheduleName { get; set; } = "";
        

        [Description("Values in schedule are expected to be in W/m2")]
        [JsonProperty("layer_4_solar_radiation_absorbed_schedule_name")]
        public string Layer4SolarRadiationAbsorbedScheduleName { get; set; } = "";
        

        [Description("Values in schedule are expected to be in W/m2")]
        [JsonProperty("layer_5_solar_radiation_absorbed_schedule_name")]
        public string Layer5SolarRadiationAbsorbedScheduleName { get; set; } = "";
    }
}