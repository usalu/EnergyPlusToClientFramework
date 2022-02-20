using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system air distribution unit, serves as a wrapper for a specific type" +
                 " of air terminal unit. This object is referenced in a ZoneHVAC:EquipmentList.")]
    [JsonObject("ZoneHVAC:AirDistributionUnit")]
    public class ZoneHVAC_AirDistributionUnit : BHoMObject
    {
        

        [JsonProperty("air_distribution_unit_outlet_node_name")]
        public string AirDistributionUnitOutletNodeName { get; set; } = "";
        

        [JsonProperty("air_terminal_object_type")]
        public EmptyNoYes AirTerminalObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("air_terminal_name")]
        public string AirTerminalName { get; set; } = "";
        

        [Description("fraction at system design Flow; leakage Flow constant, leakage fraction varies wi" +
                     "th variable system Flow Rate.")]
        [JsonProperty("nominal_upstream_leakage_fraction")]
        public System.Nullable<float> NominalUpstreamLeakageFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("constant_downstream_leakage_fraction")]
        public System.Nullable<float> ConstantDownstreamLeakageFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This optional field is the name of a DesignSpecification:AirTerminal:Sizing objec" +
                     "t which specifies sizing adjustments to be made for this terminal unit.")]
        [JsonProperty("design_specification_air_terminal_sizing_object_name")]
        public string DesignSpecificationAirTerminalSizingObjectName { get; set; } = "";
    }
}