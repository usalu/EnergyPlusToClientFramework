namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_Photovoltaic_PhotovoltaicPerformanceObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PhotovoltaicPerformance:EquivalentOne-Diode")]
        PhotovoltaicPerformanceEquivalentOneDiode = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PhotovoltaicPerformance:Sandia")]
        PhotovoltaicPerformanceSandia = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PhotovoltaicPerformance:Simple")]
        PhotovoltaicPerformanceSimple = 2,
    }
}