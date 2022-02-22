using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, dual duct, variable volume with special control" +
                 "s. One VAV duct is controlled to supply ventilation air and the other VAV duct i" +
                 "s controlled to meet the zone cooling load.")]
    public class AirTerminal_DualDuct_VAV_OutdoorAir : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("The outlet node of the terminal unit. This is also the zone inlet node.")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("outdoor_air_inlet_node_name")]
        public string OutdoorAirInletNodeName { get; set; } = "";
        

        [JsonProperty("recirculated_air_inlet_node_name")]
        public string RecirculatedAirInletNodeName { get; set; } = "";
        

        [Description("If autosized this is the sum of flow needed for cooling and maximum required outd" +
                     "oor air")]
        [JsonProperty("maximum_terminal_air_flow_rate")]
        public string MaximumTerminalAirFlowRate { get; set; } = "";
        

        [Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will increase flow as needed to meet this outdoor air requirement. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based mode selected in the next field. At no time will the supply air flow rate exceed the value for Maximum Air Flow Rate.")]
        [JsonProperty("design_specification_outdoor_air_object_name")]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description("CurrentOccupancy models demand controlled ventilation using the current number of" +
                     " people DesignOccupancy uses the total Number of People in the zone and is const" +
                     "ant")]
        [JsonProperty("per_person_ventilation_rate_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirTerminal_DualDuct_VAV_OutdoorAir_PerPersonVentilationRateMode PerPersonVentilationRateMode { get; set; } = (AirTerminal_DualDuct_VAV_OutdoorAir_PerPersonVentilationRateMode)Enum.Parse(typeof(AirTerminal_DualDuct_VAV_OutdoorAir_PerPersonVentilationRateMode), "CurrentOccupancy");
    }
}