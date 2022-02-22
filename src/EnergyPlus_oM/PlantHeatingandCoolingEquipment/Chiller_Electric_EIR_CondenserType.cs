namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum Chiller_Electric_EIR_CondenserType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirCooled")]
        AirCooled = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="EvaporativelyCooled")]
        EvaporativelyCooled = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="WaterCooled")]
        WaterCooled = 3,
    }
}