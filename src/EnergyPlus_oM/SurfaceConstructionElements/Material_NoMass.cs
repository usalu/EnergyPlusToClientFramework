using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Regular materials properties described whose principal description is R (Thermal " +
                 "Resistance)")]
    public class Material_NoMass : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("roughness")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Material_NoMass_Roughness Roughness { get; set; } = (Material_NoMass_Roughness)Enum.Parse(typeof(Material_NoMass_Roughness), "MediumRough");
        

        [JsonProperty("thermal_resistance")]
        public System.Nullable<float> ThermalResistance { get; set; } = null;
        

        [JsonProperty("thermal_absorptance")]
        public System.Nullable<float> ThermalAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("solar_absorptance")]
        public System.Nullable<float> SolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("visible_absorptance")]
        public System.Nullable<float> VisibleAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
    }
}