using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description("reference points are given in coordinates specified in the GlobalGeometryRules ob" +
                 "ject Daylighting Reference Point CoordinateSystem field")]
    public class Output_IlluminanceMap : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("z_height")]
        public System.Nullable<float> ZHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("x_minimum_coordinate")]
        public System.Nullable<float> XMinimumCoordinate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("x_maximum_coordinate")]
        public System.Nullable<float> XMaximumCoordinate { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Maximum number of total grid points must be <= 2500 (X*Y)")]
        [JsonProperty("number_of_x_grid_points")]
        public System.Nullable<float> NumberOfXGridPoints { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [JsonProperty("y_minimum_coordinate")]
        public System.Nullable<float> YMinimumCoordinate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("y_maximum_coordinate")]
        public System.Nullable<float> YMaximumCoordinate { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Maximum number of total grid points must be <= 2500 (X*Y)")]
        [JsonProperty("number_of_y_grid_points")]
        public System.Nullable<float> NumberOfYGridPoints { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
}