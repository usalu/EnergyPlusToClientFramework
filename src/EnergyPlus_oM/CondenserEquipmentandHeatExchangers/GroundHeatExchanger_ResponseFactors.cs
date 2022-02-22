using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("Response factor definitions from third-party tool, commonly referred to a \"g-func" +
                 "tions\"")]
    [JsonObject("GroundHeatExchanger:ResponseFactors")]
    public class GroundHeatExchanger_ResponseFactors : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("ghe_vertical_properties_object_name")]
        public string GheVerticalPropertiesObjectName { get; set; } = "";
        

        [JsonProperty("number_of_boreholes")]
        public System.Nullable<float> NumberOfBoreholes { get; set; } = null;
        

        [JsonProperty("g_function_reference_ratio")]
        public System.Nullable<float> GFunctionReferenceRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.0005", CultureInfo.InvariantCulture);
        

        [JsonProperty("g_functions")]
        public string GFunctions { get; set; } = "";
    }
}