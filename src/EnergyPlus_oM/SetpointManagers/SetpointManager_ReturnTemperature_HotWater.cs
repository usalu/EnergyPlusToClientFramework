using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description(@"This setpoint manager is used to place a temperature setpoint on a plant supply outlet node based on a target return water setpoint. The setpoint manager attempts to achieve the desired return water temperature by adjusting the supply temperature setpoint based on the plant conditions at each system time step.")]
    public class SetpointManager_ReturnTemperature_HotWater : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"This is the name of the supply outlet node for the plant being controlled by this setpoint manager. Typically this is where the setpoint will be actuated for supply equipment to control to, but not necessarily. This setpoint manager will mine that information from the internal plant data structures.")]
        [JsonProperty("plant_loop_supply_outlet_node")]
        public string PlantLoopSupplyOutletNode { get; set; } = "";
        

        [Description("This is the name of the supply inlet node for the plant being controlled with thi" +
                     "s setpoint manager. The temperature on this node is controlled by actuating the " +
                     "supply setpoint.")]
        [JsonProperty("plant_loop_supply_inlet_node")]
        public string PlantLoopSupplyInletNode { get; set; } = "";
        

        [Description("This is the minimum reset temperature for the hot water supply.")]
        [JsonProperty("minimum_supply_temperature_setpoint")]
        public System.Nullable<float> MinimumSupplyTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("77", CultureInfo.InvariantCulture);
        

        [Description("This is the maximum hot water supply temperature setpoint. This is also used as t" +
                     "he default setpoint during no-load or negative-load conditions and during initia" +
                     "lization.")]
        [JsonProperty("maximum_supply_temperature_setpoint")]
        public System.Nullable<float> MaximumSupplyTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("82", CultureInfo.InvariantCulture);
        

        [Description("This defines whether the hot water return temperature target is constant, schedul" +
                     "ed, or specified on the supply inlet node by a separate setpoint manager.")]
        [JsonProperty("return_temperature_setpoint_input_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_ReturnTemperature_HotWater_ReturnTemperatureSetpointInputType ReturnTemperatureSetpointInputType { get; set; } = (SetpointManager_ReturnTemperature_HotWater_ReturnTemperatureSetpointInputType)Enum.Parse(typeof(SetpointManager_ReturnTemperature_HotWater_ReturnTemperatureSetpointInputType), "Constant");
        

        [Description("This is the desired return temperature target, which is met by adjusting the supp" +
                     "ly temperature setpoint. This constant value is only used if the Design Hot Wate" +
                     "r Return Temperature Input Type is Constant")]
        [JsonProperty("return_temperature_setpoint_constant_value")]
        public System.Nullable<float> ReturnTemperatureSetpointConstantValue { get; set; } = (System.Nullable<float>)Single.Parse("71", CultureInfo.InvariantCulture);
        

        [Description(@"This is the desired return temperature target, which is met by adjusting the supply temperature setpoint. This is a schedule name to allow the return temperature target value to be scheduled. This field is only used if the Design Hot Water Return Temperature Input Type is Scheduled")]
        [JsonProperty("return_temperature_setpoint_schedule_name")]
        public string ReturnTemperatureSetpointScheduleName { get; set; } = "";
    }
}