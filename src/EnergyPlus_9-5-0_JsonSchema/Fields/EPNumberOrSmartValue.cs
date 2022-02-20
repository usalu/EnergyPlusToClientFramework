namespace EnergyPlus_9_5_0_JsonSchema.Fields
{
    public struct EPNumberOrSmartValue
    {
        public EPSmartValue? Enum;
        public long? Integer;

        public static implicit operator EPNumberOrSmartValue(EPSmartValue Enum) => new EPNumberOrSmartValue { Enum = Enum };
        public static implicit operator EPNumberOrSmartValue(long Integer) => new EPNumberOrSmartValue { Integer = Integer };
    }
}