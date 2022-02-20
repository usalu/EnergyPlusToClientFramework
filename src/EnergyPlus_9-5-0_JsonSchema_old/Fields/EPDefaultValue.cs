namespace EnergyPlusJsonSchemas.Fields
{
    public struct EPDefaultValue
    {
        public double? Double;
        public string String;

        public static implicit operator EPDefaultValue(double Double) => new EPDefaultValue { Double = Double };
        public static implicit operator EPDefaultValue(string String) => new EPDefaultValue { String = String };
    }
}