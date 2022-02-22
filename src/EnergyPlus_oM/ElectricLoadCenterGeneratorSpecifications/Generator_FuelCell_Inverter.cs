using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Used to describe the power condition unit subsystem of a fuel cell power generato" +
                 "r. This object models an inverter system contained within a fuel cell system tha" +
                 "t converts from direct current (DC) to alternating current (AC).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelCell_Inverter : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("inverter_efficiency_calculation_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_Inverter_InverterEfficiencyCalculationMode InverterEfficiencyCalculationMode { get; set; } = (Generator_FuelCell_Inverter_InverterEfficiencyCalculationMode)Enum.Parse(typeof(Generator_FuelCell_Inverter_InverterEfficiencyCalculationMode), "Constant");
        

        [JsonProperty("inverter_efficiency")]
        public System.Nullable<float> InverterEfficiency { get; set; } = null;
        

        [JsonProperty("efficiency_function_of_dc_power_curve_name")]
        public string EfficiencyFunctionOfDcPowerCurveName { get; set; } = "";
    }
}