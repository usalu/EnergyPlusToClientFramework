using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description(@"This object calculates the performance of zone (room) air dehumidifiers. Meant to model conventional direct expansion (DX) cooling-based room air dehumidifiers (reject 100% of condenser heat to the zone air), but this object might be able to be used to model other room air dehumidifier types.")]
    [JsonObject("ZoneHVAC:Dehumidifier:DX")]
    public class ZoneHVAC_Dehumidifier_DX : BHoMObject
    {
        

        [Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. Schedule values of 0 denote the unit is off. Schedule values >0.0 (usually 1.0) indicate that the dehumidifier is available to operate.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Air inlet node for the dehumidifier must be a zone air exhaust node.")]
        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Air outlet node for the dehumidifier must be a zone air inlet node.")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Rating point: air entering dehumidifier at 26.7 C (80 F) dry-bulb and 60% relativ" +
                     "e humidity.")]
        [JsonProperty("rated_water_removal")]
        public System.Nullable<float> RatedWaterRemoval { get; set; } = null;
        

        [Description("Rating point: air entering dehumidifier at 26.7 C (80 F) dry-bulb and 60% relativ" +
                     "e humidity.")]
        [JsonProperty("rated_energy_factor")]
        public System.Nullable<float> RatedEnergyFactor { get; set; } = null;
        

        [JsonProperty("rated_air_flow_rate")]
        public System.Nullable<float> RatedAirFlowRate { get; set; } = null;
        

        [Description(@"Name of a curve that describes the water removal rate (normalized to rated conditions) as a function of the dry-bulb temperature and relative humidity of the air entering the dehumidifier. Curve output = (actual water removal/rated water removal) = a + b*T + c*T**2 + d*RH + e*RH**2 + f*T*RH T = inlet air dry-bulb temperature (C) RH = inlet air RH (%)")]
        [JsonProperty("water_removal_curve_name")]
        public string WaterRemovalCurveName { get; set; } = "";
        

        [Description(@"Name of a curve that describes the energy factor (normalized to rated conditions) as a function of the dry-bulb temperature and relative humidity of the air entering the dehumidifier. Curve output = (actual energy factor/rated energy factor) = a + b*T + c*T**2 + d*RH + e*RH**2 + f*T*RH T = inlet air dry-bulb temperature (C) RH = inlet air RH (%)")]
        [JsonProperty("energy_factor_curve_name")]
        public string EnergyFactorCurveName { get; set; } = "";
        

        [Description(@"Name of a curve that describes the part load fraction (PLF) of the system as a function of the part load ratio. Used to calculate dehumidifier run time fraction and electric power. quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 PLR = part load ratio (dehumidification load/steady state water removal capacity)")]
        [JsonProperty("part_load_fraction_correlation_curve_name")]
        public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description("Dehumidifier shut off if inlet air (zone) temperature is below this value. This v" +
                     "alue must be less than the Maximum Dry-Bulb Temperature for Dehumidifier Operati" +
                     "on.")]
        [JsonProperty("minimum_dry_bulb_temperature_for_dehumidifier_operation")]
        public System.Nullable<float> MinimumDryBulbTemperatureForDehumidifierOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Dehumidifier shut off if inlet air (zone) temperature is above this value. This v" +
                     "alue must be greater than the Minimum Dry-Bulb Temperature for Dehumidifier Oper" +
                     "ation.")]
        [JsonProperty("maximum_dry_bulb_temperature_for_dehumidifier_operation")]
        public System.Nullable<float> MaximumDryBulbTemperatureForDehumidifierOperation { get; set; } = (System.Nullable<float>)Single.Parse("35", CultureInfo.InvariantCulture);
        

        [Description(@"Parasitic electric power consumed when the dehumidifier is available to operate, but does not operate (i.e., no high humidity load to be met). Off cycle parasitic power is 0 when the availability schedule is 0. This electric load is considered as a heat gain to the zone air.")]
        [JsonProperty("off_cycle_parasitic_electric_load")]
        public System.Nullable<float> OffCycleParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Name of storage tank used to collect water removed by the dehumidifier.")]
        [JsonProperty("condensate_collection_water_storage_tank_name")]
        public string CondensateCollectionWaterStorageTankName { get; set; } = "";
    }
}