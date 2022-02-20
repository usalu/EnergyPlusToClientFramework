using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    public enum ConnectorList_Connector2ObjectType
    {
        
        [JsonProperty("Connector:Mixer")]
        ConnectorMixer = 0,
        
        [JsonProperty("Connector:Splitter")]
        ConnectorSplitter = 1,
    }
}