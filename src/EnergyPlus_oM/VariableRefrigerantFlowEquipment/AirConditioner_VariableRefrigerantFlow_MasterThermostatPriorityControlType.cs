namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    public enum AirConditioner_VariableRefrigerantFlow_MasterThermostatPriorityControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LoadPriority")]
        LoadPriority = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MasterThermostatPriority")]
        MasterThermostatPriority = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatOffsetPriority")]
        ThermostatOffsetPriority = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ZonePriority")]
        ZonePriority = 5,
    }
}