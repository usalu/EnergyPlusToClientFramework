using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description("Plant equipment operation scheme for component setpoint operation. Specifies one " +
                 "or pieces of equipment which are controlled to meet the temperature setpoint at " +
                 "the component outlet node.")]
    [JsonObject("PlantEquipmentOperation:ComponentSetpoint")]
    public class PlantEquipmentOperation_ComponentSetpoint : BHoMObject
    {
        

        [JsonProperty("equipment_1_object_type")]
        public string Equipment1ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_1_name")]
        public string Equipment1Name { get; set; } = "";
        

        [JsonProperty("demand_calculation_1_node_name")]
        public string DemandCalculation1NodeName { get; set; } = "";
        

        [JsonProperty("setpoint_1_node_name")]
        public string Setpoint1NodeName { get; set; } = "";
        

        [JsonProperty("component_1_flow_rate")]
        public string Component1FlowRate { get; set; } = "";
        

        [JsonProperty("operation_1_type")]
        public EmptyNoYes Operation1Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("equipment_2_object_type")]
        public string Equipment2ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_2_name")]
        public string Equipment2Name { get; set; } = "";
        

        [JsonProperty("demand_calculation_2_node_name")]
        public string DemandCalculation2NodeName { get; set; } = "";
        

        [JsonProperty("setpoint_2_node_name")]
        public string Setpoint2NodeName { get; set; } = "";
        

        [JsonProperty("component_2_flow_rate")]
        public string Component2FlowRate { get; set; } = "";
        

        [JsonProperty("operation_2_type")]
        public EmptyNoYes Operation2Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("equipment_3_object_type")]
        public string Equipment3ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_3_name")]
        public string Equipment3Name { get; set; } = "";
        

        [JsonProperty("demand_calculation_3_node_name")]
        public string DemandCalculation3NodeName { get; set; } = "";
        

        [JsonProperty("setpoint_3_node_name")]
        public string Setpoint3NodeName { get; set; } = "";
        

        [JsonProperty("component_3_flow_rate")]
        public string Component3FlowRate { get; set; } = "";
        

        [JsonProperty("operation_3_type")]
        public EmptyNoYes Operation3Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("equipment_4_object_type")]
        public string Equipment4ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_4_name")]
        public string Equipment4Name { get; set; } = "";
        

        [JsonProperty("demand_calculation_4_node_name")]
        public string DemandCalculation4NodeName { get; set; } = "";
        

        [JsonProperty("setpoint_4_node_name")]
        public string Setpoint4NodeName { get; set; } = "";
        

        [JsonProperty("component_4_flow_rate")]
        public string Component4FlowRate { get; set; } = "";
        

        [JsonProperty("operation_4_type")]
        public EmptyNoYes Operation4Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("equipment_5_object_type")]
        public string Equipment5ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_5_name")]
        public string Equipment5Name { get; set; } = "";
        

        [JsonProperty("demand_calculation_5_node_name")]
        public string DemandCalculation5NodeName { get; set; } = "";
        

        [JsonProperty("setpoint_5_node_name")]
        public string Setpoint5NodeName { get; set; } = "";
        

        [JsonProperty("component_5_flow_rate")]
        public string Component5FlowRate { get; set; } = "";
        

        [JsonProperty("operation_5_type")]
        public EmptyNoYes Operation5Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("equipment_6_object_type")]
        public string Equipment6ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_6_name")]
        public string Equipment6Name { get; set; } = "";
        

        [JsonProperty("demand_calculation_6_node_name")]
        public string DemandCalculation6NodeName { get; set; } = "";
        

        [JsonProperty("setpoint_6_node_name")]
        public string Setpoint6NodeName { get; set; } = "";
        

        [JsonProperty("component_6_flow_rate")]
        public string Component6FlowRate { get; set; } = "";
        

        [JsonProperty("operation_6_type")]
        public EmptyNoYes Operation6Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("equipment_7_object_type")]
        public string Equipment7ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_7_name")]
        public string Equipment7Name { get; set; } = "";
        

        [JsonProperty("demand_calculation_7_node_name")]
        public string DemandCalculation7NodeName { get; set; } = "";
        

        [JsonProperty("setpoint_7_node_name")]
        public string Setpoint7NodeName { get; set; } = "";
        

        [JsonProperty("component_7_flow_rate")]
        public string Component7FlowRate { get; set; } = "";
        

        [JsonProperty("operation_7_type")]
        public EmptyNoYes Operation7Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("equipment_8_object_type")]
        public string Equipment8ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_8_name")]
        public string Equipment8Name { get; set; } = "";
        

        [JsonProperty("demand_calculation_8_node_name")]
        public string DemandCalculation8NodeName { get; set; } = "";
        

        [JsonProperty("setpoint_8_node_name")]
        public string Setpoint8NodeName { get; set; } = "";
        

        [JsonProperty("component_8_flow_rate")]
        public string Component8FlowRate { get; set; } = "";
        

        [JsonProperty("operation_8_type")]
        public EmptyNoYes Operation8Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("equipment_9_object_type")]
        public string Equipment9ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_9_name")]
        public string Equipment9Name { get; set; } = "";
        

        [JsonProperty("demand_calculation_9_node_name")]
        public string DemandCalculation9NodeName { get; set; } = "";
        

        [JsonProperty("setpoint_9_node_name")]
        public string Setpoint9NodeName { get; set; } = "";
        

        [JsonProperty("component_9_flow_rate")]
        public string Component9FlowRate { get; set; } = "";
        

        [JsonProperty("operation_9_type")]
        public EmptyNoYes Operation9Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("equipment_10_object_type")]
        public string Equipment10ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_10_name")]
        public string Equipment10Name { get; set; } = "";
        

        [JsonProperty("demand_calculation_10_node_name")]
        public string DemandCalculation10NodeName { get; set; } = "";
        

        [JsonProperty("setpoint_10_node_name")]
        public string Setpoint10NodeName { get; set; } = "";
        

        [JsonProperty("component_10_flow_rate")]
        public string Component10FlowRate { get; set; } = "";
        

        [JsonProperty("operation_10_type")]
        public EmptyNoYes Operation10Type { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
    }
}