using System.ComponentModel;
using BH.oM.Base;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("This is only needed when using manual gridding (not recommended) YFACE: Y Directi" +
                 "on cell face coordinates: m,")]
    public class GroundHeatTransfer_Slab_YFACE : BHoMObject, IEnergyPlusClass
    {
    }
}