using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Central plant loop portion of a water source heat pump system.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_Plant_MixedWaterLoop : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("If blank, always available Applies to both chilled water and condenser loop pumps" +
                     "")]
        [JsonProperty("pump_schedule_name")]
        public string PumpScheduleName { get; set; } = "";
        

        [Description("Applies to both chilled water and condenser loop pumps")]
        [JsonProperty("pump_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_MixedWaterLoop_PumpControlType PumpControlType { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_PumpControlType)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_PumpControlType), "Intermittent");
        

        [Description("Default operation type makes all equipment available at all times operating in or" +
                     "der of Priority specified in HVACTemplate:Plant:Boiler and HVACTemplate:Plant:To" +
                     "wer objects.")]
        [JsonProperty("operation_scheme_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_MixedWaterLoop_OperationSchemeType OperationSchemeType { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_OperationSchemeType)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_OperationSchemeType), "Default");
        

        [Description("Name of a PlantEquipmentOperationSchemes object Ignored if Plant Operation Scheme" +
                     " Type = Default")]
        [JsonProperty("equipment_operation_schemes_name")]
        public string EquipmentOperationSchemesName { get; set; } = "";
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty("high_temperature_setpoint_schedule_name")]
        public string HighTemperatureSetpointScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Setpoint Schedule Name is specifie" +
                     "d.")]
        [JsonProperty("high_temperature_design_setpoint")]
        public System.Nullable<float> HighTemperatureDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("33", CultureInfo.InvariantCulture);
        

        [Description("Leave blank if constant setpoint May be left blank if not serving any water coole" +
                     "d chillers")]
        [JsonProperty("low_temperature_setpoint_schedule_name")]
        public string LowTemperatureSetpointScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Condenser Water Setpoint Schedule " +
                     "Name is specified. May be left blank if not serving any water cooled chillers")]
        [JsonProperty("low_temperature_design_setpoint")]
        public System.Nullable<float> LowTemperatureDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

        [Description("VariableFlow - variable flow to boilers and coils, excess bypassed ConstantFlow -" +
                     " constant flow to boilers and coils, excess bypassed")]
        [JsonProperty("water_pump_configuration")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_MixedWaterLoop_WaterPumpConfiguration WaterPumpConfiguration { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_WaterPumpConfiguration)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_WaterPumpConfiguration), "ConstantFlow");
        

        [Description("May be left blank if not serving any water cooled chillers default head is 60 fee" +
                     "t H2O")]
        [JsonProperty("water_pump_rated_head")]
        public System.Nullable<float> WaterPumpRatedHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

        [Description("Describes the type of pump configuration used for the mixed water loop.")]
        [JsonProperty("water_pump_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_MixedWaterLoop_WaterPumpType WaterPumpType { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_WaterPumpType)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_WaterPumpType), "SinglePump");
        

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
        public HVACTemplate_Plant_MixedWaterLoop_FluidType FluidType { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_FluidType)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_FluidType), "Water");
        

        [Description("The temperature difference used in sizing the loop flow rate.")]
        [JsonProperty("loop_design_delta_temperature")]
        public System.Nullable<float> LoopDesignDeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("5.6", CultureInfo.InvariantCulture);
        

        [JsonProperty("load_distribution_scheme")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_MixedWaterLoop_LoadDistributionScheme LoadDistributionScheme { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_LoadDistributionScheme)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_LoadDistributionScheme), "SequentialLoad");
    }
}