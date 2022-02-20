using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("This is only needed when using manual gridding (not recommended) ZFACE: Z Directi" +
                 "on cell face coordinates: m")]
    [JsonObject("GroundHeatTransfer:Basement:ZFACE")]
    public class GroundHeatTransfer_Basement_ZFACE : BHoMObject
    {
    }
}