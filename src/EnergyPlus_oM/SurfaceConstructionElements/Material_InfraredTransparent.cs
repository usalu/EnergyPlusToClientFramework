using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Special infrared transparent material. Similar to a Material:Nomass with low thermal resistance. High absorptance in both wavelengths. Area will be doubled internally to make internal radiant exchange accurate. Should be only material in single layer surface construction. All thermal properties are set internally. User needs only to supply name. Cannot be used with ConductionFiniteDifference solution algorithms")]
    [JsonObject("Material:InfraredTransparent")]
    public class Material_InfraredTransparent : BHoMObject, IEnergyPlusClass
    {
    }
}