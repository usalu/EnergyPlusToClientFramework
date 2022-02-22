using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fault of dirty air filters")]
    [JsonObject("FaultModel:Fouling:AirFilter")]
    public class FaultModel_Fouling_AirFilter : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Choose the type of the fan Support for Fan:SystemModel is pending")]
        [JsonProperty("fan_object_type")]
        public FaultModel_Fouling_AirFilter_FanObjectType FanObjectType { get; set; } = (FaultModel_Fouling_AirFilter_FanObjectType)Enum.Parse(typeof(FaultModel_Fouling_AirFilter_FanObjectType), "FanConstantVolume");
        

        [Description("Enter the name of a fan object")]
        [JsonProperty("fan_name")]
        public string FanName { get; set; } = "";
        

        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter the name of a schedule describing the variations of the fan pressure rise i" +
                     "n terms of multipliers to the fan design pressure rise")]
        [JsonProperty("pressure_fraction_schedule_name")]
        public string PressureFractionScheduleName { get; set; } = "";
        

        [Description("The curve describes the relationship between the fan pressure rise and air flow r" +
                     "ate")]
        [JsonProperty("fan_curve_name")]
        public string FanCurveName { get; set; } = "";
    }
}