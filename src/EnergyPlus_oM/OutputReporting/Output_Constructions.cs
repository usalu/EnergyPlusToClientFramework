using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Adds a report to the eio output file which shows details for each construction, i" +
                 "ncluding overall properties, a list of material layers, and calculated results r" +
                 "elated to conduction transfer functions.")]
    [JsonObject("Output:Constructions")]
    public class Output_Constructions : BHoMObject
    {
        

        [JsonProperty("details_type_1")]
        public EmptyNoYes DetailsType1 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("details_type_2")]
        public EmptyNoYes DetailsType2 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
    }
}