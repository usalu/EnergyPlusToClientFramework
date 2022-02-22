using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object is used to allow user-defined view factors to be used for duct-surfac" +
                 "e radiation calculations.")]
    [JsonObject("AirflowNetwork:Distribution:DuctViewFactors")]
    public class AirflowNetwork_Distribution_DuctViewFactors : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("linkage_name")]
        public string LinkageName { get; set; } = "";
        

        [JsonProperty("duct_surface_exposure_fraction")]
        public System.Nullable<float> DuctSurfaceExposureFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("duct_surface_emittance")]
        public System.Nullable<float> DuctSurfaceEmittance { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("surfaces")]
        public string Surfaces { get; set; } = "";
    }
}