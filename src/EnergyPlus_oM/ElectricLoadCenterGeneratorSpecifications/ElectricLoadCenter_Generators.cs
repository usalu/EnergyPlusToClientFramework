using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("List of electric power generators to include in the simulation including the name" +
                 " and type of each generators along with availability schedule, rated power outpu" +
                 "t, and thermal-to-electrical power ratio.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricLoadCenter_Generators : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("generator_outputs")]
        public string GeneratorOutputs { get; set; } = "";
    }
}