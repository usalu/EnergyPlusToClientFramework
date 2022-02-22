using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Used to enter data describing deflection state of the gap. It is referenced from " +
                 "WindowMaterial:Gap object only and it is used only when deflection model is set " +
                 "to MeasuredDeflection, otherwise it is ignored.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowGap_DeflectionState : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("If left blank will be considered that gap has no deflection.")]
        [JsonProperty("deflected_thickness")]
        public System.Nullable<float> DeflectedThickness { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("initial_temperature")]
        public System.Nullable<float> InitialTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25", CultureInfo.InvariantCulture);
        

        [JsonProperty("initial_pressure")]
        public System.Nullable<float> InitialPressure { get; set; } = (System.Nullable<float>)Single.Parse("101325", CultureInfo.InvariantCulture);
    }
}