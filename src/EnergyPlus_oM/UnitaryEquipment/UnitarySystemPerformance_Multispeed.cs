using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    [Description(@"The UnitarySystemPerformance object is used to specify the air flow ratio at each operating speed. This object is primarily used for multispeed DX and water coils to allow operation at alternate flow rates different from those specified in the coil object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class UnitarySystemPerformance_Multispeed : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Used only for Multi speed coils Enter the number of the following sets of data fo" +
                     "r air flow rates.")]
        [JsonProperty("number_of_speeds_for_heating")]
        public System.Nullable<float> NumberOfSpeedsForHeating { get; set; } = null;
        

        [Description("Used only for Multi speed coils Enter the number of the following sets of data fo" +
                     "r air flow rates.")]
        [JsonProperty("number_of_speeds_for_cooling")]
        public System.Nullable<float> NumberOfSpeedsForCooling { get; set; } = null;
        

        [Description(@"Controls coil operation during each HVAC timestep. This choice does not apply to speed 1 operation. Yes = operate at the highest speed possible without exceeding the current load. No = allow operation at the average of two adjacent speeds to match the current load.")]
        [JsonProperty("single_mode_operation")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes SingleModeOperation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Used to define the no load operating air flow rate when the system fan is specifi" +
                     "ed to operate continuously.")]
        [JsonProperty("no_load_supply_air_flow_rate_ratio")]
        public System.Nullable<float> NoLoadSupplyAirFlowRateRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("flow_ratios")]
        public string FlowRatios { get; set; } = "";
    }
}