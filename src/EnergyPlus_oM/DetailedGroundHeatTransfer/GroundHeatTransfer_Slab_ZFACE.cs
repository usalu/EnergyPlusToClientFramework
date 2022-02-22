using System.ComponentModel;
using BH.oM.Base;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("This is only needed when using manual gridding (not recommended) ZFACE: Z Directi" +
                 "on cell face coordinates: m")]
    public class GroundHeatTransfer_Slab_ZFACE : BHoMObject, IEnergyPlusClass
    {
    }
}