namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_Photovoltaic_HeatTransferIntegrationMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Decoupled")]
        Decoupled = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DecoupledUllebergDynamic")]
        DecoupledUllebergDynamic = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="IntegratedExteriorVentedCavity")]
        IntegratedExteriorVentedCavity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="IntegratedSurfaceOutsideFace")]
        IntegratedSurfaceOutsideFace = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="IntegratedTranspiredCollector")]
        IntegratedTranspiredCollector = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="PhotovoltaicThermalSolarCollector")]
        PhotovoltaicThermalSolarCollector = 6,
    }
}