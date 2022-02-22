using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Specifies the material properties for the Basement preprocessor ground heat trans" +
                 "fer simulation. Only the Foundation Wall, Floor Slab, Soil, and Gravel propertie" +
                 "s are currently used.")]
    public class GroundHeatTransfer_Basement_MatlProps : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("nmat_number_of_materials_in_this_domain")]
        public System.Nullable<float> NmatNumberOfMaterialsInThisDomain { get; set; } = null;
        

        [JsonProperty("density_for_foundation_wall")]
        public System.Nullable<float> DensityForFoundationWall { get; set; } = (System.Nullable<float>)Single.Parse("2243", CultureInfo.InvariantCulture);
        

        [JsonProperty("density_for_floor_slab")]
        public System.Nullable<float> DensityForFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("2243", CultureInfo.InvariantCulture);
        

        [JsonProperty("density_for_ceiling")]
        public System.Nullable<float> DensityForCeiling { get; set; } = (System.Nullable<float>)Single.Parse("311", CultureInfo.InvariantCulture);
        

        [JsonProperty("density_for_soil")]
        public System.Nullable<float> DensityForSoil { get; set; } = (System.Nullable<float>)Single.Parse("1500", CultureInfo.InvariantCulture);
        

        [JsonProperty("density_for_gravel")]
        public System.Nullable<float> DensityForGravel { get; set; } = (System.Nullable<float>)Single.Parse("2000", CultureInfo.InvariantCulture);
        

        [JsonProperty("density_for_wood")]
        public System.Nullable<float> DensityForWood { get; set; } = (System.Nullable<float>)Single.Parse("449", CultureInfo.InvariantCulture);
        

        [JsonProperty("specific_heat_for_foundation_wall")]
        public System.Nullable<float> SpecificHeatForFoundationWall { get; set; } = (System.Nullable<float>)Single.Parse("880", CultureInfo.InvariantCulture);
        

        [JsonProperty("specific_heat_for_floor_slab")]
        public System.Nullable<float> SpecificHeatForFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("880", CultureInfo.InvariantCulture);
        

        [JsonProperty("specific_heat_for_ceiling")]
        public System.Nullable<float> SpecificHeatForCeiling { get; set; } = (System.Nullable<float>)Single.Parse("1530", CultureInfo.InvariantCulture);
        

        [JsonProperty("specific_heat_for_soil")]
        public System.Nullable<float> SpecificHeatForSoil { get; set; } = (System.Nullable<float>)Single.Parse("840", CultureInfo.InvariantCulture);
        

        [JsonProperty("specific_heat_for_gravel")]
        public System.Nullable<float> SpecificHeatForGravel { get; set; } = (System.Nullable<float>)Single.Parse("720", CultureInfo.InvariantCulture);
        

        [JsonProperty("specific_heat_for_wood")]
        public System.Nullable<float> SpecificHeatForWood { get; set; } = (System.Nullable<float>)Single.Parse("1530", CultureInfo.InvariantCulture);
        

        [JsonProperty("thermal_conductivity_for_foundation_wall")]
        public System.Nullable<float> ThermalConductivityForFoundationWall { get; set; } = (System.Nullable<float>)Single.Parse("1.4", CultureInfo.InvariantCulture);
        

        [JsonProperty("thermal_conductivity_for_floor_slab")]
        public System.Nullable<float> ThermalConductivityForFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("1.4", CultureInfo.InvariantCulture);
        

        [JsonProperty("thermal_conductivity_for_ceiling")]
        public System.Nullable<float> ThermalConductivityForCeiling { get; set; } = (System.Nullable<float>)Single.Parse("0.09", CultureInfo.InvariantCulture);
        

        [JsonProperty("thermal_conductivity_for_soil")]
        public System.Nullable<float> ThermalConductivityForSoil { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

        [JsonProperty("thermal_conductivity_for_gravel")]
        public System.Nullable<float> ThermalConductivityForGravel { get; set; } = (System.Nullable<float>)Single.Parse("1.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("thermal_conductivity_for_wood")]
        public System.Nullable<float> ThermalConductivityForWood { get; set; } = (System.Nullable<float>)Single.Parse("0.12", CultureInfo.InvariantCulture);
    }
}