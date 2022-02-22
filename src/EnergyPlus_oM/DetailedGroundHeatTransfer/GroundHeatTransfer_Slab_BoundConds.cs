using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Supplies some of the boundary conditions used in the ground heat transfer calcula" +
                 "tions.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Slab_BoundConds : BHoMObject
    {
        

        [Description(@"This field specifies whether or not to use the evapotransporation model. The inclusion of evapotransporation in the calculation has the greatest effect in warm dry climates, primarily on the ground surface temperature. This field can be used to turn the evapotransporation off and on to check sensitivity to it.")]
        [JsonProperty("evtr_is_surface_evapotranspiration_modeled")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatTransfer_Slab_BoundConds_EvtrIsSurfaceEvapotranspirationModeled EvtrIsSurfaceEvapotranspirationModeled { get; set; } = (GroundHeatTransfer_Slab_BoundConds_EvtrIsSurfaceEvapotranspirationModeled)Enum.Parse(typeof(GroundHeatTransfer_Slab_BoundConds_EvtrIsSurfaceEvapotranspirationModeled), "FALSE");
        

        [Description("This field permits using a fixed temperature at the lower surface of the model in" +
                     "stead of a zero heat flux condition. This change normally has a very small effec" +
                     "t on the results. FALSE selects the zero flux lower boundary condition")]
        [JsonProperty("fixbc_is_the_lower_boundary_at_a_fixed_temperature")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatTransfer_Slab_BoundConds_FixbcIsTheLowerBoundaryAtAFixedTemperature FixbcIsTheLowerBoundaryAtAFixedTemperature { get; set; } = (GroundHeatTransfer_Slab_BoundConds_FixbcIsTheLowerBoundaryAtAFixedTemperature)Enum.Parse(typeof(GroundHeatTransfer_Slab_BoundConds_FixbcIsTheLowerBoundaryAtAFixedTemperature), "FALSE");
        

        [Description("User input lower boundary temperature if FIXBC is TRUE Blank for FIXBC FALSE or t" +
                     "o use the calculated 1-D deep ground temperature.")]
        [JsonProperty("tdeepin")]
        public System.Nullable<float> Tdeepin { get; set; } = null;
        

        [Description(@"This field flags the use of a user specified heat transfer coefficient on the ground surface. This condition is used primarily for testing. For normal runs (USPHflag is FALSE) and the program calculates the heat transfer coefficient using the weather conditions.")]
        [JsonProperty("usrhflag_is_the_ground_surface_h_specified_by_the_user_")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatTransfer_Slab_BoundConds_UsrhflagIsTheGroundSurfaceHSpecifiedByTheUser UsrhflagIsTheGroundSurfaceHSpecifiedByTheUser { get; set; } = (GroundHeatTransfer_Slab_BoundConds_UsrhflagIsTheGroundSurfaceHSpecifiedByTheUser)Enum.Parse(typeof(GroundHeatTransfer_Slab_BoundConds_UsrhflagIsTheGroundSurfaceHSpecifiedByTheUser), "FALSE");
        

        [Description("Used only if USRHflag is TRUE and the heat transfer coefficient value is specifie" +
                     "d in this field.")]
        [JsonProperty("userh_user_specified_ground_surface_heat_transfer_coefficient")]
        public System.Nullable<float> UserhUserSpecifiedGroundSurfaceHeatTransferCoefficient { get; set; } = null;
    }
}