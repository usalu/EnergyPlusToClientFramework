using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description(@"This setpoint manager is used to place a temperature setpoint on a plant supply outlet node based on a target return water setpoint. The setpoint manager attempts to achieve the desired return water temperature by adjusting the supply temperature setpoint based on the plant conditions at each system time step.")]
    [JsonObject("SetpointManager:ReturnTemperature:ChilledWater")]
    public class SetpointManager_ReturnTemperature_ChilledWater : BHoMObject
    {
        

        [Description(@"This is the name of the supply outlet node for the plant being controlled by this setpoint manager. Typically this is where the setpoint will be actuated for supply equipment to control to, but not necessarily. This setpoint manager will mine that information from the internal plant data structures.")]
        [JsonProperty("plant_loop_supply_outlet_node")]
        public string PlantLoopSupplyOutletNode { get; set; } = "";
        

        [Description("This is the name of the supply inlet node for the plant being controlled with thi" +
                     "s setpoint manager. The temperature on this node is controlled by actuating the " +
                     "supply setpoint.")]
        [JsonProperty("plant_loop_supply_inlet_node")]
        public string PlantLoopSupplyInletNode { get; set; } = "";
        

        [Description("This is the minimum chilled water supply temperature setpoint. This is also used " +
                     "as the default setpoint during no-load or negative-load conditions and during in" +
                     "itialization.")]
        [JsonProperty("minimum_supply_temperature_setpoint")]
        public System.Nullable<float> MinimumSupplyTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("This is the maximum reset temperature for the chilled water supply.")]
        [JsonProperty("maximum_supply_temperature_setpoint")]
        public System.Nullable<float> MaximumSupplyTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("This defines whether the chilled water return temperature target is constant, sch" +
                     "eduled, or specified on the supply inlet node by a separate setpoint manager.")]
        [JsonProperty("return_temperature_setpoint_input_type")]
        public EmptyNoYes ReturnTemperatureSetpointInputType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("This is the desired return temperature target, which is met by adjusting the supp" +
                     "ly temperature setpoint. This constant value is only used if the Design Chilled " +
                     "Water Return Temperature Input Type is Constant")]
        [JsonProperty("return_temperature_setpoint_constant_value")]
        public System.Nullable<float> ReturnTemperatureSetpointConstantValue { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [Description(@"This is the desired return temperature target, which is met by adjusting the supply temperature setpoint. This is a schedule name to allow the return temperature target value to be scheduled. This field is only used if the Design Chilled Water Return Temperature Input Type is Scheduled")]
        [JsonProperty("return_temperature_setpoint_schedule_name")]
        public string ReturnTemperatureSetpointScheduleName { get; set; } = "";
    }
}