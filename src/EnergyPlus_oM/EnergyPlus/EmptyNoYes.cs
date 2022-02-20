namespace BH.oM.Adapters.EnergyPlus
{
    using System.ComponentModel;
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using BH.oM.Base;
    
    
    public enum EmptyNoYes
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("No")]
        No = 1,
        
        [JsonProperty("Yes")]
        Yes = 2,
    }
}
