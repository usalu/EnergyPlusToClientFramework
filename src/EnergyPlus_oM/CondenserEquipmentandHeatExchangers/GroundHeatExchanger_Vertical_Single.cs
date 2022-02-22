using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description(null)]
    public class GroundHeatExchanger_Vertical_Single : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("ghe_vertical_properties_object_name")]
        public string GheVerticalPropertiesObjectName { get; set; } = "";
        

        [JsonProperty("x_location")]
        public System.Nullable<float> XLocation { get; set; } = null;
        

        [JsonProperty("y_location")]
        public System.Nullable<float> YLocation { get; set; } = null;
    }
}