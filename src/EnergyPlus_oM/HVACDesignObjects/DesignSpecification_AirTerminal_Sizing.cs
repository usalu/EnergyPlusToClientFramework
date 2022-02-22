using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description("This object is used to scale the sizing of air terminal units.")]
    [JsonObject("DesignSpecification:AirTerminal:Sizing")]
    public class DesignSpecification_AirTerminal_Sizing : BHoMObject, IEnergyPlusClass
    {
        

        [Description("The fraction of the design sensible cooling load to be met by this terminal unit." +
                     " This fraction is applied after the Zone Cooling Sizing Factor (see Sizing:Zone)" +
                     ".")]
        [JsonProperty("fraction_of_design_cooling_load")]
        public System.Nullable<float> FractionOfDesignCoolingLoad { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This ratio adjusts the supply air temperature difference used to calculate the co" +
                     "oling design supply air flow rate for this terminal unit.")]
        [JsonProperty("cooling_design_supply_air_temperature_difference_ratio")]
        public System.Nullable<float> CoolingDesignSupplyAirTemperatureDifferenceRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The fraction of the design sensible heating load to be met by this terminal unit." +
                     " This fraction is applied after the Zone Heating Sizing Factor (see Sizing:Zone)" +
                     ".")]
        [JsonProperty("fraction_of_design_heating_load")]
        public System.Nullable<float> FractionOfDesignHeatingLoad { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This ratio adjusts the supply air temperature difference used to calculate the he" +
                     "ating design supply air flow rate for this terminal unit.")]
        [JsonProperty("heating_design_supply_air_temperature_difference_ratio")]
        public System.Nullable<float> HeatingDesignSupplyAirTemperatureDifferenceRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The fraction of the zone minimum outdoor air requirement to be met by this termin" +
                     "al unit.")]
        [JsonProperty("fraction_of_minimum_outdoor_air_flow")]
        public System.Nullable<float> FractionOfMinimumOutdoorAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}