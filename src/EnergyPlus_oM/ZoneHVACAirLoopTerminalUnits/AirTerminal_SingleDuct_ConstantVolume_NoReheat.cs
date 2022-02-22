using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, single duct, constant volume, without reheat co" +
                 "il")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirTerminal_SingleDuct_ConstantVolume_NoReheat : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("The air-inlet node name that connects the air splitter to the individual zone air" +
                     " distribution unit. This node should also be one of the outlet air node of an Ai" +
                     "rLoopHVAC:ZoneSplitter or AirLoopHVAC:SupplyPlenum component.")]
        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("This is an air outlet node from the air distribution unit. This node name should " +
                     "be one of the supply air inlet node names of a zone served by this component.")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("maximum_air_flow_rate")]
        public string MaximumAirFlowRate { get; set; } = "";
        

        [Description(@"This field is used to modulate the terminal unit flow rate based on the specified outdoor air requirement. When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will adjust flow to meet this outdoor air requirement and no more. There is no control for zone load. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based on either the current or design occupancy as specified in the Per Person Ventilation Rate Mode field. At no time will the supply air flow rate exceed the value for Maximum Air Flow Rate. The requested flow rate may not be fully met if the system is operating with cycling fan. If this field is blank, then the terminal unit will not be controlled for outdoor air flow. This field is optional.")]
        [JsonProperty("design_specification_outdoor_air_object_name")]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description("CurrentOccupancy uses current number of people in the zone which may vary DesignO" +
                     "ccupancy uses the total number of people in the zone and is constant")]
        [JsonProperty("per_person_ventilation_rate_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirTerminal_SingleDuct_ConstantVolume_NoReheat_PerPersonVentilationRateMode PerPersonVentilationRateMode { get; set; } = (AirTerminal_SingleDuct_ConstantVolume_NoReheat_PerPersonVentilationRateMode)Enum.Parse(typeof(AirTerminal_SingleDuct_ConstantVolume_NoReheat_PerPersonVentilationRateMode), "CurrentOccupancy");
    }
}