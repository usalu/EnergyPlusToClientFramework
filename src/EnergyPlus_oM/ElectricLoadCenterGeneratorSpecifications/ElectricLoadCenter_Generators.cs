using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("List of electric power generators to include in the simulation including the name" +
                 " and type of each generators along with availability schedule, rated power outpu" +
                 "t, and thermal-to-electrical power ratio.")]
    public class ElectricLoadCenter_Generators : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("generator_outputs")]
        public string GeneratorOutputs { get; set; } = "";
    }
}