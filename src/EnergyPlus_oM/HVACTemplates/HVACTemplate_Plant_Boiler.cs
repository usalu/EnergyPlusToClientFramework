using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("This object adds a boiler to an HVACTemplate:Plant:HotWaterLoop or MixedWaterLoop" +
                 ".")]
    public class HVACTemplate_Plant_Boiler : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("boiler_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Boiler_BoilerType BoilerType { get; set; } = (HVACTemplate_Plant_Boiler_BoilerType)Enum.Parse(typeof(HVACTemplate_Plant_Boiler_BoilerType), "CondensingHotWaterBoiler");
        

        [JsonProperty("capacity")]
        public string Capacity { get; set; } = (System.String)"Autosize";
        

        [Description("Not applicable  if Boiler Type is DistrictHotWater")]
        [JsonProperty("efficiency")]
        public System.Nullable<float> Efficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [Description("Not applicable  if Boiler Type is DistrictHotWater")]
        [JsonProperty("fuel_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Boiler_FuelType FuelType { get; set; } = (HVACTemplate_Plant_Boiler_FuelType)Enum.Parse(typeof(HVACTemplate_Plant_Boiler_FuelType), "Coal");
        

        [Description("If Hot Water Plant Operation Scheme Type=Default in HVACTemplate:Plant:HotWaterLo" +
                     "op, then equipment operates in priority order, 1, 2, 3, etc.")]
        [JsonProperty("priority")]
        public string Priority { get; set; } = "";
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("minimum_part_load_ratio")]
        public System.Nullable<float> MinimumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_part_load_ratio")]
        public System.Nullable<float> MaximumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

        [JsonProperty("optimum_part_load_ratio")]
        public System.Nullable<float> OptimumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("water_outlet_upper_temperature_limit")]
        public System.Nullable<float> WaterOutletUpperTemperatureLimit { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

        [Description("Specifies if this boiler serves a template hot water loop or mixed water loop If " +
                     "left blank, will serve a hot water loop if present, or a mixed water loop (if no" +
                     " hot water loop is present).")]
        [JsonProperty("template_plant_loop_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Boiler_TemplatePlantLoopType TemplatePlantLoopType { get; set; } = (HVACTemplate_Plant_Boiler_TemplatePlantLoopType)Enum.Parse(typeof(HVACTemplate_Plant_Boiler_TemplatePlantLoopType), "HotWater");
    }
}