using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("This model is for converting AC to DC for grid-supplied charging of DC storage")]
    [JsonObject("ElectricLoadCenter:Storage:Converter")]
    public class ElectricLoadCenter_Storage_Converter : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the converter is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("SimpleFixed indicates power conversion losses are based on Simple Fixed Efficienc" +
                     "y FunctionOfPower indicates power conversion losses are a function of normalized" +
                     " power using a curve or table.")]
        [JsonProperty("power_conversion_efficiency_method")]
        public ElectricLoadCenter_Storage_Converter_PowerConversionEfficiencyMethod PowerConversionEfficiencyMethod { get; set; } = (ElectricLoadCenter_Storage_Converter_PowerConversionEfficiencyMethod)Enum.Parse(typeof(ElectricLoadCenter_Storage_Converter_PowerConversionEfficiencyMethod), "SimpleFixed");
        

        [Description("Constant efficiency for conversion of AC to DC at all power levels. Field is only" +
                     " used when Power Conversion Efficiency Method is set to SimpleFixed.")]
        [JsonProperty("simple_fixed_efficiency")]
        public System.Nullable<float> SimpleFixedEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.95", CultureInfo.InvariantCulture);
        

        [Description("Required field when Power Conversion Efficiency Method is set to FunctionOfPower." +
                     "")]
        [JsonProperty("design_maximum_continuous_input_power")]
        public System.Nullable<float> DesignMaximumContinuousInputPower { get; set; } = null;
        

        [Description(@"Curve or table with a single independent variable that describes efficiency as a function of normalized power. The ""x"" input for curve or table is the ratio of current input power divided by design power in the previous field Required field when Power Conversion Efficiency Method is set to FunctionOfPower.")]
        [JsonProperty("efficiency_function_of_power_curve_name")]
        public string EfficiencyFunctionOfPowerCurveName { get; set; } = "";
        

        [Description("Optional standby power consumed when converter is available but no power is being" +
                     " conditioned.")]
        [JsonProperty("ancillary_power_consumed_in_standby")]
        public System.Nullable<float> AncillaryPowerConsumedInStandby { get; set; } = null;
        

        [Description("enter name of zone to receive converter losses as heat if blank then converter is" +
                     " assumed to be outdoors")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("fraction of zone heat gains treated as thermal radiation")]
        [JsonProperty("radiative_fraction")]
        public System.Nullable<float> RadiativeFraction { get; set; } = null;
    }
}