using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Plant and condenser loops to serve all HVACTemplate chilled water coils, chillers" +
                 ", and towers.")]
    public class HVACTemplate_Plant_ChilledWaterLoop : BHoMObject, IEnergyPlusClass
    {
        

        [Description("If blank, always available Applies to both chilled water and condenser loop pumps" +
                     "")]
        [JsonProperty("pump_schedule_name")]
        public string PumpScheduleName { get; set; } = "";
        

        [Description("Applies to both chilled water and condenser loop pumps")]
        [JsonProperty("pump_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_ChilledWaterLoop_PumpControlType PumpControlType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_PumpControlType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_PumpControlType), "Intermittent");
        

        [Description("Default operation type makes all equipment available at all times operating in or" +
                     "der of Priority specified in HVACTemplate:Plant:Chiller objects.")]
        [JsonProperty("chiller_plant_operation_scheme_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_ChilledWaterLoop_ChillerPlantOperationSchemeType ChillerPlantOperationSchemeType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_ChillerPlantOperationSchemeType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_ChillerPlantOperationSchemeType), "Default");
        

        [Description("Name of a PlantEquipmentOperationSchemes object Ignored if Chiller Plant Operatio" +
                     "n Scheme Type = Default")]
        [JsonProperty("chiller_plant_equipment_operation_schemes_name")]
        public string ChillerPlantEquipmentOperationSchemesName { get; set; } = "";
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty("chilled_water_setpoint_schedule_name")]
        public string ChilledWaterSetpointScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Chilled Water Setpoint Schedule Na" +
                     "me is specified.")]
        [JsonProperty("chilled_water_design_setpoint")]
        public System.Nullable<float> ChilledWaterDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("7.22", CultureInfo.InvariantCulture);
        

        [Description(@"VariablePrimaryNoSecondary - variable flow to chillers and coils ConstantPrimaryNoSecondary - constant flow to chillers and coils, excess bypassed ConstantPrimaryVariableSecondary - constant flow to chillers, variable flow to coils VariablePrimaryConstantSecondary - currently unsupported - variable flow to chillers, constant flow to coils")]
        [JsonProperty("chilled_water_pump_configuration")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPumpConfiguration ChilledWaterPumpConfiguration { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPumpConfiguration)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPumpConfiguration), "ConstantPrimaryNoSecondary");
        

        [Description("default head is 60 feet H2O")]
        [JsonProperty("primary_chilled_water_pump_rated_head")]
        public System.Nullable<float> PrimaryChilledWaterPumpRatedHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

        [Description("default head is 60 feet H2O")]
        [JsonProperty("secondary_chilled_water_pump_rated_head")]
        public System.Nullable<float> SecondaryChilledWaterPumpRatedHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

        [Description("Default operation type makes all equipment available at all times operating in or" +
                     "der of Priority specified in HVACTemplate:Plant:Tower objects. May be left blank" +
                     " if not serving any water cooled chillers")]
        [JsonProperty("condenser_plant_operation_scheme_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_ChilledWaterLoop_CondenserPlantOperationSchemeType CondenserPlantOperationSchemeType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_CondenserPlantOperationSchemeType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_CondenserPlantOperationSchemeType), "Default");
        

        [Description("Name of a CondenserEquipmentOperationSchemes object Ignored if Condenser Plant Op" +
                     "eration Scheme Type = Default May be left blank if not serving any water cooled " +
                     "chillers")]
        [JsonProperty("condenser_equipment_operation_schemes_name")]
        public string CondenserEquipmentOperationSchemesName { get; set; } = "";
        

        [Description("May be left blank if not serving any water cooled chillers")]
        [JsonProperty("condenser_water_temperature_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterTemperatureControlType CondenserWaterTemperatureControlType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterTemperatureControlType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterTemperatureControlType), "OutdoorWetBulbTemperature");
        

        [Description("Leave blank if constant setpoint May be left blank if not serving any water coole" +
                     "d chillers")]
        [JsonProperty("condenser_water_setpoint_schedule_name")]
        public string CondenserWaterSetpointScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Condenser Water Setpoint Schedule " +
                     "Name is specified. May be left blank if not serving any water cooled chillers")]
        [JsonProperty("condenser_water_design_setpoint")]
        public System.Nullable<float> CondenserWaterDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("29.4", CultureInfo.InvariantCulture);
        

        [Description("May be left blank if not serving any water cooled chillers default head is 60 fee" +
                     "t H2O")]
        [JsonProperty("condenser_water_pump_rated_head")]
        public System.Nullable<float> CondenserWaterPumpRatedHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

        [Description("Overrides Chilled Water Setpoint Schedule Name")]
        [JsonProperty("chilled_water_setpoint_reset_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSetpointResetType ChilledWaterSetpointResetType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSetpointResetType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSetpointResetType), "None");
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("chilled_water_setpoint_at_outdoor_dry_bulb_low")]
        public System.Nullable<float> ChilledWaterSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("12.2", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("chilled_water_reset_outdoor_dry_bulb_low")]
        public System.Nullable<float> ChilledWaterResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15.6", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("chilled_water_setpoint_at_outdoor_dry_bulb_high")]
        public System.Nullable<float> ChilledWaterSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("6.7", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("chilled_water_reset_outdoor_dry_bulb_high")]
        public System.Nullable<float> ChilledWaterResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("26.7", CultureInfo.InvariantCulture);
        

        [Description("Describes the type of pump configuration used for the primary portion of the chil" +
                     "led water loop.")]
        [JsonProperty("chilled_water_primary_pump_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPrimaryPumpType ChilledWaterPrimaryPumpType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPrimaryPumpType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPrimaryPumpType), "SinglePump");
        

        [Description("Describes the type of pump configuration used for the secondary portion of the ch" +
                     "illed water loop.")]
        [JsonProperty("chilled_water_secondary_pump_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSecondaryPumpType ChilledWaterSecondaryPumpType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSecondaryPumpType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSecondaryPumpType), "SinglePump");
        

        [Description("Describes the type of pump configuration used for the condenser water loop.")]
        [JsonProperty("condenser_water_pump_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterPumpType CondenserWaterPumpType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterPumpType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterPumpType), "SinglePump");
        

        [Description("Determines if a supply side bypass pipe is present in the chilled water loop.")]
        [JsonProperty("chilled_water_supply_side_bypass_pipe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ChilledWaterSupplySideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("Determines if a demand side bypass pipe is present in the chilled water loop.")]
        [JsonProperty("chilled_water_demand_side_bypass_pipe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ChilledWaterDemandSideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("Determines if a supply side bypass pipe is present in the condenser water loop.")]
        [JsonProperty("condenser_water_supply_side_bypass_pipe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes CondenserWaterSupplySideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("Determines if a demand side bypass pipe is present in the condenser water loop.")]
        [JsonProperty("condenser_water_demand_side_bypass_pipe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes CondenserWaterDemandSideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("fluid_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_ChilledWaterLoop_FluidType FluidType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_FluidType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_FluidType), "Water");
        

        [Description("The temperature difference used in sizing the loop flow rate.")]
        [JsonProperty("loop_design_delta_temperature")]
        public System.Nullable<float> LoopDesignDeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("6.67", CultureInfo.InvariantCulture);
        

        [Description("The minimum outdoor dry-bulb temperature that the chilled water loops operate. Le" +
                     "ave blank for no limit.")]
        [JsonProperty("minimum_outdoor_dry_bulb_temperature")]
        public System.Nullable<float> MinimumOutdoorDryBulbTemperature { get; set; } = null;
        

        [JsonProperty("chilled_water_load_distribution_scheme")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterLoadDistributionScheme ChilledWaterLoadDistributionScheme { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterLoadDistributionScheme)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterLoadDistributionScheme), "SequentialLoad");
        

        [JsonProperty("condenser_water_load_distribution_scheme")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterLoadDistributionScheme CondenserWaterLoadDistributionScheme { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterLoadDistributionScheme)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterLoadDistributionScheme), "SequentialLoad");
    }
}