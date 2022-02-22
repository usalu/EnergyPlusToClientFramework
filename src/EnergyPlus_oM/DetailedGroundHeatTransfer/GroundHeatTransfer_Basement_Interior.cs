using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Provides the information needed to simulate the inside boundary conditions for th" +
                 "e Basement preprocessor ground heat transfer simulation.")]
    public class GroundHeatTransfer_Basement_Interior : BHoMObject, IEnergyPlusClass
    {
        

        [Description("for EnergyPlus this should be TRUE")]
        [JsonProperty("cond_flag_is_the_basement_conditioned_")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatTransfer_Basement_Interior_CondFlagIsTheBasementConditioned CondFlagIsTheBasementConditioned { get; set; } = (GroundHeatTransfer_Basement_Interior_CondFlagIsTheBasementConditioned)Enum.Parse(typeof(GroundHeatTransfer_Basement_Interior_CondFlagIsTheBasementConditioned), "TRUE");
        

        [JsonProperty("hin_downward_convection_only_heat_transfer_coefficient")]
        public System.Nullable<float> HinDownwardConvectionOnlyHeatTransferCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0.92", CultureInfo.InvariantCulture);
        

        [JsonProperty("hin_upward_convection_only_heat_transfer_coefficient")]
        public System.Nullable<float> HinUpwardConvectionOnlyHeatTransferCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("4.04", CultureInfo.InvariantCulture);
        

        [JsonProperty("hin_horizontal_convection_only_heat_transfer_coefficient")]
        public System.Nullable<float> HinHorizontalConvectionOnlyHeatTransferCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("3.08", CultureInfo.InvariantCulture);
        

        [JsonProperty("hin_downward_combined_convection_and_radiation_heat_transfer_coefficient")]
        public System.Nullable<float> HinDownwardCombinedConvectionAndRadiationHeatTransferCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("6.13", CultureInfo.InvariantCulture);
        

        [JsonProperty("hin_upward_combined_convection_and_radiation_heat_transfer_coefficient")]
        public System.Nullable<float> HinUpwardCombinedConvectionAndRadiationHeatTransferCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("9.26", CultureInfo.InvariantCulture);
        

        [JsonProperty("hin_horizontal_combined_convection_and_radiation_heat_transfer_coefficient")]
        public System.Nullable<float> HinHorizontalCombinedConvectionAndRadiationHeatTransferCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("8.29", CultureInfo.InvariantCulture);
    }
}