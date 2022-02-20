using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("Define an air node for some types of nodal room air models")]
    [JsonObject("RoomAir:Node")]
    public class RoomAir_Node : BHoMObject
    {
        

        [JsonProperty("node_type")]
        public EmptyNoYes NodeType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("height_of_nodal_control_volume_center")]
        public System.Nullable<float> HeightOfNodalControlVolumeCenter { get; set; } = null;
        

        [JsonProperty("surface_1_name")]
        public string Surface1Name { get; set; } = "";
        

        [JsonProperty("surface_2_name")]
        public string Surface2Name { get; set; } = "";
        

        [JsonProperty("surface_3_name")]
        public string Surface3Name { get; set; } = "";
        

        [JsonProperty("surface_4_name")]
        public string Surface4Name { get; set; } = "";
        

        [JsonProperty("surface_5_name")]
        public string Surface5Name { get; set; } = "";
        

        [JsonProperty("surface_6_name")]
        public string Surface6Name { get; set; } = "";
        

        [JsonProperty("surface_7_name")]
        public string Surface7Name { get; set; } = "";
        

        [JsonProperty("surface_8_name")]
        public string Surface8Name { get; set; } = "";
        

        [JsonProperty("surface_9_name")]
        public string Surface9Name { get; set; } = "";
        

        [JsonProperty("surface_10_name")]
        public string Surface10Name { get; set; } = "";
        

        [JsonProperty("surface_11_name")]
        public string Surface11Name { get; set; } = "";
        

        [JsonProperty("surface_12_name")]
        public string Surface12Name { get; set; } = "";
        

        [JsonProperty("surface_13_name")]
        public string Surface13Name { get; set; } = "";
        

        [JsonProperty("surface_14_name")]
        public string Surface14Name { get; set; } = "";
        

        [JsonProperty("surface_15_name")]
        public string Surface15Name { get; set; } = "";
        

        [JsonProperty("surface_16_name")]
        public string Surface16Name { get; set; } = "";
        

        [JsonProperty("surface_17_name")]
        public string Surface17Name { get; set; } = "";
        

        [JsonProperty("surface_18_name")]
        public string Surface18Name { get; set; } = "";
        

        [JsonProperty("surface_19_name")]
        public string Surface19Name { get; set; } = "";
        

        [JsonProperty("surface_20_name")]
        public string Surface20Name { get; set; } = "";
        

        [JsonProperty("surface_21_name")]
        public string Surface21Name { get; set; } = "";
    }
}