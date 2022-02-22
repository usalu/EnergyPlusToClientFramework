using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("The number of surfaces can be expanded beyond 100, if necessary, by adding more g" +
                 "roups to the end of the list")]
    [JsonObject("ZoneHVAC:CoolingPanel:RadiantConvective:Water")]
    public class ZoneHVAC_CoolingPanel_RadiantConvective_Water : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("water_inlet_node_name")]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty("water_outlet_node_name")]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("rated_inlet_water_temperature")]
        public System.Nullable<float> RatedInletWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty("rated_inlet_space_temperature")]
        public System.Nullable<float> RatedInletSpaceTemperature { get; set; } = (System.Nullable<float>)Single.Parse("24", CultureInfo.InvariantCulture);
        

        [JsonProperty("rated_water_mass_flow_rate")]
        public System.Nullable<float> RatedWaterMassFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0.063", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the method used to determine the cooling design capacity for scalable sizing. CoolingDesignCapacity => selected when the design cooling capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determined from user specified cooling capacity per floor area and total floor area of cooled zone served by the hydrolic unit. FractionOfAutosizedCoolingCapacity => is selected when the design cooling capacity is determined from a user specified fraction and the auto-sized design cooling capacity of the system.")]
        [JsonProperty("cooling_design_capacity_method")]
        public ZoneHVAC_CoolingPanel_RadiantConvective_Water_CoolingDesignCapacityMethod CoolingDesignCapacityMethod { get; set; } = (ZoneHVAC_CoolingPanel_RadiantConvective_Water_CoolingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_CoolingPanel_RadiantConvective_Water_CoolingDesignCapacityMethod), "CoolingDesignCapacity");
        

        [Description("Enter the design cooling capacity. Required field when the cooling design capacit" +
                     "y method CoolingDesignCapacity.")]
        [JsonProperty("cooling_design_capacity")]
        public string CoolingDesignCapacity { get; set; } = "";
        

        [Description("Enter the cooling design capacity per total floor area of cooled zones served by " +
                     "the unit. Required field when the cooling design capacity method field is Capaci" +
                     "tyPerFloorArea.")]
        [JsonProperty("cooling_design_capacity_per_floor_area")]
        public System.Nullable<float> CoolingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of auto-sized cooling design capacity. Required field when the" +
                     " cooling design capacity method field is FractionOfAutosizedCoolingCapacity.")]
        [JsonProperty("fraction_of_autosized_cooling_design_capacity")]
        public System.Nullable<float> FractionOfAutosizedCoolingDesignCapacity { get; set; } = null;
        

        [JsonProperty("maximum_chilled_water_flow_rate")]
        public string MaximumChilledWaterFlowRate { get; set; } = "";
        

        [Description("Temperature on which unit is controlled")]
        [JsonProperty("control_type")]
        public ZoneHVAC_CoolingPanel_RadiantConvective_Water_ControlType ControlType { get; set; } = (ZoneHVAC_CoolingPanel_RadiantConvective_Water_ControlType)Enum.Parse(typeof(ZoneHVAC_CoolingPanel_RadiantConvective_Water_ControlType), "MeanAirTemperature");
        

        [JsonProperty("cooling_control_throttling_range")]
        public System.Nullable<float> CoolingControlThrottlingRange { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_control_temperature_schedule_name")]
        public string CoolingControlTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("condensation_control_type")]
        public ZoneHVAC_CoolingPanel_RadiantConvective_Water_CondensationControlType CondensationControlType { get; set; } = (ZoneHVAC_CoolingPanel_RadiantConvective_Water_CondensationControlType)Enum.Parse(typeof(ZoneHVAC_CoolingPanel_RadiantConvective_Water_CondensationControlType), "SimpleOff");
        

        [JsonProperty("condensation_control_dewpoint_offset")]
        public System.Nullable<float> CondensationControlDewpointOffset { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("fraction_radiant")]
        public System.Nullable<float> FractionRadiant { get; set; } = null;
        

        [JsonProperty("fraction_of_radiant_energy_incident_on_people")]
        public System.Nullable<float> FractionOfRadiantEnergyIncidentOnPeople { get; set; } = null;
        

        [JsonProperty("surface_fractions")]
        public string SurfaceFractions { get; set; } = "";
    }
}