namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_TemperatureSensorOffset_ChillerSupplyWater_ChillerObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric")]
        ChillerElectric = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
    }
}