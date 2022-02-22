namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_Plant_LoopType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Condenser")]
        Condenser = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 3,
    }
}