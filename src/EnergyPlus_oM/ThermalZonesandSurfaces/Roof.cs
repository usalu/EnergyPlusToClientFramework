using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for simplified entry of roofs (exterior). View Factor to Ground is automat" +
                 "ically calculated.")]
    public class Roof : BHoMObject, IEnergyPlusClass
    {
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [Description("Zone the surface is a part of")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Facing direction of outside of Roof")]
        [JsonProperty("azimuth_angle")]
        public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

        [Description("Flat Roofs are tilted 0 degrees")]
        [JsonProperty("tilt_angle")]
        public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("If not Flat, Starting coordinate is the Lower Left Corner of the Roof")]
        [JsonProperty("starting_x_coordinate")]
        public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

        [JsonProperty("starting_y_coordinate")]
        public System.Nullable<float> StartingYCoordinate { get; set; } = null;
        

        [JsonProperty("starting_z_coordinate")]
        public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

        [Description("Along X Axis")]
        [JsonProperty("length")]
        public System.Nullable<float> Length { get; set; } = null;
        

        [Description("Along Y Axis")]
        [JsonProperty("width")]
        public System.Nullable<float> Width { get; set; } = null;
    }
}