using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [Description("Thermal and optical performance parameters for a single glazed solar collector wi" +
                 "th integral storage unit.")]
    public class SolarCollectorPerformance_IntegralCollectorStorage : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Currently only RectangularTank ICS collector type is available.")]
        [JsonProperty("ics_collector_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SolarCollectorPerformance_IntegralCollectorStorage_IcsCollectorType IcsCollectorType { get; set; } = (SolarCollectorPerformance_IntegralCollectorStorage_IcsCollectorType)Enum.Parse(typeof(SolarCollectorPerformance_IntegralCollectorStorage_IcsCollectorType), "RectangularTank");
        

        [JsonProperty("gross_area")]
        public System.Nullable<float> GrossArea { get; set; } = null;
        

        [JsonProperty("collector_water_volume")]
        public System.Nullable<float> CollectorWaterVolume { get; set; } = null;
        

        [Description("Heat loss conductance of the collector bottom insulation")]
        [JsonProperty("bottom_heat_loss_conductance")]
        public System.Nullable<float> BottomHeatLossConductance { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [Description("heat loss conductance of the collector side insulation")]
        [JsonProperty("side_heat_loss_conductance")]
        public System.Nullable<float> SideHeatLossConductance { get; set; } = (System.Nullable<float>)Single.Parse("0.6", CultureInfo.InvariantCulture);
        

        [Description("This value is ratio of the width (short side) to length (long side of) of the col" +
                     "lector. Used to calculate the perimeter of the collector")]
        [JsonProperty("aspect_ratio")]
        public System.Nullable<float> AspectRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [Description("This value is used to estimate collector side area for the heat loss calculation " +
                     "through the collector side")]
        [JsonProperty("collector_side_height")]
        public System.Nullable<float> CollectorSideHeight { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("Calculated from the specific heat, density and thickness of the absorber plate.")]
        [JsonProperty("thermal_mass_of_absorber_plate")]
        public System.Nullable<float> ThermalMassOfAbsorberPlate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Number of transparent covers. Common practice is to use low-iron glass as the out" +
                     "er cover and very thin transparent sheet such as Teflon as the inner cover.")]
        [JsonProperty("number_of_covers")]
        public System.Nullable<float> NumberOfCovers { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("The gap between the transparent covers and between the inner cover and the absorb" +
                     "er plate")]
        [JsonProperty("cover_spacing")]
        public System.Nullable<float> CoverSpacing { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

        [Description("Refractive index of outer cover. Typically low-iron glass is used as the outer co" +
                     "ver material, and used as the default outer cover with a value of 1.526.")]
        [JsonProperty("refractive_index_of_outer_cover")]
        public System.Nullable<float> RefractiveIndexOfOuterCover { get; set; } = (System.Nullable<float>)Single.Parse("1.526", CultureInfo.InvariantCulture);
        

        [Description("Clear glass has extinction coefficient of about 15 [1/m] and with thickness of 3." +
                     "0mm, the product of the extinction coefficient and thickness becomes 0.045 (=15 " +
                     "* 0.003)")]
        [JsonProperty("extinction_coefficient_times_thickness_of_outer_cover")]
        public System.Nullable<float> ExtinctionCoefficientTimesThicknessOfOuterCover { get; set; } = (System.Nullable<float>)Single.Parse("0.045", CultureInfo.InvariantCulture);
        

        [Description("Thermal emissivity of the outer cover, commonly glass is used as the out collecto" +
                     "r cover material.")]
        [JsonProperty("emissivity_of_outer_cover")]
        public System.Nullable<float> EmissivityOfOuterCover { get; set; } = (System.Nullable<float>)Single.Parse("0.88", CultureInfo.InvariantCulture);
        

        [Description("Typical material is very thin sheet of Teflon (PTFE). The default value is refrac" +
                     "tive index of Teflon.")]
        [JsonProperty("refractive_index_of_inner_cover")]
        public System.Nullable<float> RefractiveIndexOfInnerCover { get; set; } = (System.Nullable<float>)Single.Parse("1.37", CultureInfo.InvariantCulture);
        

        [Description("Default inner cover is very thin sheet of Teflon with extinction coefficient of a" +
                     "pproximately 40.0 and a thickness 0.2mm yields a default value of 0.008.")]
        [JsonProperty("extinction_coefficient_times_thickness_of_the_inner_cover")]
        public System.Nullable<float> ExtinctionCoefficientTimesThicknessOfTheInnerCover { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

        [Description("Thermal emissivity of the inner cover material")]
        [JsonProperty("emissivity_of_inner_cover")]
        public System.Nullable<float> EmissivityOfInnerCover { get; set; } = (System.Nullable<float>)Single.Parse("0.88", CultureInfo.InvariantCulture);
        

        [Description("The absorber plate solar absorptance. Copper is assumed as the default absorber p" +
                     "late.")]
        [JsonProperty("absorptance_of_absorber_plate")]
        public System.Nullable<float> AbsorptanceOfAbsorberPlate { get; set; } = (System.Nullable<float>)Single.Parse("0.96", CultureInfo.InvariantCulture);
        

        [Description("Thermal emissivity of the absorber plate")]
        [JsonProperty("emissivity_of_absorber_plate")]
        public System.Nullable<float> EmissivityOfAbsorberPlate { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
    }
}