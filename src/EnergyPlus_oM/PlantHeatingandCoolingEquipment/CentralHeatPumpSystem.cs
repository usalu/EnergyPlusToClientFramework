using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description(@"This chiller bank can contain multiple chiller heaters and heat pump performance objects. Its function is to encapsulate the extra controls needed to turn individual modules on/off and whether they are to operate in cooling-only, heating-only or simultaneous cooling/heating mode and whether to connect the source water to the evaporator or condenser side.")]
    [JsonObject("CentralHeatPumpSystem")]
    public class CentralHeatPumpSystem : BHoMObject
    {
        

        [JsonProperty("control_method")]
        public EmptyNoYes ControlMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "SmartMixing");
        

        [JsonProperty("cooling_loop_inlet_node_name")]
        public string CoolingLoopInletNodeName { get; set; } = "";
        

        [JsonProperty("cooling_loop_outlet_node_name")]
        public string CoolingLoopOutletNodeName { get; set; } = "";
        

        [JsonProperty("source_loop_inlet_node_name")]
        public string SourceLoopInletNodeName { get; set; } = "";
        

        [JsonProperty("source_loop_outlet_node_name")]
        public string SourceLoopOutletNodeName { get; set; } = "";
        

        [JsonProperty("heating_loop_inlet_node_name")]
        public string HeatingLoopInletNodeName { get; set; } = "";
        

        [JsonProperty("heating_loop_outlet_node_name")]
        public string HeatingLoopOutletNodeName { get; set; } = "";
        

        [Description("Power as demanded from any auxiliary controls")]
        [JsonProperty("ancillary_power")]
        public System.Nullable<float> AncillaryPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This value from this schedule is multiplied times the Ancillary Power")]
        [JsonProperty("ancillary_operation_schedule_name")]
        public string AncillaryOperationScheduleName { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_1")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType1 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_1")]
        public string ChillerHeaterModulesPerformanceComponentName1 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_1")]
        public string ChillerHeaterModulesControlScheduleName1 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_1")]
        public System.Nullable<float> NumberOfChillerHeaterModules1 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_2")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType2 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_2")]
        public string ChillerHeaterModulesPerformanceComponentName2 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_2")]
        public string ChillerHeaterModulesControlScheduleName2 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_2")]
        public System.Nullable<float> NumberOfChillerHeaterModules2 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_performance_component_object_type_3")]
        public EmptyNoYes ChillerHeaterPerformanceComponentObjectType3 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_performance_component_name_3")]
        public string ChillerHeaterPerformanceComponentName3 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_3")]
        public string ChillerHeaterModulesControlScheduleName3 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_3")]
        public System.Nullable<float> NumberOfChillerHeaterModules3 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_4")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType4 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_4")]
        public string ChillerHeaterModulesPerformanceComponentName4 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_4")]
        public string ChillerHeaterModulesControlScheduleName4 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_4")]
        public System.Nullable<float> NumberOfChillerHeaterModules4 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_5")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType5 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_models_performance_component_name_5")]
        public string ChillerHeaterModelsPerformanceComponentName5 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_5")]
        public string ChillerHeaterModulesControlScheduleName5 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_5")]
        public System.Nullable<float> NumberOfChillerHeaterModules5 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_6")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType6 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_6")]
        public string ChillerHeaterModulesPerformanceComponentName6 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_6")]
        public string ChillerHeaterModulesControlScheduleName6 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_6")]
        public System.Nullable<float> NumberOfChillerHeaterModules6 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_7")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType7 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_7")]
        public string ChillerHeaterModulesPerformanceComponentName7 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_7")]
        public string ChillerHeaterModulesControlScheduleName7 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_7")]
        public System.Nullable<float> NumberOfChillerHeaterModules7 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_8")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType8 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_8")]
        public string ChillerHeaterModulesPerformanceComponentName8 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_8")]
        public string ChillerHeaterModulesControlScheduleName8 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_8")]
        public System.Nullable<float> NumberOfChillerHeaterModules8 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_9")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType9 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_9")]
        public string ChillerHeaterModulesPerformanceComponentName9 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_9")]
        public string ChillerHeaterModulesControlScheduleName9 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_9")]
        public System.Nullable<float> NumberOfChillerHeaterModules9 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_10")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType10 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_10")]
        public string ChillerHeaterModulesPerformanceComponentName10 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_10")]
        public string ChillerHeaterModulesControlScheduleName10 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_10")]
        public System.Nullable<float> NumberOfChillerHeaterModules10 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_11")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType11 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_11")]
        public string ChillerHeaterModulesPerformanceComponentName11 { get; set; } = "";
        

        [JsonProperty("chiller_heater_module_control_schedule_name_11")]
        public string ChillerHeaterModuleControlScheduleName11 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_11")]
        public System.Nullable<float> NumberOfChillerHeaterModules11 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_12")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType12 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_12")]
        public string ChillerHeaterModulesPerformanceComponentName12 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_12")]
        public string ChillerHeaterModulesControlScheduleName12 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_12")]
        public System.Nullable<float> NumberOfChillerHeaterModules12 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_13")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType13 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_13")]
        public string ChillerHeaterModulesPerformanceComponentName13 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_13")]
        public string ChillerHeaterModulesControlScheduleName13 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_13")]
        public System.Nullable<float> NumberOfChillerHeaterModules13 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_14")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType14 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_14")]
        public string ChillerHeaterModulesPerformanceComponentName14 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_14")]
        public string ChillerHeaterModulesControlScheduleName14 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_14")]
        public System.Nullable<float> NumberOfChillerHeaterModules14 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_15")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType15 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_15")]
        public string ChillerHeaterModulesPerformanceComponentName15 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_15")]
        public string ChillerHeaterModulesControlScheduleName15 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_15")]
        public System.Nullable<float> NumberOfChillerHeaterModules15 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_16")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType16 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_16")]
        public string ChillerHeaterModulesPerformanceComponentName16 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_16")]
        public string ChillerHeaterModulesControlScheduleName16 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_16")]
        public System.Nullable<float> NumberOfChillerHeaterModules16 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_17")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType17 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_17")]
        public string ChillerHeaterModulesPerformanceComponentName17 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_17")]
        public string ChillerHeaterModulesControlScheduleName17 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_17")]
        public System.Nullable<float> NumberOfChillerHeaterModules17 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_18")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType18 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_18")]
        public string ChillerHeaterModulesPerformanceComponentName18 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_control_schedule_name_18")]
        public string ChillerHeaterModulesControlControlScheduleName18 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_18")]
        public System.Nullable<float> NumberOfChillerHeaterModules18 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_19")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType19 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_19")]
        public string ChillerHeaterModulesPerformanceComponentName19 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_19")]
        public string ChillerHeaterModulesControlScheduleName19 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_19")]
        public System.Nullable<float> NumberOfChillerHeaterModules19 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_20")]
        public EmptyNoYes ChillerHeaterModulesPerformanceComponentObjectType20 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_20")]
        public string ChillerHeaterModulesPerformanceComponentName20 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_20")]
        public string ChillerHeaterModulesControlScheduleName20 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_20")]
        public System.Nullable<float> NumberOfChillerHeaterModules20 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}