using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Describes the insulation used on an exterior basement wall for the Basement prepr" +
                 "ocessor ground heat transfer simulation.")]
    [JsonObject("GroundHeatTransfer:Basement:Insulation")]
    public class GroundHeatTransfer_Basement_Insulation : BHoMObject
    {
        

        [JsonProperty("rext_r_value_of_any_exterior_insulation")]
        public System.Nullable<float> RextRValueOfAnyExteriorInsulation { get; set; } = null;
        

        [Description("True for full insulation False for insulation half way down side wall from grade " +
                     "line")]
        [JsonProperty("insfull_flag_is_the_wall_fully_insulated_")]
        public EmptyNoYes InsfullFlagIsTheWallFullyInsulated { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
    }
}