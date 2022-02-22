using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description(@"This boiler model is an adaptation of the empirical model from the Building Loads and System Thermodynamics (BLAST) program. Boiler performance curves are generated by fitting catalog data to third order polynomial equations. A constant efficiency boiler is modeled by setting the fuel use coefficients as follows: N9=1, N10=0, N11=0")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Boiler_Steam : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("fuel_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Boiler_Steam_FuelType FuelType { get; set; } = (Boiler_Steam_FuelType)Enum.Parse(typeof(Boiler_Steam_FuelType), "Coal");
        

        [JsonProperty("maximum_operating_pressure")]
        public System.Nullable<float> MaximumOperatingPressure { get; set; } = (System.Nullable<float>)Single.Parse("160000", CultureInfo.InvariantCulture);
        

        [JsonProperty("theoretical_efficiency")]
        public System.Nullable<float> TheoreticalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty("design_outlet_steam_temperature")]
        public System.Nullable<float> DesignOutletSteamTemperature { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

        [JsonProperty("nominal_capacity")]
        public string NominalCapacity { get; set; } = "";
        

        [JsonProperty("minimum_part_load_ratio")]
        public System.Nullable<float> MinimumPartLoadRatio { get; set; } = null;
        

        [JsonProperty("maximum_part_load_ratio")]
        public System.Nullable<float> MaximumPartLoadRatio { get; set; } = null;
        

        [JsonProperty("optimum_part_load_ratio")]
        public System.Nullable<float> OptimumPartLoadRatio { get; set; } = null;
        

        [JsonProperty("coefficient_1_of_fuel_use_function_of_part_load_ratio_curve")]
        public System.Nullable<float> Coefficient1OfFuelUseFunctionOfPartLoadRatioCurve { get; set; } = null;
        

        [JsonProperty("coefficient_2_of_fuel_use_function_of_part_load_ratio_curve")]
        public System.Nullable<float> Coefficient2OfFuelUseFunctionOfPartLoadRatioCurve { get; set; } = null;
        

        [JsonProperty("coefficient_3_of_fuel_use_function_of_part_load_ratio_curve")]
        public System.Nullable<float> Coefficient3OfFuelUseFunctionOfPartLoadRatioCurve { get; set; } = null;
        

        [JsonProperty("water_inlet_node_name")]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty("steam_outlet_node_name")]
        public string SteamOutletNodeName { get; set; } = "";
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}