using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description(@"Specifies the data needed to perform a zone design air flow calculation. The calculation is done for every sizing period included in the input. The maximum cooling and heating load and cooling, heating, and ventilation air flows are then saved for system level and zone component design calculations.")]
    [JsonObject("Sizing:Zone")]
    public class Sizing_Zone : BHoMObject
    {
        

        [JsonProperty("zone_or_zonelist_name")]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
        public EmptyNoYes ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "SupplyAirTemperature");
        

        [Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty("zone_cooling_design_supply_air_temperature")]
        public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = null;
        

        [Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
        [JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
        public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = null;
        

        [JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
        public EmptyNoYes ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "SupplyAirTemperature");
        

        [Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty("zone_heating_design_supply_air_temperature")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = null;
        

        [Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
        [JsonProperty("zone_heating_design_supply_air_temperature_difference")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = null;
        

        [JsonProperty("zone_cooling_design_supply_air_humidity_ratio")]
        public System.Nullable<float> ZoneCoolingDesignSupplyAirHumidityRatio { get; set; } = null;
        

        [JsonProperty("zone_heating_design_supply_air_humidity_ratio")]
        public System.Nullable<float> ZoneHeatingDesignSupplyAirHumidityRatio { get; set; } = null;
        

        [JsonProperty("design_specification_outdoor_air_object_name")]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description("if blank or zero, global heating sizing factor from Sizing:Parameters is used.")]
        [JsonProperty("zone_heating_sizing_factor")]
        public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

        [Description("if blank or zero, global cooling sizing factor from Sizing:Parameters is used.")]
        [JsonProperty("zone_cooling_sizing_factor")]
        public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

        [JsonProperty("cooling_design_air_flow_method")]
        public EmptyNoYes CoolingDesignAirFlowMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "DesignDay");
        

        [Description("This input is used if Cooling Design Air Flow Method is Flow/Zone This value will" +
                     " be multiplied by the global or zone sizing factor and by zone multipliers.")]
        [JsonProperty("cooling_design_air_flow_rate")]
        public System.Nullable<float> CoolingDesignAirFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("default is .15 cfm/ft2 This input is used if Cooling Design Air Flow Method is De" +
                     "signDayWithLimit")]
        [JsonProperty("cooling_minimum_air_flow_per_zone_floor_area")]
        public System.Nullable<float> CoolingMinimumAirFlowPerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0.000762", CultureInfo.InvariantCulture);
        

        [Description("This input is used if Cooling Design Air Flow Method is DesignDayWithLimit")]
        [JsonProperty("cooling_minimum_air_flow")]
        public System.Nullable<float> CoolingMinimumAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("fraction of the Cooling design Air Flow Rate This input is currently used in sizi" +
                     "ng the VAV air terminal unit and fan minimum flow rate It does not currently aff" +
                     "ect other component autosizing.")]
        [JsonProperty("cooling_minimum_air_flow_fraction")]
        public System.Nullable<float> CoolingMinimumAirFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_design_air_flow_method")]
        public EmptyNoYes HeatingDesignAirFlowMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "DesignDay");
        

        [Description("This input is used if Heating Design Air Flow Method is Flow/Zone. This value wil" +
                     "l be multiplied by the global or zone sizing factor and by zone multipliers.")]
        [JsonProperty("heating_design_air_flow_rate")]
        public System.Nullable<float> HeatingDesignAirFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("default is .40 cfm/ft2 This field is used to size the heating design flow rate wh" +
                     "en Heating Design Air Flow Method = Flow/Zone. This input is used for autosizing" +
                     " components when Heating Design Air Flow Method = DesignDayWithLimit.")]
        [JsonProperty("heating_maximum_air_flow_per_zone_floor_area")]
        public System.Nullable<float> HeatingMaximumAirFlowPerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0.002032", CultureInfo.InvariantCulture);
        

        [Description("default is 300 cfm This input is used for autosizing components when Heating Desi" +
                     "gn Air Flow Method = DesignDayWithLimit.")]
        [JsonProperty("heating_maximum_air_flow")]
        public System.Nullable<float> HeatingMaximumAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0.1415762", CultureInfo.InvariantCulture);
        

        [Description("fraction of the Heating Design Air Flow Rate This input is used for autosizing co" +
                     "mponents when Heating Design Air Flow Method = DesignDayWithLimit.")]
        [JsonProperty("heating_maximum_air_flow_fraction")]
        public System.Nullable<float> HeatingMaximumAirFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

        [JsonProperty("design_specification_zone_air_distribution_object_name")]
        public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

        [Description("account for effect of dedicated outdoor air system supplying air directly to the " +
                     "zone")]
        [JsonProperty("account_for_dedicated_outdoor_air_system")]
        public EmptyNoYes AccountForDedicatedOutdoorAirSystem { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("1)supply neutral ventilation air; 2)supply neutral dehumidified and reheated vent" +
                     "ilation air; 3)supply cold ventilation air")]
        [JsonProperty("dedicated_outdoor_air_system_control_strategy")]
        public EmptyNoYes DedicatedOutdoorAirSystemControlStrategy { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "NeutralSupplyAir");
        

        [JsonProperty("dedicated_outdoor_air_low_setpoint_temperature_for_design")]
        public string DedicatedOutdoorAirLowSetpointTemperatureForDesign { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("dedicated_outdoor_air_high_setpoint_temperature_for_design")]
        public string DedicatedOutdoorAirHighSetpointTemperatureForDesign { get; set; } = (System.String)"Autosize";
    }
}