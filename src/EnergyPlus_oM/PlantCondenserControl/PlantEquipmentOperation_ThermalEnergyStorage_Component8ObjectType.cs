using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    public enum PlantEquipmentOperation_ThermalEnergyStorage_Component8ObjectType
    {
        
        [JsonProperty("Chiller:Absorption")]
        ChillerAbsorption = 0,
        
        [JsonProperty("Chiller:Absorption:Indirect")]
        ChillerAbsorptionIndirect = 1,
        
        [JsonProperty("Chiller:CombustionTurbine")]
        ChillerCombustionTurbine = 2,
        
        [JsonProperty("Chiller:ConstantCOP")]
        ChillerConstantCOP = 3,
        
        [JsonProperty("Chiller:Electric")]
        ChillerElectric = 4,
        
        [JsonProperty("Chiller:Electric:EIR")]
        ChillerElectricEIR = 5,
        
        [JsonProperty("Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 6,
        
        [JsonProperty("Chiller:EngineDriven")]
        ChillerEngineDriven = 7,
        
        [JsonProperty("ThermalStorage:Ice:Detailed")]
        ThermalStorageIceDetailed = 8,
        
        [JsonProperty("ThermalStorage:Ice:Simple")]
        ThermalStorageIceSimple = 9,
    }
}