namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum ElectricLoadCenter_Transformer_TransformerUsage
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LoadCenterPowerConditioning")]
        LoadCenterPowerConditioning = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerInFromGrid")]
        PowerInFromGrid = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PowerOutToGrid")]
        PowerOutToGrid = 3,
    }
}