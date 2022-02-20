using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("Low temperature hydronic radiant heating and/or cooling system embedded in a buil" +
                 "ding surface (wall, ceiling, or floor). Controlled by varying the hot or chilled" +
                 " water flow to the unit.")]
    [JsonObject("ZoneHVAC:LowTemperatureRadiant:VariableFlow")]
    public class ZoneHVAC_LowTemperatureRadiant_VariableFlow : BHoMObject
    {
        

        [JsonProperty("design_object")]
        public string DesignObject { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Name of zone system is serving")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Identifies surfaces that radiant system is embedded in. For a system with multipl" +
                     "e surfaces, enter the name of a ZoneHVAC:LowTemperatureRadiant:SurfaceGroup obje" +
                     "ct.")]
        [JsonProperty("surface_name_or_radiant_surface_group_name")]
        public string SurfaceNameOrRadiantSurfaceGroupName { get; set; } = "";
        

        [Description("(total length of pipe embedded in surface)")]
        [JsonProperty("hydronic_tubing_length")]
        public string HydronicTubingLength { get; set; } = (System.String)"Autosize";
        

        [Description("Enter the design heating capacity. Required field when the heating design capacit" +
                     "y method HeatingDesignCapacity.")]
        [JsonProperty("heating_design_capacity")]
        public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("maximum_hot_water_flow")]
        public string MaximumHotWaterFlow { get; set; } = "";
        

        [JsonProperty("heating_water_inlet_node_name")]
        public string HeatingWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("heating_water_outlet_node_name")]
        public string HeatingWaterOutletNodeName { get; set; } = "";
        

        [Description("Enter the design cooling capacity. Required field when the cooling design capacit" +
                     "y method CoolingDesignCapacity.")]
        [JsonProperty("cooling_design_capacity")]
        public string CoolingDesignCapacity { get; set; } = "";
        

        [JsonProperty("maximum_cold_water_flow")]
        public string MaximumColdWaterFlow { get; set; } = "";
        

        [JsonProperty("cooling_water_inlet_node_name")]
        public string CoolingWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("cooling_water_outlet_node_name")]
        public string CoolingWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("number_of_circuits")]
        public EmptyNoYes NumberOfCircuits { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "OnePerSurface");
        

        [JsonProperty("circuit_length")]
        public System.Nullable<float> CircuitLength { get; set; } = (System.Nullable<float>)Single.Parse("106.7", CultureInfo.InvariantCulture);
    }
}