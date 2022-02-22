namespace BH.oM.Adapters.EnergyPlus.PythonPluginSystem
{
    public enum PythonPlugin_OutputVariable_GroupType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Building")]
        Building = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="HVAC")]
        HVAC = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Plant")]
        Plant = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="System")]
        System = 3,
    }
}