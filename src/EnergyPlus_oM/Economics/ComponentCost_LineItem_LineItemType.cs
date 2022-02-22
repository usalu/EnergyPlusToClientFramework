namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum ComponentCost_LineItem_LineItemType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Chiller:Electric")]
        ChillerElectric = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:DX")]
        CoilDX = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Fuel")]
        CoilHeatingFuel = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Construction")]
        Construction = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Daylighting:Controls")]
        DaylightingControls = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="General")]
        General = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Generator:Photovoltaic")]
        GeneratorPhotovoltaic = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Lights")]
        Lights = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Shading:Zone:Detailed")]
        ShadingZoneDetailed = 9,
    }
}