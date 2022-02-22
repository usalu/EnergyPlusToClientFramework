using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("used for shading elements such as trees, other buildings, parts of this building " +
                 "not being modeled these items are relative to the current building and would mov" +
                 "e with relative geometry")]
    public class Shading_Building : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Facing direction of outside of shading device (S=180,N=0,E=90,W=270)")]
        [JsonProperty("azimuth_angle")]
        public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

        [JsonProperty("tilt_angle")]
        public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

        [Description("Starting coordinate is the Lower Left Corner of the Shade")]
        [JsonProperty("starting_x_coordinate")]
        public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

        [JsonProperty("starting_y_coordinate")]
        public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

        [JsonProperty("starting_z_coordinate")]
        public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

        [JsonProperty("length")]
        public System.Nullable<float> Length { get; set; } = null;
        

        [JsonProperty("height")]
        public System.Nullable<float> Height { get; set; } = null;
    }
}