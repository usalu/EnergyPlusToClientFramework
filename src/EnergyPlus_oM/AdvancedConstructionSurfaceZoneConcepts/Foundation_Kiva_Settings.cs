using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Settings applied across all Kiva foundation calculations. Object is not required." +
                 " If not defined, defaults will be applied.")]
    [JsonObject("Foundation:Kiva:Settings")]
    public class Foundation_Kiva_Settings : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("soil_conductivity")]
        public System.Nullable<float> SoilConductivity { get; set; } = (System.Nullable<float>)Single.Parse("1.73", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_density")]
        public System.Nullable<float> SoilDensity { get; set; } = (System.Nullable<float>)Single.Parse("1842", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_specific_heat")]
        public System.Nullable<float> SoilSpecificHeat { get; set; } = (System.Nullable<float>)Single.Parse("419", CultureInfo.InvariantCulture);
        

        [JsonProperty("ground_solar_absorptivity")]
        public System.Nullable<float> GroundSolarAbsorptivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("ground_thermal_absorptivity")]
        public System.Nullable<float> GroundThermalAbsorptivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("ground_surface_roughness")]
        public System.Nullable<float> GroundSurfaceRoughness { get; set; } = (System.Nullable<float>)Single.Parse("0.03", CultureInfo.InvariantCulture);
        

        [JsonProperty("far_field_width")]
        public System.Nullable<float> FarFieldWidth { get; set; } = (System.Nullable<float>)Single.Parse("40", CultureInfo.InvariantCulture);
        

        [JsonProperty("deep_ground_boundary_condition")]
        public Foundation_Kiva_Settings_DeepGroundBoundaryCondition DeepGroundBoundaryCondition { get; set; } = (Foundation_Kiva_Settings_DeepGroundBoundaryCondition)Enum.Parse(typeof(Foundation_Kiva_Settings_DeepGroundBoundaryCondition), "Autoselect");
        

        [JsonProperty("deep_ground_depth")]
        public string DeepGroundDepth { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("minimum_cell_dimension")]
        public System.Nullable<float> MinimumCellDimension { get; set; } = (System.Nullable<float>)Single.Parse("0.02", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_cell_growth_coefficient")]
        public System.Nullable<float> MaximumCellGrowthCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("simulation_timestep")]
        public Foundation_Kiva_Settings_SimulationTimestep SimulationTimestep { get; set; } = (Foundation_Kiva_Settings_SimulationTimestep)Enum.Parse(typeof(Foundation_Kiva_Settings_SimulationTimestep), "Hourly");
    }
}