using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Describes an array of photovoltaic (PV) modules. A series of different PV arrays can be connected to a single electric load center (and inverter) by listing them all in an ElectricLoadCenter:Generator object. PV performance is taken from the referenced PhotovoltaicPerformance:* object. Array tilt, azimuth, and gross area are taken from the referenced building surface or shading surface. The array surface participates normally in all shading calculations.")]
    [JsonObject("Generator:Photovoltaic")]
    public class Generator_Photovoltaic : BHoMObject
    {
        

        [JsonProperty("surface_name")]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty("photovoltaic_performance_object_type")]
        public EmptyNoYes PhotovoltaicPerformanceObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("PV array modeling details")]
        [JsonProperty("module_performance_name")]
        public string ModulePerformanceName { get; set; } = "";
        

        [JsonProperty("heat_transfer_integration_mode")]
        public EmptyNoYes HeatTransferIntegrationMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Decoupled");
        

        [Description("number of series-wired strings of PV modules that are in parallel")]
        [JsonProperty("number_of_series_strings_in_parallel")]
        public System.Nullable<float> NumberOfSeriesStringsInParallel { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Number of PV modules wired in series for each string.")]
        [JsonProperty("number_of_modules_in_series")]
        public System.Nullable<float> NumberOfModulesInSeries { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}