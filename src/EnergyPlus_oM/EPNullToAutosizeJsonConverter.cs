using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergyPlus_oM.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EnergyPlus_oM
{
    public class EPNullToAutosizeJsonConverter : JsonConverter<double?>
    {
        public EPNullToAutosizeJsonConverter()
        {
        }

        public override void WriteJson(JsonWriter writer, double? value, JsonSerializer serializer)
        {
            double autosizeValue;
            double.TryParse(Resources.autosizableValue, out autosizeValue);
            if (value == autosizeValue)
            {
                writer.WriteRawValue("\"Autosize\"");
            }
            else
            {
                JToken t = JToken.FromObject(value);
                t.WriteTo(writer);
            }
        }

        public override double? ReadJson(JsonReader reader, Type objectType, double? existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

    //public class EPNullToAutosizeJsonConverter : JsonConverter
    //{
    //    public EPNullToAutosizeJsonConverter()
    //    {

    //    }

    //    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    //    {
    //        if (value==null)
    //        {
    //            writer.WriteRawValue("Autosize");
    //        }
    //        else
    //        {
    //            JToken t = JToken.FromObject(value);
    //            t.WriteTo(writer);
    //        }
    //    }

    //    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override bool CanConvert(Type objectType)
    //    {
    //        return (objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>) && objectType.GetGenericArguments()[0]==typeof(float));
    //    }
    //}
}
