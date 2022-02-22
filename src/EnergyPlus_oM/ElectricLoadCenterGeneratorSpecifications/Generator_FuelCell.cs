using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("This generator model is the FC model from IEA Annex 42")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelCell : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:PowerModule object.")]
        [JsonProperty("power_module_name")]
        public string PowerModuleName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:AirSupply object.")]
        [JsonProperty("air_supply_name")]
        public string AirSupplyName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelSupply object.")]
        [JsonProperty("fuel_supply_name")]
        public string FuelSupplyName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:WaterSupply object.")]
        [JsonProperty("water_supply_name")]
        public string WaterSupplyName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:AuxiliaryHeater object.")]
        [JsonProperty("auxiliary_heater_name")]
        public string AuxiliaryHeaterName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:ExhaustGasToWaterHeatExchanger object.")]
        [JsonProperty("heat_exchanger_name")]
        public string HeatExchangerName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:ElectricalStorage object.")]
        [JsonProperty("electrical_storage_name")]
        public string ElectricalStorageName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:Inverter object.")]
        [JsonProperty("inverter_name")]
        public string InverterName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:StackCooler object. optional, used for PEM" +
                     "FC")]
        [JsonProperty("stack_cooler_name")]
        public string StackCoolerName { get; set; } = "";
    }
}