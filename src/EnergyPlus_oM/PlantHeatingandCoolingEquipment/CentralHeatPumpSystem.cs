using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description(@"This chiller bank can contain multiple chiller heaters and heat pump performance objects. Its function is to encapsulate the extra controls needed to turn individual modules on/off and whether they are to operate in cooling-only, heating-only or simultaneous cooling/heating mode and whether to connect the source water to the evaporator or condenser side.")]
    [JsonObject("CentralHeatPumpSystem")]
    public class CentralHeatPumpSystem : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("control_method")]
        public CentralHeatPumpSystem_ControlMethod ControlMethod { get; set; } = (CentralHeatPumpSystem_ControlMethod)Enum.Parse(typeof(CentralHeatPumpSystem_ControlMethod), "SmartMixing");
        

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
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType1 ChillerHeaterModulesPerformanceComponentObjectType1 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType1)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType1), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_1")]
        public string ChillerHeaterModulesPerformanceComponentName1 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_1")]
        public string ChillerHeaterModulesControlScheduleName1 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_1")]
        public System.Nullable<float> NumberOfChillerHeaterModules1 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_2")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType2 ChillerHeaterModulesPerformanceComponentObjectType2 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType2)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType2), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_2")]
        public string ChillerHeaterModulesPerformanceComponentName2 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_2")]
        public string ChillerHeaterModulesControlScheduleName2 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_2")]
        public System.Nullable<float> NumberOfChillerHeaterModules2 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_performance_component_object_type_3")]
        public CentralHeatPumpSystem_ChillerHeaterPerformanceComponentObjectType3 ChillerHeaterPerformanceComponentObjectType3 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterPerformanceComponentObjectType3)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterPerformanceComponentObjectType3), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_performance_component_name_3")]
        public string ChillerHeaterPerformanceComponentName3 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_3")]
        public string ChillerHeaterModulesControlScheduleName3 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_3")]
        public System.Nullable<float> NumberOfChillerHeaterModules3 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_4")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType4 ChillerHeaterModulesPerformanceComponentObjectType4 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType4)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType4), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_4")]
        public string ChillerHeaterModulesPerformanceComponentName4 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_4")]
        public string ChillerHeaterModulesControlScheduleName4 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_4")]
        public System.Nullable<float> NumberOfChillerHeaterModules4 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_5")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType5 ChillerHeaterModulesPerformanceComponentObjectType5 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType5)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType5), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_models_performance_component_name_5")]
        public string ChillerHeaterModelsPerformanceComponentName5 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_5")]
        public string ChillerHeaterModulesControlScheduleName5 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_5")]
        public System.Nullable<float> NumberOfChillerHeaterModules5 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_6")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType6 ChillerHeaterModulesPerformanceComponentObjectType6 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType6)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType6), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_6")]
        public string ChillerHeaterModulesPerformanceComponentName6 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_6")]
        public string ChillerHeaterModulesControlScheduleName6 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_6")]
        public System.Nullable<float> NumberOfChillerHeaterModules6 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_7")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType7 ChillerHeaterModulesPerformanceComponentObjectType7 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType7)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType7), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_7")]
        public string ChillerHeaterModulesPerformanceComponentName7 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_7")]
        public string ChillerHeaterModulesControlScheduleName7 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_7")]
        public System.Nullable<float> NumberOfChillerHeaterModules7 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_8")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType8 ChillerHeaterModulesPerformanceComponentObjectType8 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType8)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType8), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_8")]
        public string ChillerHeaterModulesPerformanceComponentName8 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_8")]
        public string ChillerHeaterModulesControlScheduleName8 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_8")]
        public System.Nullable<float> NumberOfChillerHeaterModules8 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_9")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType9 ChillerHeaterModulesPerformanceComponentObjectType9 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType9)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType9), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_9")]
        public string ChillerHeaterModulesPerformanceComponentName9 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_9")]
        public string ChillerHeaterModulesControlScheduleName9 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_9")]
        public System.Nullable<float> NumberOfChillerHeaterModules9 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_10")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType10 ChillerHeaterModulesPerformanceComponentObjectType10 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType10)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType10), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_10")]
        public string ChillerHeaterModulesPerformanceComponentName10 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_10")]
        public string ChillerHeaterModulesControlScheduleName10 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_10")]
        public System.Nullable<float> NumberOfChillerHeaterModules10 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_11")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType11 ChillerHeaterModulesPerformanceComponentObjectType11 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType11)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType11), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_11")]
        public string ChillerHeaterModulesPerformanceComponentName11 { get; set; } = "";
        

        [JsonProperty("chiller_heater_module_control_schedule_name_11")]
        public string ChillerHeaterModuleControlScheduleName11 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_11")]
        public System.Nullable<float> NumberOfChillerHeaterModules11 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_12")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType12 ChillerHeaterModulesPerformanceComponentObjectType12 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType12)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType12), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_12")]
        public string ChillerHeaterModulesPerformanceComponentName12 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_12")]
        public string ChillerHeaterModulesControlScheduleName12 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_12")]
        public System.Nullable<float> NumberOfChillerHeaterModules12 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_13")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType13 ChillerHeaterModulesPerformanceComponentObjectType13 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType13)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType13), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_13")]
        public string ChillerHeaterModulesPerformanceComponentName13 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_13")]
        public string ChillerHeaterModulesControlScheduleName13 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_13")]
        public System.Nullable<float> NumberOfChillerHeaterModules13 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_14")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType14 ChillerHeaterModulesPerformanceComponentObjectType14 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType14)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType14), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_14")]
        public string ChillerHeaterModulesPerformanceComponentName14 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_14")]
        public string ChillerHeaterModulesControlScheduleName14 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_14")]
        public System.Nullable<float> NumberOfChillerHeaterModules14 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_15")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType15 ChillerHeaterModulesPerformanceComponentObjectType15 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType15)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType15), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_15")]
        public string ChillerHeaterModulesPerformanceComponentName15 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_15")]
        public string ChillerHeaterModulesControlScheduleName15 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_15")]
        public System.Nullable<float> NumberOfChillerHeaterModules15 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_16")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType16 ChillerHeaterModulesPerformanceComponentObjectType16 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType16)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType16), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_16")]
        public string ChillerHeaterModulesPerformanceComponentName16 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_16")]
        public string ChillerHeaterModulesControlScheduleName16 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_16")]
        public System.Nullable<float> NumberOfChillerHeaterModules16 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_17")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType17 ChillerHeaterModulesPerformanceComponentObjectType17 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType17)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType17), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_17")]
        public string ChillerHeaterModulesPerformanceComponentName17 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_17")]
        public string ChillerHeaterModulesControlScheduleName17 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_17")]
        public System.Nullable<float> NumberOfChillerHeaterModules17 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_18")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType18 ChillerHeaterModulesPerformanceComponentObjectType18 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType18)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType18), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_18")]
        public string ChillerHeaterModulesPerformanceComponentName18 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_control_schedule_name_18")]
        public string ChillerHeaterModulesControlControlScheduleName18 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_18")]
        public System.Nullable<float> NumberOfChillerHeaterModules18 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_19")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType19 ChillerHeaterModulesPerformanceComponentObjectType19 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType19)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType19), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_19")]
        public string ChillerHeaterModulesPerformanceComponentName19 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_19")]
        public string ChillerHeaterModulesControlScheduleName19 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_19")]
        public System.Nullable<float> NumberOfChillerHeaterModules19 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("chiller_heater_modules_performance_component_object_type_20")]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType20 ChillerHeaterModulesPerformanceComponentObjectType20 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType20)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType20), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty("chiller_heater_modules_performance_component_name_20")]
        public string ChillerHeaterModulesPerformanceComponentName20 { get; set; } = "";
        

        [JsonProperty("chiller_heater_modules_control_schedule_name_20")]
        public string ChillerHeaterModulesControlScheduleName20 { get; set; } = "";
        

        [JsonProperty("number_of_chiller_heater_modules_20")]
        public System.Nullable<float> NumberOfChillerHeaterModules20 { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}