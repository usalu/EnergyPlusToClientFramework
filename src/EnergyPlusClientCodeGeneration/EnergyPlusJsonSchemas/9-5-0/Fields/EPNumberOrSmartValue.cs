namespace EnergyPlusJsonSchemas._9_5_0.Fields
{
    public struct EPNumberOrSmartValue
    {
        public EPSmartValue? Enum;
        public long? Integer;

        public static implicit operator EPNumberOrSmartValue(EPSmartValue Enum) => new EPNumberOrSmartValue { Enum = Enum };
        public static implicit operator EPNumberOrSmartValue(long Integer) => new EPNumberOrSmartValue { Integer = Integer };
    }
}