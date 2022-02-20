using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Virtual component consisting of a chilled-water cooling coil and an air-to-air heat exchanger. The air-to-air heat exchanger precools the air entering the cooling coil and reuses this energy to reheat the supply air leaving the cooling coil. This heat exchange process improves the latent removal performance of the cooling coil (lower sensible heat ratio).")]
    [JsonObject("CoilSystem:Cooling:Water:HeatExchangerAssisted")]
    public class CoilSystem_Cooling_Water_HeatExchangerAssisted : BHoMObject
    {
        

        [JsonProperty("heat_exchanger_object_type")]
        public EmptyNoYes HeatExchangerObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("heat_exchanger_name")]
        public string HeatExchangerName { get; set; } = "";
        

        [JsonProperty("cooling_coil_object_type")]
        public EmptyNoYes CoolingCoilObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
    }
}