using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for simplified entry of interior walls.")]
    public class Wall_Adiabatic : BHoMObject, IEnergyPlusClass
    {
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [Description("Zone the surface is a part of")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Facing direction of outside of wall (S=180,N=0,E=90,W=270)")]
        [JsonProperty("azimuth_angle")]
        public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

        [Description("Walls are usually tilted 90 degrees")]
        [JsonProperty("tilt_angle")]
        public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

        [Description("Starting (x,y,z) coordinate is the Lower Left Corner of the Wall")]
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