using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description(@"default style for the Daylighting Illuminance Map is comma -- this works well for importing into spreadsheet programs such as Excel(tm) but not so well for word processing programs -- there tab may be a better choice. fixed puts spaces between the ""columns""")]
    [JsonObject("OutputControl:IlluminanceMap:Style")]
    public class OutputControl_IlluminanceMap_Style : BHoMObject
    {
        

        [JsonProperty("column_separator")]
        public EmptyNoYes ColumnSeparator { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Comma");
    }
}