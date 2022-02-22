using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Internal heat source to be attached to a construction layer")]
    [JsonObject("ConstructionProperty:InternalHeatSource")]
    public class ConstructionProperty_InternalHeatSource : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [Description("refers to the list of materials which follows")]
        [JsonProperty("thermal_source_present_after_layer_number")]
        public System.Nullable<float> ThermalSourcePresentAfterLayerNumber { get; set; } = null;
        

        [Description("refers to the list of materials which follows")]
        [JsonProperty("temperature_calculation_requested_after_layer_number")]
        public System.Nullable<float> TemperatureCalculationRequestedAfterLayerNumber { get; set; } = null;
        

        [Description("1 = 1-dimensional calculation, 2 = 2-dimensional calculation")]
        [JsonProperty("dimensions_for_the_ctf_calculation")]
        public System.Nullable<float> DimensionsForTheCtfCalculation { get; set; } = null;
        

        [Description("uniform spacing between tubes or resistance wires in direction perpendicular to m" +
                     "ain intended direction of heat transfer")]
        [JsonProperty("tube_spacing")]
        public System.Nullable<float> TubeSpacing { get; set; } = null;
        

        [Description(@"used in conjunction with field Temperature Calculation Requested After Layer Number this field is the location perpendicular to the main direction of heat transfer 0.0 means in line with the tubing, 1.0 means at the midpoint between two adjacent pipes this field is ignored for 1-D calculations")]
        [JsonProperty("two_dimensional_temperature_calculation_position")]
        public System.Nullable<float> TwoDimensionalTemperatureCalculationPosition { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}