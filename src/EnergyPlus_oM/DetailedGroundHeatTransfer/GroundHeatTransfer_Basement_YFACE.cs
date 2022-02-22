using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("This is only needed when using manual gridding (not recommended) YFACE: Y Directi" +
                 "on cell face coordinates: m")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Basement_YFACE : BHoMObject
    {
    }
}