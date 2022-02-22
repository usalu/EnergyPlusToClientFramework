using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description("A thermal chimney is a vertical shaft utilizing solar radiation to enhance natura" +
                 "l ventilation. It consists of an absorber wall, air gap and glass cover with hig" +
                 "h solar transmissivity.")]
    [JsonObject("ZoneThermalChimney")]
    public class ZoneThermalChimney : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Name of zone that is the thermal chimney")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("width_of_the_absorber_wall")]
        public System.Nullable<float> WidthOfTheAbsorberWall { get; set; } = null;
        

        [JsonProperty("cross_sectional_area_of_air_channel_outlet")]
        public System.Nullable<float> CrossSectionalAreaOfAirChannelOutlet { get; set; } = null;
        

        [JsonProperty("discharge_coefficient")]
        public System.Nullable<float> DischargeCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty("zone_1_name")]
        public string Zone1Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_1")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet1 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_1")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone1 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_1")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet1 { get; set; } = null;
        

        [JsonProperty("zone_2_name")]
        public string Zone2Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_2")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet2 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_2")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone2 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_2")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet2 { get; set; } = null;
        

        [JsonProperty("zone_3_name")]
        public string Zone3Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_3")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet3 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_3")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone3 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_3")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet3 { get; set; } = null;
        

        [JsonProperty("zone_4_name")]
        public string Zone4Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_4")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet4 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_4")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone4 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_4")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet4 { get; set; } = null;
        

        [JsonProperty("zone_5_name")]
        public string Zone5Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_5")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet5 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_5")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone5 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_5")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet5 { get; set; } = null;
        

        [JsonProperty("zone_6_name")]
        public string Zone6Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_6")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet6 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_6")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone6 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_6")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet6 { get; set; } = null;
        

        [JsonProperty("zone_7_name")]
        public string Zone7Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_7")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet7 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_7")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone7 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_7")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet7 { get; set; } = null;
        

        [JsonProperty("zone_8_name")]
        public string Zone8Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_8")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet8 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_8")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone8 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_8")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet8 { get; set; } = null;
        

        [JsonProperty("zone_9_name")]
        public string Zone9Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_9")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet9 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_9")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone9 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_9")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet9 { get; set; } = null;
        

        [JsonProperty("zone_10_name")]
        public string Zone10Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_10")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet10 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_10")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone10 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_10")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet10 { get; set; } = null;
        

        [JsonProperty("zone_11_name")]
        public string Zone11Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_11")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet11 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_11")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone11 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_11")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet11 { get; set; } = null;
        

        [JsonProperty("zone_12_name")]
        public string Zone12Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_12")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet12 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_12")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone12 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_12")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet12 { get; set; } = null;
        

        [JsonProperty("zone_13_name")]
        public string Zone13Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_13")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet13 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_13")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone13 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_13")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet13 { get; set; } = null;
        

        [JsonProperty("zone_14_name")]
        public string Zone14Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_14")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet14 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_14")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone14 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_14")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet14 { get; set; } = null;
        

        [JsonProperty("zone_15_name")]
        public string Zone15Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_15")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet15 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_15")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone15 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_15")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet15 { get; set; } = null;
        

        [JsonProperty("zone_16_name")]
        public string Zone16Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_16")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet16 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_16")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone16 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_16")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet16 { get; set; } = null;
        

        [JsonProperty("zone_17_name")]
        public string Zone17Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_17")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet17 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_17")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone17 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_17")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet17 { get; set; } = null;
        

        [JsonProperty("zone_18_name")]
        public string Zone18Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_18")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet18 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_18")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone18 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_18")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet18 { get; set; } = null;
        

        [JsonProperty("zone_19_name")]
        public string Zone19Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_19")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet19 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_19")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone19 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_19")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet19 { get; set; } = null;
        

        [JsonProperty("zone_20_name")]
        public string Zone20Name { get; set; } = "";
        

        [JsonProperty("distance_from_top_of_thermal_chimney_to_inlet_20")]
        public System.Nullable<float> DistanceFromTopOfThermalChimneyToInlet20 { get; set; } = null;
        

        [JsonProperty("relative_ratios_of_air_flow_rates_passing_through_zone_20")]
        public System.Nullable<float> RelativeRatiosOfAirFlowRatesPassingThroughZone20 { get; set; } = null;
        

        [JsonProperty("cross_sectional_areas_of_air_channel_inlet_20")]
        public System.Nullable<float> CrossSectionalAreasOfAirChannelInlet20 { get; set; } = null;
    }
}