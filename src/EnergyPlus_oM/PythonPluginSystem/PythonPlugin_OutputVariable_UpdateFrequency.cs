namespace BH.oM.Adapters.EnergyPlus.PythonPluginSystem
{
    public enum PythonPlugin_OutputVariable_UpdateFrequency
    {
        
        [System.Runtime.Serialization.EnumMember(Value="SystemTimestep")]
        SystemTimestep = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneTimestep")]
        ZoneTimestep = 1,
    }
}