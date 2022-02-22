using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description("Detailed transcritical carbon dioxide (CO2) booster refrigeration systems used in" +
                 " supermarkets. The object allows for modeling either a single stage system with " +
                 "medium-temperature loads or a two stage system with both medium- and low-tempera" +
                 "ture loads.")]
    [JsonObject("Refrigeration:TranscriticalSystem")]
    public class Refrigeration_TranscriticalSystem : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("system_type")]
        public Refrigeration_TranscriticalSystem_SystemType SystemType { get; set; } = (Refrigeration_TranscriticalSystem_SystemType)Enum.Parse(typeof(Refrigeration_TranscriticalSystem_SystemType), "SingleStage");
        

        [Description(@"Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object. If there is more than one refrigerated case or walk-in served by this system, enter the name of a Refrigeration:CaseAndWalkInList object. Only medium temperature cases and walk-ins served directly by the system should be included in this list.")]
        [JsonProperty("medium_temperature_refrigerated_case_or_walkin_or_caseandwalkinlist_name")]
        public string MediumTemperatureRefrigeratedCaseOrWalkinOrCaseandwalkinlistName { get; set; } = "";
        

        [Description(@"Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object. If there is more than one refrigerated case or walk-in served by this system, enter the name of a Refrigeration:CaseAndWalkInList object. Only low temperature cases and walkins served directly by the system should be included in this list.")]
        [JsonProperty("low_temperature_refrigerated_case_or_walkin_or_caseandwalkinlist_name")]
        public string LowTemperatureRefrigeratedCaseOrWalkinOrCaseandwalkinlistName { get; set; } = "";
        

        [JsonProperty("refrigeration_gas_cooler_name")]
        public string RefrigerationGasCoolerName { get; set; } = "";
        

        [JsonProperty("high_pressure_compressor_or_compressorlist_name")]
        public string HighPressureCompressorOrCompressorlistName { get; set; } = "";
        

        [JsonProperty("low_pressure_compressor_or_compressorlist_name")]
        public string LowPressureCompressorOrCompressorlistName { get; set; } = "";
        

        [JsonProperty("receiver_pressure")]
        public System.Nullable<float> ReceiverPressure { get; set; } = (System.Nullable<float>)Single.Parse("4000000", CultureInfo.InvariantCulture);
        

        [JsonProperty("subcooler_effectiveness")]
        public System.Nullable<float> SubcoolerEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [Description(@"Fluid property data for the refrigerant must be entered. The fluid property data, including the objects: FluidProperties:Name, FluidProperties:Temperatures, FluidProperties:Saturated and FluidProperties:Superheated can be copied from the FluidPropertiesRefData.idf dataset")]
        [JsonProperty("refrigeration_system_working_fluid_type")]
        public string RefrigerationSystemWorkingFluidType { get; set; } = "";
        

        [Description("Use only if you want to include suction piping heat gain in refrigeration load")]
        [JsonProperty("sum_ua_suction_piping_for_medium_temperature_loads")]
        public System.Nullable<float> SumUaSuctionPipingForMediumTemperatureLoads { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This will be used to determine the temperature used for distribution piping heat " +
                     "gain and the pipe heat gains as cooling credit for the zone. Required only if Su" +
                     "m UA Distribution Piping for Medium Temperature Loads > 0.0")]
        [JsonProperty("medium_temperature_suction_piping_zone_name")]
        public string MediumTemperatureSuctionPipingZoneName { get; set; } = "";
        

        [Description("Use only if you want to include suction piping heat gain in refrigeration load")]
        [JsonProperty("sum_ua_suction_piping_for_low_temperature_loads")]
        public System.Nullable<float> SumUaSuctionPipingForLowTemperatureLoads { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This will be used to determine the temperature used for distribution piping heat " +
                     "gain and the pipe heat gains as cooling credit for the zone. Required only if Su" +
                     "m UA Distribution Piping for Low Temperature Loads > 0.0")]
        [JsonProperty("low_temperature_suction_piping_zone_name")]
        public string LowTemperatureSuctionPipingZoneName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}