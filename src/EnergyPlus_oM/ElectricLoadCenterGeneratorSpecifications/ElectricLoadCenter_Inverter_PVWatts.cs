using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Electric power inverter to convert from direct current (DC) to alternating curren" +
                 "t (AC) in an electric load center that contains Generator:PVWatts objects. It im" +
                 "plements the PVWatts inverter performance curves.")]
    [JsonObject("ElectricLoadCenter:Inverter:PVWatts")]
    public class ElectricLoadCenter_Inverter_PVWatts : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("dc_to_ac_size_ratio")]
        public System.Nullable<float> DcToAcSizeRatio { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

        [JsonProperty("inverter_efficiency")]
        public System.Nullable<float> InverterEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.96", CultureInfo.InvariantCulture);
    }
}