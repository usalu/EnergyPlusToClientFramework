using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
                 "ly. Additional material properties for surfaces. Has no effect with other HeatBa" +
                 "lanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:HeatAndMoistureTransfer:Settings")]
    public class MaterialProperty_HeatAndMoistureTransfer_Settings : BHoMObject
    {
        

        [Description("Material Name that the moisture properties will be added to. This augments materi" +
                     "al properties needed for combined heat and moisture transfer for surfaces.")]
        [JsonProperty("material_name")]
        public string MaterialName { get; set; } = "";
        

        [JsonProperty("porosity")]
        public System.Nullable<float> Porosity { get; set; } = null;
        

        [Description("units are the water/material density ratio at the beginning of each run period.")]
        [JsonProperty("initial_water_content_ratio")]
        public System.Nullable<float> InitialWaterContentRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
    }
}