using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, single duct, constant volume, with heating and/" +
                 "or cooling. Operates as two-pipe unit if heating or cooling water is omitted. He" +
                 "ating and/or cooling can be scheduled off for dedicated ventilation.")]
    public class AirTerminal_SingleDuct_ConstantVolume_FourPipeBeam : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Primary air is supplied by central air handling unit and must be on for heating o" +
                     "r cooling. Schedule value > 0 means the primary air supply is available. If this" +
                     " field is blank, the primary air supply is always available.")]
        [JsonProperty("primary_air_availability_schedule_name")]
        public string PrimaryAirAvailabilityScheduleName { get; set; } = "";
        

        [Description("Cooling operation can be controlled separately using this availability schedule. " +
                     "Schedule value > 0 means beam cooling is available. If this field is blank, the " +
                     "beam cooling is always available (as long as primary air is also available).")]
        [JsonProperty("cooling_availability_schedule_name")]
        public string CoolingAvailabilityScheduleName { get; set; } = "";
        

        [Description("Heating operation can be controlled separately using this availability schedule. " +
                     "Schedule value > 0 means beam heating is available. If this field is blank, the " +
                     "beam heating is always available (as long as primary air is also available).")]
        [JsonProperty("heating_availability_schedule_name")]
        public string HeatingAvailabilityScheduleName { get; set; } = "";
        

        [Description("Name of the air system node for primary supply air entering the air distribution " +
                     "unit.")]
        [JsonProperty("primary_air_inlet_node_name")]
        public string PrimaryAirInletNodeName { get; set; } = "";
        

        [Description("Name of the air system node for primary supply air leaving the air distribution u" +
                     "nit and entering the zone.")]
        [JsonProperty("primary_air_outlet_node_name")]
        public string PrimaryAirOutletNodeName { get; set; } = "";
        

        [Description("Name of the plant system node for chilled water entering the beam. The two chille" +
                     "d water nodes can (only) be omitted to model a two-pipe heating only beam.")]
        [JsonProperty("chilled_water_inlet_node_name")]
        public string ChilledWaterInletNodeName { get; set; } = "";
        

        [Description("Name of the plant system node for chilled water leaving the beam.")]
        [JsonProperty("chilled_water_outlet_node_name")]
        public string ChilledWaterOutletNodeName { get; set; } = "";
        

        [Description("Name of the plant system node for hot water entering the beam. The two hot water " +
                     "nodes can (only) be omitted to model a two-pipe cooling-only beam.")]
        [JsonProperty("hot_water_inlet_node_name")]
        public string HotWaterInletNodeName { get; set; } = "";
        

        [Description("Name of the plant system node for hot water leaving the beam.")]
        [JsonProperty("hot_water_outlet_node_name")]
        public string HotWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("design_primary_air_volume_flow_rate")]
        public string DesignPrimaryAirVolumeFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("design_chilled_water_volume_flow_rate")]
        public string DesignChilledWaterVolumeFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("design_hot_water_volume_flow_rate")]
        public string DesignHotWaterVolumeFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("Sum of the length of all the beam units in the zone represented by this terminal " +
                     "unit.")]
        [JsonProperty("zone_total_beam_length")]
        public string ZoneTotalBeamLength { get; set; } = (System.String)"Autosize";
        

        [Description("Primary air supply flow rate normalized by beam length.")]
        [JsonProperty("rated_primary_air_flow_rate_per_beam_length")]
        public System.Nullable<float> RatedPrimaryAirFlowRatePerBeamLength { get; set; } = (System.Nullable<float>)Single.Parse("0.035", CultureInfo.InvariantCulture);
        

        [Description("Sensible cooling capacity per meter of beam length at the rating point.")]
        [JsonProperty("beam_rated_cooling_capacity_per_beam_length")]
        public System.Nullable<float> BeamRatedCoolingCapacityPerBeamLength { get; set; } = (System.Nullable<float>)Single.Parse("600", CultureInfo.InvariantCulture);
        

        [Description("Difference in temperature between the zone air and the entering chilled water at " +
                     "the rating point.")]
        [JsonProperty("beam_rated_cooling_room_air_chilled_water_temperature_difference")]
        public System.Nullable<float> BeamRatedCoolingRoomAirChilledWaterTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("The volume flow rate of chilled water per meter of beam length at the rating poin" +
                     "t.")]
        [JsonProperty("beam_rated_chilled_water_volume_flow_rate_per_beam_length")]
        public System.Nullable<float> BeamRatedChilledWaterVolumeFlowRatePerBeamLength { get; set; } = (System.Nullable<float>)Single.Parse("5E-05", CultureInfo.InvariantCulture);
        

        [Description(@"Adjusts beam cooling capacity when the temperature difference between entering water and zone air is different than at the rating point. Single independent variable is the ratio of the current temperature difference divided by the rating point temperature difference. This field is required when beam is connected to a chilled water plant.")]
        [JsonProperty("beam_cooling_capacity_temperature_difference_modification_factor_curve_name")]
        public string BeamCoolingCapacityTemperatureDifferenceModificationFactorCurveName { get; set; } = "";
        

        [Description(@"Adjusts beam cooling capacity when the primary air supply flow rate is different than at the rating point. The single independent variable is the current normalized air flow rate divided by the normalized air flow rate at the rating point. This field is required when beam is connected to a chilled water plant.")]
        [JsonProperty("beam_cooling_capacity_air_flow_modification_factor_curve_name")]
        public string BeamCoolingCapacityAirFlowModificationFactorCurveName { get; set; } = "";
        

        [Description(@"Adjusts beam cooling capacity when the normalized chilled water flow rate is different than at the rating point. The single independent variable is the current normalized chilled water flow rate divided by the normalized chilled water flow rate at the rating point. This field is required when beam is connected to a chilled water plant.")]
        [JsonProperty("beam_cooling_capacity_chilled_water_flow_modification_factor_curve_name")]
        public string BeamCoolingCapacityChilledWaterFlowModificationFactorCurveName { get; set; } = "";
        

        [Description("Sensible heating capacity per meter of beam length at the rating point.")]
        [JsonProperty("beam_rated_heating_capacity_per_beam_length")]
        public System.Nullable<float> BeamRatedHeatingCapacityPerBeamLength { get; set; } = (System.Nullable<float>)Single.Parse("1500", CultureInfo.InvariantCulture);
        

        [Description("Difference in temperature between the zone air and the entering hot water at the " +
                     "rating point.")]
        [JsonProperty("beam_rated_heating_room_air_hot_water_temperature_difference")]
        public System.Nullable<float> BeamRatedHeatingRoomAirHotWaterTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("27.8", CultureInfo.InvariantCulture);
        

        [Description("The volume flow rate of hoy water per meter of beam length at the rating point.")]
        [JsonProperty("beam_rated_hot_water_volume_flow_rate_per_beam_length")]
        public System.Nullable<float> BeamRatedHotWaterVolumeFlowRatePerBeamLength { get; set; } = (System.Nullable<float>)Single.Parse("5E-05", CultureInfo.InvariantCulture);
        

        [Description(@"Adjusts beam heating capacity when the temperature difference between entering water and zone air is different than at the rating point. Single independent variable is the ratio of the current temperature difference divided by the rating point temperature difference. This field is required when beam is connected to a hot water plant.")]
        [JsonProperty("beam_heating_capacity_temperature_difference_modification_factor_curve_name")]
        public string BeamHeatingCapacityTemperatureDifferenceModificationFactorCurveName { get; set; } = "";
        

        [Description(@"Adjusts beam heating capacity when the primary air supply flow rate is different than at the rating point. The single independent variable is the current normalized air flow rate divided by the normalized air flow rate at the rating point. This field is required when beam is connected to a hot water plant.")]
        [JsonProperty("beam_heating_capacity_air_flow_modification_factor_curve_name")]
        public string BeamHeatingCapacityAirFlowModificationFactorCurveName { get; set; } = "";
        

        [Description(@"Adjusts beam heating capacity when the normalized hot water flow rate is different than at the rating point. The single independent variable is the current normalized hot water flow rate divided by the normalized hot water flow rate at the rating point. This field is required when beam is connected to a hot water plant.")]
        [JsonProperty("beam_heating_capacity_hot_water_flow_modification_factor_curve_name")]
        public string BeamHeatingCapacityHotWaterFlowModificationFactorCurveName { get; set; } = "";
    }
}