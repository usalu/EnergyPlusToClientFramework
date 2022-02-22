using System.Reflection;
using Newtonsoft.Json.Serialization;

namespace EnergyPlus_oM
{
    public class NullToEmptyStringValueProvider : IValueProvider
    {
        PropertyInfo _MemberInfo;

        public NullToEmptyStringValueProvider(PropertyInfo memberInfo)
        {
            _MemberInfo = memberInfo;
        }

        public object GetValue(object target)
        {
            object result = _MemberInfo.GetValue(target);
           if (_MemberInfo.PropertyType.IsEnum)
                if (result == null || result.ToString() == "Empty")
                    result = "";
            return result;

        }

        public void SetValue(object target, object value)
        {
            _MemberInfo.SetValue(target, value);
        }
    }
}