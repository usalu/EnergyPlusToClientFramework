using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"Works in conjunction with the refrigeration case and walk-in objects to simulate the performance of a refrigerated case system. This object models the electric consumption of the rack compressors and the condenser fans. Heat can be rejected either outdoors or to a zone. Compressor rack waste heat can also be reclaimed for use by an optional air- or water-heating coil (Coil:Heating:Desuperheater and Coil:WaterHeating:Desuperheater).")]
    [JsonObject("Refrigeration:CompressorRack")]
    public class Refrigeration_CompressorRack : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("heat_rejection_location")]
        public Refrigeration_CompressorRack_HeatRejectionLocation HeatRejectionLocation { get; set; } = (Refrigeration_CompressorRack_HeatRejectionLocation)Enum.Parse(typeof(Refrigeration_CompressorRack_HeatRejectionLocation), "Outdoors");
        

        [Description("It is important that this COP correspond to the lowest saturated suction temperat" +
                     "ure needed to serve all refrigeration loads")]
        [JsonProperty("design_compressor_rack_cop")]
        public System.Nullable<float> DesignCompressorRackCop { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("It is important that this COP curve correspond to the lowest saturated suction te" +
                     "mperature needed to serve all refrigeration loads")]
        [JsonProperty("compressor_rack_cop_function_of_temperature_curve_name")]
        public string CompressorRackCopFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Design power for condenser fan(s).")]
        [JsonProperty("design_condenser_fan_power")]
        public System.Nullable<float> DesignCondenserFanPower { get; set; } = (System.Nullable<float>)Single.Parse("250", CultureInfo.InvariantCulture);
        

        [JsonProperty("condenser_fan_power_function_of_temperature_curve_name")]
        public string CondenserFanPowerFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Applicable only when Heat Rejection Location is Outdoors.")]
        [JsonProperty("condenser_type")]
        public Refrigeration_CompressorRack_CondenserType CondenserType { get; set; } = (Refrigeration_CompressorRack_CondenserType)Enum.Parse(typeof(Refrigeration_CompressorRack_CondenserType), "AirCooled");
        

        [JsonProperty("water_cooled_condenser_inlet_node_name")]
        public string WaterCooledCondenserInletNodeName { get; set; } = "";
        

        [JsonProperty("water_cooled_condenser_outlet_node_name")]
        public string WaterCooledCondenserOutletNodeName { get; set; } = "";
        

        [Description("Applicable only when Condenser Type is WaterCooled.")]
        [JsonProperty("water_cooled_loop_flow_type")]
        public Refrigeration_CompressorRack_WaterCooledLoopFlowType WaterCooledLoopFlowType { get; set; } = (Refrigeration_CompressorRack_WaterCooledLoopFlowType)Enum.Parse(typeof(Refrigeration_CompressorRack_WaterCooledLoopFlowType), "VariableFlow");
        

        [Description("Applicable only when loop Flow type is VariableFlow.")]
        [JsonProperty("water_cooled_condenser_outlet_temperature_schedule_name")]
        public string WaterCooledCondenserOutletTemperatureScheduleName { get; set; } = "";
        

        [Description("Applicable only when loop flow type is ConstantFlow.")]
        [JsonProperty("water_cooled_condenser_design_flow_rate")]
        public System.Nullable<float> WaterCooledCondenserDesignFlowRate { get; set; } = null;
        

        [JsonProperty("water_cooled_condenser_maximum_flow_rate")]
        public System.Nullable<float> WaterCooledCondenserMaximumFlowRate { get; set; } = null;
        

        [JsonProperty("water_cooled_condenser_maximum_water_outlet_temperature")]
        public System.Nullable<float> WaterCooledCondenserMaximumWaterOutletTemperature { get; set; } = (System.Nullable<float>)Single.Parse("55", CultureInfo.InvariantCulture);
        

        [JsonProperty("water_cooled_condenser_minimum_water_inlet_temperature")]
        public System.Nullable<float> WaterCooledCondenserMinimumWaterInletTemperature { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 indicate that evaporative cooling of the condenser is available. This schedule allows the user to define seasonal shutdown/draining of the water cooling system in cold climate applications. For periods with schedule values of 0, the condenser operates as AirCooled.")]
        [JsonProperty("evaporative_condenser_availability_schedule_name")]
        public string EvaporativeCondenserAvailabilityScheduleName { get; set; } = "";
        

        [Description("Applicable only for Condenser Type = EvaporativlyCooled.")]
        [JsonProperty("evaporative_condenser_effectiveness")]
        public System.Nullable<float> EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for Condenser Type = EvaporativelyCooled. Used to calculate evapo" +
                     "rative condenser water use.")]
        [JsonProperty("evaporative_condenser_air_flow_rate")]
        public string EvaporativeCondenserAirFlowRate { get; set; } = (System.String)"Autocalculate";
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the evaporatively cooled condenser is available (field Evaporative Condenser Availability Schedule Name). For this situation, the heater heats the basin water when the outdoor air dry-bulb temperature falls below the setpoint temperature, but only when the condenser fans are off (i.e., no refrigerated case load).")]
        [JsonProperty("basin_heater_capacity")]
        public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("200", CultureInfo.InvariantCulture);
        

        [Description("Enter the outdoor dry-bulb temperature at which the basin heater turns on.")]
        [JsonProperty("basin_heater_setpoint_temperature")]
        public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Design recirc water pump power for Condenser Type = EvaporativelyCooled. Applicab" +
                     "le only for Condenser Type = EvaporativelyCooled.")]
        [JsonProperty("design_evaporative_condenser_water_pump_power")]
        public string DesignEvaporativeCondenserWaterPumpPower { get; set; } = (System.String)"1000";
        

        [Description("If blank, water supply is from Mains. Applicable only for Condenser Type = Evapor" +
                     "ativelyCooled.")]
        [JsonProperty("evaporative_water_supply_tank_name")]
        public string EvaporativeWaterSupplyTankName { get; set; } = "";
        

        [Description(@"Applicable only when Heat Rejection Location is Outdoors and Condenser Type is not WaterCooled; otherwise, leave field blank. If field is left blank with Heat Rejection Location = Outdoors, then the model assumes that the Inlet Air conditions are the outdoor air conditions for the current timestep (e.g., no adjustment for height above ground).")]
        [JsonProperty("condenser_air_inlet_node_name")]
        public string CondenserAirInletNodeName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
        

        [Description("Enter the name of a Refrigeration:Case or Refrigeration:Walkin or Refrigeration:C" +
                     "aseAndWalkinList object.")]
        [JsonProperty("refrigeration_case_name_or_walkin_name_or_caseandwalkinlist_name")]
        public string RefrigerationCaseNameOrWalkinNameOrCaseandwalkinlistName { get; set; } = "";
        

        [Description("This must be a controlled zone and appear in a ZoneHVAC:EquipmentConnections obje" +
                     "ct. Required only if walk-in[s] are connected to this rack AND the heat rejectio" +
                     "n location is \"Zone\"")]
        [JsonProperty("heat_rejection_zone_name")]
        public string HeatRejectionZoneName { get; set; } = "";
    }
}