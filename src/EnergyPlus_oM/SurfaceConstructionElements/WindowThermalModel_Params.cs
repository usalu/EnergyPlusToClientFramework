using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("object is used to select which thermal model should be used in tarcog simulations" +
                 "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowThermalModel_Params : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("standard")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowThermalModel_Params_Standard Standard { get; set; } = (WindowThermalModel_Params_Standard)Enum.Parse(typeof(WindowThermalModel_Params_Standard), "ISO15099");
        

        [JsonProperty("thermal_model")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowThermalModel_Params_ThermalModel ThermalModel { get; set; } = (WindowThermalModel_Params_ThermalModel)Enum.Parse(typeof(WindowThermalModel_Params_ThermalModel), "ISO15099");
        

        [JsonProperty("sdscalar")]
        public System.Nullable<float> Sdscalar { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("deflection_model")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowThermalModel_Params_DeflectionModel DeflectionModel { get; set; } = (WindowThermalModel_Params_DeflectionModel)Enum.Parse(typeof(WindowThermalModel_Params_DeflectionModel), "NoDeflection");
        

        [JsonProperty("vacuum_pressure_limit")]
        public System.Nullable<float> VacuumPressureLimit { get; set; } = (System.Nullable<float>)Single.Parse("13.238", CultureInfo.InvariantCulture);
        

        [Description("This is temperature in time of window fabrication")]
        [JsonProperty("initial_temperature")]
        public System.Nullable<float> InitialTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25", CultureInfo.InvariantCulture);
        

        [Description("This is pressure in time of window fabrication")]
        [JsonProperty("initial_pressure")]
        public System.Nullable<float> InitialPressure { get; set; } = (System.Nullable<float>)Single.Parse("101325", CultureInfo.InvariantCulture);
    }
}