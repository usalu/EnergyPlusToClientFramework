using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [Description(@"Unglazed transpired solar collector (UTSC) used to condition outdoor air. This type of collector is generally used to heat air drawn through perforated absorbers and also recover heat conducted out through the underlying surface. This object represents a single collector attached to one or more building or shading surfaces and to one or more outdoor air systems.")]
    [JsonObject("SolarCollector:UnglazedTranspired")]
    public class SolarCollector_UnglazedTranspired : BHoMObject
    {
        

        [Description("Enter the name of a SurfaceProperty:OtherSideConditionsModel object")]
        [JsonProperty("boundary_conditions_model_name")]
        public string BoundaryConditionsModelName { get; set; } = "";
        

        [Description("Availability schedule name for this collector. Schedule value > 0 means it is ava" +
                     "ilable. If this field is blank, the collector is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("required field if no SolarCollector:UnglazedTranspired:Multisystem")]
        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [Description("required field if no SolarCollector:UnglazedTranspired:Multisystem")]
        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [Description("This node is where the mixed air setpoint is determined. required field if no Sol" +
                     "arCollector:UnglazedTranspired:Multisystem")]
        [JsonProperty("setpoint_node_name")]
        public string SetpointNodeName { get; set; } = "";
        

        [Description("This node is used to identify the affected zone required field if no SolarCollect" +
                     "or:UnglazedTranspired:Multisystem")]
        [JsonProperty("zone_node_name")]
        public string ZoneNodeName { get; set; } = "";
        

        [JsonProperty("free_heating_setpoint_schedule_name")]
        public string FreeHeatingSetpointScheduleName { get; set; } = "";
        

        [JsonProperty("diameter_of_perforations_in_collector")]
        public System.Nullable<float> DiameterOfPerforationsInCollector { get; set; } = null;
        

        [JsonProperty("distance_between_perforations_in_collector")]
        public System.Nullable<float> DistanceBetweenPerforationsInCollector { get; set; } = null;
        

        [JsonProperty("thermal_emissivity_of_collector_surface")]
        public System.Nullable<float> ThermalEmissivityOfCollectorSurface { get; set; } = null;
        

        [JsonProperty("solar_absorbtivity_of_collector_surface")]
        public System.Nullable<float> SolarAbsorbtivityOfCollectorSurface { get; set; } = null;
        

        [JsonProperty("effective_overall_height_of_collector")]
        public System.Nullable<float> EffectiveOverallHeightOfCollector { get; set; } = null;
        

        [Description("if corrugated, use average depth")]
        [JsonProperty("effective_gap_thickness_of_plenum_behind_collector")]
        public System.Nullable<float> EffectiveGapThicknessOfPlenumBehindCollector { get; set; } = null;
        

        [Description("if corrugated, use average depth")]
        [JsonProperty("effective_cross_section_area_of_plenum_behind_collector")]
        public System.Nullable<float> EffectiveCrossSectionAreaOfPlenumBehindCollector { get; set; } = null;
        

        [JsonProperty("hole_layout_pattern_for_pitch")]
        public EmptyNoYes HoleLayoutPatternForPitch { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Square");
        

        [JsonProperty("heat_exchange_effectiveness_correlation")]
        public EmptyNoYes HeatExchangeEffectivenessCorrelation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Kutscher1994");
        

        [Description("This parameter is used to help account for corrugations in the collector")]
        [JsonProperty("ratio_of_actual_collector_surface_area_to_projected_surface_area")]
        public System.Nullable<float> RatioOfActualCollectorSurfaceAreaToProjectedSurfaceArea { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("roughness_of_collector")]
        public EmptyNoYes RoughnessOfCollector { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Collector thickness is not required for Kutscher correlation Collector thickness " +
                     "is required for Van Decker et al. correlation")]
        [JsonProperty("collector_thickness")]
        public System.Nullable<float> CollectorThickness { get; set; } = null;
        

        [Description("Cv")]
        [JsonProperty("effectiveness_for_perforations_with_respect_to_wind")]
        public System.Nullable<float> EffectivenessForPerforationsWithRespectToWind { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

        [Description("Cd")]
        [JsonProperty("discharge_coefficient_for_openings_with_respect_to_buoyancy_driven_flow")]
        public System.Nullable<float> DischargeCoefficientForOpeningsWithRespectToBuoyancyDrivenFlow { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

        [JsonProperty("surfaces")]
        public string Surfaces { get; set; } = "";
    }
}