using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description(@"Object provides information about the building and its operating conditions Monthly Average Temperature SetPoint fields specify the average indoor building set point temperatures for each month of the year. These fields are useful for simulating a building that is not temperature controlled for some of the year. In such a case, the average indoor set point temperatures can be obtained by first running the model in EnergyPlus with an insulated floor boundary condition, and then using the resulting monthly average zone temperatures in these fields.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Slab_BldgProps : BHoMObject
    {
        

        [Description(@"This field specifies the number of years to iterate. Either the ground heat transfer calculations come to an an annual steady periodic condition by converging to a tolerance (see ConvTol field) or it runs for this number of years. A ten year maximum is usually sufficient.")]
        [JsonProperty("iyrs_number_of_years_to_iterate")]
        public System.Nullable<float> IyrsNumberOfYearsToIterate { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Use only the value 0 here. Only a rectangular shape is implemented.")]
        [JsonProperty("shape_slab_shape")]
        public System.Nullable<float> ShapeSlabShape { get; set; } = null;
        

        [Description("This field supplies the building height. This is used to calculate the building s" +
                     "hadowing on the ground. typical value= 0-20")]
        [JsonProperty("hbldg_building_height")]
        public System.Nullable<float> HbldgBuildingHeight { get; set; } = null;
        

        [Description("see memo on object for more information")]
        [JsonProperty("tin1_january_indoor_average_temperature_setpoint")]
        public System.Nullable<float> Tin1JanuaryIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty("tin2_february_indoor_average_temperature_setpoint")]
        public System.Nullable<float> Tin2FebruaryIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty("tin3_march_indoor_average_temperature_setpoint")]
        public System.Nullable<float> Tin3MarchIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty("tin4_april_indoor_average_temperature_setpoint")]
        public System.Nullable<float> Tin4AprilIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty("tin5_may_indoor_average_temperature_setpoint")]
        public System.Nullable<float> Tin5MayIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty("tin6_june_indoor_average_temperature_setpoint")]
        public System.Nullable<float> Tin6JuneIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty("tin7_july_indoor_average_temperature_setpoint")]
        public System.Nullable<float> Tin7JulyIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty("tin8_august_indoor_average_temperature_setpoint")]
        public System.Nullable<float> Tin8AugustIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty("tin9_september_indoor_average_temperature_setpoint")]
        public System.Nullable<float> Tin9SeptemberIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty("tin10_october_indoor_average_temperature_setpoint")]
        public System.Nullable<float> Tin10OctoberIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty("tin11_november_indoor_average_temperature_setpoint")]
        public System.Nullable<float> Tin11NovemberIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty("tin12_december_indoor_average_temperature_setpoint")]
        public System.Nullable<float> Tin12DecemberIndoorAverageTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("This field permits imposing a daily sinusoidal variation in the indoor setpoint t" +
                     "emperature to simulate the effect of a setback profile. The value specified is t" +
                     "he amplitude of the sine wave.")]
        [JsonProperty("tinamp_daily_indoor_sine_wave_variation_amplitude")]
        public System.Nullable<float> TinampDailyIndoorSineWaveVariationAmplitude { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field specifies the convergence tolerance used to control the iteration. Whe" +
                     "n the temperature change of all nodes is less than the convergence value, iterat" +
                     "ion ceases.")]
        [JsonProperty("convtol_convergence_tolerance")]
        public System.Nullable<float> ConvtolConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
    }
}