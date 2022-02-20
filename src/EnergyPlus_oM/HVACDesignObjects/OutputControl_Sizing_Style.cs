using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description("Default style for the Sizing output files is comma -- this works well for importi" +
                 "ng into spreadsheet programs such as Excel(tm) but not so well for word processi" +
                 "ng programs -- there tab may be a better choice. Fixed puts spaces between the \"" +
                 "columns\"")]
    [JsonObject("OutputControl:Sizing:Style")]
    public class OutputControl_Sizing_Style : BHoMObject
    {
        

        [JsonProperty("column_separator")]
        public EmptyNoYes ColumnSeparator { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
    }
}