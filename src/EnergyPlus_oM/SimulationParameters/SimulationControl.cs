using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description(@"Note that the following 3 fields are related to the Sizing:Zone, Sizing:System, and Sizing:Plant objects. Having these fields set to Yes but no corresponding Sizing object will not cause the sizing to be done. However, having any of these fields set to No, the corresponding Sizing object is ignored. Note also, if you want to do system sizing, you must also do zone sizing in the same run or an error will result.")]
    [JsonObject("SimulationControl")]
    public class SimulationControl : BHoMObject, IEnergyPlusClass
    {
        

        [Description("If Yes, Zone sizing is accomplished from corresponding Sizing:Zone objects and au" +
                     "tosize fields.")]
        [JsonProperty("do_zone_sizing_calculation")]
        public EmptyNoYes DoZoneSizingCalculation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("If Yes, System sizing is accomplished from corresponding Sizing:System objects an" +
                     "d autosize fields. If Yes, Zone sizing (previous field) must also be Yes.")]
        [JsonProperty("do_system_sizing_calculation")]
        public EmptyNoYes DoSystemSizingCalculation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("If Yes, Plant sizing is accomplished from corresponding Sizing:Plant objects and " +
                     "autosize fields.")]
        [JsonProperty("do_plant_sizing_calculation")]
        public EmptyNoYes DoPlantSizingCalculation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("If Yes, SizingPeriod:* objects are executed and results from those may be display" +
                     "ed..")]
        [JsonProperty("run_simulation_for_sizing_periods")]
        public EmptyNoYes RunSimulationForSizingPeriods { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("If Yes, RunPeriod:* objects are executed and results from those may be displayed." +
                     ".")]
        [JsonProperty("run_simulation_for_weather_file_run_periods")]
        public EmptyNoYes RunSimulationForWeatherFileRunPeriods { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("If Yes, SizingPeriod:* objects are exectuted additional times for advanced sizing" +
                     ". Currently limited to use with coincident plant sizing, see Sizing:Plant object" +
                     "")]
        [JsonProperty("do_hvac_sizing_simulation_for_sizing_periods")]
        public EmptyNoYes DoHvacSizingSimulationForSizingPeriods { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("the entire set of SizingPeriod:* objects may be repeated to fine tune size result" +
                     "s this input sets a limit on the number of passes that the sizing algorithms can" +
                     " repeate the set")]
        [JsonProperty("maximum_number_of_hvac_sizing_simulation_passes")]
        public System.Nullable<float> MaximumNumberOfHvacSizingSimulationPasses { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}