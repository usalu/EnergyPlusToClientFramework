using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes the fault of fouling cooling towers")]
    [JsonObject("FaultModel:Fouling:CoolingTower")]
    public class FaultModel_Fouling_CoolingTower : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("severity_schedule_name")]
        public string SeverityScheduleName { get; set; } = "";
        

        [Description("Enter the type of the cooling tower affected")]
        [JsonProperty("cooling_tower_object_type")]
        public FaultModel_Fouling_CoolingTower_CoolingTowerObjectType CoolingTowerObjectType { get; set; } = (FaultModel_Fouling_CoolingTower_CoolingTowerObjectType)Enum.Parse(typeof(FaultModel_Fouling_CoolingTower_CoolingTowerObjectType), "CoolingTowerSingleSpeed");
        

        [Description("Enter the name of the cooling tower affected")]
        [JsonProperty("cooling_tower_object_name")]
        public string CoolingTowerObjectName { get; set; } = "";
        

        [Description("Factor describing the tower UA reduction due to fouling It is the ratio between t" +
                     "he UA value at fouling case and that at fault free case It is applicable to both" +
                     " the Design UA and Free Convection UA of the tower")]
        [JsonProperty("reference_ua_reduction_factor")]
        public System.Nullable<float> ReferenceUaReductionFactor { get; set; } = null;
    }
}