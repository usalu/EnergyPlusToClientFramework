using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("This is only needed when using manual gridding (not recommended) XFACE: X Directi" +
                 "on cell face coordinates: m")]
    [JsonObject("GroundHeatTransfer:Slab:XFACE")]
    public class GroundHeatTransfer_Slab_XFACE : BHoMObject, IEnergyPlusClass
    {
    }
}