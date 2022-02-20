using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Used to describe the power condition unit subsystem of a fuel cell power generato" +
                 "r. This object models an inverter system contained within a fuel cell system tha" +
                 "t converts from direct current (DC) to alternating current (AC).")]
    [JsonObject("Generator:FuelCell:Inverter")]
    public class Generator_FuelCell_Inverter : BHoMObject
    {
        

        [JsonProperty("inverter_efficiency_calculation_mode")]
        public EmptyNoYes InverterEfficiencyCalculationMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("inverter_efficiency")]
        public System.Nullable<float> InverterEfficiency { get; set; } = null;
        

        [JsonProperty("efficiency_function_of_dc_power_curve_name")]
        public string EfficiencyFunctionOfDcPowerCurveName { get; set; } = "";
    }
}