namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum CoilSystem_Cooling_DX_HeatExchangerAssisted_HeatExchangerObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchanger:AirToAir:FlatPlate")]
        HeatExchangerAirToAirFlatPlate = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchanger:AirToAir:SensibleAndLatent")]
        HeatExchangerAirToAirSensibleAndLatent = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchanger:Desiccant:BalancedFlow")]
        HeatExchangerDesiccantBalancedFlow = 2,
    }
}