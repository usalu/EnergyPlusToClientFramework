using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Initiates search of the Window data file for a window called Name.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction_WindowDataFile : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("default file name is \"Window5DataFile.dat\" limit on this field is 100 characters." +
                     "")]
        [JsonProperty("file_name")]
        public string FileName { get; set; } = "";
    }
}