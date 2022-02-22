using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("A Schedule:File:Shading points to a CSV file that has 8760-8784 hours of sunlit f" +
                 "raction data for all or some of the exterior surfaces.")]
    public class Schedule_File_Shading : BHoMObject, IEnergyPlusClass
    {
        

        [Description("The name of the file that writes all shading data.")]
        [JsonProperty("file_name")]
        public string FileName { get; set; } = "";
    }
}