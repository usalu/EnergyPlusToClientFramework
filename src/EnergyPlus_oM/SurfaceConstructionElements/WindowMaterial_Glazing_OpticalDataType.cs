namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowMaterial_Glazing_OpticalDataType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="BSDF")]
        BSDF = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Spectral")]
        Spectral = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SpectralAndAngle")]
        SpectralAndAngle = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SpectralAverage")]
        SpectralAverage = 3,
    }
}