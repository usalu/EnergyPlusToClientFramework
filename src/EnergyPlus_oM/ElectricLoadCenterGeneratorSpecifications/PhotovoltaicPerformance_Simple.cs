using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Describes a simple model of photovoltaics that may be useful for early phase design analysis. In this model the user has direct access to the efficiency with which surfaces convert incident solar radiation to electricity and need not specify arrays of specific modules.")]
    [JsonObject("PhotovoltaicPerformance:Simple")]
    public class PhotovoltaicPerformance_Simple : BHoMObject
    {
        

        [JsonProperty("fraction_of_surface_area_with_active_solar_cells")]
        public System.Nullable<float> FractionOfSurfaceAreaWithActiveSolarCells { get; set; } = null;
        

        [JsonProperty("conversion_efficiency_input_mode")]
        public EmptyNoYes ConversionEfficiencyInputMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Efficiency = (power generated [W])/(incident solar[W])")]
        [JsonProperty("value_for_cell_efficiency_if_fixed")]
        public System.Nullable<float> ValueForCellEfficiencyIfFixed { get; set; } = null;
        

        [JsonProperty("efficiency_schedule_name")]
        public string EfficiencyScheduleName { get; set; } = "";
    }
}