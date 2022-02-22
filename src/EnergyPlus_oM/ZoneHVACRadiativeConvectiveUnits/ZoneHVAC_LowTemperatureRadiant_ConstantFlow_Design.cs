using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description(null)]
    [JsonObject("ZoneHVAC:LowTemperatureRadiant:ConstantFlow:Design")]
    public class ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"This parameter identifies how the heat transfer between fluid being circulated through the radiant system and the radiant system (slab) is modeled. ConvectionOnly means that only convection between the fluid and the inside surface of the pipe is modeled using a conventional equation for flow inside a pipe. ISOStandard models convection between the fluid and the inside of of the pipe and conduction through the pipe material using equations specific to ISO Standard 11855-2.")]
        [JsonProperty("fluid_to_radiant_surface_heat_transfer_model")]
        public ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_FluidToRadiantSurfaceHeatTransferModel FluidToRadiantSurfaceHeatTransferModel { get; set; } = (ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_FluidToRadiantSurfaceHeatTransferModel)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_FluidToRadiantSurfaceHeatTransferModel), "ConvectionOnly");
        

        [JsonProperty("hydronic_tubing_inside_diameter")]
        public System.Nullable<float> HydronicTubingInsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.013", CultureInfo.InvariantCulture);
        

        [JsonProperty("hydronic_tubing_outside_diameter")]
        public System.Nullable<float> HydronicTubingOutsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.016", CultureInfo.InvariantCulture);
        

        [Description("Conductivity of the tubing/piping material")]
        [JsonProperty("hydronic_tubing_conductivity")]
        public System.Nullable<float> HydronicTubingConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.35", CultureInfo.InvariantCulture);
        

        [Description("Temperature used to control system")]
        [JsonProperty("temperature_control_type")]
        public ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_TemperatureControlType TemperatureControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_TemperatureControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_TemperatureControlType), "MeanAirTemperature");
        

        [Description(@"this is the weighting factor in the equation that calculate the running mean outdoor dry-bulb temperature as a weighted average of the previous dayâ€™s running mean outdoor dry-bulb temperature and the previous dayâ€™s average outdoor dry-bulb temperature this value is only used by EnergyPlus when the user elects to use the RunningMeanOutdoorDryBulbTemperature control type")]
        [JsonProperty("running_mean_outdoor_dry_bulb_temperature_weighting_factor")]
        public System.Nullable<float> RunningMeanOutdoorDryBulbTemperatureWeightingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty("motor_efficiency")]
        public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("fraction_of_motor_inefficiencies_to_fluid_stream")]
        public System.Nullable<float> FractionOfMotorInefficienciesToFluidStream { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("condensation_control_type")]
        public ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_CondensationControlType CondensationControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_CondensationControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_CondensationControlType), "SimpleOff");
        

        [JsonProperty("condensation_control_dewpoint_offset")]
        public System.Nullable<float> CondensationControlDewpointOffset { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Changeover delay schedule name for this system. Schedule value <= 0 allows change" +
                     "over with no delay The schedule values are interpretted as hours. If this field " +
                     "is blank, the system allows changeover with no delay")]
        [JsonProperty("changeover_delay_time_period_schedule")]
        public string ChangeoverDelayTimePeriodSchedule { get; set; } = "";
    }
}