using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Chilled water cooling coil, detailed flat fin coil model for continuous plate fin" +
                 "s, with inputs for detailed coil geometry specifications.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Cooling_Water_DetailedGeometry : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("maximum_water_flow_rate")]
        public string MaximumWaterFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("Tube Primary Surface Area")]
        [JsonProperty("tube_outside_surface_area")]
        public string TubeOutsideSurfaceArea { get; set; } = (System.String)"Autosize";
        

        [Description("Total tube inside surface area")]
        [JsonProperty("total_tube_inside_area")]
        public string TotalTubeInsideArea { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("fin_surface_area")]
        public string FinSurfaceArea { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("minimum_airflow_area")]
        public string MinimumAirflowArea { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("coil_depth")]
        public string CoilDepth { get; set; } = (System.String)"Autosize";
        

        [Description("Fin diameter or the coil height")]
        [JsonProperty("fin_diameter")]
        public string FinDiameter { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("fin_thickness")]
        public System.Nullable<float> FinThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.0015", CultureInfo.InvariantCulture);
        

        [Description("Inner diameter of tubes")]
        [JsonProperty("tube_inside_diameter")]
        public System.Nullable<float> TubeInsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.01445", CultureInfo.InvariantCulture);
        

        [Description("Outer diameter of tubes")]
        [JsonProperty("tube_outside_diameter")]
        public System.Nullable<float> TubeOutsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.0159", CultureInfo.InvariantCulture);
        

        [JsonProperty("tube_thermal_conductivity")]
        public System.Nullable<float> TubeThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("386", CultureInfo.InvariantCulture);
        

        [JsonProperty("fin_thermal_conductivity")]
        public System.Nullable<float> FinThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("204", CultureInfo.InvariantCulture);
        

        [Description("Fin spacing or distance")]
        [JsonProperty("fin_spacing")]
        public System.Nullable<float> FinSpacing { get; set; } = (System.Nullable<float>)Single.Parse("0.0018", CultureInfo.InvariantCulture);
        

        [JsonProperty("tube_depth_spacing")]
        public System.Nullable<float> TubeDepthSpacing { get; set; } = (System.Nullable<float>)Single.Parse("0.026", CultureInfo.InvariantCulture);
        

        [JsonProperty("number_of_tube_rows")]
        public System.Nullable<float> NumberOfTubeRows { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

        [JsonProperty("number_of_tubes_per_row")]
        public string NumberOfTubesPerRow { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("water_inlet_node_name")]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty("water_outlet_node_name")]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("condensate_collection_water_storage_tank_name")]
        public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

        [Description("This input field is optional. If specified, it is used for sizing the Design Wate" +
                     "r Flow Rate. If blank or omitted, the Loop Design Temperature Difference value s" +
                     "pecified in Sizing:Plant object is used for sizing the Design Water Flow Rate.")]
        [JsonProperty("design_water_temperature_difference")]
        public System.Nullable<float> DesignWaterTemperatureDifference { get; set; } = null;
    }
}