using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("This object contains the material properties for the materials used in the model." +
                 " The fields are mostly self explanatory.")]
    [JsonObject("GroundHeatTransfer:Slab:MatlProps")]
    public class GroundHeatTransfer_Slab_MatlProps : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Density of Slab Material typical value= 2300.0")]
        [JsonProperty("rho_slab_material_density")]
        public System.Nullable<float> RhoSlabMaterialDensity { get; set; } = (System.Nullable<float>)Single.Parse("2300", CultureInfo.InvariantCulture);
        

        [Description("Density of Soil Material typical value= 1200.0")]
        [JsonProperty("rho_soil_density")]
        public System.Nullable<float> RhoSoilDensity { get; set; } = (System.Nullable<float>)Single.Parse("1200", CultureInfo.InvariantCulture);
        

        [Description("Specific Heat of Slab Material typical value=650.0")]
        [JsonProperty("cp_slab_cp")]
        public System.Nullable<float> CpSlabCp { get; set; } = (System.Nullable<float>)Single.Parse("650", CultureInfo.InvariantCulture);
        

        [Description("Specific Heat of Soil Material typical value= 1200.0")]
        [JsonProperty("cp_soil_cp")]
        public System.Nullable<float> CpSoilCp { get; set; } = (System.Nullable<float>)Single.Parse("1200", CultureInfo.InvariantCulture);
        

        [Description("Conductivity of Slab Material typical value= .9")]
        [JsonProperty("tcon_slab_k")]
        public System.Nullable<float> TconSlabK { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Conductivity of Soil Material typical value= 1.0")]
        [JsonProperty("tcon_soil_k")]
        public System.Nullable<float> TconSoilK { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}