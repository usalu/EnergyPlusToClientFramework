using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description(@"Defines a list of thermal zones which can be referenced as a group. The ZoneList name may be used elsewhere in the input to apply a parameter to all zones in the list. ZoneLists can be used effectively with the following objects: People, Lights, ElectricEquipment, GasEquipment, HotWaterEquipment, ZoneInfiltration:DesignFlowRate, ZoneVentilation:DesignFlowRate, Sizing:Zone, ZoneControl:Thermostat, and others.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneList : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("zones")]
        public string Zones { get; set; } = "";
    }
}