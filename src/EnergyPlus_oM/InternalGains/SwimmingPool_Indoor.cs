using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Specifies an indoor swimming pools linked to a floor surface. The pool is assumed" +
                 " to cover the entire floor to which it is linked.")]
    public class SwimmingPool_Indoor : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Name of the floor surface where the pool is located.")]
        [JsonProperty("surface_name")]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty("average_depth")]
        public System.Nullable<float> AverageDepth { get; set; } = null;
        

        [JsonProperty("activity_factor_schedule_name")]
        public string ActivityFactorScheduleName { get; set; } = "";
        

        [JsonProperty("make_up_water_supply_schedule_name")]
        public string MakeUpWaterSupplyScheduleName { get; set; } = "";
        

        [JsonProperty("cover_schedule_name")]
        public string CoverScheduleName { get; set; } = "";
        

        [JsonProperty("cover_evaporation_factor")]
        public System.Nullable<float> CoverEvaporationFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("cover_convection_factor")]
        public System.Nullable<float> CoverConvectionFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("cover_short_wavelength_radiation_factor")]
        public System.Nullable<float> CoverShortWavelengthRadiationFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("cover_long_wavelength_radiation_factor")]
        public System.Nullable<float> CoverLongWavelengthRadiationFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("pool_water_inlet_node")]
        public string PoolWaterInletNode { get; set; } = "";
        

        [JsonProperty("pool_water_outlet_node")]
        public string PoolWaterOutletNode { get; set; } = "";
        

        [JsonProperty("pool_heating_system_maximum_water_flow_rate")]
        public System.Nullable<float> PoolHeatingSystemMaximumWaterFlowRate { get; set; } = null;
        

        [Description("Power input per pool water flow rate")]
        [JsonProperty("pool_miscellaneous_equipment_power")]
        public System.Nullable<float> PoolMiscellaneousEquipmentPower { get; set; } = null;
        

        [JsonProperty("setpoint_temperature_schedule")]
        public string SetpointTemperatureSchedule { get; set; } = "";
        

        [JsonProperty("maximum_number_of_people")]
        public System.Nullable<float> MaximumNumberOfPeople { get; set; } = null;
        

        [JsonProperty("people_schedule")]
        public string PeopleSchedule { get; set; } = "";
        

        [JsonProperty("people_heat_gain_schedule")]
        public string PeopleHeatGainSchedule { get; set; } = "";
    }
}