using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("This constant COP chiller model provides a means of quickly specifying a Chiller " +
                 "where performance data is not available.")]
    [JsonObject("Chiller:ConstantCOP")]
    public class Chiller_ConstantCOP : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("nominal_capacity")]
        public string NominalCapacity { get; set; } = "";
        

        [JsonProperty("nominal_cop")]
        public System.Nullable<float> NominalCop { get; set; } = null;
        

        [Description("For variable volume this is the maximum flow and for constant flow this is the fl" +
                     "ow.")]
        [JsonProperty("design_chilled_water_flow_rate")]
        public string DesignChilledWaterFlowRate { get; set; } = "";
        

        [Description("This field is not used for Condenser Type = AirCooled or EvaporativelyCooled")]
        [JsonProperty("design_condenser_water_flow_rate")]
        public string DesignCondenserWaterFlowRate { get; set; } = "";
        

        [JsonProperty("chilled_water_inlet_node_name")]
        public string ChilledWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("chilled_water_outlet_node_name")]
        public string ChilledWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_inlet_node_name")]
        public string CondenserInletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_outlet_node_name")]
        public string CondenserOutletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_type")]
        public Chiller_ConstantCOP_CondenserType CondenserType { get; set; } = (Chiller_ConstantCOP_CondenserType)Enum.Parse(typeof(Chiller_ConstantCOP_CondenserType), "AirCooled");
        

        [Description(@"Select operating mode for fluid flow through the chiller. ""NotModulated"" is for either variable or constant pumping with flow controlled by the external plant system. ""ConstantFlow"" is for constant pumping with flow controlled by chiller to operate at full design flow rate. ""LeavingSetpointModulated"" is for variable pumping with flow controlled by chiller to vary flow to target a leaving temperature setpoint.")]
        [JsonProperty("chiller_flow_mode")]
        public Chiller_ConstantCOP_ChillerFlowMode ChillerFlowMode { get; set; } = (Chiller_ConstantCOP_ChillerFlowMode)Enum.Parse(typeof(Chiller_ConstantCOP_ChillerFlowMode), "NotModulated");
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, the heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the chiller is not operating.")]
        [JsonProperty("basin_heater_capacity")]
        public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
                     "or dry-bulb temperature when the basin heater turns on.")]
        [JsonProperty("basin_heater_setpoint_temperature")]
        public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty("basin_heater_operating_schedule_name")]
        public string BasinHeaterOperatingScheduleName { get; set; } = "";
    }
}