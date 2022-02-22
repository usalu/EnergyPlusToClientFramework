using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("Hot water baseboard heater, convection-only. Natural convection hydronic heating " +
                 "unit.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_Baseboard_Convective_Water : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("inlet_node_name")]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty("outlet_node_name")]
        public string OutletNodeName { get; set; } = "";
        

        [Description(@"Enter the method used to determine the heating design capacity. HeatingDesignCapacity = > selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea = > selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity = > is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
        [JsonProperty("heating_design_capacity_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_Baseboard_Convective_Water_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_Baseboard_Convective_Water_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_Baseboard_Convective_Water_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

        [Description("Enter the design heating capacity. Required field when the heating design capacit" +
                     "y method HeatingDesignCapacity.")]
        [JsonProperty("heating_design_capacity")]
        public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Enter the heating design capacity per zone floor area. Required field when the he" +
                     "ating design capacity method field is CapacityPerFloorArea.")]
        [JsonProperty("heating_design_capacity_per_floor_area")]
        public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of autosized heating design capacity. Required field when capa" +
                     "city the heating design capacity method field is FractionOfAutosizedHeatingCapac" +
                     "ity.")]
        [JsonProperty("fraction_of_autosized_heating_design_capacity")]
        public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("u_factor_times_area_value")]
        public string UFactorTimesAreaValue { get; set; } = "";
        

        [JsonProperty("maximum_water_flow_rate")]
        public string MaximumWaterFlowRate { get; set; } = "";
        

        [JsonProperty("convergence_tolerance")]
        public System.Nullable<float> ConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
    }
}