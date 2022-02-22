using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description(null)]
    public class ZoneHVAC_Baseboard_RadiantConvective_Steam_Design : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"Enter the method used to determine the heating design capacity. HeatingDesignCapacity is selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea is selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
        [JsonProperty("heating_design_capacity_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_Baseboard_RadiantConvective_Steam_Design_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_Baseboard_RadiantConvective_Steam_Design_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_Baseboard_RadiantConvective_Steam_Design_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

        [Description("Enter the heating design capacity per zone floor area. Required field when the he" +
                     "ating design capacity method field is CapacityPerFloorArea.")]
        [JsonProperty("heating_design_capacity_per_floor_area")]
        public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of autosized heating design capacity. Required field when capa" +
                     "city the heating design capacity method field is FractionOfAutosizedHeatingCapac" +
                     "ity.")]
        [JsonProperty("fraction_of_autosized_heating_design_capacity")]
        public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("convergence_tolerance")]
        public System.Nullable<float> ConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [JsonProperty("fraction_radiant")]
        public System.Nullable<float> FractionRadiant { get; set; } = null;
        

        [JsonProperty("fraction_of_radiant_energy_incident_on_people")]
        public System.Nullable<float> FractionOfRadiantEnergyIncidentOnPeople { get; set; } = null;
    }
}