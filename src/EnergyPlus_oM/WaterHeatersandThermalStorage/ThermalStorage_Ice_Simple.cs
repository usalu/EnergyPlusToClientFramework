using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    [Description(@"This ice storage model is a simplified model It requires a setpoint placed on the Chilled Water Side Outlet Node It should be placed in the chilled water supply side outlet branch followed by a pipe. Use the PlantEquipmentOperation:ComponentSetpoint plant operation scheme.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermalStorage_Ice_Simple : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("IceOnCoilInternal = Ice-on-Coil, internal melt IceOnCoilExternal = Ice-on-Coil, e" +
                     "xternal melt")]
        [JsonProperty("ice_storage_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ThermalStorage_Ice_Simple_IceStorageType IceStorageType { get; set; } = (ThermalStorage_Ice_Simple_IceStorageType)Enum.Parse(typeof(ThermalStorage_Ice_Simple_IceStorageType), "IceOnCoilExternal");
        

        [JsonProperty("capacity")]
        public System.Nullable<float> Capacity { get; set; } = null;
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
    }
}