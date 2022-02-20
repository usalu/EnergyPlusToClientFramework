using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_FuelCell_AirSupply_AirIntakeHeatRecoveryMode
    {
        
        [JsonProperty("NoRecovery")]
        NoRecovery = 0,
        
        [JsonProperty("RecoverAuxiliaryBurner")]
        RecoverAuxiliaryBurner = 1,
        
        [JsonProperty("RecoverBurnerInverterStorage")]
        RecoverBurnerInverterStorage = 2,
        
        [JsonProperty("RecoverElectricalStorage")]
        RecoverElectricalStorage = 3,
        
        [JsonProperty("RecoverInverter")]
        RecoverInverter = 4,
        
        [JsonProperty("RecoverInverterandStorage")]
        RecoverInverterandStorage = 5,
    }
}