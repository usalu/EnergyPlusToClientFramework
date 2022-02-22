using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("The ground domain object for underground piping system simulation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PipingSystem_Underground_Domain : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Domain extent in the local \'X\' direction")]
        [JsonProperty("xmax")]
        public System.Nullable<float> Xmax { get; set; } = null;
        

        [Description("Domain extent in the local \'Y\' direction")]
        [JsonProperty("ymax")]
        public System.Nullable<float> Ymax { get; set; } = null;
        

        [Description("Domain extent in the local \'Y\' direction")]
        [JsonProperty("zmax")]
        public System.Nullable<float> Zmax { get; set; } = null;
        

        [Description("If mesh type is symmetric geometric, this should be an even number.")]
        [JsonProperty("x_direction_mesh_density_parameter")]
        public System.Nullable<float> XDirectionMeshDensityParameter { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

        [JsonProperty("x_direction_mesh_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PipingSystem_Underground_Domain_XDirectionMeshType XDirectionMeshType { get; set; } = (PipingSystem_Underground_Domain_XDirectionMeshType)Enum.Parse(typeof(PipingSystem_Underground_Domain_XDirectionMeshType), "SymmetricGeometric");
        

        [Description("optional Only used if mesh type is symmetric geometric")]
        [JsonProperty("x_direction_geometric_coefficient")]
        public System.Nullable<float> XDirectionGeometricCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1.3", CultureInfo.InvariantCulture);
        

        [Description("If mesh type is symmetric geometric, this should be an even number.")]
        [JsonProperty("y_direction_mesh_density_parameter")]
        public System.Nullable<float> YDirectionMeshDensityParameter { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

        [JsonProperty("y_direction_mesh_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PipingSystem_Underground_Domain_YDirectionMeshType YDirectionMeshType { get; set; } = (PipingSystem_Underground_Domain_YDirectionMeshType)Enum.Parse(typeof(PipingSystem_Underground_Domain_YDirectionMeshType), "SymmetricGeometric");
        

        [Description("optional Only used if mesh type is symmetric geometric")]
        [JsonProperty("y_direction_geometric_coefficient")]
        public System.Nullable<float> YDirectionGeometricCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1.3", CultureInfo.InvariantCulture);
        

        [Description("If mesh type is symmetric geometric, this should be an even number.")]
        [JsonProperty("z_direction_mesh_density_parameter")]
        public System.Nullable<float> ZDirectionMeshDensityParameter { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

        [JsonProperty("z_direction_mesh_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PipingSystem_Underground_Domain_ZDirectionMeshType ZDirectionMeshType { get; set; } = (PipingSystem_Underground_Domain_ZDirectionMeshType)Enum.Parse(typeof(PipingSystem_Underground_Domain_ZDirectionMeshType), "SymmetricGeometric");
        

        [Description("optional Only used if mesh type is symmetric geometric")]
        [JsonProperty("z_direction_geometric_coefficient")]
        public System.Nullable<float> ZDirectionGeometricCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("1.3", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_thermal_conductivity")]
        public System.Nullable<float> SoilThermalConductivity { get; set; } = null;
        

        [JsonProperty("soil_density")]
        public System.Nullable<float> SoilDensity { get; set; } = null;
        

        [Description("This is a dry soil property, which is adjusted for freezing effects by the simula" +
                     "tion algorithm.")]
        [JsonProperty("soil_specific_heat")]
        public System.Nullable<float> SoilSpecificHeat { get; set; } = null;
        

        [JsonProperty("soil_moisture_content_volume_fraction")]
        public System.Nullable<float> SoilMoistureContentVolumeFraction { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_moisture_content_volume_fraction_at_saturation")]
        public System.Nullable<float> SoilMoistureContentVolumeFractionAtSaturation { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [JsonProperty("undisturbed_ground_temperature_model_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PipingSystem_Underground_Domain_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (PipingSystem_Underground_Domain_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(PipingSystem_Underground_Domain_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

        [JsonProperty("undisturbed_ground_temperature_model_name")]
        public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

        [Description("if Yes, then the following basement inputs are used if No, then the following bas" +
                     "ement inputs are *ignored*")]
        [JsonProperty("this_domain_includes_basement_surface_interaction")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ThisDomainIncludesBasementSurfaceInteraction { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Required only if Domain Has Basement Interaction")]
        [JsonProperty("width_of_basement_floor_in_ground_domain")]
        public System.Nullable<float> WidthOfBasementFloorInGroundDomain { get; set; } = null;
        

        [Description("Required only if Domain Has Basement Interaction")]
        [JsonProperty("depth_of_basement_wall_in_ground_domain")]
        public System.Nullable<float> DepthOfBasementWallInGroundDomain { get; set; } = null;
        

        [Description("Required only if Domain Has Basement Interaction")]
        [JsonProperty("shift_pipe_x_coordinates_by_basement_width")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PipingSystem_Underground_Domain_ShiftPipeXCoordinatesByBasementWidth ShiftPipeXCoordinatesByBasementWidth { get; set; } = (PipingSystem_Underground_Domain_ShiftPipeXCoordinatesByBasementWidth)Enum.Parse(typeof(PipingSystem_Underground_Domain_ShiftPipeXCoordinatesByBasementWidth), "No");
        

        [Description("Required only if Domain Has Basement Interaction")]
        [JsonProperty("name_of_basement_wall_boundary_condition_model")]
        public string NameOfBasementWallBoundaryConditionModel { get; set; } = "";
        

        [Description("Required only if Domain Has Basement Interaction")]
        [JsonProperty("name_of_basement_floor_boundary_condition_model")]
        public string NameOfBasementFloorBoundaryConditionModel { get; set; } = "";
        

        [JsonProperty("convergence_criterion_for_the_outer_cartesian_domain_iteration_loop")]
        public System.Nullable<float> ConvergenceCriterionForTheOuterCartesianDomainIterationLoop { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_iterations_in_the_outer_cartesian_domain_iteration_loop")]
        public System.Nullable<float> MaximumIterationsInTheOuterCartesianDomainIterationLoop { get; set; } = (System.Nullable<float>)Single.Parse("500", CultureInfo.InvariantCulture);
        

        [Description(@"This specifies the ground cover effects during evapotranspiration calculations. The value roughly represents the following cases: = 0   : concrete or other solid, non-permeable ground surface material = 0.5 : short grass, much like a manicured lawn = 1   : standard reference state (12 cm grass) = 1.5 : wild growth")]
        [JsonProperty("evapotranspiration_ground_cover_parameter")]
        public System.Nullable<float> EvapotranspirationGroundCoverParameter { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty("number_of_pipe_circuits_entered_for_this_domain")]
        public System.Nullable<float> NumberOfPipeCircuitsEnteredForThisDomain { get; set; } = null;
        

        [JsonProperty("pipe_circuits")]
        public string PipeCircuits { get; set; } = "";
    }
}