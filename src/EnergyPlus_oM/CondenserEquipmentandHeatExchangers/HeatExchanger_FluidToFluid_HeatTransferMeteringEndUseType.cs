namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum HeatExchanger_FluidToFluid_HeatTransferMeteringEndUseType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FreeCooling")]
        FreeCooling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatRecovery")]
        HeatRecovery = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatRecoveryForCooling")]
        HeatRecoveryForCooling = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatRecoveryForHeating")]
        HeatRecoveryForHeating = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatRejection")]
        HeatRejection = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="LoopToLoop")]
        LoopToLoop = 6,
    }
}