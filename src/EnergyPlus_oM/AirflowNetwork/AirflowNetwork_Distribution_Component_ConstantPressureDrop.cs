using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description(@"This object defines the characteristics of a constant pressure drop component (e.g. filter). Each node connected to this object can not be a node of mixer, splitter, a node of air primary loop, or zone equipment loop. It is recommended to connect to a duct component at both ends.")]
    [JsonObject("AirflowNetwork:Distribution:Component:ConstantPressureDrop")]
    public class AirflowNetwork_Distribution_Component_ConstantPressureDrop : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the pressure drop across this component.")]
        [JsonProperty("pressure_difference_across_the_component")]
        public System.Nullable<float> PressureDifferenceAcrossTheComponent { get; set; } = null;
    }
}