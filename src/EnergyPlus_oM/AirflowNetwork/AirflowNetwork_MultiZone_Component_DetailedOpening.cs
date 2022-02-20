using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object specifies the properties of airflow through windows and doors (window" +
                 ", door and glass door heat transfer subsurfaces) when they are closed or open.")]
    [JsonObject("AirflowNetwork:MultiZone:Component:DetailedOpening")]
    public class AirflowNetwork_MultiZone_Component_DetailedOpening : BHoMObject
    {
        

        [Description("Defined at 1 Pa per meter of crack length. Enter the coefficient used in the foll" +
                     "owing equation: Mass Flow Rate = Air Mass Flow Coefficient * (dP)^Air Mass Flow " +
                     "Exponent. Used only when opening (window or door) is closed.")]
        [JsonProperty("air_mass_flow_coefficient_when_opening_is_closed")]
        public System.Nullable<float> AirMassFlowCoefficientWhenOpeningIsClosed { get; set; } = null;
        

        [Description("Enter the exponent used in the following equation: Mass Flow Rate = Air Mass Flow" +
                     " Coefficient * (dP)^Air Mass Flow Exponent. Used only when opening (window or do" +
                     "or) is closed.")]
        [JsonProperty("air_mass_flow_exponent_when_opening_is_closed")]
        public System.Nullable<float> AirMassFlowExponentWhenOpeningIsClosed { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

        [Description("Select the type of vertical opening: Non-pivoted opening or Horizontally pivoted " +
                     "opening.")]
        [JsonProperty("type_of_rectangular_large_vertical_opening_lvo_")]
        public EmptyNoYes TypeOfRectangularLargeVerticalOpeningLvo { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "NonPivoted");
        

        [Description(@"Extra crack length is used for LVO Non-pivoted type with multiple openable parts. Height of pivoting axis is used for LVO Horizontally pivoted type. Specifies window or door characteristics that depend on the LVO type. For Non-pivoted Type (rectangular windows and doors), this field is the extra crack length in meters due to multiple openable parts, if present. Extra here means in addition to the length of the cracks on the top, bottom and sides of the window/door. For Horizontally pivoted Type, this field gives the height of the pivoting axis measured from the bottom of the glazed part of the window (m).")]
        [JsonProperty("extra_crack_length_or_height_of_pivoting_axis")]
        public System.Nullable<float> ExtraCrackLengthOrHeightOfPivotingAxis { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the number of the following sets of data for opening factor, discharge coef" +
                     "ficient, width factor, height factor, and start height factor.")]
        [JsonProperty("number_of_sets_of_opening_factor_data")]
        public System.Nullable<float> NumberOfSetsOfOpeningFactorData { get; set; } = null;
        

        [Description("This value must be specified as 0.")]
        [JsonProperty("opening_factor_1")]
        public System.Nullable<float> OpeningFactor1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The Discharge Coefficient indicates the fractional effectiveness for air flow thr" +
                     "ough a window or door at that Opening Factor.")]
        [JsonProperty("discharge_coefficient_for_opening_factor_1")]
        public System.Nullable<float> DischargeCoefficientForOpeningFactor1 { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("The Width Factor is the opening width divided by the window or door width.")]
        [JsonProperty("width_factor_for_opening_factor_1")]
        public System.Nullable<float> WidthFactorForOpeningFactor1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The Height Factor is the opening height divided by the window or door height.")]
        [JsonProperty("height_factor_for_opening_factor_1")]
        public System.Nullable<float> HeightFactorForOpeningFactor1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"The Start Height Factor is the Start Height divided by the window or door height. Start Height is the distance between the bottom of the window or door and the bottom of the window or door opening. The sum of the Height Factor and the Start Height Factor must be less than 1.0 in order to have the opening within the window or door dimensions.")]
        [JsonProperty("start_height_factor_for_opening_factor_1")]
        public System.Nullable<float> StartHeightFactorForOpeningFactor1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"If Number of Sets of Opening Factor Data = 2, this value must be 1.0. If Number of Sets of Opening Factor Data = 3, this value must be less than 1.0. If Number of Sets of Opening Factor Data = 4, this value must be less than the value entered for Opening factor 3 and greater than the value entered for Opening factor 1.")]
        [JsonProperty("opening_factor_2")]
        public System.Nullable<float> OpeningFactor2 { get; set; } = null;
        

        [Description("The Discharge Coefficient indicates the fractional effectiveness for air flow thr" +
                     "ough a window or door at that Opening Factor.")]
        [JsonProperty("discharge_coefficient_for_opening_factor_2")]
        public System.Nullable<float> DischargeCoefficientForOpeningFactor2 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The Width Factor is the opening width divided by the window or door width.")]
        [JsonProperty("width_factor_for_opening_factor_2")]
        public System.Nullable<float> WidthFactorForOpeningFactor2 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The Height Factor is the opening height divided by the window or door height.")]
        [JsonProperty("height_factor_for_opening_factor_2")]
        public System.Nullable<float> HeightFactorForOpeningFactor2 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"The Start Height Factor is the Start Height divided by the window or door height. Start Height is the distance between the bottom of the window or door and the bottom of the window or door opening. The sum of the Height Factor and the Start Height Factor must be less than 1.0 in order to have the opening within the window or door dimensions.")]
        [JsonProperty("start_height_factor_for_opening_factor_2")]
        public System.Nullable<float> StartHeightFactorForOpeningFactor2 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("If Number of Sets of Opening Factor Data = 3, this value must be 1.0. If Number o" +
                     "f Sets of Opening Factor Data = 4, this value must be less than 1.0, and greater" +
                     " than value entered for Opening factor 2.")]
        [JsonProperty("opening_factor_3")]
        public System.Nullable<float> OpeningFactor3 { get; set; } = null;
        

        [Description("The Discharge Coefficient indicates the fractional effectiveness for air flow thr" +
                     "ough a window or door at that Opening Factor.")]
        [JsonProperty("discharge_coefficient_for_opening_factor_3")]
        public System.Nullable<float> DischargeCoefficientForOpeningFactor3 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The Width Factor is the opening width divided by the window or door width.")]
        [JsonProperty("width_factor_for_opening_factor_3")]
        public System.Nullable<float> WidthFactorForOpeningFactor3 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The Height Factor is the opening height divided by the window or door height.")]
        [JsonProperty("height_factor_for_opening_factor_3")]
        public System.Nullable<float> HeightFactorForOpeningFactor3 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"The Start Height Factor is the Start Height divided by the window or door height. Start Height is the distance between the bottom of the window or door and the bottom of the window or door opening. The sum of the Height Factor and the Start Height Factor must be less than 1.0 in order to have the opening within the window or door dimensions.")]
        [JsonProperty("start_height_factor_for_opening_factor_3")]
        public System.Nullable<float> StartHeightFactorForOpeningFactor3 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("If Number of Sets of Opening Factor Data = 4, this value must be 1.0")]
        [JsonProperty("opening_factor_4")]
        public System.Nullable<float> OpeningFactor4 { get; set; } = null;
        

        [Description("The Discharge Coefficient indicates the fractional effectiveness for air flow thr" +
                     "ough a window or door at that Opening Factor.")]
        [JsonProperty("discharge_coefficient_for_opening_factor_4")]
        public System.Nullable<float> DischargeCoefficientForOpeningFactor4 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The Width Factor is the opening width divided by the window or door width.")]
        [JsonProperty("width_factor_for_opening_factor_4")]
        public System.Nullable<float> WidthFactorForOpeningFactor4 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The Height Factor is the opening height divided by the window or door height.")]
        [JsonProperty("height_factor_for_opening_factor_4")]
        public System.Nullable<float> HeightFactorForOpeningFactor4 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"The Start Height Factor is the Start Height divided by the window or door height. Start Height is the distance between the bottom of the window or door and the bottom of the window or door opening. The sum of the Height Factor and the Start Height Factor must be less than 1.0 in order to have the opening within the window or door dimensions.")]
        [JsonProperty("start_height_factor_for_opening_factor_4")]
        public System.Nullable<float> StartHeightFactorForOpeningFactor4 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}