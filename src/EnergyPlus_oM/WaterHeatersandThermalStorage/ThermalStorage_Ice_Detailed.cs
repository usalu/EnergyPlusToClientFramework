using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    [Description("This input syntax is intended to describe a thermal storage system that includes " +
                 "smaller containers filled with water that are placed in a larger tank or series " +
                 "of tanks. The model uses polynomial equations to describe the system performance" +
                 ".")]
    [JsonObject("ThermalStorage:Ice:Detailed")]
    public class ThermalStorage_Ice_Detailed : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("This includes only the latent storage capacity")]
        [JsonProperty("capacity")]
        public System.Nullable<float> Capacity { get; set; } = null;
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty("discharging_curve_variable_specifications")]
        public ThermalStorage_Ice_Detailed_DischargingCurveVariableSpecifications DischargingCurveVariableSpecifications { get; set; } = (ThermalStorage_Ice_Detailed_DischargingCurveVariableSpecifications)Enum.Parse(typeof(ThermalStorage_Ice_Detailed_DischargingCurveVariableSpecifications), "FractionChargedLMTD");
        

        [JsonProperty("discharging_curve_name")]
        public string DischargingCurveName { get; set; } = "";
        

        [JsonProperty("charging_curve_variable_specifications")]
        public ThermalStorage_Ice_Detailed_ChargingCurveVariableSpecifications ChargingCurveVariableSpecifications { get; set; } = (ThermalStorage_Ice_Detailed_ChargingCurveVariableSpecifications)Enum.Parse(typeof(ThermalStorage_Ice_Detailed_ChargingCurveVariableSpecifications), "FractionChargedLMTD");
        

        [JsonProperty("charging_curve_name")]
        public string ChargingCurveName { get; set; } = "";
        

        [JsonProperty("timestep_of_the_curve_data")]
        public System.Nullable<float> TimestepOfTheCurveData { get; set; } = null;
        

        [JsonProperty("parasitic_electric_load_during_discharging")]
        public System.Nullable<float> ParasiticElectricLoadDuringDischarging { get; set; } = null;
        

        [JsonProperty("parasitic_electric_load_during_charging")]
        public System.Nullable<float> ParasiticElectricLoadDuringCharging { get; set; } = null;
        

        [Description("This is the fraction the total storage capacity that is lost or melts each hour")]
        [JsonProperty("tank_loss_coefficient")]
        public System.Nullable<float> TankLossCoefficient { get; set; } = null;
        

        [Description("This temperature is typically 0C for water. Simply changing this temperature with" +
                     "out adjusting the performance parameters input above is inappropriate and not ad" +
                     "vised.")]
        [JsonProperty("freezing_temperature_of_storage_medium")]
        public System.Nullable<float> FreezingTemperatureOfStorageMedium { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field determines whether the system uses internal or external melt during di" +
                     "scharging. This will then have an impact on charging performance.")]
        [JsonProperty("thaw_process_indicator")]
        public ThermalStorage_Ice_Detailed_ThawProcessIndicator ThawProcessIndicator { get; set; } = (ThermalStorage_Ice_Detailed_ThawProcessIndicator)Enum.Parse(typeof(ThermalStorage_Ice_Detailed_ThawProcessIndicator), "OutsideMelt");
    }
}