using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Plant loop to serve all HVACTemplate hot water coils and boilers.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_Plant_HotWaterLoop : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("If blank, always available")]
        [JsonProperty("pump_schedule_name")]
        public string PumpScheduleName { get; set; } = "";
        

        [JsonProperty("pump_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_HotWaterLoop_PumpControlType PumpControlType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_PumpControlType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_PumpControlType), "Intermittent");
        

        [Description("Default operation type makes all equipment available at all times operating in or" +
                     "der of Priority specified in HVACTemplate:Plant:Boiler objects.")]
        [JsonProperty("hot_water_plant_operation_scheme_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_HotWaterLoop_HotWaterPlantOperationSchemeType HotWaterPlantOperationSchemeType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_HotWaterPlantOperationSchemeType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_HotWaterPlantOperationSchemeType), "Default");
        

        [Description("Name of a PlantEquipmentOperationSchemes object Ignored if Plant Operation Scheme" +
                     " Type = Default")]
        [JsonProperty("hot_water_plant_equipment_operation_schemes_name")]
        public string HotWaterPlantEquipmentOperationSchemesName { get; set; } = "";
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty("hot_water_setpoint_schedule_name")]
        public string HotWaterSetpointScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Setpoint Schedule Name is specifie" +
                     "d.")]
        [JsonProperty("hot_water_design_setpoint")]
        public System.Nullable<float> HotWaterDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("82", CultureInfo.InvariantCulture);
        

        [Description("VariableFlow - variable flow to boilers and coils, excess bypassed ConstantFlow -" +
                     " constant flow to boilers and coils, excess bypassed")]
        [JsonProperty("hot_water_pump_configuration")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_HotWaterLoop_HotWaterPumpConfiguration HotWaterPumpConfiguration { get; set; } = (HVACTemplate_Plant_HotWaterLoop_HotWaterPumpConfiguration)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_HotWaterPumpConfiguration), "ConstantFlow");
        

        [Description("Default head is 60 feet H2O")]
        [JsonProperty("hot_water_pump_rated_head")]
        public System.Nullable<float> HotWaterPumpRatedHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

        [Description("Overrides Hot Water Setpoint Schedule Name")]
        [JsonProperty("hot_water_setpoint_reset_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_HotWaterLoop_HotWaterSetpointResetType HotWaterSetpointResetType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_HotWaterSetpointResetType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_HotWaterSetpointResetType), "None");
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("hot_water_setpoint_at_outdoor_dry_bulb_low")]
        public System.Nullable<float> HotWaterSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("82.2", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("hot_water_reset_outdoor_dry_bulb_low")]
        public System.Nullable<float> HotWaterResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("-6.7", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("hot_water_setpoint_at_outdoor_dry_bulb_high")]
        public System.Nullable<float> HotWaterSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("65.6", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("hot_water_reset_outdoor_dry_bulb_high")]
        public System.Nullable<float> HotWaterResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Describes the type of pump configuration used for the hot water loop.")]
        [JsonProperty("hot_water_pump_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_HotWaterLoop_HotWaterPumpType HotWaterPumpType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_HotWaterPumpType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_HotWaterPumpType), "SinglePump");
        

        [Description("Determines if a supply side bypass pipe is present in the hot water loop.")]
        [JsonProperty("supply_side_bypass_pipe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes SupplySideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("Determines if a demand side bypass pipe is present in the hot water loop.")]
        [JsonProperty("demand_side_bypass_pipe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes DemandSideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("fluid_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_HotWaterLoop_FluidType FluidType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_FluidType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_FluidType), "Water");
        

        [Description("The temperature difference used in sizing the loop flow rate.")]
        [JsonProperty("loop_design_delta_temperature")]
        public System.Nullable<float> LoopDesignDeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("11", CultureInfo.InvariantCulture);
        

        [Description("The maximum outdoor dry-bulb temperature that the hot water loops operate. Leave " +
                     "blank for no limit.")]
        [JsonProperty("maximum_outdoor_dry_bulb_temperature")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperature { get; set; } = null;
        

        [JsonProperty("load_distribution_scheme")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_HotWaterLoop_LoadDistributionScheme LoadDistributionScheme { get; set; } = (HVACTemplate_Plant_HotWaterLoop_LoadDistributionScheme)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_LoadDistributionScheme), "SequentialLoad");
    }
}