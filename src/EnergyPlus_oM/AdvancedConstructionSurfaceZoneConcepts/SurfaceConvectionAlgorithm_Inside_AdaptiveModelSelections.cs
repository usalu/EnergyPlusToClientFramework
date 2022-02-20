using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description(@"Options to change the individual convection model equations for dynamic selection when using AdaptiveConvectiongAlgorithm This object is only needed to make changes to the default model selections for any or all of the surface categories. This object is for the inside face, the side of the surface facing a thermal zone.")]
    [JsonObject("SurfaceConvectionAlgorithm:Inside:AdaptiveModelSelections")]
    public class SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections : BHoMObject
    {
        

        [Description("Applies to zone with no HVAC or when HVAC is off This is for vertical walls")]
        [JsonProperty("simple_buoyancy_vertical_wall_equation_source")]
        public EmptyNoYes SimpleBuoyancyVerticalWallEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "FohannoPolidoriVerticalWall");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("simple_buoyancy_vertical_wall_user_curve_name")]
        public string SimpleBuoyancyVerticalWallUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with no HVAC or when HVAC is off This is for horizontal surfaces " +
                     "with heat flow directed for stable thermal stratification")]
        [JsonProperty("simple_buoyancy_stable_horizontal_equation_source")]
        public EmptyNoYes SimpleBuoyancyStableHorizontalEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "AlamdariHammondStableHorizontal");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("simple_buoyancy_stable_horizontal_equation_user_curve_name")]
        public string SimpleBuoyancyStableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with no HVAC or when HVAC is off This is for passive horizontal s" +
                     "urfaces with heat flow for unstable thermal stratification")]
        [JsonProperty("simple_buoyancy_unstable_horizontal_equation_source")]
        public EmptyNoYes SimpleBuoyancyUnstableHorizontalEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "AlamdariHammondUnstableHorizontal");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("simple_buoyancy_unstable_horizontal_equation_user_curve_name")]
        public string SimpleBuoyancyUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with no HVAC or when HVAC is off This is for tilted surfaces with" +
                     " heat flow for stable thermal stratification")]
        [JsonProperty("simple_buoyancy_stable_tilted_equation_source")]
        public EmptyNoYes SimpleBuoyancyStableTiltedEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "WaltonStableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("simple_buoyancy_stable_tilted_equation_user_curve_name")]
        public string SimpleBuoyancyStableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with no HVAC or when HVAC is off This is for tilted surfaces with" +
                     " heat flow for unstable thermal stratification")]
        [JsonProperty("simple_buoyancy_unstable_tilted_equation_source")]
        public EmptyNoYes SimpleBuoyancyUnstableTiltedEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "WaltonUnstableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("simple_buoyancy_unstable_tilted_equation_user_curve_name")]
        public string SimpleBuoyancyUnstableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with no HVAC or when HVAC is off This is for all window surfaces")]
        [JsonProperty("simple_buoyancy_windows_equation_source")]
        public EmptyNoYes SimpleBuoyancyWindowsEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ISO15099Windows");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("simple_buoyancy_windows_equation_user_curve_name")]
        public string SimpleBuoyancyWindowsEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for verti" +
                     "cal walls")]
        [JsonProperty("floor_heat_ceiling_cool_vertical_wall_equation_source")]
        public EmptyNoYes FloorHeatCeilingCoolVerticalWallEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "KhalifaEq3WallAwayFromHeat");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("floor_heat_ceiling_cool_vertical_wall_equation_user_curve_name")]
        public string FloorHeatCeilingCoolVerticalWallEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for passi" +
                     "ve horizontal surfaces with heat flow for stable thermal stratification")]
        [JsonProperty("floor_heat_ceiling_cool_stable_horizontal_equation_source")]
        public EmptyNoYes FloorHeatCeilingCoolStableHorizontalEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "AlamdariHammondStableHorizontal");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("floor_heat_ceiling_cool_stable_horizontal_equation_user_curve_name")]
        public string FloorHeatCeilingCoolStableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for passi" +
                     "ve horizontal surfaces with heat flow for unstable thermal stratification")]
        [JsonProperty("floor_heat_ceiling_cool_unstable_horizontal_equation_source")]
        public EmptyNoYes FloorHeatCeilingCoolUnstableHorizontalEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "KhalifaEq4CeilingAwayFromHeat");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("floor_heat_ceiling_cool_unstable_horizontal_equation_user_curve_name")]
        public string FloorHeatCeilingCoolUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for a flo" +
                     "or with active heating elements")]
        [JsonProperty("floor_heat_ceiling_cool_heated_floor_equation_source")]
        public EmptyNoYes FloorHeatCeilingCoolHeatedFloorEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "AwbiHattonHeatedFloor");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("floor_heat_ceiling_cool_heated_floor_equation_user_curve_name")]
        public string FloorHeatCeilingCoolHeatedFloorEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for a cei" +
                     "ling with active cooling elements")]
        [JsonProperty("floor_heat_ceiling_cool_chilled_ceiling_equation_source")]
        public EmptyNoYes FloorHeatCeilingCoolChilledCeilingEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "KaradagChilledCeiling");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("floor_heat_ceiling_cool_chilled_ceiling_equation_user_curve_name")]
        public string FloorHeatCeilingCoolChilledCeilingEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for tilte" +
                     "d surfaces with heat flow for stable thermal stratification")]
        [JsonProperty("floor_heat_ceiling_cool_stable_tilted_equation_source")]
        public EmptyNoYes FloorHeatCeilingCoolStableTiltedEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "WaltonStableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("floor_heat_ceiling_cool_stable_tilted_equation_user_curve_name")]
        public string FloorHeatCeilingCoolStableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for tilte" +
                     "d surfaces with heat flow for unstable thermal stratification")]
        [JsonProperty("floor_heat_ceiling_cool_unstable_tilted_equation_source")]
        public EmptyNoYes FloorHeatCeilingCoolUnstableTiltedEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "WaltonUnstableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("floor_heat_ceiling_cool_unstable_tilted_equation_user_curve_name")]
        public string FloorHeatCeilingCoolUnstableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for all w" +
                     "indow surfaces")]
        [JsonProperty("floor_heat_ceiling_cool_window_equation_source")]
        public EmptyNoYes FloorHeatCeilingCoolWindowEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ISO15099Windows");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("floor_heat_ceiling_cool_window_equation_user_curve_name")]
        public string FloorHeatCeilingCoolWindowEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for vertical walls that are no" +
                     "t actively heated")]
        [JsonProperty("wall_panel_heating_vertical_wall_equation_source")]
        public EmptyNoYes WallPanelHeatingVerticalWallEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "KhalifaEq6NonHeatedWalls");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("wall_panel_heating_vertical_wall_equation_user_curve_name")]
        public string WallPanelHeatingVerticalWallEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for vertical walls that are be" +
                     "ing actively heated")]
        [JsonProperty("wall_panel_heating_heated_wall_equation_source")]
        public EmptyNoYes WallPanelHeatingHeatedWallEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "AwbiHattonHeatedWall");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("wall_panel_heating_heated_wall_equation_user_curve_name")]
        public string WallPanelHeatingHeatedWallEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for horizontal surfaces with h" +
                     "eat flow directed for stable thermal stratification")]
        [JsonProperty("wall_panel_heating_stable_horizontal_equation_source")]
        public EmptyNoYes WallPanelHeatingStableHorizontalEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "AlamdariHammondStableHorizontal");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("wall_panel_heating_stable_horizontal_equation_user_curve_name")]
        public string WallPanelHeatingStableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for horizontal surfaces with h" +
                     "eat flow directed for unstable thermal stratification")]
        [JsonProperty("wall_panel_heating_unstable_horizontal_equation_source")]
        public EmptyNoYes WallPanelHeatingUnstableHorizontalEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "KhalifaEq7Ceiling");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("wall_panel_heating_unstable_horizontal_equation_user_curve_name")]
        public string WallPanelHeatingUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for tilted surfaces with heat " +
                     "flow for stable thermal stratification")]
        [JsonProperty("wall_panel_heating_stable_tilted_equation_source")]
        public EmptyNoYes WallPanelHeatingStableTiltedEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "WaltonStableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("wall_panel_heating_stable_tilted_equation_user_curve_name")]
        public string WallPanelHeatingStableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for tilted surfaces with heat " +
                     "flow for unstable thermal stratification")]
        [JsonProperty("wall_panel_heating_unstable_tilted_equation_source")]
        public EmptyNoYes WallPanelHeatingUnstableTiltedEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "WaltonUnstableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("wall_panel_heating_unstable_tilted_equation_user_curve_name")]
        public string WallPanelHeatingUnstableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for all window surfaces")]
        [JsonProperty("wall_panel_heating_window_equation_source")]
        public EmptyNoYes WallPanelHeatingWindowEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ISO15099Windows");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("wall_panel_heating_window_equation_user_curve_name")]
        public string WallPanelHeatingWindowEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for vertical walls not directly af" +
                     "fected by heater")]
        [JsonProperty("convective_zone_heater_vertical_wall_equation_source")]
        public EmptyNoYes ConvectiveZoneHeaterVerticalWallEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "FohannoPolidoriVerticalWall");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("convective_zone_heater_vertical_wall_equation_user_curve_name")]
        public string ConvectiveZoneHeaterVerticalWallEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for vertical walls that are direct" +
                     "ly affected by heater Walls are considered \"near\" when listed in field set for F" +
                     "raction of Radiant Energy to Surface")]
        [JsonProperty("convective_zone_heater_vertical_walls_near_heater_equation_source")]
        public EmptyNoYes ConvectiveZoneHeaterVerticalWallsNearHeaterEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "KhalifaEq5WallNearHeat");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("convective_zone_heater_vertical_walls_near_heater_equation_user_curve_name")]
        public string ConvectiveZoneHeaterVerticalWallsNearHeaterEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for horizontal surfaces with heat " +
                     "flow directed for stable thermal stratification")]
        [JsonProperty("convective_zone_heater_stable_horizontal_equation_source")]
        public EmptyNoYes ConvectiveZoneHeaterStableHorizontalEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "AlamdariHammondStableHorizontal");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("convective_zone_heater_stable_horizontal_equation_user_curve_name")]
        public string ConvectiveZoneHeaterStableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for horizontal surfaces with heat " +
                     "flow directed for unstable thermal stratification")]
        [JsonProperty("convective_zone_heater_unstable_horizontal_equation_source")]
        public EmptyNoYes ConvectiveZoneHeaterUnstableHorizontalEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "KhalifaEq7Ceiling");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("convective_zone_heater_unstable_horizontal_equation_user_curve_name")]
        public string ConvectiveZoneHeaterUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for tilted surfaces with heat flow" +
                     " for stable thermal stratification")]
        [JsonProperty("convective_zone_heater_stable_tilted_equation_source")]
        public EmptyNoYes ConvectiveZoneHeaterStableTiltedEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "WaltonStableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("convective_zone_heater_stable_tilted_equation_user_curve_name")]
        public string ConvectiveZoneHeaterStableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for tilted surfaces with heat flow" +
                     " for unstable thermal stratification")]
        [JsonProperty("convective_zone_heater_unstable_tilted_equation_source")]
        public EmptyNoYes ConvectiveZoneHeaterUnstableTiltedEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "WaltonUnstableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("convective_zone_heater_unstable_tilted_equation_user_curve_name")]
        public string ConvectiveZoneHeaterUnstableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for all window surfaces")]
        [JsonProperty("convective_zone_heater_windows_equation_source")]
        public EmptyNoYes ConvectiveZoneHeaterWindowsEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ISO15099Windows");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("convective_zone_heater_windows_equation_user_curve_name")]
        public string ConvectiveZoneHeaterWindowsEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with mechanical forced central air with diffusers This is for all" +
                     " wall surfaces")]
        [JsonProperty("central_air_diffuser_wall_equation_source")]
        public EmptyNoYes CentralAirDiffuserWallEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "GoldsteinNovoselacCeilingDiffuserWalls");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("central_air_diffuser_wall_equation_user_curve_name")]
        public string CentralAirDiffuserWallEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with mechanical forced central air with diffusers This is for all" +
                     " ceiling surfaces")]
        [JsonProperty("central_air_diffuser_ceiling_equation_source")]
        public EmptyNoYes CentralAirDiffuserCeilingEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "FisherPedersenCeilingDiffuserCeiling");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("central_air_diffuser_ceiling_equation_user_curve_name")]
        public string CentralAirDiffuserCeilingEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with mechanical forced central air with diffusers This is for all" +
                     " floor surfaces")]
        [JsonProperty("central_air_diffuser_floor_equation_source")]
        public EmptyNoYes CentralAirDiffuserFloorEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "GoldsteinNovoselacCeilingDiffuserFloor");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("central_air_diffuser_floor_equation_user_curve_name")]
        public string CentralAirDiffuserFloorEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with mechanical forced central air with diffusers This is for all" +
                     " window surfaces")]
        [JsonProperty("central_air_diffuser_window_equation_source")]
        public EmptyNoYes CentralAirDiffuserWindowEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "GoldsteinNovoselacCeilingDiffuserWindow");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("central_air_diffuser_window_equation_user_curve_name")]
        public string CentralAirDiffuserWindowEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty("mechanical_zone_fan_circulation_vertical_wall_equation_source")]
        public EmptyNoYes MechanicalZoneFanCirculationVerticalWallEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "KhalifaEq3WallAwayFromHeat");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("mechanical_zone_fan_circulation_vertical_wall_equation_user_curve_name")]
        public string MechanicalZoneFanCirculationVerticalWallEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty("mechanical_zone_fan_circulation_stable_horizontal_equation_source")]
        public EmptyNoYes MechanicalZoneFanCirculationStableHorizontalEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "AlamdariHammondStableHorizontal");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("mechanical_zone_fan_circulation_stable_horizontal_equation_user_curve_name")]
        public string MechanicalZoneFanCirculationStableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty("mechanical_zone_fan_circulation_unstable_horizontal_equation_source")]
        public EmptyNoYes MechanicalZoneFanCirculationUnstableHorizontalEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "KhalifaEq4CeilingAwayFromHeat");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("mechanical_zone_fan_circulation_unstable_horizontal_equation_user_curve_name")]
        public string MechanicalZoneFanCirculationUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty("mechanical_zone_fan_circulation_stable_tilted_equation_source")]
        public EmptyNoYes MechanicalZoneFanCirculationStableTiltedEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "WaltonStableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("mechanical_zone_fan_circulation_stable_tilted_equation_user_curve_name")]
        public string MechanicalZoneFanCirculationStableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty("mechanical_zone_fan_circulation_unstable_tilted_equation_source")]
        public EmptyNoYes MechanicalZoneFanCirculationUnstableTiltedEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "WaltonUnstableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("mechanical_zone_fan_circulation_unstable_tilted_equation_user_curve_name")]
        public string MechanicalZoneFanCirculationUnstableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty("mechanical_zone_fan_circulation_window_equation_source")]
        public EmptyNoYes MechanicalZoneFanCirculationWindowEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ISO15099Windows");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("mechanical_zone_fan_circulation_window_equation_user_curve_name")]
        public string MechanicalZoneFanCirculationWindowEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty("mixed_regime_buoyancy_assisting_flow_on_walls_equation_source")]
        public EmptyNoYes MixedRegimeBuoyancyAssistingFlowOnWallsEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "BeausoleilMorrisonMixedAssistedWall");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("mixed_regime_buoyancy_assisting_flow_on_walls_equation_user_curve_name")]
        public string MixedRegimeBuoyancyAssistingFlowOnWallsEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty("mixed_regime_buoyancy_opposing_flow_on_walls_equation_source")]
        public EmptyNoYes MixedRegimeBuoyancyOpposingFlowOnWallsEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "BeausoleilMorrisonMixedOpposingWall");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("mixed_regime_buoyancy_opposing_flow_on_walls_equation_user_curve_name")]
        public string MixedRegimeBuoyancyOpposingFlowOnWallsEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty("mixed_regime_stable_floor_equation_source")]
        public EmptyNoYes MixedRegimeStableFloorEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "BeausoleilMorrisonMixedStableFloor");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("mixed_regime_stable_floor_equation_user_curve_name")]
        public string MixedRegimeStableFloorEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty("mixed_regime_unstable_floor_equation_source")]
        public EmptyNoYes MixedRegimeUnstableFloorEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "BeausoleilMorrisonMixedUnstableFloor");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("mixed_regime_unstable_floor_equation_user_curve_name")]
        public string MixedRegimeUnstableFloorEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty("mixed_regime_stable_ceiling_equation_source")]
        public EmptyNoYes MixedRegimeStableCeilingEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "BeausoleilMorrisonMixedStableCeiling");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("mixed_regime_stable_ceiling_equation_user_curve_name")]
        public string MixedRegimeStableCeilingEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty("mixed_regime_unstable_ceiling_equation_source")]
        public EmptyNoYes MixedRegimeUnstableCeilingEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "BeausoleilMorrisonMixedUnstableCeiling");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("mixed_regime_unstable_ceiling_equation_user_curve_name")]
        public string MixedRegimeUnstableCeilingEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty("mixed_regime_window_equation_source")]
        public EmptyNoYes MixedRegimeWindowEquationSource { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "GoldsteinNovoselacCeilingDiffuserWindow");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty("mixed_regime_window_equation_user_curve_name")]
        public string MixedRegimeWindowEquationUserCurveName { get; set; } = "";
    }
}