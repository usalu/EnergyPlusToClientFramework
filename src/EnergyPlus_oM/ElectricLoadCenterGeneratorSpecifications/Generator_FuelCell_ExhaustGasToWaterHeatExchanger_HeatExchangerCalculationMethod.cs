namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_ExhaustGasToWaterHeatExchanger_HeatExchangerCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Condensing")]
        Condensing = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="EmpiricalUAeff")]
        EmpiricalUAeff = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedEffectiveness")]
        FixedEffectiveness = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FundementalUAeff")]
        FundementalUAeff = 3,
    }
}