namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowMaterial_ComplexShade_LayerType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BSDF")]
        BSDF = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherShadingType")]
        OtherShadingType = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Perforated")]
        Perforated = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="VenetianHorizontal")]
        VenetianHorizontal = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="VenetianVertical")]
        VenetianVertical = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Woven")]
        Woven = 6,
    }
}