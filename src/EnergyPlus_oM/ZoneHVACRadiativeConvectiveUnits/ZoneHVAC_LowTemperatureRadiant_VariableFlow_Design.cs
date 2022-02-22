using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description(null)]
    public class ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"This parameter identifies how the heat transfer between fluid being circulated through the radiant system and the radiant system (slab) is modeled. ConvectionOnly means that only convection between the fluid and the inside surface of the pipe is modeled using a conventional equation for flow inside a pipe. ISOStandard models convection between the fluid and the inside of of the pipe and conduction through the pipe material using equations specific to ISO Standard 11855-2.")]
        [JsonProperty("fluid_to_radiant_surface_heat_transfer_model")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_FluidToRadiantSurfaceHeatTransferModel FluidToRadiantSurfaceHeatTransferModel { get; set; } = (ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_FluidToRadiantSurfaceHeatTransferModel)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_FluidToRadiantSurfaceHeatTransferModel), "ConvectionOnly");
        

        [JsonProperty("hydronic_tubing_inside_diameter")]
        public System.Nullable<float> HydronicTubingInsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.013", CultureInfo.InvariantCulture);
        

        [JsonProperty("hydronic_tubing_outside_diameter")]
        public System.Nullable<float> HydronicTubingOutsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.016", CultureInfo.InvariantCulture);
        

        [Description("Conductivity of the tubing/piping material")]
        [JsonProperty("hydronic_tubing_conductivity")]
        public System.Nullable<float> HydronicTubingConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.35", CultureInfo.InvariantCulture);
        

        [Description("(Temperature on which unit is controlled)")]
        [JsonProperty("temperature_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_TemperatureControlType TemperatureControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_TemperatureControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_TemperatureControlType), "MeanAirTemperature");
        

        [Description("How setpoint temperature is defined")]
        [JsonProperty("setpoint_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_SetpointControlType SetpointControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_SetpointControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_SetpointControlType), "HalfFlowPower");
        

        [Description(@"Enter the method used to determine the heating design capacity. HeatingDesignCapacity = > selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea = > selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity = > is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
        [JsonProperty("heating_design_capacity_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

        [Description("Enter the heating design capacity per zone floor area. Required field when the he" +
                     "ating design capacity method field is CapacityPerFloorArea.")]
        [JsonProperty("heating_design_capacity_per_floor_area")]
        public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of autosized heating design capacity. Required field when capa" +
                     "city the heating design capacity method field is FractionOfAutosizedHeatingCapac" +
                     "ity.")]
        [JsonProperty("fraction_of_autosized_heating_design_capacity")]
        public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_control_throttling_range")]
        public System.Nullable<float> HeatingControlThrottlingRange { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_control_temperature_schedule_name")]
        public string HeatingControlTemperatureScheduleName { get; set; } = "";
        

        [Description(@"Enter the method used to determine the cooling design capacity for scalable sizing. CoolingDesignCapacity => selected when the design cooling capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determined from user specified cooling capacity per floor area and total floor area of cooled zone served by the hydrolic unit. FractionOfAutosizedCoolingCapacity => is selected when the design cooling capacity is determined from a user specified fraction and the auto-sized design cooling capacity of the system.")]
        [JsonProperty("cooling_design_capacity_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CoolingDesignCapacityMethod CoolingDesignCapacityMethod { get; set; } = (ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CoolingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CoolingDesignCapacityMethod), "CoolingDesignCapacity");
        

        [Description("Enter the cooling design capacity per total floor area of cooled zones served by " +
                     "the unit. Required field when the cooling design capacity method field is Capaci" +
                     "tyPerFloorArea.")]
        [JsonProperty("cooling_design_capacity_per_floor_area")]
        public System.Nullable<float> CoolingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of auto-sized cooling design capacity. Required field when the" +
                     " cooling design capacity method field is FractionOfAutosizedCoolingCapacity.")]
        [JsonProperty("fraction_of_autosized_cooling_design_capacity")]
        public System.Nullable<float> FractionOfAutosizedCoolingDesignCapacity { get; set; } = null;
        

        [JsonProperty("cooling_control_throttling_range")]
        public System.Nullable<float> CoolingControlThrottlingRange { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_control_temperature_schedule_name")]
        public string CoolingControlTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("condensation_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CondensationControlType CondensationControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CondensationControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_CondensationControlType), "SimpleOff");
        

        [JsonProperty("condensation_control_dewpoint_offset")]
        public System.Nullable<float> CondensationControlDewpointOffset { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Changeover delay schedule name for this system. Schedule value <= 0 allows change" +
                     "over with no delay The schedule values are interpretted as hours. If this field " +
                     "is blank, the system allows changeover with no delay")]
        [JsonProperty("changeover_delay_time_period_schedule")]
        public string ChangeoverDelayTimePeriodSchedule { get; set; } = "";
    }
}