using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object represents an air distribution node in the AirflowNetwork model.")]
    [JsonObject("AirflowNetwork:Distribution:Node")]
    public class AirflowNetwork_Distribution_Node : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"Designates node names defined in another object. The node name may occur in air branches. Enter a node name to represent a node already defined in an air loop. Leave this field blank if the Node or Object Type field below is entered as AirLoopHVAC:ZoneMixer, AirLoopHVAC:ZoneSplitter, AirLoopHVAC:OutdoorAirSystem, or Other.")]
        [JsonProperty("component_name_or_node_name")]
        public string ComponentNameOrNodeName { get; set; } = "";
        

        [Description(@"Designates Node type for the Node or Component Name defined in the field above. AirLoopHVAC:ZoneMixer -- Represents a AirLoopHVAC:ZoneMixer object. AirLoopHVAC:ZoneSplitter -- Represents a AirLoopHVAC:ZoneSplitter object. AirLoopHVAC:OutdoorAirSystem -- Represents an AirLoopHVAC:OutdoorAirSystem object. OAMixerOutdoorAirStreamNode -- Represents an external node used in the OutdoorAir:Mixer OutdoorAir:NodeList -- Represents an external node when a heat exchanger is used before the OutdoorAir:Mixer OutdoorAir:Node -- Represents an external node when a heat exchanger is used before the OutdoorAir:Mixer Other -- none of the above, the Node name already defined in the previous field is part of an air loop.")]
        [JsonProperty("component_object_type_or_node_type")]
        public AirflowNetwork_Distribution_Node_ComponentObjectTypeOrNodeType ComponentObjectTypeOrNodeType { get; set; } = (AirflowNetwork_Distribution_Node_ComponentObjectTypeOrNodeType)Enum.Parse(typeof(AirflowNetwork_Distribution_Node_ComponentObjectTypeOrNodeType), "Other");
        

        [Description("Enter the reference height used to calculate the relative pressure.")]
        [JsonProperty("node_height")]
        public System.Nullable<float> NodeHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}