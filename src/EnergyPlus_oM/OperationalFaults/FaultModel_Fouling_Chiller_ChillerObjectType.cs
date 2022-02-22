namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_Fouling_Chiller_ChillerObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:ConstantCOP")]
        ChillerConstantCOP = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric")]
        ChillerElectric = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:EIR")]
        ChillerElectricEIR = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:EngineDriven")]
        ChillerEngineDriven = 5,
    }
}