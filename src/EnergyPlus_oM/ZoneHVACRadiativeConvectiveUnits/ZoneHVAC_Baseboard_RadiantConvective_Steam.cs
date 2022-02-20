using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("The number of surfaces can be expanded beyond 100, if necessary, by adding more g" +
                 "roups to the end of the list.")]
    [JsonObject("ZoneHVAC:Baseboard:RadiantConvective:Steam")]
    public class ZoneHVAC_Baseboard_RadiantConvective_Steam : BHoMObject
    {
        

        [JsonProperty("design_object")]
        public string DesignObject { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [Description("Enter the design heating capacity. Required field when the heating design capacit" +
                     "y method HeatingDesignCapacity.")]
        [JsonProperty("heating_design_capacity")]
        public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("degree_of_subcooling")]
        public System.Nullable<float> DegreeOfSubcooling { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_steam_flow_rate")]
        public string MaximumSteamFlowRate { get; set; } = "";
        

        [JsonProperty("surface_fractions")]
        public string SurfaceFractions { get; set; } = "";
    }
}