using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for simplified entry of exterior floors ignoring ground contact or interio" +
                 "r floors. View Factor to Ground is automatically calculated.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Floor_Adiabatic : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [Description("Zone the surface is a part of")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("azimuth_angle")]
        public System.Nullable<float> AzimuthAngle { get; set; } = null;
        

        [Description("Floors are usually tilted 180 degrees")]
        [JsonProperty("tilt_angle")]
        public System.Nullable<float> TiltAngle { get; set; } = (System.Nullable<float>)Single.Parse("180", CultureInfo.InvariantCulture);
        

        [Description("if not flat, should be lower left corner (from outside)")]
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