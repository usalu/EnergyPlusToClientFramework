using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description("This object is used to describe general scalable zone HVAC equipment sizing which" +
                 " are referenced by other objects.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DesignSpecification_ZoneHVAC_Sizing : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description(@"Enter the method used to determine the cooling supply air volume flow rate. None is used when a cooling coil is not included in the Zone HVAC Equip or this field may be blank. SupplyAirFlowRate => selected when the magnitude of the supply air volume flow rate is specified. FlowPerFloorArea => selected when the supply air volume flow rate is determined from total floor area served by the Zone HVAC unit and Flow Per Floor Area value specified. FractionOfAutosizedCoolingAirflow => is selected when the supply air volume is determined from a user specified fraction and the autosized cooling supply air flow rate value determined by the simulation. FlowPerCoolingCapacity => is selected when the supply air volume is determined from user specified flow per Cooling Capacity and Cooling Capacity determined by the simulation.")]
        [JsonProperty("cooling_supply_air_flow_rate_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DesignSpecification_ZoneHVAC_Sizing_CoolingSupplyAirFlowRateMethod CoolingSupplyAirFlowRateMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_CoolingSupplyAirFlowRateMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_CoolingSupplyAirFlowRateMethod), "SupplyAirFlowRate");
        

        [Description("Enter the magnitude of supply air volume flow rate during cooling operation. Requ" +
                     "ired field when Cooling Supply Air Flow Rate Method is SupplyAirFlowRate. This f" +
                     "ield may be blank if a cooling coil is not included in the Zone HVAC equipment.")]
        [JsonProperty("cooling_supply_air_flow_rate")]
        public string CoolingSupplyAirFlowRate { get; set; } = "";
        

        [Description("Enter the cooling supply air volume flow rate per total conditioned floor area. R" +
                     "equired field when Cooling Supply Air Flow Rate Method is FlowPerFloorArea. This" +
                     " field may be blank if a cooling coil is not included in the Zone HVAC equipment" +
                     ".")]
        [JsonProperty("cooling_supply_air_flow_rate_per_floor_area")]
        public System.Nullable<float> CoolingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

        [Description(@"Enter the supply air volume flow rate as a fraction of the cooling supply air flow rate. Required field when Cooling Supply Air Flow Rate Method is FractionOfAutosizedCoolingAirflow. This field may be blank if a cooling coil is not included in the Zone HVAC equipment.")]
        [JsonProperty("cooling_fraction_of_autosized_cooling_supply_air_flow_rate")]
        public System.Nullable<float> CoolingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = null;
        

        [Description("Enter the cooling supply air volume flow rate unit cooling capacity. Required fie" +
                     "ld when Cooling Supply Air Flow Rate Method is FlowPerCoolingCapacity. This fiel" +
                     "d may be blank if a cooling coil is not included in the Zone HVAC equipment.")]
        [JsonProperty("cooling_supply_air_flow_rate_per_unit_cooling_capacity")]
        public System.Nullable<float> CoolingSupplyAirFlowRatePerUnitCoolingCapacity { get; set; } = null;
        

        [Description(@"Enter the method used to determine the supply air volume flow rate When No Cooling or Heating is Required. None is used when a cooling or heating coil is not included in the Zone HVAC Equipment or this field may be blank. SupplyAirFlowRate => selected when the magnitude of the supply air volume flow rate is specified. FlowPerFloorArea => selected when the supply air volume flow rate is determined from total floor area served by the Zone HVAC unit and Flow Per Floor Area is specified. FractionOfAutosizedCoolingAirflow => is selected when the supply air volume is determined from a user specified fraction and the Autosized cooling supply air flow rate value determined by the simulation. FractionOfAutosizedHeatingAirflow => is selected when the supply air volume is determined from a user specified fraction and the Autosized heating supply air flow rate value determined by the simulation.")]
        [JsonProperty("no_load_supply_air_flow_rate_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DesignSpecification_ZoneHVAC_Sizing_NoLoadSupplyAirFlowRateMethod NoLoadSupplyAirFlowRateMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_NoLoadSupplyAirFlowRateMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_NoLoadSupplyAirFlowRateMethod), "SupplyAirFlowRate");
        

        [Description("Enter the magnitude of the supply air volume flow rate during when no cooling or " +
                     "heating is required. Required field when No Load Supply Air Flow Rate Method is " +
                     "SupplyAirFlowRate.")]
        [JsonProperty("no_load_supply_air_flow_rate")]
        public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

        [Description("Enter the supply air volume flow rate per total floor area. Required field when N" +
                     "o Load Supply Air Flow Rate Method is FlowPerFloorArea.")]
        [JsonProperty("no_load_supply_air_flow_rate_per_floor_area")]
        public System.Nullable<float> NoLoadSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flo" +
                     "w rate. Required field when No Load Supply Air Flow Rate Method is FractionOfAut" +
                     "osizedCoolingAirflow.")]
        [JsonProperty("no_load_fraction_of_cooling_supply_air_flow_rate")]
        public System.Nullable<float> NoLoadFractionOfCoolingSupplyAirFlowRate { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate as a fraction of the heating supply air flo" +
                     "w rate. Required field when No Load Supply Air Flow Rate Method is FractionOfAut" +
                     "osizedHeatingAirflow.")]
        [JsonProperty("no_load_fraction_of_heating_supply_air_flow_rate")]
        public System.Nullable<float> NoLoadFractionOfHeatingSupplyAirFlowRate { get; set; } = null;
        

        [Description(@"Enter the method used to determine the heating supply air volume flow rate. None is used when a heating coil is not included in the Zone HVAC Equipment or this field may be blank. SupplyAirFlowRate => selected when the magnitude of the heating supply air volume flow rate is specified. FlowPerFloorArea => selected when the supply air volume flow rate is determined from total floor area served by a Zone HVAC unit and user specified value of Flow Per Floor Area. FractionOfAutosizedHeatingAirflow => is selected when the supply air volume is determined from a user specified fraction and the Autosized heating supply air flow rate value determined by the simulation. FlowPerHeatingCapacity => is selected when the supply air volume is determined from user specified flow per Heating Capacity and Heating Capacity determined by the simulation.")]
        [JsonProperty("heating_supply_air_flow_rate_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DesignSpecification_ZoneHVAC_Sizing_HeatingSupplyAirFlowRateMethod HeatingSupplyAirFlowRateMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_HeatingSupplyAirFlowRateMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_HeatingSupplyAirFlowRateMethod), "SupplyAirFlowRate");
        

        [Description("Enter the magnitude of the supply air volume flow rate during heating operation. " +
                     "Required field when Heating Supply Air Flow Rate Method is SupplyAirFlowRate. Th" +
                     "is field may be blank if a heating coil is not included in the Zone HVAC equipme" +
                     "nt.")]
        [JsonProperty("heating_supply_air_flow_rate")]
        public string HeatingSupplyAirFlowRate { get; set; } = "";
        

        [Description("Enter the heating supply air volume flow rate per total conditioned floor area. R" +
                     "equired field when Heating Supply Air Flow Rate Method is FlowPerFloorArea. This" +
                     " field may be blank if a heating coil is not included in the Zone HVAC equipment" +
                     ".")]
        [JsonProperty("heating_supply_air_flow_rate_per_floor_area")]
        public System.Nullable<float> HeatingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

        [Description(@"Enter the supply air volume flow rate as a fraction of the heating supply air flow rate. Required field when Heating Supply Air Flow Rate Method is FractionOfAutosizedHeatingAirflow. This field may be blank if a heating coil is not included in the Zone HVAC equipment.")]
        [JsonProperty("heating_fraction_of_heating_supply_air_flow_rate")]
        public System.Nullable<float> HeatingFractionOfHeatingSupplyAirFlowRate { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate per unit heating capacity. Required field w" +
                     "hen Heating Supply Air Flow Rate Method is FlowPerHeatingCapacity. This field ma" +
                     "y be blank if a heating coil is not included in the Zone HVAC equipment.")]
        [JsonProperty("heating_supply_air_flow_rate_per_unit_heating_capacity")]
        public System.Nullable<float> HeatingSupplyAirFlowRatePerUnitHeatingCapacity { get; set; } = null;
        

        [Description(@"Enter the method used to determine the cooling design capacity for scalable sizing. None is used when a cooling coils is not included in the Zone HVAC Equipment or this field may be blank. If this input field is left blank, then the design cooling capacity is set to zero. CoolingDesignCapacity => selected when the design cooling capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determine from user specified cooling capacity per floor area and zone floor area. FractionOfAutosizedCoolingCapacity => is selected when the design cooling capacity is determined from a user specified fraction and the auto-sized design cooling capacity.")]
        [JsonProperty("cooling_design_capacity_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DesignSpecification_ZoneHVAC_Sizing_CoolingDesignCapacityMethod CoolingDesignCapacityMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_CoolingDesignCapacityMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_CoolingDesignCapacityMethod), "None");
        

        [Description("Enter the design cooling capacity. Required field when the cooling design capacit" +
                     "y method CoolingDesignCapacity.")]
        [JsonProperty("cooling_design_capacity")]
        public string CoolingDesignCapacity { get; set; } = "";
        

        [Description("Enter the cooling design capacity per zone floor area. Required field when the co" +
                     "oling design capacity method field is CapacityPerFloorArea.")]
        [JsonProperty("cooling_design_capacity_per_floor_area")]
        public System.Nullable<float> CoolingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of auto-sized cooling design capacity. Required field when the" +
                     " cooling design capacity method field is FractionOfAutosizedCoolingCapacity.")]
        [JsonProperty("fraction_of_autosized_cooling_design_capacity")]
        public System.Nullable<float> FractionOfAutosizedCoolingDesignCapacity { get; set; } = null;
        

        [Description(@"Enter the method used to determine the heating design capacity for scalable sizing. None is used when a heating coil is not included in the Zone HVAC Equipment or this field may be blank. If this input field is left blank, then the design heating capacity is set to zero. HeatingDesignCapacity => selected when the design heating capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determine from user specified heating capacity per flow area and zone floor area. FractionOfAutosizedHeatingCapacity => is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity")]
        [JsonProperty("heating_design_capacity_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DesignSpecification_ZoneHVAC_Sizing_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_HeatingDesignCapacityMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_HeatingDesignCapacityMethod), "None");
        

        [Description("Enter the design heating capacity. Required field when the heating design capacit" +
                     "y method HeatingDesignCapacity.")]
        [JsonProperty("heating_design_capacity")]
        public string HeatingDesignCapacity { get; set; } = "";
        

        [Description("Enter the heating design capacity per zone floor area. Required field when the he" +
                     "ating design capacity method field is CapacityPerFloorArea.")]
        [JsonProperty("heating_design_capacity_per_floor_area")]
        public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of auto-sized heating design capacity. Required field when cap" +
                     "acity the heating design capacity method field is FractionOfAutosizedHeatingCapa" +
                     "city.")]
        [JsonProperty("fraction_of_autosized_heating_design_capacity")]
        public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = null;
    }
}