using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for simplified entry of interzone walls (walls between zones).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Wall_Interzone : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [Description("Zone for the inside of the surface")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Specify a surface name in an adjacent zone for known interior walls. Specify a zo" +
                     "ne name of an adjacent zone to automatically generate the interior wall in the a" +
                     "djacent zone.")]
        [JsonProperty("outside_boundary_condition_object")]
        public string OutsideBoundaryConditionObject { get; set; } = "";
        

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