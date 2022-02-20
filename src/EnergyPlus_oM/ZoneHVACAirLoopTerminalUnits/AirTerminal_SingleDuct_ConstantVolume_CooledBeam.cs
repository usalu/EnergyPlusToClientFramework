using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, single duct, constant volume, with cooled beam " +
                 "(active or passive).")]
    [JsonObject("AirTerminal:SingleDuct:ConstantVolume:CooledBeam")]
    public class AirTerminal_SingleDuct_ConstantVolume_CooledBeam : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("cooled_beam_type")]
        public EmptyNoYes CooledBeamType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("supply_air_inlet_node_name")]
        public string SupplyAirInletNodeName { get; set; } = "";
        

        [JsonProperty("supply_air_outlet_node_name")]
        public string SupplyAirOutletNodeName { get; set; } = "";
        

        [JsonProperty("chilled_water_inlet_node_name")]
        public string ChilledWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("chilled_water_outlet_node_name")]
        public string ChilledWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("supply_air_volumetric_flow_rate")]
        public string SupplyAirVolumetricFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("maximum_total_chilled_water_volumetric_flow_rate")]
        public string MaximumTotalChilledWaterVolumetricFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("Number of individual beam units in the zone")]
        [JsonProperty("number_of_beams")]
        public string NumberOfBeams { get; set; } = (System.String)"Autosize";
        

        [Description("Length of an individual beam unit")]
        [JsonProperty("beam_length")]
        public string BeamLength { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("design_inlet_water_temperature")]
        public System.Nullable<float> DesignInletWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

        [JsonProperty("design_outlet_water_temperature")]
        public System.Nullable<float> DesignOutletWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("17", CultureInfo.InvariantCulture);
        

        [JsonProperty("coil_surface_area_per_coil_length")]
        public System.Nullable<float> CoilSurfaceAreaPerCoilLength { get; set; } = (System.Nullable<float>)Single.Parse("5.422", CultureInfo.InvariantCulture);
        

        [JsonProperty("model_parameter_a")]
        public System.Nullable<float> ModelParameterA { get; set; } = (System.Nullable<float>)Single.Parse("15.3", CultureInfo.InvariantCulture);
        

        [JsonProperty("model_parameter_n1")]
        public System.Nullable<float> ModelParameterN1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("model_parameter_n2")]
        public System.Nullable<float> ModelParameterN2 { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

        [JsonProperty("model_parameter_n3")]
        public System.Nullable<float> ModelParameterN3 { get; set; } = (System.Nullable<float>)Single.Parse("0.12", CultureInfo.InvariantCulture);
        

        [Description("Free area of the coil in plan view per unit beam length")]
        [JsonProperty("model_parameter_a0")]
        public System.Nullable<float> ModelParameterA0 { get; set; } = (System.Nullable<float>)Single.Parse("0.171", CultureInfo.InvariantCulture);
        

        [JsonProperty("model_parameter_k1")]
        public System.Nullable<float> ModelParameterK1 { get; set; } = (System.Nullable<float>)Single.Parse("0.0057", CultureInfo.InvariantCulture);
        

        [JsonProperty("model_parameter_n")]
        public System.Nullable<float> ModelParameterN { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty("coefficient_of_induction_kin")]
        public string CoefficientOfInductionKin { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("leaving_pipe_inside_diameter")]
        public System.Nullable<float> LeavingPipeInsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.0145", CultureInfo.InvariantCulture);
    }
}