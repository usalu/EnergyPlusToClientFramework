namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum HeatExchanger_FluidToFluid_ControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingDifferentialOnOff")]
        CoolingDifferentialOnOff = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingSetpointModulated")]
        CoolingSetpointModulated = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingSetpointOnOff")]
        CoolingSetpointOnOff = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingSetpointOnOffWithComponentOverride")]
        CoolingSetpointOnOffWithComponentOverride = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="DualDeadbandSetpointModulated")]
        DualDeadbandSetpointModulated = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="DualDeadbandSetpointOnOff")]
        DualDeadbandSetpointOnOff = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingSetpointModulated")]
        HeatingSetpointModulated = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingSetpointOnOff")]
        HeatingSetpointOnOff = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="OperationSchemeModulated")]
        OperationSchemeModulated = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="OperationSchemeOnOff")]
        OperationSchemeOnOff = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="UncontrolledOn")]
        UncontrolledOn = 11,
    }
}