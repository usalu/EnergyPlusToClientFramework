using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("This object adds a chiller to an HVACTemplate:Plant:ChilledWaterLoop.")]
    public class HVACTemplate_Plant_Chiller : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("chiller_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Chiller_ChillerType ChillerType { get; set; } = (HVACTemplate_Plant_Chiller_ChillerType)Enum.Parse(typeof(HVACTemplate_Plant_Chiller_ChillerType), "DistrictChilledWater");
        

        [JsonProperty("capacity")]
        public string Capacity { get; set; } = (System.String)"Autosize";
        

        [Description("Not applicable if Chiller Type is DistrictChilledWater Electric Reciprocating Chi" +
                     "ller")]
        [JsonProperty("nominal_cop")]
        public System.Nullable<float> NominalCop { get; set; } = null;
        

        [Description("Not applicable if Chiller Type is DistrictChilledWater")]
        [JsonProperty("condenser_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Chiller_CondenserType CondenserType { get; set; } = (HVACTemplate_Plant_Chiller_CondenserType)Enum.Parse(typeof(HVACTemplate_Plant_Chiller_CondenserType), "WaterCooled");
        

        [Description("If Chiller Plant Operation Scheme Type=Default in HVACTemplate:Plant:ChilledWater" +
                     "Loop, then equipment operates in Priority order, 1, 2, 3, etc.")]
        [JsonProperty("priority")]
        public string Priority { get; set; } = "";
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Part load ratio below which the chiller starts cycling on/off to meet the load. M" +
                     "ust be less than or equal to Maximum Part Load Ratio.")]
        [JsonProperty("minimum_part_load_ratio")]
        public System.Nullable<float> MinimumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Maximum allowable part load ratio. Must be greater than or equal to Minimum Part " +
                     "Load Ratio.")]
        [JsonProperty("maximum_part_load_ratio")]
        public System.Nullable<float> MaximumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Optimum part load ratio where the chiller is most efficient. Must be greater than" +
                     " or equal to the Minimum Part Load Ratio and less than or equal to the Maximum P" +
                     "art Load Ratio.")]
        [JsonProperty("optimum_part_load_ratio")]
        public System.Nullable<float> OptimumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Part load ratio where the chiller can no longer unload and false loading begins. " +
                     "Minimum unloading ratio must be greater than or equal to the Minimum Part Load R" +
                     "atio and less than or equal to the Maximum Part Load Ratio.")]
        [JsonProperty("minimum_unloading_ratio")]
        public System.Nullable<float> MinimumUnloadingRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

        [JsonProperty("leaving_chilled_water_lower_temperature_limit")]
        public System.Nullable<float> LeavingChilledWaterLowerTemperatureLimit { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
    }
}