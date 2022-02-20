using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description("Specifies the input needed to perform sizing calculations for a central forced ai" +
                 "r system. System design air flow, heating capacity, and cooling capacity will be" +
                 " calculated using this input data.")]
    [JsonObject("Sizing:System")]
    public class Sizing_System : BHoMObject
    {
        

        [JsonProperty("airloop_name")]
        public string AirloopName { get; set; } = "";
        

        [Description(@"Specifies the basis for sizing the system supply air flow rate Sensible and Total use the zone design air flow rates to size the system supply air flow rate The cooling coil will then be sized at either the peak Sensible or Total flow rate and conditions The heating coil is always sized at the peak sensible heating load. VentilationRequirement uses the system ventilation requirement")]
        [JsonProperty("type_of_load_to_size_on")]
        public EmptyNoYes TypeOfLoadToSizeOn { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Sensible");
        

        [JsonProperty("design_outdoor_air_flow_rate")]
        public string DesignOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("central_heating_maximum_system_air_flow_ratio")]
        public string CentralHeatingMaximumSystemAirFlowRatio { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("preheat_design_temperature")]
        public System.Nullable<float> PreheatDesignTemperature { get; set; } = null;
        

        [JsonProperty("preheat_design_humidity_ratio")]
        public System.Nullable<float> PreheatDesignHumidityRatio { get; set; } = null;
        

        [JsonProperty("precool_design_temperature")]
        public System.Nullable<float> PrecoolDesignTemperature { get; set; } = null;
        

        [JsonProperty("precool_design_humidity_ratio")]
        public System.Nullable<float> PrecoolDesignHumidityRatio { get; set; } = null;
        

        [JsonProperty("central_cooling_design_supply_air_temperature")]
        public System.Nullable<float> CentralCoolingDesignSupplyAirTemperature { get; set; } = null;
        

        [JsonProperty("central_heating_design_supply_air_temperature")]
        public System.Nullable<float> CentralHeatingDesignSupplyAirTemperature { get; set; } = null;
        

        [JsonProperty("type_of_zone_sum_to_use")]
        public EmptyNoYes TypeOfZoneSumToUse { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "NonCoincident");
        

        [JsonProperty("100_outdoor_air_in_cooling")]
        public EmptyNoYes _100OutdoorAirInCooling { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("100_outdoor_air_in_heating")]
        public EmptyNoYes _100OutdoorAirInHeating { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("central_cooling_design_supply_air_humidity_ratio")]
        public System.Nullable<float> CentralCoolingDesignSupplyAirHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

        [JsonProperty("central_heating_design_supply_air_humidity_ratio")]
        public System.Nullable<float> CentralHeatingDesignSupplyAirHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_supply_air_flow_rate_method")]
        public EmptyNoYes CoolingSupplyAirFlowRateMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "DesignDay");
        

        [Description("This input is used if Cooling Supply Air Flow Rate Method is Flow/System This val" +
                     "ue will *not* be multiplied by any sizing factor or by zone multipliers. If usin" +
                     "g zone multipliers, this value must be large enough to serve the multiplied zone" +
                     "s.")]
        [JsonProperty("cooling_supply_air_flow_rate")]
        public System.Nullable<float> CoolingSupplyAirFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the cooling supply air volume flow rate per total conditioned floor area. R" +
                     "equired field when Cooling Supply Air Flow Rate Method is FlowPerFloorArea.")]
        [JsonProperty("cooling_supply_air_flow_rate_per_floor_area")]
        public System.Nullable<float> CoolingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flo" +
                     "w rate. Required field when Cooling Supply Air Flow Rate Method is FractionOfAut" +
                     "osizedCoolingAirflow.")]
        [JsonProperty("cooling_fraction_of_autosized_cooling_supply_air_flow_rate")]
        public System.Nullable<float> CoolingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate per unit cooling capacity. Required field w" +
                     "hen Cooling Supply Air Flow Rate Method is FlowPerCoolingCapacity.")]
        [JsonProperty("cooling_supply_air_flow_rate_per_unit_cooling_capacity")]
        public System.Nullable<float> CoolingSupplyAirFlowRatePerUnitCoolingCapacity { get; set; } = null;
        

        [JsonProperty("heating_supply_air_flow_rate_method")]
        public EmptyNoYes HeatingSupplyAirFlowRateMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "DesignDay");
        

        [Description("Required field when Heating Supply Air Flow Rate Method is Flow/System This value" +
                     " will *not* be multiplied by any sizing factor or by zone multipliers. If using " +
                     "zone multipliers, this value must be large enough to serve the multiplied zones." +
                     "")]
        [JsonProperty("heating_supply_air_flow_rate")]
        public System.Nullable<float> HeatingSupplyAirFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the heating supply air volume flow rate per total conditioned floor area. R" +
                     "equired field when Heating Supply Air Flow Rate Method is FlowPerFloorArea.")]
        [JsonProperty("heating_supply_air_flow_rate_per_floor_area")]
        public System.Nullable<float> HeatingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate as a fraction of the heating supply air flo" +
                     "w rate. Required field when Heating Supply Air Flow Rate Method is FractionOfAut" +
                     "osizedHeatingAirflow.")]
        [JsonProperty("heating_fraction_of_autosized_heating_supply_air_flow_rate")]
        public System.Nullable<float> HeatingFractionOfAutosizedHeatingSupplyAirFlowRate { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flo" +
                     "w rate. Required field when Heating Supply Air Flow Rate Method is FractionOfAut" +
                     "osizedCoolingAirflow.")]
        [JsonProperty("heating_fraction_of_autosized_cooling_supply_air_flow_rate")]
        public System.Nullable<float> HeatingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = null;
        

        [Description("Enter the heating supply air volume flow rate per unit heating capacity. Required" +
                     " field when Heating Supply Air Flow Rate Method is FlowPerHeatingCapacity.")]
        [JsonProperty("heating_supply_air_flow_rate_per_unit_heating_capacity")]
        public System.Nullable<float> HeatingSupplyAirFlowRatePerUnitHeatingCapacity { get; set; } = null;
        

        [JsonProperty("system_outdoor_air_method")]
        public EmptyNoYes SystemOutdoorAirMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ZoneSum");
        

        [JsonProperty("zone_maximum_outdoor_air_fraction")]
        public System.Nullable<float> ZoneMaximumOutdoorAirFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the method used to determine the system cooling design capacity for scalable sizing. None is used when a cooling coils is not included in an airloop or this field may be blank. If this input field is left blank, then the design cooling capacity is set to zero. CoolingDesignCapacity => selected when the design cooling capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determined from user specified cooling capacity per floor area and total floor area of cooled zones served by an airloop. FractionOfAutosizedCoolingCapacity => is selected when the design cooling capacity is determined from a user specified fraction and the auto-sized design cooling capacity of the system.")]
        [JsonProperty("cooling_design_capacity_method")]
        public EmptyNoYes CoolingDesignCapacityMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "CoolingDesignCapacity");
        

        [Description("Enter the design cooling capacity.")]
        [JsonProperty("cooling_design_capacity")]
        public string CoolingDesignCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Enter the cooling design capacity per total floor area of cooled zones served by " +
                     "an airloop. Required field when the cooling design capacity method field is Capa" +
                     "cityPerFloorArea.")]
        [JsonProperty("cooling_design_capacity_per_floor_area")]
        public System.Nullable<float> CoolingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of auto-sized cooling design capacity. Required field when the" +
                     " cooling design capacity method field is FractionOfAutosizedCoolingCapacity.")]
        [JsonProperty("fraction_of_autosized_cooling_design_capacity")]
        public System.Nullable<float> FractionOfAutosizedCoolingDesignCapacity { get; set; } = null;
        

        [Description(@"Enter the method used to determine the heating design capacity for scalable sizing. None is used when a heating coil not included in an airloop or this field may be blank. If this input field is left blank, then the design heating capacity is set to zero. HeatingDesignCapacity => selected when the design heating capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design heating capacity is determined from user specified heating capacity per flow area and total floor area of heated zones served by an airloop. FractionOfAutosizedHeatingCapacity => is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity of the system.")]
        [JsonProperty("heating_design_capacity_method")]
        public EmptyNoYes HeatingDesignCapacityMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "HeatingDesignCapacity");
        

        [Description("Enter the design heating capacity.")]
        [JsonProperty("heating_design_capacity")]
        public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Enter the heating design capacity per zone floor area. Required field when the he" +
                     "ating design capacity method field is CapacityPerFloorArea.")]
        [JsonProperty("heating_design_capacity_per_floor_area")]
        public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of auto-sized heating design capacity. Required field when cap" +
                     "acity the heating design capacity method field is FractionOfAutosizedHeatingCapa" +
                     "city.")]
        [JsonProperty("fraction_of_autosized_heating_design_capacity")]
        public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = null;
        

        [Description("Method used to control the coil\'s output")]
        [JsonProperty("central_cooling_capacity_control_method")]
        public EmptyNoYes CentralCoolingCapacityControlMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "OnOff");
    }
}