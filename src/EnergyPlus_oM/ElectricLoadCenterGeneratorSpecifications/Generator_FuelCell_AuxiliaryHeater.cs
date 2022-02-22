using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Intended for modeling an auxiliary heater for a fuel cell power generator, however this portion of the model is not yet available. The program still requires one of these objects be included even though the data are not yet used (so that internal data structures can be allocated).")]
    public class Generator_FuelCell_AuxiliaryHeater : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("excess_air_ratio")]
        public System.Nullable<float> ExcessAirRatio { get; set; } = null;
        

        [JsonProperty("ancillary_power_constant_term")]
        public System.Nullable<float> AncillaryPowerConstantTerm { get; set; } = null;
        

        [JsonProperty("ancillary_power_linear_term")]
        public System.Nullable<float> AncillaryPowerLinearTerm { get; set; } = null;
        

        [JsonProperty("skin_loss_u_factor_times_area_value")]
        public System.Nullable<float> SkinLossUFactorTimesAreaValue { get; set; } = null;
        

        [JsonProperty("skin_loss_destination")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_AuxiliaryHeater_SkinLossDestination SkinLossDestination { get; set; } = (Generator_FuelCell_AuxiliaryHeater_SkinLossDestination)Enum.Parse(typeof(Generator_FuelCell_AuxiliaryHeater_SkinLossDestination), "AirInletForFuelCell");
        

        [JsonProperty("zone_name_to_receive_skin_losses")]
        public string ZoneNameToReceiveSkinLosses { get; set; } = "";
        

        [JsonProperty("heating_capacity_units")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_AuxiliaryHeater_HeatingCapacityUnits HeatingCapacityUnits { get; set; } = (Generator_FuelCell_AuxiliaryHeater_HeatingCapacityUnits)Enum.Parse(typeof(Generator_FuelCell_AuxiliaryHeater_HeatingCapacityUnits), "Watts");
        

        [JsonProperty("maximum_heating_capacity_in_watts")]
        public System.Nullable<float> MaximumHeatingCapacityInWatts { get; set; } = null;
        

        [JsonProperty("minimum_heating_capacity_in_watts")]
        public System.Nullable<float> MinimumHeatingCapacityInWatts { get; set; } = null;
        

        [JsonProperty("maximum_heating_capacity_in_kmol_per_second")]
        public System.Nullable<float> MaximumHeatingCapacityInKmolPerSecond { get; set; } = null;
        

        [JsonProperty("minimum_heating_capacity_in_kmol_per_second")]
        public System.Nullable<float> MinimumHeatingCapacityInKmolPerSecond { get; set; } = null;
    }
}