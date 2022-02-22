using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Pumps
{
    [Description("This pump model is described in the ASHRAE secondary HVAC toolkit. Variable Speed" +
                 " Condensate pump for Steam Systems")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Pump_VariableSpeed_Condensate : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [Description("this is the volume of steam before condensation, the volume of condensate is much" +
                     " lower and calculated from steam density")]
        [JsonProperty("design_steam_volume_flow_rate")]
        public string DesignSteamVolumeFlowRate { get; set; } = "";
        

        [Description("default head is 60 feet")]
        [JsonProperty("design_pump_head")]
        public System.Nullable<float> DesignPumpHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

        [Description("When autosized the type of scaling factor is chosen in the input field Design Pow" +
                     "er Sizing Method")]
        [JsonProperty("design_power_consumption")]
        public string DesignPowerConsumption { get; set; } = "";
        

        [Description("This is the motor efficiency only. When the Design Power Consumption is autosized" +
                     " using PowerPerFlowPerPressure, the Design Shaft Power per Unit Flow Rate per Un" +
                     "it Head is used in addition to the motor efficiency.")]
        [JsonProperty("motor_efficiency")]
        public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("fraction_of_motor_inefficiencies_to_fluid_stream")]
        public System.Nullable<float> FractionOfMotorInefficienciesToFluidStream { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("coefficient_1_of_the_part_load_performance_curve")]
        public System.Nullable<float> Coefficient1OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("coefficient_2_of_the_part_load_performance_curve")]
        public System.Nullable<float> Coefficient2OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("coefficient_3_of_the_part_load_performance_curve")]
        public System.Nullable<float> Coefficient3OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("coefficient_4_of_the_part_load_performance_curve")]
        public System.Nullable<float> Coefficient4OfThePartLoadPerformanceCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Modifies the rated flow rate of the pump on a time basis. Default is that the pum" +
                     "p is on and runs according to its other operational requirements specified above" +
                     ". The schedule is for special pump operations.")]
        [JsonProperty("pump_flow_rate_schedule_name")]
        public string PumpFlowRateScheduleName { get; set; } = "";
        

        [Description("optional, if used pump losses transfered to zone as internal gains")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("optional. If zone identified in previous field then this determines the split bet" +
                     "ween convection and radiation for the skin losses")]
        [JsonProperty("skin_loss_radiative_fraction")]
        public System.Nullable<float> SkinLossRadiativeFraction { get; set; } = null;
        

        [Description(@"Used to indicate which sizing factor is used to calculate Design Power Consumption. PowerPerFlow indicates that Design Electric Power per Unit Flow Rate is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * scaling factor PowerPerFlowPerPressure indicates that Design Shaft Power per Unit Flow Rate per Unit Head is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * Design Pump Head * scaling factor / Motor Efficiency")]
        [JsonProperty("design_power_sizing_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Pump_VariableSpeed_Condensate_DesignPowerSizingMethod DesignPowerSizingMethod { get; set; } = (Pump_VariableSpeed_Condensate_DesignPowerSizingMethod)Enum.Parse(typeof(Pump_VariableSpeed_Condensate_DesignPowerSizingMethod), "PowerPerFlowPerPressure");
        

        [Description("Used to size Design Power Consumption from design flow rate")]
        [JsonProperty("design_electric_power_per_unit_flow_rate")]
        public System.Nullable<float> DesignElectricPowerPerUnitFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("348701.1", CultureInfo.InvariantCulture);
        

        [Description("Used to size Design Power Consumption from design flow rate for head and motor ef" +
                     "ficiency")]
        [JsonProperty("design_shaft_power_per_unit_flow_rate_per_unit_head")]
        public System.Nullable<float> DesignShaftPowerPerUnitFlowRatePerUnitHead { get; set; } = (System.Nullable<float>)Single.Parse("1.282051282", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}