using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PythonPluginSystem
{
    public enum PythonPlugin_OutputVariable_EndUseCategory
    {
        
        [JsonProperty("Baseboard")]
        Baseboard = 0,
        
        [JsonProperty("Boilers")]
        Boilers = 1,
        
        [JsonProperty("Chillers")]
        Chillers = 2,
        
        [JsonProperty("Cooling")]
        Cooling = 3,
        
        [JsonProperty("CoolingCoils")]
        CoolingCoils = 4,
        
        [JsonProperty("ExteriorEquipment")]
        ExteriorEquipment = 5,
        
        [JsonProperty("ExteriorLights")]
        ExteriorLights = 6,
        
        [JsonProperty("Fans")]
        Fans = 7,
        
        [JsonProperty("HeatRecovery")]
        HeatRecovery = 8,
        
        [JsonProperty("HeatRecoveryForCooling")]
        HeatRecoveryForCooling = 9,
        
        [JsonProperty("HeatRecoveryForHeating")]
        HeatRecoveryForHeating = 10,
        
        [JsonProperty("HeatRejection")]
        HeatRejection = 11,
        
        [JsonProperty("Heating")]
        Heating = 12,
        
        [JsonProperty("HeatingCoils")]
        HeatingCoils = 13,
        
        [JsonProperty("Humidifier")]
        Humidifier = 14,
        
        [JsonProperty("InteriorEquipment")]
        InteriorEquipment = 15,
        
        [JsonProperty("InteriorLights")]
        InteriorLights = 16,
        
        [JsonProperty("OnSiteGeneration")]
        OnSiteGeneration = 17,
        
        [JsonProperty("Pumps")]
        Pumps = 18,
        
        [JsonProperty("Refrigeration")]
        Refrigeration = 19,
        
        [JsonProperty("WaterSystems")]
        WaterSystems = 20,
    }
}