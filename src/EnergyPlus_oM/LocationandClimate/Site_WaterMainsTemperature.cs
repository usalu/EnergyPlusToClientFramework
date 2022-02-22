using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Used to calculate water mains temperatures delivered by underground water main pi" +
                 "pes. Water mains temperatures are a function of outdoor climate conditions and v" +
                 "ary with time of year.")]
    [JsonObject("Site:WaterMainsTemperature")]
    public class Site_WaterMainsTemperature : BHoMObject, IEnergyPlusClass
    {
        

        [Description("If calculation method is CorrelationFromWeatherFile, the two numeric input fields" +
                     " are ignored. Instead, EnergyPlus calculates them from weather file.")]
        [JsonProperty("calculation_method")]
        public Site_WaterMainsTemperature_CalculationMethod CalculationMethod { get; set; } = (Site_WaterMainsTemperature_CalculationMethod)Enum.Parse(typeof(Site_WaterMainsTemperature_CalculationMethod), "CorrelationFromWeatherFile");
        

        [JsonProperty("temperature_schedule_name")]
        public string TemperatureScheduleName { get; set; } = "";
        

        [Description("If calculation method is CorrelationFromWeatherFile or Schedule, this input field" +
                     " is ignored.")]
        [JsonProperty("annual_average_outdoor_air_temperature")]
        public System.Nullable<float> AnnualAverageOutdoorAirTemperature { get; set; } = null;
        

        [Description("If calculation method is CorrelationFromWeatherFile or Schedule, this input field" +
                     " is ignored.")]
        [JsonProperty("maximum_difference_in_monthly_average_outdoor_air_temperatures")]
        public System.Nullable<float> MaximumDifferenceInMonthlyAverageOutdoorAirTemperatures { get; set; } = null;
    }
}