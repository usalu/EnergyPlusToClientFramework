using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Initiates search of the Window data file for a window called Name.")]
    public class Construction_WindowDataFile : BHoMObject, IEnergyPlusClass
    {
        

        [Description("default file name is \"Window5DataFile.dat\" limit on this field is 100 characters." +
                     "")]
        [JsonProperty("file_name")]
        public string FileName { get; set; } = "";
    }
}