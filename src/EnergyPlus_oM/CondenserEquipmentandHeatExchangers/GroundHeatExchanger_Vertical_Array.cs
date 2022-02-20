using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description(null)]
    [JsonObject("GroundHeatExchanger:Vertical:Array")]
    public class GroundHeatExchanger_Vertical_Array : BHoMObject
    {
        

        [JsonProperty("ghe_vertical_properties_object_name")]
        public string GheVerticalPropertiesObjectName { get; set; } = "";
        

        [JsonProperty("number_of_boreholes_in_x_direction")]
        public System.Nullable<float> NumberOfBoreholesInXDirection { get; set; } = null;
        

        [JsonProperty("number_of_boreholes_in_y_direction")]
        public System.Nullable<float> NumberOfBoreholesInYDirection { get; set; } = null;
        

        [JsonProperty("borehole_spacing")]
        public System.Nullable<float> BoreholeSpacing { get; set; } = null;
    }
}