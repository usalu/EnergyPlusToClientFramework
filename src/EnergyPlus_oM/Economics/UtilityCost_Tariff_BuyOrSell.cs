namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum UtilityCost_Tariff_BuyOrSell
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BuyFromUtility")]
        BuyFromUtility = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="NetMetering")]
        NetMetering = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SellToUtility")]
        SellToUtility = 3,
    }
}