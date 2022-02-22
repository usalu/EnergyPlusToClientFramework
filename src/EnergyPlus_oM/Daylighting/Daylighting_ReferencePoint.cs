using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description("Used by Daylighting:Controls to identify the reference point coordinates for each" +
                 " sensor. Reference points are given in coordinates specified in the GlobalGeomet" +
                 "ryRules object Daylighting Reference Point CoordinateSystem field")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Daylighting_ReferencePoint : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("x_coordinate_of_reference_point")]
        public System.Nullable<float> XCoordinateOfReferencePoint { get; set; } = null;
        

        [JsonProperty("y_coordinate_of_reference_point")]
        public System.Nullable<float> YCoordinateOfReferencePoint { get; set; } = null;
        

        [JsonProperty("z_coordinate_of_reference_point")]
        public System.Nullable<float> ZCoordinateOfReferencePoint { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
    }
}