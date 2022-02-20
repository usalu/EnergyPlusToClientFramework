using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description("Simulates the performance of a supermarket refrigeration system when used along w" +
                 "ith other objects to define the refrigeration load(s), the compressor(s), and th" +
                 "e condenser.")]
    [JsonObject("Refrigeration:System")]
    public class Refrigeration_System : BHoMObject
    {
        

        [Description(@"Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object. If there is more than one refrigerated case or walk-in served by this system, enter the name of a Refrigeration:CaseAndWalkInList object. Only cases and walkins served directly by the system should be included in this list. Any cases served indirectly via a secondary chiller should NOT be included in this list")]
        [JsonProperty("refrigerated_case_or_walkin_or_caseandwalkinlist_name")]
        public string RefrigeratedCaseOrWalkinOrCaseandwalkinlistName { get; set; } = "";
        

        [Description(@"Enter the name of a Refrigeration:SecondarySystem object OR a Refrigeration:Condenser:Cascade object OR, a Refrigeration:TransferLoadList object. A transfer load is identified as one which moves the load from one system to another. So if you have more than one such load (including cascade condensers and secondary loops) served by the same system, use a TransferLoadList object.")]
        [JsonProperty("refrigeration_transfer_load_or_transferload_list_name")]
        public string RefrigerationTransferLoadOrTransferloadListName { get; set; } = "";
        

        [JsonProperty("refrigeration_condenser_name")]
        public string RefrigerationCondenserName { get; set; } = "";
        

        [JsonProperty("compressor_or_compressorlist_name")]
        public string CompressorOrCompressorlistName { get; set; } = "";
        

        [Description("related to the proper operation of the thermal expansion valves and compressors")]
        [JsonProperty("minimum_condensing_temperature")]
        public System.Nullable<float> MinimumCondensingTemperature { get; set; } = null;
        

        [Description(@"Fluid property data for the refrigerant must be entered. The fluid property data, including the objects: FluidProperties:Name, FluidProperties:Temperatures, FluidProperties:Saturated and FluidProperties:Superheated can be copied from the FluidPropertiesRefData.idf dataset")]
        [JsonProperty("refrigeration_system_working_fluid_type")]
        public string RefrigerationSystemWorkingFluidType { get; set; } = "";
        

        [JsonProperty("suction_temperature_control_type")]
        public EmptyNoYes SuctionTemperatureControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ConstantSuctionTemperature");
        

        [Description("Optional Field Recipient of refrigeration capacity, that is receives cool liquid " +
                     "from another refrigeration system to help meet aggregate case loads")]
        [JsonProperty("mechanical_subcooler_name")]
        public string MechanicalSubcoolerName { get; set; } = "";
        

        [Description("Optional Field Liquid Suction Heat Exchanger Name, or leave blank")]
        [JsonProperty("liquid_suction_heat_exchanger_subcooler_name")]
        public string LiquidSuctionHeatExchangerSubcoolerName { get; set; } = "";
        

        [Description("Use only if you want to include suction piping heat gain in refrigeration load")]
        [JsonProperty("sum_ua_suction_piping")]
        public System.Nullable<float> SumUaSuctionPiping { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This will be used to determine the temperature used for distribution piping heat " +
                     "gain and the pipe heat gains  as cooling credit for the zone. Required only if S" +
                     "um UA Distribution Piping >0.0")]
        [JsonProperty("suction_piping_zone_name")]
        public string SuctionPipingZoneName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
        

        [JsonProperty("number_of_compressor_stages")]
        public string NumberOfCompressorStages { get; set; } = (System.String)"1";
        

        [JsonProperty("intercooler_type")]
        public EmptyNoYes IntercoolerType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
        

        [JsonProperty("shell_and_coil_intercooler_effectiveness")]
        public System.Nullable<float> ShellAndCoilIntercoolerEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty("high_stage_compressor_or_compressorlist_name")]
        public string HighStageCompressorOrCompressorlistName { get; set; } = "";
    }
}