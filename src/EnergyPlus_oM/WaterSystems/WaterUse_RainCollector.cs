using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    [Description("Used for harvesting rainwater falling on building surfaces. The rainwater is sent" +
                 " to a WaterUse:Storage object. In order to use this object it is necessary to al" +
                 "so include a Site:Precipitation object to describe the rates of rainfall.")]
    [JsonObject("WaterUse:RainCollector")]
    public class WaterUse_RainCollector : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("storage_tank_name")]
        public string StorageTankName { get; set; } = "";
        

        [JsonProperty("loss_factor_mode")]
        public WaterUse_RainCollector_LossFactorMode LossFactorMode { get; set; } = (WaterUse_RainCollector_LossFactorMode)Enum.Parse(typeof(WaterUse_RainCollector_LossFactorMode), "Constant");
        

        [Description("this is the portion of rain that is lost in the process of collecting it the rain" +
                     " collected is one minus this factor")]
        [JsonProperty("collection_loss_factor")]
        public System.Nullable<float> CollectionLossFactor { get; set; } = null;
        

        [JsonProperty("collection_loss_factor_schedule_name")]
        public string CollectionLossFactorScheduleName { get; set; } = "";
        

        [Description("Defaults to unlimited flow.")]
        [JsonProperty("maximum_collection_rate")]
        public System.Nullable<float> MaximumCollectionRate { get; set; } = null;
        

        [JsonProperty("surfaces")]
        public string Surfaces { get; set; } = "";
    }
}