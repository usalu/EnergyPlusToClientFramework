namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_MultiZone_Surface_EquivalentRectangleMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BaseSurfaceAspectRatio")]
        BaseSurfaceAspectRatio = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PolygonHeight")]
        PolygonHeight = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="UserDefinedAspectRatio")]
        UserDefinedAspectRatio = 3,
    }
}