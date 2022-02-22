using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"Works in conjunction with refrigerated cases and walkins to simulate the performance of a secondary loop supermarket refrigeration system. Heat from the refrigeration loads served by the secondary loop is absorbed by a primary refrigeration system (Refrigeration:System). The SecondarySystem object simulates a heat exchanger that is an evaporator, or refrigeration load, on the primary refrigeration system.")]
    [JsonObject("Refrigeration:SecondarySystem")]
    public class Refrigeration_SecondarySystem : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object. If there i" +
                     "s more than one refrigerated case or walk-in served by this secondary system, en" +
                     "ter the name of a Refrigeration:CaseAndWalkInList object.")]
        [JsonProperty("refrigerated_case_or_walkin_or_caseandwalkinlist_name")]
        public string RefrigeratedCaseOrWalkinOrCaseandwalkinlistName { get; set; } = "";
        

        [Description(@"If ""FluidAlwaysLiquid"" is selected, the fluid properties must be input using the objects: FluidProperties:Name, FluidProperties:GlycolConcentration, and, if user defined fluid type, FluidProperties:Temperatures and FluidProperties:Concentration. Many sets of fluid properties can be found in GlycolPropertiesRefData.idf. If ""FluidPhaseChange"" is selected, the refrigerant properties must be input using the objects: (if user defined fluid type): FluidProperties:Name, FluidProperties:Temperatures, FluidProperties:Saturated, and FluidProperties:Superheated. Many sets of refrigerant data can be found in FluidPropertiesRefData.idf.")]
        [JsonProperty("circulating_fluid_type")]
        public Refrigeration_SecondarySystem_CirculatingFluidType CirculatingFluidType { get; set; } = (Refrigeration_SecondarySystem_CirculatingFluidType)Enum.Parse(typeof(Refrigeration_SecondarySystem_CirculatingFluidType), "FluidAlwaysLiquid");
        

        [Description("This must correspond to a name in the FluidProperties:Name object.")]
        [JsonProperty("circulating_fluid_name")]
        public string CirculatingFluidName { get; set; } = "";
        

        [Description(@"For ""FluidAlwaysLiquid"", at least one of the two, Evaporator Capacity OR Evaporator Flow Rate for Secondary Fluid, is required. For ""FluidPhaseChange"", the default capacity is the sum of the rated capacities of the Cases and Walk-ins served by the secondary loop.")]
        [JsonProperty("evaporator_capacity")]
        public System.Nullable<float> EvaporatorCapacity { get; set; } = null;
        

        [Description("For \"FluidAlwaysLiquid\", at least one of the two, Evaporator Capacity OR Evaporat" +
                     "or Flow Rate for Secondary Fluid, is required. For \"FluidPhaseChange\" loops, thi" +
                     "s input is not used. (see PhaseChange Circulating Rate)")]
        [JsonProperty("evaporator_flow_rate_for_secondary_fluid")]
        public System.Nullable<float> EvaporatorFlowRateForSecondaryFluid { get; set; } = null;
        

        [Description("This is the evaporating temperature in the heat exchanger used to chill or conden" +
                     "se the secondary loop circulating fluid. It is NOT the temperature in any cases " +
                     "or walk-ins served by the secondary loop.")]
        [JsonProperty("evaporator_evaporating_temperature")]
        public System.Nullable<float> EvaporatorEvaporatingTemperature { get; set; } = null;
        

        [Description(@"For ""FluidAlwaysLiquid"", this is the rated difference between the temperature of the circulating fluid leaving the heat exchanger and the heat exchanger's rated evaporating temperature. For ""FluidPhaseChange"", this is the difference between the temperature of the evaporating and condensing temperatures in the heat exchanger.")]
        [JsonProperty("evaporator_approach_temperature_difference")]
        public System.Nullable<float> EvaporatorApproachTemperatureDifference { get; set; } = null;
        

        [Description(@"For ""FluidAlwaysLiquid"", this is the rated difference between the temperature of the circulating fluid entering the heat exchanger and the temperature of the circulating fluid leaving the heat exchanger, and is Required. For ""FluidPhaseChange"", this input is not used.")]
        [JsonProperty("evaporator_range_temperature_difference")]
        public System.Nullable<float> EvaporatorRangeTemperatureDifference { get; set; } = null;
        

        [JsonProperty("number_of_pumps_in_loop")]
        public System.Nullable<float> NumberOfPumpsInLoop { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("For \"FluidAlwaysLiquid\",if not input, Evaporator Flow Rate for Secondary Fluid wi" +
                     "ll be used. For \"FluidPhaseChange\", if not input, this will be calculated using " +
                     "the PhaseChange Circulating Rate.")]
        [JsonProperty("total_pump_flow_rate")]
        public System.Nullable<float> TotalPumpFlowRate { get; set; } = null;
        

        [Description("Either the Total Pump Power or the Total Pump Head is required.")]
        [JsonProperty("total_pump_power")]
        public System.Nullable<float> TotalPumpPower { get; set; } = null;
        

        [Description("Either the Total Pump Power or the Total Pump Head is required.")]
        [JsonProperty("total_pump_head")]
        public System.Nullable<float> TotalPumpHead { get; set; } = null;
        

        [Description("This is the total mass flow at the pump divided by the gaseous mass flow leaving " +
                     "the refrigeration load.")]
        [JsonProperty("phasechange_circulating_rate")]
        public System.Nullable<float> PhasechangeCirculatingRate { get; set; } = (System.Nullable<float>)Single.Parse("2.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("pump_drive_type")]
        public Refrigeration_SecondarySystem_PumpDriveType PumpDriveType { get; set; } = (Refrigeration_SecondarySystem_PumpDriveType)Enum.Parse(typeof(Refrigeration_SecondarySystem_PumpDriveType), "Constant");
        

        [Description("Variable Speed Pump Curve Name is applicable to variable speed pumps only.")]
        [JsonProperty("variable_speed_pump_cubic_curve_name")]
        public string VariableSpeedPumpCubicCurveName { get; set; } = "";
        

        [Description("This is the portion of the pump motor heat added to secondary circulating fluid a" +
                     "nd is equal to the motor efficiency for non-hermetic motor. Enter 1.0 for a semi" +
                     "-hermetic motor.")]
        [JsonProperty("pump_motor_heat_to_fluid")]
        public System.Nullable<float> PumpMotorHeatToFluid { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

        [Description("Use only if you want to include distribution piping heat gain in refrigeration lo" +
                     "ad.")]
        [JsonProperty("sum_ua_distribution_piping")]
        public System.Nullable<float> SumUaDistributionPiping { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This will be used to determine the temperature used for distribution piping heat " +
                     "gain. The pipe heat gains are also counted as cooling credit for the zone. Requi" +
                     "red only if Sum UA Distribution Piping >0.0")]
        [JsonProperty("distribution_piping_zone_name")]
        public string DistributionPipingZoneName { get; set; } = "";
        

        [Description("Use only if you want to include Receiver/Separator Shell heat gain in refrigerati" +
                     "on load.")]
        [JsonProperty("sum_ua_receiver_separator_shell")]
        public System.Nullable<float> SumUaReceiverSeparatorShell { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This will be used to determine the temperature used for Receiver/Separator Shell " +
                     "heat gain. The shell heat gains are also counted as cooling credit for the zone." +
                     " Required only if Sum UA Receiver/Separator Shell >0.0")]
        [JsonProperty("receiver_separator_zone_name")]
        public string ReceiverSeparatorZoneName { get; set; } = "";
        

        [Description("This value refers to the refrigerant circulating within the primary system provid" +
                     "ing cooling to the chiller for the secondary loop, not to the fluid circulating " +
                     "within the secondary loop itself.")]
        [JsonProperty("evaporator_refrigerant_inventory")]
        public System.Nullable<float> EvaporatorRefrigerantInventory { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}