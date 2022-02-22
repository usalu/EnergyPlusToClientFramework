using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Describes parameters that are used during the simulation of the building. There a" +
                 "re necessary correlations between the entries for this object and some entries i" +
                 "n the Site:WeatherStation and Site:HeightVariation objects, specifically the Ter" +
                 "rain field.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Building : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("degrees from true North")]
        [JsonProperty("north_axis")]
        public System.Nullable<float> NorthAxis { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Country=FlatOpenCountry | Suburbs=CountryTownsSuburbs | City=CityCenter | Ocean=b" +
                     "ody of water (5km) | Urban=Urban-Industrial-Forest")]
        [JsonProperty("terrain")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Building_Terrain Terrain { get; set; } = (Building_Terrain)Enum.Parse(typeof(Building_Terrain), "Suburbs");
        

        [Description("Loads Convergence Tolerance Value is a change in load from one warmup day to the " +
                     "next")]
        [JsonProperty("loads_convergence_tolerance_value")]
        public System.Nullable<float> LoadsConvergenceToleranceValue { get; set; } = (System.Nullable<float>)Single.Parse("0.04", CultureInfo.InvariantCulture);
        

        [JsonProperty("temperature_convergence_tolerance_value")]
        public System.Nullable<float> TemperatureConvergenceToleranceValue { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [Description("MinimalShadowing | FullExterior | FullInteriorAndExterior | FullExteriorWithRefle" +
                     "ctions | FullInteriorAndExteriorWithReflections")]
        [JsonProperty("solar_distribution")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Building_SolarDistribution SolarDistribution { get; set; } = (Building_SolarDistribution)Enum.Parse(typeof(Building_SolarDistribution), "FullExterior");
        

        [Description("EnergyPlus will only use as many warmup days as needed to reach convergence toler" +
                     "ance. This field\'s value should NOT be set less than 25.")]
        [JsonProperty("maximum_number_of_warmup_days")]
        public System.Nullable<float> MaximumNumberOfWarmupDays { get; set; } = (System.Nullable<float>)Single.Parse("25", CultureInfo.InvariantCulture);
        

        [Description(@"The minimum number of warmup days that produce enough temperature and flux history to start EnergyPlus simulation for all reference buildings was suggested to be 6. However this can lead to excessive run times as warmup days can be repeated needlessly. For faster execution rely on the convergence criteria to detect when warmup is complete. When this field is greater than the maximum warmup days defined previous field the maximum number of warmup days will be reset to the minimum value entered here. Warmup days will be set to be the value you entered. The default is 1.")]
        [JsonProperty("minimum_number_of_warmup_days")]
        public System.Nullable<float> MinimumNumberOfWarmupDays { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}