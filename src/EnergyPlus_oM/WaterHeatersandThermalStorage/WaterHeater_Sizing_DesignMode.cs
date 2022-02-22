namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_Sizing_DesignMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PeakDraw")]
        PeakDraw = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PerFloorArea")]
        PerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PerPerson")]
        PerPerson = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PerSolarCollectorArea")]
        PerSolarCollectorArea = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PerUnit")]
        PerUnit = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ResidentialHUD-FHAMinimum")]
        ResidentialHUDFHAMinimum = 5,
    }
}