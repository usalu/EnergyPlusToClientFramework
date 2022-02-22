using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description(@"This input object is similar to EnergyManagementSystem:GlobalVariable. However, at the beginning of each zone time step, its value is set to the value received from the external interface. During the warm-up period and the system sizing, its value is set to the value specified by the field ""initial value."" This object can be used to move data into Erl subroutines.")]
    public class ExternalInterface_Variable : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Used during warm-up and system sizing.")]
        [JsonProperty("initial_value")]
        public System.Nullable<float> InitialValue { get; set; } = null;
    }
}