using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Pumps
{
    [Description("This pump model is described in the ASHRAE secondary HVAC toolkit.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Pump_ConstantSpeed : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty("design_flow_rate")]
        public string DesignFlowRate { get; set; } = "";
        

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
        

        [JsonProperty("pump_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Pump_ConstantSpeed_PumpControlType PumpControlType { get; set; } = (Pump_ConstantSpeed_PumpControlType)Enum.Parse(typeof(Pump_ConstantSpeed_PumpControlType), "Continuous");
        

        [Description("Modifies the rated flow rate of the pump on a time basis. Default is that the pum" +
                     "p is on and runs according to its other operational requirements specified above" +
                     ". The schedule is for special pump operations.")]
        [JsonProperty("pump_flow_rate_schedule_name")]
        public string PumpFlowRateScheduleName { get; set; } = "";
        

        [Description(@"This references any single independent variable polynomial curve in order to do pressure vs. flow calculations for this pump. The available types are then: Linear, Quadratic, Cubic, and Quartic The non-dimensional pump pressure relationship is of the following form: (psi = C4*phi^4 + C3*phi^3 + C2*phi^2 + C1*phi + C0) Where the non-dimensional variables are defined as: delP = rho * ((N/60)^2) * (D^2) * psi mdot = rho * (N/60) * (D^3) * phi")]
        [JsonProperty("pump_curve_name")]
        public string PumpCurveName { get; set; } = "";
        

        [Description("\"D\" in above expression in field A6")]
        [JsonProperty("impeller_diameter")]
        public System.Nullable<float> ImpellerDiameter { get; set; } = null;
        

        [Description("\"N\" in above expression in field A6")]
        [JsonProperty("rotational_speed")]
        public System.Nullable<float> RotationalSpeed { get; set; } = null;
        

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
        public Pump_ConstantSpeed_DesignPowerSizingMethod DesignPowerSizingMethod { get; set; } = (Pump_ConstantSpeed_DesignPowerSizingMethod)Enum.Parse(typeof(Pump_ConstantSpeed_DesignPowerSizingMethod), "PowerPerFlowPerPressure");
        

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