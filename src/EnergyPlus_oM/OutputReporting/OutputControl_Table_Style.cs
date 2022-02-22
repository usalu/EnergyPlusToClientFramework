using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"default style for the OutputControl:Table:Style is comma -- this works well for importing into spreadsheet programs such as Excel(tm) but not so well for word processing programs -- there tab may be a better choice. fixed puts spaces between the ""columns"". HTML produces tables in HTML. XML produces an XML file. note - if no OutputControl:Table:Style is included, the defaults are comma and None.")]
    public class OutputControl_Table_Style : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("column_separator")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_Table_Style_ColumnSeparator ColumnSeparator { get; set; } = (OutputControl_Table_Style_ColumnSeparator)Enum.Parse(typeof(OutputControl_Table_Style_ColumnSeparator), "Comma");
        

        [JsonProperty("unit_conversion")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_Table_Style_UnitConversion UnitConversion { get; set; } = (OutputControl_Table_Style_UnitConversion)Enum.Parse(typeof(OutputControl_Table_Style_UnitConversion), "None");
    }
}