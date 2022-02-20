using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Plant loop to serve all HVACTemplate hot water coils and boilers.")]
    [JsonObject("HVACTemplate:Plant:HotWaterLoop")]
    public class HVACTemplate_Plant_HotWaterLoop : BHoMObject
    {
        

        [Description("If blank, always available")]
        [JsonProperty("pump_schedule_name")]
        public string PumpScheduleName { get; set; } = "";
        

        [JsonProperty("pump_control_type")]
        public EmptyNoYes PumpControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Intermittent");
        

        [Description("Default operation type makes all equipment available at all times operating in or" +
                     "der of Priority specified in HVACTemplate:Plant:Boiler objects.")]
        [JsonProperty("hot_water_plant_operation_scheme_type")]
        public EmptyNoYes HotWaterPlantOperationSchemeType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Default");
        

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
        public EmptyNoYes HotWaterPumpConfiguration { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ConstantFlow");
        

        [Description("Default head is 60 feet H2O")]
        [JsonProperty("hot_water_pump_rated_head")]
        public System.Nullable<float> HotWaterPumpRatedHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

        [Description("Overrides Hot Water Setpoint Schedule Name")]
        [JsonProperty("hot_water_setpoint_reset_type")]
        public EmptyNoYes HotWaterSetpointResetType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
        

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
        public EmptyNoYes HotWaterPumpType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "SinglePump");
        

        [Description("Determines if a supply side bypass pipe is present in the hot water loop.")]
        [JsonProperty("supply_side_bypass_pipe")]
        public EmptyNoYes SupplySideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("Determines if a demand side bypass pipe is present in the hot water loop.")]
        [JsonProperty("demand_side_bypass_pipe")]
        public EmptyNoYes DemandSideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("fluid_type")]
        public EmptyNoYes FluidType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Water");
        

        [Description("The temperature difference used in sizing the loop flow rate.")]
        [JsonProperty("loop_design_delta_temperature")]
        public System.Nullable<float> LoopDesignDeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("11", CultureInfo.InvariantCulture);
        

        [Description("The maximum outdoor dry-bulb temperature that the hot water loops operate. Leave " +
                     "blank for no limit.")]
        [JsonProperty("maximum_outdoor_dry_bulb_temperature")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperature { get; set; } = null;
        

        [JsonProperty("load_distribution_scheme")]
        public EmptyNoYes LoadDistributionScheme { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "SequentialLoad");
    }
}