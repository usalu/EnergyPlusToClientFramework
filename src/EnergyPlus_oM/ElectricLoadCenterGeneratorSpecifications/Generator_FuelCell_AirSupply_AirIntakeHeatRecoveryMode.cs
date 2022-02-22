namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_AirSupply_AirIntakeHeatRecoveryMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="NoRecovery")]
        NoRecovery = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="RecoverAuxiliaryBurner")]
        RecoverAuxiliaryBurner = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="RecoverBurnerInverterStorage")]
        RecoverBurnerInverterStorage = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="RecoverElectricalStorage")]
        RecoverElectricalStorage = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="RecoverInverter")]
        RecoverInverter = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="RecoverInverterandStorage")]
        RecoverInverterandStorage = 5,
    }
}