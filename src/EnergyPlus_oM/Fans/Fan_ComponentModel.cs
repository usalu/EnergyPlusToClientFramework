using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    [Description("A detailed fan type for constant-air-volume (CAV) and variable-air-volume (VAV) s" +
                 "ystems. It includes inputs that describe the air-distribution system as well as " +
                 "the fan, drive belt (if used), motor, and variable-frequency-drive (if used).")]
    [JsonObject("Fan:ComponentModel")]
    public class Fan_ComponentModel : BHoMObject
    {
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("maximum_flow_rate")]
        public string MaximumFlowRate { get; set; } = "";
        

        [JsonProperty("minimum_flow_rate")]
        public string MinimumFlowRate { get; set; } = "";
        

        [Description("Applied to specified or autosized max fan airflow")]
        [JsonProperty("fan_sizing_factor")]
        public System.Nullable<float> FanSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Diameter of wheel outer circumference")]
        [JsonProperty("fan_wheel_diameter")]
        public System.Nullable<float> FanWheelDiameter { get; set; } = null;
        

        [Description("Area at fan outlet plane for determining discharge velocity pressure")]
        [JsonProperty("fan_outlet_area")]
        public System.Nullable<float> FanOutletArea { get; set; } = null;
        

        [Description("Maximum ratio between power delivered to air and fan shaft input power Determined" +
                     " from fan performance data")]
        [JsonProperty("maximum_fan_static_efficiency")]
        public System.Nullable<float> MaximumFanStaticEfficiency { get; set; } = null;
        

        [Description("Euler number (Eu) determined from fan performance data")]
        [JsonProperty("euler_number_at_maximum_fan_static_efficiency")]
        public System.Nullable<float> EulerNumberAtMaximumFanStaticEfficiency { get; set; } = null;
        

        [Description("Corresponds to maximum ratio between fan airflow and fan shaft rotational speed f" +
                     "or specified fan wheel diameter Determined from fan performance data")]
        [JsonProperty("maximum_dimensionless_fan_airflow")]
        public System.Nullable<float> MaximumDimensionlessFanAirflow { get; set; } = null;
        

        [Description("Ratio of motor pulley diameter to fan pulley diameter")]
        [JsonProperty("motor_fan_pulley_ratio")]
        public string MotorFanPulleyRatio { get; set; } = (System.String)"1";
        

        [Description("Maximum torque transmitted by belt")]
        [JsonProperty("belt_maximum_torque")]
        public string BeltMaximumTorque { get; set; } = "";
        

        [Description("Applied to specified or autosized max torque transmitted by belt")]
        [JsonProperty("belt_sizing_factor")]
        public System.Nullable<float> BeltSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Region 1 to 2 curve transition for belt normalized efficiency")]
        [JsonProperty("belt_fractional_torque_transition")]
        public System.Nullable<float> BeltFractionalTorqueTransition { get; set; } = (System.Nullable<float>)Single.Parse("0.167", CultureInfo.InvariantCulture);
        

        [Description("Maximum rotational speed of fan motor shaft")]
        [JsonProperty("motor_maximum_speed")]
        public System.Nullable<float> MotorMaximumSpeed { get; set; } = null;
        

        [Description("Maximum power input to drive belt by motor")]
        [JsonProperty("maximum_motor_output_power")]
        public string MaximumMotorOutputPower { get; set; } = "";
        

        [Description("Applied to specified or autosized motor output power")]
        [JsonProperty("motor_sizing_factor")]
        public System.Nullable<float> MotorSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("0.0 means motor outside air stream 1.0 means motor inside air stream")]
        [JsonProperty("motor_in_airstream_fraction")]
        public System.Nullable<float> MotorInAirstreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Efficiency depends on fraction of full-load motor speed Efficiency depends on  fr" +
                     "action of full-load motor input power If field blank, then assumes constant VFD " +
                     "efficiency (0.97)")]
        [JsonProperty("vfd_efficiency_type")]
        public EmptyNoYes VfdEfficiencyType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Maximum power input to motor by VFD")]
        [JsonProperty("maximum_vfd_output_power")]
        public string MaximumVfdOutputPower { get; set; } = "";
        

        [Description("Applied to specified or autosized VFD output power")]
        [JsonProperty("vfd_sizing_factor")]
        public System.Nullable<float> VfdSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Pressure rise depends on volumetric flow, system resistances, system leakage, and" +
                     " duct static pressure set point")]
        [JsonProperty("fan_pressure_rise_curve_name")]
        public string FanPressureRiseCurveName { get; set; } = "";
        

        [Description("Function of fan volumetric flow Minimum and maximum fan airflows correspond respe" +
                     "ctively to minimum and maximum duct static pressure set points")]
        [JsonProperty("duct_static_pressure_reset_curve_name")]
        public string DuctStaticPressureResetCurveName { get; set; } = "";
        

        [Description("xfan <= 0 Curve should have maximum of 1.0")]
        [JsonProperty("normalized_fan_static_efficiency_curve_name_non_stall_region")]
        public string NormalizedFanStaticEfficiencyCurveNameNonStallRegion { get; set; } = "";
        

        [Description("xfan > 0 Curve should have maximum of 1.0")]
        [JsonProperty("normalized_fan_static_efficiency_curve_name_stall_region")]
        public string NormalizedFanStaticEfficiencyCurveNameStallRegion { get; set; } = "";
        

        [Description("xspd <= 0 Curve should have maximum of 1.0")]
        [JsonProperty("normalized_dimensionless_airflow_curve_name_non_stall_region")]
        public string NormalizedDimensionlessAirflowCurveNameNonStallRegion { get; set; } = "";
        

        [Description("xspd > 0 Curve should have maximum of 1.0")]
        [JsonProperty("normalized_dimensionless_airflow_curve_name_stall_region")]
        public string NormalizedDimensionlessAirflowCurveNameStallRegion { get; set; } = "";
        

        [Description("Determines maximum fan drive belt efficiency in log space as function of xbelt,ma" +
                     "x Curve should have minimum of -4.6 and maximum of 0.0 If field blank, assumes o" +
                     "utput of curve is always 1.0")]
        [JsonProperty("maximum_belt_efficiency_curve_name")]
        public string MaximumBeltEfficiencyCurveName { get; set; } = "";
        

        [Description("Region 1 (0 <= xbelt < xbelt,trans) Curve should have minimum > 0.0 and maximum o" +
                     "f 1.0 If field blank, assumes output of curve is always 1.0 in Region 1")]
        [JsonProperty("normalized_belt_efficiency_curve_name_region_1")]
        public string NormalizedBeltEfficiencyCurveNameRegion1 { get; set; } = "";
        

        [Description("Region 2 (xbelt,trans <= xbelt <= 1) Curve should have minimum > 0.0 and maximum " +
                     "of 1.0 If field blank, assumes output of curve is always 1.0 in Region 2")]
        [JsonProperty("normalized_belt_efficiency_curve_name_region_2")]
        public string NormalizedBeltEfficiencyCurveNameRegion2 { get; set; } = "";
        

        [Description("Determines normalized drive belt efficiency Region 3 (xbelt > 1) Curve should hav" +
                     "e minimum > 0.0 and maximum of 1.0 If field blank, assumes output of curve is al" +
                     "ways 1.0 in Region 3")]
        [JsonProperty("normalized_belt_efficiency_curve_name_region_3")]
        public string NormalizedBeltEfficiencyCurveNameRegion3 { get; set; } = "";
        

        [Description("Curve should have minimum > 0.0 and maximum of 1.0 If field blank, assumes output" +
                     " of curve is always 1.0")]
        [JsonProperty("maximum_motor_efficiency_curve_name")]
        public string MaximumMotorEfficiencyCurveName { get; set; } = "";
        

        [Description("Curve should have minimum > 0.0 and maximum of 1.0 If field blank, assumes output" +
                     " of curve is always 1.0")]
        [JsonProperty("normalized_motor_efficiency_curve_name")]
        public string NormalizedMotorEfficiencyCurveName { get; set; } = "";
        

        [Description("Determines VFD efficiency as function of motor load or speed fraction Curve shoul" +
                     "d have minimum > 0.0 and maximum of 1.0 If field blank, assumes constant VFD eff" +
                     "iciency (0.97)")]
        [JsonProperty("vfd_efficiency_curve_name")]
        public string VfdEfficiencyCurveName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}