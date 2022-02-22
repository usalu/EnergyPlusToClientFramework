using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Sets internal gains for lights in the zone. If you use a ZoneList in the Zone or " +
                 "ZoneList name field then this definition applies to all the zones in the ZoneLis" +
                 "t.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Lights : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("zone_or_zonelist_name")]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [Description("units in schedule should be fraction applied to design level of lights, generally" +
                     " (0.0 - 1.0)")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [Description(@"The entered calculation method is used to create the maximum amount of lights for this set of attributes Choices: LightingLevel => Lighting Level -- simply enter watts of lights Watts/Area => Watts per Zone Floor Area -- enter the number to apply. Value * Floor Area = Lights Watts/Person => Watts per Person -- enter the number to apply. Value * Occupants = Lights")]
        [JsonProperty("design_level_calculation_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Lights_DesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = (Lights_DesignLevelCalculationMethod)Enum.Parse(typeof(Lights_DesignLevelCalculationMethod), "LightingLevel");
        

        [JsonProperty("lighting_level")]
        public System.Nullable<float> LightingLevel { get; set; } = null;
        

        [JsonProperty("watts_per_zone_floor_area")]
        public System.Nullable<float> WattsPerZoneFloorArea { get; set; } = null;
        

        [JsonProperty("watts_per_person")]
        public System.Nullable<float> WattsPerPerson { get; set; } = null;
        

        [Description("Used only for sizing calculation if return-air-fraction coefficients are specifie" +
                     "d.")]
        [JsonProperty("return_air_fraction")]
        public System.Nullable<float> ReturnAirFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("fraction_radiant")]
        public System.Nullable<float> FractionRadiant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("fraction_visible")]
        public System.Nullable<float> FractionVisible { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("For Daylighting:Controls must be 0 or 1:  0 = no dimming control, 1 = full dimmin" +
                     "g control")]
        [JsonProperty("fraction_replaceable")]
        public System.Nullable<float> FractionReplaceable { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
        

        [JsonProperty("return_air_fraction_calculated_from_plenum_temperature")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ReturnAirFractionCalculatedFromPlenumTemperature { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Used only if Return Air Fraction Is Calculated from Plenum Temperature = Yes Equa" +
                     "tion is Return Air Fraction = Coefficient#1 - Coefficient#2 X PlenumTemp(degC)")]
        [JsonProperty("return_air_fraction_function_of_plenum_temperature_coefficient_1")]
        public System.Nullable<float> ReturnAirFractionFunctionOfPlenumTemperatureCoefficient1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only if Return Air Fraction Is Calculated from Plenum Temperature = Yes Equa" +
                     "tion is Return Air Fraction = Coefficient#1 - Coefficient#2 X PlenumTemp(degC)")]
        [JsonProperty("return_air_fraction_function_of_plenum_temperature_coefficient_2")]
        public System.Nullable<float> ReturnAirFractionFunctionOfPlenumTemperatureCoefficient2 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Name of the return air node for this heat gain. If left blank, defaults to the fi" +
                     "rst return air node for the zone. Leave this field blank when using a ZoneList n" +
                     "ame.")]
        [JsonProperty("return_air_heat_gain_node_name")]
        public string ReturnAirHeatGainNodeName { get; set; } = "";
    }
}