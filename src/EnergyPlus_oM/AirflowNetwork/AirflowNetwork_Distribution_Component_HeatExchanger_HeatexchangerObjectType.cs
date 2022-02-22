namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_Distribution_Component_HeatExchanger_HeatexchangerObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchanger:AirToAir:FlatPlate")]
        HeatExchangerAirToAirFlatPlate = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchanger:AirToAir:SensibleAndLatent")]
        HeatExchangerAirToAirSensibleAndLatent = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchanger:Desiccant:BalancedFlow")]
        HeatExchangerDesiccantBalancedFlow = 2,
    }
}