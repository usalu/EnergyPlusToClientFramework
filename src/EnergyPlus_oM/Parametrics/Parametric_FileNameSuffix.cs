using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Parametrics
{
    [Description("Defines the suffixes to be appended to the idf and output file names for each par" +
                 "ametric run. If this object is omitted, the suffix will default to the run numbe" +
                 "r.")]
    public class Parametric_FileNameSuffix : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("suffixes")]
        public string Suffixes { get; set; } = "";
    }
}