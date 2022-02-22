using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager uses one curve to determine the optimum condenser entering " +
                 "water temperature for a given timestep and two other curves to place boundary co" +
                 "nditions on the setpoint value.")]
    public class SetpointManager_CondenserEnteringReset : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("control_variable")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_CondenserEnteringReset_ControlVariable ControlVariable { get; set; } = (SetpointManager_CondenserEnteringReset_ControlVariable)Enum.Parse(typeof(SetpointManager_CondenserEnteringReset_ControlVariable), "Temperature");
        

        [Description("This scheduled setpoint value is only used in a given timestep if the \"Optimized\"" +
                     " Condenser Entering Temperature does not fall within the prescribed boundary con" +
                     "ditions.")]
        [JsonProperty("default_condenser_entering_water_temperature_schedule_name")]
        public string DefaultCondenserEnteringWaterTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("minimum_design_wetbulb_temperature_curve_name")]
        public string MinimumDesignWetbulbTemperatureCurveName { get; set; } = "";
        

        [JsonProperty("minimum_outside_air_wetbulb_temperature_curve_name")]
        public string MinimumOutsideAirWetbulbTemperatureCurveName { get; set; } = "";
        

        [JsonProperty("optimized_cond_entering_water_temperature_curve_name")]
        public string OptimizedCondEnteringWaterTemperatureCurveName { get; set; } = "";
        

        [JsonProperty("minimum_lift")]
        public System.Nullable<float> MinimumLift { get; set; } = (System.Nullable<float>)Single.Parse("11.1", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_condenser_entering_water_temperature")]
        public System.Nullable<float> MaximumCondenserEnteringWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("32", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_tower_design_inlet_air_wet_bulb_temperature")]
        public System.Nullable<float> CoolingTowerDesignInletAirWetBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25.56", CultureInfo.InvariantCulture);
        

        [Description("Node(s) at which control variable will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}