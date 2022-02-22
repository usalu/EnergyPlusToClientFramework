using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description(null)]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatExchanger_Vertical_Single : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("ghe_vertical_properties_object_name")]
        public string GheVerticalPropertiesObjectName { get; set; } = "";
        

        [JsonProperty("x_location")]
        public System.Nullable<float> XLocation { get; set; } = null;
        

        [JsonProperty("y_location")]
        public System.Nullable<float> YLocation { get; set; } = null;
    }
}