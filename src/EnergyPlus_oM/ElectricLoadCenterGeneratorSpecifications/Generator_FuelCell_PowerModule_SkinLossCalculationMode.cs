namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_PowerModule_SkinLossCalculationMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ConstantRate")]
        ConstantRate = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="QuadraticFunctionOfFuelRate")]
        QuadraticFunctionOfFuelRate = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="UAForProcessGasTemperature")]
        UAForProcessGasTemperature = 2,
    }
}