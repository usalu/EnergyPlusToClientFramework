using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"This object is used to set colors for reporting on various building elements particularly for the DXF reports. We know the user can enter 0 to 255 and the color map is available in DXF output. Therefore, we are limiting the colors in that range. You can extend by editing the IDD but you do so on your own. Colors not changed in any scheme will remain as the default scheme uses.")]
    [JsonObject("OutputControl:SurfaceColorScheme")]
    public class OutputControl_SurfaceColorScheme : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("drawing_element_1_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement1Type DrawingElement1Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement1Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement1Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_1")]
        public System.Nullable<float> ColorForDrawingElement1 { get; set; } = null;
        

        [JsonProperty("drawing_element_2_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement2Type DrawingElement2Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement2Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement2Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_2")]
        public System.Nullable<float> ColorForDrawingElement2 { get; set; } = null;
        

        [JsonProperty("drawing_element_3_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement3Type DrawingElement3Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement3Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement3Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_3")]
        public System.Nullable<float> ColorForDrawingElement3 { get; set; } = null;
        

        [JsonProperty("drawing_element_4_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement4Type DrawingElement4Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement4Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement4Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_4")]
        public System.Nullable<float> ColorForDrawingElement4 { get; set; } = null;
        

        [JsonProperty("drawing_element_5_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement5Type DrawingElement5Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement5Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement5Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_5")]
        public System.Nullable<float> ColorForDrawingElement5 { get; set; } = null;
        

        [JsonProperty("drawing_element_6_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement6Type DrawingElement6Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement6Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement6Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_6")]
        public System.Nullable<float> ColorForDrawingElement6 { get; set; } = null;
        

        [JsonProperty("drawing_element_7_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement7Type DrawingElement7Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement7Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement7Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_7")]
        public System.Nullable<float> ColorForDrawingElement7 { get; set; } = null;
        

        [JsonProperty("drawing_element_8_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement8Type DrawingElement8Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement8Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement8Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_8")]
        public System.Nullable<float> ColorForDrawingElement8 { get; set; } = null;
        

        [JsonProperty("drawing_element_9_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement9Type DrawingElement9Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement9Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement9Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_9")]
        public System.Nullable<float> ColorForDrawingElement9 { get; set; } = null;
        

        [JsonProperty("drawing_element_10_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement10Type DrawingElement10Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement10Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement10Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_10")]
        public System.Nullable<float> ColorForDrawingElement10 { get; set; } = null;
        

        [JsonProperty("drawing_element_11_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement11Type DrawingElement11Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement11Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement11Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_11")]
        public System.Nullable<float> ColorForDrawingElement11 { get; set; } = null;
        

        [JsonProperty("drawing_element_12_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement12Type DrawingElement12Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement12Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement12Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_12")]
        public System.Nullable<float> ColorForDrawingElement12 { get; set; } = null;
        

        [JsonProperty("drawing_element_13_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement13Type DrawingElement13Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement13Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement13Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_13")]
        public System.Nullable<float> ColorForDrawingElement13 { get; set; } = null;
        

        [JsonProperty("drawing_element_14_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement14Type DrawingElement14Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement14Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement14Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_14")]
        public System.Nullable<float> ColorForDrawingElement14 { get; set; } = null;
        

        [JsonProperty("drawing_element_15_type")]
        public OutputControl_SurfaceColorScheme_DrawingElement15Type DrawingElement15Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement15Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement15Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty("color_for_drawing_element_15")]
        public System.Nullable<float> ColorForDrawingElement15 { get; set; } = null;
    }
}