using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Undisturbed ground temperature object using a detailed finite difference 1-D mode" +
                 "l")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_Undisturbed_FiniteDifference : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("soil_thermal_conductivity")]
        public System.Nullable<float> SoilThermalConductivity { get; set; } = null;
        

        [JsonProperty("soil_density")]
        public System.Nullable<float> SoilDensity { get; set; } = null;
        

        [JsonProperty("soil_specific_heat")]
        public System.Nullable<float> SoilSpecificHeat { get; set; } = null;
        

        [JsonProperty("soil_moisture_content_volume_fraction")]
        public System.Nullable<float> SoilMoistureContentVolumeFraction { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [JsonProperty("soil_moisture_content_volume_fraction_at_saturation")]
        public System.Nullable<float> SoilMoistureContentVolumeFractionAtSaturation { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description(@"This specifies the ground cover effects during evapotranspiration calculations. The value roughly represents the following cases: = 0   : concrete or other solid, non-permeable ground surface material = 0.5 : short grass, much like a manicured lawn = 1   : standard reference state (12 cm grass) = 1.5 : wild growth")]
        [JsonProperty("evapotranspiration_ground_cover_parameter")]
        public System.Nullable<float> EvapotranspirationGroundCoverParameter { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
    }
}