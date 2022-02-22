using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description("A return air path can only contain one AirLoopHVAC:ZoneMixer and one or more AirL" +
                 "oopHVAC:ReturnPlenum objects.")]
    [JsonObject("AirLoopHVAC:ReturnPath")]
    public class AirLoopHVAC_ReturnPath : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("return_air_path_outlet_node_name")]
        public string ReturnAirPathOutletNodeName { get; set; } = "";
        

        [JsonProperty("components")]
        public string Components { get; set; } = "";
    }
}