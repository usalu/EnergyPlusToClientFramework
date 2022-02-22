using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Describes which window model will be used in calculations. Built in windows model will use algorithms that are part of EnergyPlus, while ExternalWindowsModel will use Windows-CalcEngine library to perform optical and thermal performances of windows and doors.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowsCalculationEngine : BHoMObject
    {
        

        [JsonProperty("windows_engine")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowsCalculationEngine_WindowsEngine WindowsEngine { get; set; } = (WindowsCalculationEngine_WindowsEngine)Enum.Parse(typeof(WindowsCalculationEngine_WindowsEngine), "BuiltInWindowsModel");
    }
}