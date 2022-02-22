using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Virtual component consisting of a chilled-water cooling coil and an air-to-air heat exchanger. The air-to-air heat exchanger precools the air entering the cooling coil and reuses this energy to reheat the supply air leaving the cooling coil. This heat exchange process improves the latent removal performance of the cooling coil (lower sensible heat ratio).")]
    public class CoilSystem_Cooling_Water_HeatExchangerAssisted : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("heat_exchanger_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CoilSystem_Cooling_Water_HeatExchangerAssisted_HeatExchangerObjectType HeatExchangerObjectType { get; set; } = (CoilSystem_Cooling_Water_HeatExchangerAssisted_HeatExchangerObjectType)Enum.Parse(typeof(CoilSystem_Cooling_Water_HeatExchangerAssisted_HeatExchangerObjectType), "HeatExchangerAirToAirFlatPlate");
        

        [JsonProperty("heat_exchanger_name")]
        public string HeatExchangerName { get; set; } = "";
        

        [JsonProperty("cooling_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CoilSystem_Cooling_Water_HeatExchangerAssisted_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (CoilSystem_Cooling_Water_HeatExchangerAssisted_CoolingCoilObjectType)Enum.Parse(typeof(CoilSystem_Cooling_Water_HeatExchangerAssisted_CoolingCoilObjectType), "CoilCoolingWater");
        

        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
    }
}