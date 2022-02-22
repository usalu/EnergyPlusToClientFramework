using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the name of the supply Air Fan used in an Air loop.")]
    [JsonObject("AirflowNetwork:Distribution:Component:Fan")]
    public class AirflowNetwork_Distribution_Component_Fan : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the name of the fan in the primary air loop.")]
        [JsonProperty("fan_name")]
        public string FanName { get; set; } = "";
        

        [JsonProperty("supply_fan_object_type")]
        public AirflowNetwork_Distribution_Component_Fan_SupplyFanObjectType SupplyFanObjectType { get; set; } = (AirflowNetwork_Distribution_Component_Fan_SupplyFanObjectType)Enum.Parse(typeof(AirflowNetwork_Distribution_Component_Fan_SupplyFanObjectType), "Empty");
    }
}