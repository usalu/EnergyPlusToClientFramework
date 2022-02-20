using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"default style for the OutputControl:Table:Style is comma -- this works well for importing into spreadsheet programs such as Excel(tm) but not so well for word processing programs -- there tab may be a better choice. fixed puts spaces between the ""columns"". HTML produces tables in HTML. XML produces an XML file. note - if no OutputControl:Table:Style is included, the defaults are comma and None.")]
    [JsonObject("OutputControl:Table:Style")]
    public class OutputControl_Table_Style : BHoMObject
    {
        

        [JsonProperty("column_separator")]
        public EmptyNoYes ColumnSeparator { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Comma");
        

        [JsonProperty("unit_conversion")]
        public EmptyNoYes UnitConversion { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
    }
}