using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fouling water heating or cooling coils")]
    [JsonObject("FaultModel:Fouling:Coil")]
    public class FaultModel_Fouling_Coil : BHoMObject
    {
        

        [JsonProperty("coil_name")]
        public string CoilName { get; set; } = "";
        

        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("severity_schedule_name")]
        public string SeverityScheduleName { get; set; } = "";
        

        [JsonProperty("fouling_input_method")]
        public EmptyNoYes FoulingInputMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "FouledUARated");
        

        [Description("Fouling coil UA value under rating conditions For Fouling Input Method: FouledUAR" +
                     "ated")]
        [JsonProperty("uafouled")]
        public System.Nullable<float> Uafouled { get; set; } = null;
        

        [Description("For Fouling Input Method: FoulingFactor")]
        [JsonProperty("water_side_fouling_factor")]
        public System.Nullable<float> WaterSideFoulingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("For Fouling Input Method: FoulingFactor")]
        [JsonProperty("air_side_fouling_factor")]
        public System.Nullable<float> AirSideFoulingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("For Fouling Input Method: FoulingFactor")]
        [JsonProperty("outside_coil_surface_area")]
        public System.Nullable<float> OutsideCoilSurfaceArea { get; set; } = null;
        

        [Description("For Fouling Input Method: FoulingFactor")]
        [JsonProperty("inside_to_outside_coil_surface_area_ratio")]
        public System.Nullable<float> InsideToOutsideCoilSurfaceAreaRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.07", CultureInfo.InvariantCulture);
    }
}