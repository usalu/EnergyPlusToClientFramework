using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"Two types of subcoolers are modeled by the detailed refrigeration system. The liquid suction heat exchanger uses cool suction gas to subcool the hot condensate after it leaves the condenser and before it reaches the thermal expansion valve. A mechanical subcooler is used to transfer cooling capacity from one refrigeration system to another.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_Subcooler : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("plan to add ambient subcoolers at future time")]
        [JsonProperty("subcooler_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_Subcooler_SubcoolerType SubcoolerType { get; set; } = (Refrigeration_Subcooler_SubcoolerType)Enum.Parse(typeof(Refrigeration_Subcooler_SubcoolerType), "LiquidSuction");
        

        [Description("Applicable only and required for liquid suction heat exchangers design liquid suc" +
                     "tion subcooling")]
        [JsonProperty("liquid_suction_design_subcooling_temperature_difference")]
        public System.Nullable<float> LiquidSuctionDesignSubcoolingTemperatureDifference { get; set; } = null;
        

        [Description("design inlet temperature on liquid side Applicable only and required for liquid s" +
                     "uction heat exchangers (LSHX)")]
        [JsonProperty("design_liquid_inlet_temperature")]
        public System.Nullable<float> DesignLiquidInletTemperature { get; set; } = null;
        

        [Description("design inlet temperature on vapor side Applicable only and required for liquid su" +
                     "ction heat exchangers (LSHX) Design vapor inlet temperature must be less than or" +
                     " equal to the Liquid inlet design temp")]
        [JsonProperty("design_vapor_inlet_temperature")]
        public System.Nullable<float> DesignVaporInletTemperature { get; set; } = null;
        

        [Description("Name of the Detailed Refrigeration System providing cooling capacity Applicable o" +
                     "nly and required for mechanical subcoolers")]
        [JsonProperty("capacity_providing_system")]
        public string CapacityProvidingSystem { get; set; } = "";
        

        [Description("Control Temperature Out for subcooled liquid Applicable only and required for mec" +
                     "hanical subcoolers")]
        [JsonProperty("outlet_control_temperature")]
        public System.Nullable<float> OutletControlTemperature { get; set; } = null;
    }
}