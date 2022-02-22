namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_AirSupply_AirSupplyRateCalculationMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AirRatiobyStoics")]
        AirRatiobyStoics = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="QuadraticFunctionofElectricPower")]
        QuadraticFunctionofElectricPower = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="QuadraticFunctionofFuelRate")]
        QuadraticFunctionofFuelRate = 2,
    }
}