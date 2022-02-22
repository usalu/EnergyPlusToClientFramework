using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("This object adds a cooling tower to an HVACTemplate:Plant:ChilledWaterLoop or Mix" +
                 "edWaterLoop.")]
    public class HVACTemplate_Plant_Tower : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("tower_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Tower_TowerType TowerType { get; set; } = (HVACTemplate_Plant_Tower_TowerType)Enum.Parse(typeof(HVACTemplate_Plant_Tower_TowerType), "SingleSpeed");
        

        [Description(@"Applicable for tower type SingleSpeed and TwoSpeed Nominal tower capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature, with the tower fan operating at high speed. Design water flow rate assumed to be 5.382E-8 m3/s per watt(3 gpm/ton). Nominal tower capacity times (1.25) gives the actual tower heat rejection at these operating conditions.")]
        [JsonProperty("high_speed_nominal_capacity")]
        public string HighSpeedNominalCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Applicable for tower type SingleSpeed and TwoSpeed")]
        [JsonProperty("high_speed_fan_power")]
        public string HighSpeedFanPower { get; set; } = (System.String)"Autosize";
        

        [Description(@"Applicable only for Tower Type TwoSpeed Nominal tower capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature, with the tower fan operating at low speed. Design water flow rate assumed to be 5.382E-8 m3/s per watt of tower high-speed nominal capacity (3 gpm/ton). Nominal tower capacity times (1.25) gives the actual tower heat rejection at these operating conditions.")]
        [JsonProperty("low_speed_nominal_capacity")]
        public string LowSpeedNominalCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Applicable only for Tower Type TwoSpeed")]
        [JsonProperty("low_speed_fan_power")]
        public string LowSpeedFanPower { get; set; } = (System.String)"Autosize";
        

        [Description(@"Applicable for Tower Type SingleSpeed and TwoSpeed Tower capacity in free convection regime with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt of tower high-speed nominal capacity (3 gpm/ton). Tower free convection capacity times (1.25) gives the actual tower heat rejection at these operating conditions.")]
        [JsonProperty("free_convection_capacity")]
        public string FreeConvectionCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Applicable for all Tower Types If Condenser Plant Operation Scheme Type=Default i" +
                     "n HVACTemplate:Plant:ChilledWaterLoop, then equipment operates in Priority order" +
                     ", 1, 2, 3, etc.")]
        [JsonProperty("priority")]
        public string Priority { get; set; } = "";
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Specifies if this tower serves a template chilled water loop or mixed water loop " +
                     "If left blank, will serve a chilled water loop if present, or a mixed water loop" +
                     " (if no chilled water loop is present).")]
        [JsonProperty("template_plant_loop_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Tower_TemplatePlantLoopType TemplatePlantLoopType { get; set; } = (HVACTemplate_Plant_Tower_TemplatePlantLoopType)Enum.Parse(typeof(HVACTemplate_Plant_Tower_TemplatePlantLoopType), "ChilledWater");
    }
}