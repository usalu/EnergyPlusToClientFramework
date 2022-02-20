using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"This object is used to set colors for reporting on various building elements particularly for the DXF reports. We know the user can enter 0 to 255 and the color map is available in DXF output. Therefore, we are limiting the colors in that range. You can extend by editing the IDD but you do so on your own. Colors not changed in any scheme will remain as the default scheme uses.")]
    [JsonObject("OutputControl:SurfaceColorScheme")]
    public class OutputControl_SurfaceColorScheme : BHoMObject
    {
        

        [JsonProperty("drawing_element_1_type")]
        public EmptyNoYes DrawingElement1Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_1")]
        public System.Nullable<float> ColorForDrawingElement1 { get; set; } = null;
        

        [JsonProperty("drawing_element_2_type")]
        public EmptyNoYes DrawingElement2Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_2")]
        public System.Nullable<float> ColorForDrawingElement2 { get; set; } = null;
        

        [JsonProperty("drawing_element_3_type")]
        public EmptyNoYes DrawingElement3Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_3")]
        public System.Nullable<float> ColorForDrawingElement3 { get; set; } = null;
        

        [JsonProperty("drawing_element_4_type")]
        public EmptyNoYes DrawingElement4Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_4")]
        public System.Nullable<float> ColorForDrawingElement4 { get; set; } = null;
        

        [JsonProperty("drawing_element_5_type")]
        public EmptyNoYes DrawingElement5Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_5")]
        public System.Nullable<float> ColorForDrawingElement5 { get; set; } = null;
        

        [JsonProperty("drawing_element_6_type")]
        public EmptyNoYes DrawingElement6Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_6")]
        public System.Nullable<float> ColorForDrawingElement6 { get; set; } = null;
        

        [JsonProperty("drawing_element_7_type")]
        public EmptyNoYes DrawingElement7Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_7")]
        public System.Nullable<float> ColorForDrawingElement7 { get; set; } = null;
        

        [JsonProperty("drawing_element_8_type")]
        public EmptyNoYes DrawingElement8Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_8")]
        public System.Nullable<float> ColorForDrawingElement8 { get; set; } = null;
        

        [JsonProperty("drawing_element_9_type")]
        public EmptyNoYes DrawingElement9Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_9")]
        public System.Nullable<float> ColorForDrawingElement9 { get; set; } = null;
        

        [JsonProperty("drawing_element_10_type")]
        public EmptyNoYes DrawingElement10Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_10")]
        public System.Nullable<float> ColorForDrawingElement10 { get; set; } = null;
        

        [JsonProperty("drawing_element_11_type")]
        public EmptyNoYes DrawingElement11Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_11")]
        public System.Nullable<float> ColorForDrawingElement11 { get; set; } = null;
        

        [JsonProperty("drawing_element_12_type")]
        public EmptyNoYes DrawingElement12Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_12")]
        public System.Nullable<float> ColorForDrawingElement12 { get; set; } = null;
        

        [JsonProperty("drawing_element_13_type")]
        public EmptyNoYes DrawingElement13Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_13")]
        public System.Nullable<float> ColorForDrawingElement13 { get; set; } = null;
        

        [JsonProperty("drawing_element_14_type")]
        public EmptyNoYes DrawingElement14Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_14")]
        public System.Nullable<float> ColorForDrawingElement14 { get; set; } = null;
        

        [JsonProperty("drawing_element_15_type")]
        public EmptyNoYes DrawingElement15Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_15")]
        public System.Nullable<float> ColorForDrawingElement15 { get; set; } = null;
    }
}