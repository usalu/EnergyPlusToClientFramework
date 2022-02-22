using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for simplified entry of ceilings using adjacent zone (interzone) heat tran" +
                 "sfer - adjacent surface should be a floor")]
    public class Ceiling_Interzone : BHoMObject, IEnergyPlusClass
    {
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [Description("Zone for the inside of the surface")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Specify a surface name in an adjacent zone for known interior floors Specify a zo" +
                     "ne name of an adjacent zone to automatically generate the interior floor in the " +
                     "adjacent zone.")]
        [JsonProperty("outside_boundary_condition_object")]
        public string OutsideBoundaryConditionObject { get; set; } = "";
        

        [Description("Facing direction of outside of wall (S=180,N=0,E=90,W=270)")]
        [JsonProperty("azimuth_angle")]
        public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

        [Description("Ceilings are usually tilted 0 degrees")]
        [JsonProperty("tilt_angle")]
        public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("If not Flat, should be Lower Left Corner (from outside)")]
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