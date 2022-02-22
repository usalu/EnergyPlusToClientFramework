using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the name of a coil used in an air loop.")]
    [JsonObject("AirflowNetwork:Distribution:Component:Coil")]
    public class AirflowNetwork_Distribution_Component_Coil : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the name of a cooling or heating coil in the primary Air loop.")]
        [JsonProperty("coil_name")]
        public string CoilName { get; set; } = "";
        

        [Description("Select the type of coil corresponding to the name entered in the field above.")]
        [JsonProperty("coil_object_type")]
        public AirflowNetwork_Distribution_Component_Coil_CoilObjectType CoilObjectType { get; set; } = (AirflowNetwork_Distribution_Component_Coil_CoilObjectType)Enum.Parse(typeof(AirflowNetwork_Distribution_Component_Coil_CoilObjectType), "CoilCoolingDX");
        

        [Description("Enter the air path length (depth) for the coil.")]
        [JsonProperty("air_path_length")]
        public System.Nullable<float> AirPathLength { get; set; } = null;
        

        [Description("Enter the hydraulic diameter of this coil. The hydraulic diameter is defined as 4" +
                     " multiplied by the cross section area divided by perimeter.")]
        [JsonProperty("air_path_hydraulic_diameter")]
        public System.Nullable<float> AirPathHydraulicDiameter { get; set; } = null;
    }
}