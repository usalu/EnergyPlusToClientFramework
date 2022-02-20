using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    [Description(@"This object is used in conjunction with Controller:OutdoorAir to specify outdoor ventilation air based on outdoor air specified in the DesignSpecification:OutdoorAir object The Controller:OutdoorAir object is associated with a specific air loop, so the outdoor air flow rates specified in Controller:MechanicalVentilation correspond to the zones attached to that specific air loop. Duplicate groups of Zone name, Design Specification Outdoor Air Object Name, and Design Specification Zone Air Distribution Object Name to increase allowable number of entries")]
    [JsonObject("Controller:MechanicalVentilation")]
    public class Controller_MechanicalVentilation : BHoMObject
    {
        

        [Description("If this field is blank, the controller uses the values from the associated Contro" +
                     "ller:OutdoorAir. Schedule values greater than 0 indicate mechanical ventilation " +
                     "is enabled")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("demand_controlled_ventilation")]
        public EmptyNoYes DemandControlledVentilation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("system_outdoor_air_method")]
        public EmptyNoYes SystemOutdoorAirMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "VentilationRateProcedure");
        

        [JsonProperty("zone_maximum_outdoor_air_fraction")]
        public System.Nullable<float> ZoneMaximumOutdoorAirFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("zone_specifications")]
        public string ZoneSpecifications { get; set; } = "";
    }
}