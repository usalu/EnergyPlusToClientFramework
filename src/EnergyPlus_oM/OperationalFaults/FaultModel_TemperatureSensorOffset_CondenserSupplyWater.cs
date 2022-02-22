using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fault of condenser supply water temperature sensor offset")]
    [JsonObject("FaultModel:TemperatureSensorOffset:CondenserSupplyWater")]
    public class FaultModel_TemperatureSensorOffset_CondenserSupplyWater : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("severity_schedule_name")]
        public string SeverityScheduleName { get; set; } = "";
        

        [Description("Enter the type of the cooling tower affected")]
        [JsonProperty("cooling_tower_object_type")]
        public FaultModel_TemperatureSensorOffset_CondenserSupplyWater_CoolingTowerObjectType CoolingTowerObjectType { get; set; } = (FaultModel_TemperatureSensorOffset_CondenserSupplyWater_CoolingTowerObjectType)Enum.Parse(typeof(FaultModel_TemperatureSensorOffset_CondenserSupplyWater_CoolingTowerObjectType), "CoolingTowerSingleSpeed");
        

        [Description("Enter the name of the cooling tower affected")]
        [JsonProperty("cooling_tower_object_name")]
        public string CoolingTowerObjectName { get; set; } = "";
        

        [JsonProperty("reference_sensor_offset")]
        public System.Nullable<float> ReferenceSensorOffset { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}