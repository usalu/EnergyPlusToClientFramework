using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("The number of surfaces can be expanded beyond 100, if necessary, by adding more g" +
                 "roups to the end of the list")]
    [JsonObject("ZoneHVAC:Baseboard:RadiantConvective:Water")]
    public class ZoneHVAC_Baseboard_RadiantConvective_Water : BHoMObject, IEnergyPlusClass
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
        

        [Description("Rated average water temperature is the average of the inlet and outlet water temp" +
                     "eratures at rated conditions.")]
        [JsonProperty("rated_average_water_temperature")]
        public System.Nullable<float> RatedAverageWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("87.78", CultureInfo.InvariantCulture);
        

        [Description(@"Standard is I=B=R Rating document where all baseboards are rated at either 0.063 kg/s (1 gpm) or 0.252 kg/s (4 gpm). It is recommended that users find data for the baseboard heater that corresponds to performance at 0.063 kg/s unless the flow rate is expected to be above 0.252 kg/s. If the flow rate is expected to be above 0.252 kg/s, this field should be 0.252 kg/s.")]
        [JsonProperty("rated_water_mass_flow_rate")]
        public System.Nullable<float> RatedWaterMassFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0.063", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the design heating capacity. Required field when the heating design capacity method HeatingDesignCapacity. This input field is rated heating capacity. Users must multiply the actual finned length published in the literature to determine the rated capacity. Rated Capacity is for an inlet air dry-bulb temperature of 18.0C, the Rated Water Mass Flow Rate of 0.063kg/s or 0.252kg/s, and the Rated Average Water Temperature between 32.2C and 115.6C.")]
        [JsonProperty("heating_design_capacity")]
        public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("maximum_water_flow_rate")]
        public string MaximumWaterFlowRate { get; set; } = "";
        

        [JsonProperty("surface_fractions")]
        public string SurfaceFractions { get; set; } = "";
    }
}