using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description(@"default style for the Daylighting Illuminance Map is comma -- this works well for importing into spreadsheet programs such as Excel(tm) but not so well for word processing programs -- there tab may be a better choice. fixed puts spaces between the ""columns""")]
    public class OutputControl_IlluminanceMap_Style : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("column_separator")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_IlluminanceMap_Style_ColumnSeparator ColumnSeparator { get; set; } = (OutputControl_IlluminanceMap_Style_ColumnSeparator)Enum.Parse(typeof(OutputControl_IlluminanceMap_Style_ColumnSeparator), "Comma");
    }
}