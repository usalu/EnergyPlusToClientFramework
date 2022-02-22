using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Defines a thermal zone of the building.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Zone : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("direction_of_relative_north")]
        public System.Nullable<float> DirectionOfRelativeNorth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("x_origin")]
        public System.Nullable<float> XOrigin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("y_origin")]
        public System.Nullable<float> YOrigin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("z_origin")]
        public System.Nullable<float> ZOrigin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("type")]
        public System.Nullable<float> Type { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("multiplier")]
        public System.Nullable<float> Multiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"If this field is 0.0, negative or autocalculate, then the average height of the zone is automatically calculated and used in subsequent calculations. If this field is positive, then the number entered here will be used. Note that the Zone Ceiling Height is the distance from the Floor to the Ceiling in the Zone, not an absolute height from the ground.")]
        [JsonProperty("ceiling_height")]
        public string CeilingHeight { get; set; } = (System.String)"Autocalculate";
        

        [Description("If this field is 0.0, negative or autocalculate, then the volume of the zone is a" +
                     "utomatically calculated and used in subsequent calculations. If this field is po" +
                     "sitive, then the number entered here will be used.")]
        [JsonProperty("volume")]
        public string Volume { get; set; } = (System.String)"Autocalculate";
        

        [Description("If this field is 0.0, negative or autocalculate, then the floor area of the zone " +
                     "is automatically calculated and used in subsequent calculations. If this field i" +
                     "s positive, then the number entered here will be used.")]
        [JsonProperty("floor_area")]
        public string FloorArea { get; set; } = (System.String)"Autocalculate";
        

        [Description(@"Will default to same value as SurfaceConvectionAlgorithm:Inside object setting this field overrides the default SurfaceConvectionAlgorithm:Inside for this zone Simple = constant natural convection (ASHRAE) TARP = variable natural convection based on temperature difference (ASHRAE) CeilingDiffuser = ACH based forced and mixed convection correlations for ceiling diffuser configuration with simple natural convection limit AdaptiveConvectionAlgorithm = dynamic selection of convection models based on conditions TrombeWall = variable natural convection in an enclosed rectangular cavity ASTMC1340 = mixed convection correlations specified for attic zone")]
        [JsonProperty("zone_inside_convection_algorithm")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Zone_ZoneInsideConvectionAlgorithm ZoneInsideConvectionAlgorithm { get; set; } = (Zone_ZoneInsideConvectionAlgorithm)Enum.Parse(typeof(Zone_ZoneInsideConvectionAlgorithm), "Empty");
        

        [Description(@"Will default to same value as SurfaceConvectionAlgorithm:Outside object setting this field overrides the default SurfaceConvectionAlgorithm:Outside for this zone SimpleCombined = Combined radiation and convection coefficient using simple ASHRAE model TARP = correlation from models developed by ASHRAE, Walton, and Sparrow et. al. MoWiTT = correlation from measurements by Klems and Yazdanian for smooth surfaces DOE-2 = correlation from measurements by Klems and Yazdanian for rough surfaces AdaptiveConvectionAlgorithm = dynamic selection of correlations based on conditions")]
        [JsonProperty("zone_outside_convection_algorithm")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Zone_ZoneOutsideConvectionAlgorithm ZoneOutsideConvectionAlgorithm { get; set; } = (Zone_ZoneOutsideConvectionAlgorithm)Enum.Parse(typeof(Zone_ZoneOutsideConvectionAlgorithm), "Empty");
        

        [JsonProperty("part_of_total_floor_area")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes PartOfTotalFloorArea { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
}